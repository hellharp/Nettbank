﻿using Nettbank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Nettbank.Controllers
{
    
    public class KontoController : Controller
    {
        public ActionResult OpprettKonto()
        {
            // Send bruker til innlogging dersom ikke innlogget
            if (Session["LoggetInn"] == null || false)
            {
                return RedirectToAction("/Index", "Kunde");
            }
            return View();
        }

        [HttpPost]
        public ActionResult OpprettKonto(FormCollection innListe)
        {
            // Send bruker til innlogging dersom ikke innlogget
            if (Session["LoggetInn"] == null || false)
            {
                return RedirectToAction("/Index", "Kunde");
            }

            try
            {
                using (var db = new KundeContext())
                {
                    var nyKonto = new konto();
                    // Konverter streng til double
                    nyKonto.saldo = Convert.ToDouble(innListe["Saldo"]);



                    int innKunde = Convert.ToInt32(innListe["Kontoeier"]);

                    var funnetKunde = db.Kunder.FirstOrDefault(p => p.id == innKunde);

                    //Lagre konto
                    db.Konti.Add(nyKonto);
                    db.SaveChanges();

                    //Konto i DB, legg til i kunde sin liste
                    if (funnetKunde == null)
                    {
                        // Feilhåndter
                       
                    }
                    else
                    {
                        var kontoObjekt = db.Konti.LastOrDefault();
                        if (kontoObjekt != null)
                        {
                            funnetKunde.Kontoer.Add(kontoObjekt);
                            db.SaveChanges();
                        }
                    }
                    return RedirectToAction("/Konto/ListKonti");
                }
            }
            catch (Exception feil)
            {
                return View();
            }
        }

        public ActionResult ListKonti()
        {
            // Send bruker til innlogging dersom ikke innlogget
            if (Session["LoggetInn"] == null || false)
            {
                return RedirectToAction("/Index", "Kunde");
            }

            var db = new KundeContext();
            List<konto> kontoListe = db.Konti.ToList();
            if (Session["LoggetInn"] == null)
            {
                Session["LoggetInn"] = false;
                ViewBag.Innlogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["LoggetInn"];
            }

            return View(kontoListe);
        }

    }

    public class TransaksjonController : Controller
    {
        public ActionResult RegistrerBetaling()
        {
            // Send bruker til innlogging dersom ikke innlogget
            if (Session["LoggetInn"] == null || false)
            {
                return RedirectToAction("/Index", "Kunde");
            }
            return View();
        }

        [HttpPost]
        public ActionResult RegistrerBetaling(FormCollection innTrans)
        {
            // Send bruker til innlogging dersom ikke innlogget
            if (Session["LoggetInn"] == null || false)
            {
                return RedirectToAction("/Index", "Kunde");
            }

            try
            {
                using (var db = new KundeContext())
                {
                    var nyTrans = new transaksjon();
                    nyTrans.utKonto = innTrans["UtK"];
                    nyTrans.innKonto = innTrans["InnK"];
                    nyTrans.beløp = Convert.ToInt32(innTrans["Beløp"]);
                    
                    if(innTrans["KID_Meld"] is string )
                    {
                        nyTrans.melding = innTrans["KID_Meld"];
                    }
                    else
                    {
                        nyTrans.KID = Convert.ToUInt32(innTrans["KID_Meld"]);
                    }

                    //Setter transaksjonstidspunktet og formaterer det etter britisk standard
                    nyTrans.transaksjonsTidspunkt = DateTime.Now.ToString("en-GB");

                    db.Transaksjoner.Add(nyTrans);
                    db.SaveChanges();
                    return RedirectToAction("ListKonti");
                }
            }
            catch(Exception feil)
            {
                return View();
            }
        }
    }


    public class KundeController : Controller
    {
        
        public ActionResult Index()
        {
            if(Session["LoggetInn"] == null)
            {
                Session["LoggetInn"] = false;
                ViewBag.Innlogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["LoggetInn"];
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(kunde innKunde)
        {
            if (Kunde_i_DB(innKunde))
            {
                Session["LoggetInn"] = true;
                Session["kundeId"] = innKunde.id;
                ViewBag.Innlogget = true;
                return View();
            }
            else
            {
                Session["LoggetInn"] = false;
                ViewBag.Innlogget = false;
                return View();
            }
        }

        private static bool Kunde_i_DB(kunde innKunde)
        {
            using (var db = new KundeContext())
            {
                byte[] passordDb = lagHash(innKunde.Passord);
                dbKunde funnetKunde = db.Kunder.FirstOrDefault(b => b.Passord == passordDb && b.Personnummer == innKunde.Personnummer);
                if(funnetKunde == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private static byte[] lagHash(string innPassord)
        {
            byte[] innData, utData;
            var algoritme = System.Security.Cryptography.SHA256.Create();
            innData = System.Text.Encoding.ASCII.GetBytes(innPassord);
            utData = algoritme.ComputeHash(innData);
            return utData;
        }

        public ActionResult ListKunder()
        {
            var db = new KundeContext();
            List<dbKunde> kundeListe = db.Kunder.ToList();
            return View(kundeListe);
        }


        // Metoder for oppretting av kunder/konti
        public ActionResult OpprettKunde()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OpprettKunde(FormCollection innListe)
        {
            try
            {
                using (var db = new KundeContext())
                {
                    var nyKunde = new dbKunde();
                    nyKunde.Personnummer = innListe["Personnummer"];
                    nyKunde.Fornavn = innListe["Fornavn"];
                    nyKunde.Etternavn = innListe["Etternavn"];
                    nyKunde.Adresse = innListe["Adresse"];
                    nyKunde.Passord = lagHash(innListe["Passord"]);

                    string innPostnr = innListe["Postnummer"];

                    var funnetPostSted = db.Poststeder.FirstOrDefault(p => p.Postnr == innPostnr);

                    if(funnetPostSted == null)
                    {
                        var nyttPoststed = new Models.PostSted();
                        nyttPoststed.Postnr = innListe["Postnummer"];
                        nyttPoststed.Poststed = innListe["Poststed"];
                        db.Poststeder.Add(nyttPoststed);
                    }
                    else
                    {
                        nyKunde.Poststed = funnetPostSted;
                    }
                    db.Kunder.Add(nyKunde);
                    db.SaveChanges();
                    return RedirectToAction("ListKunder");
                }
            }
            catch (Exception feil)
            {
                return View();
            }
        }

        
        




    }
}