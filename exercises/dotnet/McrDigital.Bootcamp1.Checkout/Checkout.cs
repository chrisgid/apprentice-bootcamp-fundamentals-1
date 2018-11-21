namespace McrDigital.Bootcamp1.Checkout
{
    public class Checkout
    {
        private int _total;
        private int _numberOfA;
        private int _numberOfB;
        private int _numberOfC;
        private Receipt _receipt = new Receipt();

        public string Receipt
        {
            get => this._receipt.Text;
        }

        public int Total
        {
            get => this._total;
        }

        public void Scan(Item item)
        {
            if ("A".Equals(item.Sku))
            {
                this._total += 50;
                this._receipt.ScannedA();
            }
            else if ("B".Equals(item.Sku))
            {
                this._total += 30;
                this._receipt.ScannedB();
            }
            else if ("C".Equals(item.Sku))
            {
                this._total += 20;
                this._receipt.ScannedC();
            }
            else if ("D".Equals(item.Sku))
            {
                this._total += 15;
                this._receipt.ScannedD();
            }


            if ("A".Equals(item.Sku))
            {
                this._numberOfA++;
                if (this._numberOfA % 3 == 0)
                {
                    this._total -= 20;
                }
            }
            else if ("B".Equals(item.Sku))
            {
                this._numberOfB++;
                if (this._numberOfB % 2 == 0)
                {
                    this._total -= 15;
                }
            }
            else if ("C".Equals(item.Sku))
            {
                this._numberOfC++;
                if (this._numberOfC % 4 == 0)
                {
                    this._total -= 10;
                }
            }
        }
    }
}