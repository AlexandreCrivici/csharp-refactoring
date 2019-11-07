using kata.Models.Base;

namespace kata.Models
{
    public class NormalItem : Item
    {
        public override void UpdateQuality()
        {
            this.SellIn = this.SellIn - 1;
            if (this.SellIn < 0)
            {
                this.Quality = this.Quality - 2;
            }
            else
            {
                this.Quality = this.Quality - 1;
            }

            this.Quality = this.Quality <= 0 ? 0 : this.Quality;
        }
    }
}
