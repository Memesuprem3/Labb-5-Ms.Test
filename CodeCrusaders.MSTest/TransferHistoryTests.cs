
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP___Projekt_i_grupp___Code_Crusades__SUT23_;
using System.Collections.Generic;
using test;


namespace CodeCrusaders.MSTest
{
    

    [TestClass]
    public class TransferHistoryTests
    {
        private List<TransferLog> TransferLogs;

        [TestInitialize]
        public void Setup()
        {
            TransferLogs = new List<TransferLog>
        {
            new TransferLog { TransferDetails = "Log 1" },
            new TransferLog { TransferDetails = "Log 2" }
        };
        }

        [TestMethod]
        public void PrintTransferHistory_AllLogsPrinted()
        {
            // Arrange
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                PrintTransferHistory();

                // Assert
                string expected = "Log 1\r\nLog 2\r\n";
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void PrintTransferHistory_EmptyLogs_NoOutput()
        {
            // Arrange
            TransferLogs.Clear();
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                PrintTransferHistory();

                // Assert
                string expected = "";
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void PrintTransferHistory_NoExceptionThrown()
        {
            // Arrange

            // Act & Assert
            try
            {
                PrintTransferHistory();
            }
            catch (Exception)
            {
                Assert.Fail("PrintTransferHistory threw an exception");
            }
        }

        public void PrintTransferHistory()
        {
            foreach (var log in TransferLogs)
            {
                Console.WriteLine(log.TransferDetails);
            }
        }

        public class TransferLog
        {
            public string TransferDetails { get; set; }
        }
    }
}
