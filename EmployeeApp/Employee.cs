﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        //Property
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceed 15 characters!");
                else
                    empName = value;
            }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public int Age
        {
            get => empAge;
            set => empAge = value;
        }

        public string SocialSecurityNumber
        {
            get => empSSN;
        }

        //Methods
        public void GiveBonus (float amount)
        {
            currPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name); // Name of employee
            Console.WriteLine("Age: {0}", Age); // Age of employee
            Console.WriteLine("ID: {0}", ID); // ID of employee
            Console.WriteLine("Pay: {0}", Pay); // current pay for employee
        }
    }
}
