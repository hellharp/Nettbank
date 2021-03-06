﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Model
{
    public class Transaksjon
    {
        [Key]
        [Display(Name ="Transaksjons ID")]
        public int TransaksjonsID { get; set; }

        [Display(Name ="Fra Konto")]
        [RegularExpression(@"[0-9]*", ErrorMessage = "Kontonummeret må bestå av siffer.")]
        [Required(ErrorMessage = "Velg konto du ønsker å overføre beløpet fra")]
        public string Utkonto { get; set; }

        [Display(Name ="Til Konto")]
        [RegularExpression(@"[0-9]*", ErrorMessage = "Kontonummeret må bestå av siffer.")]
        [Required(ErrorMessage = "Velg konto du ønsker å overføre beløpet til")]
        public string Innkonto { get; set; }

        [Display(Name = "Beløp")]
        [Required(ErrorMessage ="Velg beløpet som skal overføres")]
        public string Beløp { get; set; }

        [Display(Name ="KID")]
        [RegularExpression(@"[0-9]*", ErrorMessage = "KID-nummeret må bestå av siffer.")]
        public string KID { get; set; }

        [Display(Name ="Melding")]
        public string Melding { get; set; }

        [Display(Name ="Time of Transaction")]
        public string Tidspunkt { get; set; }

        public string Bekreftet { get; set; }
    }
}