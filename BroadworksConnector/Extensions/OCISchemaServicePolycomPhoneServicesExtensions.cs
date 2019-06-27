using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServicePolycomPhoneServicesExtensions
    {

        /// <summary>
        /// Request the group's Polycom Phone Services attributes.
        /// The response is either a GroupPolycomPhoneServicesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupPolycomPhoneServicesGetResponse> GroupPolycomPhoneServicesGetRequest(this OcipClient client, GroupPolycomPhoneServicesGetRequest request)
        {
            return await client.Call(request) as GroupPolycomPhoneServicesGetResponse;
        }

        /// <summary>
        /// Modify the group's Polycom Phone Services attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupPolycomPhoneServicesModifyRequest(this OcipClient client, GroupPolycomPhoneServicesModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user's list of device profiles on which the user is the primary user.
        /// The response is either a UserPolycomPhoneServicesGetPrimaryEndpointListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserPolycomPhoneServicesGetPrimaryEndpointListResponse> UserPolycomPhoneServicesGetPrimaryEndpointListRequest(this OcipClient client, UserPolycomPhoneServicesGetPrimaryEndpointListRequest request)
        {
            return await client.Call(request) as UserPolycomPhoneServicesGetPrimaryEndpointListResponse;
        }

        /// <summary>
        /// Request the user's Polycom Phone Services attributes.
        /// The response is either a UserPolycomPhoneServicesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserPolycomPhoneServicesGetResponse> UserPolycomPhoneServicesGetRequest(this OcipClient client, UserPolycomPhoneServicesGetRequest request)
        {
            return await client.Call(request) as UserPolycomPhoneServicesGetResponse;
        }

        /// <summary>
        /// Modify the user's Polycom Phone Services attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPolycomPhoneServicesModifyRequest(this OcipClient client, UserPolycomPhoneServicesModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
