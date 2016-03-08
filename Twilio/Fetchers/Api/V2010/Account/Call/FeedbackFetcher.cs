using Twilio.Clients.TwilioRestClient;
using Twilio.Exceptions;
using Twilio.Fetchers.Fetcher;
using Twilio.Http;
using Twilio.Resources.Api.V2010.account.call.Feedback;

namespace Twilio.Fetchers.Api.V2010.Account.Call {

    public class FeedbackFetcher : Fetcher<Feedback> {
        private String accountSid;
        private String callSid;
    
        /**
         * Construct a new FeedbackFetcher
         * 
         * @param accountSid The account_sid
         * @param callSid The call sid that uniquely identifies the call
         */
        public FeedbackFetcher(String accountSid, String callSid) {
            this.accountSid = accountSid;
            this.callSid = callSid;
        }
    
        /**
         * Make the request to the Twilio API to perform the fetch
         * 
         * @param client TwilioRestClient with which to make the request
         * @return Fetched Feedback
         */
        [Override]
        public Feedback execute(TwilioRestClient client) {
            Request request = new Request(
                HttpMethod.GET,
                TwilioRestClient.Domains.API,
                "/2010-04-01/Accounts/" + this.accountSid + "/Calls/" + this.callSid + "/Feedback.json",
                client.getAccountSid()
            );
            
            Response response = client.request(request);
            
            if (response == null) {
                throw new ApiConnectionException("Feedback fetch failed: Unable to connect to server");
            } else if (response.getStatusCode() != TwilioRestClient.HTTP_STATUS_CODE_OK) {
                RestException restException = RestException.fromJson(response.getStream(), client.getObjectMapper());
                if (restException == null)
                    throw new ApiException("Server Error, no content");
                throw new ApiException(
                    restException.getMessage(),
                    restException.getCode(),
                    restException.getMoreInfo(),
                    restException.getStatus(),
                    null
                );
            }
            
            return Feedback.fromJson(response.getStream(), client.getObjectMapper());
        }
    }
}