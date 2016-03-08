using Newtonsoft.Json;
using System;
using Twilio.Clients.TwilioRestClient;
using Twilio.Exceptions;
using Twilio.Fetchers.Api.V2010.Account.Queue;
using Twilio.Http;
using Twilio.Readers.Api.V2010.Account.Queue;
using Twilio.Resources;
using Twilio.Updaters.Api.V2010.Account.Queue;
using com.twilio.sdk.converters.MarshalConverter;
using com.twilio.sdk.http.HttpMethod;
using java.net.URI;
using org.joda.time.DateTime;

namespace Twilio.Resources.Api.V2010.Account.Queue {

    public class Member : SidResource {
        /**
         * Fetch a specific members of the queue
         * 
         * @param accountSid The account_sid
         * @param queueSid The Queue in which to find the members
         * @param callSid The call_sid
         * @return MemberFetcher capable of executing the fetch
         */
        public static MemberFetcher fetch(String accountSid, String queueSid, String callSid) {
            return new MemberFetcher(accountSid, queueSid, callSid);
        }
    
        /**
         * Dequeue a member from a queue and have the member's call begin executing the
         * TwiML document at that URL
         * 
         * @param accountSid The account_sid
         * @param queueSid The Queue in which to find the members
         * @param callSid The call_sid
         * @param url The url
         * @param method The method
         * @return MemberUpdater capable of executing the update
         */
        public static MemberUpdater update(String accountSid, String queueSid, String callSid, URI url, HttpMethod method) {
            return new MemberUpdater(accountSid, queueSid, callSid, url, method);
        }
    
        /**
         * Retrieve a list of members in the queue
         * 
         * @param accountSid The account_sid
         * @param queueSid The Queue in which to find members
         * @return MemberReader capable of executing the read
         */
        public static MemberReader read(String accountSid, String queueSid) {
            return new MemberReader(accountSid, queueSid);
        }
    
        /**
         * Converts a JSON string into a Member object
         * 
         * @param json Raw JSON string
         * @return Member object represented by the provided JSON
         */
        public static Member fromJson(string json) {
            // Convert all checked exceptions to Runtime
            try {
                return JsonConvert.DeserializeObject<Member>(json);
            } catch (JsonException e) {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("call_sid")]
        private readonly String callSid;
        [JsonProperty("date_enqueued")]
        private readonly DateTime dateEnqueued;
        [JsonProperty("position")]
        private readonly Integer position;
        [JsonProperty("uri")]
        private readonly String uri;
        [JsonProperty("wait_time")]
        private readonly Integer waitTime;
    
        private Member([JsonProperty("call_sid")]
                       String callSid, 
                       [JsonProperty("date_enqueued")]
                       String dateEnqueued, 
                       [JsonProperty("position")]
                       Integer position, 
                       [JsonProperty("uri")]
                       String uri, 
                       [JsonProperty("wait_time")]
                       Integer waitTime) {
            this.callSid = callSid;
            this.dateEnqueued = MarshalConverter.dateTimeFromString(dateEnqueued);
            this.position = position;
            this.uri = uri;
            this.waitTime = waitTime;
        }
    
        /**
         * @return Unique string that identifies this resource
         */
        public String getSid() {
            return this.getCallSid();
        }
    
        /**
         * @return Unique string that identifies this resource
         */
        public String GetCallSid() {
            return this.callSid;
        }
    
        /**
         * @return The date the member was enqueued
         */
        public DateTime GetDateEnqueued() {
            return this.dateEnqueued;
        }
    
        /**
         * @return This member's current position in the queue.
         */
        public Integer GetPosition() {
            return this.position;
        }
    
        /**
         * @return The uri
         */
        public String GetUri() {
            return this.uri;
        }
    
        /**
         * @return The number of seconds the member has been in the queue.
         */
        public Integer GetWaitTime() {
            return this.waitTime;
        }
    }
}