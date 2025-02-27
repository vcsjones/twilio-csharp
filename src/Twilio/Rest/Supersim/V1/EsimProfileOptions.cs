/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Supersim.V1
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Order an eSIM Profile.
    /// </summary>
    public class CreateEsimProfileOptions : IOptions<EsimProfileResource>
    {
        /// <summary>
        /// Identifier of the eUICC that will claim the eSIM Profile
        /// </summary>
        public string Eid { get; }
        /// <summary>
        /// The URL we should call after we have sent when the status of the eSIM Profile changes
        /// </summary>
        public string CallbackUrl { get; set; }
        /// <summary>
        /// The HTTP method we should use to call callback_url
        /// </summary>
        public Twilio.Http.HttpMethod CallbackMethod { get; set; }

        /// <summary>
        /// Construct a new CreateEsimProfileOptions
        /// </summary>
        /// <param name="eid"> Identifier of the eUICC that will claim the eSIM Profile </param>
        public CreateEsimProfileOptions(string eid)
        {
            Eid = eid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Eid != null)
            {
                p.Add(new KeyValuePair<string, string>("Eid", Eid));
            }

            if (CallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackUrl", CallbackUrl));
            }

            if (CallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackMethod", CallbackMethod.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Fetch an eSIM Profile.
    /// </summary>
    public class FetchEsimProfileOptions : IOptions<EsimProfileResource>
    {
        /// <summary>
        /// The SID of the eSIM Profile resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchEsimProfileOptions
        /// </summary>
        /// <param name="pathSid"> The SID of the eSIM Profile resource to fetch </param>
        public FetchEsimProfileOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Retrieve a list of eSIM Profiles.
    /// </summary>
    public class ReadEsimProfileOptions : ReadOptions<EsimProfileResource>
    {
        /// <summary>
        /// List the eSIM Profiles that have been associated with an EId
        /// </summary>
        public string Eid { get; set; }
        /// <summary>
        /// Find the eSIM Profile resource related to a Sim resource by providing the SIM SID
        /// </summary>
        public string SimSid { get; set; }
        /// <summary>
        /// List the eSIM Profiles that are in a given status
        /// </summary>
        public EsimProfileResource.StatusEnum Status { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Eid != null)
            {
                p.Add(new KeyValuePair<string, string>("Eid", Eid));
            }

            if (SimSid != null)
            {
                p.Add(new KeyValuePair<string, string>("SimSid", SimSid.ToString()));
            }

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}