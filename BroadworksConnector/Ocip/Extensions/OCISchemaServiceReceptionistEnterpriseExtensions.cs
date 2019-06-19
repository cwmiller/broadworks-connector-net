using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceReceptionistEnterpriseExtensions
    {

        /// <summary>
        /// Request to get the list of BroadWorks Receptionist - Enterprise parameters.
        /// The response is either SystemBroadWorksReceptionistEnterpriseGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemBroadWorksReceptionistEnterpriseGetResponse> SystemBroadWorksReceptionistEnterpriseGetRequest(this OcipClient client, SystemBroadWorksReceptionistEnterpriseGetRequest request)
        {
            return await client.Call(request) as SystemBroadWorksReceptionistEnterpriseGetResponse;
        }

        /// <summary>
        /// Request to modify BroadWorks Receptionist - Enterprise settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksReceptionistEnterpriseModifyRequest(this OcipClient client, SystemBroadWorksReceptionistEnterpriseModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add users to the BroadWorks Receptionist - Enterprise monitored user list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksReceptionistEnterpriseAddUserListRequest(this OcipClient client, UserBroadWorksReceptionistEnterpriseAddUserListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Remove selected users from the BroadWorks Receptionist - Enterprise monitored user list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksReceptionistEnterpriseDeleteUserListRequest(this OcipClient client, UserBroadWorksReceptionistEnterpriseDeleteUserListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of available users for BroadWorks Receptionist - Enterprise monitoring.
        /// The response is either UserBroadWorksReceptionistEnterpriseGetAvailableUserListResponse or ErrorResponse.
        /// The Receptionist Note column is only populated, if the user sending the request is the owner of the
        /// Receptionist Note and a Note exists.
        /// </summary>
        public static async Task<UserBroadWorksReceptionistEnterpriseGetAvailableUserListResponse> UserBroadWorksReceptionistEnterpriseGetAvailableUserListRequest(this OcipClient client, UserBroadWorksReceptionistEnterpriseGetAvailableUserListRequest request)
        {
            return await client.Call(request) as UserBroadWorksReceptionistEnterpriseGetAvailableUserListResponse;
        }

        /// <summary>
        /// Request the monitored users list for the BroadWorks Receptionist - Enterprise service.
        /// The response is either a UserBroadWorksReceptionistEnterpriseGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksReceptionistEnterpriseGetResponse> UserBroadWorksReceptionistEnterpriseGetRequest(this OcipClient client, UserBroadWorksReceptionistEnterpriseGetRequest request)
        {
            return await client.Call(request) as UserBroadWorksReceptionistEnterpriseGetResponse;
        }

        /// <summary>
        /// Replace the BroadWorks Receptionist - Enterprise monitored user list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksReceptionistEnterpriseModifyRequest(this OcipClient client, UserBroadWorksReceptionistEnterpriseModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the Receptionist notes for the specified Receptionist and Contact User IDs.
        /// The response is either a UserBroadWorksReceptionistEnterpriseNoteGetResponse or an
        /// ErrorResponse.  If the user sending the request is the not the owner of the
        /// Receptionist Note, then an ErrorResponse will be returned.
        /// </summary>
        public static async Task<UserBroadWorksReceptionistEnterpriseNoteGetResponse> UserBroadWorksReceptionistEnterpriseNoteGetRequest(this OcipClient client, UserBroadWorksReceptionistEnterpriseNoteGetRequest request)
        {
            return await client.Call(request) as UserBroadWorksReceptionistEnterpriseNoteGetResponse;
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
        public static async Task<SuccessResponse> UserBroadWorksReceptionistEnterpriseNoteModifyListRequest(this OcipClient client, UserBroadWorksReceptionistEnterpriseNoteModifyListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
