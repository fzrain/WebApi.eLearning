using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using Learning.Data.Entities;
using Microsoft.Data.Edm;

namespace Learning.ODataService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapODataRoute("elearningOData", "OData", GenerateEdmModel());
        }
        private static IEdmModel GenerateEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Course>("Courses");
            builder.EntitySet<Enrollment>("Enrollments");
            builder.EntitySet<Subject>("Subjects");
            builder.EntitySet<Tutor>("Tutors");
            var tutorsEntitySet = builder.EntitySet<Tutor>("Tutors");

            tutorsEntitySet.EntityType.Ignore(s => s.UserName);
            tutorsEntitySet.EntityType.Ignore(s => s.Password);
           
            return builder.GetEdmModel();
        }
    }
}
