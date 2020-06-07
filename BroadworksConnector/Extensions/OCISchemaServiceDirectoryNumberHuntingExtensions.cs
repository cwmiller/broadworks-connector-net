using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceDirectoryNumberHuntingExtensions
    {

        /// <summary>
        /// Request to get the agents of a call center or hunt group that are available
        /// to be assigned to a directory number hunting group.  They are agents that
        /// are not already assigned to any other directory number hunting group.
        /// The response is either GroupDirectoryNumberHuntingGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDirectoryNumberHuntingGetAvailableUserListRequestAsync instead.")]
        public static async Task<GroupDirectoryNumberHuntingGetAvailableUserListResponse> GroupDirectoryNumberHuntingGetAvailableUserListRequest(this OcipClient client, GroupDirectoryNumberHuntingGetAvailableUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDirectoryNumberHuntingGetAvailableUserListResponse;
        }

        /// <summary>
        /// Request to get the agents of a call center or hunt group that are available
        /// to be assigned to a directory number hunting group.  They are agents that
        /// are not already assigned to any other directory number hunting group.
        /// The response is either GroupDirectoryNumberHuntingGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupDirectoryNumberHuntingGetAvailableUserListResponse> GroupDirectoryNumberHuntingGetAvailableUserListRequestAsync(this OcipClient client, GroupDirectoryNumberHuntingGetAvailableUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDirectoryNumberHuntingGetAvailableUserListResponse;
        }
        /// <summary>
        /// Request to get the properties of the DNH service for a specified serviceUserId.
        /// It gets the agents of a call center or hunt group that are members
        /// of a directory number hunting group.  They are agents that are not already
        /// assigned to any other directory number hunting group.
        /// The response is either GroupDirectoryNumberHuntingGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDirectoryNumberHuntingGetRequest17sp1Async instead.")]
        public static async Task<GroupDirectoryNumberHuntingGetResponse> GroupDirectoryNumberHuntingGetRequest17sp1(this OcipClient client, GroupDirectoryNumberHuntingGetRequest17sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDirectoryNumberHuntingGetResponse;
        }

        /// <summary>
        /// Request to get the properties of the DNH service for a specified serviceUserId.
        /// It gets the agents of a call center or hunt group that are members
        /// of a directory number hunting group.  They are agents that are not already
        /// assigned to any other directory number hunting group.
        /// The response is either GroupDirectoryNumberHuntingGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupDirectoryNumberHuntingGetResponse> GroupDirectoryNumberHuntingGetRequest17sp1Async(this OcipClient client, GroupDirectoryNumberHuntingGetRequest17sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDirectoryNumberHuntingGetResponse;
        }
        /// <summary>
        /// Replaces a list of users as agents for a directory number hunting group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDirectoryNumberHuntingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDirectoryNumberHuntingModifyRequest(this OcipClient client, GroupDirectoryNumberHuntingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Replaces a list of users as agents for a directory number hunting group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDirectoryNumberHuntingModifyRequestAsync(this OcipClient client, GroupDirectoryNumberHuntingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
