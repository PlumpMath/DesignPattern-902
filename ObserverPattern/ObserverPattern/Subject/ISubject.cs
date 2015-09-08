﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface ISubject
    {
        void registerObserver(IObserver O);
        void removeObserver(IObserver O);
        void notifyObserver();
    }
}
