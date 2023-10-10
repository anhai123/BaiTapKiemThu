using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket;
using DongDieuKhien;

namespace TicketProgramTests
{
    [TestFixture]
    public class KiemThuDongDieuKhienTests
    {
        [Test]
        [TestCase(-1, 'I')]
        [TestCase(9, 'A')]
        [TestCase(8, 'B')]
        [TestCase(6.5, 'C')]
        [TestCase(5, 'D')]
        [TestCase(0, 'F')]
        public void Grade_GetRankByGrade_RankPoint(double point, char expectedResult)
        {
            var tk = new KiemThuDongDieuKhien();
            //Act
            var actualResult = tk.Grade(point);
            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(1, 1, 1)]
        [TestCase(0, 0)]
        [TestCase(2, 3, 1, 2)]
        [TestCase(4, 10, 1, 2, 3, 4)]
        public void Sum_AddUpArrayValue_SumArrayResult( int n, int expectedResult,params int[] array)
        {
            var tk = new KiemThuDongDieuKhien();
            //Act
            var actualResult = tk.Sum(array,n);
            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(40, 1.5, "Thiếu cân")]
        [TestCase(60, 1.7, "Bình thường")]
        [TestCase(72, 1.65, "Béo phì")]
        public void CalculateBMI_WeightAndHeight_BodyStatus(double weight, double height, string expectedResult)
        {
            var tk = new KiemThuDongDieuKhien();
            //Act
            var actualResult = tk.calculateBMI(weight,height);
            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(65, "A")]
        [TestCase(66, "B")]
        [TestCase(67, "C")]
        [TestCase(69, "haven't check")]
        public void Foo_CheckInputNumber_String(int x,  string expectedResult)
        {
            var tk = new KiemThuDongDieuKhien();
            //Act
            var actualResult = tk.Foo(x);
            
            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
