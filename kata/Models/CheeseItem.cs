using kata.Models.Base;

namespace kata.Models
{
    public class CheeseItem : Item
    {
        public override void UpdateQuality()
        {
            this.SellIn = this.SellIn - 1;
            if (this.SellIn < 0)
            {
                this.Quality = this.Quality + 2;
            }
            else
            {
                this.Quality = this.Quality + 1;
            }

            this.Quality = this.Quality >= 50 ? 50 : this.Quality;
        }
    }
}
