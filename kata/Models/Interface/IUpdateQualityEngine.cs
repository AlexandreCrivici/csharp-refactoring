namespace kata.Models.Interface
{
    public interface IUpdateQualityEngine
    {
        /// <summary>
        /// Update the quality value
        /// </summary>
        /// <param name="oldQuality"></param>
        /// <param name="sellIn"></param>
        /// <returns></returns>
        int UpdateQuality(int oldQuality, int sellIn);
    }
}
