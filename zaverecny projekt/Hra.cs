using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaverecny_projekt
{
    internal class Hra
    {
        public int SkoreHrac { get; set; }
        public int SkoreNepritel { get; set; }
        public Random generatorVoleb = new Random();
        
   
        public Hra()
        {
            SkoreHrac = 0;
            SkoreNepritel = 0;
        }
   
    }
}
