using System;
using System.Collections.Generic;

namespace FizzBuzz.Service
{
    public class FizzBuzzService : IFizzBuzzService
    {
        //Var originalt en public funksjon men etter å ha testet den ble den refactored slik til gjengeld for en generator funksjon
        private string _getFizzBuzz(uint i) 
        {
            string returnValue = "";

            if(i % 3 == 0) returnValue = "Fizz";
            if(i % 5 == 0) returnValue += "Buzz";
            if(returnValue == "") returnValue = i.ToString();
            
            return returnValue;
        }
        public IEnumerable<string> GetFizzBuzz(uint n) 
        {
            for(uint i = 1; i <= n; i++)
            {
                yield return _getFizzBuzz(i);
            }
        }
    }
}
