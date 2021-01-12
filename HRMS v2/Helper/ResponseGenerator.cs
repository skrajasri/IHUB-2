using HRMS_v2.ViewModel.OutModel.Shared;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HRMS_v2.Helper
{    
    public static class ResponseGenerator
    {
        /// <summary>
        /// Response Generator Method for success
        /// </summary>
        /// <param name="resultContent"></param>
        /// <returns></returns>
        public static IActionResult Ok(object resultContent)
        {
            return CreateResponse(resultContent, eResponseCode.OK, eResponseMessages.OKResponse);
        }

        /// <summary>
        /// Response Generator Method for success with given MsgDetail as parameter
        /// </summary>
        /// <param name="resultContent"></param>
        /// <param name="ResponseMessage"></param>
        /// <returns></returns>
        public static IActionResult Ok(object resultContent, eResponseMessages ResponseMessage)
        {
            return CreateResponse(resultContent, eResponseCode.OK, ResponseMessage);
        }

        /// <summary>
        /// Response Generator Method for Failue or BadRequest
        /// </summary>
        /// <param name="resultContent"></param>
        /// <param name="ResponseMessage"></param>
        /// <returns></returns>
        public static IActionResult BadRequest(object resultContent, eResponseMessages ResponseMessage)
        {
            return CreateResponse(resultContent, eResponseCode.BadRequest, ResponseMessage);
        }

        /// <summary>
        /// Method for create the Response
        /// </summary>
        /// <param name="responseData"></param>
        /// <param name="ResponseStatus"></param>
        /// <param name="ResponseMessage"></param>
        /// <param name="ReplaceString"></param>
        /// <returns></returns>
        private static IActionResult CreateResponse(object responseData, eResponseCode ResponseStatus, eResponseMessages ResponseMessage, params string[] ReplaceString)
        {
            Result result = new Result();
            Response response = new Response();

            result.status = ResponseStatusCode.NormalStatusCode[ResponseStatus];
            result.msgCode = ResponseMessages.NormalMessagesCode[ResponseMessage];
            if (ReplaceString != null)
            {
                result.msgDetail = string.Format(ResponseMessages.NormalMessagesContent[ResponseMessage], ReplaceString);
            }
            else
            {
                result.msgDetail = ResponseMessages.NormalMessagesContent[ResponseMessage];
            }
            response.data = responseData;

            response.result = result;

            GeneralResponseModel genericResponse = new GeneralResponseModel
            {
                response = response
            };

            return new ObjectResult(genericResponse)
            {
                StatusCode = (int)ResponseStatus
            };
        }
    }
}
