using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public enum PriceAction
    {
        Increase,
        Decrease
    }

    public interface ICommand
    {
        void ExecuteAction();
    }
}
