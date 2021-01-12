using System;
using System.Collections.Generic;

namespace HRMS.ViewModel.OutModel
{
    
    public class API0001_OutModel  {
        public Response response { get; set; } 
    }
    public class Result    {
        public bool status { get; set; } 
        public string msgCode { get; set; } 
        public string msgDetail { get; set; } 
    }

    public class Data    {
        public string name { get; set; } 
        public int employee_id { get; set; } 
        public string employee_code { get; set; } 
        public string organization_code { get; set; } 
    }

    public class Response    {
        public Result result { get; set; } 
        public Data data { get; set; } 
    }

}

