using BioloMICS.ClientApi.Client.Exceptions;
using RestSharp;

namespace BioloMICS.ClientApi.Extentions
{
	static class RestResponseExtensions
	{
		public static void ThrowExceptionOnResponseError(this IRestResponse response)
		{
			if (!response.IsSuccessful)
			{
				if (response.ResponseStatus == ResponseStatus.Completed)
				{
					throw new HttpResponseException(response.StatusCode, response.Content);
				}
				else
				{
					throw response.ErrorException;
				}
			}
		}
	}
}
