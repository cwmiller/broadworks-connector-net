using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceTwoStageDialingExtensions
    {

        /// <summary>
        /// Request to add Two Stage Dialing number to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTwoStageDialingAddDnRequest(this OcipClient client, SystemTwoStageDialingAddDnRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a Two Stage Dialing number from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTwoStageDialingDeleteDnRequest(this OcipClient client, SystemTwoStageDialingDeleteDnRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a list of Two Stage Dialing dns defined in the system.
        /// The response is either a SystemTwoStageDialingGetDnListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemTwoStageDialingGetDnListResponse> SystemTwoStageDialingGetDnListRequest(this OcipClient client, SystemTwoStageDialingGetDnListRequest request)
        {
            return await client.Call(request) as SystemTwoStageDialingGetDnListResponse;
        }

        /// <summary>
        /// Request to modify a Two Stage Dialing number's description in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTwoStageDialingModifyDnRequest(this OcipClient client, SystemTwoStageDialingModifyDnRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user level data associated with Two Stage Dialing.
        /// The response is either a UserTwoStageDialingGetResponse13Mp20 or an ErrorResponse.
        /// </summary>
        public static async Task<UserTwoStageDialingGetResponse13Mp20> UserTwoStageDialingGetRequest13Mp20(this OcipClient client, UserTwoStageDialingGetRequest13Mp20 request)
        {
            return await client.Call(request) as UserTwoStageDialingGetResponse13Mp20;
        }

        /// <summary>
        /// Modify the user level data associated with Two Stage Dialing.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserTwoStageDialingModifyRequest(this OcipClient client, UserTwoStageDialingModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
