using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceReceptionistEnterpriseExtensions
    {

        /// <summary>
        /// Request to get the list of BroadWorks Receptionist - Enterprise parameters.
        /// The response is either SystemBroadWorksReceptionistEnterpriseGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBroadWorksReceptionistEnterpriseGetRequestAsync instead.")]
        public static async Task<SystemBroadWorksReceptionistEnterpriseGetResponse> SystemBroadWorksReceptionistEnterpriseGetRequest(this OcipClient client, SystemBroadWorksReceptionistEnterpriseGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBroadWorksReceptionistEnterpriseGetResponse;
        }

        /// <summary>
        /// Request to get the list of BroadWorks Receptionist - Enterprise parameters.
        /// The response is either SystemBroadWorksReceptionistEnterpriseGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemBroadWorksReceptionistEnterpriseGetResponse> SystemBroadWorksReceptionistEnterpriseGetRequestAsync(this OcipClient client, SystemBroadWorksReceptionistEnterpriseGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBroadWorksReceptionistEnterpriseGetResponse;
        }
        /// <summary>
        /// Request to modify BroadWorks Receptionist - Enterprise settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBroadWorksReceptionistEnterpriseModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBroadWorksReceptionistEnterpriseModifyRequest(this OcipClient client, SystemBroadWorksReceptionistEnterpriseModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify BroadWorks Receptionist - Enterprise settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksReceptionistEnterpriseModifyRequestAsync(this OcipClient client, SystemBroadWorksReceptionistEnterpriseModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add users to the BroadWorks Receptionist - Enterprise monitored user list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksReceptionistEnterpriseAddUserListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserBroadWorksReceptionistEnterpriseAddUserListRequest(this OcipClient client, UserBroadWorksReceptionistEnterpriseAddUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add users to the BroadWorks Receptionist - Enterprise monitored user list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksReceptionistEnterpriseAddUserListRequestAsync(this OcipClient client, UserBroadWorksReceptionistEnterpriseAddUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Remove selected users from the BroadWorks Receptionist - Enterprise monitored user list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksReceptionistEnterpriseDeleteUserListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserBroadWorksReceptionistEnterpriseDeleteUserListRequest(this OcipClient client, UserBroadWorksReceptionistEnterpriseDeleteUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Remove selected users from the BroadWorks Receptionist - Enterprise monitored user list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksReceptionistEnterpriseDeleteUserListRequestAsync(this OcipClient client, UserBroadWorksReceptionistEnterpriseDeleteUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of available users for BroadWorks Receptionist - Enterprise monitoring.
        /// The response is either UserBroadWorksReceptionistEnterpriseGetAvailableUserListResponse or ErrorResponse.
        /// The Receptionist Note column is only populated, if the user sending the request is the owner of the
        /// Receptionist Note and a Note exists.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksReceptionistEnterpriseGetAvailableUserListRequestAsync instead.")]
        public static async Task<UserBroadWorksReceptionistEnterpriseGetAvailableUserListResponse> UserBroadWorksReceptionistEnterpriseGetAvailableUserListRequest(this OcipClient client, UserBroadWorksReceptionistEnterpriseGetAvailableUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBroadWorksReceptionistEnterpriseGetAvailableUserListResponse;
        }

        /// <summary>
        /// Get a list of available users for BroadWorks Receptionist - Enterprise monitoring.
        /// The response is either UserBroadWorksReceptionistEnterpriseGetAvailableUserListResponse or ErrorResponse.
        /// The Receptionist Note column is only populated, if the user sending the request is the owner of the
        /// Receptionist Note and a Note exists.
        /// </summary>
        public static async Task<UserBroadWorksReceptionistEnterpriseGetAvailableUserListResponse> UserBroadWorksReceptionistEnterpriseGetAvailableUserListRequestAsync(this OcipClient client, UserBroadWorksReceptionistEnterpriseGetAvailableUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBroadWorksReceptionistEnterpriseGetAvailableUserListResponse;
        }
        /// <summary>
        /// Request the monitored users list for the BroadWorks Receptionist - Enterprise service.
        /// The response is either a UserBroadWorksReceptionistEnterpriseGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksReceptionistEnterpriseGetRequestAsync instead.")]
        public static async Task<UserBroadWorksReceptionistEnterpriseGetResponse> UserBroadWorksReceptionistEnterpriseGetRequest(this OcipClient client, UserBroadWorksReceptionistEnterpriseGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBroadWorksReceptionistEnterpriseGetResponse;
        }

        /// <summary>
        /// Request the monitored users list for the BroadWorks Receptionist - Enterprise service.
        /// The response is either a UserBroadWorksReceptionistEnterpriseGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksReceptionistEnterpriseGetResponse> UserBroadWorksReceptionistEnterpriseGetRequestAsync(this OcipClient client, UserBroadWorksReceptionistEnterpriseGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBroadWorksReceptionistEnterpriseGetResponse;
        }
        /// <summary>
        /// Replace the BroadWorks Receptionist - Enterprise monitored user list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksReceptionistEnterpriseModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserBroadWorksReceptionistEnterpriseModifyRequest(this OcipClient client, UserBroadWorksReceptionistEnterpriseModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Replace the BroadWorks Receptionist - Enterprise monitored user list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksReceptionistEnterpriseModifyRequestAsync(this OcipClient client, UserBroadWorksReceptionistEnterpriseModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the Receptionist notes for the specified Receptionist and Contact User IDs.
        /// The response is either a UserBroadWorksReceptionistEnterpriseNoteGetResponse or an
        /// ErrorResponse.  If the user sending the request is the not the owner of the
        /// Receptionist Note, then an ErrorResponse will be returned.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksReceptionistEnterpriseNoteGetRequestAsync instead.")]
        public static async Task<UserBroadWorksReceptionistEnterpriseNoteGetResponse> UserBroadWorksReceptionistEnterpriseNoteGetRequest(this OcipClient client, UserBroadWorksReceptionistEnterpriseNoteGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBroadWorksReceptionistEnterpriseNoteGetResponse;
        }

        /// <summary>
        /// Request the Receptionist notes for the specified Receptionist and Contact User IDs.
        /// The response is either a UserBroadWorksReceptionistEnterpriseNoteGetResponse or an
        /// ErrorResponse.  If the user sending the request is the not the owner of the
        /// Receptionist Note, then an ErrorResponse will be returned.
        /// </summary>
        public static async Task<UserBroadWorksReceptionistEnterpriseNoteGetResponse> UserBroadWorksReceptionistEnterpriseNoteGetRequestAsync(this OcipClient client, UserBroadWorksReceptionistEnterpriseNoteGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBroadWorksReceptionistEnterpriseNoteGetResponse;
        }
        /// <summary>
        /// Add a list of notes for an existing Receptionist user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// If some of the users add and some users fail to add, then the
        /// response will contain a WarningResponse containing only the
        /// a comma delimited list of users that failed to add. If the user
        /// sending the request is the not the owner of the Receptionist Note,
        /// then an ErrorResponse will be returned.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksReceptionistEnterpriseNoteModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserBroadWorksReceptionistEnterpriseNoteModifyListRequest(this OcipClient client, UserBroadWorksReceptionistEnterpriseNoteModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of notes for an existing Receptionist user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// If some of the users add and some users fail to add, then the
        /// response will contain a WarningResponse containing only the
        /// a comma delimited list of users that failed to add. If the user
        /// sending the request is the not the owner of the Receptionist Note,
        /// then an ErrorResponse will be returned.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksReceptionistEnterpriseNoteModifyListRequestAsync(this OcipClient client, UserBroadWorksReceptionistEnterpriseNoteModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
