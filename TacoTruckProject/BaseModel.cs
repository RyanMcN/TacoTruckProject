using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacoTruckProject
{
    class BaseModel
    {
        bool _flourTortillaIsChecked;
        bool _wheatTortillaIsChecked;
        bool _chipsIsChecked;
        bool _saladIsChecked;


        public bool Flour_Tortilla { get
            {
                return _flourTortillaIsChecked;
            }
            set
            {
                _flourTortillaIsChecked = value;
            }
        }

        
        public bool Wheat_Tortilla { get; set; }

        public bool Chips { get; set; }

        public bool Salad { get; set; }
    }
}
