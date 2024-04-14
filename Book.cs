using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pisaheim
{
    public class Book
    {

        public string _ItemId;
        public string _Title;
        public double _price;

        //Constructors
        public Book(string itemId)
        {
            _ItemId = itemId;
        }

        public Book(string itemId, string title)
        {
            _ItemId = itemId;
            _Title = title;
        }

        public Book(string itemId, string title, double price)
        {
            _ItemId = itemId;
            _Title = title;
            _price = price;

        }

        //properties
        public string Itemid
        { get { return _ItemId; } }

        public string Title
        { get { return _Title; } }

        public double Price
        { get { return _price; } }

        public override string ToString()
        {
            return $"ItemId: {_ItemId}, Title: {_Title}, Price: {_price}";
            //Assert.AreEqual("ItemId: 2, Title: Falling in Love with Yourself, Price: 0", b2.ToString());
        }
    }

}
