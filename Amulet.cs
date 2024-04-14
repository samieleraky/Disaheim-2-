namespace Pisaheim
{
     public class Amulet
    {
        public string _itemId;
        public string _design;
        public Level _quality;

        // Constructors
        public Amulet(string itemId, Level quality = Level.medium, string design = "")
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
            return $"ItemId: {_itemId}, Quality: {_quality}, Design: {_design}";
        }
    }
}
