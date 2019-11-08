using kata.Models.Base;
using kata.Models.UpdateQualityEngine;

namespace kata.Models
{
    public class ConjuredItem : Item
    {
        public ConjuredItem()
        {
            _updateQualityEngine = new ConjuredQualityIncrement();
        }
    }
}
