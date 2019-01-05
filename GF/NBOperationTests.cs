﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;


namespace GF
{
    [TestFixture]
    class NBOperationTests
    {

        [Test]
        [TestCase("01000011110111001100100100000110000000011000011000100111011001000010010011010001011010000000110110101111110110111101101101011000010010011110111110001110000001100001010100011101001011111000000101111110101010111101111100001001010101000010100100011110111010110101111011010011010001000011010110011110111011111011000010001100111011101101110010001100100100110010111100010010011011101101111100010001010011101100100001010001000001010010110",
                  "10010010101001100100000110001111111001011001001100100011111100100001100100011000001011101101010010100010101111000000110000111110010110011101110000011101010110000010110111100101110110010001111010001111111000110000011101000011010011011111000010010110100101111111100010011100001000101100100000100001000011000011001000011001111110010001100010101001001111001100110010010001011011000101110111001001101100011010100101010001011001010010110",
                  "00101110111000101010001100111101100001000010100111100101000010001100010100010001101101000101100111110000011110000001000001000011100111111001101000111111000110100111110101111011101101101000011011110110100101000011000100101000011001110101011011101001001110110111101101111110110001000101000011110111010100101011101110111110110100000111111100010001100101100010011100000100101010011011001111101110100011001111001010111000000000100110001")]
        [TestCase("11000011101110001001010010100110111111010110000101010100101000110001010000110101100101101011100110000101011110111101001000100000011011101010000110000011010110001111010001010100011111111100000100110100011101011100001000000101000111010101110000011110000011110011010101101010001011111000111011010010101100000111101110111111101011000010000010111010110001000010011000110011111011010001001000101100100110101011010111100010101111110000011",
                  "10011011111110110011010001011101011100100001101011101011001001001111110111010101111011101101100110001011001001000110100101000111010101101010010110111101111100111100010100111000100011001110111100001000010011110111010110001010001101011110100110111110100010001111110101100010101001001110001101000010100111101011001110011011011111001010000010011111100100110001110011100011100000111000000000110000110010100101110011000000000011111000100",
                  "10111011010100000000010110001100100100101111010010010010000111110101010111001010000110100001011101010011001100001011101001110010010110000100011100100100110010001101110011100110010000010000111010100001011011101101100100011011101111010011111111111111010110010100111110010110111010110000100111110110100100011001101010100001011010111111010010011110101000111010010111001000010001000111101001000010101111011000000110101110111010000101111")]
        [TestCase("00111101001011110010010100111011110111100000000010010101101111100011110010000011011100100101101001111010111000000100110110101101000100011011001100101001001100010011001101000110011010101010100110011011110101101001111010000000000011000010111110110110110110101111010001001011110011110111110111011000011111001011100010000011001110001110110000001011011110101010101000101100010011111010011000001110011010010111100101011110011000011111101",
                  "10010100101101101010011000111101110111110010111011110000110011010010111111011000000011101100010011110100100100010100110011111101000000010111110001000011000010010110011111000010101110101101001011000111001101000111100100010011000111101100010101110101111001111110100001110010101110011111110101011110100111001010110000001001111101111111111000100001110101001010011100100100100000111011111011111010110010000100000000100010011101100110010",
                  "11010001001010011100111010111101001000000001100101011101010011110110111010101100101011111000001000001011111100011001010000101100000001010010000011011111001111100010100011000011111011101010101101110000100101001110111101110110111010010111011110101101111110011100110110111011000100010111000111111110011110011111000110110110000100011101110000000110000111000000000110110011100111001100011100001101000011111100111111111101100001001110000")]
        [TestCase("00100111100111100010100000101111101100010000011011010001110011110011101110111011010111011111011000010111011101001111100000101100011010000000101010011100101001010010011010000110001010000001101011100011100100110010001101000100000001100001100110110101101111110111011110101111000011000011010111000110111111101110000000001001110001101000111001011011000111011001110111010101100100001001011010111101101110101000011000010000011111010010110",
                  "10100000010111101010000001111101010110110001100000101111011001001111110000000101011110011000110010010001100001000111111001111101000011111100010110110110010000001010100111100010101101010010101100110111000000001001010010011010000110100000100000111110001110111100110011010000010011000011000000010100010110100111100000101110110010011110010001100010011101100000010010000101011001110111101110000101100011000111000000000001001101000001010",
                  "10001010101110100001000101101010100101010100011110110011111000001000110001001001111001100011011010001011101011011010000001000101001101001100101101101101100101001111000001000010110000000110110010001001111101111101000000111010010111011001000110000011001011011010010111001100000010000000010001010010011001101001100110001110010100100100110000000100000001100001011011111000110101101110001111100111111000000111001111101110010010000100110")]
        [TestCase("01001000001010110000011011101100010101100111110110101000110100010110001111100111110010111101111101100100001010010101101111010101000100101101101110101000111110110010001101000001001000001100010110011010110111100111000000001000110011111000110001110100100111000011000111001000111101011001011111101010011001100001110000100100100011100000111000111111000010010100001110101000101100000011000000111011001011010101111001011111000110010011001",
                  "01000000100111011000001000110100101011111100001101100100110000010101010101110001010100000100111111100100010011110111011011000110010110100011001011110001010110001111111111111001001111111000111100111110111001000110000100110100010111001111000011111100101000101001110001010011101011100010100111000010001110111110110001101111110000001000001010001100111001111110110010100100110110000010101101001011000110011010011101100010000010011111101",
                  "10100101011010010111101111000110110011110011100000110111100011001111001010110001100110100010001010100001100000000000011100010000001010101110001010010111111100010011101011100000010110100110001100111011100011000100111111100101101100111110010000001110111011100110000110011011001010111111110011100100011010010011110010111010110110111101000101011110100110011000110000000100101000000111010100001110011110001011111001110011110100110100110")]
        [TestCase("11111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111",
                  "10010010101001100100000110001111111001011001001100100011111100100001100100011000001011101101010010100010101111000000110000111110010110011101110000011101010110000010110111100101110110010001111010001111111000110000011101000011010011011111000010010110100101111111100010011100001000101100100000100001000011000011001000011001111110010001100010101001001111001100110010010001011011000101110111001001101100011010100101010001011001010010110",
                  "10010010101001100100000110001111111001011001001100100011111100100001100100011000001011101101010010100010101111000000110000111110010110011101110000011101010110000010110111100101110110010001111010001111111000110000011101000011010011011111000010010110100101111111100010011100001000101100100000100001000011000011001000011001111110010001100010101001001111001100110010010001011011000101110111001001101100011010100101010001011001010010110")]
        public void MulTest(string bin1, string bin2, string expectedResult)
        {
            NBNumber a = new NBNumber(bin1);
            NBNumber b = new NBNumber(bin2);
            var res = NBOperations.Mul(a, b);
            var actualResult = res.BitSTR();
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        [TestCase("00010000000001100111110000110010000010111001101101101011010110110101101100110101111011111100010111101011001011100101110110010011001100101000100100101001001111011000000110001101101011110011011000101110011000001101100011110100110100101011100000111101000111111110111010110001000011000111010110001101001101011001101110110110110011000011010110111100101001001010010100110011010010101001110000101111110100110111110010001000110001011011010",
                  "00101010100010001011000110011101001110100000011101000000101110100110101111001101001110010000010011010100011010101111011101100101000000000110000010101110010000011011001100011001010111110001111101100111100101100110101110001110000111100011110100101110001101101110100100100110011000001000110000010011000011000011000111111001010111111100111101000011101010011111011110110111110100110011011100101011010010010010000110111110101110000101001",
                  "00011010110100100101111010011101001000011011100010001111011111101010001001110010110000110110010101000111100101010111110001100101110000001011110110100001010000110111101110000001110010001111011100111111001001010110111010000000110011001111011111111110011110010100010010100101101000111111110111111100011111001000000000011111111000100001000010000101001110110101000110000110101001011001110110101010100000110110010000010000010001000111100")]
        [TestCase("",
                  "",
                  "")]
        [TestCase("",
                  "",
                  "")]
        [TestCase("",
                  "",
                  "")]
        [TestCase("",
                  "",
                  "")]
        public void PowTest(string bin1, string bin2, string expectedResult)
        {
            NBNumber a = new NBNumber(bin1);
            NBNumber b = new NBNumber(bin2);
            var res = NBOperations.Pow(a, b);
            var actualResult = res.BitSTR();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}