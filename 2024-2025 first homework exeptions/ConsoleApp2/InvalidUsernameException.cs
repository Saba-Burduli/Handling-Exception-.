using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class InvalidUsernameException : Exception
    {

        public InvalidUsernameException(string massage) : base(massage) 
        
        { 
        
        
        
        }   
    }
}
