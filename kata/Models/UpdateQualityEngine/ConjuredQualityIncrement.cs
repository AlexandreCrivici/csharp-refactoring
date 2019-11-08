using kata.Models.Interface;

namespace kata.Models.UpdateQualityEngine
{
    class ConjuredQualityIncrement : IUpdateQualityEngine
    {
        public int UpdateQuality(int oldQuality, int sellIn)
        {
            if (sellIn < 0)
            {
                oldQuality = oldQuality - 4;
            }
            else
            {
                oldQuality = oldQuality - 2;
            }

            oldQuality = oldQuality <= 0 ? 0 : oldQuality;

            return oldQuality;
        }
    }
}
