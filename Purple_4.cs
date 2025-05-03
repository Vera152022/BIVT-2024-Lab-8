using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_4 : Purple
    {
        private string _out;
        private (string, char)[] _code;
        public string Output => _out;
        public Purple_4(string input, (string, char)[] code) : base(input)
        {
            _code = code;
        }
        public override string ToString()
        {
            return _out;
        }
        public override void Review()
        {
            if (_code == null || Input == null) return;
            var total = new StringBuilder();
            for (int i = 0; i < Input.Length; i++) 
            {
                int flag = -1;
                for (int j = 0; j < _code.Length; j++) 
                {
                    if (_code[j].Item2 == Input[i])
                    {
                        flag = j;
                    }
                }
                if(flag != -1)
                {
                    total.Append(_code[flag].Item1);
                }
                else
                {
                     total.Append(Input[i]);
                }
            }
            _out  = total.ToString();
        }

    }
}
