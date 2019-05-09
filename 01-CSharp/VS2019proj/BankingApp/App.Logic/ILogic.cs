using System;
using System.Collections.Generic;
using System.Text;

namespace App.Logic
{
    interface ILogic<T>
    {
        //Methods
        void Swap<T>(T a, T b);
        //Properties
        int value { get; set; }
        //Events
        //Indexers

    }
}
