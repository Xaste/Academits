using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single
{
    public class Singleton
    {
        private static Singleton _uniqueInstance;

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (_uniqueInstance == null)
            {
                _uniqueInstance = new Singleton();
            }
            return _uniqueInstance;
        }
    }
}
