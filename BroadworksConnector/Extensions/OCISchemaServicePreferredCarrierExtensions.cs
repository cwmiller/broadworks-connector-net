using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServicePreferredCarrierExtensions
    {

        /// <summary>
        /// Requests the currently configured carriers for a group.
        /// The response is either a GroupPreferredCarrierGroupGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPreferredCarrierGroupGetRequestAsync instead.")]
        public static async Task<GroupPreferredCarrierGroupGetResponse> GroupPreferredCarrierGroupGetRequest(this OcipClient client, GroupPreferredCarrierGroupGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupPreferredCarrierGroupGetResponse;
        }

        /// <summary>
        /// Requests the currently configured carriers for a group.
        /// The response is either a GroupPreferredCarrierGroupGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupPreferredCarrierGroupGetResponse> GroupPreferredCarrierGroupGetRequestAsync(this OcipClient client, GroupPreferredCarrierGroupGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupPreferredCarrierGroupGetResponse;
        }
        /// <summary>
        /// Modifies the currently configured carriers for a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPreferredCarrierGroupModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupPreferredCarrierGroupModifyRequest(this OcipClient client, GroupPreferredCarrierGroupModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the currently configured carriers for a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupPreferredCarrierGroupModifyRequestAsync(this OcipClient client, GroupPreferredCarrierGroupModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add the country code preferred carriers for a service provider or enterprise. For each
        /// combination of service provider and country code, you can assign an intra-lata, inter-lata,
        /// and international carrier. Each of the three types of carriers is optional.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Note: At the system level, more than one carrier may be assigned to each country code.
        /// At the service provider level, you must choose from the carriers assigned at the system level.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderPreferredCarrierAddRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderPreferredCarrierAddRequest(this OcipClient client, ServiceProviderPreferredCarrierAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add the country code preferred carriers for a service provider or enterprise. For each
        /// combination of service provider and country code, you can assign an intra-lata, inter-lata,
        /// and international carrier. Each of the three types of carriers is optional.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Note: At the system level, more than one carrier may be assigned to each country code.
        /// At the service provider level, you must choose from the carriers assigned at the system level.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderPreferredCarrierAddRequestAsync(this OcipClient client, ServiceProviderPreferredCarrierAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete the country code preferred carriers for a service provider or enterprise.
        /// Note that this is different from unassigning all 3 types of carriers with
        /// the ServiceProviderPreferredCarrierModifyRequest.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// An ErrorResponse will be returned if the country code preferred carriers were never added or
        /// were already deleted.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderPreferredCarrierDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderPreferredCarrierDeleteRequest(this OcipClient client, ServiceProviderPreferredCarrierDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete the country code preferred carriers for a service provider or enterprise.
        /// Note that this is different from unassigning all 3 types of carriers with
        /// the ServiceProviderPreferredCarrierModifyRequest.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// An ErrorResponse will be returned if the country code preferred carriers were never added or
        /// were already deleted.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderPreferredCarrierDeleteRequestAsync(this OcipClient client, ServiceProviderPreferredCarrierDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the default country code and the list of unused country codes for a service provider / enterprise.
        /// The response is either a ServiceProviderPreferredCarrierGetAvailableCountryCodeListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderPreferredCarrierGetAvailableCountryCodeListRequestAsync instead.")]
        public static async Task<ServiceProviderPreferredCarrierGetAvailableCountryCodeListResponse> ServiceProviderPreferredCarrierGetAvailableCountryCodeListRequest(this OcipClient client, ServiceProviderPreferredCarrierGetAvailableCountryCodeListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderPreferredCarrierGetAvailableCountryCodeListResponse;
        }

        /// <summary>
        /// Requests the default country code and the list of unused country codes for a service provider / enterprise.
        /// The response is either a ServiceProviderPreferredCarrierGetAvailableCountryCodeListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderPreferredCarrierGetAvailableCountryCodeListResponse> ServiceProviderPreferredCarrierGetAvailableCountryCodeListRequestAsync(this OcipClient client, ServiceProviderPreferredCarrierGetAvailableCountryCodeListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderPreferredCarrierGetAvailableCountryCodeListResponse;
        }
        /// <summary>
        /// Requests the lists of carriers for a specified country code for a service provider / enterprise.
        /// The response is either a ServiceProviderPreferredCarrierGetCarrierListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderPreferredCarrierGetCarrierListRequestAsync instead.")]
        public static async Task<ServiceProviderPreferredCarrierGetCarrierListResponse> ServiceProviderPreferredCarrierGetCarrierListRequest(this OcipClient client, ServiceProviderPreferredCarrierGetCarrierListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderPreferredCarrierGetCarrierListResponse;
        }

        /// <summary>
        /// Requests the lists of carriers for a specified country code for a service provider / enterprise.
        /// The response is either a ServiceProviderPreferredCarrierGetCarrierListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderPreferredCarrierGetCarrierListResponse> ServiceProviderPreferredCarrierGetCarrierListRequestAsync(this OcipClient client, ServiceProviderPreferredCarrierGetCarrierListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderPreferredCarrierGetCarrierListResponse;
        }
        /// <summary>
        /// Requests a table of all the carriers defined in a specified service provider or enterprise.
        /// The response is either a ServiceProviderPreferredCarrierGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderPreferredCarrierGetListRequestAsync instead.")]
        public static async Task<ServiceProviderPreferredCarrierGetListResponse> ServiceProviderPreferredCarrierGetListRequest(this OcipClient client, ServiceProviderPreferredCarrierGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderPreferredCarrierGetListResponse;
        }

        /// <summary>
        /// Requests a table of all the carriers defined in a specified service provider or enterprise.
        /// The response is either a ServiceProviderPreferredCarrierGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderPreferredCarrierGetListResponse> ServiceProviderPreferredCarrierGetListRequestAsync(this OcipClient client, ServiceProviderPreferredCarrierGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderPreferredCarrierGetListResponse;
        }
        /// <summary>
        /// Requests the currently configured carriers for a specified country code for a service provider / enterprise.
        /// The response is either a ServiceProviderPreferredCarrierGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderPreferredCarrierGetRequestAsync instead.")]
        public static async Task<ServiceProviderPreferredCarrierGetResponse> ServiceProviderPreferredCarrierGetRequest(this OcipClient client, ServiceProviderPreferredCarrierGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderPreferredCarrierGetResponse;
        }

        /// <summary>
        /// Requests the currently configured carriers for a specified country code for a service provider / enterprise.
        /// The response is either a ServiceProviderPreferredCarrierGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderPreferredCarrierGetResponse> ServiceProviderPreferredCarrierGetRequestAsync(this OcipClient client, ServiceProviderPreferredCarrierGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderPreferredCarrierGetResponse;
        }
        /// <summary>
        /// Modify the country code preferred carriers for a service provider or enterprise. For each
        /// combination of service provider and country code, you can assign an intra-lata, inter-lata,
        /// and international carrier. Each of the 3 types of carriers is optional.
        /// If an optional carrier is not specified, the assignment will not change.
        /// To clear a preferred carrier, set the value to an empty string.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Note: At the system level, more than one carrier may be assigned to each country code.
        /// At the service provider level, you must choose from the carriers assigned at the system level.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderPreferredCarrierModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderPreferredCarrierModifyRequest(this OcipClient client, ServiceProviderPreferredCarrierModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the country code preferred carriers for a service provider or enterprise. For each
        /// combination of service provider and country code, you can assign an intra-lata, inter-lata,
        /// and international carrier. Each of the 3 types of carriers is optional.
        /// If an optional carrier is not specified, the assignment will not change.
        /// To clear a preferred carrier, set the value to an empty string.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Note: At the system level, more than one carrier may be assigned to each country code.
        /// At the service provider level, you must choose from the carriers assigned at the system level.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderPreferredCarrierModifyRequestAsync(this OcipClient client, ServiceProviderPreferredCarrierModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a carrier to the system.
        /// More than one carrier may be assigned to each country code.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPreferredCarrierAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPreferredCarrierAddRequest(this OcipClient client, SystemPreferredCarrierAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a carrier to the system.
        /// More than one carrier may be assigned to each country code.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPreferredCarrierAddRequestAsync(this OcipClient client, SystemPreferredCarrierAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a carrier from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// An ErrorResponse is returned if the carrier is in use, or if the carrier didn't exist prior to deletion..
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPreferredCarrierDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPreferredCarrierDeleteRequest(this OcipClient client, SystemPreferredCarrierDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a carrier from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// An ErrorResponse is returned if the carrier is in use, or if the carrier didn't exist prior to deletion..
        /// </summary>
        public static async Task<SuccessResponse> SystemPreferredCarrierDeleteRequestAsync(this OcipClient client, SystemPreferredCarrierDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a list of groups using the specified carrier.  It is possible to restrict the
        /// number of rows returned by specifying various search criteria. Multiple search criteria
        /// are logically ANDed together.
        /// The response is either a SystemPreferredCarrierGetGroupListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPreferredCarrierGetGroupListRequestAsync instead.")]
        public static async Task<SystemPreferredCarrierGetGroupListResponse> SystemPreferredCarrierGetGroupListRequest(this OcipClient client, SystemPreferredCarrierGetGroupListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPreferredCarrierGetGroupListResponse;
        }

        /// <summary>
        /// Requests a list of groups using the specified carrier.  It is possible to restrict the
        /// number of rows returned by specifying various search criteria. Multiple search criteria
        /// are logically ANDed together.
        /// The response is either a SystemPreferredCarrierGetGroupListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemPreferredCarrierGetGroupListResponse> SystemPreferredCarrierGetGroupListRequestAsync(this OcipClient client, SystemPreferredCarrierGetGroupListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPreferredCarrierGetGroupListResponse;
        }
        /// <summary>
        /// Requests a table of all the carriers defined in the system.
        /// The response is either a SystemPreferredCarrierGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPreferredCarrierGetListRequestAsync instead.")]
        public static async Task<SystemPreferredCarrierGetListResponse> SystemPreferredCarrierGetListRequest(this OcipClient client, SystemPreferredCarrierGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPreferredCarrierGetListResponse;
        }

        /// <summary>
        /// Requests a table of all the carriers defined in the system.
        /// The response is either a SystemPreferredCarrierGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemPreferredCarrierGetListResponse> SystemPreferredCarrierGetListRequestAsync(this OcipClient client, SystemPreferredCarrierGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPreferredCarrierGetListResponse;
        }
        /// <summary>
        /// Requests the attributes of carrier.
        /// The response is either a SystemPreferredCarrierGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPreferredCarrierGetRequestAsync instead.")]
        public static async Task<SystemPreferredCarrierGetResponse> SystemPreferredCarrierGetRequest(this OcipClient client, SystemPreferredCarrierGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPreferredCarrierGetResponse;
        }

        /// <summary>
        /// Requests the attributes of carrier.
        /// The response is either a SystemPreferredCarrierGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemPreferredCarrierGetResponse> SystemPreferredCarrierGetRequestAsync(this OcipClient client, SystemPreferredCarrierGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPreferredCarrierGetResponse;
        }
        /// <summary>
        /// Requests a list of users using the specified carrier.  It is possible to restrict the
        /// number of rows returned by specifying various search criteria. Multiple search criteria
        /// are logically ANDed together.
        /// The response is either a SystemPreferredCarrierGetUserListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPreferredCarrierGetUserListRequestAsync instead.")]
        public static async Task<SystemPreferredCarrierGetUserListResponse> SystemPreferredCarrierGetUserListRequest(this OcipClient client, SystemPreferredCarrierGetUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPreferredCarrierGetUserListResponse;
        }

        /// <summary>
        /// Requests a list of users using the specified carrier.  It is possible to restrict the
        /// number of rows returned by specifying various search criteria. Multiple search criteria
        /// are logically ANDed together.
        /// The response is either a SystemPreferredCarrierGetUserListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemPreferredCarrierGetUserListResponse> SystemPreferredCarrierGetUserListRequestAsync(this OcipClient client, SystemPreferredCarrierGetUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPreferredCarrierGetUserListResponse;
        }
        /// <summary>
        /// Modify the attributes of a carrier.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// An ErrorResponse is returned if countryCode modification is attempted while the carrier is assigned to a service provider.
        /// An ErrorResponse is returned if an attempt to set isIntraLata to false is made while the carrier is used as an intra-LATA carrier.
        /// An ErrorResponse is returned if an attempt to set isInternational to false is made while the carrier is used as an international carrier.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPreferredCarrierModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPreferredCarrierModifyRequest(this OcipClient client, SystemPreferredCarrierModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the attributes of a carrier.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// An ErrorResponse is returned if countryCode modification is attempted while the carrier is assigned to a service provider.
        /// An ErrorResponse is returned if an attempt to set isIntraLata to false is made while the carrier is used as an intra-LATA carrier.
        /// An ErrorResponse is returned if an attempt to set isInternational to false is made while the carrier is used as an international carrier.
        /// </summary>
        public static async Task<SuccessResponse> SystemPreferredCarrierModifyRequestAsync(this OcipClient client, SystemPreferredCarrierModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the currently configured preferred carriers for a user.
        /// The response is either a UserPreferredCarrierUserGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPreferredCarrierUserGetRequestAsync instead.")]
        public static async Task<UserPreferredCarrierUserGetResponse> UserPreferredCarrierUserGetRequest(this OcipClient client, UserPreferredCarrierUserGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPreferredCarrierUserGetResponse;
        }

        /// <summary>
        /// Requests the currently configured preferred carriers for a user.
        /// The response is either a UserPreferredCarrierUserGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserPreferredCarrierUserGetResponse> UserPreferredCarrierUserGetRequestAsync(this OcipClient client, UserPreferredCarrierUserGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPreferredCarrierUserGetResponse;
        }
        /// <summary>
        /// Modifies the currently configured preferred carriers for a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPreferredCarrierUserModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPreferredCarrierUserModifyRequest(this OcipClient client, UserPreferredCarrierUserModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the currently configured preferred carriers for a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPreferredCarrierUserModifyRequestAsync(this OcipClient client, UserPreferredCarrierUserModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
