using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServicePersonalAssistantExtensions
    {

        /// <summary>
        /// Get system Personal Assistant Parameters.
        /// The response is either SystemPersonalAssistantGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemPersonalAssistantGetResponse> SystemPersonalAssistantGetRequest(this OcipClient client, SystemPersonalAssistantGetRequest request)
        {
            return await client.Call(request) as SystemPersonalAssistantGetResponse;
        }

        /// <summary>
        /// Modify system Personal Assistant Parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPersonalAssistantModifyRequest(this OcipClient client, SystemPersonalAssistantModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the user available Call to Number List information. The response is either a UserCallToNumberGetAvailableListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallToNumberGetAvailableListResponse> UserCallToNumberGetAvailableListRequest(this OcipClient client, UserCallToNumberGetAvailableListRequest request)
        {
            return await client.Call(request) as UserCallToNumberGetAvailableListResponse;
        }

        /// <summary>
        /// Request to get the user assigned Call to Number List information. The response is either a UserPersonalAssistantCallToNumberGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserPersonalAssistantCallToNumberGetListResponse> UserPersonalAssistantCallToNumberGetListRequest(this OcipClient client, UserPersonalAssistantCallToNumberGetListRequest request)
        {
            return await client.Call(request) as UserPersonalAssistantCallToNumberGetListResponse;
        }

        /// <summary>
        /// Request to modify the user assigned Call to Number List information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// For the callToNumbers in the callToNumberList, the extension element
        /// is not used and the number element is only used when the type is BroadWorks Mobility.
        /// </summary>
        public static async Task<SuccessResponse> UserPersonalAssistantCallToNumberModifyListRequest(this OcipClient client, UserPersonalAssistantCallToNumberModifyListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a User Personal Assistant Exclusion Number.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPersonalAssistantExclusionNumberAddRequest(this OcipClient client, UserPersonalAssistantExclusionNumberAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of User Personal Assistant Exclusion Number.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPersonalAssistantExclusionNumberDeleteListRequest(this OcipClient client, UserPersonalAssistantExclusionNumberDeleteListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the User Personal Assistant Exclusion Number List information.
        /// The response is either a UserPersonalAssistantExclusionNumberGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserPersonalAssistantExclusionNumberGetListResponse> UserPersonalAssistantExclusionNumberGetListRequest(this OcipClient client, UserPersonalAssistantExclusionNumberGetListRequest request)
        {
            return await client.Call(request) as UserPersonalAssistantExclusionNumberGetListResponse;
        }

        /// <summary>
        /// Get a Personal Assistant Exclusion Number.
        /// The response is either UserPersonalAssistantExclusionNumberGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserPersonalAssistantExclusionNumberGetResponse> UserPersonalAssistantExclusionNumberGetRequest(this OcipClient client, UserPersonalAssistantExclusionNumberGetRequest request)
        {
            return await client.Call(request) as UserPersonalAssistantExclusionNumberGetResponse;
        }

        /// <summary>
        /// Modify an existing User Personal Assistant Exclusion Number description.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPersonalAssistantExclusionNumberModifyRequest(this OcipClient client, UserPersonalAssistantExclusionNumberModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the User Personal Assistant information.
        /// The response is either a UserPersonalAssistantGetResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<UserPersonalAssistantGetResponse22> UserPersonalAssistantGetRequest22(this OcipClient client, UserPersonalAssistantGetRequest22 request)
        {
            return await client.Call(request) as UserPersonalAssistantGetResponse22;
        }

        /// <summary>
        /// Modify the User Personal Assistant information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPersonalAssistantModifyRequest(this OcipClient client, UserPersonalAssistantModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
