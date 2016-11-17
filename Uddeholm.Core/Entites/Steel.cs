using System;

namespace Uddeholm.Core.Entites
{
    public class Steel
    {
        public bool IsRound { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }

        public double GetVolume()
        {
            double result;

            if (IsRound)
                result = ((Height * Math.PI) * ((Width / 2) * (Width / 2)) / 1000);
            else
                result = (Width * Length * Height) / 1000;

            return Math.Round(result, 2);
        }
    }
}
