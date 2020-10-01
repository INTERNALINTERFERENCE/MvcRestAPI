using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetCommands();
        Command GetCommandById(int id);
    }
}
