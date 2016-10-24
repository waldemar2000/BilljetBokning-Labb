using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilljetBokning_Labb
{
    class Filmer : AvilableEvents
    {

       


        public override string ToString()
        {
            return String.Format("{0} Datum: {1} Kategori: {2}  Pris: {3}Kr", MovieName, EventDate, EventCatergory, EventPrice);
        }




    }
}
