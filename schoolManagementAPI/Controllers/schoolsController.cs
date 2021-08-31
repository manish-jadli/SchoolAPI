using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace WebAPI.Controllers
{
    public class schoolsController : ApiController
    {
        //get api code
        [HttpGet]
        public IEnumerable<school> Get()
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                return entities.schools.ToList();
            }
        }
        //end

        //get api code by id
        [HttpGet]
        public school Get(string school_id)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                return entities.schools.FirstOrDefault(e=>e.school_id==school_id);
            }
        }
        //end

        //post api code
        [HttpPost]
        public void Post([FromBody] school value)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                entities.schools.Add(value);
                entities.SaveChanges();
            }
        }
        //end

        //put api code
        [HttpPut]
        public void Put(string school_id, [FromBody] school value)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                school schoool = entities.schools.FirstOrDefault(e => e.school_id == school_id);
                schoool.school_name = value.school_name;
                schoool.address_id = value.address_id;
                schoool.school_principal = value.school_principal;
                schoool.other_school_details = value.other_school_details;
                entities.SaveChanges();
            }
        }
        //end

        //delete api code
        [HttpDelete]
        public void Delete(string school_id)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                school schoool = entities.schools.FirstOrDefault(e => e.school_id == school_id);
                entities.schools.Remove(schoool);
                entities.SaveChanges();
            }
        }
        //end

    }
}
