using System.Threading;
using System;
using System.Collections.Generic;

namespace Observer
{
        public interface IObserver
    {
        void Update(Temperature value);
    }
}