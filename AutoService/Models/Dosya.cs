using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    public class Dosya
    {
        public int id { get; set; }
        public string Ad { get; set; }
        public string Path { get; set; }
        public int KategoriID { get; set; }
        public int AracID { get; set; }
    }
}
