using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace WebAPI.Controllers
{
    public class schoolAddressController : ApiController
    {
        //get api code
        //[HttpGet]
        //public IEnumerable<school_address> Get()
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //        return entities.school_address.ToList();
        //}
        //end

        //get api code by id
        //[HttpGet]
        //public school_address Get(string address_id)
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        return entities.school_address.FirstOrDefault(e => e.address_id == address_id);
        //    }
        //}
        //end

        //post api code
        //[HttpPost]
        //public void Post([FromBody] school_address value)
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        entities.school_address.Add(value);
        //        entities.SaveChanges();
        //    }
        //}
        //end

        //put api code
        //[HttpPut]
        //public void Put(string address_id, [FromBody] school_address value)
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        school_address schoolAddress = entities.school_address.FirstOrDefault(e => e.address_id == address_id);
        //        schoolAddress.address_id = value.address_id;
        //        schoolAddress.school_name = value.school_name;
        //        schoolAddress.address_detail = value.address_detail;
        //        schoolAddress.img = value.img;
        //        entities.SaveChanges();
        //    }
        //}
        //end

        //delete api code
        //[HttpDelete]
        //public void Delete(string address_id)
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        school_address schoolAddress = entities.school_address.FirstOrDefault(e => e.address_id == address_id);
        //        entities.school_address.Remove(schoolAddress);
        //        entities.SaveChanges();
        //    }
        //}
        //end





    }
}