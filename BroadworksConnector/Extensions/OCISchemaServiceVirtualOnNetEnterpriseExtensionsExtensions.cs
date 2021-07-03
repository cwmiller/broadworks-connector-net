using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceVirtualOnNetEnterpriseExtensionsExtensions
    {

        /// <summary>
        /// Request the list of Virtual On-Net users in an Enterprise.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a  EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListResponse or
        /// an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListRequestAsync instead.")]
        public static async Task<EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListResponse> EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListRequest(this OcipClient client, EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListResponse;
        }

        /// <summary>
        /// Request the list of Virtual On-Net users in an Enterprise.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a  EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListResponse or
        /// an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListResponse> EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListRequestAsync(this OcipClient client, EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListResponse;
        }
        /// <summary>
        /// Adds Virtual On-Net users to a Group. It is possible to add
        /// either: a single user,  or a list of users, or a range of users,
        /// or any combination thereof.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVirtualOnNetEnterpriseExtensionsAddUserRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupVirtualOnNetEnterpriseExtensionsAddUserRequest(this OcipClient client, GroupVirtualOnNetEnterpriseExtensionsAddUserRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Adds Virtual On-Net users to a Group. It is possible to add
        /// either: a single user,  or a list of users, or a range of users,
        /// or any combination thereof.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupVirtualOnNetEnterpriseExtensionsAddUserRequestAsync(this OcipClient client, GroupVirtualOnNetEnterpriseExtensionsAddUserRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an existing Virtual On-Net user from a Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVirtualOnNetEnterpriseExtensionsDeleteUserRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupVirtualOnNetEnterpriseExtensionsDeleteUserRequest(this OcipClient client, GroupVirtualOnNetEnterpriseExtensionsDeleteUserRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an existing Virtual On-Net user from a Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupVirtualOnNetEnterpriseExtensionsDeleteUserRequestAsync(this OcipClient client, GroupVirtualOnNetEnterpriseExtensionsDeleteUserRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of Virtual On-Net users in a Group.
        /// It is possible to search by various criteria to restrict the number
        /// of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupVirtualOnNetEnterpriseExtensionsGetUserListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVirtualOnNetEnterpriseExtensionsGetUserListRequestAsync instead.")]
        public static async Task<GroupVirtualOnNetEnterpriseExtensionsGetUserListResponse> GroupVirtualOnNetEnterpriseExtensionsGetUserListRequest(this OcipClient client, GroupVirtualOnNetEnterpriseExtensionsGetUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupVirtualOnNetEnterpriseExtensionsGetUserListResponse;
        }

        /// <summary>
        /// Request the list of Virtual On-Net users in a Group.
        /// It is possible to search by various criteria to restrict the number
        /// of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupVirtualOnNetEnterpriseExtensionsGetUserListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupVirtualOnNetEnterpriseExtensionsGetUserListResponse> GroupVirtualOnNetEnterpriseExtensionsGetUserListRequestAsync(this OcipClient client, GroupVirtualOnNetEnterpriseExtensionsGetUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupVirtualOnNetEnterpriseExtensionsGetUserListResponse;
        }
        /// <summary>
        /// Get an existing Virtual On-Net user from a Group.
        /// The response is either a GroupVirtualOnNetEnterpriseExtensionsGetUserResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVirtualOnNetEnterpriseExtensionsGetUserRequestAsync instead.")]
        public static async Task<GroupVirtualOnNetEnterpriseExtensionsGetUserResponse> GroupVirtualOnNetEnterpriseExtensionsGetUserRequest(this OcipClient client, GroupVirtualOnNetEnterpriseExtensionsGetUserRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupVirtualOnNetEnterpriseExtensionsGetUserResponse;
        }

        /// <summary>
        /// Get an existing Virtual On-Net user from a Group.
        /// The response is either a GroupVirtualOnNetEnterpriseExtensionsGetUserResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupVirtualOnNetEnterpriseExtensionsGetUserResponse> GroupVirtualOnNetEnterpriseExtensionsGetUserRequestAsync(this OcipClient client, GroupVirtualOnNetEnterpriseExtensionsGetUserRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupVirtualOnNetEnterpriseExtensionsGetUserResponse;
        }
        /// <summary>
        /// Modify an existing Virtual On-Net user of a Group.
        /// The serviceProviderId, groupId and phoneNumber combination uniquely
        /// identifies a Virtual On-Net User.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVirtualOnNetEnterpriseExtensionsModifyUserRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupVirtualOnNetEnterpriseExtensionsModifyUserRequest(this OcipClient client, GroupVirtualOnNetEnterpriseExtensionsModifyUserRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing Virtual On-Net user of a Group.
        /// The serviceProviderId, groupId and phoneNumber combination uniquely
        /// identifies a Virtual On-Net User.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupVirtualOnNetEnterpriseExtensionsModifyUserRequestAsync(this OcipClient client, GroupVirtualOnNetEnterpriseExtensionsModifyUserRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Virtual On-Net Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVirtualOnNetCallTypeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemVirtualOnNetCallTypeAddRequest(this OcipClient client, SystemVirtualOnNetCallTypeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Virtual On-Net Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVirtualOnNetCallTypeAddRequestAsync(this OcipClient client, SystemVirtualOnNetCallTypeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Virtual On-Net Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVirtualOnNetCallTypeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemVirtualOnNetCallTypeDeleteRequest(this OcipClient client, SystemVirtualOnNetCallTypeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Virtual On-Net Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVirtualOnNetCallTypeDeleteRequestAsync(this OcipClient client, SystemVirtualOnNetCallTypeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list Virtual On-Net Call Types in the system.
        /// The response is either a SystemVirtualOnNetCallTypeGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVirtualOnNetCallTypeGetListRequestAsync instead.")]
        public static async Task<SystemVirtualOnNetCallTypeGetListResponse> SystemVirtualOnNetCallTypeGetListRequest(this OcipClient client, SystemVirtualOnNetCallTypeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemVirtualOnNetCallTypeGetListResponse;
        }

        /// <summary>
        /// Get the list Virtual On-Net Call Types in the system.
        /// The response is either a SystemVirtualOnNetCallTypeGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemVirtualOnNetCallTypeGetListResponse> SystemVirtualOnNetCallTypeGetListRequestAsync(this OcipClient client, SystemVirtualOnNetCallTypeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemVirtualOnNetCallTypeGetListResponse;
        }
        /// <summary>
        /// Modify a Virtual On-Net Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVirtualOnNetCallTypeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemVirtualOnNetCallTypeModifyRequest(this OcipClient client, SystemVirtualOnNetCallTypeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Virtual On-Net Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVirtualOnNetCallTypeModifyRequestAsync(this OcipClient client, SystemVirtualOnNetCallTypeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
