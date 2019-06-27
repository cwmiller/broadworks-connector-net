using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceRoutePointExtensions
    {

        /// <summary>
        /// Add a Route Point DNIS.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointAddDNISRequest(this OcipClient client, GroupRoutePointAddDNISRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Route Point instance to a group.
        /// The Route Point is a Call Center queue that performs the same function but
        /// allows an external system to perform the distribution of calls instead of making
        /// those decisions itself.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointAddInstanceRequest22(this OcipClient client, GroupRoutePointAddInstanceRequest22 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a route point's bounced call settings.
        /// The response is either a GroupRoutePointBouncedCallGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointBouncedCallGetResponse> GroupRoutePointBouncedCallGetRequest(this OcipClient client, GroupRoutePointBouncedCallGetRequest request)
        {
            return await client.Call(request) as GroupRoutePointBouncedCallGetResponse;
        }

        /// <summary>
        /// Modify a route point's bounced call settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointBouncedCallModifyRequest(this OcipClient client, GroupRoutePointBouncedCallModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a route point's DNIS.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointDeleteDNISRequest(this OcipClient client, GroupRoutePointDeleteDNISRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Route Point instance from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointDeleteInstanceRequest(this OcipClient client, GroupRoutePointDeleteInstanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the distinctive ringing configuration values for route point.
        /// The response is either a GroupRoutePointDistinctiveRingingGetResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointDistinctiveRingingGetResponse> GroupRoutePointDistinctiveRingingGetRequest(this OcipClient client, GroupRoutePointDistinctiveRingingGetRequest request)
        {
            return await client.Call(request) as GroupRoutePointDistinctiveRingingGetResponse;
        }

        /// <summary>
        /// Modify the distinctive ringing configuration values for route point.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointDistinctiveRingingModifyRequest(this OcipClient client, GroupRoutePointDistinctiveRingingModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a route point's forced forwarding settings.
        /// The response is either a GroupRoutePointForcedForwardingGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointForcedForwardingGetResponse20> GroupRoutePointForcedForwardingGetRequest20(this OcipClient client, GroupRoutePointForcedForwardingGetRequest20 request)
        {
            return await client.Call(request) as GroupRoutePointForcedForwardingGetResponse20;
        }

        /// <summary>
        /// Modify a route point's forced forwarding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointForcedForwardingModifyRequest20(this OcipClient client, GroupRoutePointForcedForwardingModifyRequest20 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a route point's announcement settings.
        /// The response is either a GroupRoutePointGetAnnouncementResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetAnnouncementResponse20> GroupRoutePointGetAnnouncementRequest20(this OcipClient client, GroupRoutePointGetAnnouncementRequest20 request)
        {
            return await client.Call(request) as GroupRoutePointGetAnnouncementResponse20;
        }

        /// <summary>
        /// Get a route point's announcement settings.
        /// The response is either a GroupRoutePointGetAnnouncementResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetAnnouncementResponse22> GroupRoutePointGetAnnouncementRequest22(this OcipClient client, GroupRoutePointGetAnnouncementRequest22 request)
        {
            return await client.Call(request) as GroupRoutePointGetAnnouncementResponse22;
        }

        /// <summary>
        /// Get a list of agent who selected the DNIS as the outgoing call.
        /// The response is either GroupRoutePointGetDNISAgentListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetDNISAgentListResponse> GroupRoutePointGetDNISAgentListRequest(this OcipClient client, GroupRoutePointGetDNISAgentListRequest request)
        {
            return await client.Call(request) as GroupRoutePointGetDNISAgentListResponse;
        }

        /// <summary>
        /// Get a route point's DNIS Announcements
        /// The response is either a GroupRoutePointGetDNISAnnouncementResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetDNISAnnouncementResponse20> GroupRoutePointGetDNISAnnouncementRequest20(this OcipClient client, GroupRoutePointGetDNISAnnouncementRequest20 request)
        {
            return await client.Call(request) as GroupRoutePointGetDNISAnnouncementResponse20;
        }

        /// <summary>
        /// Get a route point's DNIS Announcements
        /// The response is either a GroupRoutePointGetDNISAnnouncementResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetDNISAnnouncementResponse22> GroupRoutePointGetDNISAnnouncementRequest22(this OcipClient client, GroupRoutePointGetDNISAnnouncementRequest22 request)
        {
            return await client.Call(request) as GroupRoutePointGetDNISAnnouncementResponse22;
        }

        /// <summary>
        /// Get a list of DNIS that are configured for a Route Point.
        /// The response is either GroupRoutePointGetDNISListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetDNISListResponse> GroupRoutePointGetDNISListRequest(this OcipClient client, GroupRoutePointGetDNISListRequest request)
        {
            return await client.Call(request) as GroupRoutePointGetDNISListResponse;
        }

        /// <summary>
        /// Get a route point's DNIS.
        /// The response is either a GroupRoutePointGetDNISResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetDNISResponse> GroupRoutePointGetDNISRequest(this OcipClient client, GroupRoutePointGetDNISRequest request)
        {
            return await client.Call(request) as GroupRoutePointGetDNISResponse;
        }

        /// <summary>
        /// Get the route point failover policy.
        /// The response is either a GroupRoutePointGetFailoverPolicyResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetFailoverPolicyResponse> GroupRoutePointGetFailoverPolicyRequest(this OcipClient client, GroupRoutePointGetFailoverPolicyRequest request)
        {
            return await client.Call(request) as GroupRoutePointGetFailoverPolicyResponse;
        }

        /// <summary>
        /// Get a list of Route Point instances within a group.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// The response is either GroupRoutePointGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        public static async Task<GroupRoutePointGetInstanceListResponse> GroupRoutePointGetInstanceListRequest(this OcipClient client, GroupRoutePointGetInstanceListRequest request)
        {
            return await client.Call(request) as GroupRoutePointGetInstanceListResponse;
        }

        /// <summary>
        /// Request to get all the information of a Route Point instance.
        /// The response is either GroupRoutePointGetInstanceResponse19sp1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetInstanceResponse19sp1> GroupRoutePointGetInstanceRequest22(this OcipClient client, GroupRoutePointGetInstanceRequest22 request)
        {
            return await client.Call(request) as GroupRoutePointGetInstanceResponse19sp1;
        }

        /// <summary>
        /// Get a route point's holiday service settings.
        /// The response is either a GroupRoutePointHolidayServiceGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointHolidayServiceGetResponse20> GroupRoutePointHolidayServiceGetRequest20(this OcipClient client, GroupRoutePointHolidayServiceGetRequest20 request)
        {
            return await client.Call(request) as GroupRoutePointHolidayServiceGetResponse20;
        }

        /// <summary>
        /// Modify a route point's holiday service settings.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointHolidayServiceModifyRequest20(this OcipClient client, GroupRoutePointHolidayServiceModifyRequest20 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Initiate manual failover for the Route Point.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointManualFailoverRequest(this OcipClient client, GroupRoutePointManualFailoverRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to set the active status of Route Point instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyActiveInstanceListRequest(this OcipClient client, GroupRoutePointModifyActiveInstanceListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point's announcement settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyAnnouncementRequest20(this OcipClient client, GroupRoutePointModifyAnnouncementRequest20 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point DNIS announcement settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyDNISAnnouncementRequest20(this OcipClient client, GroupRoutePointModifyDNISAnnouncementRequest20 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the setting that are configured for all the DNIS in a Route Point.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyDNISParametersRequest(this OcipClient client, GroupRoutePointModifyDNISParametersRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point's DNIS settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyDNISRequest(this OcipClient client, GroupRoutePointModifyDNISRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the route point failover policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyFailoverPolicyRequest(this OcipClient client, GroupRoutePointModifyFailoverPolicyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Route Point instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyInstanceRequest22(this OcipClient client, GroupRoutePointModifyInstanceRequest22 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a route point's night service settings.
        /// The response is either a GroupRoutePointNightServiceGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointNightServiceGetResponse20> GroupRoutePointNightServiceGetRequest20(this OcipClient client, GroupRoutePointNightServiceGetRequest20 request)
        {
            return await client.Call(request) as GroupRoutePointNightServiceGetResponse20;
        }

        /// <summary>
        /// Modify a route point's night service settings.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointNightServiceModifyRequest20(this OcipClient client, GroupRoutePointNightServiceModifyRequest20 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a route point's overflow settings.
        /// The response is either a GroupRoutePointOverflowGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointOverflowGetResponse20> GroupRoutePointOverflowGetRequest20(this OcipClient client, GroupRoutePointOverflowGetRequest20 request)
        {
            return await client.Call(request) as GroupRoutePointOverflowGetResponse20;
        }

        /// <summary>
        /// Modify a route point's overflow settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointOverflowModifyRequest20(this OcipClient client, GroupRoutePointOverflowModifyRequest20 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Route Point Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeAddRequest(this OcipClient client, GroupRoutePointQueueCallDispositionCodeAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Route Point Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeDeleteRequest(this OcipClient client, GroupRoutePointQueueCallDispositionCodeDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the list of Route Point Level and Organization Level Call Disposition Codes.
        /// The response is either GroupRoutePointQueueCallDispositionCodeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointQueueCallDispositionCodeGetListResponse> GroupRoutePointQueueCallDispositionCodeGetListRequest(this OcipClient client, GroupRoutePointQueueCallDispositionCodeGetListRequest request)
        {
            return await client.Call(request) as GroupRoutePointQueueCallDispositionCodeGetListResponse;
        }

        /// <summary>
        /// Get a Route Point Call Disposition Code.
        /// The response is either GroupRoutePointQueueCallDispositionCodeGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointQueueCallDispositionCodeGetResponse> GroupRoutePointQueueCallDispositionCodeGetRequest(this OcipClient client, GroupRoutePointQueueCallDispositionCodeGetRequest request)
        {
            return await client.Call(request) as GroupRoutePointQueueCallDispositionCodeGetResponse;
        }

        /// <summary>
        /// Modify a Route Point Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeModifyRequest(this OcipClient client, GroupRoutePointQueueCallDispositionCodeModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the queue level data associated with Route Point Call Disposition Code Settings.
        /// The response is either an GroupRoutePointQueueCallDispositionCodeSettingsGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointQueueCallDispositionCodeSettingsGetResponse> GroupRoutePointQueueCallDispositionCodeSettingsGetRequest(this OcipClient client, GroupRoutePointQueueCallDispositionCodeSettingsGetRequest request)
        {
            return await client.Call(request) as GroupRoutePointQueueCallDispositionCodeSettingsGetResponse;
        }

        /// <summary>
        /// Modify the queue level data associated with Route Point Agents Unavailable Code Settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeSettingsModifyRequest(this OcipClient client, GroupRoutePointQueueCallDispositionCodeSettingsModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the list of available Route Point Call Disposition Codes to be used by a client.
        /// The response is either UserRoutePointCallDispositionCodeGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserRoutePointCallDispositionCodeGetAvailableListResponse> UserRoutePointCallDispositionCodeGetAvailableListRequest(this OcipClient client, UserRoutePointCallDispositionCodeGetAvailableListRequest request)
        {
            return await client.Call(request) as UserRoutePointCallDispositionCodeGetAvailableListResponse;
        }

        /// <summary>
        /// Get a list of Route Point supervisors assigned to a user.
        /// The response is either a UserRoutePointSupervisorGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserRoutePointSupervisorGetListResponse> UserRoutePointSupervisorGetListRequest(this OcipClient client, UserRoutePointSupervisorGetListRequest request)
        {
            return await client.Call(request) as UserRoutePointSupervisorGetListResponse;
        }

        /// <summary>
        /// Request to modify the Route Point supervisor list for a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserRoutePointSupervisorModifyListRequest(this OcipClient client, UserRoutePointSupervisorModifyListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
