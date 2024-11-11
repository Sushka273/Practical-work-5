using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Практическая__5
{
    internal class Triad
    {
        int tr1;
        int tr2;
        int tr3;


        public int Trid1
        {
            get
            {
                return tr1;
            }
            set
            {
                if ((value < 999) && (value > 99))
                {
                    if (value % 2 != 0 && value / 10 % 2 != 0 && value / 100 % 2 != 0) tr1 = value;
                    else MessageBox.Show("1-ая триада четная");
                }
                else MessageBox.Show("Неправильное значение");
            }
        }

        public int Trid2
        {
            get
            {
                return tr2;
            }
            set
            {
                if ((value < 999) && (value > 99))
                {
                    if (value % 2 != 0 && value / 10 % 2 != 0 && value / 100 % 2 != 0) tr2 = value;
                    else MessageBox.Show("2-ая триада четная");
                }
                else MessageBox.Show("Неправильное значение");
            }
        }

        public int Trid3
        {
            get
            {
                return tr3;
            }
            set
            {
                if ((value < 999) && (value > 99))
                {
                    if (value % 2 != 0 && value / 10 % 2 != 0 && value / 100 % 2 != 0) tr3 = value;
                    else MessageBox.Show("3-я триада четная");
                }
                else MessageBox.Show("Неправильное значение");
            }
        }

        public bool Sravn(int a, int b)
        {
            if (a == b) return true;
            else return false;
        }

        public bool Sravn(int a, int b, int c)
        {
            if ((a == b) && (a == c)) return true;
            else return false;
        }
    }   
}
