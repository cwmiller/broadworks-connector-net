using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceSMDIMessageDeskExtensions
    {

        /// <summary>
        /// Request to add a SMDI Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIMessageDeskAddServerRequest(this OcipClient client, SystemSMDIMessageDeskAddServerRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a SMDI Server route to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIMessageDeskAddServerRouteRequest(this OcipClient client, SystemSMDIMessageDeskAddServerRouteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a SMDI Server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIMessageDeskDeleteServerRequest(this OcipClient client, SystemSMDIMessageDeskDeleteServerRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a SMDI Server route from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIMessageDeskDeleteServerRouteRequest(this OcipClient client, SystemSMDIMessageDeskDeleteServerRouteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a list of SMDI Servers defined in the system.
        /// The response is either a SystemSMDIMessageDeskGetServerListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSMDIMessageDeskGetServerListResponse> SystemSMDIMessageDeskGetServerListRequest(this OcipClient client, SystemSMDIMessageDeskGetServerListRequest request)
        {
            return await client.Call(request) as SystemSMDIMessageDeskGetServerListResponse;
        }

        /// <summary>
        /// Request to get a list of SMDI Servers routes in the system.
        /// The response is either a SystemSMDIMessageDeskGetServerRouteListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSMDIMessageDeskGetServerRouteListResponse> SystemSMDIMessageDeskGetServerRouteListRequest(this OcipClient client, SystemSMDIMessageDeskGetServerRouteListRequest request)
        {
            return await client.Call(request) as SystemSMDIMessageDeskGetServerRouteListResponse;
        }

        /// <summary>
        /// Request to modify a SMDI Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIMessageDeskModifyServerRequest(this OcipClient client, SystemSMDIMessageDeskModifyServerRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Replace the list of devices associated with a SMDI server route destination.
        /// There must be at least one device in the list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIMessageDeskModifyServerRouteRequest(this OcipClient client, SystemSMDIMessageDeskModifyServerRouteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a SMDI Server for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSMDIMessageDeskAddServerRequest(this OcipClient client, UserSMDIMessageDeskAddServerRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a list of SMDI Servers for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSMDIMessageDeskDeleteServerListRequest(this OcipClient client, UserSMDIMessageDeskDeleteServerListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the user's SMDI Message Desk service personal setting.
        /// The response is either a UserSMDIMessageDeskGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserSMDIMessageDeskGetResponse> UserSMDIMessageDeskGetRequest(this OcipClient client, UserSMDIMessageDeskGetRequest request)
        {
            return await client.Call(request) as UserSMDIMessageDeskGetResponse;
        }

        /// <summary>
        /// Request to get a list of SMDI Servers defined for a user.
        /// The response is either a UserSMDIMessageDeskGetServerListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserSMDIMessageDeskGetServerListResponse> UserSMDIMessageDeskGetServerListRequest(this OcipClient client, UserSMDIMessageDeskGetServerListRequest request)
        {
            return await client.Call(request) as UserSMDIMessageDeskGetServerListResponse;
        }

        /// <summary>
        /// Modify the user's SMDI Message Desk service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSMDIMessageDeskModifyRequest(this OcipClient client, UserSMDIMessageDeskModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
