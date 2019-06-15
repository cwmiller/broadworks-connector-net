using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceCallForwardingNotReachableExtensions
{

    /// <summary>
    /// Request the user level data associated with Call Forwarding Not Reachable.
    /// The response is either a UserCallForwardingNotReachableGetResponse or an
    /// ErrorResponse.
    /// </summary>
    public static async Task<UserCallForwardingNotReachableGetResponse> UserCallForwardingNotReachableGetRequest(this OcipClient client, UserCallForwardingNotReachableGetRequest request) {
        return await client.Call(request) as UserCallForwardingNotReachableGetResponse;
    }

    /// <summary>
    /// Modify the user level data associated with Call Forwarding Not Reachable.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Engineering Note: This command is used internally by Call Processing.
    /// </summary>
    public static async Task<SuccessResponse> UserCallForwardingNotReachableModifyRequest(this OcipClient client, UserCallForwardingNotReachableModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
