using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.DataAccessLayer;

namespace WebApplication3.Models
{
    public class ParameterBusinessLayer
    {
        public List<Parameter> GetParameters()
        {
            WebAppDAL webappDal = new WebAppDAL();
            return webappDal.Parameters.ToList();
        }
    }
}