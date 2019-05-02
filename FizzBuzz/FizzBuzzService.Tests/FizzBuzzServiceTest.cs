using NUnit.Framework;
using FizzBuzz.Service;
using System;

namespace Tests
{
    public class FizzBuzzServiceTests
    {
        private readonly FizzBuzzService _fizzBuzzService;
       
        public FizzBuzzServiceTests()
        {
            _fizzBuzzService = new FizzBuzzService();
        }
        /* 
        Beholdt de testene jeg skrev for å teste den private funksjonen i FizzBuzzService.
        I prinsippet skal man fjerne disse testene ettersom den ene testen nå tester det samme som disse.
        Men lot den være med så dere kan få se det.

        [Test]
        public void ReturnFizzOnThree()
        {
            var result = _fizzBuzzService.GetFizzBuzz(3);
            Assert.That(result, Is.EqualTo("Fizz"));
        }
        
        [Test]
        public void ReturnBuzzOnFive()  
        {
            var result = _fizzBuzzService.GetFizzBuzz(5);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void ReturnFizzBuzzOnFifteen()
        {
            var result = _fizzBuzzService.GetFizzBuzz(15);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
        [Test]
        public void ReturnNumberOnNotDivisable()
        {
            var result = _fizzBuzzService.GetFizzBuzz(2);
            Assert.That(result, Is.EqualTo("2"));
        }
        */

        [Test]
        public void ReturnEnumerableUpToFifteen() 
        {
            string expectedResult = "12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz";
            string receivedResult = "";

            foreach(var result in _fizzBuzzService.GetFizzBuzz(15))
            {
                receivedResult += result;
            }

            Assert.That(expectedResult, Is.EqualTo(receivedResult));
        }

    }
}