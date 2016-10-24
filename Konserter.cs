using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilljetBokning_Labb
{
    class Konserter : AvilableEvents
    {

        



        public override string ToString()
        {
            return String.Format("Artist: {0} Datum: {1} Kategori: {2} Pris: {3}Kr", ArtistName, EventDate, EventCatergory, EventPrice);
        }

    }


}



