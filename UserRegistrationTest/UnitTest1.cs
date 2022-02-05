using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        //testing user details
        [TestMethod]
        public void UserDetails()
        {
                bool expected = true;
                string firstName = "Mahafuz";
                string lastName = "Ahmed";
                string emailID = "abc.xyz@gmail.com";
                string mobileNum = "91 8790988099";
                string password = "Asdfg@1sbj";
                UserForm pattern = new UserForm();
                Assert.AreEqual(expected, pattern.ValidateFName(firstName));
                Assert.AreEqual(expected, pattern.ValidateLName(lastName));
                Assert.AreEqual(expected, pattern.ValidateEmail(emailID));
                Assert.AreEqual(expected, pattern.ValidateMobile(mobileNum));
                Assert.AreEqual(expected, pattern.ValidatePasswordR4(password));
        }
        //testing all email samples
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void ValidateEmailId(string email)
        {
            bool expected = true;
            UserForm pattern = new UserForm();
            Assert.AreEqual(expected, pattern.ValidateEmail(email));
         }
        
    }
}
