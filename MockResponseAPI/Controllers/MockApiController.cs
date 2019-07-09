using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using Microsoft.AspNet.OData;
using MockResponseAPI.Models;

namespace MockResponseAPI.Controllers
{
    public class MockApiController : ODataController
    {
        public List<odata> Get([FromODataUri] string ValueSecret)
        {
            List<odata> response = new List<odata>();
            var MatchKey = System.Configuration.ConfigurationManager.AppSettings["MatchKey"];
            if(MatchKey == ValueSecret)
            {
                response.Add(new odata
                {
                    FirstName = "John",
                    LastName = "Smith",
                    Gender = "Male"
                });
                response.Add(new odata
                {
                    FirstName = "Kelly",
                    LastName = "Lanes",
                    Gender = "Female"
                });
                response.Add(new odata
                {
                    FirstName = "John",
                    LastName = "Wright",
                    Gender = "Male"
                });
                response.Add(new odata
                {
                    FirstName = "Steve",
                    LastName = "Smith",
                    Gender = "Male"
                });
            }
            return response;
        }

        // GET api/values/5
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public string Get(int id)
        {
            return "value";
        }
    }
}
