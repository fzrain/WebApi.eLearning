using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;
using Learning.Data;
using Learning.Data.Entities;

namespace Learning.ODataService.Controllers
{
    public class CoursesController : EntitySetController<Course, int>
    {
        LearningContext ctx = new LearningContext();

        [Queryable(PageSize = 10)]
        public override IQueryable<Course> Get()
        {
            return ctx.Courses.AsQueryable();
        }

        protected override Course GetEntityByKey(int key)
        {
            return ctx.Courses.Find(key);
        }
    }
}
