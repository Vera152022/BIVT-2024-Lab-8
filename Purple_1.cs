using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_1 :Purple
    {
        private string _out;
        public string Output => _out;
        public Purple_1(string outt) : base(outt)
        {
            _out = "";
        }
        public override string ToString()
        {
            return _out;
        }
        public override void Review()
        {
            if (Input == null) return;
            string word = "";
            int deff = 45;
            int deff3 = 39;
            for (int i = 0; i < Input.Length; i++) 
            {
                Char def2 = Input[i];
                int deff2 = def2;
                
                if (Char.IsLetter(Input[i]) || deff == deff2 || deff2 == deff3)
                { 
                    
                    word += Input[i];
                        
                }
                else
                {
                    if (Char.IsLetter(Input[i]) == false)
                    {
                        if(word == "th")
                        {
                            _out += "th";
                            _out += Input[i];
                            word = "";
                        }
                        else
                        {
                            string word_2 = "";
                            for (int j = word.Length - 1; j > -1; j--)
                            {
                                word_2 += word[j];
                            }
                            _out += word_2;
                            word = "";
                            _out += Input[i];

                        }
                        

                    }
                }
            }
        }
    }
}
