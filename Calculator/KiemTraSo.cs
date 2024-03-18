using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class KiemTraSo
    {
        public  bool IsInt(string input)
        {
            int result;
            return int.TryParse(input, out result);
        }

        public int SumInt(int a, int b)
        {
            if(!IsInt(a.ToString()))
            {
                throw new AggregateException("a không phải số nguyên");
            }
            if (!IsInt(b.ToString()))
            {
                throw new AggregateException("b không phải số nguyên");
            }
            if (!IsInt(b.ToString()) && !IsInt(a.ToString()))
            {
                throw new AggregateException("Cả 2 số không phải số nguyên");
            }
            return a + b;
        }

        public double Quoitient (double a, double b)
        {
            if(a == 0)
            {
                throw new AggregateException("Phép tính không xác định");

            }
            if (b == 0)
            {
                throw new AggregateException("Phép tính không xác định");

            }
            if( a == 0 && b == 0)
            {
                throw new AggregateException("Đây là phép tính vô định");

            }

            return a / b;
        }
    }
}
