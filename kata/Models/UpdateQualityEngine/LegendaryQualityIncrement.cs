using kata.Models.Interface;

namespace kata.Models.UpdateQualityEngine
{
    public class LegendaryQualityIncrement : IUpdateQualityEngine
    {
        public int UpdateQuality(int oldQuality, int sellIn)
        {
            return oldQuality;
        }
    }
}
