using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kpo4281.Vasilov.Lib;

namespace Kpo4281_VasilovUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void IncorrectSurnameNone()
        {
            Employee employee = new Employee
            {
                surname = "",
                initials = "В.П.",
                birth = 1950,
                salary = 500
            };
            Assert.IsFalse(EmployeeControl.InfoControl(employee));
        }

        [TestMethod]
        public void IncorrectSurnameSpace()
        {
            Employee employee = new Employee
            {
                surname = " ",
                initials = "В.П.",
                birth = 1950,
                salary = 500
            };
            Assert.IsFalse(EmployeeControl.InfoControl(employee));
        }

        [TestMethod]
        public void IncorrectSurnameDigit()
        {
            Employee employee = new Employee
            {
                surname = "100",
                initials = "В.П.",
                birth = 1950,
                salary = 500
            };
            Assert.IsFalse(EmployeeControl.InfoControl(employee));
        }

        [TestMethod]
        public void CorrectSurname()
        {
            Employee employee = new Employee
            {
                surname = "Козловский",
                initials = "В.П.",
                birth = 1950,
                salary = 500
            };
            Assert.IsTrue(EmployeeControl.InfoControl(employee));
        }

        [TestMethod]
        public void IncorrectInitialsNone()
        {
            Employee employee = new Employee
            {
                surname = "Иванов",
                initials = "",
                birth = 1950,
                salary = 500
            };
            Assert.IsFalse(EmployeeControl.InfoControl(employee));
        }

        [TestMethod]
        public void IncorrectInitialsSpace()
        {
            Employee employee = new Employee
            {
                surname = "Иванов",
                initials = "  ",
                birth = 1950,
                salary = 500
            };
            Assert.IsFalse(EmployeeControl.InfoControl(employee));
        }

        [TestMethod]
        public void IncorrectInitialsDigit()
        {
            Employee employee = new Employee
            {
                surname = "Иванов",
                initials = "-50",
                birth = 1950,
                salary = 500
            };
            Assert.IsFalse(EmployeeControl.InfoControl(employee));
        }

        [TestMethod]
        public void CorrectInitials()
        {
            Employee employee = new Employee
            {
                surname = "Козловский",
                initials = "В.П.",
                birth = 1950,
                salary = 500
            };
            Assert.IsTrue(EmployeeControl.InfoControl(employee));
        }

        [TestMethod]
        public void InCorrectBirthPast()
        {
            Employee employee = new Employee
            {
                surname = "Козловский",
                initials = "В.П.",
                birth = 1899,
                salary = 500
            };
            Assert.IsFalse(EmployeeControl.InfoControl(employee));
        }


        [TestMethod]
        public void InCorrectBirthFuture()
        {
            Employee employee = new Employee
            {
                surname = "Козловский",
                initials = "В.П.",
                birth = 3000,
                salary = 500
            };
            Assert.IsFalse(EmployeeControl.InfoControl(employee));
        }

        [TestMethod]
        public void CorrectBirth()
        {
            Employee employee = new Employee
            {
                surname = "Козловский",
                initials = "В.П.",
                birth = 1900,
                salary = 500
            };
            Assert.IsTrue(EmployeeControl.InfoControl(employee));
        }

        [TestMethod]
        public void CorrectBirth1()
        {
            Employee employee = new Employee
            {
                surname = "Козловский",
                initials = "В.П.",
                birth = 2010,
                salary = 500
            };
            Assert.IsTrue(EmployeeControl.InfoControl(employee));
        }


        [TestMethod]
        public void InCorrectSalary()
        {
            Employee employee = new Employee
            {
                surname = "Козловский",
                initials = "В.П.",
                birth = 1900,
                salary = -500
            };
            Assert.IsFalse(EmployeeControl.InfoControl(employee));
        }

        [TestMethod]
        public void CorrectSalary()
        {
            Employee employee = new Employee
            {
                surname = "Козловский",
                initials = "В.П.",
                birth = 1900,
                salary = 500
            };
            Assert.IsTrue(EmployeeControl.InfoControl(employee));
        }
    }
}
