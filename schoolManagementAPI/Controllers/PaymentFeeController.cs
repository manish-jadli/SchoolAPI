using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace WebAPI.Controllers
{
    public class PaymentFeeController : ApiController
    {
        //get api code
        //[HttpGet]
        //public IEnumerable<payment_fee> Get()
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        return entities.payment_fee.ToList();
        //    }
        //}
        //end

        //get api code by id
        //[HttpGet]
        //public payment_fee Get(string student_id)
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        return entities.payment_fee.FirstOrDefault(e => e.student_id == student_id);
        //    }
        //}
        //end

        //post api code
        //[HttpPost]
        //public void Post([FromBody] payment_fee value)
        //{
        //    using (schoolManagementEntities2 entites = new schoolManagementEntities2())
        //    {
        //        entites.payment_fee.Add(value);
        //        entites.SaveChanges();
        //    }
        //}
        //end

        //put api code
        //[HttpPut]
        //public void Put(string student_id, [FromBody] payment_fee value)
        //{
        //    using (schoolManagementEntities2 entities = new schoolManagementEntities2())
        //    {
        //        payment_fee payment = entities.payment_fee.FirstOrDefault(e => e.student_id == student_id);
        //        payment.gender = value.gender;
        //        payment.first_name = value.first_name;
        //        payment.middle_name = value.middle_name;
        //        payment.last_name = value.last_name;
        //        payment.game_fee = value.game_fee;
        //        payment.@class = value.@class;
        //        payment.subject = value.subject;
        //        payment.fees = value.fees;
        //        payment.tution_fee = value.tution_fee;
        //        payment.library_fee = value.library_fee;
        //        payment.paneltie_fees = value.paneltie_fees;
        //        payment.payment_mode = value.payment_mode;
        //        payment.other_fee = value.other_fee;
        //        payment.gender = value.gender;
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
        //        payment_fee payment = entities.payment_fee.FirstOrDefault(e => e.student_id == student_id);
        //        entities.payment_fee.Remove(payment);
        //        entities.SaveChanges();
        //    }
        //}
        //end


    }
}