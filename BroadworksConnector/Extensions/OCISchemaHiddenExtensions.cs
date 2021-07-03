using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;

namespace BroadWorksConnector
{
    public static class OCISchemaHiddenExtensions
    {

        /// <summary>
        /// Request to get the location of a file in a user’s Announcement Repository.
        /// The response is either UserAnnouncementFileLocationGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAnnouncementFileLocationGetRequestAsync instead.")]
        public static async Task<UserAnnouncementFileLocationGetResponse> UserAnnouncementFileLocationGetRequest(this OcipClient client, UserAnnouncementFileLocationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAnnouncementFileLocationGetResponse;
        }

        /// <summary>
        /// Request to get the location of a file in a user’s Announcement Repository.
        /// The response is either UserAnnouncementFileLocationGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserAnnouncementFileLocationGetResponse> UserAnnouncementFileLocationGetRequestAsync(this OcipClient client, UserAnnouncementFileLocationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAnnouncementFileLocationGetResponse;
        }
        /// <summary>
        /// Request to get the location of a file in a group’s
        /// Announcement Repository.
        /// The response is either GroupAnnouncementFileLocationGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAnnouncementFileLocationGetRequestAsync instead.")]
        public static async Task<GroupAnnouncementFileLocationGetResponse> GroupAnnouncementFileLocationGetRequest(this OcipClient client, GroupAnnouncementFileLocationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAnnouncementFileLocationGetResponse;
        }

        /// <summary>
        /// Request to get the location of a file in a group’s
        /// Announcement Repository.
        /// The response is either GroupAnnouncementFileLocationGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupAnnouncementFileLocationGetResponse> GroupAnnouncementFileLocationGetRequestAsync(this OcipClient client, GroupAnnouncementFileLocationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAnnouncementFileLocationGetResponse;
        }

    }
}
