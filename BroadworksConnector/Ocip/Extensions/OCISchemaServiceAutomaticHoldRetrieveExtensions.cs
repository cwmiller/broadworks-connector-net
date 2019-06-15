using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceAutomaticHoldRetrieveExtensions
{

    /// <summary>
    /// Request the user level data associated with Automatic Hold/Retrieve.
    /// The response is either a UserAutomaticHoldRetrieveGetResponse or an
    /// ErrorResponse.
    /// </summary>
    public static async Task<UserAutomaticHoldRetrieveGetResponse> UserAutomaticHoldRetrieveGetRequest(this OcipClient client, UserAutomaticHoldRetrieveGetRequest request) {
        return await client.Call(request) as UserAutomaticHoldRetrieveGetResponse;
    }

    /// <summary>
    /// Modify the user level data associated with Automatic Hold/Retrieve.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserAutomaticHoldRetrieveModifyRequest(this OcipClient client, UserAutomaticHoldRetrieveModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
