/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// UsAppToPersonUsecaseResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Messaging.V1.Service
{

    public class UsAppToPersonUsecaseResource : Resource
    {
        private static Request BuildFetchRequest(FetchUsAppToPersonUsecaseOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Messaging,
                "/v1/Services/" + options.PathMessagingServiceSid + "/Compliance/Usa2p/Usecases",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch UsAppToPersonUsecase parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UsAppToPersonUsecase </returns>
        public static UsAppToPersonUsecaseResource Fetch(FetchUsAppToPersonUsecaseOptions options,
                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch UsAppToPersonUsecase parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UsAppToPersonUsecase </returns>
        public static async System.Threading.Tasks.Task<UsAppToPersonUsecaseResource> FetchAsync(FetchUsAppToPersonUsecaseOptions options,
                                                                                                 ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathMessagingServiceSid"> The SID of the Messaging Service to fetch the resource from </param>
        /// <param name="brandRegistrationSid"> A2P Brand Registration SID </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UsAppToPersonUsecase </returns>
        public static UsAppToPersonUsecaseResource Fetch(string pathMessagingServiceSid,
                                                         string brandRegistrationSid = null,
                                                         ITwilioRestClient client = null)
        {
            var options = new FetchUsAppToPersonUsecaseOptions(pathMessagingServiceSid){BrandRegistrationSid = brandRegistrationSid};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathMessagingServiceSid"> The SID of the Messaging Service to fetch the resource from </param>
        /// <param name="brandRegistrationSid"> A2P Brand Registration SID </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UsAppToPersonUsecase </returns>
        public static async System.Threading.Tasks.Task<UsAppToPersonUsecaseResource> FetchAsync(string pathMessagingServiceSid,
                                                                                                 string brandRegistrationSid = null,
                                                                                                 ITwilioRestClient client = null)
        {
            var options = new FetchUsAppToPersonUsecaseOptions(pathMessagingServiceSid){BrandRegistrationSid = brandRegistrationSid};
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a UsAppToPersonUsecaseResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> UsAppToPersonUsecaseResource object represented by the provided JSON </returns>
        public static UsAppToPersonUsecaseResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<UsAppToPersonUsecaseResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// Human readable A2P Use Case details
        /// </summary>
        [JsonProperty("us_app_to_person_usecases")]
        public List<object> UsAppToPersonUsecases { get; private set; }

        private UsAppToPersonUsecaseResource()
        {

        }
    }

}