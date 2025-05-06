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
            if (Input == null)
            {
                _out = Input;
                return;
            } 
            var word = new StringBuilder(); 
            int deff = 45;
            int deff3 = 39;
            var answer_out = new StringBuilder();
            for (int i = 0; i < Input.Length; i++) 
            {
                Char def2 = Input[i];
                int deff2 = def2;
                
                if (Char.IsLetter(Input[i]) || deff == deff2 || deff2 == deff3)
                { 
                    
                    word.Append(Input[i]);
                        
                }
                else
                {
                    if (Char.IsLetter(Input[i]) == false)
                    {
                        if(word.ToString() == "th")
                        {
                            answer_out.Append("th");
                            answer_out.Append(Input[i]);
                            word = new StringBuilder();
                        }
                        else
                        {
                            var word_2 = new StringBuilder();
                            for (int j = word.Length - 1; j > -1; j--)
                            {
                                word_2.Append(word[j]);
                            }
                            answer_out.Append(word_2.ToString());
                            word = new StringBuilder();
                            answer_out.Append(Input[i]);

                        }
                        

                    }
                }
                
            }
            _out = answer_out.ToString();
        }
    }
}
