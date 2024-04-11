using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disaheim
{
    public class Amulet
    {
        // Private fields
        public string _itemId;
        public string _design;
        public Level _quality; // Corrected the declaration of _quality

        // Constructors
        public Amulet(string itemId)
        {
            _itemId = itemId;
        }

        public Amulet(string itemId, Level quality)
        {
            _itemId = itemId;
            _quality = quality;
        }

        public Amulet(string itemId, Level quality, string design)
        {
            _itemId = itemId;
            _quality = quality;
            _design = design;
        }

        // Properties
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        public string Design
        {
            get { return _design; }
            set { _design = value; }
        }

        public Level Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }

        // ToString method override
        public override string ToString()
        {
            return $"Amulet: ItemId - {_itemId}, Design - {_design}, Quality - {_quality}";
        }
    }
}
