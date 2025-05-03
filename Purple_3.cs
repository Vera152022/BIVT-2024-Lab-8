using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_3 : Purple
    {
        private string _out;
        private char[] _code;
        public string Output => _out;
        public (string, char)[] Codes
        {
            get;
            private set;
        }
        public Purple_3(string input) : base(input) 
        {
            Codes = new (string, char)[0];
            _code = new char[0];
            for (char i = ' '; i < '~' && _code.Length < 5; i++)
            {
                if (!input.Contains(i)) 
                { 
                    _code = _code.Append(i).ToArray();
                }
                
            }
        }
        public override string ToString() 
        { 
            return _out;
        }

        public override void Review()
        {
            if (Input == null) return;
            var total = new StringBuilder();
            var input_tot = Input.Split(' ');

            string[] syllable = new string[0];
            int[] num_syllable = new int[0];

            foreach (var word in input_tot) 
            { 
                for(int i = 0; i < word.Length - 1; i++)
                {
                    int t = 0;
                    string syl = $"{word[i]}{word[i + 1]}";
                    if (!syllable.Contains(syl) && char.IsLetter(word[i]) && char.IsLetter(word[i + 1]))
                    {
                        Array.Resize(ref syllable, syllable.Length + 1);
                        syllable[syllable.Length - 1] = syl;

                        Array.Resize(ref num_syllable, num_syllable.Length + 1);
                        num_syllable[num_syllable.Length - 1] = 1;
                    }
                    else if (syllable.Contains(syl))
                    {
                        for(int j = 0; j < syllable.Length; j++)
                        {
                            if (syllable[j] == syl)
                            {
                                num_syllable[j] += 1;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < syllable.Length; i++) 
            {
                int j = i;
                int z = i - 1;
                while(z >= 0)
                {
                    if (num_syllable[z] < num_syllable[j])
                    {
                        int neww = num_syllable[z];
                        num_syllable[z] = num_syllable[j];
                        num_syllable[j] = neww;

                        string neww2 = syllable[z];
                        syllable[z] = syllable[j];
                        syllable[j] = neww2;
                    }
                    j = z;
                    z--;
                }
            }
            num_syllable = num_syllable.Take(5).ToArray();
            for (int i = 0; i < Math.Min(5, syllable.Length); i++) 
            {
                //Console.WriteLine(syllable[i]);
                Codes = Codes.Append((syllable[i], _code[i])).ToArray();
            }
            string input = Input;
            
            for(int i = 0; i < num_syllable.Length; i++)
            {
                int j;
                for(j = 0; j < input.Length - 1; j++)
                {
                    if ($"{input[j]}{input[j + 1]}" == syllable[i])
                    {
                        total.Append(_code[i]);
                        j++;
                    }
                    else
                    {
                        total.Append(input[j]);
                    }
                }
                if (j == input.Length - 1) 
                {
                    total.Append(input[j]);
                }
                input = total.ToString();
                total = new StringBuilder();
            }
            _out = input;

        }
    }
}
