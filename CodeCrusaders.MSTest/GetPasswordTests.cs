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
        public void GetPassword_EnterKey_ReturnsPassword()
        {
            // Arrange
            string input = "password\n";

            // Act
            string result = GetPassword(input);

            // Assert
            Assert.AreEqual("password", result);
        }

        [TestMethod]
        public void GetPassword_Backspace_RemovesLastCharacter()
        {
            // Arrange
            string input = "pass\bword\n";

            // Act
            string result = GetPassword(input);

            // Assert
            Assert.AreEqual("pasword", result);
        }

        [TestMethod]
        public void GetPassword_NoControlCharactersInPassword()
        {
            // Arrange
            string input = "pa\0ssword\n";

            // Act
            string result = GetPassword(input);

            // Assert
            Assert.AreEqual("password", result);
        }

        // Mockup användare 1
        [TestMethod]
        public void GetPassword_MockUser1()
        {
            // Arrange
            string input = "mockUser1Password\n";

            // Act
            string result = GetPassword(input);

            // Assert
            Assert.AreEqual("mockUser1Password", result);
        }

        // Mockup användare 2
        [TestMethod]
        public void GetPassword_MockUser2()
        {
            // Arrange
            string input = "mockUser2Password\n";

            // Act
            string result = GetPassword(input);

            // Assert
            Assert.AreEqual("mockUser2Password", result);
        }


        private string GetPassword(string input)
        {
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
            return password;
        }
    }
}