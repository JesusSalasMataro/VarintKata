using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VarintKata.Entities;

namespace VarintKataTests
{
    [TestClass]
    public class VarintUnitTests
    {
        [TestMethod]
        public void Given_SingleByteInt_When_ConvertToVarint_Then_ReturnCorrectResult()
        {
            // ARRANGE
            Varint varint = new Varint();

            // ACT
            string binaryRepresentationActual = varint.ConvertVarToInt(1);
            string binaryRepresentationExpected = "00000001";

            // ASSERT
            Assert.AreEqual(binaryRepresentationExpected, binaryRepresentationActual);
        }
    }
}
