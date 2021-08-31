using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace WebAPI.Controllers
{
    public class marksheetController: ApiController
    {
        //get api code
        //[HttpGet]
        //public IEnumerable<student_marksheet> Get()
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        return entities.student_marksheet.ToList();
        //    }
        //}
        //end

        //get api code by id
        //[HttpGet]
        //public student_marksheet Get(string student_id)
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        return entities.student_marksheet.FirstOrDefault(e => e.student_id == student_id);
        //    }
        //}
        //end

        //post api code
        //[HttpPost]
        //public void Post([FromBody] student_marksheet value)
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        entities.student_marksheet.Add(value);
        //        entities.SaveChanges();
        //    }
        //}
        //end

        //put api code
        //[HttpPut]
        //public void Put(string student_id, [FromBody] student_marksheet value)
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        student_marksheet marksheet = entities.student_marksheet.FirstOrDefault(e => e.student_id == student_id);
        //        marksheet.first_name = value.first_name;
        //        marksheet.middle_name = value.middle_name;
        //        marksheet.last_name = value.last_name;
        //        marksheet.year_from = value.year_from;
        //        marksheet.year_to = value.year_to;
        //        marksheet.father_name = value.father_name;
        //        marksheet.mother_name = value.mother_name;
        //        marksheet.date_of_birth = value.date_of_birth;
        //        marksheet.school_name = value.school_name;
        //        marksheet.course_stream = value.course_stream;
        //        entities.SaveChanges();
        //    }
        //}
        //end

        //delete api code
        //[HttpDelete]
        //public void Delete(string student_id)
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        student_marksheet marksheet = entities.student_marksheet.FirstOrDefault(e => e.student_id == student_id);
        //        entities.student_marksheet.Remove(marksheet);
        //        entities.SaveChanges();
        //    }
        //}
        //end
    }
}