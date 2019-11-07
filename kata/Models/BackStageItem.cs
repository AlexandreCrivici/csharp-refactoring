using kata.Models.Base;

namespace kata.Models
{
    public class BackStageItem : Item
    {
        public override void UpdateQuality()
        {
            this.SellIn = this.SellIn - 1;

            if (this.SellIn < 10 && this.SellIn >= 5)
            {
                this.Quality = this.Quality + 2;
            }
            else
            {
                if (this.SellIn < 5 && this.SellIn >= 0)
                {
                    this.Quality = this.Quality + 3;
                }
                else
                {
                    if (this.SellIn < 0)
                    {
                        this.Quality = 0;
                    }
                    else
                    {
                        this.Quality = this.Quality + 1;
                    }
                }
            }

            this.Quality = this.Quality >= 50 ? 50 : this.Quality;
        }
    }
}
