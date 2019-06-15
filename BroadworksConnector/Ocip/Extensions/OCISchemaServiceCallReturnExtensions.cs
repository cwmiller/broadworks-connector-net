using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceCallReturnExtensions
{

    /// <summary>
    /// Request the system level data associated with Call Return.
    /// The response is either a SystemCallReturnGetResponse or an
    /// ErrorResponse.
    /// </summary>
    public static async Task<SystemCallReturnGetResponse> SystemCallReturnGetRequest(this OcipClient client, SystemCallReturnGetRequest request) {
        return await client.Call(request) as SystemCallReturnGetResponse;
    }

    /// <summary>
    /// Modify the system level data associated with Call Return.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemCallReturnModifyRequest(this OcipClient client, SystemCallReturnModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
