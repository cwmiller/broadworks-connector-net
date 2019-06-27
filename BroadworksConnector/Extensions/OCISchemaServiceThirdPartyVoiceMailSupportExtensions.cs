using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceThirdPartyVoiceMailSupportExtensions
    {

        /// <summary>
        /// Request the group level data associated with Third-Party Voice Mail Support.
        /// The response is either a GroupThirdPartyVoiceMailSupportGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<GroupThirdPartyVoiceMailSupportGetResponse> GroupThirdPartyVoiceMailSupportGetRequest(this OcipClient client, GroupThirdPartyVoiceMailSupportGetRequest request)
        {
            return await client.Call(request) as GroupThirdPartyVoiceMailSupportGetResponse;
        }

        /// <summary>
        /// Modify the Third Party Voice Mail Support settings for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupThirdPartyVoiceMailSupportModifyRequest(this OcipClient client, GroupThirdPartyVoiceMailSupportModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a ThirdPartyVoiceMailSupport User DN to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemThirdPartyVoiceMailSupportAddDnRequest(this OcipClient client, SystemThirdPartyVoiceMailSupportAddDnRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a ThirdPartyVoiceMailSupport User DN from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemThirdPartyVoiceMailSupportDeleteDnRequest(this OcipClient client, SystemThirdPartyVoiceMailSupportDeleteDnRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a list of ThirdPartyVoiceMailSupport User DN's defined in the system.
        /// The response is either a SystemThirdPartyVoiceMailSupportGetDnListResponse or an ErrorResponse.
        /// The search can be done using multiple criterion.
        /// </summary>
        public static async Task<SystemThirdPartyVoiceMailSupportGetDnListResponse> SystemThirdPartyVoiceMailSupportGetDnListRequest(this OcipClient client, SystemThirdPartyVoiceMailSupportGetDnListRequest request)
        {
            return await client.Call(request) as SystemThirdPartyVoiceMailSupportGetDnListResponse;
        }

        /// <summary>
        /// Request the system level data associated with Third-party Voice Mail Support.
        /// The response is either a SystemThirdPartyVoiceMailSupportGetResponse17sp4 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemThirdPartyVoiceMailSupportGetResponse17sp4> SystemThirdPartyVoiceMailSupportGetRequest17sp4(this OcipClient client, SystemThirdPartyVoiceMailSupportGetRequest17sp4 request)
        {
            return await client.Call(request) as SystemThirdPartyVoiceMailSupportGetResponse17sp4;
        }

        /// <summary>
        /// Request to modify a ThirdPartyVoiceMailSupport User DN and description in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemThirdPartyVoiceMailSupportModifyDnRequest(this OcipClient client, SystemThirdPartyVoiceMailSupportModifyDnRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Third-party Voice Mail Support.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// stripDiversionOnVMDestinationRetrieval
        /// </summary>
        public static async Task<SuccessResponse> SystemThirdPartyVoiceMailSupportModifyRequest(this OcipClient client, SystemThirdPartyVoiceMailSupportModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user level data associated with Third-Party Voice Mail Support.
        /// The response is either a UserThirdPartyVoiceMailSupportGetResponse17 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserThirdPartyVoiceMailSupportGetResponse17> UserThirdPartyVoiceMailSupportGetRequest17(this OcipClient client, UserThirdPartyVoiceMailSupportGetRequest17 request)
        {
            return await client.Call(request) as UserThirdPartyVoiceMailSupportGetResponse17;
        }

        /// <summary>
        /// Modify the Third Party Voice Mail Support settings for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserThirdPartyVoiceMailSupportModifyRequest(this OcipClient client, UserThirdPartyVoiceMailSupportModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
