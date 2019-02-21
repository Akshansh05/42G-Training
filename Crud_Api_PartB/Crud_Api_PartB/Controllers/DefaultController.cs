using Crud_Api_PartB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crud_Api_PartB.Controllers
{
    
    public class DefaultController : ApiController
    {


        [Produces("application/json")]
        [System.Web.Http.Route("api/Default")]
        [System.Web.Http.HttpGet]
        public String Get()
        {
            string result=" ";
            BusinessModel Model_Get = new BusinessModel();
            result = Model_Get.show();
            return result;


        }
       
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/Default")]
        public Intern Post(Intern intern)
        {
            Intern Post_Obj;
            BusinessModel Model_Post = new BusinessModel();
            Post_Obj = Model_Post.Insert(intern);
            return Post_Obj;

        }
        [System.Web.Http.Route("api/Default/{id}")]
        [System.Web.Http.HttpPut]
        public Intern Put(Intern intern,int id)
        {
            Intern Put_Obj;
            BusinessModel Model_Put = new BusinessModel();
            Put_Obj = Model_Put.Update(intern,id);
            return Put_Obj;

        }

        
        [System.Web.Http.HttpDelete]
        [System.Web.Http.Route("api/Default/{id}")]
        public string Delete(Intern intern, int id)
        {
            String Output = "";
            BusinessModel Model_Delete = new BusinessModel();
            Output = Model_Delete.Delete(intern,id);
            return Output;
        }

    }
    }
