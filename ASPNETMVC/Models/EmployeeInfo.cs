﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
 Benton Valenzuela 
Lab 1. MVC Fundamentals

 */

namespace ASPNETMVC.Models
{
    public class EmployeeInfo
    {

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string EmailAddress { get; set; }

    }
}