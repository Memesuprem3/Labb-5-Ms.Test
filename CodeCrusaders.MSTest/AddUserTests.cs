using OOP___Projekt_i_grupp___Code_Crusades__SUT23_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test;

namespace CodeCrusaders.MSTest
{
    [TestClass]
    public class AddUserTests
    {

        [TestMethod]
        public void AddUser_UserIsAdded()
        {
            // Arrange
            using (StringReader sr = new StringReader("testuser\ntestpin\n"))
            {
                Console.SetIn(sr);

                // Act
                AddUser();

                // Assert
                Assert.AreEqual(1, Start.CustomerList.Count);
            }
        }

        [TestMethod]
        public void AddUser_UsernameIsSavedCorrectly()
        {
            // Arrange
            using (StringReader sr = new StringReader("testuser\ntestpin\n"))
            {
                Console.SetIn(sr);

                // Act
                AddUser();

                // Assert
                Assert.AreEqual("testuser", Start.CustomerList[0].Username);
            }
        }

        [TestMethod]
        public void AddUser_PinIsSavedCorrectly()
        {
            // Arrange
            using (StringReader sr = new StringReader("testuser\ntestpin\n"))
            {
                Console.SetIn(sr);

                // Act
                AddUser();

                // Assert
                Assert.AreEqual("testpin", Start.CustomerList[0].Pin);
            }
        }

        public static void AddUser()
        {
            Console.Write("\n\tAnge Användarnamn: ");
            string username = Console.ReadLine();

            Console.Write("\n\tAnge pin: ");
            string pin = Console.ReadLine();

            bool role = false;

            User newCustomer = new User(username, pin, role);
            newCustomer.Accounts = new List<Accounts>();

            Start.CustomerList.Add(newCustomer);

            Console.WriteLine($"\n\tAnvändare {username} Skapats!");
        }

        public static class Start
        {
            public static List<User> CustomerList { get; set; } = new List<User>();
        }

        public class User
        {
            public User(string username, string pin, bool role)
            {
                Username = username;
                Pin = pin;
                Role = role;
                Accounts = new List<Accounts>();
            }

            public string Username { get; set; }
            public string Pin { get; set; }
            public bool Role { get; set; }
            public List<Accounts> Accounts { get; set; }
        }

        public class Accounts
        {
        }
    }
}
