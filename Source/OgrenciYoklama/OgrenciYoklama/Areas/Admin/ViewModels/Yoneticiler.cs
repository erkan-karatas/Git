﻿using OgrenciYoklama.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OgrenciYoklama.Areas.Admin.ViewModels
{
    public class YoneticilerYoneticiListele
    {
        public IEnumerable<Yonetici> Yoneticiler { get; set; }
    }

}