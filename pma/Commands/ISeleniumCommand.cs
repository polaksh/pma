using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pma.Commands
{
    public interface ISeleniumCommand<T> where T : CommandOptions
    {
        void Execute(T options);
    }

    public abstract class CommandOptions { }
}
