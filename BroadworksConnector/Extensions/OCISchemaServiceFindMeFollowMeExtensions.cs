using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceFindMeFollowMeExtensions
    {

        /// <summary>
        /// Add an alerting group to a Find-me/Follow-me instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFindMeFollowMeAddAlertingGroupRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupFindMeFollowMeAddAlertingGroupRequest(this OcipClient client, GroupFindMeFollowMeAddAlertingGroupRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an alerting group to a Find-me/Follow-me instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFindMeFollowMeAddAlertingGroupRequestAsync(this OcipClient client, GroupFindMeFollowMeAddAlertingGroupRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a criteria to the Find-me/Follow-me alerting group.
        /// For the callToNumber, the extension and number elements are not used and the only types accepted for each number are Primary and Alternates. If other type is specified the command fails.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFindMeFollowMeAddAlertingGroupSelectiveCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupFindMeFollowMeAddAlertingGroupSelectiveCriteriaRequest(this OcipClient client, GroupFindMeFollowMeAddAlertingGroupSelectiveCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a criteria to the Find-me/Follow-me alerting group.
        /// For the callToNumber, the extension and number elements are not used and the only types accepted for each number are Primary and Alternates. If other type is specified the command fails.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFindMeFollowMeAddAlertingGroupSelectiveCriteriaRequestAsync(this OcipClient client, GroupFindMeFollowMeAddAlertingGroupSelectiveCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Find-me/Follow-me instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFindMeFollowMeAddInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupFindMeFollowMeAddInstanceRequest(this OcipClient client, GroupFindMeFollowMeAddInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Find-me/Follow-me instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFindMeFollowMeAddInstanceRequestAsync(this OcipClient client, GroupFindMeFollowMeAddInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of users that can be assigned to a Find-me/Follow-me alerting group.
        /// The response is either GroupFindMeFollowMeAlertingGroupGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFindMeFollowMeAlertingGroupGetAvailableUserListRequestAsync instead.")]
        public static async Task<GroupFindMeFollowMeAlertingGroupGetAvailableUserListResponse> GroupFindMeFollowMeAlertingGroupGetAvailableUserListRequest(this OcipClient client, GroupFindMeFollowMeAlertingGroupGetAvailableUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupFindMeFollowMeAlertingGroupGetAvailableUserListResponse;
        }

        /// <summary>
        /// Get a list of users that can be assigned to a Find-me/Follow-me alerting group.
        /// The response is either GroupFindMeFollowMeAlertingGroupGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupFindMeFollowMeAlertingGroupGetAvailableUserListResponse> GroupFindMeFollowMeAlertingGroupGetAvailableUserListRequestAsync(this OcipClient client, GroupFindMeFollowMeAlertingGroupGetAvailableUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupFindMeFollowMeAlertingGroupGetAvailableUserListResponse;
        }
        /// <summary>
        /// Delete an alerting group from a Find-me/Follow-me instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFindMeFollowMeDeleteAlertingGroupRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupFindMeFollowMeDeleteAlertingGroupRequest(this OcipClient client, GroupFindMeFollowMeDeleteAlertingGroupRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an alerting group from a Find-me/Follow-me instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFindMeFollowMeDeleteAlertingGroupRequestAsync(this OcipClient client, GroupFindMeFollowMeDeleteAlertingGroupRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a criteria from the Find-me/Follow-me alerting group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFindMeFollowMeDeleteAlertingGroupSelectiveCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupFindMeFollowMeDeleteAlertingGroupSelectiveCriteriaRequest(this OcipClient client, GroupFindMeFollowMeDeleteAlertingGroupSelectiveCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a criteria from the Find-me/Follow-me alerting group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFindMeFollowMeDeleteAlertingGroupSelectiveCriteriaRequestAsync(this OcipClient client, GroupFindMeFollowMeDeleteAlertingGroupSelectiveCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Find-me/Follow-me instance from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFindMeFollowMeDeleteInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupFindMeFollowMeDeleteInstanceRequest(this OcipClient client, GroupFindMeFollowMeDeleteInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Find-me/Follow-me instance from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFindMeFollowMeDeleteInstanceRequestAsync(this OcipClient client, GroupFindMeFollowMeDeleteInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Find-me/Follow-me alerting groups within a group.
        /// The response is either GroupFindMeFollowMeGetAlertingGroupListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFindMeFollowMeGetAlertingGroupListRequestAsync instead.")]
        public static async Task<GroupFindMeFollowMeGetAlertingGroupListResponse> GroupFindMeFollowMeGetAlertingGroupListRequest(this OcipClient client, GroupFindMeFollowMeGetAlertingGroupListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupFindMeFollowMeGetAlertingGroupListResponse;
        }

        /// <summary>
        /// Get a list of Find-me/Follow-me alerting groups within a group.
        /// The response is either GroupFindMeFollowMeGetAlertingGroupListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupFindMeFollowMeGetAlertingGroupListResponse> GroupFindMeFollowMeGetAlertingGroupListRequestAsync(this OcipClient client, GroupFindMeFollowMeGetAlertingGroupListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupFindMeFollowMeGetAlertingGroupListResponse;
        }
        /// <summary>
        /// Request to get all the information of a Find-me/Follow-me alerting group.
        /// The response is either GroupFindMeFollowMeGetAlertingGroupResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFindMeFollowMeGetAlertingGroupRequestAsync instead.")]
        public static async Task<GroupFindMeFollowMeGetAlertingGroupResponse> GroupFindMeFollowMeGetAlertingGroupRequest(this OcipClient client, GroupFindMeFollowMeGetAlertingGroupRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupFindMeFollowMeGetAlertingGroupResponse;
        }

        /// <summary>
        /// Request to get all the information of a Find-me/Follow-me alerting group.
        /// The response is either GroupFindMeFollowMeGetAlertingGroupResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupFindMeFollowMeGetAlertingGroupResponse> GroupFindMeFollowMeGetAlertingGroupRequestAsync(this OcipClient client, GroupFindMeFollowMeGetAlertingGroupRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupFindMeFollowMeGetAlertingGroupResponse;
        }
        /// <summary>
        /// Request to get all the information of a specific Find-me/Follow-me alerting group selective criteria.
        /// The response is either GroupFindMeFollowMeGetAlertingGroupSelectiveCriteriaResponse21 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFindMeFollowMeGetAlertingGroupSelectiveCriteriaRequest21Async instead.")]
        public static async Task<GroupFindMeFollowMeGetAlertingGroupSelectiveCriteriaResponse21> GroupFindMeFollowMeGetAlertingGroupSelectiveCriteriaRequest21(this OcipClient client, GroupFindMeFollowMeGetAlertingGroupSelectiveCriteriaRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupFindMeFollowMeGetAlertingGroupSelectiveCriteriaResponse21;
        }

        /// <summary>
        /// Request to get all the information of a specific Find-me/Follow-me alerting group selective criteria.
        /// The response is either GroupFindMeFollowMeGetAlertingGroupSelectiveCriteriaResponse21 or ErrorResponse.
        /// </summary>
        public static async Task<GroupFindMeFollowMeGetAlertingGroupSelectiveCriteriaResponse21> GroupFindMeFollowMeGetAlertingGroupSelectiveCriteriaRequest21Async(this OcipClient client, GroupFindMeFollowMeGetAlertingGroupSelectiveCriteriaRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupFindMeFollowMeGetAlertingGroupSelectiveCriteriaResponse21;
        }
        /// <summary>
        /// Get a list of Find-me/Follow-me instances within a group.
        /// The response is either GroupFindMeFollowMeGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFindMeFollowMeGetInstanceListRequestAsync instead.")]
        public static async Task<GroupFindMeFollowMeGetInstanceListResponse> GroupFindMeFollowMeGetInstanceListRequest(this OcipClient client, GroupFindMeFollowMeGetInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupFindMeFollowMeGetInstanceListResponse;
        }

        /// <summary>
        /// Get a list of Find-me/Follow-me instances within a group.
        /// The response is either GroupFindMeFollowMeGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        public static async Task<GroupFindMeFollowMeGetInstanceListResponse> GroupFindMeFollowMeGetInstanceListRequestAsync(this OcipClient client, GroupFindMeFollowMeGetInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupFindMeFollowMeGetInstanceListResponse;
        }
        /// <summary>
        /// Request to get all the information of a Find-me/Follow-me instance.
        /// The response is either GroupFindMeFollowMeGetInstanceResponse19sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFindMeFollowMeGetInstanceRequest19sp1Async instead.")]
        public static async Task<GroupFindMeFollowMeGetInstanceResponse19sp1> GroupFindMeFollowMeGetInstanceRequest19sp1(this OcipClient client, GroupFindMeFollowMeGetInstanceRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupFindMeFollowMeGetInstanceResponse19sp1;
        }

        /// <summary>
        /// Request to get all the information of a Find-me/Follow-me instance.
        /// The response is either GroupFindMeFollowMeGetInstanceResponse19sp1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupFindMeFollowMeGetInstanceResponse19sp1> GroupFindMeFollowMeGetInstanceRequest19sp1Async(this OcipClient client, GroupFindMeFollowMeGetInstanceRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupFindMeFollowMeGetInstanceResponse19sp1;
        }
        /// <summary>
        /// Request to set the active status of Find-me/Follow-me instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFindMeFollowMeModifyActiveInstanceListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupFindMeFollowMeModifyActiveInstanceListRequest(this OcipClient client, GroupFindMeFollowMeModifyActiveInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to set the active status of Find-me/Follow-me instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFindMeFollowMeModifyActiveInstanceListRequestAsync(this OcipClient client, GroupFindMeFollowMeModifyActiveInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the priorities assigned to alerting groups
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// NOTE: The command fails if all the alerting groups defined for the user are not provided.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFindMeFollowMeModifyAlertingGroupListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupFindMeFollowMeModifyAlertingGroupListRequest(this OcipClient client, GroupFindMeFollowMeModifyAlertingGroupListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the priorities assigned to alerting groups
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// NOTE: The command fails if all the alerting groups defined for the user are not provided.
        /// </summary>
        public static async Task<SuccessResponse> GroupFindMeFollowMeModifyAlertingGroupListRequestAsync(this OcipClient client, GroupFindMeFollowMeModifyAlertingGroupListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a Find-me/Follow-me alerting group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFindMeFollowMeModifyAlertingGroupRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupFindMeFollowMeModifyAlertingGroupRequest(this OcipClient client, GroupFindMeFollowMeModifyAlertingGroupRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Find-me/Follow-me alerting group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFindMeFollowMeModifyAlertingGroupRequestAsync(this OcipClient client, GroupFindMeFollowMeModifyAlertingGroupRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a Find-me/Follow-me alerting group criteria.
        /// For the callToNumbers in the callToNumberList, the extension and number elements are not used and the only types accepted for each number are Primary and Alternates. If other type is specified the command fails.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFindMeFollowMeModifyAlertingGroupSelectiveCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupFindMeFollowMeModifyAlertingGroupSelectiveCriteriaRequest(this OcipClient client, GroupFindMeFollowMeModifyAlertingGroupSelectiveCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Find-me/Follow-me alerting group criteria.
        /// For the callToNumbers in the callToNumberList, the extension and number elements are not used and the only types accepted for each number are Primary and Alternates. If other type is specified the command fails.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFindMeFollowMeModifyAlertingGroupSelectiveCriteriaRequestAsync(this OcipClient client, GroupFindMeFollowMeModifyAlertingGroupSelectiveCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a Find-me/Follow-me instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFindMeFollowMeModifyInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupFindMeFollowMeModifyInstanceRequest(this OcipClient client, GroupFindMeFollowMeModifyInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Find-me/Follow-me instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFindMeFollowMeModifyInstanceRequestAsync(this OcipClient client, GroupFindMeFollowMeModifyInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
