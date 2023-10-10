using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongDieuKhien
{
    public class KiemThuDongDieuKhien
    {
        public KiemThuDongDieuKhien() { }
        public char Grade(double score)
        {
            if (score < 0 || score > 10)
                return 'I';
            char res;
            if (score >= 9)
                res = 'A';
            else if (score >= 8)
                res = 'B';
            else if (score >= 6.5)
                res = 'C';
            else if (score >= 5)
                res = 'D';
            else
                res = 'F';
            return res;
        }
        public int Sum(int[] a, int n)
        {
            int i, total = 0;

            for (i = 0; i < n; i++)
                total += a[i];
            return total;
        }

        public string calculateBMI(double weight, double height)
        {
            double bmi = 0.0;
            bmi = weight / (height * height);
            bmi = (double)Math.Round((bmi * 10) / 10, 2, MidpointRounding.ToEven);
            if (bmi < 18.5)
            {
                return "Thiếu cân";
            }
            else if (bmi < 23)
            {
                return "Bình thường";
            }
            else if (bmi < 25)
            {
                return "Thừa cân";
            }
            else
            {
                return "Béo phì";
            }
        }

        public string Foo(int x)
        {
            string res;
            switch (x)
            {
                case 65:

                    res = "A"; break;
                case 66:
                    res = "B"; break;
                case 67:
                    res = "C";
                    break;
                default:
                    res = "haven't check";
                    return res;
            }
            return res;
        }
    }
}