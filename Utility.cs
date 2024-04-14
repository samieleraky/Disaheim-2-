using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pisaheim
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book), "The book parameter cannot be null.");
            }

            return book.Price;
        }




        public double GetValueOfAmulet(Amulet amulet)
        {
            if (amulet == null)
            {
                throw new ArgumentException(nameof(amulet), "the amulet parameter cannot be null.");

            }

            switch (amulet.Quality)
            {
                case Level.low:
                    return 12.5;
                case Level.medium:
                    return 20.0;
                case Level.high:
                    return 27.5;
                default:
                    throw new InvalidOperationException("Invalid amulet quality");


            }
        }
    }

}

   

