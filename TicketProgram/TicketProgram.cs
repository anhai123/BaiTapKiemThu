using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket
{
    public class TicketProgram
    {
        public TicketProgram() { }
        public  string TicketPrice(dynamic age)
        {
            if (age <= 0)
            {
                return $"INPUT_KHONG_HOP_LE, age {age} <= 0";
            }

            if(age.GetType() != typeof(int))
            {
                return $"INPUT_KHONG_HOP_LE, {age} khong phai la so nguyen";
            }
            if (age < 5)
            {
                return "MIEN_PHI_VE";
            }
            else if (age <= 65)
            {
                return "20$/VE";
            }
            else
            {
                return "10$/VE";
            }
        }
        public  string HatGift(string gender)
        {
            if (gender.ToLower() == "female")
            {
                return "MU_HONG";
            }
            else if (gender.ToLower() == "male")
            {
                return "MU_XANH";
            }
            else
            {
                return $"Gioi tinh {gender} khong hop le, dau vao phai la male hoac female";
            }
        }

        public  string TicketAndGiftResult(dynamic age, string gender)
        {
            if(TicketPrice(age) == $"INPUT_KHONG_HOP_LE, age {age} <= 0" && HatGift(gender) == $"Gioi tinh {gender} khong hop le, dau vao phai la male hoac female")
            {
                return TicketPrice(age) + " va " + HatGift(gender);
            }
            else if (TicketPrice(age) == $"INPUT_KHONG_HOP_LE, {age} khong phai la so nguyen" && HatGift(gender) == $"Gioi tinh {gender} khong hop le, dau vao phai la male hoac female")
            {
                return TicketPrice(age) + " va " + HatGift(gender);
            }
            else if (TicketPrice(age) == $"INPUT_KHONG_HOP_LE, age {age} <= 0")
            {
                return TicketPrice(age);
            }
            else if (TicketPrice(age) == $"INPUT_KHONG_HOP_LE, {age} khong phai la so nguyen")
            {
                return TicketPrice(age);
            }
            else if (HatGift(gender) == $"Gioi tinh {gender} khong hop le, dau vao phai la male hoac female")
            {
                return HatGift(gender);
            }
            else
            {
                return TicketPrice(age) + " va " + HatGift(gender);
            }   
        }
    }
}
