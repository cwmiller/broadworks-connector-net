using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceBargeInExemptExtensions
{

    /// <summary>
    /// Request the user level data associated with Barge In Exempt.
    /// The response is either a UserBargeInExemptGetResponse or an
    /// ErrorResponse.
    /// </summary>
    public static async Task<UserBargeInExemptGetResponse> UserBargeInExemptGetRequest(this OcipClient client, UserBargeInExemptGetRequest request) {
        return await client.Call(request) as UserBargeInExemptGetResponse;
    }

    /// <summary>
    /// Modify the user level data associated with Barge In Exempt.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserBargeInExemptModifyRequest(this OcipClient client, UserBargeInExemptModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
