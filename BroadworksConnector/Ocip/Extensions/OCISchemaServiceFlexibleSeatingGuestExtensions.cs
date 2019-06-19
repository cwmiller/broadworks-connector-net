using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceFlexibleSeatingGuestExtensions
    {

        /// <summary>
        /// Requests the list of access devices available for assignment to a flexible
        /// seating host or guest. The list includes devices created at the system, service
        /// provider, and group levels that support device management.
        /// The response is either GroupFlexibleSeatingAccessDeviceGetListResponse or
        /// ErrorResponse.
        /// </summary>
        public static async Task<GroupFlexibleSeatingAccessDeviceGetListResponse> GroupFlexibleSeatingAccessDeviceGetListRequest(this OcipClient client, GroupFlexibleSeatingAccessDeviceGetListRequest request)
        {
            return await client.Call(request) as GroupFlexibleSeatingAccessDeviceGetListResponse;
        }

        /// <summary>
        /// Add a flexible seating host instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFlexibleSeatingHostAddInstanceRequest(this OcipClient client, GroupFlexibleSeatingHostAddInstanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a flexible seating host instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFlexibleSeatingHostAddInstanceRequest22(this OcipClient client, GroupFlexibleSeatingHostAddInstanceRequest22 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a flexible seating host instance from a group. Host cannot be deleted when a guest is associated to a host.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFlexibleSeatingHostDeleteInstanceRequest(this OcipClient client, GroupFlexibleSeatingHostDeleteInstanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of flexible seating host instances within a group.
        /// The response is either GroupFlexibleSeatingHostGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        public static async Task<GroupFlexibleSeatingHostGetInstanceListResponse> GroupFlexibleSeatingHostGetInstanceListRequest(this OcipClient client, GroupFlexibleSeatingHostGetInstanceListRequest request)
        {
            return await client.Call(request) as GroupFlexibleSeatingHostGetInstanceListResponse;
        }

        /// <summary>
        /// Request to get all the information of a flexible seating host instance.
        /// The response is either GroupFlexibleSeatingHostGetInstanceResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupFlexibleSeatingHostGetInstanceResponse> GroupFlexibleSeatingHostGetInstanceRequest(this OcipClient client, GroupFlexibleSeatingHostGetInstanceRequest request)
        {
            return await client.Call(request) as GroupFlexibleSeatingHostGetInstanceResponse;
        }

        /// <summary>
        /// Request to get all the information of a flexible seating host instance.
        /// The response is either GroupFlexibleSeatingHostGetInstanceResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<GroupFlexibleSeatingHostGetInstanceResponse22> GroupFlexibleSeatingHostGetInstanceRequest22(this OcipClient client, GroupFlexibleSeatingHostGetInstanceRequest22 request)
        {
            return await client.Call(request) as GroupFlexibleSeatingHostGetInstanceResponse22;
        }

        /// <summary>
        /// Request the flexible seating host guest association details.
        /// The response is either a GroupFlexibleSeatingHostGuestAssociationGetResponse or an ErrorResponse.
        /// accessLevel is always set to Group for a Service Provider
        /// </summary>
        public static async Task<GroupFlexibleSeatingHostGuestAssociationGetResponse> GroupFlexibleSeatingHostGuestAssociationGetRequest(this OcipClient client, GroupFlexibleSeatingHostGuestAssociationGetRequest request)
        {
            return await client.Call(request) as GroupFlexibleSeatingHostGuestAssociationGetResponse;
        }

        /// <summary>
        /// Modify the flexible seating host’s guest association attributes.
        /// The request fails if enforceAssociationLimit or associationLimitHours are changed when the host is associated to a guest.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFlexibleSeatingHostGuestAssociationModifyRequest(this OcipClient client, GroupFlexibleSeatingHostGuestAssociationModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to set the active status of flexible seating host instances. Host cannot be disabled when a flexible seating guest is associated.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFlexibleSeatingHostModifyActiveInstanceListRequest(this OcipClient client, GroupFlexibleSeatingHostModifyActiveInstanceListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a flexible seating host instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFlexibleSeatingHostModifyInstanceRequest(this OcipClient client, GroupFlexibleSeatingHostModifyInstanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a flexible seating host instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFlexibleSeatingHostModifyInstanceRequest22(this OcipClient client, GroupFlexibleSeatingHostModifyInstanceRequest22 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a flexible seating host’s routing policies
        /// The response is either a GroupFlexibleSeatingHostRoutingPoliciesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupFlexibleSeatingHostRoutingPoliciesGetResponse> GroupFlexibleSeatingHostRoutingPoliciesGetRequest(this OcipClient client, GroupFlexibleSeatingHostRoutingPoliciesGetRequest request)
        {
            return await client.Call(request) as GroupFlexibleSeatingHostRoutingPoliciesGetResponse;
        }

        /// <summary>
        /// Modify a flexible seating host’s routing policies
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFlexibleSeatingHostRoutingPoliciesModifyRequest(this OcipClient client, GroupFlexibleSeatingHostRoutingPoliciesModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of hosts that can be assigned to flexible seating guests.
        /// The response is either UserFlexibleSeatingGuestGetAvailableHostListResponse or ErrorResponse. The response will include active hosts based on the following criteria.
        /// - host that has the equivalent device type as the guest, host already assigned to another guest and for a guest in a Service Provider host in the user’s group and for a user in an Enterprise a host within the user’s group and host in the user’s enterprise that has the accessLevel set to Enterprise.
        /// </summary>
        public static async Task<UserFlexibleSeatingGuestGetAvailableHostListResponse> UserFlexibleSeatingGuestGetAvailableHostListRequest(this OcipClient client, UserFlexibleSeatingGuestGetAvailableHostListRequest request)
        {
            return await client.Call(request) as UserFlexibleSeatingGuestGetAvailableHostListResponse;
        }

        /// <summary>
        /// Request the user level data associated with flexible seating guest.
        /// The response is either a UserFlexibleSeatingGuestGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserFlexibleSeatingGuestGetResponse> UserFlexibleSeatingGuestGetRequest(this OcipClient client, UserFlexibleSeatingGuestGetRequest request)
        {
            return await client.Call(request) as UserFlexibleSeatingGuestGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with flexible seating guest.
        /// accessDeviceEndpoint can only be configured by group or a higher level administrator.
        /// The request fails if isActive is set to false and the guest is associated to a host.
        /// The request fails when enableAssociationLimit, associationLimitHours, unlockPhonePINCode are changed when the guest is associated to a host.
        /// The request fails when accessDeviceEndpoint is set in the request when the guest is associated to a host.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserFlexibleSeatingGuestModifyRequest(this OcipClient client, UserFlexibleSeatingGuestModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user level data associated with flexible seating guest.
        /// The response is either a UserFlexibleSeatingGuestGetResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<UserFlexibleSeatingGuestGetResponse22> UserFlexibleSeatingGuestGetRequest22(this OcipClient client, UserFlexibleSeatingGuestGetRequest22 request)
        {
            return await client.Call(request) as UserFlexibleSeatingGuestGetResponse22;
        }

        /// <summary>
        /// Modify the user level data associated with flexible seating guest.
        /// accessDeviceEndpoint can only be configured by group or a higher level administrator.
        /// The request fails if isActive is set to false and the guest is associated to a host.
        /// The request fails when enableAssociationLimit, associationLimitHours, unlockPhonePINCode are changed when the guest is associated to a host.
        /// The request fails when accessDeviceEndpoint is set in the request when the guest is associated to a host.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserFlexibleSeatingGuestModifyRequest22(this OcipClient client, UserFlexibleSeatingGuestModifyRequest22 request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
