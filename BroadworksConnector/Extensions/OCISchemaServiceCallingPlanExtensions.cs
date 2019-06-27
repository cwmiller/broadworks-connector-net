using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallingPlanExtensions
    {

        /// <summary>
        /// Add a new calling plan digit string.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallingPlanAddDigitPatternRequest(this OcipClient client, GroupCallingPlanAddDigitPatternRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete one or more calling plan digit strings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallingPlanDeleteDigitPatternListRequest(this OcipClient client, GroupCallingPlanDeleteDigitPatternListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the list of calling plan digit strings for a group.
        /// The response is either a GroupCallingPlanGetDigitPatternListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallingPlanGetDigitPatternListResponse> GroupCallingPlanGetDigitPatternListRequest(this OcipClient client, GroupCallingPlanGetDigitPatternListRequest request)
        {
            return await client.Call(request) as GroupCallingPlanGetDigitPatternListResponse;
        }

        /// <summary>
        /// Modify a calling plan digit string. The name is a key; it cannot be changed.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallingPlanModifyDigitPatternRequest(this OcipClient client, GroupCallingPlanModifyDigitPatternRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
