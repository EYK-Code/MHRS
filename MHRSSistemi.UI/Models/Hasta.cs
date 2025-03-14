using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRSSistemi.UI.Models
{
    public class Hasta
    {
        public string AdSoyad { get; set; }
        public string Sikayet { get; set; }
        public Doktor Doktor { get; set; }
        public override string ToString()
        {
            return AdSoyad+" "+Sikayet+" "+Doktor;
        }

    }
}
