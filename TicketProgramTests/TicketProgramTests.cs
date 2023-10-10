//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Ticket;
//namespace TicketProgramTests
//{
//    [TestFixture]
//    public class TicketProgramTests
//    {
//        [Test]
//        [TestCase(-5, "male", "INPUT_KHONG_HOP_LE, age -5 <= 0")]
//        [TestCase(1, "male", "MIEN_PHI_VE va MU_XANH")]
//        [TestCase(20, "male", "20$/VE va MU_XANH")]
//        [TestCase(95, "male", "10$/VE va MU_XANH")]
//        [TestCase(-100, "female", "INPUT_KHONG_HOP_LE, age -100 <= 0")]
//        [TestCase(2, "female", "MIEN_PHI_VE va MU_HONG")]
//        [TestCase(19, "aaaaa", "Gioi tinh aaaaa khong hop le, dau vao phai la male hoac female")]
//        [TestCase(-1, "aaaaa", "INPUT_KHONG_HOP_LE, age -1 <= 0 va Gioi tinh aaaaa khong hop le, dau vao phai la male hoac female")]
//        [TestCase(2, "aaaaa", "Gioi tinh aaaaa khong hop le, dau vao phai la male hoac female")]
//        [TestCase(35, "aaaaa", "Gioi tinh aaaaa khong hop le, dau vao phai la male hoac female")]
//        [TestCase(95, "aaaaa", "Gioi tinh aaaaa khong hop le, dau vao phai la male hoac female")]
//        [TestCase(0, "male", "INPUT_KHONG_HOP_LE, age 0 <= 0")]
//        [TestCase(65, "female", "20$/VE va MU_HONG")]
//        public void TicketAndGiftResult_GetINTAgeAndGift_PriceAndGift(int age, string gender, string expectedResult ) {
//            var ticketProgram = new TicketProgram();
//            //Act
//            var actualResult = ticketProgram.TicketAndGiftResult(age,gender);
//            //Assert
//            Assert.That(actualResult, Is.EqualTo(expectedResult));
//        }
//        [Test]
//        [TestCase(1.2, "Female", "INPUT_KHONG_HOP_LE, 1.2 khong phai la so nguyen")]
//        [TestCase(1.2, "aaaaa", "INPUT_KHONG_HOP_LE, 1.2 khong phai la so nguyen va Gioi tinh aaaaa khong hop le, khong phai la male hoac female")]
//        public void TicketAndGiftResult_GetDOUBLEAgeAndGift_PriceAndGift(double age, string gender, string expectedResult)
//        {
//            var tk = new TicketProgram();
//            //Act
//            var actualResult = tk.TicketAndGiftResult(age, gender);
//            //Assert
//            Assert.That(actualResult, Is.EqualTo(expectedResult));
//        }
//    }
//}
