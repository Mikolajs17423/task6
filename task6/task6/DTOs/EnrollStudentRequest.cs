﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace task6.DTOs
{
    public class EnrollStudentRequest
    {
        [RegularExpression("^s[0-9]+$")]
        public string idStudent { get; set; }

        [Required]
        [MaxLength(10)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

    }
}