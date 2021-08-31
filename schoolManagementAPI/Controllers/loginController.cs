using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace WebAPI.Controllers
{
    public class loginController: ApiController
    {
        //get api code
        //[HttpGet]
        //public IEnumerable<login_info> Get()
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        return entities.login_info.ToList();
        //    }
        //}
        //end

        //get api code by id
        //[HttpGet]
        //public login_info Get(string login_id)
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        return entities.login_info.FirstOrDefault(e => e.login_id == login_id);
        //    }
        //}
        //end

        //get post code
        //[HttpPost]
        //public void Post([FromBody]login_info value)
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        entities.login_info.Add(value);
        //        entities.SaveChanges();
        //    }
        //}
        //end

        //put api code
        //[HttpPut]
        //public void Put(string login_id, [FromBody]login_info value)
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        login_info login = entities.login_info.FirstOrDefault(e => e.login_id == login_id);
        //        login.username = value.username;
        //        login.password = value.password;
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
        //        login_info login = entities.login_info.FirstOrDefault(e => e.login_id == login_id);
        //        entities.login_info.Remove(login);
        //        entities.SaveChanges();
        //    }
        //}
        //end
    }
}