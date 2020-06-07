using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceBasicCallLogsExtensions
    {

        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls are returned.
        /// The response is either a UserBasicCallLogsGetListResponse14sp4 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBasicCallLogsGetListRequest14sp4Async instead.")]
        public static async Task<UserBasicCallLogsGetListResponse14sp4> UserBasicCallLogsGetListRequest14sp4(this OcipClient client, UserBasicCallLogsGetListRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBasicCallLogsGetListResponse14sp4;
        }

        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls are returned.
        /// The response is either a UserBasicCallLogsGetListResponse14sp4 or an ErrorResponse.
        /// </summary>
        public static async Task<UserBasicCallLogsGetListResponse14sp4> UserBasicCallLogsGetListRequest14sp4Async(this OcipClient client, UserBasicCallLogsGetListRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBasicCallLogsGetListResponse14sp4;
        }

    }
}
