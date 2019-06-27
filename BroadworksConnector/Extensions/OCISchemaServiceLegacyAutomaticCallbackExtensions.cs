using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceLegacyAutomaticCallbackExtensions
    {

        /// <summary>
        /// Request the system's legacy automatic callback line type settings.
        /// The response is either a SystemLegacyAutomaticCallbackGetLineTypeListResponse or
        /// an ErrorResponse.
        /// </summary>
        public static async Task<SystemLegacyAutomaticCallbackGetLineTypeListResponse> SystemLegacyAutomaticCallbackGetLineTypeListRequest(this OcipClient client, SystemLegacyAutomaticCallbackGetLineTypeListRequest request)
        {
            return await client.Call(request) as SystemLegacyAutomaticCallbackGetLineTypeListResponse;
        }

        /// <summary>
        /// Request the system's legacy automatic callback attributes.
        /// The response is either a SystemLegacyAutomaticCallbackGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemLegacyAutomaticCallbackGetResponse> SystemLegacyAutomaticCallbackGetRequest(this OcipClient client, SystemLegacyAutomaticCallbackGetRequest request)
        {
            return await client.Call(request) as SystemLegacyAutomaticCallbackGetResponse;
        }

        /// <summary>
        /// Modifies the system's legacy automatic callback line type attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemLegacyAutomaticCallbackModifyLineTypeRequest(this OcipClient client, SystemLegacyAutomaticCallbackModifyLineTypeRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the system's legacy automatic callback attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemLegacyAutomaticCallbackModifyRequest(this OcipClient client, SystemLegacyAutomaticCallbackModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user level data associated with Legacy Automatic Callback.
        /// The response is either a UserLegacyAutomaticCallbackGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserLegacyAutomaticCallbackGetResponse> UserLegacyAutomaticCallbackGetRequest(this OcipClient client, UserLegacyAutomaticCallbackGetRequest request)
        {
            return await client.Call(request) as UserLegacyAutomaticCallbackGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Legacy Automatic Callback.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserLegacyAutomaticCallbackModifyRequest(this OcipClient client, UserLegacyAutomaticCallbackModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
