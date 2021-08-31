using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace WebAPI.Controllers
{
    public class subjectsController : ApiController
    {
        //get api code
        [HttpGet]
        public IEnumerable<subject> Get()
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                return entities.subjects.ToList();
            }
        }
        //end

        //get api code by id
        [HttpGet]
        public subject Get(string subject_id)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                return entities.subjects.FirstOrDefault(e=>e.subject_id==subject_id);
            }
        }
        //end

        //post api code
        [HttpPost]
        public void Post([FromBody] subject value)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                entities.subjects.Add(value);
                entities.SaveChanges();
            }
        }
        //end

        //put api code
        [HttpPut]
        public void Put(string subject_id, [FromBody]subject value)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                subject subjectt = entities.subjects.FirstOrDefault(e=>e.subject_id==subject_id);
                subjectt.subject_name = value.subject_name;
                entities.SaveChanges();
            }
        }
        //end

        //delete api code
        [HttpDelete]
        public void Delete(string subject_id)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                subject subjectt = entities.subjects.FirstOrDefault(e=>e.subject_id==subject_id);
                entities.subjects.Remove(subjectt);
                entities.SaveChanges();
            }
        }
        //end




    }
}
