using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;

namespace DependencyPropertyInitialization
{
    public class NamedClass : ViewModelBase
    {
        private static int classCounter = 0;

        private int _counter; public int Counter { get => _counter; set { Set(() => Counter, ref _counter, value); }}


        public NamedClass()
        {
            Counter = classCounter++;
        }

        public override string ToString()
        {
            return Counter.ToString();
        }
    }
}
