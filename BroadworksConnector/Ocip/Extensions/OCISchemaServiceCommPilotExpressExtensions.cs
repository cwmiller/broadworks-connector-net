using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceCommPilotExpressExtensions
{

    /// <summary>
    /// Get the user's commPilot express service setting.
    /// The response is either a UserCommPilotExpressGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserCommPilotExpressGetResponse> UserCommPilotExpressGetRequest(this OcipClient client, UserCommPilotExpressGetRequest request) {
        return await client.Call(request) as UserCommPilotExpressGetResponse;
    }

    /// <summary>
    /// Modify the user's commPilot express service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Engineering Note: This command is used internally by Call Processing.
    /// </summary>
    public static async Task<SuccessResponse> UserCommPilotExpressModifyRequest(this OcipClient client, UserCommPilotExpressModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
