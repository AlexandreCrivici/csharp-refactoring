using kata.Models.Interface;

namespace kata.Models.UpdateQualityEngine
{
    public class BackStageQualityIncrement : IUpdateQualityEngine
    {
        public int UpdateQuality(int oldQuality, int sellIn)
        {
            sellIn = sellIn - 1;

            if (sellIn < 10 && sellIn >= 5)
            {
                oldQuality = oldQuality + 2;
            }
            else
            {
                if (sellIn < 5 && sellIn >= 0)
                {
                    oldQuality = oldQuality + 3;
                }
                else
                {
                    if (sellIn < 0)
                    {
                        oldQuality = 0;
                    }
                    else
                    {
                        oldQuality = oldQuality + 1;
                    }
                }
            }

            oldQuality = oldQuality >= 50 ? 50 : oldQuality;

            return oldQuality;
        }
    }
}
