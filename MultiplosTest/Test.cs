using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Multiplos;

namespace MultiplosTest
{
    [TestFixture]
   public class Test
    {

        [Test]
        public void TestNumero1()
        {
            //arranque
            var numero = new NumeroMultiplo();

            var num = numero.GetMultiploNumero(1);

            Assert.AreEqual("1", num);
        }

        [Test]
        public void TestNumero2()
        {
            //arranque
            var numero = new NumeroMultiplo();

            var num = numero.GetMultiploNumero(2);

            Assert.AreEqual("2", num);
        }

        [Test]
        public void TestNumero3()
        {
            //arranque
            var numero = new NumeroMultiplo();

            var num = numero.GetMultiploNumero(3);

            Assert.AreEqual("Fizz", num);
        }

        [Test]
        public void TestNumero4()
        {
            //arranque
            var numero = new NumeroMultiplo();

            var num = numero.GetMultiploNumero(4);

            Assert.AreEqual("4", num);
        }

        [Test]
        public void TestNumero5()
        {
            //arranque
            var numero = new NumeroMultiplo();

            var num = numero.GetMultiploNumero(5);

            Assert.AreEqual("Buzz", num);
        }

        [Test]
        public void TestNumero15()
        {
            //arranque
            var numero = new NumeroMultiplo();

            var num = numero.GetMultiploNumero(15);

            Assert.AreEqual("FizzBuzz", num);
        }
    }
}
