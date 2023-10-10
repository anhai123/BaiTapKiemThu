using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketProgram
{
    public class KiemThuDongDuLieu
    {
        public KiemThuDongDuLieu() { }
        public string BaiNhapXvaY(int x, int y)
        {
            int xLocal = x;
            int yLocal = y; 
           while(yLocal > 0)
            {
                if(xLocal > 0)
                {
                    yLocal -= xLocal;
                }
                else
                {
                    //giả sử người dùng nhập lại x = 6
                    xLocal = 6;
                }
            }
            return Output(xLocal, yLocal);
        }
        public string Output(int x,int y)
        {
            // In ra kết quả
            return "x = " + x + ", y = " + y;
            
        }
        //Tỷ lệ tươi càng cao thì chất lượng và độ tươi ngon của trái cây càng tốt.
        //Tỷ lệ tươi thường dao động từ 3-6 đối với hầu hết các loại trái cây tươi.
        //Trọng lượng trái cây tươi) / (Trọng lượng trái cây khô
        public string calculateFreshRatio(double weightFresh, double weightDry)
        {
            double freshRatio = 0;
            freshRatio = weightFresh / weightDry;
            freshRatio = (double)Math.Round((freshRatio * 10) / 10, 2, MidpointRounding.ToEven);
            if (freshRatio < 3)
            {
                return "Héo";
            }
            else if ( 3 <= freshRatio && freshRatio < 4)
            {
                return "Vừa";
            }
            else if (4 <= freshRatio && freshRatio < 5)
            {
                return "Ngon";
            }
            else
            {
                return "Siêu tươi ngon";
            }
        }
    }
}
