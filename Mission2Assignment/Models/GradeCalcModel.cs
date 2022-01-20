using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission2Assignment.Models
{
    /* The code below contains the getters and setters for the Grade calculation form contained in the GradeCalc.cshtml
     * file. There are also validations to ensure that only integers between 0 and 100 are able to be entered. */
    
    public class GradeCalcModel
    {
        [Required]
        [Range(0, 100)]
        public int Assignment { get; set; }
        [Required]
        [Range(0, 100)]
        public int Group { get; set; }
        [Required]
        [Range(0, 100)]
        public int Quiz { get; set; }
        [Required]
        [Range(0, 100)]
        public int Exam { get; set; }
        [Required]
        [Range(0, 100)]
        public int INTEX { get; set; }

    }
}
