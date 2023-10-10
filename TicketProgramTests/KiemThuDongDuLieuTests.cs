using DongDieuKhien;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TicketProgram;

namespace TicketProgramTests
{
    [TestFixture]
    public class KiemThuDongDuLieuTests
    {
        /// <summary>
        // The name of the method being tested.
        //  The scenario under which it's being tested.
        //  The expected behavior when the scenario is invoked.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="expectedResult"></param>
        [Test]
        [TestCase(3, 2, "x = 3, y = -1")]
        [TestCase(-3, 2, "x = 6, y = -4")]
        [TestCase(3, -2, "x = 3, y = -2")]
        public void BaiNhapXvaY_2IntNumbers_PrintXandY(int x, int y, string expectedResult)
        {
            var dongDuLieu = new KiemThuDongDuLieu();
            //Act
            var actualResult = dongDuLieu.BaiNhapXvaY(x,y);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(5, 2, "Héo")]
        [TestCase(6, 2, "Vừa")]
        [TestCase(8, 2, "Ngon")]
        [TestCase(10, 2, "Siêu tươi ngon")]
        public void  calculateFreshRatio_2DoubleWeightAnd_freshRatio(double freshWeight, double dryhWeight, string expectedResult)
        {
            var dongDuLieu = new KiemThuDongDuLieu();
            //Act
            var actualResult = dongDuLieu.calculateFreshRatio(freshWeight, dryhWeight);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
