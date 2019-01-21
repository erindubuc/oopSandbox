using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessment
{
    public class Degree
    {
        // Defining properties
        public string Course { get; set; }
        public string DegreeName { get; set; }

        // Adding a constructor
        // Instantiating Degree with course
        public Degree(string degreeName)
        {
            this.DegreeName = degreeName;
        }
    }
}
