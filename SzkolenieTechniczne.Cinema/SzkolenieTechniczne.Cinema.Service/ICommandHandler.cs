using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Cinema.Service
{
    public interface ICommandHandler<in TCommand>
        where TCommand : ICommand
    {
        Result Handle(TCommand command);
    }
}
