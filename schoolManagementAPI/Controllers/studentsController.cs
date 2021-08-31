using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace WebAPI.Controllers
{
    public class studentsController : ApiController
    {
        //get api code
        [HttpGet]
        public IEnumerable<student> Get()
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                return entities.students.ToList();
            }
        }
        //end

        //get api code by id
        [HttpGet]
        public student Get(string student_id)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                return entities.students.FirstOrDefault(e=>e.student_id==student_id);
            }
        }
        //end

        //post api code
        [HttpPost]
        public void Post([FromBody] student value)
        {
            try
            {
                using (schoolManagementEntities2 entites = new schoolManagementEntities2())
                {
                    entites.students.Add(value);
                    entites.SaveChanges();
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                string validationErrorMsg = "";
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        validationErrorMsg = validationErrorMsg + string.Format("Property: {0} Error: {1}",
                        validationError.PropertyName,
                        validationError.ErrorMessage);
                    }
                }
            }

        }
        //end

        //put api code
        [HttpPut]
        public void Put(string student_id, [FromBody] student value)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                student studentt = entities.students.FirstOrDefault(e => e.student_id == student_id);
                studentt.gender = value.gender;
                studentt.first_name = value.first_name;
                studentt.middle_name = value.middle_name;
                studentt.last_name = value.last_name;
                studentt.date_of_birth = value.date_of_birth;
                studentt.other_student_details = value.other_student_details;
                studentt.class_code = value.class_code;
                studentt.address = value.address;
                studentt.father_name = value.father_name;
                studentt.mother_name = value.mother_name;
                studentt.admission_on = value.admission_on;
                studentt.school_name = value.school_name;
                studentt.mobile_no = value.mobile_no;
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
                student studentt = entities.students.FirstOrDefault(e => e.student_id == student_id);
                entities.students.Remove(studentt);
                entities.SaveChanges();
            }
        }
        //end





    }
}
