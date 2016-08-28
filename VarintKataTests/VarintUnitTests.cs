using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VarintKata.Entities;

namespace VarintKataTests
{
    [TestClass]
    public class VarintUnitTests
    {
        [TestMethod]
        public void Given_SingleByteInt_When_ConvertNumber1ToVarint_Then_ReturnCorrectResult()
        {
            // ARRANGE
            Varint varint = new Varint();

            // ACT
            string binaryRepresentationActual = varint.ConvertVarToInt(1);
            string binaryRepresentationExpected = "1";

            // ASSERT
            Assert.AreEqual(binaryRepresentationExpected, binaryRepresentationActual);
        }

        [TestMethod]
        public void Given_SingleByteInt_When_ConvertNumber20ToVarint_Then_ReturnCorrectResult()
        {
            // ARRANGE
            Varint varint = new Varint();

            // ACT
            string binaryRepresentationActual = varint.ConvertVarToInt(20);
            string binaryRepresentationExpected = "10100";

            // ASSERT
            Assert.AreEqual(binaryRepresentationExpected, binaryRepresentationActual);
        }
    }
}
