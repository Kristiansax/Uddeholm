using System;
using System.Collections.Generic;
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
        public PriceRepository PR { get; set; }
        public double BasePrice
        {
            get
            {
                return PR.GetPrice(GetVolume()).PriceCM3 * GetVolume();
            }
        }

        public Steel(PriceRepository pr)
        {
            PR = pr;
        }

        public Steel() { }

        public double GetVolume()
        {
            double result;

            if (IsRound)
                result = ((Length * Math.PI) * ((Width / 2) * (Width / 2)) / 1000);
            else
                result = (Width * Length * Height) / 1000;

                return result;
        }

        public double GetFinalPrice(List<Coating> c, WaterTreatment wtb, DryTreatment dtb, List<ToolType> tt, WaterTreatment wta, DryTreatment dta)
        {
            //bool IsCrosalChosen = false;

            // Price
            double price = 0;

            // Coatings
            foreach (Coating coating in c)
            {
                price += ((BasePrice * coating.factor) * Quantity);

                //if (coating.name.Contains("CROSAL"))
                //    IsCrosalChosen = true;
            }

            /* =============================== Dry og water treatment BEFORE ================================ */
            if (dtb.ToVolume != 0)
                price += GetDryTreatmentPrice(dtb);

            if (wtb.ToVolume != 0)
            {
                price += GetWaterTreatmentPrice(wtb);
            }

            /* =============================== Dry og water treatment AFTER ================================ */

            if (dta.ToVolume != 0)
                price += GetDryTreatmentPrice(dta);

            // Watertreatment BEFORE
            if (wta.ToVolume != 0)
            {
                //if (!IsCrosalChosen)
                    price += GetWaterTreatmentPrice(wta);
            }

            // Tooltypes
            foreach (ToolType tooltype in tt)
                price += ((BasePrice * tooltype.AddFactor) * Quantity);

            // Return final price
            return Math.Round(price, 2);
        }

        /* ========================================================== */

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
