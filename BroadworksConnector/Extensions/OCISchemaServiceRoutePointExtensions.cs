using System;
using System.Threading;
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
        [Obsolete("This method is deprecated. Use GroupRoutePointAddDNISRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointAddDNISRequest(this OcipClient client, GroupRoutePointAddDNISRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Route Point DNIS.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointAddDNISRequestAsync(this OcipClient client, GroupRoutePointAddDNISRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Route Point instance to a group.
        /// The Route Point is a Call Center queue that performs the same function but
        /// allows an external system to perform the distribution of calls instead of making
        /// those decisions itself.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The Following elements are only used in AS data mode and ignored in XS data mode:
        /// - sendCallAdmissionNotification, use value ‘false’ in XS data mode.
        /// - callAdmissionTimerSeconds, use value ‘3’ in XS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointAddInstanceRequest23Async instead.")]
        public static async Task<SuccessResponse> GroupRoutePointAddInstanceRequest23(this OcipClient client, GroupRoutePointAddInstanceRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Route Point instance to a group.
        /// The Route Point is a Call Center queue that performs the same function but
        /// allows an external system to perform the distribution of calls instead of making
        /// those decisions itself.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The Following elements are only used in AS data mode and ignored in XS data mode:
        /// - sendCallAdmissionNotification, use value ‘false’ in XS data mode.
        /// - callAdmissionTimerSeconds, use value ‘3’ in XS data mode.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointAddInstanceRequest23Async(this OcipClient client, GroupRoutePointAddInstanceRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a route point's bounced call settings.
        /// The response is either a GroupRoutePointBouncedCallGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointBouncedCallGetRequestAsync instead.")]
        public static async Task<GroupRoutePointBouncedCallGetResponse> GroupRoutePointBouncedCallGetRequest(this OcipClient client, GroupRoutePointBouncedCallGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointBouncedCallGetResponse;
        }

        /// <summary>
        /// Get a route point's bounced call settings.
        /// The response is either a GroupRoutePointBouncedCallGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointBouncedCallGetResponse> GroupRoutePointBouncedCallGetRequestAsync(this OcipClient client, GroupRoutePointBouncedCallGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointBouncedCallGetResponse;
        }
        /// <summary>
        /// Modify a route point's bounced call settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointBouncedCallModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointBouncedCallModifyRequest(this OcipClient client, GroupRoutePointBouncedCallModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point's bounced call settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointBouncedCallModifyRequestAsync(this OcipClient client, GroupRoutePointBouncedCallModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a route point's DNIS.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointDeleteDNISRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointDeleteDNISRequest(this OcipClient client, GroupRoutePointDeleteDNISRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a route point's DNIS.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointDeleteDNISRequestAsync(this OcipClient client, GroupRoutePointDeleteDNISRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Route Point instance from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointDeleteInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointDeleteInstanceRequest(this OcipClient client, GroupRoutePointDeleteInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Route Point instance from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointDeleteInstanceRequestAsync(this OcipClient client, GroupRoutePointDeleteInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the distinctive ringing configuration values for route point.
        /// The response is either a GroupRoutePointDistinctiveRingingGetResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointDistinctiveRingingGetRequestAsync instead.")]
        public static async Task<GroupRoutePointDistinctiveRingingGetResponse> GroupRoutePointDistinctiveRingingGetRequest(this OcipClient client, GroupRoutePointDistinctiveRingingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointDistinctiveRingingGetResponse;
        }

        /// <summary>
        /// Get the distinctive ringing configuration values for route point.
        /// The response is either a GroupRoutePointDistinctiveRingingGetResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointDistinctiveRingingGetResponse> GroupRoutePointDistinctiveRingingGetRequestAsync(this OcipClient client, GroupRoutePointDistinctiveRingingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointDistinctiveRingingGetResponse;
        }
        /// <summary>
        /// Modify the distinctive ringing configuration values for route point.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointDistinctiveRingingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointDistinctiveRingingModifyRequest(this OcipClient client, GroupRoutePointDistinctiveRingingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the distinctive ringing configuration values for route point.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointDistinctiveRingingModifyRequestAsync(this OcipClient client, GroupRoutePointDistinctiveRingingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a route point's forced forwarding settings.
        /// The response is either a GroupRoutePointForcedForwardingGetResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointForcedForwardingGetRequest20Async instead.")]
        public static async Task<GroupRoutePointForcedForwardingGetResponse20> GroupRoutePointForcedForwardingGetRequest20(this OcipClient client, GroupRoutePointForcedForwardingGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointForcedForwardingGetResponse20;
        }

        /// <summary>
        /// Get a route point's forced forwarding settings.
        /// The response is either a GroupRoutePointForcedForwardingGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointForcedForwardingGetResponse20> GroupRoutePointForcedForwardingGetRequest20Async(this OcipClient client, GroupRoutePointForcedForwardingGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointForcedForwardingGetResponse20;
        }
        /// <summary>
        /// Modify a route point's forced forwarding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointForcedForwardingModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupRoutePointForcedForwardingModifyRequest20(this OcipClient client, GroupRoutePointForcedForwardingModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point's forced forwarding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointForcedForwardingModifyRequest20Async(this OcipClient client, GroupRoutePointForcedForwardingModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a route point's announcement settings.
        /// The response is either a GroupRoutePointGetAnnouncementResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetAnnouncementRequest22Async instead.")]
        public static async Task<GroupRoutePointGetAnnouncementResponse22> GroupRoutePointGetAnnouncementRequest22(this OcipClient client, GroupRoutePointGetAnnouncementRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetAnnouncementResponse22;
        }

        /// <summary>
        /// Get a route point's announcement settings.
        /// The response is either a GroupRoutePointGetAnnouncementResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetAnnouncementResponse22> GroupRoutePointGetAnnouncementRequest22Async(this OcipClient client, GroupRoutePointGetAnnouncementRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetAnnouncementResponse22;
        }
        /// <summary>
        /// Get a list of agent who selected the DNIS as the outgoing call.
        /// The response is either GroupRoutePointGetDNISAgentListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetDNISAgentListRequestAsync instead.")]
        public static async Task<GroupRoutePointGetDNISAgentListResponse> GroupRoutePointGetDNISAgentListRequest(this OcipClient client, GroupRoutePointGetDNISAgentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetDNISAgentListResponse;
        }

        /// <summary>
        /// Get a list of agent who selected the DNIS as the outgoing call.
        /// The response is either GroupRoutePointGetDNISAgentListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetDNISAgentListResponse> GroupRoutePointGetDNISAgentListRequestAsync(this OcipClient client, GroupRoutePointGetDNISAgentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetDNISAgentListResponse;
        }
        /// <summary>
        /// Get a route point's DNIS Announcements
        /// The response is either a GroupRoutePointGetDNISAnnouncementResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetDNISAnnouncementRequest22Async instead.")]
        public static async Task<GroupRoutePointGetDNISAnnouncementResponse22> GroupRoutePointGetDNISAnnouncementRequest22(this OcipClient client, GroupRoutePointGetDNISAnnouncementRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetDNISAnnouncementResponse22;
        }

        /// <summary>
        /// Get a route point's DNIS Announcements
        /// The response is either a GroupRoutePointGetDNISAnnouncementResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetDNISAnnouncementResponse22> GroupRoutePointGetDNISAnnouncementRequest22Async(this OcipClient client, GroupRoutePointGetDNISAnnouncementRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetDNISAnnouncementResponse22;
        }
        /// <summary>
        /// Get a list of DNIS that are configured for a Route Point.
        /// The response is either GroupRoutePointGetDNISListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetDNISListRequestAsync instead.")]
        public static async Task<GroupRoutePointGetDNISListResponse> GroupRoutePointGetDNISListRequest(this OcipClient client, GroupRoutePointGetDNISListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetDNISListResponse;
        }

        /// <summary>
        /// Get a list of DNIS that are configured for a Route Point.
        /// The response is either GroupRoutePointGetDNISListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetDNISListResponse> GroupRoutePointGetDNISListRequestAsync(this OcipClient client, GroupRoutePointGetDNISListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetDNISListResponse;
        }
        /// <summary>
        /// Get a route point's DNIS.
        /// The response is either a GroupRoutePointGetDNISResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetDNISRequestAsync instead.")]
        public static async Task<GroupRoutePointGetDNISResponse> GroupRoutePointGetDNISRequest(this OcipClient client, GroupRoutePointGetDNISRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetDNISResponse;
        }

        /// <summary>
        /// Get a route point's DNIS.
        /// The response is either a GroupRoutePointGetDNISResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetDNISResponse> GroupRoutePointGetDNISRequestAsync(this OcipClient client, GroupRoutePointGetDNISRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetDNISResponse;
        }
        /// <summary>
        /// Get the route point failover policy.
        /// The response is either a GroupRoutePointGetFailoverPolicyResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetFailoverPolicyRequestAsync instead.")]
        public static async Task<GroupRoutePointGetFailoverPolicyResponse> GroupRoutePointGetFailoverPolicyRequest(this OcipClient client, GroupRoutePointGetFailoverPolicyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetFailoverPolicyResponse;
        }

        /// <summary>
        /// Get the route point failover policy.
        /// The response is either a GroupRoutePointGetFailoverPolicyResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetFailoverPolicyResponse> GroupRoutePointGetFailoverPolicyRequestAsync(this OcipClient client, GroupRoutePointGetFailoverPolicyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetFailoverPolicyResponse;
        }
        /// <summary>
        /// Get a list of Route Point instances within a group.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// The response is either GroupRoutePointGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetInstanceListRequestAsync instead.")]
        public static async Task<GroupRoutePointGetInstanceListResponse> GroupRoutePointGetInstanceListRequest(this OcipClient client, GroupRoutePointGetInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetInstanceListResponse;
        }

        /// <summary>
        /// Get a list of Route Point instances within a group.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// The response is either GroupRoutePointGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        public static async Task<GroupRoutePointGetInstanceListResponse> GroupRoutePointGetInstanceListRequestAsync(this OcipClient client, GroupRoutePointGetInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetInstanceListResponse;
        }
        /// <summary>
        /// Request to get all the information of a Route Point instance.
        /// The response is either GroupRoutePointGetInstanceResponse19sp1 or ErrorResponse.
        /// The Following elements are only used in AS data mode and ignored in XS data mode:
        /// - sendCallAdmissionNotification, use value ‘false’ in XS data mode.
        /// - callAdmissionTimerSeconds, use value ‘3’ in XS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetInstanceRequest23Async instead.")]
        public static async Task<GroupRoutePointGetInstanceResponse19sp1> GroupRoutePointGetInstanceRequest23(this OcipClient client, GroupRoutePointGetInstanceRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetInstanceResponse19sp1;
        }

        /// <summary>
        /// Request to get all the information of a Route Point instance.
        /// The response is either GroupRoutePointGetInstanceResponse19sp1 or ErrorResponse.
        /// The Following elements are only used in AS data mode and ignored in XS data mode:
        /// - sendCallAdmissionNotification, use value ‘false’ in XS data mode.
        /// - callAdmissionTimerSeconds, use value ‘3’ in XS data mode.
        /// </summary>
        public static async Task<GroupRoutePointGetInstanceResponse19sp1> GroupRoutePointGetInstanceRequest23Async(this OcipClient client, GroupRoutePointGetInstanceRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetInstanceResponse19sp1;
        }
        /// <summary>
        /// Get a route point's holiday service settings.
        /// The response is either a GroupRoutePointHolidayServiceGetResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointHolidayServiceGetRequest20Async instead.")]
        public static async Task<GroupRoutePointHolidayServiceGetResponse20> GroupRoutePointHolidayServiceGetRequest20(this OcipClient client, GroupRoutePointHolidayServiceGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointHolidayServiceGetResponse20;
        }

        /// <summary>
        /// Get a route point's holiday service settings.
        /// The response is either a GroupRoutePointHolidayServiceGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointHolidayServiceGetResponse20> GroupRoutePointHolidayServiceGetRequest20Async(this OcipClient client, GroupRoutePointHolidayServiceGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointHolidayServiceGetResponse20;
        }
        /// <summary>
        /// Modify a route point's holiday service settings.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointHolidayServiceModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupRoutePointHolidayServiceModifyRequest20(this OcipClient client, GroupRoutePointHolidayServiceModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point's holiday service settings.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointHolidayServiceModifyRequest20Async(this OcipClient client, GroupRoutePointHolidayServiceModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Initiate manual failover for the Route Point.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointManualFailoverRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointManualFailoverRequest(this OcipClient client, GroupRoutePointManualFailoverRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Initiate manual failover for the Route Point.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointManualFailoverRequestAsync(this OcipClient client, GroupRoutePointManualFailoverRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to set the active status of Route Point instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointModifyActiveInstanceListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointModifyActiveInstanceListRequest(this OcipClient client, GroupRoutePointModifyActiveInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to set the active status of Route Point instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyActiveInstanceListRequestAsync(this OcipClient client, GroupRoutePointModifyActiveInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a route point's announcement settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointModifyAnnouncementRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupRoutePointModifyAnnouncementRequest20(this OcipClient client, GroupRoutePointModifyAnnouncementRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point's announcement settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyAnnouncementRequest20Async(this OcipClient client, GroupRoutePointModifyAnnouncementRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a route point DNIS announcement settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointModifyDNISAnnouncementRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupRoutePointModifyDNISAnnouncementRequest20(this OcipClient client, GroupRoutePointModifyDNISAnnouncementRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point DNIS announcement settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyDNISAnnouncementRequest20Async(this OcipClient client, GroupRoutePointModifyDNISAnnouncementRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the setting that are configured for all the DNIS in a Route Point.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointModifyDNISParametersRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointModifyDNISParametersRequest(this OcipClient client, GroupRoutePointModifyDNISParametersRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the setting that are configured for all the DNIS in a Route Point.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyDNISParametersRequestAsync(this OcipClient client, GroupRoutePointModifyDNISParametersRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a route point's DNIS settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointModifyDNISRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointModifyDNISRequest(this OcipClient client, GroupRoutePointModifyDNISRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point's DNIS settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyDNISRequestAsync(this OcipClient client, GroupRoutePointModifyDNISRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the route point failover policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointModifyFailoverPolicyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointModifyFailoverPolicyRequest(this OcipClient client, GroupRoutePointModifyFailoverPolicyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the route point failover policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyFailoverPolicyRequestAsync(this OcipClient client, GroupRoutePointModifyFailoverPolicyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a Route Point instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The Following elements are only used in AS data mode and ignored in XS data mode:
        /// - sendCallAdmissionNotification, use value ‘false’ in XS data mode.
        /// - callAdmissionTimerSeconds, use value ‘3’ in XS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointModifyInstanceRequest22Async instead.")]
        public static async Task<SuccessResponse> GroupRoutePointModifyInstanceRequest22(this OcipClient client, GroupRoutePointModifyInstanceRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Route Point instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The Following elements are only used in AS data mode and ignored in XS data mode:
        /// - sendCallAdmissionNotification, use value ‘false’ in XS data mode.
        /// - callAdmissionTimerSeconds, use value ‘3’ in XS data mode.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyInstanceRequest22Async(this OcipClient client, GroupRoutePointModifyInstanceRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a route point's night service settings.
        /// The response is either a GroupRoutePointNightServiceGetResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointNightServiceGetRequest20Async instead.")]
        public static async Task<GroupRoutePointNightServiceGetResponse20> GroupRoutePointNightServiceGetRequest20(this OcipClient client, GroupRoutePointNightServiceGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointNightServiceGetResponse20;
        }

        /// <summary>
        /// Get a route point's night service settings.
        /// The response is either a GroupRoutePointNightServiceGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointNightServiceGetResponse20> GroupRoutePointNightServiceGetRequest20Async(this OcipClient client, GroupRoutePointNightServiceGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointNightServiceGetResponse20;
        }
        /// <summary>
        /// Modify a route point's night service settings.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointNightServiceModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupRoutePointNightServiceModifyRequest20(this OcipClient client, GroupRoutePointNightServiceModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point's night service settings.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointNightServiceModifyRequest20Async(this OcipClient client, GroupRoutePointNightServiceModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a route point's overflow settings.
        /// The response is either a GroupRoutePointOverflowGetResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointOverflowGetRequest20Async instead.")]
        public static async Task<GroupRoutePointOverflowGetResponse20> GroupRoutePointOverflowGetRequest20(this OcipClient client, GroupRoutePointOverflowGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointOverflowGetResponse20;
        }

        /// <summary>
        /// Get a route point's overflow settings.
        /// The response is either a GroupRoutePointOverflowGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointOverflowGetResponse20> GroupRoutePointOverflowGetRequest20Async(this OcipClient client, GroupRoutePointOverflowGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointOverflowGetResponse20;
        }
        /// <summary>
        /// Modify a route point's overflow settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointOverflowModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupRoutePointOverflowModifyRequest20(this OcipClient client, GroupRoutePointOverflowModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point's overflow settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointOverflowModifyRequest20Async(this OcipClient client, GroupRoutePointOverflowModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Route Point Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointQueueCallDispositionCodeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeAddRequest(this OcipClient client, GroupRoutePointQueueCallDispositionCodeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Route Point Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeAddRequestAsync(this OcipClient client, GroupRoutePointQueueCallDispositionCodeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Route Point Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointQueueCallDispositionCodeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeDeleteRequest(this OcipClient client, GroupRoutePointQueueCallDispositionCodeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Route Point Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeDeleteRequestAsync(this OcipClient client, GroupRoutePointQueueCallDispositionCodeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of Route Point Level and Organization Level Call Disposition Codes.
        /// The response is either GroupRoutePointQueueCallDispositionCodeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointQueueCallDispositionCodeGetListRequestAsync instead.")]
        public static async Task<GroupRoutePointQueueCallDispositionCodeGetListResponse> GroupRoutePointQueueCallDispositionCodeGetListRequest(this OcipClient client, GroupRoutePointQueueCallDispositionCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointQueueCallDispositionCodeGetListResponse;
        }

        /// <summary>
        /// Get the list of Route Point Level and Organization Level Call Disposition Codes.
        /// The response is either GroupRoutePointQueueCallDispositionCodeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointQueueCallDispositionCodeGetListResponse> GroupRoutePointQueueCallDispositionCodeGetListRequestAsync(this OcipClient client, GroupRoutePointQueueCallDispositionCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointQueueCallDispositionCodeGetListResponse;
        }
        /// <summary>
        /// Get a Route Point Call Disposition Code.
        /// The response is either GroupRoutePointQueueCallDispositionCodeGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointQueueCallDispositionCodeGetRequestAsync instead.")]
        public static async Task<GroupRoutePointQueueCallDispositionCodeGetResponse> GroupRoutePointQueueCallDispositionCodeGetRequest(this OcipClient client, GroupRoutePointQueueCallDispositionCodeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointQueueCallDispositionCodeGetResponse;
        }

        /// <summary>
        /// Get a Route Point Call Disposition Code.
        /// The response is either GroupRoutePointQueueCallDispositionCodeGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointQueueCallDispositionCodeGetResponse> GroupRoutePointQueueCallDispositionCodeGetRequestAsync(this OcipClient client, GroupRoutePointQueueCallDispositionCodeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointQueueCallDispositionCodeGetResponse;
        }
        /// <summary>
        /// Modify a Route Point Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointQueueCallDispositionCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeModifyRequest(this OcipClient client, GroupRoutePointQueueCallDispositionCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Route Point Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeModifyRequestAsync(this OcipClient client, GroupRoutePointQueueCallDispositionCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the queue level data associated with Route Point Call Disposition Code Settings.
        /// The response is either an GroupRoutePointQueueCallDispositionCodeSettingsGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointQueueCallDispositionCodeSettingsGetRequestAsync instead.")]
        public static async Task<GroupRoutePointQueueCallDispositionCodeSettingsGetResponse> GroupRoutePointQueueCallDispositionCodeSettingsGetRequest(this OcipClient client, GroupRoutePointQueueCallDispositionCodeSettingsGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointQueueCallDispositionCodeSettingsGetResponse;
        }

        /// <summary>
        /// Request the queue level data associated with Route Point Call Disposition Code Settings.
        /// The response is either an GroupRoutePointQueueCallDispositionCodeSettingsGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointQueueCallDispositionCodeSettingsGetResponse> GroupRoutePointQueueCallDispositionCodeSettingsGetRequestAsync(this OcipClient client, GroupRoutePointQueueCallDispositionCodeSettingsGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointQueueCallDispositionCodeSettingsGetResponse;
        }
        /// <summary>
        /// Modify the queue level data associated with Route Point Agents Unavailable Code Settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointQueueCallDispositionCodeSettingsModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeSettingsModifyRequest(this OcipClient client, GroupRoutePointQueueCallDispositionCodeSettingsModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the queue level data associated with Route Point Agents Unavailable Code Settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeSettingsModifyRequestAsync(this OcipClient client, GroupRoutePointQueueCallDispositionCodeSettingsModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of available Route Point Call Disposition Codes to be used by a client.
        /// The response is either UserRoutePointCallDispositionCodeGetAvailableListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserRoutePointCallDispositionCodeGetAvailableListRequestAsync instead.")]
        public static async Task<UserRoutePointCallDispositionCodeGetAvailableListResponse> UserRoutePointCallDispositionCodeGetAvailableListRequest(this OcipClient client, UserRoutePointCallDispositionCodeGetAvailableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserRoutePointCallDispositionCodeGetAvailableListResponse;
        }

        /// <summary>
        /// Get the list of available Route Point Call Disposition Codes to be used by a client.
        /// The response is either UserRoutePointCallDispositionCodeGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserRoutePointCallDispositionCodeGetAvailableListResponse> UserRoutePointCallDispositionCodeGetAvailableListRequestAsync(this OcipClient client, UserRoutePointCallDispositionCodeGetAvailableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserRoutePointCallDispositionCodeGetAvailableListResponse;
        }
        /// <summary>
        /// Get a list of Route Point supervisors assigned to a user.
        /// The response is either a UserRoutePointSupervisorGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserRoutePointSupervisorGetListRequestAsync instead.")]
        public static async Task<UserRoutePointSupervisorGetListResponse> UserRoutePointSupervisorGetListRequest(this OcipClient client, UserRoutePointSupervisorGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserRoutePointSupervisorGetListResponse;
        }

        /// <summary>
        /// Get a list of Route Point supervisors assigned to a user.
        /// The response is either a UserRoutePointSupervisorGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserRoutePointSupervisorGetListResponse> UserRoutePointSupervisorGetListRequestAsync(this OcipClient client, UserRoutePointSupervisorGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserRoutePointSupervisorGetListResponse;
        }
        /// <summary>
        /// Request to modify the Route Point supervisor list for a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserRoutePointSupervisorModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserRoutePointSupervisorModifyListRequest(this OcipClient client, UserRoutePointSupervisorModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the Route Point supervisor list for a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserRoutePointSupervisorModifyListRequestAsync(this OcipClient client, UserRoutePointSupervisorModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
