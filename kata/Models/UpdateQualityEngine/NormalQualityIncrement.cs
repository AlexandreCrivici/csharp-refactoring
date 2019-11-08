using kata.Models.Interface;

namespace kata.Models.UpdateQualityEngine
{
    public class NormalQualityIncrement : IUpdateQualityEngine
    {
        /// <summary>
        /// Update the quality value of an item
        /// </summary>
        /// <param name="oldQuality">The old quality value</param>
        /// <param name="sellIn">The sellin Value</param>
        /// <returns>the new quality value</returns>
        public int UpdateQuality(int oldQuality, int sellIn)
        {
            if (sellIn < 0)
            {
                oldQuality = oldQuality - 2;
            }
            else
            {
                oldQuality = oldQuality - 1;
            }

            oldQuality = oldQuality <= 0 ? 0 : oldQuality;

            return oldQuality;
        }
    }
}
