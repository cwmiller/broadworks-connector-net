using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceVoiceXmlExtensions
{

    /// <summary>
    /// Add a VoiceXML instance to a group.
    /// The domain is required in the serviceUserId.  For a valid voiceXml instance to work properly,
    /// a device with Static Registration is expected with a valid contact.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupVoiceXmlAddInstanceRequest(this OcipClient client, GroupVoiceXmlAddInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a VoiceXML instance from a group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupVoiceXmlDeleteInstanceRequest(this OcipClient client, GroupVoiceXmlDeleteInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get a list of VoiceXML instances within a group.
    /// The response is either GroupVoiceXmlGetInstanceListResponse or ErrorResponse.
    /// It is possible to get the instances within a specified department.
    /// </summary>
    public static async Task<GroupVoiceXmlGetInstanceListResponse> GroupVoiceXmlGetInstanceListRequest(this OcipClient client, GroupVoiceXmlGetInstanceListRequest request) {
        return await client.Call(request) as GroupVoiceXmlGetInstanceListResponse;
    }

    /// <summary>
    /// Request to get all the information of a VoiceXML instance.
    /// The response is either GroupVoiceXmlGetInstanceResponse22 or ErrorResponse.
    /// </summary>
    public static async Task<GroupVoiceXmlGetInstanceResponse22> GroupVoiceXmlGetInstanceRequest22(this OcipClient client, GroupVoiceXmlGetInstanceRequest22 request) {
        return await client.Call(request) as GroupVoiceXmlGetInstanceResponse22;
    }

    /// <summary>
    /// Request to set the active status of VoiceXML instances.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupVoiceXmlModifyActiveInstanceListRequest(this OcipClient client, GroupVoiceXmlModifyActiveInstanceListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request to modify a VoiceXML instance. For a valid voiceXml instance to work properly,
    /// a device with Static Registration is expected with a valid contact.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupVoiceXmlModifyInstanceRequest(this OcipClient client, GroupVoiceXmlModifyInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
