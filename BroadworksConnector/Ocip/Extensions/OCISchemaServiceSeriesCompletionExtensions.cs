using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceSeriesCompletionExtensions
    {

        /// <summary>
        /// Adds a Series Completion group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupSeriesCompletionAddInstanceRequest(this OcipClient client, GroupSeriesCompletionAddInstanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Deletes a Series Completion group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupSeriesCompletionDeleteInstanceRequest(this OcipClient client, GroupSeriesCompletionDeleteInstanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of users that can be assigned to a Series Completion group.
        /// The available user list for a new Series Completion group can be obtained
        /// by not setting the name.
        /// The response is either GroupSeriesCompletionGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupSeriesCompletionGetAvailableUserListResponse> GroupSeriesCompletionGetAvailableUserListRequest(this OcipClient client, GroupSeriesCompletionGetAvailableUserListRequest request)
        {
            return await client.Call(request) as GroupSeriesCompletionGetAvailableUserListResponse;
        }

        /// <summary>
        /// Request to get a list of Series Completion instances within a group.
        /// The response is either GroupSeriesCompletionGetInstanceListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupSeriesCompletionGetInstanceListResponse> GroupSeriesCompletionGetInstanceListRequest(this OcipClient client, GroupSeriesCompletionGetInstanceListRequest request)
        {
            return await client.Call(request) as GroupSeriesCompletionGetInstanceListResponse;
        }

        /// <summary>
        /// Gets a Series Completion group.
        /// The response is either GroupSeriesCompletionGetInstanceResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupSeriesCompletionGetInstanceResponse> GroupSeriesCompletionGetInstanceRequest(this OcipClient client, GroupSeriesCompletionGetInstanceRequest request)
        {
            return await client.Call(request) as GroupSeriesCompletionGetInstanceResponse;
        }

        /// <summary>
        /// Modifies a Series Completion group. Replaces the entire list of users in the group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupSeriesCompletionModifyInstanceRequest(this OcipClient client, GroupSeriesCompletionModifyInstanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Gets the details of the Series Completion group that a user belongs to (if any).
        /// Any user can only belong to one Series Completion group.
        /// The response is either UserSeriesCompletionGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserSeriesCompletionGetResponse> UserSeriesCompletionGetRequest(this OcipClient client, UserSeriesCompletionGetRequest request)
        {
            return await client.Call(request) as UserSeriesCompletionGetResponse;
        }


    }
}
