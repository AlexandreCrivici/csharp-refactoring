using kata.Models.Base;

namespace kata.Models
{
    public class ConjuredItem : Item
    {
        public override void UpdateQuality()
        {
            this.SellIn = this.SellIn - 1;
            if (this.SellIn < 0)
            {
                this.Quality = this.Quality - 4;
            }
            else
            {
                this.Quality = this.Quality - 2;
            }

            this.Quality = this.Quality <= 0 ? 0 : this.Quality;
        }
    }
}
