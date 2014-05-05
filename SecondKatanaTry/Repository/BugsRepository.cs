using SecondKatanaTry.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondKatanaTry.Repository
{
    public interface IBugsRepository
    {
        IEnumerable<Bug> GetBugs();
    }

    public class BugsRepository : IBugsRepository
    {
        private static IList<Bug> _bugs = new List<Bug>(); 
        static BugsRepository()
        {
            _bugs.Add(new Bug { Id = 1, State = "backlog", Title="This is a baclog bug" });
            _bugs.Add(new Bug { Id = 2, State = "backlog", Title = "This isn another backlog bug" });
            _bugs.Add(new Bug { Id = 3, State = "done", Title = "This is done" });
            _bugs.Add(new Bug { Id = 4, State = "working", Title = "This is verified to be working" });
            _bugs.Add(new Bug { Id = 5, State = "working", Title = "This is working aswell" });
            _bugs.Add(new Bug { Id = 6, State = "done", Title = "This is done bug pending verification." });
        }

        public IEnumerable<Bug> GetBugs()
        {
            return new List<Bug>(_bugs);
        }
    }
}