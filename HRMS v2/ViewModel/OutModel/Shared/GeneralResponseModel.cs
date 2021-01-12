namespace HRMS_v2.ViewModel.OutModel.Shared
{
    /// <summary>
    /// General Response variable Declaration for all Api
    /// </summary>
    

    public class Result
    {
        public bool status { get; set; }
        public string msgCode { get; set; }
        public string msgDetail { get; set; }
    }

    public class Response
    {
        public Result result { get; set; }
        public object? data { get; set; }
    }

    public class GeneralResponseModel
    {
        public Response response { get; set; }
    }
}
