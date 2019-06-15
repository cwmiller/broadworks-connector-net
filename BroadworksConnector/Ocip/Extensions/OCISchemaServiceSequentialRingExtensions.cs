using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceSequentialRingExtensions
{

    /// <summary>
    /// Add a criteria to the user's sequential ring service.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserSequentialRingAddCriteriaRequest16(this OcipClient client, UserSequentialRingAddCriteriaRequest16 request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a criteria from the user's sequential ring service.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserSequentialRingDeleteCriteriaRequest(this OcipClient client, UserSequentialRingDeleteCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get a criteria for the user's sequential ring service.
    /// The response is either a UserSequentialRingGetCriteriaResponse16 or an ErrorResponse.
    /// </summary>
    public static async Task<UserSequentialRingGetCriteriaResponse16> UserSequentialRingGetCriteriaRequest16(this OcipClient client, UserSequentialRingGetCriteriaRequest16 request) {
        return await client.Call(request) as UserSequentialRingGetCriteriaResponse16;
    }

    /// <summary>
    /// Get the user's sequential ring service setting.
    /// The response is either a UserSequentialRingGetResponse14sp4 or an ErrorResponse.
    /// </summary>
    public static async Task<UserSequentialRingGetResponse14sp4> UserSequentialRingGetRequest14sp4(this OcipClient client, UserSequentialRingGetRequest14sp4 request) {
        return await client.Call(request) as UserSequentialRingGetResponse14sp4;
    }

    /// <summary>
    /// Modify a criteria for the user's sequential ring service.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserSequentialRingModifyCriteriaRequest(this OcipClient client, UserSequentialRingModifyCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Modify the user's sequential ring service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserSequentialRingModifyRequest(this OcipClient client, UserSequentialRingModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
