using System;
using System.Net;

namespace BioloMICS.ClientApi.Client.Exceptions
{
	public class HttpResponseException : Exception
	{
		public HttpStatusCode StatusCode { get; private set; }
		public string ErrorMessage { get; private set; }

		public string ErrorDescription { get; private set; }

		public HttpResponseException(HttpStatusCode statusCode, string errorMessage, string errorDescription = null)
		{
			StatusCode = statusCode;
			ErrorMessage = errorMessage;
			ErrorDescription = errorDescription;
		}
	}
}
