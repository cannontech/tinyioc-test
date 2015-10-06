using System;

namespace tinyioctest
{
    public class Test : ITest
    {
        public Test()
        {
        }

        public string DoWork()
        {
            return @"this is work";
        }
    }
}

