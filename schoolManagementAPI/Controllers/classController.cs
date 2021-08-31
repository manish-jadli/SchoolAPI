using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace WebAPI.Controllers
{
    public class classController : ApiController
    {
        //get api code
        [HttpGet]
        public IEnumerable<student_classes> Get()
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                return entities.student_classes.ToList();
            }
        }
        //end

        //get api code by id
        [HttpGet]
        public student_classes Get(string student_id)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                return entities.student_classes.FirstOrDefault(e => e.student_id == student_id);
            }
        }
        //end

        //get post code
        [HttpPost]
        public void Post([FromBody]student_classes value)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                entities.student_classes.Add(value);
                entities.SaveChanges();
            }
        }
        //end

        //put api code
        [HttpPut]
        public void Put(string student_id, [FromBody]student_classes value)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                student_classes studentClass = entities.student_classes.FirstOrDefault(e=>e.student_id==student_id);
                studentClass.class_id = value.class_id;
                studentClass.date_from = value.date_from;
                studentClass.date_to = value.date_to;
                //studentClass.first_name = value.first_name;
                //studentClass.last_name = value.last_name;
                //studentClass.middle_name = value.middle_name;
                //studentClass.gender = value.gender;
                entities.SaveChanges();
            }
        }
        //end

        //delete api code
        [HttpDelete]
        public void Delete(string student_id)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                student_classes studentClass = entities.student_classes.FirstOrDefault(e=>e.student_id==student_id);
                entities.student_classes.Remove(studentClass);
                entities.SaveChanges();
            }
        }
        //end

    }
}
