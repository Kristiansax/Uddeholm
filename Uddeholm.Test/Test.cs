using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uddeholm.Core.Entites;
using Uddeholm.Core.Repositories;

namespace Uddeholm.Test
{
    [TestClass]
    public class Test
    {
        CoatingRepository CoatingRepository = new CoatingRepository();
        PriceRepository PriceRepository = new PriceRepository();
        SteelRepository SteelRepository = new SteelRepository();

        /* ========================== Testing files ========================== */

        [TestMethod]
        public void FilesExist()
        {
            string startupPath = Environment.CurrentDirectory;
            Assert.IsTrue(File.Exists(startupPath+@"\factors.xlsx"));
            Assert.IsTrue(File.Exists(startupPath+@"\PVD.xlsx"));
        }

        /* ========================= Testing coatings ======================== */

        [TestMethod]
        public void CanPutCoatingsIntoList()
        {
            Assert.IsTrue(CoatingRepository.GetAllCoatings().Count > 0);
        }

        [TestMethod]
        public void CanGetCoatingFactorFromName()
        {
            Assert.AreEqual(1.4, CoatingRepository.GetCoating("SISTRAL").factor);
        }

        /* ========================== Testing Steel ========================= */

        [TestMethod]
        public void CalculateVolumeOfRoundSteel()
        {
            Steel steel = new Steel()
            {
                IsRound = true,
                Width = 20,
                Length = 20
            };

            Assert.AreEqual(6.28, Math.Round(steel.GetVolume(), 2));
        }

        [TestMethod]
        public void CalculateVolumeOfSquareSteel()
        {
            Steel steel = new Steel()
            {
                IsRound = false,
                Height = 20,
                Width = 20,
                Length = 20
            };

            Assert.AreEqual(8, steel.GetVolume());
        }

        /* ========================== Testing Prices ========================= */

        [TestMethod]
        public void CanPutPricesIntoList()
        {
            Assert.IsTrue(PriceRepository.GetAllPrices().Count > 0);
        }

        [TestMethod]
        public void GetGetCorrectPriceFromVolume()
        {
            Assert.AreEqual(3.71, PriceRepository.GetPrice(81).PriceCM3);
        }

        /* ======================= Testing Total Price ======================= */

        [TestMethod]
        public void CanCalculateTotalPrice()
        {
            Steel steel = new Steel()
            {
                IsRound = false,
                Width = 20,
                Height = 20,
                Length = 20
            };

            Price price = PriceRepository.GetPrice(steel.GetVolume());

            Coating coating = CoatingRepository.GetCoating("SISTRAL");

            Assert.AreEqual(98.56, steel.GetPrice(coating, price));
        }

        [TestMethod]
        public void CanCalculateRoundObject()
        {
            Steel steel = new Steel()
            {
                IsRound = true,
                Width = 25,
                Length = 40.03
            };

            Price price = PriceRepository.GetPrice(steel.GetVolume());

            Coating coating = CoatingRepository.GetCoating("CROSAL Duplex");

            Assert.AreEqual(326.59, steel.GetPrice(coating, price));
        }
    }
}
