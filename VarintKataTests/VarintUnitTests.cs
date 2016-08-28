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
            string binaryRepresentationActual = varint.ConvertIntToVarint(1);
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
            string binaryRepresentationActual = varint.ConvertIntToVarint(20);
            string binaryRepresentationExpected = "10100";

            // ASSERT
            Assert.AreEqual(binaryRepresentationExpected, binaryRepresentationActual);
        }

        [TestMethod]
        public void Given_TwoBytesInt_When_ConvertNumber300ToVarint_Then_ReturnCorrectResult()
        {
            // ARRANGE
            Varint varint = new Varint();

            // ACT
            string binaryRepresentationActual = varint.ConvertIntToVarint(300);
            string binaryRepresentationExpected = "10101100 00000010";

            // ASSERT
            Assert.AreEqual(binaryRepresentationExpected, binaryRepresentationActual);
        }

        [TestMethod]
        public void Given_TwoBytesInt_When_ConvertNumber524ToVarint_Then_ReturnCorrectResult()
        {
            // ARRANGE
            Varint varint = new Varint();

            // ACT
            string binaryRepresentationActual = varint.ConvertIntToVarint(524);
            string binaryRepresentationExpected = "10001100 00000100";

            // ASSERT
            Assert.AreEqual(binaryRepresentationExpected, binaryRepresentationActual);
        }

        [TestMethod]
        public void Given_MoreThanTwoBytesInt_When_ConvertNumber784000ToVarint_Then_ReturnCorrectResult()
        {
            // ARRANGE
            Varint varint = new Varint();

            // ACT
            string binaryRepresentationActual = varint.ConvertIntToVarint(784000);
            string binaryRepresentationExpected = "10000000 11101101 00101111";

            // ASSERT
            Assert.AreEqual(binaryRepresentationExpected, binaryRepresentationActual);
        }
    }
}
