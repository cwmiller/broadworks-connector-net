using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServicePhysicalLocationExtensions
{

    /// <summary>
    /// Request to get the list of Physical Location system parameters.
    /// The response is either SystemPhysicalLocationGetResponse or ErrorResponse.
    /// </summary>
    public static async Task<SystemPhysicalLocationGetResponse> SystemPhysicalLocationGetRequest(this OcipClient client, SystemPhysicalLocationGetRequest request) {
        return await client.Call(request) as SystemPhysicalLocationGetResponse;
    }

    /// <summary>
    /// Request to modify Physical Location system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemPhysicalLocationModifyRequest(this OcipClient client, SystemPhysicalLocationModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the user level data associated with Physical Location.
    /// The response is either a UserPhysicalLocationGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserPhysicalLocationGetResponse> UserPhysicalLocationGetRequest(this OcipClient client, UserPhysicalLocationGetRequest request) {
        return await client.Call(request) as UserPhysicalLocationGetResponse;
    }

    /// <summary>
    /// Modify the user level data associated with Physical Location.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserPhysicalLocationModifyRequest(this OcipClient client, UserPhysicalLocationModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
