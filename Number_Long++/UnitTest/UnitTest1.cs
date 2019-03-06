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
            BigNumber result;
            string exp_result;
            exp_result = "5400"; 

            BigNumber a1 = new BigNumber("5000");
            BigNumber a2 = new BigNumber("400");
            result = a1 + a2;

            Assert.AreEqual(exp_result, result.ToString());
        }

        [TestMethod]
        public void TestMethod2()
        {
            BigNumber result;
            string exp_result;
            exp_result = "0";

            BigNumber a1 = new BigNumber("0");
            BigNumber a2 = new BigNumber("0");
            result = a1 + a2;

            Assert.AreEqual(exp_result, result.ToString());
        }

        [TestMethod]
        public void TestMethod3()
        {
            BigNumber result;
            string exp_result;
            exp_result = "10512";

            BigNumber a1 = new BigNumber("5609");
            BigNumber a2 = new BigNumber("4903");
            result = a1 + a2;

            Assert.AreEqual(exp_result, result.ToString());

        }

        [TestMethod]
        public void TestMethod4()
        {
            BigNumber result;
            string exp_result;
            exp_result = "6000000000000000000000000000";

            BigNumber a1 = new BigNumber("5000000000000000000000000000");
            BigNumber a2 = new BigNumber("1000000000000000000000000000");
            result = a1 + a2;

            Assert.AreEqual(exp_result, result.ToString());
        }

        [TestMethod]
        public void TestMethod5()
        {
            BigNumber result;
            string exp_result;
            exp_result = "5001";

            BigNumber a1 = new BigNumber("5000");
            BigNumber a2 = new BigNumber("1");
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
            BigNumber result; 
            string exp_result;
            exp_result = "4600";

            BigNumber a1 = new BigNumber("5000");
            BigNumber a2 = new BigNumber("400");
            result = a1 - a2;

            Assert.AreEqual(exp_result, result.ToString());
        }

        [TestMethod]
        public void TestMethod2()
        {
            BigNumber result;
            string exp_result;
            exp_result = "0";

            BigNumber a1 = new BigNumber("0");
            BigNumber a2 = new BigNumber("0");
            result = a1 - a2;

            Assert.AreEqual(exp_result, result.ToString());
        }

        [TestMethod]
        public void TestMethod3() 
        { 
            BigNumber result;
            string exp_result;
            exp_result = "706";

            BigNumber a1 = new BigNumber("5609");
            BigNumber a2 = new BigNumber("4903");
            result = a1 - a2;

            Assert.AreEqual(exp_result, result.ToString());

        }

        [TestMethod]
        public void TestMethod4()
        {
            BigNumber result;
            string exp_result;
            exp_result = "4000000000000000000000000000";

            BigNumber a1 = new BigNumber("5000000000000000000000000000");
            BigNumber a2 = new BigNumber("1000000000000000000000000000");
            result = a1 - a2;

            Assert.AreEqual(exp_result, result.ToString());
        }

        [TestMethod]
        public void TestMethod5()
        {
            BigNumber result; 
            string exp_result;
            exp_result = "4999";

            BigNumber a1 = new BigNumber("5000");
            BigNumber a2 = new BigNumber("1"); 
            result = a1 - a2;

            Assert.AreEqual(exp_result, result.ToString());
        }

        [TestMethod]
        public void TestMethod6()
        {
            BigNumber result;
            string exp_result;
            exp_result = "-1000";

            BigNumber a1 = new BigNumber("4000");
            BigNumber a2 = new BigNumber("5000");
            result = a1 - a2;

            Assert.AreEqual(exp_result, result.ToString()); 
        }

        [TestMethod]
        public void TestMethod7()
        {
            BigNumber result;
            string exp_result; 
            exp_result = "0";

            BigNumber a1 = new BigNumber("5000");
            BigNumber a2 = new BigNumber("5000");
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
            BigNumber a1 = new BigNumber("5000");
            BigNumber a2 = new BigNumber("1");

            result = a1 > a2;

            Assert.AreEqual(exp_result, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool result;
            bool exp_result = false;
            BigNumber a1 = new BigNumber("5");
            BigNumber a2 = new BigNumber("1");

            result = a1 < a2;

            Assert.AreEqual(exp_result, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            bool result;
            bool exp_result = false;
            BigNumber a1 = new BigNumber("5");
            BigNumber a2 = new BigNumber("5");

            result = a1 < a2;

            Assert.AreEqual(exp_result, result);
        }
    }

    [TestClass]
    public class Multiply
    {
         
        [TestMethod]
        public void TestMethod1()
        {
            BigNumber result;
            string exp_result;
            exp_result = "20";

            BigNumber a1 = new BigNumber("4");
            BigNumber a2 = new BigNumber("5");
            result = a1 * a2;

            Assert.AreEqual(exp_result, result.ToString());
        }

        [TestMethod]
        public void TestMethod2()
        {
            BigNumber result;
            string exp_result;
            exp_result = "20000";

            BigNumber a1 = new BigNumber("4000");
            BigNumber a2 = new BigNumber("5");
            result = a1 * a2;

            Assert.AreEqual(exp_result, result.ToString());
        }

        [TestMethod]
        public void TestMethod3()
        {
            BigNumber result;
            string exp_result;
            exp_result = "12323958";

            BigNumber a1 = new BigNumber("1234");
            BigNumber a2 = new BigNumber("9987");
            result = a1 * a2;

            Assert.AreEqual(exp_result, result.ToString());
        }

        [TestMethod]
        public void TestMethod4()
        {
            BigNumber result;
            string exp_result;
            exp_result = "9987000000000000";

            BigNumber a1 = new BigNumber("1000000000000");
            BigNumber a2 = new BigNumber("9987");
            result = a1 * a2;

            Assert.AreEqual(exp_result, result.ToString());
        } 
    } 
    [TestClass]
    public class Divide
    {
        [TestMethod]
        public void TestMethod1()
        {
            BigNumber result;       
            string exp_result;   
            exp_result = "1000000000000"; 

            BigNumber a1 = new BigNumber("9987000000000000");
            int a2 = 9987; 
            result = a1 / a2;
             
            Assert.AreEqual(exp_result, result.ToString());
        }
         
        [TestMethod]
        public void TestMethod2()
        {
            BigNumber result;
            string exp_result; 
            exp_result = "1234";  

            BigNumber a1 = new BigNumber("12323958");
            int a2 = 9987;
            result = a1 / a2; 

            Assert.AreEqual(exp_result, result.ToString());
        }

        [TestMethod] 
        public void TestMethod3()
        {
            BigNumber result;
            string exp_result; 
            exp_result = "4000";

            BigNumber a1 = new BigNumber("20000");
            int a2 = 5;
            result = a1 / a2; 

            Assert.AreEqual(exp_result, result.ToString());
        }

        [TestMethod]
        public void TestMethod4()
        {
            BigNumber result;
            string exp_result; 
            exp_result = "1"; 

            BigNumber a1 = new BigNumber("5");
            int a2 = 5;
            result = a1 / a2;

            Assert.AreEqual(exp_result, result.ToString());
        }

        [TestMethod]
        public void TestMethod5()
        {
            BigNumber result; 
            string exp_result;  
            exp_result = "1"; 

            BigNumber a1 = new BigNumber("5");
            int a2 = 3; 
            result = a1 / a2;

            Assert.AreEqual(exp_result, result.ToString());
        }
    } 
}
  