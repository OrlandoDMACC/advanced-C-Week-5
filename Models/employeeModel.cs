using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week5project.Enums;

namespace Week5project.Models
{
    public class employeeModel
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }

        public DateTime birthDate { get; set; }

        public DateTime hireDate {get; set;}

        public Enums.department department { get; set; }

        public String jobTitle { get; set; }

        public double salary { get; set; }

        public Enums.salaryType salaryType { get; set; }

        public int ID { get; set; }

        public string availableHours { get; set; }

    }
}
