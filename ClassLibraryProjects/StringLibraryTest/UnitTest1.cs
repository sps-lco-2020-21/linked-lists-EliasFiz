using System;
using LinkedListExample.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListExample.Tests
{
    [TestClass]
    public class BasicLinkedListTests
    {

        // Unit test work just make sure you are debugging in the right folder
        [TestMethod]
        public void TestEmpty()
        {
            IntegerLinkedList ill = new IntegerLinkedList();
            Assert.AreEqual(0, ill.Count);
        }

        [TestMethod]
        public void TestCount()
        {
            var ill = new IntegerLinkedList(5);
            ill.Append(7);
            ill.Append(9);
            Assert.AreEqual(3, ill.Count);
        }

        [TestMethod]
        public void TestSum()
        {
            var ill = new IntegerLinkedList(5);
            ill.Append(7);
            ill.Append(9);
            Assert.AreEqual(21, ill.Sum);
        }

        [TestMethod]
        public void TestToStringExplicit()
        {
            var ill = new IntegerLinkedList(5);
            ill.Append(7);
            ill.Append(8);
            ill.Append(9);
            Assert.AreEqual("{5, 7, 8, 9}", ill.ToStr);
        }

    }
}