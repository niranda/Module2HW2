using System;

namespace StyleCop.Services
{
    public class IdService
    {
        private readonly Random _randomHandler = new Random();
        public int IdNumber
        {
            get
            {
                return _randomHandler.Next(100000);
            }
        }
    }
}
