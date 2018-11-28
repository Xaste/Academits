using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Single
{
    public sealed class ChocolateBoiler
    {
        private bool _empty;
        private bool _boiled;

        //private static ChocolateBoiler _source = null;
        //private static readonly object threadlock = new object();

        private static readonly Lazy<ChocolateBoiler> lazy = new Lazy<ChocolateBoiler>(() => new ChocolateBoiler());

        public static ChocolateBoiler Source { get { return lazy.Value; } }

        /*public static ChocolateBoiler Source
        {
            get
            {
                lock (threadlock)
                {
                    if (_source == null)
                    {
                        _source = new ChocolateBoiler();
                    }
                }

                return _source;
            }
        }*/

        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }



        /*public static ChocolateBoiler GetInstance()
        {
            if (ReferenceEquals(Source, null))
            {
                Source = new ChocolateBoiler();
            }

            return Source;
        }*/

        public void Fill()
        {
            if (IsEmpty())
            {
                _empty = false;
                _boiled = false;
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                _empty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                _boiled = true;
            }
        }

        public bool IsEmpty()
        {
            return _empty;
        }

        public bool IsBoiled()
        {
            return _boiled;
        }
    }
}
