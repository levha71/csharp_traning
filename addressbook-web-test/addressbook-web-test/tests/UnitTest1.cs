﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace addressbook_web_test.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double total = 1500;
            bool vipClient = true;

            if(total > 1000 && vipClient)
            {
                total = total * 0.9;
                System.Console.Out.Write("Скидка 10%, общая сумма " + total);
            }
            
        }
    }
}
