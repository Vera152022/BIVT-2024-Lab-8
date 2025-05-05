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
        public string[] Output => _out;
        public Purple_2(string intput) : base(intput) 
        {
            _out = new string[0];
        }

        public override string ToString()
        {
            string outt = string.Join("\n", _out);
            return outt;
        }
        public override void Review()
        {
            if (Input == null) return;
            string[] tot = Input.Split(' ');
            string summ = "";
            int flag = 0;
            for(int i = 0; i < tot.Length; i++) 
            {
                
                if (summ.Length + tot[i].Length <= 50 && flag == 0) 
                {
                   
                    if (summ.Length + tot[i].Length == 50 && flag == 0)
                    {
                        summ += tot[i];
                        flag = 1;
                    }
                        
                    else if (summ.Length + tot[i].Length < 50)
                    {
                        if(i != tot.Length - 1)
                        {
                            if (50 - tot[i].Length - summ.Length >= tot[i + 1].Length + 1 && flag == 0)
                            {
                                //Console.WriteLine(tot[i]);
                                summ += tot[i] + " ";
                            }
                            else if(flag == 0)
                            {
                               //Console.WriteLine(tot[i]);
                                summ += tot[i];
                                flag = 1;
                            }
                            
                   
                        }
                        else if (i == tot.Length - 1 && flag == 0)
                        {
                            summ += tot[i];
                            flag = 1;
                        }
                     }

                }
                else
                {
                    //Console.WriteLine(tot[i]);
                    summ = Probel(summ);
                    Add(summ);
                    //Console.WriteLine(summ);

                    //string[] time = summ.Split(' ');
                    //int num = 0;
                    //foreach (string s in time) 
                    //{
                    //    num += s.Length;

                    //}
                    //num = 50 - num;
                    //int prob = num / (time.Length - 1);
                    //int prob_izbran = num % (time.Length - 1);
                    //string new_summ = time[0];
                    //for (int j = 0; j < prob; j++) 
                    //{ 
                    //    if(j < prob_izbran)
                    //        new_summ += string.Concat(Enumerable.Repeat(" ",  prob + prob_izbran));
                    //    else
                    //    {
                    //        new_summ += string.Concat(Enumerable.Repeat(" ", prob));
                    //    }
                    //}

                    summ = "";
                    summ += tot[i] + " ";
                    flag = 0;
                }
            }
            //Console.WriteLine(summ);
            //Console.WriteLine("kkkkkkkkkkkkk");
            summ = Probel(summ);
            Add(summ);
            //Console.WriteLine(summ);


        }
        private string Probel(string summ)
        {
            string[] time = summ.Split(' ');
            int num = 0;
            if (time.Length == 1) return time[0];
            foreach (string s in time)
            {
                num += s.Length;

            }
            num = 50 - num;
            int prob = num / (time.Length - 1);
            
            int prob_izbran = num % (time.Length - 1);
            //Console.WriteLine(prob_izbran);
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
            //Console.WriteLine(new_summ);
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
