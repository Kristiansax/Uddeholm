using System;
using Uddeholm.Core.Entites;
using Uddeholm.Core.Repositories;

namespace Uddeholm.Core.Entites
{
    public class Steel
    {
        public bool IsRound { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public int Quantity { get; set; }

        public double GetVolume()
        {
            double result;

            if (IsRound)
                result = ((Length * Math.PI) * ((Width / 2) * (Width / 2)) / 1000);
            else
                result = (Width * Length * Height) / 1000;

                return result;
        }

        public double GetPrice(Coating coating, Price price)
        {
            double subprice = price.PriceCM3 * GetVolume();
            double newprice = subprice * coating.factor;

            return Math.Round(newprice, 2);
        }
    }
}
