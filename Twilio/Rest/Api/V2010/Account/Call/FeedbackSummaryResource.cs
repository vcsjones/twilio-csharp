using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account.Call 
{

    public class FeedbackSummaryResource : Resource 
    {
        public sealed class FeedbackSummaryStatus : IStringEnum 
        {
            public const string Queued = "queued";
            public const string InProgress = "in-progress";
            public const string Completed = "completed";
            public const string Failed = "failed";
        
            private string _value;
            
            public FeedbackSummaryStatus() {}
            
            public FeedbackSummaryStatus(string value)
            {
                _value = value;
            }
            
            public override string ToString()
            {
                return _value;
            }
            
            public static implicit operator FeedbackSummaryStatus(string value)
            {
                return new FeedbackSummaryStatus(value);
            }
            
            public static implicit operator string(FeedbackSummaryStatus value)
            {
                return value.ToString();
            }
            
            public void FromString(string value)
            {
                _value = value;
            }
        }
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="startDate"> The start_date </param>
        /// <param name="endDate"> The end_date </param>
        /// <returns> FeedbackSummaryCreator capable of executing the create </returns> 
        public static FeedbackSummaryCreator Creator(DateTime? startDate, DateTime? endDate)
        {
            return new FeedbackSummaryCreator(startDate, endDate);
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <returns> FeedbackSummaryFetcher capable of executing the fetch </returns> 
        public static FeedbackSummaryFetcher Fetcher(string sid)
        {
            return new FeedbackSummaryFetcher(sid);
        }
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <returns> FeedbackSummaryDeleter capable of executing the delete </returns> 
        public static FeedbackSummaryDeleter Deleter(string sid)
        {
            return new FeedbackSummaryDeleter(sid);
        }
    
        /// <summary>
        /// Converts a JSON string into a FeedbackSummaryResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FeedbackSummaryResource object represented by the provided JSON </returns> 
        public static FeedbackSummaryResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<FeedbackSummaryResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("account_sid")]
        public string accountSid { get; set; }
        [JsonProperty("call_count")]
        public int? callCount { get; set; }
        [JsonProperty("call_feedback_count")]
        public int? callFeedbackCount { get; set; }
        [JsonProperty("date_created")]
        public DateTime? dateCreated { get; set; }
        [JsonProperty("date_updated")]
        public DateTime? dateUpdated { get; set; }
        [JsonProperty("end_date")]
        public DateTime? endDate { get; set; }
        [JsonProperty("include_subaccounts")]
        public bool? includeSubaccounts { get; set; }
        [JsonProperty("issues")]
        public List<FeedbackIssue> issues { get; set; }
        [JsonProperty("quality_score_average")]
        public decimal? qualityScoreAverage { get; set; }
        [JsonProperty("quality_score_median")]
        public decimal? qualityScoreMedian { get; set; }
        [JsonProperty("quality_score_standard_deviation")]
        public decimal? qualityScoreStandardDeviation { get; set; }
        [JsonProperty("sid")]
        public string sid { get; set; }
        [JsonProperty("start_date")]
        public DateTime? startDate { get; set; }
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FeedbackSummaryResource.FeedbackSummaryStatus status { get; set; }
    
        public FeedbackSummaryResource()
        {
        
        }
    
        private FeedbackSummaryResource([JsonProperty("account_sid")]
                                        string accountSid, 
                                        [JsonProperty("call_count")]
                                        int? callCount, 
                                        [JsonProperty("call_feedback_count")]
                                        int? callFeedbackCount, 
                                        [JsonProperty("date_created")]
                                        string dateCreated, 
                                        [JsonProperty("date_updated")]
                                        string dateUpdated, 
                                        [JsonProperty("end_date")]
                                        string endDate, 
                                        [JsonProperty("include_subaccounts")]
                                        bool? includeSubaccounts, 
                                        [JsonProperty("issues")]
                                        List<FeedbackIssue> issues, 
                                        [JsonProperty("quality_score_average")]
                                        decimal? qualityScoreAverage, 
                                        [JsonProperty("quality_score_median")]
                                        decimal? qualityScoreMedian, 
                                        [JsonProperty("quality_score_standard_deviation")]
                                        decimal? qualityScoreStandardDeviation, 
                                        [JsonProperty("sid")]
                                        string sid, 
                                        [JsonProperty("start_date")]
                                        string startDate, 
                                        [JsonProperty("status")]
                                        FeedbackSummaryResource.FeedbackSummaryStatus status)
                                        {
            this.accountSid = accountSid;
            this.callCount = callCount;
            this.callFeedbackCount = callFeedbackCount;
            this.dateCreated = MarshalConverter.DateTimeFromString(dateCreated);
            this.dateUpdated = MarshalConverter.DateTimeFromString(dateUpdated);
            this.endDate = MarshalConverter.DateTimeFromString(endDate);
            this.includeSubaccounts = includeSubaccounts;
            this.issues = issues;
            this.qualityScoreAverage = qualityScoreAverage;
            this.qualityScoreMedian = qualityScoreMedian;
            this.qualityScoreStandardDeviation = qualityScoreStandardDeviation;
            this.sid = sid;
            this.startDate = MarshalConverter.DateTimeFromString(startDate);
            this.status = status;
        }
    }
}