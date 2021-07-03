using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServicePrivacyExtensions
    {

        /// <summary>
        /// Request the data associated with Privacy for a service instance.
        /// The response is either a GroupServiceInstancePrivacyGetResponse17sp4
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupServiceInstancePrivacyGetRequest17sp4Async instead.")]
        public static async Task<GroupServiceInstancePrivacyGetResponse17sp4> GroupServiceInstancePrivacyGetRequest17sp4(this OcipClient client, GroupServiceInstancePrivacyGetRequest17sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupServiceInstancePrivacyGetResponse17sp4;
        }

        /// <summary>
        /// Request the data associated with Privacy for a service instance.
        /// The response is either a GroupServiceInstancePrivacyGetResponse17sp4
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<GroupServiceInstancePrivacyGetResponse17sp4> GroupServiceInstancePrivacyGetRequest17sp4Async(this OcipClient client, GroupServiceInstancePrivacyGetRequest17sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupServiceInstancePrivacyGetResponse17sp4;
        }
        /// <summary>
        /// Modify the data associated with Privacy for a service instance.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupServiceInstancePrivacyModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupServiceInstancePrivacyModifyRequest(this OcipClient client, GroupServiceInstancePrivacyModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the data associated with Privacy for a service instance.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupServiceInstancePrivacyModifyRequestAsync(this OcipClient client, GroupServiceInstancePrivacyModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Retrieves a list of users in the enterprise or group available
        /// for phone status monitoring the user specified in the userId
        /// element.
        /// The response is either UserPrivacyGetAvailableMonitorsUserListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPrivacyGetAvailableMonitorsUserListRequestAsync instead.")]
        public static async Task<UserPrivacyGetAvailableMonitorsUserListResponse> UserPrivacyGetAvailableMonitorsUserListRequest(this OcipClient client, UserPrivacyGetAvailableMonitorsUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPrivacyGetAvailableMonitorsUserListResponse;
        }

        /// <summary>
        /// Retrieves a list of users in the enterprise or group available
        /// for phone status monitoring the user specified in the userId
        /// element.
        /// The response is either UserPrivacyGetAvailableMonitorsUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserPrivacyGetAvailableMonitorsUserListResponse> UserPrivacyGetAvailableMonitorsUserListRequestAsync(this OcipClient client, UserPrivacyGetAvailableMonitorsUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPrivacyGetAvailableMonitorsUserListResponse;
        }
        /// <summary>
        /// Request the user level data associated with Privacy.
        /// This command is supported for regular users only.
        /// The response is either a UserPrivacyGetResponse13mp17
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPrivacyGetRequest13mp17Async instead.")]
        public static async Task<UserPrivacyGetResponse13mp17> UserPrivacyGetRequest13mp17(this OcipClient client, UserPrivacyGetRequest13mp17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPrivacyGetResponse13mp17;
        }

        /// <summary>
        /// Request the user level data associated with Privacy.
        /// This command is supported for regular users only.
        /// The response is either a UserPrivacyGetResponse13mp17
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<UserPrivacyGetResponse13mp17> UserPrivacyGetRequest13mp17Async(this OcipClient client, UserPrivacyGetRequest13mp17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPrivacyGetResponse13mp17;
        }
        /// <summary>
        /// Modify the user level data associated with Privacy.
        /// This command is supported for regular users only.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPrivacyModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPrivacyModifyRequest(this OcipClient client, UserPrivacyModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Privacy.
        /// This command is supported for regular users only.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPrivacyModifyRequestAsync(this OcipClient client, UserPrivacyModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
