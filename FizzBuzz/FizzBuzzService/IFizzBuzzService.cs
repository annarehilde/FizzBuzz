using System.Collections.Generic;

namespace FizzBuzz.Service
{
    //Interface for FizzBuzz, gir gode muligheter for å kunne utvide funksjonaliteten
    public interface IFizzBuzzService
    {
        IEnumerable<string> GetFizzBuzz(uint n);
    }
}
