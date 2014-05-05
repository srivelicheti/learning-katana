using SecondKatanaTry.Entity;
using SecondKatanaTry.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SecondKatanaTry.Controllers
{
    public class BugsController:ApiController
    {
        private IBugsRepository _bugsRepository = new BugsRepository();
        public IEnumerable<Bug> Get()
        {
            return _bugsRepository.GetBugs();
        }

        [Route("api/bugs/backlog")]
        public Bug MoveToBacklog([FromBody] int id) {
          var bug =  _bugsRepository.GetBugs().First(b => b.Id == id);
          bug.State = "Backlog";
          return bug;
        }

        [Route("api/bugs/working")]
        public Bug MoveToWorking([FromBody] int id)
        {
            var bug = _bugsRepository.GetBugs().First(b => b.Id == id);
            bug.State = "working";
            return bug;
        }
        [Route("api/bugs/done")]
        public Bug MoveToDone([FromBody] int id)
        {
            var bug = _bugsRepository.GetBugs().First(b => b.Id == id);
            bug.State = "done";
            return bug;
        }
    }
}