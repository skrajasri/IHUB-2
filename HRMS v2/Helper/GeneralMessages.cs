using System.Collections.Generic;

namespace HRMS_v2.Helper
{
    /// <summary>
    /// Response code
    /// </summary>
    public enum eResponseCode { OK = 200 , BadRequest = 400};

    public static class ResponseStatusCode
    {
        public static Dictionary<eResponseCode, bool> NormalStatusCode = new Dictionary<eResponseCode, bool>
        {
            {eResponseCode.OK, true },
            {eResponseCode.BadRequest, false }
        };
        
    }

    /// <summary>
    /// Message Definition for all Responses
    /// </summary>
    public enum eResponseMessages
    {
        OKResponse,
        NoTokenInformation,
        RecordNotFound
    }
    public static class ResponseMessages
    {
        /// <summary>
        /// Message Code for all Responses
        /// </summary>
        /// <value></value>
        public static Dictionary<eResponseMessages, string> NormalMessagesCode = new Dictionary<eResponseMessages, string>
        {
            {eResponseMessages.OKResponse,"MSG200" },
            {eResponseMessages.NoTokenInformation,"MSG400" },
            {eResponseMessages.RecordNotFound,"MSG400" },
        };
        
        /// <summary>
        /// Message Detail for all Responses
        /// </summary>
        /// <value></value>
        public static Dictionary<eResponseMessages, string> NormalMessagesContent = new Dictionary<eResponseMessages, string>
        {
            {eResponseMessages.OKResponse,"" },
            {eResponseMessages.NoTokenInformation,"NoTokenInformation"},
            {eResponseMessages.RecordNotFound,"Record not found for the given input"},
        };
    }
}