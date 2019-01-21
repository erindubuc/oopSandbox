using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessment
{
    // Declaring UProgram() Class
    // Properties: Degree, Course
    public class UProgram
    {
        public string ProgramName { get; set; }

        
        // Adding a constructor
        // Instantiates UProgram with degree
        public UProgram(string programName)
        {
            this.ProgramName = programName;
        }


    }
}
