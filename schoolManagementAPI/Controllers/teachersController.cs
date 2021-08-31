using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace WebAPI.Controllers
{
    public class teachersController : ApiController
    {
        //get api code
        [HttpGet]
        public IEnumerable<teacher> Get()
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                return entities.teachers.ToList();
            }
        }
        //end

        //get api code by id
        [HttpGet]
        public teacher Get(string teacher_id)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                return entities.teachers.FirstOrDefault(e => e.teacher_id == teacher_id);
            }
        }
        //end

        //post api code
        [HttpPost]
        public void Post([FromBody]teacher value)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                entities.teachers.Add(value);
                entities.SaveChanges();
            }
        }
        //end

        //put api code
        [HttpPut]
        public void Put(string teacher_id, [FromBody] teacher value)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                teacher teacherr = entities.teachers.FirstOrDefault(e => e.teacher_id == teacher_id);
                teacherr.school_id = value.school_id;
                teacherr.gender = value.gender;
                teacherr.first_name = value.first_name;
                teacherr.middle_name = value.middle_name;
                teacherr.last_name = value.last_name;
                teacherr.other_teacher_details = value.other_teacher_details;
                entities.SaveChanges();
            }
        }
        //end

        //delete api code
        [HttpDelete]
        public void Delete(string teacher_id)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                teacher teacherr = entities.teachers.FirstOrDefault(e => e.teacher_id == teacher_id);
                entities.teachers.Remove(teacherr);
                entities.SaveChanges();
            }
        }
        //end




    }
}
