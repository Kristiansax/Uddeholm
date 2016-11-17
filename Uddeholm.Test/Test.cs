﻿using System;
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
        PriceRepository   PriceRepository   = new PriceRepository();
        //SteelRepository   SteelRepository   = new SteelRepository();

        /* ========================== Testing files ========================== */

        [TestMethod]
        public void FilesExist()
        {
            Assert.IsTrue(File.Exists(@"F:\Uddeholm\Uddeholm.Test\bin\Debug\factors.xlsx"));
            Assert.IsTrue(File.Exists(@"F:\Uddeholm\Uddeholm.Test\bin\Debug\PVD.xlsx"));
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
                Height = 20,
                Width = 20
            };

            Assert.AreEqual(6.28, steel.GetVolume());
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
            
        }
    }
}
