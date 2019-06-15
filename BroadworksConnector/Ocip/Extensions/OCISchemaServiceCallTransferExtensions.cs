using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceCallTransferExtensions
{

    /// <summary>
    /// Request the user level data associated with Call Transfer.
    /// The response is either a UserCallTransferGetResponse14sp4 or an
    /// ErrorResponse.
    /// </summary>
    public static async Task<UserCallTransferGetResponse14sp4> UserCallTransferGetRequest14sp4(this OcipClient client, UserCallTransferGetRequest14sp4 request) {
        return await client.Call(request) as UserCallTransferGetResponse14sp4;
    }

    /// <summary>
    /// Modify the user level data associated with Call Transfer.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCallTransferModifyRequest(this OcipClient client, UserCallTransferModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
