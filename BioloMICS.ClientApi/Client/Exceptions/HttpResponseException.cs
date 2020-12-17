using BioloMICS.ClientApi.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BioloMICS.ClientApi.Client.Exceptions
{
	public class HttpResponseException : Exception
	{
		public HttpStatusCode StatusCode { get; private set; }
		public string ErrorMessage { get; private set; }

		public string ErrorDescription { get; private set; }

		public HttpResponseException(ProblemDetails details)
		{
			StatusCode = details.Status;
			ErrorMessage = details.Title;
			ErrorDescription = details.Detail;
		}

		public HttpResponseException(HttpStatusCode statusCode, string errorMessage, string errorDescription = null)
		{
			StatusCode = statusCode;
			ErrorMessage = errorMessage;
			ErrorDescription = errorDescription;
		}
	}
}
