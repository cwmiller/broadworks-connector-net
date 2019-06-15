using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceCallForwardingBusyExtensions
{

    /// <summary>
    /// Request the user level data associated with Call Forwarding Busy.
    /// The response is either a UserCallForwardingBusyGetResponse or an
    /// ErrorResponse.
    /// </summary>
    public static async Task<UserCallForwardingBusyGetResponse> UserCallForwardingBusyGetRequest(this OcipClient client, UserCallForwardingBusyGetRequest request) {
        return await client.Call(request) as UserCallForwardingBusyGetResponse;
    }

    /// <summary>
    /// Modify the user level data associated with Call Forwarding Busy.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Engineering Note: This command is used internally by Call Processing.
    /// </summary>
    public static async Task<SuccessResponse> UserCallForwardingBusyModifyRequest(this OcipClient client, UserCallForwardingBusyModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
