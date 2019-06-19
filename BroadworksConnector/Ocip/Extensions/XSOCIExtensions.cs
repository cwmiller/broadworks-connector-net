using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class XSOCIExtensions
    {

        /// <summary>
        /// Request to modify an Auto Attendant instance.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Engineering Note: This command can only be executed from the Execution Server
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantModifyInstanceExecutionServerRequest(this OcipClient client, GroupAutoAttendantModifyInstanceExecutionServerRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group's voice portal branding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command can only be executed from the Execution Server
        /// </summary>
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupModifyVoicePortalBrandingExecutionServerRequest(this OcipClient client, GroupVoiceMessagingGroupModifyVoicePortalBrandingExecutionServerRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing custom greeting audio file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Engineering Note: This command can only be executed from the Execution Server
        /// </summary>
        public static async Task<SuccessResponse> UserMeetMeConferencingModifyConferenceGreetingExecutionServerRequest(this OcipClient client, UserMeetMeConferencingModifyConferenceGreetingExecutionServerRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging greeting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command can only be executed from the Execution Server
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyGreetingExecutionServerRequest(this OcipClient client, UserVoiceMessagingUserModifyGreetingExecutionServerRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging voice portal settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command can only be executed from the Execution
        /// Server
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyVoicePortalExecutionServerRequest(this OcipClient client, UserVoiceMessagingUserModifyVoicePortalExecutionServerRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
