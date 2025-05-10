using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_2 : Purple
    {
        private string[] _out;
        public string[] Output
        {
            get
            {
                if (_out == null) return null;
                var new_out = new string[_out.Length];
                Array.Copy(_out, new_out, _out.Length);
                return new_out;
            }
        }
        public Purple_2(string intput) : base(intput) {}

        public override string ToString()
        {
            if (_out == null || _out.Length == 0) return null;
            string outt = string.Join(Environment.NewLine, _out);
            return outt;
        }
        public override void Review()
        {
            if (Input == null) return;
            _out = new string[0];
            string[] tot = Input.Split(' ');
            if (tot.Length == 0) return;
            var summ = new StringBuilder();
            int flag = 0;
            for(int i = 0; i < tot.Length; i++) 
            {
                
                if (summ.Length + tot[i].Length <= 50 && flag == 0) 
                {
                   
                    if (summ.Length + tot[i].Length == 50 && flag == 0)
                    {
                        summ.Append(tot[i]);
                        
                        flag = 1;
                    }
                        
                    else if (summ.Length + tot[i].Length < 50)
                    {
                        if(i < tot.Length - 1)
                        {
                            if (50 - tot[i].Length - summ.Length >= tot[i + 1].Length + 1 && flag == 0)
                            {
                                summ.Append(tot[i]);
                                summ.Append(" ");
                            }
                            else if(flag == 0)
                            {
                                summ.Append(tot[i]);
                                flag = 1;
                            }
                            
                   
                        }
                        else if (i == tot.Length - 1 && flag == 0)
                        {
                            summ.Append(tot[i]);
                            flag = 1;
                        }
                     }

                }
                else
                {
                    var summ_3 = Probel(summ.ToString());
                    Add(summ_3);
                    

                    summ = new StringBuilder();
                    summ.Append(tot[i]);
                    if(i < tot.Length - 1)
                      summ.Append(" ");
                    flag = 0;
                }
            }
            
            var summ_2 = Probel(summ.ToString());
            Add(summ_2);
            
        }
        private string Probel(string summ)
        {
            string[] time = summ.Split(' ');
            
            if(time.Length == 1) return time[0];
            int num = 0;
            if (time.Length == 1) return time[0];
            foreach (string s in time)
            {
                num += s.Length;

            }
            num = 50 - num;
            int prob = num / (time.Length - 1);
            
            int prob_izbran = num % (time.Length - 1);
            
            string new_summ = time[0];
            for (int j = 0; j < time.Length - 1; j++)
            {
                if (j < prob_izbran)
                    new_summ += string.Concat(Enumerable.Repeat(" ", prob + 1)) + time[j + 1];
                else
                {
                    new_summ += string.Concat(Enumerable.Repeat(" ", prob)) + time[j + 1];
                }
            }
            
            return new_summ;
        }
        private void Add(string s)
        {
            
            string[] new_sport = new string[_out.Length + 1];
            Array.Copy(_out, new_sport, _out.Length);
            new_sport[new_sport.Length - 1] = s;
            _out = new_sport;
        }
    }
}
