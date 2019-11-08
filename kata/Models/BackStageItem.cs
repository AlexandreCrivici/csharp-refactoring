using kata.Models.Base;
using kata.Models.UpdateQualityEngine;

namespace kata.Models
{
    public class BackStageItem : Item
    {
        public BackStageItem()
        {
            _updateQualityEngine = new BackStageQualityIncrement();
        }
    }
}
