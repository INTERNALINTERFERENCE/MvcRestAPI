using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Data
{
    public class Repository : ICommanderRepo
    {
        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan"
            };
        }

        public IEnumerable<Command> GetCommands()
        {
            var commands = new List<Command>
            {
                new Command
                {
                    Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan"
                },
                new Command
                {
                    Id = 1, HowTo = "Cut a bread", Line = "Get a knife", Platform = "knife & shopping board"
                },
                new Command
                {
                    Id = 2, HowTo = "Make cup of tea", Line = "Place teabag in a cup", Platform = "Kettle & Cup"
                },               
            };
            return commands;
        }      
    }
}
