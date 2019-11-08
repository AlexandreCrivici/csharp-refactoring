using kata.Models.Base;
using kata.Models.UpdateQualityEngine;

namespace kata.Models
{
    public class LegendaryItem : Item
    {
        public LegendaryItem()
        {
            _updateQualityEngine = new LegendaryQualityIncrement();
        }
    }
}
