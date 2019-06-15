using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceEmergencyZonesExtensions
{

    /// <summary>
    /// Add a list of home zones and/or home zone ranges to the group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupEmergencyZonesAddHomeZoneListRequest(this OcipClient client, GroupEmergencyZonesAddHomeZoneListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a list of home zones and/or home zone ranges to the group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupEmergencyZonesDeleteHomeZoneListRequest(this OcipClient client, GroupEmergencyZonesDeleteHomeZoneListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the group level data associated with Emergency Zones.
    /// The response is either a GroupEmergencyZonesGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<GroupEmergencyZonesGetResponse> GroupEmergencyZonesGetHomeZoneListRequest(this OcipClient client, GroupEmergencyZonesGetHomeZoneListRequest request) {
        return await client.Call(request) as GroupEmergencyZonesGetResponse;
    }

    /// <summary>
    /// Request the group level data associated with Emergency Zones.
    /// The response is either a GroupEmergencyZonesGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<GroupEmergencyZonesGetResponse> GroupEmergencyZonesGetRequest(this OcipClient client, GroupEmergencyZonesGetRequest request) {
        return await client.Call(request) as GroupEmergencyZonesGetResponse;
    }

    /// <summary>
    /// Modify a list of home zones and/or home zone ranges.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupEmergencyZonesModifyHomeZoneListRequest(this OcipClient client, GroupEmergencyZonesModifyHomeZoneListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Modify the group level data associated with Emergency Zones.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupEmergencyZonesModifyRequest(this OcipClient client, GroupEmergencyZonesModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the reseller level data associated with Emergency Zones.
    /// The response is either a ResellerEmergencyZonesGetResponse or an
    /// ErrorResponse.
    /// </summary>
    public static async Task<ResellerEmergencyZonesGetResponse> ResellerEmergencyZonesGetRequest(this OcipClient client, ResellerEmergencyZonesGetRequest request) {
        return await client.Call(request) as ResellerEmergencyZonesGetResponse;
    }

    /// <summary>
    /// Modify the reseller level data associated with Emergency Zones.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> ResellerEmergencyZonesModifyRequest(this OcipClient client, ResellerEmergencyZonesModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the system level data associated with Emergency Zones.
    /// The response is either a SystemEmergencyZonesGetResponse or an
    /// ErrorResponse.
    /// </summary>
    public static async Task<SystemEmergencyZonesGetResponse> SystemEmergencyZonesGetRequest(this OcipClient client, SystemEmergencyZonesGetRequest request) {
        return await client.Call(request) as SystemEmergencyZonesGetResponse;
    }

    /// <summary>
    /// Modify the system level data associated with Emergency Zones.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemEmergencyZonesModifyRequest(this OcipClient client, SystemEmergencyZonesModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
