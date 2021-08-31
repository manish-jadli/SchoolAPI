using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace WebAPI.Controllers
{
    public class reportsController : ApiController
    {
        //get api code
        [HttpGet]
        public IEnumerable<report> Get()
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                return entities.reports.ToList();
            }
        }
        //end

        //get api code by id
        [HttpGet]
        public report Get(string report_id)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
              return  entities.reports.FirstOrDefault(e => e.report_id == report_id);
            }
        }
        //end

        //post api code
        [HttpPost]
        public void Post([FromBody]report value)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                entities.reports.Add(value);
                entities.SaveChanges();
            }
        }
        //end

        //put api code
        [HttpPut]
        public void Put(string report_id, [FromBody] report value)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
              report reported = entities.reports.FirstOrDefault(e => e.report_id == report_id);
                reported.student_id = value.student_id;
                reported.first_name = value.first_name;
                reported.middle_name = value.middle_name;
                reported.last_name = value.last_name;
                reported.gender=value.gender;
                reported.date_created = value.date_created;
                reported.report_content = value.report_content;
                reported.teacher_comments = value.teacher_comments;
                reported.other_report_details = value.other_report_details;
                entities.SaveChanges();
            }
        }
        //end

        //delete api code
        [HttpDelete]
        public void Delete(string report_id)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                report reported = entities.reports.FirstOrDefault(e => e.report_id == report_id);
                entities.reports.Remove(reported);
                entities.SaveChanges();
            }
        }
        //end

    }
}
