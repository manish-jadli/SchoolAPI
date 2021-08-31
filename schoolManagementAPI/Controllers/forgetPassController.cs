using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace WebAPI.Controllers
{
    public class forgetPassController: ApiController
    {
        //get api code
        //[HttpGet]
        //public IEnumerable<forget_password> Get()
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        return entities.forget_password.ToList();
        //    }
        //}
        //end

        //get api code by id
        //[HttpGet]
        //public forget_password Get(string login_id)
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        return entities.forget_password.FirstOrDefault(e => e.login_id == login_id);
        //    }
        //}
        //end

        //get post code
        //[HttpPost]
        //public void Post([FromBody]forget_password value)
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        entities.forget_password.Add(value);
        //        entities.SaveChanges();
        //    }
        //}
        //end

        //put api code
        //[HttpPut]
        //public void Put(string login_id, [FromBody]forget_password value)
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        forget_password forget_Pass = entities.forget_password.FirstOrDefault(e => e.login_id == login_id);
        //        forget_Pass.id = value.id;
        //        forget_Pass.password = value.password;
        //        forget_Pass.new_password = value.new_password;
        //        forget_Pass.confirm_password = value.confirm_password;
        //        entities.SaveChanges();
        //    }
        //}
        //end

        //delete api code
        //[HttpDelete]
        //public void Delete(string login_id)
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        forget_password forget_pass = entities.forget_password.FirstOrDefault(e => e.login_id == login_id);
        //        entities.forget_password.Remove(forget_pass);
        //        entities.SaveChanges();
        //    }
        //}
        //end
    }
}