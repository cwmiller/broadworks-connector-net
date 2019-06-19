using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaResellerExtensions
    {

        /// <summary>
        /// Add a reseller.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerAddRequest(this OcipClient client, ResellerAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a reseller administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerAdminAddRequest(this OcipClient client, ResellerAdminAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a reseller administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerAdminDeleteRequest(this OcipClient client, ResellerAdminDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of reseller administrators.
        /// The response is either a ResellerAdminGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerAdminGetListResponse> ResellerAdminGetListRequest(this OcipClient client, ResellerAdminGetListRequest request)
        {
            return await client.Call(request) as ResellerAdminGetListResponse;
        }

        /// <summary>
        /// Get a reseller administrators profile.
        /// The response is either a ResellerAdminGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerAdminGetResponse> ResellerAdminGetRequest(this OcipClient client, ResellerAdminGetRequest request)
        {
            return await client.Call(request) as ResellerAdminGetResponse;
        }

        /// <summary>
        /// Modify the profile for a reseller administrator.
        /// Since old password is not specified here, any password rule related to old password does not apply.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerAdminModifyRequest(this OcipClient client, ResellerAdminModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a reseller call admission control policies.
        /// The response is either a ResellerCallAdmissionControlPoliciesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerCallAdmissionControlPoliciesGetResponse> ResellerCallAdmissionControlPoliciesGetRequest(this OcipClient client, ResellerCallAdmissionControlPoliciesGetRequest request)
        {
            return await client.Call(request) as ResellerCallAdmissionControlPoliciesGetResponse;
        }

        /// <summary>
        /// Modify the reseller call admission control policies.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerCallAdmissionControlPoliciesModifyRequest(this OcipClient client, ResellerCallAdmissionControlPoliciesModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a reseller.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerDeleteRequest(this OcipClient client, ResellerDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the reseller level data associated with Emergency Call
        /// Notification.
        /// The response is either a ResellerEmergencyCallNotificationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerEmergencyCallNotificationGetResponse> ResellerEmergencyCallNotificationGetRequest(this OcipClient client, ResellerEmergencyCallNotificationGetRequest request)
        {
            return await client.Call(request) as ResellerEmergencyCallNotificationGetResponse;
        }

        /// <summary>
        /// Modify the reseller level data associated with Emergency Call
        /// Notification.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerEmergencyCallNotificationModifyRequest(this OcipClient client, ResellerEmergencyCallNotificationModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request a list of resellers in the system.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a ResellerGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerGetListResponse> ResellerGetListRequest(this OcipClient client, ResellerGetListRequest request)
        {
            return await client.Call(request) as ResellerGetListResponse;
        }

        /// <summary>
        /// Get the profile for a reseller.
        /// The response is either ResellerGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ResellerGetResponse> ResellerGetRequest(this OcipClient client, ResellerGetRequest request)
        {
            return await client.Call(request) as ResellerGetResponse;
        }

        /// <summary>
        /// Request the reseller Mail parameters.
        /// The response is either a ResellerMailParametersGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<ResellerMailParametersGetResponse> ResellerMailParametersGetRequest(this OcipClient client, ResellerMailParametersGetRequest request)
        {
            return await client.Call(request) as ResellerMailParametersGetResponse;
        }

        /// <summary>
        /// Request to modify the reseller Mail parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerMailParametersModifyRequest(this OcipClient client, ResellerMailParametersModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the reseller profile.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerModifyRequest(this OcipClient client, ResellerModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Network Classes of Service to a reseller.
        /// A default Network Class of Service is optional.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerNetworkClassOfServiceAssignListRequest(this OcipClient client, ResellerNetworkClassOfServiceAssignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of Network Classes of Service assigned to a reseller.
        /// The response is either a ResellerNetworkClassOfServiceGetAssignedListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerNetworkClassOfServiceGetAssignedListResponse> ResellerNetworkClassOfServiceGetAssignedListRequest(this OcipClient client, ResellerNetworkClassOfServiceGetAssignedListRequest request)
        {
            return await client.Call(request) as ResellerNetworkClassOfServiceGetAssignedListResponse;
        }

        /// <summary>
        /// Get a list of service provider/enterprises within a reseller that have a given
        /// Network Class of Service assigned.
        /// The response is either a ResellerNetworkClassOfServiceGetAssignedServiceProviderListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerNetworkClassOfServiceGetAssignedServiceProviderListResponse> ResellerNetworkClassOfServiceGetAssignedServiceProviderListRequest(this OcipClient client, ResellerNetworkClassOfServiceGetAssignedServiceProviderListRequest request)
        {
            return await client.Call(request) as ResellerNetworkClassOfServiceGetAssignedServiceProviderListResponse;
        }

        /// <summary>
        /// Modifies the default Network Classes of Service of a reseller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerNetworkClassOfServiceModifyDefaultRequest(this OcipClient client, ResellerNetworkClassOfServiceModifyDefaultRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of Network Classes of Service from a reseller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerNetworkClassOfServiceUnassignListRequest(this OcipClient client, ResellerNetworkClassOfServiceUnassignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the reseller service authorization
        /// The response is either ResellerServiceAuthorizationGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ResellerServiceAuthorizationGetResponse> ResellerServiceAuthorizationGetRequest(this OcipClient client, ResellerServiceAuthorizationGetRequest request)
        {
            return await client.Call(request) as ResellerServiceAuthorizationGetResponse;
        }

        /// <summary>
        /// Modify the reseller service authorization file.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerServiceAuthorizationModifyRequest(this OcipClient client, ResellerServiceAuthorizationModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
