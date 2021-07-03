using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaResellerExtensions
    {

        /// <summary>
        /// Add a reseller.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerAddRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerAddRequest(this OcipClient client, ResellerAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a reseller.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerAddRequestAsync(this OcipClient client, ResellerAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a reseller administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerAdminAddRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerAdminAddRequest(this OcipClient client, ResellerAdminAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a reseller administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerAdminAddRequestAsync(this OcipClient client, ResellerAdminAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add an alternate Id to a reseller admin.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerAdminAlternateIdAddRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerAdminAlternateIdAddRequest(this OcipClient client, ResellerAdminAlternateIdAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add an alternate Id to a reseller admin.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerAdminAlternateIdAddRequestAsync(this OcipClient client, ResellerAdminAlternateIdAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete an alternate admin user id of a reseller admin.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerAdminAlternateIdDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerAdminAlternateIdDeleteRequest(this OcipClient client, ResellerAdminAlternateIdDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete an alternate admin user id of a reseller admin.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerAdminAlternateIdDeleteRequestAsync(this OcipClient client, ResellerAdminAlternateIdDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the admin id and the list of alternate admin ids of an admin.
        /// The response is either ResellerAdminAlternateIdGetListResponse or ErrorResponse.
        /// The "userId" can be either the admin user Id or an alternate admin user Id.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerAdminAlternateIdGetListRequestAsync instead.")]
        public static async Task<ResellerAdminAlternateIdGetListResponse> ResellerAdminAlternateIdGetListRequest(this OcipClient client, ResellerAdminAlternateIdGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerAdminAlternateIdGetListResponse;
        }

        /// <summary>
        /// Request to get the admin id and the list of alternate admin ids of an admin.
        /// The response is either ResellerAdminAlternateIdGetListResponse or ErrorResponse.
        /// The "userId" can be either the admin user Id or an alternate admin user Id.
        /// </summary>
        public static async Task<ResellerAdminAlternateIdGetListResponse> ResellerAdminAlternateIdGetListRequestAsync(this OcipClient client, ResellerAdminAlternateIdGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerAdminAlternateIdGetListResponse;
        }
        /// <summary>
        /// Request to modify an alternate id of a reseller admin.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerAdminAlternateIdModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerAdminAlternateIdModifyRequest(this OcipClient client, ResellerAdminAlternateIdModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an alternate id of a reseller admin.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerAdminAlternateIdModifyRequestAsync(this OcipClient client, ResellerAdminAlternateIdModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a reseller administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerAdminDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerAdminDeleteRequest(this OcipClient client, ResellerAdminDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a reseller administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerAdminDeleteRequestAsync(this OcipClient client, ResellerAdminDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of reseller administrators.
        /// The response is either a ResellerAdminGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerAdminGetListRequestAsync instead.")]
        public static async Task<ResellerAdminGetListResponse> ResellerAdminGetListRequest(this OcipClient client, ResellerAdminGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerAdminGetListResponse;
        }

        /// <summary>
        /// Get a list of reseller administrators.
        /// The response is either a ResellerAdminGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerAdminGetListResponse> ResellerAdminGetListRequestAsync(this OcipClient client, ResellerAdminGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerAdminGetListResponse;
        }
        /// <summary>
        /// Get a reseller administrators profile.
        /// The response is either a ResellerAdminGetResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerAdminGetRequest22Async instead.")]
        public static async Task<ResellerAdminGetResponse22> ResellerAdminGetRequest22(this OcipClient client, ResellerAdminGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerAdminGetResponse22;
        }

        /// <summary>
        /// Get a reseller administrators profile.
        /// The response is either a ResellerAdminGetResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerAdminGetResponse22> ResellerAdminGetRequest22Async(this OcipClient client, ResellerAdminGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerAdminGetResponse22;
        }
        /// <summary>
        /// Modify the profile for a reseller administrator.
        /// Since old password is not specified here, any password rule related to old password does not apply.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerAdminModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerAdminModifyRequest(this OcipClient client, ResellerAdminModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the profile for a reseller administrator.
        /// Since old password is not specified here, any password rule related to old password does not apply.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerAdminModifyRequestAsync(this OcipClient client, ResellerAdminModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a reseller call admission control policies.
        /// The response is either a ResellerCallAdmissionControlPoliciesGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerCallAdmissionControlPoliciesGetRequestAsync instead.")]
        public static async Task<ResellerCallAdmissionControlPoliciesGetResponse> ResellerCallAdmissionControlPoliciesGetRequest(this OcipClient client, ResellerCallAdmissionControlPoliciesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerCallAdmissionControlPoliciesGetResponse;
        }

        /// <summary>
        /// Get a reseller call admission control policies.
        /// The response is either a ResellerCallAdmissionControlPoliciesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerCallAdmissionControlPoliciesGetResponse> ResellerCallAdmissionControlPoliciesGetRequestAsync(this OcipClient client, ResellerCallAdmissionControlPoliciesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerCallAdmissionControlPoliciesGetResponse;
        }
        /// <summary>
        /// Modify the reseller call admission control policies.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerCallAdmissionControlPoliciesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerCallAdmissionControlPoliciesModifyRequest(this OcipClient client, ResellerCallAdmissionControlPoliciesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the reseller call admission control policies.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerCallAdmissionControlPoliciesModifyRequestAsync(this OcipClient client, ResellerCallAdmissionControlPoliciesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the reseller level data associated with Call Policies.
        /// The response is either a ResellerCallPoliciesGetResponse22
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerCallPoliciesGetRequest22Async instead.")]
        public static async Task<ResellerCallPoliciesGetResponse22> ResellerCallPoliciesGetRequest22(this OcipClient client, ResellerCallPoliciesGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerCallPoliciesGetResponse22;
        }

        /// <summary>
        /// Request the reseller level data associated with Call Policies.
        /// The response is either a ResellerCallPoliciesGetResponse22
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerCallPoliciesGetResponse22> ResellerCallPoliciesGetRequest22Async(this OcipClient client, ResellerCallPoliciesGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerCallPoliciesGetResponse22;
        }
        /// <summary>
        /// Modify the reseller level data associated with Call Policies.
        /// The following elements are only used in AS data mode:
        /// forceRedirectingUserIdentityForRedirectedCalls
        /// applyRedirectingUserIdentityToNetworkLocations
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerCallPoliciesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerCallPoliciesModifyRequest(this OcipClient client, ResellerCallPoliciesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the reseller level data associated with Call Policies.
        /// The following elements are only used in AS data mode:
        /// forceRedirectingUserIdentityForRedirectedCalls
        /// applyRedirectingUserIdentityToNetworkLocations
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerCallPoliciesModifyRequestAsync(this OcipClient client, ResellerCallPoliciesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a reseller.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerDeleteRequest(this OcipClient client, ResellerDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a reseller.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerDeleteRequestAsync(this OcipClient client, ResellerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the Device Activation policy of a reseller.
        /// The response is either a ResellerDeviceActivationPolicyGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerDeviceActivationPolicyGetRequestAsync instead.")]
        public static async Task<ResellerDeviceActivationPolicyGetResponse> ResellerDeviceActivationPolicyGetRequest(this OcipClient client, ResellerDeviceActivationPolicyGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerDeviceActivationPolicyGetResponse;
        }

        /// <summary>
        /// Request the Device Activation policy of a reseller.
        /// The response is either a ResellerDeviceActivationPolicyGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerDeviceActivationPolicyGetResponse> ResellerDeviceActivationPolicyGetRequestAsync(this OcipClient client, ResellerDeviceActivationPolicyGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerDeviceActivationPolicyGetResponse;
        }
        /// <summary>
        /// Modify the Device Activation policy of a reseller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerDeviceActivationPolicyModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerDeviceActivationPolicyModifyRequest(this OcipClient client, ResellerDeviceActivationPolicyModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Device Activation policy of a reseller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerDeviceActivationPolicyModifyRequestAsync(this OcipClient client, ResellerDeviceActivationPolicyModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the reseller level data associated with Emergency Call
        /// Notification.
        /// The response is either a ResellerEmergencyCallNotificationGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerEmergencyCallNotificationGetRequestAsync instead.")]
        public static async Task<ResellerEmergencyCallNotificationGetResponse> ResellerEmergencyCallNotificationGetRequest(this OcipClient client, ResellerEmergencyCallNotificationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerEmergencyCallNotificationGetResponse;
        }

        /// <summary>
        /// Request the reseller level data associated with Emergency Call
        /// Notification.
        /// The response is either a ResellerEmergencyCallNotificationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerEmergencyCallNotificationGetResponse> ResellerEmergencyCallNotificationGetRequestAsync(this OcipClient client, ResellerEmergencyCallNotificationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerEmergencyCallNotificationGetResponse;
        }
        /// <summary>
        /// Modify the reseller level data associated with Emergency Call
        /// Notification.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerEmergencyCallNotificationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerEmergencyCallNotificationModifyRequest(this OcipClient client, ResellerEmergencyCallNotificationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the reseller level data associated with Emergency Call
        /// Notification.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerEmergencyCallNotificationModifyRequestAsync(this OcipClient client, ResellerEmergencyCallNotificationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a list of resellers in the system.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a ResellerGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerGetListRequestAsync instead.")]
        public static async Task<ResellerGetListResponse> ResellerGetListRequest(this OcipClient client, ResellerGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerGetListResponse;
        }

        /// <summary>
        /// Request a list of resellers in the system.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a ResellerGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerGetListResponse> ResellerGetListRequestAsync(this OcipClient client, ResellerGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerGetListResponse;
        }
        /// <summary>
        /// Get the profile for a reseller.
        /// The response is either ResellerGetResponse22V2 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerGetRequest22V2Async instead.")]
        public static async Task<ResellerGetResponse22V2> ResellerGetRequest22V2(this OcipClient client, ResellerGetRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerGetResponse22V2;
        }

        /// <summary>
        /// Get the profile for a reseller.
        /// The response is either ResellerGetResponse22V2 or ErrorResponse.
        /// </summary>
        public static async Task<ResellerGetResponse22V2> ResellerGetRequest22V2Async(this OcipClient client, ResellerGetRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerGetResponse22V2;
        }
        /// <summary>
        /// Request the reseller Mail parameters.
        /// The response is either a ResellerMailParametersGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerMailParametersGetRequestAsync instead.")]
        public static async Task<ResellerMailParametersGetResponse> ResellerMailParametersGetRequest(this OcipClient client, ResellerMailParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerMailParametersGetResponse;
        }

        /// <summary>
        /// Request the reseller Mail parameters.
        /// The response is either a ResellerMailParametersGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerMailParametersGetResponse> ResellerMailParametersGetRequestAsync(this OcipClient client, ResellerMailParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerMailParametersGetResponse;
        }
        /// <summary>
        /// Request to modify the reseller Mail parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerMailParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerMailParametersModifyRequest(this OcipClient client, ResellerMailParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the reseller Mail parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerMailParametersModifyRequestAsync(this OcipClient client, ResellerMailParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the reseller profile.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerModifyRequest(this OcipClient client, ResellerModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the reseller profile.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerModifyRequestAsync(this OcipClient client, ResellerModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a list of Network Classes of Service to a reseller.
        /// A default Network Class of Service is optional.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerNetworkClassOfServiceAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerNetworkClassOfServiceAssignListRequest(this OcipClient client, ResellerNetworkClassOfServiceAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Network Classes of Service to a reseller.
        /// A default Network Class of Service is optional.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerNetworkClassOfServiceAssignListRequestAsync(this OcipClient client, ResellerNetworkClassOfServiceAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Network Classes of Service assigned to a reseller.
        /// The response is either a ResellerNetworkClassOfServiceGetAssignedListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerNetworkClassOfServiceGetAssignedListRequestAsync instead.")]
        public static async Task<ResellerNetworkClassOfServiceGetAssignedListResponse> ResellerNetworkClassOfServiceGetAssignedListRequest(this OcipClient client, ResellerNetworkClassOfServiceGetAssignedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerNetworkClassOfServiceGetAssignedListResponse;
        }

        /// <summary>
        /// Get a list of Network Classes of Service assigned to a reseller.
        /// The response is either a ResellerNetworkClassOfServiceGetAssignedListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerNetworkClassOfServiceGetAssignedListResponse> ResellerNetworkClassOfServiceGetAssignedListRequestAsync(this OcipClient client, ResellerNetworkClassOfServiceGetAssignedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerNetworkClassOfServiceGetAssignedListResponse;
        }
        /// <summary>
        /// Get a list of service provider/enterprises within a reseller that have a given
        /// Network Class of Service assigned.
        /// The response is either a ResellerNetworkClassOfServiceGetAssignedServiceProviderListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerNetworkClassOfServiceGetAssignedServiceProviderListRequestAsync instead.")]
        public static async Task<ResellerNetworkClassOfServiceGetAssignedServiceProviderListResponse> ResellerNetworkClassOfServiceGetAssignedServiceProviderListRequest(this OcipClient client, ResellerNetworkClassOfServiceGetAssignedServiceProviderListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerNetworkClassOfServiceGetAssignedServiceProviderListResponse;
        }

        /// <summary>
        /// Get a list of service provider/enterprises within a reseller that have a given
        /// Network Class of Service assigned.
        /// The response is either a ResellerNetworkClassOfServiceGetAssignedServiceProviderListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerNetworkClassOfServiceGetAssignedServiceProviderListResponse> ResellerNetworkClassOfServiceGetAssignedServiceProviderListRequestAsync(this OcipClient client, ResellerNetworkClassOfServiceGetAssignedServiceProviderListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerNetworkClassOfServiceGetAssignedServiceProviderListResponse;
        }
        /// <summary>
        /// Modifies the default Network Classes of Service of a reseller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerNetworkClassOfServiceModifyDefaultRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerNetworkClassOfServiceModifyDefaultRequest(this OcipClient client, ResellerNetworkClassOfServiceModifyDefaultRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the default Network Classes of Service of a reseller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerNetworkClassOfServiceModifyDefaultRequestAsync(this OcipClient client, ResellerNetworkClassOfServiceModifyDefaultRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Unassign a list of Network Classes of Service from a reseller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerNetworkClassOfServiceUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerNetworkClassOfServiceUnassignListRequest(this OcipClient client, ResellerNetworkClassOfServiceUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of Network Classes of Service from a reseller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerNetworkClassOfServiceUnassignListRequestAsync(this OcipClient client, ResellerNetworkClassOfServiceUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the reseller service authorization
        /// The response is either ResellerServiceAuthorizationGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerServiceAuthorizationGetRequestAsync instead.")]
        public static async Task<ResellerServiceAuthorizationGetResponse> ResellerServiceAuthorizationGetRequest(this OcipClient client, ResellerServiceAuthorizationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerServiceAuthorizationGetResponse;
        }

        /// <summary>
        /// Get the reseller service authorization
        /// The response is either ResellerServiceAuthorizationGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ResellerServiceAuthorizationGetResponse> ResellerServiceAuthorizationGetRequestAsync(this OcipClient client, ResellerServiceAuthorizationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerServiceAuthorizationGetResponse;
        }
        /// <summary>
        /// Modify the reseller service authorization file.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerServiceAuthorizationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerServiceAuthorizationModifyRequest(this OcipClient client, ResellerServiceAuthorizationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the reseller service authorization file.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerServiceAuthorizationModifyRequestAsync(this OcipClient client, ResellerServiceAuthorizationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get Reseller Stir Shaken service settings.
        /// The response is either ResellerStirShakenGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerStirShakenGetRequestAsync instead.")]
        public static async Task<ResellerStirShakenGetResponse> ResellerStirShakenGetRequest(this OcipClient client, ResellerStirShakenGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerStirShakenGetResponse;
        }

        /// <summary>
        /// Get Reseller Stir Shaken service settings.
        /// The response is either ResellerStirShakenGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ResellerStirShakenGetResponse> ResellerStirShakenGetRequestAsync(this OcipClient client, ResellerStirShakenGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerStirShakenGetResponse;
        }
        /// <summary>
        /// Modify reseller Stir Shaken service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerStirShakenModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerStirShakenModifyRequest(this OcipClient client, ResellerStirShakenModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify reseller Stir Shaken service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerStirShakenModifyRequestAsync(this OcipClient client, ResellerStirShakenModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a list of Xsi policy profile to a reseller.
        /// It contains the service provider, group, user level Xsi policy profile.
        /// Each level has one default Xsi policy profile assigned.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerXsiPolicyProfileAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerXsiPolicyProfileAssignListRequest(this OcipClient client, ResellerXsiPolicyProfileAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Xsi policy profile to a reseller.
        /// It contains the service provider, group, user level Xsi policy profile.
        /// Each level has one default Xsi policy profile assigned.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerXsiPolicyProfileAssignListRequestAsync(this OcipClient client, ResellerXsiPolicyProfileAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Xsi policy profile assigned.
        /// The response is either a ResellerXsiPolicyProfileGetAssignedListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerXsiPolicyProfileGetAssignedListRequestAsync instead.")]
        public static async Task<ResellerXsiPolicyProfileGetAssignedListResponse> ResellerXsiPolicyProfileGetAssignedListRequest(this OcipClient client, ResellerXsiPolicyProfileGetAssignedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerXsiPolicyProfileGetAssignedListResponse;
        }

        /// <summary>
        /// Get a list of Xsi policy profile assigned.
        /// The response is either a ResellerXsiPolicyProfileGetAssignedListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerXsiPolicyProfileGetAssignedListResponse> ResellerXsiPolicyProfileGetAssignedListRequestAsync(this OcipClient client, ResellerXsiPolicyProfileGetAssignedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerXsiPolicyProfileGetAssignedListResponse;
        }
        /// <summary>
        /// Get a list of service provider/enterprises within a reseller that have a given
        /// Service provider Xsi policy profile assigned.
        /// The response is either a ResellerXsiPolicyProfileGetAssignedServiceProviderListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerXsiPolicyProfileGetAssignedServiceProviderListRequestAsync instead.")]
        public static async Task<ResellerXsiPolicyProfileGetAssignedServiceProviderListResponse> ResellerXsiPolicyProfileGetAssignedServiceProviderListRequest(this OcipClient client, ResellerXsiPolicyProfileGetAssignedServiceProviderListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerXsiPolicyProfileGetAssignedServiceProviderListResponse;
        }

        /// <summary>
        /// Get a list of service provider/enterprises within a reseller that have a given
        /// Service provider Xsi policy profile assigned.
        /// The response is either a ResellerXsiPolicyProfileGetAssignedServiceProviderListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerXsiPolicyProfileGetAssignedServiceProviderListResponse> ResellerXsiPolicyProfileGetAssignedServiceProviderListRequestAsync(this OcipClient client, ResellerXsiPolicyProfileGetAssignedServiceProviderListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerXsiPolicyProfileGetAssignedServiceProviderListResponse;
        }
        /// <summary>
        /// Modifies the default Xsi policy profile for a reseller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerXsiPolicyProfileModifyDefaultRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerXsiPolicyProfileModifyDefaultRequest(this OcipClient client, ResellerXsiPolicyProfileModifyDefaultRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the default Xsi policy profile for a reseller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerXsiPolicyProfileModifyDefaultRequestAsync(this OcipClient client, ResellerXsiPolicyProfileModifyDefaultRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Unassign a list of Xsi policy profile.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerXsiPolicyProfileUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerXsiPolicyProfileUnassignListRequest(this OcipClient client, ResellerXsiPolicyProfileUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of Xsi policy profile.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerXsiPolicyProfileUnassignListRequestAsync(this OcipClient client, ResellerXsiPolicyProfileUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
