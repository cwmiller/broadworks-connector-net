using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceCallForwardingSelectiveExtensions
{

    /// <summary>
    /// Add a criteria to the user's call forwarding selective service.
    /// The following elements are only used in AS data mode:
    /// callToNumber
    /// 
    /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCallForwardingSelectiveAddCriteriaRequest16(this OcipClient client, UserCallForwardingSelectiveAddCriteriaRequest16 request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a criteria from the user's call forwarding selective service.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCallForwardingSelectiveDeleteCriteriaRequest(this OcipClient client, UserCallForwardingSelectiveDeleteCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get a criteria for the user's call forwarding selective service.
    /// The response is either a UserCallForwardingSelectiveGetCriteriaResponse21 or an ErrorResponse.
    /// </summary>
    public static async Task<UserCallForwardingSelectiveGetCriteriaResponse21> UserCallForwardingSelectiveGetCriteriaRequest21(this OcipClient client, UserCallForwardingSelectiveGetCriteriaRequest21 request) {
        return await client.Call(request) as UserCallForwardingSelectiveGetCriteriaResponse21;
    }

    /// <summary>
    /// Get the user's call forwarding selective service setting.
    /// The response is either a UserCallForwardingSelectiveGetResponse16 or an ErrorResponse.
    /// </summary>
    public static async Task<UserCallForwardingSelectiveGetResponse16> UserCallForwardingSelectiveGetRequest16(this OcipClient client, UserCallForwardingSelectiveGetRequest16 request) {
        return await client.Call(request) as UserCallForwardingSelectiveGetResponse16;
    }

    /// <summary>
    /// Modify a criteria for the user's call forwarding selective service.
    /// The following elements are only used in AS data mode:
    /// callToNumber
    /// 
    /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCallForwardingSelectiveModifyCriteriaRequest(this OcipClient client, UserCallForwardingSelectiveModifyCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Modify the user's call forwarding selective service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCallForwardingSelectiveModifyRequest(this OcipClient client, UserCallForwardingSelectiveModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
