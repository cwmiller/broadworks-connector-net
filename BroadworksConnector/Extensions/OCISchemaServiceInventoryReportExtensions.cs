using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceInventoryReportExtensions
    {

        /// <summary>
        /// Request the group's inventory report.
        /// The response is either a GroupInventoryReportGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupInventoryReportGetRequestAsync instead.")]
        public static async Task<GroupInventoryReportGetResponse> GroupInventoryReportGetRequest(this OcipClient client, GroupInventoryReportGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupInventoryReportGetResponse;
        }

        /// <summary>
        /// Request the group's inventory report.
        /// The response is either a GroupInventoryReportGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupInventoryReportGetResponse> GroupInventoryReportGetRequestAsync(this OcipClient client, GroupInventoryReportGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupInventoryReportGetResponse;
        }
        /// <summary>
        /// Request the system level data associated with Inventory Report.
        /// The response is either a SystemInventoryReportGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemInventoryReportGetRequestAsync instead.")]
        public static async Task<SystemInventoryReportGetResponse> SystemInventoryReportGetRequest(this OcipClient client, SystemInventoryReportGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemInventoryReportGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Inventory Report.
        /// The response is either a SystemInventoryReportGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemInventoryReportGetResponse> SystemInventoryReportGetRequestAsync(this OcipClient client, SystemInventoryReportGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemInventoryReportGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Inventory Report.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemInventoryReportModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemInventoryReportModifyRequest(this OcipClient client, SystemInventoryReportModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Inventory Report.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemInventoryReportModifyRequestAsync(this OcipClient client, SystemInventoryReportModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
