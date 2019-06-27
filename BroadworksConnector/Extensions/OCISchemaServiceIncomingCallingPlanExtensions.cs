using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceIncomingCallingPlanExtensions
    {

        /// <summary>
        /// Request the group's incoming calling plan settings.
        /// The response is either a GroupIncomingCallingPlanGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupIncomingCallingPlanGetListResponse> GroupIncomingCallingPlanGetListRequest(this OcipClient client, GroupIncomingCallingPlanGetListRequest request)
        {
            return await client.Call(request) as GroupIncomingCallingPlanGetListResponse;
        }

        /// <summary>
        /// Change the group's incoming calling plan settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupIncomingCallingPlanModifyListRequest(this OcipClient client, GroupIncomingCallingPlanModifyListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user's incoming calling plan settings.
        /// The response is either a UserIncomingCallingPlanGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserIncomingCallingPlanGetResponse> UserIncomingCallingPlanGetRequest(this OcipClient client, UserIncomingCallingPlanGetRequest request)
        {
            return await client.Call(request) as UserIncomingCallingPlanGetResponse;
        }

        /// <summary>
        /// Change the user's incoming calling plan settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserIncomingCallingPlanModifyRequest(this OcipClient client, UserIncomingCallingPlanModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
