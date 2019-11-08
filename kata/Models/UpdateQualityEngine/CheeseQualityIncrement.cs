using kata.Models.Interface;

namespace kata.Models.UpdateQualityEngine
{
    public class CheeseQualityIncrement : IUpdateQualityEngine
    {
        public int UpdateQuality(int oldQuality, int sellIn)
        {
            sellIn = sellIn - 1;
            if (sellIn < 0)
            {
                oldQuality = oldQuality + 2;
            }
            else
            {
                oldQuality = oldQuality + 1;
            }

            oldQuality = oldQuality >= 50 ? 50 : oldQuality;

            return oldQuality;
        }
    }
}
