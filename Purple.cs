using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public abstract class Purple
    {
        private string _input;
        public string Input => _input; 
        public Purple(string input)
        {
            _input = input;
        }
        public abstract void Review();
    }
}
