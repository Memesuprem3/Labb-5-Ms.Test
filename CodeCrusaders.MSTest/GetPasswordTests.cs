using FluentAssertions;
using OOP___Projekt_i_grupp___Code_Crusades__SUT23_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCrusaders.MSTest
{
    [TestClass]
    public class GetPasswordTests
    {


        [TestMethod]
        [Description("This test checks if the 'enter password' field is empty")]
        public void GetPassword_EmptyInput_ReturnsEnterPassword()
        {
            // Arrange
            string input = "";
            string correctPassword = "password";

            // Act
            string result = GetPassword(input, correctPassword);

            // Assert
            Assert.AreEqual("Enter password", result);
        }

        [TestMethod]
        [Description("This test checks if the password is correct, then a prompt is returned 'Password accepted")]
        public void GetPassword_CorrectPassword_ReturnsPasswordAccepted()
        {
            // Arrange
            string input = "password";
            string correctPassword = "password";

            // Act
            string result = GetPassword(input, correctPassword);

            // Assert
            Assert.AreEqual("Password accepted", result);
        }

        [TestMethod]
        [Description("This test checks the password, if it is wrong 'wrong password' is prompted")]
        public void GetPassword_WrongPassword_ReturnsWrongPassword()
        {
            // Arrange
            string input = "wrongpassword";
            string correctPassword = "password";

            // Act
            string result = GetPassword(input, correctPassword);

            // Assert
            Assert.AreEqual("Wrong password", result);
        }

        private string GetPassword(string input, string correctPassword)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "Enter password";
            }

            string password = "";
            foreach (char c in input)
            {
                if (c == '\n')
                    break;

                if (c == '\b' && password.Length > 0)
                {
                    password = password.Substring(0, (password.Length - 1));
                }
                else if (!char.IsControl(c))
                {
                    password += c;
                }
            }

            if (password == correctPassword)
            {
                return "Password accepted";
            }
            else
            {
                return "Wrong password";
            }
        }
    }
}