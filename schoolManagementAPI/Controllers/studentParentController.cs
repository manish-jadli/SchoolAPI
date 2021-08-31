
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace WebAPI.Controllers
{
    public class studentParentController : ApiController
    {
        //get api code
        [HttpGet]
        public IEnumerable<parent> Get()
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                return entities.parents.ToList();
            }
        }
        //end

        //get api code by id
        [HttpGet]
        public parent Get(string parent_id)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                return entities.parents.FirstOrDefault(e => e.parent_id == parent_id);
            }
        }
        //end

        //post api code
        [HttpPost]
        public void Post([FromBody]parent value)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                entities.parents.Add(value);
                entities.SaveChanges();
            }
        }
        //end

        //put api code
        [HttpPut]
        public void Put(string parent_id, [FromBody] parent value)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                parent parented = entities.parents.FirstOrDefault(e => e.parent_id == parent_id);
                parented.gender = value.gender;
                parented.first_name = value.first_name;
                parented.middle_name = value.middle_name;
                parented.last_name = value.last_name;
                parented.other_parent_details = value.other_parent_details;
                entities.SaveChanges();
            }
        }
        //end

        //delete api code
        [HttpDelete]
        public void Delete(string parent_id)
        {
            using (schoolManagementEntities2 entities = new schoolManagementEntities2())
            {
                parent parented = entities.parents.FirstOrDefault(e => e.parent_id == parent_id);
                entities.parents.Remove(parented);
                entities.SaveChanges();
            }
        }
        //end
    }
}