using kata.Models.Base;
using kata.Models.UpdateQualityEngine;

namespace kata.Models
{
    public class NormalItem : Item
    {
        public NormalItem()
        {
            _updateQualityEngine = new NormalQualityIncrement();
        }
    }
}
