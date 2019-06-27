using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceFaxMessagingExtensions
    {

        /// <summary>
        /// Request the system level data associated with Fax Messaging.
        /// The response is either a SystemFaxMessagingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemFaxMessagingGetResponse> SystemFaxMessagingGetRequest(this OcipClient client, SystemFaxMessagingGetRequest request)
        {
            return await client.Call(request) as SystemFaxMessagingGetResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Fax Messaging.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// statusDurationHours
        /// statusAuditIntervalHours
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemFaxMessagingModifyRequest(this OcipClient client, SystemFaxMessagingModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user level data associated with Fax Messaging.
        /// The response is either a UserFaxMessagingGetResponse17sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<UserFaxMessagingGetResponse17sp1> UserFaxMessagingGetRequest17sp1(this OcipClient client, UserFaxMessagingGetRequest17sp1 request)
        {
            return await client.Call(request) as UserFaxMessagingGetResponse17sp1;
        }

        /// <summary>
        /// Modify the user level data associated with Fax Messaging.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserFaxMessagingModifyRequest(this OcipClient client, UserFaxMessagingModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
