using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceCommunicationBarringUserControlExtensions
{

    /// <summary>
    /// Gets the Communication Barring system level settings.
    /// The response is either SystemCommunicationBarringUserControlGetResponse or ErrorResponse.
    /// </summary>
    public static async Task<SystemCommunicationBarringUserControlGetResponse> SystemCommunicationBarringUserControlGetRequest(this OcipClient client, SystemCommunicationBarringUserControlGetRequest request) {
        return await client.Call(request) as SystemCommunicationBarringUserControlGetResponse;
    }

    /// <summary>
    /// Modifies the system's Communication Barring User-Control settings.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemCommunicationBarringUserControlModifyRequest(this OcipClient client, SystemCommunicationBarringUserControlModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Lists the Communication Barring profiles available to a user and
    /// indicates which profile if any is currently active for the user..
    /// The response is either UserCommunicationBarringUserControlGetResponse or ErrorResponse.
    /// </summary>
    public static async Task<UserCommunicationBarringUserControlGetResponse> UserCommunicationBarringUserControlGetRequest(this OcipClient client, UserCommunicationBarringUserControlGetRequest request) {
        return await client.Call(request) as UserCommunicationBarringUserControlGetResponse;
    }

    /// <summary>
    /// Enabling a profile automatically disables the currently active profile.
    /// Also allows the passcode for the service to be modified and the lockout to be reset.
    /// Admins only need to populate the newPasscode field when changing the passcode.
    /// Users must populate both the oldPasscode and new Passcode fields when changing the passcode.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCommunicationBarringUserControlModifyRequest(this OcipClient client, UserCommunicationBarringUserControlModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
