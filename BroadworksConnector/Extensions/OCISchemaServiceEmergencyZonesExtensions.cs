using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceEmergencyZonesExtensions
    {

        /// <summary>
        /// Add a list of home zones and/or home zone ranges to the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEmergencyZonesAddHomeZoneListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEmergencyZonesAddHomeZoneListRequest(this OcipClient client, GroupEmergencyZonesAddHomeZoneListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of home zones and/or home zone ranges to the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEmergencyZonesAddHomeZoneListRequestAsync(this OcipClient client, GroupEmergencyZonesAddHomeZoneListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of home zones and/or home zone ranges to the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEmergencyZonesDeleteHomeZoneListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEmergencyZonesDeleteHomeZoneListRequest(this OcipClient client, GroupEmergencyZonesDeleteHomeZoneListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of home zones and/or home zone ranges to the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEmergencyZonesDeleteHomeZoneListRequestAsync(this OcipClient client, GroupEmergencyZonesDeleteHomeZoneListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the group level data associated with Emergency Zones.
        /// The response is either a GroupEmergencyZonesGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEmergencyZonesGetHomeZoneListRequestAsync instead.")]
        public static async Task<GroupEmergencyZonesGetResponse> GroupEmergencyZonesGetHomeZoneListRequest(this OcipClient client, GroupEmergencyZonesGetHomeZoneListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupEmergencyZonesGetResponse;
        }

        /// <summary>
        /// Request the group level data associated with Emergency Zones.
        /// The response is either a GroupEmergencyZonesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEmergencyZonesGetResponse> GroupEmergencyZonesGetHomeZoneListRequestAsync(this OcipClient client, GroupEmergencyZonesGetHomeZoneListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupEmergencyZonesGetResponse;
        }
        /// <summary>
        /// Request the group level data associated with Emergency Zones.
        /// The response is either a GroupEmergencyZonesGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEmergencyZonesGetRequestAsync instead.")]
        public static async Task<GroupEmergencyZonesGetResponse> GroupEmergencyZonesGetRequest(this OcipClient client, GroupEmergencyZonesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupEmergencyZonesGetResponse;
        }

        /// <summary>
        /// Request the group level data associated with Emergency Zones.
        /// The response is either a GroupEmergencyZonesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEmergencyZonesGetResponse> GroupEmergencyZonesGetRequestAsync(this OcipClient client, GroupEmergencyZonesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupEmergencyZonesGetResponse;
        }
        /// <summary>
        /// Modify a list of home zones and/or home zone ranges.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEmergencyZonesModifyHomeZoneListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEmergencyZonesModifyHomeZoneListRequest(this OcipClient client, GroupEmergencyZonesModifyHomeZoneListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a list of home zones and/or home zone ranges.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEmergencyZonesModifyHomeZoneListRequestAsync(this OcipClient client, GroupEmergencyZonesModifyHomeZoneListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the group level data associated with Emergency Zones.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEmergencyZonesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEmergencyZonesModifyRequest(this OcipClient client, GroupEmergencyZonesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group level data associated with Emergency Zones.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEmergencyZonesModifyRequestAsync(this OcipClient client, GroupEmergencyZonesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the reseller level data associated with Emergency Zones.
        /// The response is either a ResellerEmergencyZonesGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerEmergencyZonesGetRequestAsync instead.")]
        public static async Task<ResellerEmergencyZonesGetResponse> ResellerEmergencyZonesGetRequest(this OcipClient client, ResellerEmergencyZonesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerEmergencyZonesGetResponse;
        }

        /// <summary>
        /// Request the reseller level data associated with Emergency Zones.
        /// The response is either a ResellerEmergencyZonesGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<ResellerEmergencyZonesGetResponse> ResellerEmergencyZonesGetRequestAsync(this OcipClient client, ResellerEmergencyZonesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerEmergencyZonesGetResponse;
        }
        /// <summary>
        /// Modify the reseller level data associated with Emergency Zones.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerEmergencyZonesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerEmergencyZonesModifyRequest(this OcipClient client, ResellerEmergencyZonesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the reseller level data associated with Emergency Zones.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerEmergencyZonesModifyRequestAsync(this OcipClient client, ResellerEmergencyZonesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with Emergency Zones.
        /// The response is either a SystemEmergencyZonesGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEmergencyZonesGetRequestAsync instead.")]
        public static async Task<SystemEmergencyZonesGetResponse> SystemEmergencyZonesGetRequest(this OcipClient client, SystemEmergencyZonesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemEmergencyZonesGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Emergency Zones.
        /// The response is either a SystemEmergencyZonesGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemEmergencyZonesGetResponse> SystemEmergencyZonesGetRequestAsync(this OcipClient client, SystemEmergencyZonesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemEmergencyZonesGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Emergency Zones.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEmergencyZonesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemEmergencyZonesModifyRequest(this OcipClient client, SystemEmergencyZonesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Emergency Zones.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemEmergencyZonesModifyRequestAsync(this OcipClient client, SystemEmergencyZonesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
