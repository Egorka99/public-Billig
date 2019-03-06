using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Number_Long__;

namespace UnitTestProject
{
    [TestClass] 
    public class Addition
    {
        [TestMethod] 
        public void TestMethod1()
        {
            BigNumbers result;   
            string exp_result; 
            exp_result = "5400"; 

            BigNumbers a1 = new BigNumbers("5000");
            BigNumbers a2 = new BigNumbers("400"); 
            result = a1 + a2;   

            Assert.AreEqual(exp_result, result.ToString()); 
        }

        [TestMethod] 
        public void TestMethod2()
        {
            BigNumbers result;
            string exp_result;
            exp_result = "0";

            BigNumbers a1 = new BigNumbers("0");
            BigNumbers a2 = new BigNumbers("0");
            result = a1 + a2;

            Assert.AreEqual(exp_result, result.ToString());
        }

        [TestMethod]
        public void TestMethod3()
        {
            BigNumbers result;
            string exp_result;
            exp_result = "10512";

            BigNumbers a1 = new BigNumbers("5609");
            BigNumbers a2 = new BigNumbers("4903");
            result = a1 + a2;

            Assert.AreEqual(exp_result, result.ToString());
 
        }

        [TestMethod] 
        public void TestMethod4()
        { 
            BigNumbers result;
            string exp_result; 
            exp_result = "6000000000000000000000000000";

            BigNumbers a1 = new BigNumbers("5000000000000000000000000000");
            BigNumbers a2 = new BigNumbers("1000000000000000000000000000");
            result = a1 + a2;

            Assert.AreEqual(exp_result, result.ToString());
        }

        [TestMethod]
        public void TestMethod5()
        {
            BigNumbers result;
            string exp_result;
            exp_result = "5001";

            BigNumbers a1 = new BigNumbers("5000");
            BigNumbers a2 = new BigNumbers("1");
            result = a1 + a2;

            Assert.AreEqual(exp_result, result.ToString());
        }
    }

    [TestClass]
    public class Subtraction
    {
        [TestMethod]
        public void TestMethod1() 
        {
            BigNumbers result;
            string exp_result;
            exp_result = "4600";

            BigNumbers a1 = new BigNumbers("5000");
            BigNumbers a2 = new BigNumbers("400");
            result = a1 - a2;

            Assert.AreEqual(exp_result, result.ToString());
        }

        [TestMethod]
        public void TestMethod2()
        { 
            BigNumbers result;
            string exp_result;
            exp_result = "0";

            BigNumbers a1 = new BigNumbers("0");
            BigNumbers a2 = new BigNumbers("0");
            result = a1 - a2;

            Assert.AreEqual(exp_result, result.ToString());
        }

        [TestMethod]
        public void TestMethod3()
        {
            BigNumbers result;
            string exp_result; 
            exp_result = "706";

            BigNumbers a1 = new BigNumbers("5609");
            BigNumbers a2 = new BigNumbers("4903");
            result = a1 - a2;

            Assert.AreEqual(exp_result, result.ToString());

        }

        [TestMethod]
        public void TestMethod4()
        { 
            BigNumbers result;
            string exp_result;
            exp_result = "4000000000000000000000000000"; 

            BigNumbers a1 = new BigNumbers("5000000000000000000000000000");
            BigNumbers a2 = new BigNumbers("1000000000000000000000000000");
            result = a1 - a2;

            Assert.AreEqual(exp_result, result.ToString());
        }

        [TestMethod]
        public void TestMethod5()
        {
            BigNumbers result;
            string exp_result;
            exp_result = "4999"; 
             
            BigNumbers a1 = new BigNumbers("5000");
            BigNumbers a2 = new BigNumbers("1");
            result = a1 - a2; 

            Assert.AreEqual(exp_result, result.ToString());
        }

        [TestMethod]
        public void TestMethod6()
        {
            BigNumbers result; 
            string exp_result; 
            exp_result = "-1000";

            BigNumbers a1 = new BigNumbers("4000");
            BigNumbers a2 = new BigNumbers("5000");
            result = a1 - a2;

            Assert.AreEqual(exp_result, result.ToString());
        }

    }

    [TestClass] 
    public class Comparison 
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool result;
            bool exp_result = true;
            BigNumbers a1 = new BigNumbers("5000");
            BigNumbers a2 = new BigNumbers("1");

            result = a1 > a2; 
             
            Assert.AreEqual(exp_result, result);
        }

        [TestMethod]
        public void TestMethod2()   
        {
            bool result;
            bool exp_result = false; 
            BigNumbers a1 = new BigNumbers("5");
            BigNumbers a2 = new BigNumbers("1");

            result = a1 < a2;

            Assert.AreEqual(exp_result, result);
        }

        [TestMethod]
        public void TestMethod3() 
        {
            bool result;
            bool exp_result = false; 
            BigNumbers a1 = new BigNumbers("5");
            BigNumbers a2 = new BigNumbers("5");

            result = a1 < a2;

            Assert.AreEqual(exp_result, result);
        }
    }
}    
