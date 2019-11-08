using kata.Models.Base;
using kata.Models.UpdateQualityEngine;

namespace kata.Models
{
    public class CheeseItem : Item
    {
        public CheeseItem()
        {
            _updateQualityEngine = new CheeseQualityIncrement();
        }
    }
}
