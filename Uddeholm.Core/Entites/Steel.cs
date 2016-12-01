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
            double newprice = (subprice * coating.factor) * Quantity;

            return Math.Round(newprice, 2);
        }

        // Only watertreatment
        public double GetPrice(Coating coating, Price price, WaterTreatment wt)
        {
            double subprice = price.PriceCM3 * GetVolume();
            double newprice = (subprice * coating.factor) * Quantity;
            newprice += GetWaterTreatmentPrice(wt);

            return Math.Round(newprice, 2);
        }

        // Only drytreatment
        public double GetPrice(Coating coating, Price price, DryTreatment dt)
        {
            double subprice = price.PriceCM3 * GetVolume();
            double newprice = (subprice * coating.factor) * Quantity;
            newprice += GetDryTreatmentPrice(dt);

            return Math.Round(newprice, 2);
        }

        // Both treatments
        public double GetPrice(Coating coating, Price price, WaterTreatment wt, DryTreatment dt)
        {
            double subprice = price.PriceCM3 * GetVolume();
            double newprice = (subprice * coating.factor) * Quantity;
            newprice += GetDryTreatmentPrice(dt);
            newprice += GetWaterTreatmentPrice(wt);

            return Math.Round(newprice, 2);
        }

        private double GetWaterTreatmentPrice(WaterTreatment wt)
        {
            double treatmentPrice;
            switch (Quantity)
            {
                case 1:
                case 2:
                    treatmentPrice = wt.QuantityLow * Quantity;
                    break;

                case 3:
                case 4:
                case 5:
                    treatmentPrice = wt.QuantityMid * Quantity;
                    break;

                default:
                    treatmentPrice = wt.QuantityHigh * Quantity;
                    break;
            }

            return treatmentPrice;
        }

        private double GetDryTreatmentPrice(DryTreatment dt)
        {
            double treatmentPrice;
            switch (Quantity)
            {
                case 1:
                case 2:
                    treatmentPrice = dt.QuantityLow * Quantity;
                    break;

                case 3:
                case 4:
                case 5:
                    treatmentPrice = dt.QuantityMid * Quantity;
                    break;

                default:
                    treatmentPrice = dt.QuantityHigh * Quantity;
                    break;
            }

            return treatmentPrice;
        }
    }
}
