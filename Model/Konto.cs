﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Model
{
    public class Konto
    {
        [Display(Name = "Kontonummer")]
        public long kontoId { get; set; }

        [Display(Name = "Kontonavn")]
        public string kontoNavn { get; set; }

        [Display(Name = "Saldo")]
        public string saldo { get; set; }

        [Display(Name = "Kundenummer")]
        public string kontoEier { get; set; }
    }
}