using StudentProfileWebApi.Models;
using StudentProfileWebApi.Processors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentProfileWebApi.Controllers
{
    public class StudentController : ApiController
    {
        // GET api/values

        Repositories.GetStudent GetStudentData = new Repositories.GetStudent();
        [HttpPost]
        [Route("GetStudent")]
        public DataSet GetRecord(string id)
        {
            DataSet ds = GetStudentData.GetRecordbyID(id);
            return ds;
        }
        [HttpPost]
        [Route("GetStudentErecords")]
        public DataSet GetERecords(string id)
        {
            DataSet ds = GetStudentData.GetERecordbyID(id);
            return ds;
        }

        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}
        [HttpPost]
        [Route("SaveStudent")]
        // POST api/values
        public bool SaveStudent(Student student)
        {
            if (student == null) { return false; }
          return  StudentProcessor.ProcessStudent(student);

        }

        [HttpPost]
        [Route("UpdateStudent")]
        // POST api/values
        public bool UpdateStudent(Student student)
        {
            if (student == null) { return false; }
            return StudentProcessor.ProcessUpdateStudent(student);

        }
        [HttpPost]
        [Route("DeleteStudent")]
        // POST api/values
        public bool DeleteStudent(Student student)
        {
            if (student == null) { return false; }
            return StudentProcessor.ProcessDeleteStudent(student);

        }

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
