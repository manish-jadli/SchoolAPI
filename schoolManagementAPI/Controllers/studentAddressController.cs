using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace WebAPI.Controllers
{
    public class studentAddressController : ApiController
    {
        //get code here
        [HttpGet]
        public IEnumerable<student_addresses> Get()
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                return entities.student_addresses.ToList();
            }
        }
        //end

        //get api code by id
        [HttpGet]
        public student_addresses Get(string student_id)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                return entities.student_addresses.FirstOrDefault(e => e.student_id == student_id);
            }
        }
        //end

        //post api code
        [HttpPost]
        public void Post([FromBody]student_addresses value)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                entities.student_addresses.Add(value);
                entities.SaveChanges();
            }
        }
        //end

        //put api code
        [HttpPut]
        public void Put(string student_id, [FromBody]student_addresses value)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                student_addresses studentAddress = entities.student_addresses.FirstOrDefault(e => e.student_id == student_id);
                studentAddress.address_id = value.address_id;
                studentAddress.address_details = value.address_details;
                studentAddress.date_from = value.date_from;
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
                student_addresses studentAddress = entities.student_addresses.FirstOrDefault(e=>e.student_id==student_id);
                entities.student_addresses.Remove(studentAddress);
                entities.SaveChanges();
            }
        }
        //end

    }
}
