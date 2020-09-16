
using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                 new Command{id = 0, HowTo="Boil an egg", Line="Boil water", Platform="kettle & Pan"},
                 new Command{id = 0, HowTo="Boil an egg", Line="Boil water", Platform="kettle & Pan"},
                 new Command{id = 0, HowTo="Boil an egg", Line="Boil water", Platform="kettle & Pan"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{id = 0, HowTo="Boil an egg", Line="Boil water", Platform="kettle & Pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }

}