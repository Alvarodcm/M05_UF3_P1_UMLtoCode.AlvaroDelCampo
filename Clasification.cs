using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05_UF3_P1_UMLtoCode.AlvaroDelCampo
{
    internal class Classification
    {
        private string HighCat { get; set; }
        private string LowCat { get; set; }
        private string HighSubcat { get; set; }
        private string LowSubcat { get; set; }

        public Classification(string highCat, string lowCat, string highSubcat, string lowSubcat)
        {
            this.HighCat = highCat;
            this.LowCat = lowCat;
            this.HighSubcat = highSubcat;
            this.LowSubcat = lowSubcat;
        }
    }
}
