using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilljetBokning_Labb
{
    class Festivaler : AvilableEvents
    {


        
        public int EventLength { get; set; }

        public override string ToString()
        {
            return String.Format(" {0} Datum: {1} Kategori: {2} Längd: {3} dagar Pris: {4}Kr", EventName, EventDate, EventCatergory, EventLength, EventPrice);
        }
    }
}
