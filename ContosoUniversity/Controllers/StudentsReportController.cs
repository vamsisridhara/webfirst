using ContosoUniversity.DAL;
using System.Linq;
using System.Web.Http;

namespace ContosoUniversity.Controllers
{
    [System.Web.Http.RoutePrefix("api/students/report")]
    public class StudentsReportController : ApiController
    {
        private SchoolContext db = new SchoolContext();

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("getstudentsage")]
        public IHttpActionResult getStudentsAge()
        {
            var query = this.db.Students.Where(x => x.Age % 2 != 0).ToList();
            return Ok(query);
        }
    }
}
