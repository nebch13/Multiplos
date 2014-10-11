using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplos
{
   public class NumeroMultiplo
    {
       public string GetMultiploNumero(int num) {
           var respuesta = "";




           if (num % 3 == 0 && num % 5 == 0) {
               respuesta = "FizzBuzz";
           }
           else if (num % 3 == 0)
           {
               respuesta = "Fizz";
           }
           else if (num % 5 == 0)
           {
               respuesta = "Buzz";
           }
           else
           {
               respuesta = Convert.ToString(num);
           }
              
           
           return respuesta;
       
       }
    }
}
