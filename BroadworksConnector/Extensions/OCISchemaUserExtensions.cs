using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaUserExtensions
    {

        /// <summary>
        /// Request to configure a WebEx room/place to have the primary endpoint of WebEx Teams device.
        /// 
        /// placeUserId refers to a WebEx room/place.
        /// webExSIPAddress specifies the WebEx SIP address of the place. The format of this parameter is: user@domain.
        /// The user part specified in webExSIPAddress will be set to the lineport of the place’s primary endpoint. The endpoint
        /// will have a static address with URI set to "sip:user@domain".
        /// The domain specified in webExSIPAddress will be:
        /// - added to the system if it does not exist yet.
        /// - assigned to the service provider/enterprise which the place belongs to, if it has not been assigned yet.
        /// - assigned to the group which the place belongs to, if it has not been assigned yet.
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use PlaceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> PlaceModifyRequest(this OcipClient client, PlaceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to configure a WebEx room/place to have the primary endpoint of WebEx Teams device.
        /// 
        /// placeUserId refers to a WebEx room/place.
        /// webExSIPAddress specifies the WebEx SIP address of the place. The format of this parameter is: user@domain.
        /// The user part specified in webExSIPAddress will be set to the lineport of the place’s primary endpoint. The endpoint
        /// will have a static address with URI set to "sip:user@domain".
        /// The domain specified in webExSIPAddress will be:
        /// - added to the system if it does not exist yet.
        /// - assigned to the service provider/enterprise which the place belongs to, if it has not been assigned yet.
        /// - assigned to the group which the place belongs to, if it has not been assigned yet.
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> PlaceModifyRequestAsync(this OcipClient client, PlaceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of access devices associated to a user and their device activation information.
        /// The response is either UserAccessDeviceDeviceActivationGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAccessDeviceDeviceActivationGetListRequestAsync instead.")]
        public static async Task<UserAccessDeviceDeviceActivationGetListResponse> UserAccessDeviceDeviceActivationGetListRequest(this OcipClient client, UserAccessDeviceDeviceActivationGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAccessDeviceDeviceActivationGetListResponse;
        }

        /// <summary>
        /// Requests the list of access devices associated to a user and their device activation information.
        /// The response is either UserAccessDeviceDeviceActivationGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserAccessDeviceDeviceActivationGetListResponse> UserAccessDeviceDeviceActivationGetListRequestAsync(this OcipClient client, UserAccessDeviceDeviceActivationGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAccessDeviceDeviceActivationGetListResponse;
        }
        /// <summary>
        /// Request to get the list of Device Management user modifiable files.
        /// The response is either UserAccessDeviceFileGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAccessDeviceFileGetListRequestAsync instead.")]
        public static async Task<UserAccessDeviceFileGetListResponse> UserAccessDeviceFileGetListRequest(this OcipClient client, UserAccessDeviceFileGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAccessDeviceFileGetListResponse;
        }

        /// <summary>
        /// Request to get the list of Device Management user modifiable files.
        /// The response is either UserAccessDeviceFileGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserAccessDeviceFileGetListResponse> UserAccessDeviceFileGetListRequestAsync(this OcipClient client, UserAccessDeviceFileGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAccessDeviceFileGetListResponse;
        }
        /// <summary>
        /// Request to get a user modifiable file.
        /// The response is either UserAccessDeviceFileGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAccessDeviceFileGetRequestAsync instead.")]
        public static async Task<UserAccessDeviceFileGetResponse> UserAccessDeviceFileGetRequest(this OcipClient client, UserAccessDeviceFileGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAccessDeviceFileGetResponse;
        }

        /// <summary>
        /// Request to get a user modifiable file.
        /// The response is either UserAccessDeviceFileGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserAccessDeviceFileGetResponse> UserAccessDeviceFileGetRequestAsync(this OcipClient client, UserAccessDeviceFileGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAccessDeviceFileGetResponse;
        }
        /// <summary>
        /// Request to modify a user modifiable access device file.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAccessDeviceFileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserAccessDeviceFileModifyRequest(this OcipClient client, UserAccessDeviceFileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a user modifiable access device file.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAccessDeviceFileModifyRequestAsync(this OcipClient client, UserAccessDeviceFileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Reset a specific user SIP device that supports the reset operation.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAccessDeviceResetRequestAsync instead.")]
        public static async Task<SuccessResponse> UserAccessDeviceResetRequest(this OcipClient client, UserAccessDeviceResetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Reset a specific user SIP device that supports the reset operation.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAccessDeviceResetRequestAsync(this OcipClient client, UserAccessDeviceResetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get all the device tag names and values for a specific device. The resolved tags are returned only if the device is the main device for this user.
        /// The response is either a UserAccessDeviceTagsGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAccessDeviceTagsGetRequestAsync instead.")]
        public static async Task<UserAccessDeviceTagsGetResponse> UserAccessDeviceTagsGetRequest(this OcipClient client, UserAccessDeviceTagsGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAccessDeviceTagsGetResponse;
        }

        /// <summary>
        /// Request to get all the device tag names and values for a specific device. The resolved tags are returned only if the device is the main device for this user.
        /// The response is either a UserAccessDeviceTagsGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserAccessDeviceTagsGetResponse> UserAccessDeviceTagsGetRequestAsync(this OcipClient client, UserAccessDeviceTagsGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAccessDeviceTagsGetResponse;
        }
        /// <summary>
        /// Request to add a user.
        /// The domain is required in the userId.
        /// The password is not required if external authentication is enabled.
        /// 
        /// The following elements are only used in AS data mode and will fail in XS data mode:
        /// trunkAddressing
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// nameDialingName
        /// alternateUserId
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// allowVideo
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements can only be used by a system administrator:.
        /// allowVideo
        /// alternateUserId
        /// 
        /// The following elements can only be used by a provisioning administrator:.
        /// alternateUserId
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAddRequest22V2Async instead.")]
        public static async Task<SuccessResponse> UserAddRequest22V2(this OcipClient client, UserAddRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a user.
        /// The domain is required in the userId.
        /// The password is not required if external authentication is enabled.
        /// 
        /// The following elements are only used in AS data mode and will fail in XS data mode:
        /// trunkAddressing
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// nameDialingName
        /// alternateUserId
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// allowVideo
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements can only be used by a system administrator:.
        /// allowVideo
        /// alternateUserId
        /// 
        /// The following elements can only be used by a provisioning administrator:.
        /// alternateUserId
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAddRequest22V2Async(this OcipClient client, UserAddRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add an alternate user Id to an user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAlternateUserIdAddRequestAsync instead.")]
        public static async Task<SuccessResponse> UserAlternateUserIdAddRequest(this OcipClient client, UserAlternateUserIdAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add an alternate user Id to an user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAlternateUserIdAddRequestAsync(this OcipClient client, UserAlternateUserIdAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete an alternate user id of a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAlternateUserIdDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> UserAlternateUserIdDeleteRequest(this OcipClient client, UserAlternateUserIdDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete an alternate user id of a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAlternateUserIdDeleteRequestAsync(this OcipClient client, UserAlternateUserIdDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the user id and the list of alternate user ids of an user.
        /// The response is either UserAlternateUserIdGetListResponse or ErrorResponse.
        /// The "userId" can be either the user Id or an alternate user Id.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAlternateUserIdGetListRequestAsync instead.")]
        public static async Task<UserAlternateUserIdGetListResponse> UserAlternateUserIdGetListRequest(this OcipClient client, UserAlternateUserIdGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAlternateUserIdGetListResponse;
        }

        /// <summary>
        /// Request to get the user id and the list of alternate user ids of an user.
        /// The response is either UserAlternateUserIdGetListResponse or ErrorResponse.
        /// The "userId" can be either the user Id or an alternate user Id.
        /// </summary>
        public static async Task<UserAlternateUserIdGetListResponse> UserAlternateUserIdGetListRequestAsync(this OcipClient client, UserAlternateUserIdGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAlternateUserIdGetListResponse;
        }
        /// <summary>
        /// Request to modify an alternate user id of a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAlternateUserIdModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserAlternateUserIdModifyRequest(this OcipClient client, UserAlternateUserIdModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an alternate user id of a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAlternateUserIdModifyRequestAsync(this OcipClient client, UserAlternateUserIdModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an announcement to the user announcement repository
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// announcementFileExternalId
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAnnouncementFileAddRequestAsync instead.")]
        public static async Task<SuccessResponse> UserAnnouncementFileAddRequest(this OcipClient client, UserAnnouncementFileAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an announcement to the user announcement repository
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// announcementFileExternalId
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAnnouncementFileAddRequestAsync(this OcipClient client, UserAnnouncementFileAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete one or more announcements from the user announcement repository
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// announcementFileExternalId
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAnnouncementFileDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserAnnouncementFileDeleteListRequest(this OcipClient client, UserAnnouncementFileDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete one or more announcements from the user announcement repository
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// announcementFileExternalId
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAnnouncementFileDeleteListRequestAsync(this OcipClient client, UserAnnouncementFileDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of available announcement files for a User from the Announcement Repository,
        /// for Virtual subscribers the list will also include the announcements for it's group.
        /// 
        /// The response is either a UserAnnouncementFileGetAvailableListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAnnouncementFileGetAvailableListRequestAsync instead.")]
        public static async Task<UserAnnouncementFileGetAvailableListResponse> UserAnnouncementFileGetAvailableListRequest(this OcipClient client, UserAnnouncementFileGetAvailableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAnnouncementFileGetAvailableListResponse;
        }

        /// <summary>
        /// Get the list of available announcement files for a User from the Announcement Repository,
        /// for Virtual subscribers the list will also include the announcements for it's group.
        /// 
        /// The response is either a UserAnnouncementFileGetAvailableListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserAnnouncementFileGetAvailableListResponse> UserAnnouncementFileGetAvailableListRequestAsync(this OcipClient client, UserAnnouncementFileGetAvailableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAnnouncementFileGetAvailableListResponse;
        }
        /// <summary>
        /// Get the list of announcement names with associated media type and filesize for a User and
        /// given Announcement Repository Type
        /// The response is either a UserAnnouncementFileGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAnnouncementFileGetListRequestAsync instead.")]
        public static async Task<UserAnnouncementFileGetListResponse> UserAnnouncementFileGetListRequest(this OcipClient client, UserAnnouncementFileGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAnnouncementFileGetListResponse;
        }

        /// <summary>
        /// Get the list of announcement names with associated media type and filesize for a User and
        /// given Announcement Repository Type
        /// The response is either a UserAnnouncementFileGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserAnnouncementFileGetListResponse> UserAnnouncementFileGetListRequestAsync(this OcipClient client, UserAnnouncementFileGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAnnouncementFileGetListResponse;
        }
        /// <summary>
        /// Get the list of announcement files for a user.
        /// If the responsePagingControl element is not provided,
        /// the paging startIndex will be set to 1 by default,
        /// and the responsePageSize will be set to the maximum responsePageSize by
        /// default.
        /// If no sortOrder is provided, the response is sorted by Name ascending by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// The response is either a UserAnnouncementFileGetPagedSortedListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAnnouncementFileGetPagedSortedListRequestAsync instead.")]
        public static async Task<UserAnnouncementFileGetPagedSortedListResponse> UserAnnouncementFileGetPagedSortedListRequest(this OcipClient client, UserAnnouncementFileGetPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAnnouncementFileGetPagedSortedListResponse;
        }

        /// <summary>
        /// Get the list of announcement files for a user.
        /// If the responsePagingControl element is not provided,
        /// the paging startIndex will be set to 1 by default,
        /// and the responsePageSize will be set to the maximum responsePageSize by
        /// default.
        /// If no sortOrder is provided, the response is sorted by Name ascending by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// The response is either a UserAnnouncementFileGetPagedSortedListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserAnnouncementFileGetPagedSortedListResponse> UserAnnouncementFileGetPagedSortedListRequestAsync(this OcipClient client, UserAnnouncementFileGetPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAnnouncementFileGetPagedSortedListResponse;
        }
        /// <summary>
        /// Request to get the announcement repository file information.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// announcementFileExternalId
        /// 
        /// The response is either UserAnnouncementFileGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAnnouncementFileGetRequest22Async instead.")]
        public static async Task<UserAnnouncementFileGetResponse22> UserAnnouncementFileGetRequest22(this OcipClient client, UserAnnouncementFileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAnnouncementFileGetResponse22;
        }

        /// <summary>
        /// Request to get the announcement repository file information.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// announcementFileExternalId
        /// 
        /// The response is either UserAnnouncementFileGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<UserAnnouncementFileGetResponse22> UserAnnouncementFileGetRequest22Async(this OcipClient client, UserAnnouncementFileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAnnouncementFileGetResponse22;
        }
        /// <summary>
        /// This command is used to change the name of the file or upload a new announcement file for
        /// an existing announcement in the user repository.
        /// When modifying the file type the command will fail if the media type of the new file changes
        /// the announcement from audio to video (or vice versa).
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// announcementFileExternalId
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAnnouncementFileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserAnnouncementFileModifyRequest(this OcipClient client, UserAnnouncementFileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// This command is used to change the name of the file or upload a new announcement file for
        /// an existing announcement in the user repository.
        /// When modifying the file type the command will fail if the media type of the new file changes
        /// the announcement from audio to video (or vice versa).
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// announcementFileExternalId
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAnnouncementFileModifyRequestAsync(this OcipClient client, UserAnnouncementFileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Return the disk space being used.
        /// The response is either a UserAnnouncementRepositoryGetSettingsResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAnnouncementRepositoryGetSettingsRequestAsync instead.")]
        public static async Task<UserAnnouncementRepositoryGetSettingsResponse> UserAnnouncementRepositoryGetSettingsRequest(this OcipClient client, UserAnnouncementRepositoryGetSettingsRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAnnouncementRepositoryGetSettingsResponse;
        }

        /// <summary>
        /// Return the disk space being used.
        /// The response is either a UserAnnouncementRepositoryGetSettingsResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserAnnouncementRepositoryGetSettingsResponse> UserAnnouncementRepositoryGetSettingsRequestAsync(this OcipClient client, UserAnnouncementRepositoryGetSettingsRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAnnouncementRepositoryGetSettingsResponse;
        }
        /// <summary>
        /// Get the list of assigned User and Group Services for the specified user.
        /// The response is either an UserAssignedServicesGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAssignedServicesGetListRequestAsync instead.")]
        public static async Task<UserAssignedServicesGetListResponse> UserAssignedServicesGetListRequest(this OcipClient client, UserAssignedServicesGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAssignedServicesGetListResponse;
        }

        /// <summary>
        /// Get the list of assigned User and Group Services for the specified user.
        /// The response is either an UserAssignedServicesGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserAssignedServicesGetListResponse> UserAssignedServicesGetListRequestAsync(this OcipClient client, UserAssignedServicesGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAssignedServicesGetListResponse;
        }
        /// <summary>
        /// Clear a user's call logs associated with Basic Call Logs and Enhanced
        /// Call Logs features. The calls logs are deleted from both Basic Call Logs
        /// and Enhanced Call Logs if both features are assigned.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallLogsClearRequest14sp4Async instead.")]
        public static async Task<SuccessResponse> UserCallLogsClearRequest14sp4(this OcipClient client, UserCallLogsClearRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Clear a user's call logs associated with Basic Call Logs and Enhanced
        /// Call Logs features. The calls logs are deleted from both Basic Call Logs
        /// and Enhanced Call Logs if both features are assigned.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallLogsClearRequest14sp4Async(this OcipClient client, UserCallLogsClearRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Call Policies.
        /// The response is either a UserCallPoliciesGetResponse19sp1
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallPoliciesGetRequest19sp1Async instead.")]
        public static async Task<UserCallPoliciesGetResponse19sp1> UserCallPoliciesGetRequest19sp1(this OcipClient client, UserCallPoliciesGetRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallPoliciesGetResponse19sp1;
        }

        /// <summary>
        /// Request the user level data associated with Call Policies.
        /// The response is either a UserCallPoliciesGetResponse19sp1
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallPoliciesGetResponse19sp1> UserCallPoliciesGetRequest19sp1Async(this OcipClient client, UserCallPoliciesGetRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallPoliciesGetResponse19sp1;
        }
        /// <summary>
        /// Modify the user level data associated with Call Policies.
        /// The following elements are only used in AS data mode:
        /// callingLineIdentityForRedirectedCalls
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallPoliciesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallPoliciesModifyRequest(this OcipClient client, UserCallPoliciesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Call Policies.
        /// The following elements are only used in AS data mode:
        /// callingLineIdentityForRedirectedCalls
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallPoliciesModifyRequestAsync(this OcipClient client, UserCallPoliciesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse22V2 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallProcessingGetPolicyRequest22V2Async instead.")]
        public static async Task<UserCallProcessingGetPolicyResponse22V2> UserCallProcessingGetPolicyRequest22V2(this OcipClient client, UserCallProcessingGetPolicyRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallProcessingGetPolicyResponse22V2;
        }

        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse22V2 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallProcessingGetPolicyResponse22V2> UserCallProcessingGetPolicyRequest22V2Async(this OcipClient client, UserCallProcessingGetPolicyRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallProcessingGetPolicyResponse22V2;
        }
        /// <summary>
        /// Modify the user level data associated with Call Processing Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The useUserCLIDSetting attribute controls the CLID settings
        /// (clidPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowConfigurableCLIDForRedirectingIdentity, allowDepartmentCLIDNameOverride)
        /// 
        /// The useUserMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// 
        /// The useUserCallLimitsSetting attribute controls the Call Limits setting
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls, useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls, maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls,
        /// useMaxFindMeFollowMeDepth, maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations,
        /// useMaxConcurrentTerminatingAlertingRequests, maxConcurrentTerminatingAlertingRequests,
        /// includeRedirectionsInMaximumNumberOfConcurrentCalls)
        /// 
        /// The useUserDCLIDSetting controls the Dialable Caller ID settings (enableDialableCallerID)
        /// 
        /// The useUserPhoneListLookupSetting controls the Caller ID Lookup settings (enablePhoneListLookup)
        /// 
        /// The useUserTranslationRoutingSetting attribute controls the routing and translation settings (routeOverrideDomain, routeOverridePrefix)
        /// 
        /// The following elements are only used in AS data mode:
        /// useUserDCLIDSetting
        /// enableDialableCallerID
        /// allowConfigurableCLIDForRedirectingIdentity
        /// allowDepartmentCLIDNameOverride
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useUserPhoneListLookupSetting
        /// enablePhoneListLookup
        /// useMaxConcurrentTerminatingAlertingRequests
        /// maxConcurrentTerminatingAlertingRequests
        /// includeRedirectionsInMaximumNumberOfConcurrentCalls
        /// allowMobileDNForRedirectingIdentity
        /// 
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// useUserTranslationRoutingSetting
        /// routeOverrideDomain
        /// routeOverridePrefix
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallProcessingModifyPolicyRequest14sp7Async instead.")]
        public static async Task<SuccessResponse> UserCallProcessingModifyPolicyRequest14sp7(this OcipClient client, UserCallProcessingModifyPolicyRequest14sp7 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Call Processing Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The useUserCLIDSetting attribute controls the CLID settings
        /// (clidPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowConfigurableCLIDForRedirectingIdentity, allowDepartmentCLIDNameOverride)
        /// 
        /// The useUserMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// 
        /// The useUserCallLimitsSetting attribute controls the Call Limits setting
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls, useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls, maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls,
        /// useMaxFindMeFollowMeDepth, maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations,
        /// useMaxConcurrentTerminatingAlertingRequests, maxConcurrentTerminatingAlertingRequests,
        /// includeRedirectionsInMaximumNumberOfConcurrentCalls)
        /// 
        /// The useUserDCLIDSetting controls the Dialable Caller ID settings (enableDialableCallerID)
        /// 
        /// The useUserPhoneListLookupSetting controls the Caller ID Lookup settings (enablePhoneListLookup)
        /// 
        /// The useUserTranslationRoutingSetting attribute controls the routing and translation settings (routeOverrideDomain, routeOverridePrefix)
        /// 
        /// The following elements are only used in AS data mode:
        /// useUserDCLIDSetting
        /// enableDialableCallerID
        /// allowConfigurableCLIDForRedirectingIdentity
        /// allowDepartmentCLIDNameOverride
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useUserPhoneListLookupSetting
        /// enablePhoneListLookup
        /// useMaxConcurrentTerminatingAlertingRequests
        /// maxConcurrentTerminatingAlertingRequests
        /// includeRedirectionsInMaximumNumberOfConcurrentCalls
        /// allowMobileDNForRedirectingIdentity
        /// 
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// useUserTranslationRoutingSetting
        /// routeOverrideDomain
        /// routeOverridePrefix
        /// </summary>
        public static async Task<SuccessResponse> UserCallProcessingModifyPolicyRequest14sp7Async(this OcipClient client, UserCallProcessingModifyPolicyRequest14sp7 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a list of Communication Barring Authorization codes to a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCommunicationBarringAuthorizationCodeAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCommunicationBarringAuthorizationCodeAddListRequest(this OcipClient client, UserCommunicationBarringAuthorizationCodeAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of Communication Barring Authorization codes to a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCommunicationBarringAuthorizationCodeAddListRequestAsync(this OcipClient client, UserCommunicationBarringAuthorizationCodeAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of Communication Barring Authorization codes from a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCommunicationBarringAuthorizationCodeDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCommunicationBarringAuthorizationCodeDeleteListRequest(this OcipClient client, UserCommunicationBarringAuthorizationCodeDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of Communication Barring Authorization codes from a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCommunicationBarringAuthorizationCodeDeleteListRequestAsync(this OcipClient client, UserCommunicationBarringAuthorizationCodeDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Communication Barring Authorization Code for a user.
        /// The response is either a UserCommunicationBarringAuthorizationCodeGetListResponse
        /// or an ErorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCommunicationBarringAuthorizationCodeGetListRequestAsync instead.")]
        public static async Task<UserCommunicationBarringAuthorizationCodeGetListResponse> UserCommunicationBarringAuthorizationCodeGetListRequest(this OcipClient client, UserCommunicationBarringAuthorizationCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCommunicationBarringAuthorizationCodeGetListResponse;
        }

        /// <summary>
        /// Get a list of Communication Barring Authorization Code for a user.
        /// The response is either a UserCommunicationBarringAuthorizationCodeGetListResponse
        /// or an ErorResponse.
        /// </summary>
        public static async Task<UserCommunicationBarringAuthorizationCodeGetListResponse> UserCommunicationBarringAuthorizationCodeGetListRequestAsync(this OcipClient client, UserCommunicationBarringAuthorizationCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCommunicationBarringAuthorizationCodeGetListResponse;
        }
        /// <summary>
        /// Gets the Communication Barring settings for a user.
        /// The response is either a UserCommunicationBarringGetResponse or an ErrorResponse.
        /// This command only applies to groups in an Enterprise. This command will fail for groups in a Service Provider.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCommunicationBarringGetRequestAsync instead.")]
        public static async Task<UserCommunicationBarringGetResponse> UserCommunicationBarringGetRequest(this OcipClient client, UserCommunicationBarringGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCommunicationBarringGetResponse;
        }

        /// <summary>
        /// Gets the Communication Barring settings for a user.
        /// The response is either a UserCommunicationBarringGetResponse or an ErrorResponse.
        /// This command only applies to groups in an Enterprise. This command will fail for groups in a Service Provider.
        /// </summary>
        public static async Task<UserCommunicationBarringGetResponse> UserCommunicationBarringGetRequestAsync(this OcipClient client, UserCommunicationBarringGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCommunicationBarringGetResponse;
        }
        /// <summary>
        /// Modify the Communication Barring settings for a user. If useDefaultServiceProviderProfile is set to false, a profile name must be present.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// This command only applies to groups in an Enterprise. This command will fail for groups in a Service Provider.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCommunicationBarringModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCommunicationBarringModifyRequest(this OcipClient client, UserCommunicationBarringModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Communication Barring settings for a user. If useDefaultServiceProviderProfile is set to false, a profile name must be present.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// This command only applies to groups in an Enterprise. This command will fail for groups in a Service Provider.
        /// </summary>
        public static async Task<SuccessResponse> UserCommunicationBarringModifyRequestAsync(this OcipClient client, UserCommunicationBarringModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// In AS and Amplify  Data Mode:
        /// The group user limit will be increased by one if needed.
        /// 
        /// The group will be added if it does not exist and if the command is executed by a Service
        /// Provider level administrator or above. If the group needs to be created, the
        /// groupProperties element must be set or the request will fail.
        /// The groupProperties element will be ignored if the group already exists.
        /// 
        /// If the domain has not been assigned to the group, it will be added to group if the
        /// command is executed by a Service provider level administrator or above.
        /// If the domain has not been assigned to the service provider, it will be added to the
        /// service provider if the command is executed by a Provisioning level administrator or
        /// above. The command will fail otherwise.
        /// 
        /// If the phoneNumber has not been assigned to the group and addPhoneNumberToGroup is set
        /// to true, it will be added to group if the command is executed by a service provider
        /// administrator or above and the number is already assigned to the service provider. The
        /// command will fail otherwise.
        /// 
        /// The password is not required if external authentication is enabled.
        /// Alternate user ids can be added by a group level administrator or above.
        /// 
        /// When sharedCallAppearanceAccessDeviceEndpoint element is included and the Shared Call
        /// Appearance is not included in the service/service pack of the request or in the
        /// "new user template", the request will fail.
        /// 
        /// The userService/servicePack will be authorized to the group if it has not been
        /// authorized to the group if the command is executed by a Service Provider level
        /// administrator or above. The command will fail otherwise.
        /// The authorizedQuantity will be set to unlimited if not present.
        /// 
        /// When thirdPartyVoiceMail elements are included and the Third Party Voice Mail Support
        /// service is not included in the service/service pack of the request or in the
        /// "new user template", the request will fail.
        /// 
        /// When sipAuthenticationData element is included and the Authentication service is not
        /// included in the service/service pack of the request or in the "new user template",
        /// the request will fail.
        /// 
        /// 
        /// In XS data mode:
        /// only the System level administrator has the authorization level to execute the command.
        /// The group will be added if it does not exist. If the group needs to be created, the
        /// groupProperties element must be set or the request will fail.
        /// The groupProperties element will be ignored if the group already exists.
        /// 
        /// If the phoneNumber has not been assigned to the group, it will be added to group and
        /// service provider if needed.
        /// 
        /// When sharedCallAppearanceAccessDeviceEndpoint element is included and the Shared
        /// Call Appearance is not included in the service/service pack of the request, the request
        /// will fail.
        /// 
        /// The following elements are ignored in XS data mode:
        /// addPhoneNumberToGroup
        /// nameDialingName
        /// alternateUserId
        /// passcode
        /// trunkAddressing
        /// thirdPartyVoiceMailServerSelection
        /// thirdPartyVoiceMailServerUserServer
        /// thirdPartyVoiceMailServerMailboxIdType
        /// thirdPartyVoiceMailMailboxURL
        /// sipAuthenticationData
        /// </summary>
        [Obsolete("This method is deprecated. Use UserConsolidatedAddRequest22Async instead.")]
        public static async Task<SuccessResponse> UserConsolidatedAddRequest22(this OcipClient client, UserConsolidatedAddRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// In AS and Amplify  Data Mode:
        /// The group user limit will be increased by one if needed.
        /// 
        /// The group will be added if it does not exist and if the command is executed by a Service
        /// Provider level administrator or above. If the group needs to be created, the
        /// groupProperties element must be set or the request will fail.
        /// The groupProperties element will be ignored if the group already exists.
        /// 
        /// If the domain has not been assigned to the group, it will be added to group if the
        /// command is executed by a Service provider level administrator or above.
        /// If the domain has not been assigned to the service provider, it will be added to the
        /// service provider if the command is executed by a Provisioning level administrator or
        /// above. The command will fail otherwise.
        /// 
        /// If the phoneNumber has not been assigned to the group and addPhoneNumberToGroup is set
        /// to true, it will be added to group if the command is executed by a service provider
        /// administrator or above and the number is already assigned to the service provider. The
        /// command will fail otherwise.
        /// 
        /// The password is not required if external authentication is enabled.
        /// Alternate user ids can be added by a group level administrator or above.
        /// 
        /// When sharedCallAppearanceAccessDeviceEndpoint element is included and the Shared Call
        /// Appearance is not included in the service/service pack of the request or in the
        /// "new user template", the request will fail.
        /// 
        /// The userService/servicePack will be authorized to the group if it has not been
        /// authorized to the group if the command is executed by a Service Provider level
        /// administrator or above. The command will fail otherwise.
        /// The authorizedQuantity will be set to unlimited if not present.
        /// 
        /// When thirdPartyVoiceMail elements are included and the Third Party Voice Mail Support
        /// service is not included in the service/service pack of the request or in the
        /// "new user template", the request will fail.
        /// 
        /// When sipAuthenticationData element is included and the Authentication service is not
        /// included in the service/service pack of the request or in the "new user template",
        /// the request will fail.
        /// 
        /// 
        /// In XS data mode:
        /// only the System level administrator has the authorization level to execute the command.
        /// The group will be added if it does not exist. If the group needs to be created, the
        /// groupProperties element must be set or the request will fail.
        /// The groupProperties element will be ignored if the group already exists.
        /// 
        /// If the phoneNumber has not been assigned to the group, it will be added to group and
        /// service provider if needed.
        /// 
        /// When sharedCallAppearanceAccessDeviceEndpoint element is included and the Shared
        /// Call Appearance is not included in the service/service pack of the request, the request
        /// will fail.
        /// 
        /// The following elements are ignored in XS data mode:
        /// addPhoneNumberToGroup
        /// nameDialingName
        /// alternateUserId
        /// passcode
        /// trunkAddressing
        /// thirdPartyVoiceMailServerSelection
        /// thirdPartyVoiceMailServerUserServer
        /// thirdPartyVoiceMailServerMailboxIdType
        /// thirdPartyVoiceMailMailboxURL
        /// sipAuthenticationData
        /// </summary>
        public static async Task<SuccessResponse> UserConsolidatedAddRequest22Async(this OcipClient client, UserConsolidatedAddRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a user.
        /// 
        /// If deleteExistingDevices is set to true, after the user is deleted, any device that is only used by the deleted user prior to the deletion will be deleted if the command is executed with the correct priviledge.
        /// Group administrator or above running this command can delete any group level devices. Service provider administrator or above can delete any service provider and group devices. Provisioning administrator or above can delete any devices.
        /// An ErrorResponse will be returned if any device cannot be deleted because of insufficient privilege.
        /// 
        /// If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group if the command is executed by a service provider administrator or above.
        /// When set to 'Service Provider', they will be un-assigned from the group and service provider if the command is executed by a provisioning administrator or above.
        /// When omitted, the number(s) will be left assigned to the group.
        /// An ErrorResponse will be returned if any number cannot be unassigned because of insufficient privilege.
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserConsolidatedDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> UserConsolidatedDeleteRequest(this OcipClient client, UserConsolidatedDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a user.
        /// 
        /// If deleteExistingDevices is set to true, after the user is deleted, any device that is only used by the deleted user prior to the deletion will be deleted if the command is executed with the correct priviledge.
        /// Group administrator or above running this command can delete any group level devices. Service provider administrator or above can delete any service provider and group devices. Provisioning administrator or above can delete any devices.
        /// An ErrorResponse will be returned if any device cannot be deleted because of insufficient privilege.
        /// 
        /// If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group if the command is executed by a service provider administrator or above.
        /// When set to 'Service Provider', they will be un-assigned from the group and service provider if the command is executed by a provisioning administrator or above.
        /// When omitted, the number(s) will be left assigned to the group.
        /// An ErrorResponse will be returned if any number cannot be unassigned because of insufficient privilege.
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserConsolidatedDeleteRequestAsync(this OcipClient client, UserConsolidatedDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a user.
        /// 
        /// If deleteExistingDevices is set to true, when the devices for the main endpoint or SCA service are changed, devices with no more endpoint will be deleted if the command is executed with the correct privilege.
        /// Group administrator or above running this command can delete any group level devices.
        /// Service provider administrator or above can delete any service provider and group devices.
        /// Provisioning administrator or above can delete any devices.
        /// An ErrorResponse will be returned if any device cannot be deleted because of insufficient privilege.
        /// 
        /// When phone numbers are un-assigned from the user, the unused numbers may be un-assigned from the group and service provider. If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group if the command is executed by a service provider administrator or above.
        /// When set to 'Service Provider', they will be un-assigned from the group and service provider if the command is executed by a provisioning administrator or above.
        /// When omitted, the number(s) will be left assigned to the group.
        /// An ErrorResponse will be returned if any number cannot be unassigned because of insufficient privilege.
        /// 
        /// If the phoneNumber has not been assigned to the group and addPhoneNumberToGroup is set to true, it will be added to group if needed if the command is executed by a service provider administrator and above. The command will fail otherwise.
        /// 
        /// Alternate user ids can be added by a group level administrator or above.
        /// 
        /// The password is not required if external authentication is enabled.
        /// When sharedCallAppearanceAccessDeviceEndpoint element is included and the Shared Call Appearance service is not assigned after this request, the request will fail.
        /// 
        /// The userService/servicePackwill be authorized to the group if it has not been authorized to the group and the command is excuted by a service provider administrator. The request will fail otherwise.
        /// If not present, the authorizedQuantity will be set to unlimited if allowed.
        /// 
        /// If any of the third party voice mail elements are included but the service is not assigned after this request, the request will fail.
        /// 
        /// If the sip authentication elements are included but the SPI Authentication service is not assigned after this request, the request will fail.
        /// 
        /// If the impPassword element is included but the Integrated IMP service is not assigned after this request, the request will fail.
        /// 
        /// 
        /// The following elements are ignored in XS data mode:
        /// nameDialingName
        /// alternateUserIdList
        /// passcode
        /// trunkAddressing
        /// thirdPartyVoiceMailServerSelection
        /// thirdPartyVoiceMailServerUserServer
        /// thirdPartyVoiceMailServerMailboxIdType
        /// thirdPartyVoiceMailMailboxURL
        /// sipAuthenticationData
        /// newUserExternalId
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserConsolidatedModifyRequest22Async instead.")]
        public static async Task<SuccessResponse> UserConsolidatedModifyRequest22(this OcipClient client, UserConsolidatedModifyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a user.
        /// 
        /// If deleteExistingDevices is set to true, when the devices for the main endpoint or SCA service are changed, devices with no more endpoint will be deleted if the command is executed with the correct privilege.
        /// Group administrator or above running this command can delete any group level devices.
        /// Service provider administrator or above can delete any service provider and group devices.
        /// Provisioning administrator or above can delete any devices.
        /// An ErrorResponse will be returned if any device cannot be deleted because of insufficient privilege.
        /// 
        /// When phone numbers are un-assigned from the user, the unused numbers may be un-assigned from the group and service provider. If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group if the command is executed by a service provider administrator or above.
        /// When set to 'Service Provider', they will be un-assigned from the group and service provider if the command is executed by a provisioning administrator or above.
        /// When omitted, the number(s) will be left assigned to the group.
        /// An ErrorResponse will be returned if any number cannot be unassigned because of insufficient privilege.
        /// 
        /// If the phoneNumber has not been assigned to the group and addPhoneNumberToGroup is set to true, it will be added to group if needed if the command is executed by a service provider administrator and above. The command will fail otherwise.
        /// 
        /// Alternate user ids can be added by a group level administrator or above.
        /// 
        /// The password is not required if external authentication is enabled.
        /// When sharedCallAppearanceAccessDeviceEndpoint element is included and the Shared Call Appearance service is not assigned after this request, the request will fail.
        /// 
        /// The userService/servicePackwill be authorized to the group if it has not been authorized to the group and the command is excuted by a service provider administrator. The request will fail otherwise.
        /// If not present, the authorizedQuantity will be set to unlimited if allowed.
        /// 
        /// If any of the third party voice mail elements are included but the service is not assigned after this request, the request will fail.
        /// 
        /// If the sip authentication elements are included but the SPI Authentication service is not assigned after this request, the request will fail.
        /// 
        /// If the impPassword element is included but the Integrated IMP service is not assigned after this request, the request will fail.
        /// 
        /// 
        /// The following elements are ignored in XS data mode:
        /// nameDialingName
        /// alternateUserIdList
        /// passcode
        /// trunkAddressing
        /// thirdPartyVoiceMailServerSelection
        /// thirdPartyVoiceMailServerUserServer
        /// thirdPartyVoiceMailServerMailboxIdType
        /// thirdPartyVoiceMailMailboxURL
        /// sipAuthenticationData
        /// newUserExternalId
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserConsolidatedModifyRequest22Async(this OcipClient client, UserConsolidatedModifyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a user.  The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> UserDeleteRequest(this OcipClient client, UserDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a user.  The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserDeleteRequestAsync(this OcipClient client, UserDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the Device Activation policies in effect for the user.
        /// The response is either a UserDeviceActivationPolicyInEffectGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserDeviceActivationPolicyInEffectGetRequestAsync instead.")]
        public static async Task<UserDeviceActivationPolicyInEffectGetResponse> UserDeviceActivationPolicyInEffectGetRequest(this OcipClient client, UserDeviceActivationPolicyInEffectGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserDeviceActivationPolicyInEffectGetResponse;
        }

        /// <summary>
        /// Request the Device Activation policies in effect for the user.
        /// The response is either a UserDeviceActivationPolicyInEffectGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserDeviceActivationPolicyInEffectGetResponse> UserDeviceActivationPolicyInEffectGetRequestAsync(this OcipClient client, UserDeviceActivationPolicyInEffectGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserDeviceActivationPolicyInEffectGetResponse;
        }
        /// <summary>
        /// Request the user level data associated with Device Policy.
        /// The response is either a UserDevicePoliciesGetResponse21 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserDevicePoliciesGetRequest21Async instead.")]
        public static async Task<UserDevicePoliciesGetResponse21> UserDevicePoliciesGetRequest21(this OcipClient client, UserDevicePoliciesGetRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserDevicePoliciesGetResponse21;
        }

        /// <summary>
        /// Request the user level data associated with Device Policy.
        /// The response is either a UserDevicePoliciesGetResponse21 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserDevicePoliciesGetResponse21> UserDevicePoliciesGetRequest21Async(this OcipClient client, UserDevicePoliciesGetRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserDevicePoliciesGetResponse21;
        }
        /// <summary>
        /// Modify the user level data associated with Device Policy. enableDeviceFeatureSynchronization and enableCallDecline can be
        /// configured by the admin regardless of lineMode, but is ignored by the application server in Multiple User Shared mode.
        /// 
        /// enableCallDecline can be modified by the user when the admin has set the mode to ‘Single User Private and Shared Lines mode’.
        /// This is the only element that the user can modify. In XS data mode,  the lineMode is ignored and enabledCallDecline is the only element that can be configured.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// lineMode
        /// enableDeviceFeatureSynchronization
        /// enableDnd
        /// enableCallForwardingAlways
        /// enableCallForwardingBusy
        /// enableCallForwardingNoAnswer
        /// enableAcd
        /// enableExecutive
        /// enableExecutiveAssistant
        /// enableSecurityClassification
        /// enableCallRecording
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserDevicePoliciesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserDevicePoliciesModifyRequest(this OcipClient client, UserDevicePoliciesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Device Policy. enableDeviceFeatureSynchronization and enableCallDecline can be
        /// configured by the admin regardless of lineMode, but is ignored by the application server in Multiple User Shared mode.
        /// 
        /// enableCallDecline can be modified by the user when the admin has set the mode to ‘Single User Private and Shared Lines mode’.
        /// This is the only element that the user can modify. In XS data mode,  the lineMode is ignored and enabledCallDecline is the only element that can be configured.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// lineMode
        /// enableDeviceFeatureSynchronization
        /// enableDnd
        /// enableCallForwardingAlways
        /// enableCallForwardingBusy
        /// enableCallForwardingNoAnswer
        /// enableAcd
        /// enableExecutive
        /// enableExecutiveAssistant
        /// enableSecurityClassification
        /// enableCallRecording
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserDevicePoliciesModifyRequestAsync(this OcipClient client, UserDevicePoliciesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of DNs associated with a user and their activation state.
        /// The response is either UserDnGetActivationListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserDnGetActivationListRequestAsync instead.")]
        public static async Task<UserDnGetActivationListResponse> UserDnGetActivationListRequest(this OcipClient client, UserDnGetActivationListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserDnGetActivationListResponse;
        }

        /// <summary>
        /// Request to get a list of DNs associated with a user and their activation state.
        /// The response is either UserDnGetActivationListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserDnGetActivationListResponse> UserDnGetActivationListRequestAsync(this OcipClient client, UserDnGetActivationListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserDnGetActivationListResponse;
        }
        /// <summary>
        /// Get an enterprise's common phone list for a user.
        /// The response is either a UserEnterpriseCommonPhoneListGetPagedSortedListResponse
        /// or an ErrorResponse.
        /// The search can be done using multiple criterion.
        /// If the searchCriteriaModeOr is present, any result matching any one
        /// criteria is included in the results.
        /// Otherwise, only results matching all the search criterion are included in the
        /// results.
        /// If no search criteria is specified, all results are returned.
        /// Specifying searchCriteriaModeOr without any search criteria results
        /// in an ErrorResponse.
        /// The sort can be done on the name or the number in the common phone list.
        /// The following elements are only used in AS data mode and ignored in XS data
        /// mode:
        /// searchCriteriaEnterpriseCommonMultiPartPhoneListName
        /// </summary>
        [Obsolete("This method is deprecated. Use UserEnterpriseCommonPhoneListGetPagedSortedListRequestAsync instead.")]
        public static async Task<UserEnterpriseCommonPhoneListGetPagedSortedListResponse> UserEnterpriseCommonPhoneListGetPagedSortedListRequest(this OcipClient client, UserEnterpriseCommonPhoneListGetPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserEnterpriseCommonPhoneListGetPagedSortedListResponse;
        }

        /// <summary>
        /// Get an enterprise's common phone list for a user.
        /// The response is either a UserEnterpriseCommonPhoneListGetPagedSortedListResponse
        /// or an ErrorResponse.
        /// The search can be done using multiple criterion.
        /// If the searchCriteriaModeOr is present, any result matching any one
        /// criteria is included in the results.
        /// Otherwise, only results matching all the search criterion are included in the
        /// results.
        /// If no search criteria is specified, all results are returned.
        /// Specifying searchCriteriaModeOr without any search criteria results
        /// in an ErrorResponse.
        /// The sort can be done on the name or the number in the common phone list.
        /// The following elements are only used in AS data mode and ignored in XS data
        /// mode:
        /// searchCriteriaEnterpriseCommonMultiPartPhoneListName
        /// </summary>
        public static async Task<UserEnterpriseCommonPhoneListGetPagedSortedListResponse> UserEnterpriseCommonPhoneListGetPagedSortedListRequestAsync(this OcipClient client, UserEnterpriseCommonPhoneListGetPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserEnterpriseCommonPhoneListGetPagedSortedListResponse;
        }
        /// <summary>
        /// Get the list of feature access codes for a user.
        /// The response is either a UserFeatureAccessCodeGetListResponse20 or an ErrorResponse.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording Start".
        /// </summary>
        [Obsolete("This method is deprecated. Use UserFeatureAccessCodeGetListRequest21Async instead.")]
        public static async Task<UserFeatureAccessCodeGetListResponse20> UserFeatureAccessCodeGetListRequest21(this OcipClient client, UserFeatureAccessCodeGetListRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserFeatureAccessCodeGetListResponse20;
        }

        /// <summary>
        /// Get the list of feature access codes for a user.
        /// The response is either a UserFeatureAccessCodeGetListResponse20 or an ErrorResponse.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording Start".
        /// </summary>
        public static async Task<UserFeatureAccessCodeGetListResponse20> UserFeatureAccessCodeGetListRequest21Async(this OcipClient client, UserFeatureAccessCodeGetListRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserFeatureAccessCodeGetListResponse20;
        }
        /// <summary>
        /// Enable or disable a list of feature access codes for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserFeatureAccessCodeModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserFeatureAccessCodeModifyListRequest(this OcipClient client, UserFeatureAccessCodeModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Enable or disable a list of feature access codes for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserFeatureAccessCodeModifyListRequestAsync(this OcipClient client, UserFeatureAccessCodeModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of users in a group.
        /// The response is either a UserGetListInGroupPagedSortedListResponse or an ErrorResponse.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// A limitation to the search by DN activation exists when the Number Activation mode is set to
        /// Off. In this case DNs not assigned to users are never returned by queries with the
        /// "dnActivationSearchCriteria" included.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// 
        /// The following elements are used in AS data mode and ignored in XS data mode:
        /// groupExternalId
        /// </summary>
        [Obsolete("This method is deprecated. Use UserGetListInGroupPagedSortedListRequestAsync instead.")]
        public static async Task<UserGetListInGroupPagedSortedListResponse> UserGetListInGroupPagedSortedListRequest(this OcipClient client, UserGetListInGroupPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserGetListInGroupPagedSortedListResponse;
        }

        /// <summary>
        /// Request the list of users in a group.
        /// The response is either a UserGetListInGroupPagedSortedListResponse or an ErrorResponse.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// A limitation to the search by DN activation exists when the Number Activation mode is set to
        /// Off. In this case DNs not assigned to users are never returned by queries with the
        /// "dnActivationSearchCriteria" included.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// 
        /// The following elements are used in AS data mode and ignored in XS data mode:
        /// groupExternalId
        /// </summary>
        public static async Task<UserGetListInGroupPagedSortedListResponse> UserGetListInGroupPagedSortedListRequestAsync(this OcipClient client, UserGetListInGroupPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserGetListInGroupPagedSortedListResponse;
        }
        /// <summary>
        /// Request the list of users in a group.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a UserGetListInGroupResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserGetListInGroupRequestAsync instead.")]
        public static async Task<UserGetListInGroupResponse> UserGetListInGroupRequest(this OcipClient client, UserGetListInGroupRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserGetListInGroupResponse;
        }

        /// <summary>
        /// Request the list of users in a group.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a UserGetListInGroupResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserGetListInGroupResponse> UserGetListInGroupRequestAsync(this OcipClient client, UserGetListInGroupRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserGetListInGroupResponse;
        }
        /// <summary>
        /// Request the list of users in a service provider or enterprise.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// serviceProviderExternalId
        /// 
        /// The response is either a UserGetListInServiceProviderResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserGetListInServiceProviderRequestAsync instead.")]
        public static async Task<UserGetListInServiceProviderResponse> UserGetListInServiceProviderRequest(this OcipClient client, UserGetListInServiceProviderRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserGetListInServiceProviderResponse;
        }

        /// <summary>
        /// Request the list of users in a service provider or enterprise.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// serviceProviderExternalId
        /// 
        /// The response is either a UserGetListInServiceProviderResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserGetListInServiceProviderResponse> UserGetListInServiceProviderRequestAsync(this OcipClient client, UserGetListInServiceProviderRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserGetListInServiceProviderResponse;
        }
        /// <summary>
        /// Request the list of users in the system.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All the users
        /// in the administrator's reseller meeting the search criteria are returned.
        /// 
        /// The response is either a UserGetListInSystemResponse or an ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use UserGetListInSystemRequestAsync instead.")]
        public static async Task<UserGetListInSystemResponse> UserGetListInSystemRequest(this OcipClient client, UserGetListInSystemRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserGetListInSystemResponse;
        }

        /// <summary>
        /// Request the list of users in the system.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All the users
        /// in the administrator's reseller meeting the search criteria are returned.
        /// 
        /// The response is either a UserGetListInSystemResponse or an ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        public static async Task<UserGetListInSystemResponse> UserGetListInSystemRequestAsync(this OcipClient client, UserGetListInSystemRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserGetListInSystemResponse;
        }
        /// <summary>
        /// Request to get a list of registrations for a user.
        /// The response is either a UserGetRegistrationListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserGetRegistrationListRequestAsync instead.")]
        public static async Task<UserGetRegistrationListResponse> UserGetRegistrationListRequest(this OcipClient client, UserGetRegistrationListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserGetRegistrationListResponse;
        }

        /// <summary>
        /// Request to get a list of registrations for a user.
        /// The response is either a UserGetRegistrationListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserGetRegistrationListResponse> UserGetRegistrationListRequestAsync(this OcipClient client, UserGetRegistrationListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserGetRegistrationListResponse;
        }
        /// <summary>
        /// Request to get the user information.  The response is either UserGetResponse22V8 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserGetRequest22V8Async instead.")]
        public static async Task<UserGetResponse22V8> UserGetRequest22V8(this OcipClient client, UserGetRequest22V8 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserGetResponse22V8;
        }

        /// <summary>
        /// Request to get the user information.  The response is either UserGetResponse22V8 or ErrorResponse.
        /// </summary>
        public static async Task<UserGetResponse22V8> UserGetRequest22V8Async(this OcipClient client, UserGetRequest22V8 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserGetResponse22V8;
        }
        /// <summary>
        /// Request the list of Service Instances in a service provider or an enterprise.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together. searchCriteriaExactUserDepartment criteria is only applicable for an enterprise and is ignored if set for a service provider.
        /// The response is either a UserGetServiceInstanceListInServiceProviderResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserGetServiceInstanceListInServiceProviderRequestAsync instead.")]
        public static async Task<UserGetServiceInstanceListInServiceProviderResponse> UserGetServiceInstanceListInServiceProviderRequest(this OcipClient client, UserGetServiceInstanceListInServiceProviderRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserGetServiceInstanceListInServiceProviderResponse;
        }

        /// <summary>
        /// Request the list of Service Instances in a service provider or an enterprise.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together. searchCriteriaExactUserDepartment criteria is only applicable for an enterprise and is ignored if set for a service provider.
        /// The response is either a UserGetServiceInstanceListInServiceProviderResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserGetServiceInstanceListInServiceProviderResponse> UserGetServiceInstanceListInServiceProviderRequestAsync(this OcipClient client, UserGetServiceInstanceListInServiceProviderRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserGetServiceInstanceListInServiceProviderResponse;
        }
        /// <summary>
        /// Request the list of Service Instances in the system.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All the service
        /// instances in the administrator's reseller meeting the search criteria are returned.
        /// 
        /// The response is either a UserGetServiceInstanceListInSystemResponse or an ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use UserGetServiceInstanceListInSystemRequestAsync instead.")]
        public static async Task<UserGetServiceInstanceListInSystemResponse> UserGetServiceInstanceListInSystemRequest(this OcipClient client, UserGetServiceInstanceListInSystemRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserGetServiceInstanceListInSystemResponse;
        }

        /// <summary>
        /// Request the list of Service Instances in the system.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All the service
        /// instances in the administrator's reseller meeting the search criteria are returned.
        /// 
        /// The response is either a UserGetServiceInstanceListInSystemResponse or an ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        public static async Task<UserGetServiceInstanceListInSystemResponse> UserGetServiceInstanceListInSystemRequestAsync(this OcipClient client, UserGetServiceInstanceListInSystemRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserGetServiceInstanceListInSystemResponse;
        }
        /// <summary>
        /// Get a user's group's common phone list.
        /// The response is either a UserGroupCommonPhoneListGetPagedSortedListResponse or an
        /// ErrorResponse.
        /// The search can be done using multiple criterion.
        /// If the searchCriteriaModeOr is present, any result matching any one
        /// criteria is included in the results.
        /// Otherwise, only results matching all the search criterion are included in the
        /// results.
        /// If no search criteria is specified, all results are returned.
        /// Specifying searchCriteriaModeOr without any search criteria results
        /// in an ErrorResponse.
        /// The sort can be done on the name or the number in the common phone list.
        /// The following elements are only used in AS data mode and ignored in XS data
        /// mode:
        /// searchCriteriaGroupCommonMultiPartPhoneListName
        /// </summary>
        [Obsolete("This method is deprecated. Use UserGroupCommonPhoneListGetPagedSortedListRequestAsync instead.")]
        public static async Task<UserGroupCommonPhoneListGetPagedSortedListResponse> UserGroupCommonPhoneListGetPagedSortedListRequest(this OcipClient client, UserGroupCommonPhoneListGetPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserGroupCommonPhoneListGetPagedSortedListResponse;
        }

        /// <summary>
        /// Get a user's group's common phone list.
        /// The response is either a UserGroupCommonPhoneListGetPagedSortedListResponse or an
        /// ErrorResponse.
        /// The search can be done using multiple criterion.
        /// If the searchCriteriaModeOr is present, any result matching any one
        /// criteria is included in the results.
        /// Otherwise, only results matching all the search criterion are included in the
        /// results.
        /// If no search criteria is specified, all results are returned.
        /// Specifying searchCriteriaModeOr without any search criteria results
        /// in an ErrorResponse.
        /// The sort can be done on the name or the number in the common phone list.
        /// The following elements are only used in AS data mode and ignored in XS data
        /// mode:
        /// searchCriteriaGroupCommonMultiPartPhoneListName
        /// </summary>
        public static async Task<UserGroupCommonPhoneListGetPagedSortedListResponse> UserGroupCommonPhoneListGetPagedSortedListRequestAsync(this OcipClient client, UserGroupCommonPhoneListGetPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserGroupCommonPhoneListGetPagedSortedListResponse;
        }
        /// <summary>
        /// Gets a Custom Contact Directory in a group.
        /// The response is either UserGroupCustomContactDirectoryGetPagedSortedListResponse
        /// or ErrorResponse.
        /// The search can be done using multiple criterion.
        /// If the searchCriteriaModeOr is present, any result matching any one
        /// criteria is included in the results.
        /// Otherwise, only results matching all the search criterion are included in the
        /// results.
        /// If no search criteria is specified, all results are returned.
        /// Specifying searchCriteriaModeOr without any search criteria results
        /// in an ErrorResponse.
        /// The sort can be done on the user last name, first name, department, or
        /// contact notes.  The Receptionist Note column is only populated, if the
        /// user sending the request is a the owner of this Receptionist Note and a Note
        /// exists.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserGroupCustomContactDirectoryGetPagedSortedListRequestAsync instead.")]
        public static async Task<UserGroupCustomContactDirectoryGetPagedSortedListResponse> UserGroupCustomContactDirectoryGetPagedSortedListRequest(this OcipClient client, UserGroupCustomContactDirectoryGetPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserGroupCustomContactDirectoryGetPagedSortedListResponse;
        }

        /// <summary>
        /// Gets a Custom Contact Directory in a group.
        /// The response is either UserGroupCustomContactDirectoryGetPagedSortedListResponse
        /// or ErrorResponse.
        /// The search can be done using multiple criterion.
        /// If the searchCriteriaModeOr is present, any result matching any one
        /// criteria is included in the results.
        /// Otherwise, only results matching all the search criterion are included in the
        /// results.
        /// If no search criteria is specified, all results are returned.
        /// Specifying searchCriteriaModeOr without any search criteria results
        /// in an ErrorResponse.
        /// The sort can be done on the user last name, first name, department, or
        /// contact notes.  The Receptionist Note column is only populated, if the
        /// user sending the request is a the owner of this Receptionist Note and a Note
        /// exists.
        /// </summary>
        public static async Task<UserGroupCustomContactDirectoryGetPagedSortedListResponse> UserGroupCustomContactDirectoryGetPagedSortedListRequestAsync(this OcipClient client, UserGroupCustomContactDirectoryGetPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserGroupCustomContactDirectoryGetPagedSortedListResponse;
        }
        /// <summary>
        /// Request to get all user's configured line ports.
        /// 
        /// The response is either a UserLinePortGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserLinePortGetListRequestAsync instead.")]
        public static async Task<UserLinePortGetListResponse> UserLinePortGetListRequest(this OcipClient client, UserLinePortGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserLinePortGetListResponse;
        }

        /// <summary>
        /// Request to get all user's configured line ports.
        /// 
        /// The response is either a UserLinePortGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserLinePortGetListResponse> UserLinePortGetListRequestAsync(this OcipClient client, UserLinePortGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserLinePortGetListResponse;
        }
        /// <summary>
        /// Move the user from one group to another group within the same enterprise.
        /// If evaluateOnly is specified, no actual move will happen. The command only tests the move and reports the impacts or possible conditions preventing the move.
        /// The response is either UserModifyGroupIdResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserModifyGroupIdRequestAsync instead.")]
        public static async Task<UserModifyGroupIdResponse> UserModifyGroupIdRequest(this OcipClient client, UserModifyGroupIdRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserModifyGroupIdResponse;
        }

        /// <summary>
        /// Move the user from one group to another group within the same enterprise.
        /// If evaluateOnly is specified, no actual move will happen. The command only tests the move and reports the impacts or possible conditions preventing the move.
        /// The response is either UserModifyGroupIdResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserModifyGroupIdResponse> UserModifyGroupIdRequestAsync(this OcipClient client, UserModifyGroupIdRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserModifyGroupIdResponse;
        }
        /// <summary>
        /// The following data elements are only used in AS data mode:
        /// contact[2]-contact[5]
        /// The following elements are only used in AS data mode and will fail in XS data mode:
        /// trunkAddressing
        /// newUserExternalId
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// nameDialingName
        /// alternateUserIdList
        /// newUserExternalId
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// allowVideo
        /// 
        /// The allowVideo element can only be used by a system administrator.
        /// 
        /// The impId and impPassword are accepted when the Third-Party IMP service is assigned to the user;
        /// when Integrated IMP service is assigned to the user and active, only the impPassword is accepted;
        /// all other cases, the request fails if either field is changed.
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserModifyRequest22Async instead.")]
        public static async Task<SuccessResponse> UserModifyRequest22(this OcipClient client, UserModifyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The following data elements are only used in AS data mode:
        /// contact[2]-contact[5]
        /// The following elements are only used in AS data mode and will fail in XS data mode:
        /// trunkAddressing
        /// newUserExternalId
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// nameDialingName
        /// alternateUserIdList
        /// newUserExternalId
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// allowVideo
        /// 
        /// The allowVideo element can only be used by a system administrator.
        /// 
        /// The impId and impPassword are accepted when the Third-Party IMP service is assigned to the user;
        /// when Integrated IMP service is assigned to the user and active, only the impPassword is accepted;
        /// all other cases, the request fails if either field is changed.
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserModifyRequest22Async(this OcipClient client, UserModifyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the user id of a real or virtual user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserModifyUserIdRequestAsync instead.")]
        public static async Task<SuccessResponse> UserModifyUserIdRequest(this OcipClient client, UserModifyUserIdRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user id of a real or virtual user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserModifyUserIdRequestAsync(this OcipClient client, UserModifyUserIdRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the Network-Based Conferencing data for a specified user.
        /// The response is either a UserNetworkConferencingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserNetworkConferencingGetRequestAsync instead.")]
        public static async Task<UserNetworkConferencingGetResponse> UserNetworkConferencingGetRequest(this OcipClient client, UserNetworkConferencingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserNetworkConferencingGetResponse;
        }

        /// <summary>
        /// Request the Network-Based Conferencing data for a specified user.
        /// The response is either a UserNetworkConferencingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserNetworkConferencingGetResponse> UserNetworkConferencingGetRequestAsync(this OcipClient client, UserNetworkConferencingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserNetworkConferencingGetResponse;
        }
        /// <summary>
        /// Get the OCI call control application list that can be used by the user.
        /// The response is either UserOCICallControlApplicationGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOCICallControlApplicationGetListRequestAsync instead.")]
        public static async Task<UserOCICallControlApplicationGetListResponse> UserOCICallControlApplicationGetListRequest(this OcipClient client, UserOCICallControlApplicationGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOCICallControlApplicationGetListResponse;
        }

        /// <summary>
        /// Get the OCI call control application list that can be used by the user.
        /// The response is either UserOCICallControlApplicationGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserOCICallControlApplicationGetListResponse> UserOCICallControlApplicationGetListRequestAsync(this OcipClient client, UserOCICallControlApplicationGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOCICallControlApplicationGetListResponse;
        }
        /// <summary>
        /// Modify which OCI Call Control Applications are enabled on a user
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOCICallControlApplicationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOCICallControlApplicationModifyRequest(this OcipClient client, UserOCICallControlApplicationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify which OCI Call Control Applications are enabled on a user
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOCICallControlApplicationModifyRequestAsync(this OcipClient client, UserOCICallControlApplicationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user's Web password information.
        /// The response is either a UserPasswordInfoGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPasswordInfoGetRequestAsync instead.")]
        public static async Task<UserPasswordInfoGetResponse> UserPasswordInfoGetRequest(this OcipClient client, UserPasswordInfoGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPasswordInfoGetResponse;
        }

        /// <summary>
        /// Request the user's Web password information.
        /// The response is either a UserPasswordInfoGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserPasswordInfoGetResponse> UserPasswordInfoGetRequestAsync(this OcipClient client, UserPasswordInfoGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPasswordInfoGetResponse;
        }
        /// <summary>
        /// Request the user level data associated with PBX Integration service.
        /// The response is either a UserPBXIntegrationGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPBXIntegrationGetRequestAsync instead.")]
        public static async Task<UserPBXIntegrationGetResponse> UserPBXIntegrationGetRequest(this OcipClient client, UserPBXIntegrationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPBXIntegrationGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with PBX Integration service.
        /// The response is either a UserPBXIntegrationGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserPBXIntegrationGetResponse> UserPBXIntegrationGetRequestAsync(this OcipClient client, UserPBXIntegrationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPBXIntegrationGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with PBX Integration service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPBXIntegrationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPBXIntegrationModifyRequest(this OcipClient client, UserPBXIntegrationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with PBX Integration service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPBXIntegrationModifyRequestAsync(this OcipClient client, UserPBXIntegrationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add one or more entries to a user's personal phone list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPersonalPhoneListAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPersonalPhoneListAddListRequest(this OcipClient client, UserPersonalPhoneListAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add one or more entries to a user's personal phone list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPersonalPhoneListAddListRequestAsync(this OcipClient client, UserPersonalPhoneListAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete one or more entries from a user's personal phone list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPersonalPhoneListDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPersonalPhoneListDeleteListRequest(this OcipClient client, UserPersonalPhoneListDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete one or more entries from a user's personal phone list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPersonalPhoneListDeleteListRequestAsync(this OcipClient client, UserPersonalPhoneListDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a user's personal phone list.
        /// The response is either a UserPersonalPhoneListGetListResponse or an ErrorResponse.
        /// The search can be done using multiple criterion.
        /// If the searchCriteriaModeOr is present, any result matching any one criteria is included in the results.
        /// Otherwise, only results matching all the search criterion are included in the results.
        /// If no search criteria is specified, all results are returned.
        /// Specifying searchCriteriaModeOr without any search criteria results in an ErrorResponse.
        /// In all cases, if a responseSizeLimit is specified and the number of matching results is more than this limit, then an
        /// ErrorResponse is returned.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPersonalPhoneListGetListRequestAsync instead.")]
        public static async Task<UserPersonalPhoneListGetListResponse> UserPersonalPhoneListGetListRequest(this OcipClient client, UserPersonalPhoneListGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPersonalPhoneListGetListResponse;
        }

        /// <summary>
        /// Get a user's personal phone list.
        /// The response is either a UserPersonalPhoneListGetListResponse or an ErrorResponse.
        /// The search can be done using multiple criterion.
        /// If the searchCriteriaModeOr is present, any result matching any one criteria is included in the results.
        /// Otherwise, only results matching all the search criterion are included in the results.
        /// If no search criteria is specified, all results are returned.
        /// Specifying searchCriteriaModeOr without any search criteria results in an ErrorResponse.
        /// In all cases, if a responseSizeLimit is specified and the number of matching results is more than this limit, then an
        /// ErrorResponse is returned.
        /// </summary>
        public static async Task<UserPersonalPhoneListGetListResponse> UserPersonalPhoneListGetListRequestAsync(this OcipClient client, UserPersonalPhoneListGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPersonalPhoneListGetListResponse;
        }
        /// <summary>
        /// Get a user's personal phone list.
        /// The response is either a UserPersonalPhoneListGetPagedSortedListResponse or an
        /// ErrorResponse.
        /// The search can be done using multiple criterion.
        /// If the searchCriteriaModeOr is present, any result matching any one
        /// criteria is included in the results.
        /// Otherwise, only results matching all the search criterion are included in the
        /// results.
        /// If no search criteria is specified, all results are returned.
        /// Specifying searchCriteriaModeOr without any search criteria results
        /// in an ErrorResponse.
        /// The sort can done by the personal phone list number or name.
        /// The following elements are only used in AS data mode and ignored in XS data
        /// mode:
        /// searchCriteriaUserPersonalMultiPartPhoneListName
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPersonalPhoneListGetPagedSortedListRequestAsync instead.")]
        public static async Task<UserPersonalPhoneListGetPagedSortedListResponse> UserPersonalPhoneListGetPagedSortedListRequest(this OcipClient client, UserPersonalPhoneListGetPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPersonalPhoneListGetPagedSortedListResponse;
        }

        /// <summary>
        /// Get a user's personal phone list.
        /// The response is either a UserPersonalPhoneListGetPagedSortedListResponse or an
        /// ErrorResponse.
        /// The search can be done using multiple criterion.
        /// If the searchCriteriaModeOr is present, any result matching any one
        /// criteria is included in the results.
        /// Otherwise, only results matching all the search criterion are included in the
        /// results.
        /// If no search criteria is specified, all results are returned.
        /// Specifying searchCriteriaModeOr without any search criteria results
        /// in an ErrorResponse.
        /// The sort can done by the personal phone list number or name.
        /// The following elements are only used in AS data mode and ignored in XS data
        /// mode:
        /// searchCriteriaUserPersonalMultiPartPhoneListName
        /// </summary>
        public static async Task<UserPersonalPhoneListGetPagedSortedListResponse> UserPersonalPhoneListGetPagedSortedListRequestAsync(this OcipClient client, UserPersonalPhoneListGetPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPersonalPhoneListGetPagedSortedListResponse;
        }
        /// <summary>
        /// Modify an entry in a user's personal phone list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPersonalPhoneListModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPersonalPhoneListModifyRequest(this OcipClient client, UserPersonalPhoneListModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an entry in a user's personal phone list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPersonalPhoneListModifyRequestAsync(this OcipClient client, UserPersonalPhoneListModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a table containing the phone directory for a user's group.
        /// If the user's group is part of an enterprise, the directory includes all users in the enterprise
        /// and all entries in the enterprise common phone list and the common phone list of the specified
        /// group  (if includeCommonPhoneList is set to true).
        /// If the user's group is part of a service provider, the directory includes all users in the group
        /// and all entries in the common phone list (if includeCommonPhoneList is set to true) of the
        /// specified group.
        /// The response is either UserPhoneDirectoryGetListResponse or ErrorResponse.
        /// If the searchCriteriaModeOr is present, any result matching any one criteria is included in the results. Otherwise, only
        /// results matching all the search criteria are included in the results.
        /// If no search criteria is specified, all results are returned.
        /// In all cases, if a responseSizeLimit is specified and the number of matching results is more than this limit, then an
        /// ErrorResponse is returned.
        /// Specifying searchCriteriaModeOr without any search criteria results in an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPhoneDirectoryGetListRequestAsync instead.")]
        public static async Task<UserPhoneDirectoryGetListResponse> UserPhoneDirectoryGetListRequest(this OcipClient client, UserPhoneDirectoryGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPhoneDirectoryGetListResponse;
        }

        /// <summary>
        /// Request a table containing the phone directory for a user's group.
        /// If the user's group is part of an enterprise, the directory includes all users in the enterprise
        /// and all entries in the enterprise common phone list and the common phone list of the specified
        /// group  (if includeCommonPhoneList is set to true).
        /// If the user's group is part of a service provider, the directory includes all users in the group
        /// and all entries in the common phone list (if includeCommonPhoneList is set to true) of the
        /// specified group.
        /// The response is either UserPhoneDirectoryGetListResponse or ErrorResponse.
        /// If the searchCriteriaModeOr is present, any result matching any one criteria is included in the results. Otherwise, only
        /// results matching all the search criteria are included in the results.
        /// If no search criteria is specified, all results are returned.
        /// In all cases, if a responseSizeLimit is specified and the number of matching results is more than this limit, then an
        /// ErrorResponse is returned.
        /// Specifying searchCriteriaModeOr without any search criteria results in an ErrorResponse.
        /// </summary>
        public static async Task<UserPhoneDirectoryGetListResponse> UserPhoneDirectoryGetListRequestAsync(this OcipClient client, UserPhoneDirectoryGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPhoneDirectoryGetListResponse;
        }
        /// <summary>
        /// Request a table containing the phone directory for a user.
        /// Setting isEnterpriseRequested to true will return enterprise directory
        /// members in the response if the user is in an enterprise. Otherwise,
        /// just the group directory members for a user are returned in the response.
        /// The response is either UserPhoneDirectoryGetPagedListResponse or
        /// ErrorResponse.
        /// The search can be done using multiple criteria.
        /// If the searchCriteriaModeOr is present, any result matching any one criteria is included in
        /// the results. Otherwise, only results matching all the search criteria are included in the results.
        /// If no search criteria is specified, all results are returned.
        /// In all cases, if a responseSizeLimit is specified and the number of matching results is more than
        /// this limit, then an ErrorResponse is returned.
        /// Specifying searchCriteriaModeOr without any search criteria results in an ErrorResponse.
        /// The boolean sortByFirstName is optional. If it is not specified, the response is
        /// sorted by Last Name.  The Receptionist Note column is only populated, if the user sending
        /// the request is the owner of the Receptionist Note and a Note exists.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPhoneDirectoryGetPagedListRequestAsync instead.")]
        public static async Task<UserPhoneDirectoryGetPagedListResponse> UserPhoneDirectoryGetPagedListRequest(this OcipClient client, UserPhoneDirectoryGetPagedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPhoneDirectoryGetPagedListResponse;
        }

        /// <summary>
        /// Request a table containing the phone directory for a user.
        /// Setting isEnterpriseRequested to true will return enterprise directory
        /// members in the response if the user is in an enterprise. Otherwise,
        /// just the group directory members for a user are returned in the response.
        /// The response is either UserPhoneDirectoryGetPagedListResponse or
        /// ErrorResponse.
        /// The search can be done using multiple criteria.
        /// If the searchCriteriaModeOr is present, any result matching any one criteria is included in
        /// the results. Otherwise, only results matching all the search criteria are included in the results.
        /// If no search criteria is specified, all results are returned.
        /// In all cases, if a responseSizeLimit is specified and the number of matching results is more than
        /// this limit, then an ErrorResponse is returned.
        /// Specifying searchCriteriaModeOr without any search criteria results in an ErrorResponse.
        /// The boolean sortByFirstName is optional. If it is not specified, the response is
        /// sorted by Last Name.  The Receptionist Note column is only populated, if the user sending
        /// the request is the owner of the Receptionist Note and a Note exists.
        /// </summary>
        public static async Task<UserPhoneDirectoryGetPagedListResponse> UserPhoneDirectoryGetPagedListRequestAsync(this OcipClient client, UserPhoneDirectoryGetPagedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPhoneDirectoryGetPagedListResponse;
        }
        /// <summary>
        /// Request a table containing the phone directory for a user.
        /// Setting isEnterpriseRequested to true will return enterprise directory
        /// members in the response if the user is in an enterprise.  Otherwise,
        /// just the group directory members for a user are returned in the
        /// response.
        /// The response is either UserPhoneDirectoryGetPagedSortedListResponse or ErrorResponse.
        /// The search can be done using multiple criteria.  If the searchCriteriaModeOr is present,
        /// any result matching any one criteria is included in the results. Otherwise, only results
        /// matching all the search criteria are included in the results.  If no search criteria is
        /// specified, all results are returned.  Specifying searchCriteriaModeOr
        /// without any search criteria results in an ErrorResponse.  The sort can be
        /// performed on user last name, first name, department, or receptionist note.
        /// The Receptionist Note column is only populated, if the user sending the request
        /// is the owner of the Receptionist Note and a Note exists.
        /// The following elements are only used in AS data mode and ignored in XS data
        /// mode:
        /// searchCriteriaMultiPartName
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPhoneDirectoryGetPagedSortedListRequestAsync instead.")]
        public static async Task<UserPhoneDirectoryGetPagedSortedListResponse> UserPhoneDirectoryGetPagedSortedListRequest(this OcipClient client, UserPhoneDirectoryGetPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPhoneDirectoryGetPagedSortedListResponse;
        }

        /// <summary>
        /// Request a table containing the phone directory for a user.
        /// Setting isEnterpriseRequested to true will return enterprise directory
        /// members in the response if the user is in an enterprise.  Otherwise,
        /// just the group directory members for a user are returned in the
        /// response.
        /// The response is either UserPhoneDirectoryGetPagedSortedListResponse or ErrorResponse.
        /// The search can be done using multiple criteria.  If the searchCriteriaModeOr is present,
        /// any result matching any one criteria is included in the results. Otherwise, only results
        /// matching all the search criteria are included in the results.  If no search criteria is
        /// specified, all results are returned.  Specifying searchCriteriaModeOr
        /// without any search criteria results in an ErrorResponse.  The sort can be
        /// performed on user last name, first name, department, or receptionist note.
        /// The Receptionist Note column is only populated, if the user sending the request
        /// is the owner of the Receptionist Note and a Note exists.
        /// The following elements are only used in AS data mode and ignored in XS data
        /// mode:
        /// searchCriteriaMultiPartName
        /// </summary>
        public static async Task<UserPhoneDirectoryGetPagedSortedListResponse> UserPhoneDirectoryGetPagedSortedListRequestAsync(this OcipClient client, UserPhoneDirectoryGetPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPhoneDirectoryGetPagedSortedListResponse;
        }
        /// <summary>
        /// Request a table containing the phone directory for a user.
        /// If the specified user is part of an enterprise, the directory includes all users in the enterprise
        /// and all entries in the enterprise common phone list and the common phone list of the specified user's group.
        /// If the specified user is part of a service provider, the directory includes all users in the user's group
        /// and all entries in the common phone list of the specified user's group.
        /// It is possible to search the directory for names containing a specified search string. The search includes
        /// matches on first name or last name or common phone list names.
        /// The response is either UserPhoneDirectoryGetSearchedListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPhoneDirectoryGetSearchedListRequestAsync instead.")]
        public static async Task<UserPhoneDirectoryGetSearchedListResponse> UserPhoneDirectoryGetSearchedListRequest(this OcipClient client, UserPhoneDirectoryGetSearchedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPhoneDirectoryGetSearchedListResponse;
        }

        /// <summary>
        /// Request a table containing the phone directory for a user.
        /// If the specified user is part of an enterprise, the directory includes all users in the enterprise
        /// and all entries in the enterprise common phone list and the common phone list of the specified user's group.
        /// If the specified user is part of a service provider, the directory includes all users in the user's group
        /// and all entries in the common phone list of the specified user's group.
        /// It is possible to search the directory for names containing a specified search string. The search includes
        /// matches on first name or last name or common phone list names.
        /// The response is either UserPhoneDirectoryGetSearchedListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserPhoneDirectoryGetSearchedListResponse> UserPhoneDirectoryGetSearchedListRequestAsync(this OcipClient client, UserPhoneDirectoryGetSearchedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPhoneDirectoryGetSearchedListResponse;
        }
        /// <summary>
        /// Request the user's portal passcode information.
        /// The response is either a UserPortalPasscodeGetInfoResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPortalPasscodeGetInfoRequestAsync instead.")]
        public static async Task<UserPortalPasscodeGetInfoResponse> UserPortalPasscodeGetInfoRequest(this OcipClient client, UserPortalPasscodeGetInfoRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPortalPasscodeGetInfoResponse;
        }

        /// <summary>
        /// Request the user's portal passcode information.
        /// The response is either a UserPortalPasscodeGetInfoResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserPortalPasscodeGetInfoResponse> UserPortalPasscodeGetInfoRequestAsync(this OcipClient client, UserPortalPasscodeGetInfoRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPortalPasscodeGetInfoResponse;
        }
        /// <summary>
        /// Modify the user's Portal passcode
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// oldPasscode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPortalPasscodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPortalPasscodeModifyRequest(this OcipClient client, UserPortalPasscodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's Portal passcode
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// oldPasscode
        /// </summary>
        public static async Task<SuccessResponse> UserPortalPasscodeModifyRequestAsync(this OcipClient client, UserPortalPasscodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the effective passcode rules setting for a user.
        /// The response is either UserPortalPasscodeRulesGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPortalPasscodeRulesGetRequestAsync instead.")]
        public static async Task<UserPortalPasscodeRulesGetResponse> UserPortalPasscodeRulesGetRequest(this OcipClient client, UserPortalPasscodeRulesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPortalPasscodeRulesGetResponse;
        }

        /// <summary>
        /// Requests the effective passcode rules setting for a user.
        /// The response is either UserPortalPasscodeRulesGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserPortalPasscodeRulesGetResponse> UserPortalPasscodeRulesGetRequestAsync(this OcipClient client, UserPortalPasscodeRulesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPortalPasscodeRulesGetResponse;
        }
        /// <summary>
        /// Get the Users Primary Endpoint setting.
        /// The response is either a UserPrimaryEndpointAdvancedSettingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPrimaryEndpointAdvancedSettingGetRequestAsync instead.")]
        public static async Task<UserPrimaryEndpointAdvancedSettingGetResponse> UserPrimaryEndpointAdvancedSettingGetRequest(this OcipClient client, UserPrimaryEndpointAdvancedSettingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPrimaryEndpointAdvancedSettingGetResponse;
        }

        /// <summary>
        /// Get the Users Primary Endpoint setting.
        /// The response is either a UserPrimaryEndpointAdvancedSettingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserPrimaryEndpointAdvancedSettingGetResponse> UserPrimaryEndpointAdvancedSettingGetRequestAsync(this OcipClient client, UserPrimaryEndpointAdvancedSettingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPrimaryEndpointAdvancedSettingGetResponse;
        }
        /// <summary>
        /// Modify the Users Primary Endpoint line control settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// allowVideo
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPrimaryEndpointAdvancedSettingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPrimaryEndpointAdvancedSettingModifyRequest(this OcipClient client, UserPrimaryEndpointAdvancedSettingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Users Primary Endpoint line control settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// allowVideo
        /// </summary>
        public static async Task<SuccessResponse> UserPrimaryEndpointAdvancedSettingModifyRequestAsync(this OcipClient client, UserPrimaryEndpointAdvancedSettingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the push notification settings for a user.
        /// The response is either UserPushNotificationGetResponse24 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPushNotificationGetRequest24Async instead.")]
        public static async Task<UserPushNotificationGetResponse24> UserPushNotificationGetRequest24(this OcipClient client, UserPushNotificationGetRequest24 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPushNotificationGetResponse24;
        }

        /// <summary>
        /// Get the push notification settings for a user.
        /// The response is either UserPushNotificationGetResponse24 or ErrorResponse.
        /// </summary>
        public static async Task<UserPushNotificationGetResponse24> UserPushNotificationGetRequest24Async(this OcipClient client, UserPushNotificationGetRequest24 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPushNotificationGetResponse24;
        }
        /// <summary>
        /// Modify the push notification settings for a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPushNotificationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPushNotificationModifyRequest(this OcipClient client, UserPushNotificationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the push notification settings for a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPushNotificationModifyRequestAsync(this OcipClient client, UserPushNotificationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to remove a push notification registration.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPushNotificationRegistrationDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPushNotificationRegistrationDeleteRequest(this OcipClient client, UserPushNotificationRegistrationDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to remove a push notification registration.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPushNotificationRegistrationDeleteRequestAsync(this OcipClient client, UserPushNotificationRegistrationDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a list of all of the push notification registrations for a user by
        /// either registration id or user id.
        /// The response is either UserPushNotificationRegistrationGetListResponse21sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPushNotificationRegistrationGetListRequest21sp1Async instead.")]
        public static async Task<UserPushNotificationRegistrationGetListResponse21sp1> UserPushNotificationRegistrationGetListRequest21sp1(this OcipClient client, UserPushNotificationRegistrationGetListRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPushNotificationRegistrationGetListResponse21sp1;
        }

        /// <summary>
        /// Request a list of all of the push notification registrations for a user by
        /// either registration id or user id.
        /// The response is either UserPushNotificationRegistrationGetListResponse21sp1 or ErrorResponse.
        /// </summary>
        public static async Task<UserPushNotificationRegistrationGetListResponse21sp1> UserPushNotificationRegistrationGetListRequest21sp1Async(this OcipClient client, UserPushNotificationRegistrationGetListRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPushNotificationRegistrationGetListResponse21sp1;
        }
        /// <summary>
        /// Add an event to user schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserScheduleAddEventRequestAsync instead.")]
        public static async Task<SuccessResponse> UserScheduleAddEventRequest(this OcipClient client, UserScheduleAddEventRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an event to user schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        public static async Task<SuccessResponse> UserScheduleAddEventRequestAsync(this OcipClient client, UserScheduleAddEventRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a user schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserScheduleAddRequestAsync instead.")]
        public static async Task<SuccessResponse> UserScheduleAddRequest(this OcipClient client, UserScheduleAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a user schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserScheduleAddRequestAsync(this OcipClient client, UserScheduleAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of events from a user schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserScheduleDeleteEventListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserScheduleDeleteEventListRequest(this OcipClient client, UserScheduleDeleteEventListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of events from a user schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserScheduleDeleteEventListRequestAsync(this OcipClient client, UserScheduleDeleteEventListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of user schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserScheduleDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserScheduleDeleteListRequest(this OcipClient client, UserScheduleDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of user schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserScheduleDeleteListRequestAsync(this OcipClient client, UserScheduleDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of schedules viewable by a User. The list can be filtered by schedule type.
        /// The response is either a UserScheduleGetEventDetailListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserScheduleGetEventDetailListRequestAsync instead.")]
        public static async Task<UserScheduleGetEventDetailListResponse> UserScheduleGetEventDetailListRequest(this OcipClient client, UserScheduleGetEventDetailListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserScheduleGetEventDetailListResponse;
        }

        /// <summary>
        /// Request the list of schedules viewable by a User. The list can be filtered by schedule type.
        /// The response is either a UserScheduleGetEventDetailListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserScheduleGetEventDetailListResponse> UserScheduleGetEventDetailListRequestAsync(this OcipClient client, UserScheduleGetEventDetailListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserScheduleGetEventDetailListResponse;
        }
        /// <summary>
        /// Get the list of events of a user schedule.
        /// The response is either a UserScheduleGetEventListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserScheduleGetEventListRequestAsync instead.")]
        public static async Task<UserScheduleGetEventListResponse> UserScheduleGetEventListRequest(this OcipClient client, UserScheduleGetEventListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserScheduleGetEventListResponse;
        }

        /// <summary>
        /// Get the list of events of a user schedule.
        /// The response is either a UserScheduleGetEventListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserScheduleGetEventListResponse> UserScheduleGetEventListRequestAsync(this OcipClient client, UserScheduleGetEventListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserScheduleGetEventListResponse;
        }
        /// <summary>
        /// Get an event from a user schedule.
        /// The response is either a UserScheduleGetEventResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserScheduleGetEventRequestAsync instead.")]
        public static async Task<UserScheduleGetEventResponse> UserScheduleGetEventRequest(this OcipClient client, UserScheduleGetEventRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserScheduleGetEventResponse;
        }

        /// <summary>
        /// Get an event from a user schedule.
        /// The response is either a UserScheduleGetEventResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserScheduleGetEventResponse> UserScheduleGetEventRequestAsync(this OcipClient client, UserScheduleGetEventRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserScheduleGetEventResponse;
        }
        /// <summary>
        /// Get the list of schedules viewable by a User. The list can be filtered by schedule type.
        /// The response is either a UserScheduleGetListResponse17sp1 or an ErrorResponse.
        /// This command is authorized to user who is Executive-Assistant of the Executive.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserScheduleGetListRequest17sp1Async instead.")]
        public static async Task<UserScheduleGetListResponse17sp1> UserScheduleGetListRequest17sp1(this OcipClient client, UserScheduleGetListRequest17sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserScheduleGetListResponse17sp1;
        }

        /// <summary>
        /// Get the list of schedules viewable by a User. The list can be filtered by schedule type.
        /// The response is either a UserScheduleGetListResponse17sp1 or an ErrorResponse.
        /// This command is authorized to user who is Executive-Assistant of the Executive.
        /// </summary>
        public static async Task<UserScheduleGetListResponse17sp1> UserScheduleGetListRequest17sp1Async(this OcipClient client, UserScheduleGetListRequest17sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserScheduleGetListResponse17sp1;
        }
        /// <summary>
        /// Get the list of schedules viewable by a User. The list can be filtered by schedule name,
        /// schedule type, and schedule level.
        /// The response is either a UserScheduleGetPagedSortedListResponse or an ErrorResponse.
        /// This command is authorized to user who is Executive-Assistant of the Executive.
        /// If no sortOrder is included, the response is sorted by Name ascending by default.
        /// If the responsePagingControl element is not provided, the paging startIndex will be
        /// set to 1 by default, and the responsePageSize will be set to the maximum
        /// responsePageSize by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option
        /// is included. Then the search criteria are logically ORed together.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserScheduleGetPagedSortedListRequestAsync instead.")]
        public static async Task<UserScheduleGetPagedSortedListResponse> UserScheduleGetPagedSortedListRequest(this OcipClient client, UserScheduleGetPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserScheduleGetPagedSortedListResponse;
        }

        /// <summary>
        /// Get the list of schedules viewable by a User. The list can be filtered by schedule name,
        /// schedule type, and schedule level.
        /// The response is either a UserScheduleGetPagedSortedListResponse or an ErrorResponse.
        /// This command is authorized to user who is Executive-Assistant of the Executive.
        /// If no sortOrder is included, the response is sorted by Name ascending by default.
        /// If the responsePagingControl element is not provided, the paging startIndex will be
        /// set to 1 by default, and the responsePageSize will be set to the maximum
        /// responsePageSize by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option
        /// is included. Then the search criteria are logically ORed together.
        /// </summary>
        public static async Task<UserScheduleGetPagedSortedListResponse> UserScheduleGetPagedSortedListRequestAsync(this OcipClient client, UserScheduleGetPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserScheduleGetPagedSortedListResponse;
        }
        /// <summary>
        /// Modify an event of a user schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserScheduleModifyEventRequestAsync instead.")]
        public static async Task<SuccessResponse> UserScheduleModifyEventRequest(this OcipClient client, UserScheduleModifyEventRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an event of a user schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        public static async Task<SuccessResponse> UserScheduleModifyEventRequestAsync(this OcipClient client, UserScheduleModifyEventRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a user schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserScheduleModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserScheduleModifyRequest(this OcipClient client, UserScheduleModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a user schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserScheduleModifyRequestAsync(this OcipClient client, UserScheduleModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to assign the user services and service packs for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserServiceAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserServiceAssignListRequest(this OcipClient client, UserServiceAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to assign the user services and service packs for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserServiceAssignListRequestAsync(this OcipClient client, UserServiceAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the user's service and service pack assignment list with status.
        /// The response is either UserServiceGetAssignmentListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserServiceGetAssignmentListRequestAsync instead.")]
        public static async Task<UserServiceGetAssignmentListResponse> UserServiceGetAssignmentListRequest(this OcipClient client, UserServiceGetAssignmentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserServiceGetAssignmentListResponse;
        }

        /// <summary>
        /// Requests the user's service and service pack assignment list with status.
        /// The response is either UserServiceGetAssignmentListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserServiceGetAssignmentListResponse> UserServiceGetAssignmentListRequestAsync(this OcipClient client, UserServiceGetAssignmentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserServiceGetAssignmentListResponse;
        }
        /// <summary>
        /// Request to determine if a UserService or service pack is assigned to the user.
        /// The response is either UserServiceIsAssignedResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserServiceIsAssignedRequestAsync instead.")]
        public static async Task<UserServiceIsAssignedResponse> UserServiceIsAssignedRequest(this OcipClient client, UserServiceIsAssignedRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserServiceIsAssignedResponse;
        }

        /// <summary>
        /// Request to determine if a UserService or service pack is assigned to the user.
        /// The response is either UserServiceIsAssignedResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserServiceIsAssignedResponse> UserServiceIsAssignedRequestAsync(this OcipClient client, UserServiceIsAssignedRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserServiceIsAssignedResponse;
        }
        /// <summary>
        /// Requests to unassign the user services and service packs for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserServiceUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserServiceUnassignListRequest(this OcipClient client, UserServiceUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Requests to unassign the user services and service packs for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserServiceUnassignListRequestAsync(this OcipClient client, UserServiceUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Returns the Sh non-transparent data stored against a Public User Identity (a SIP URI
        /// or TEL URI).
        /// The response is either a UserShInterfaceGetPublicIdDataResponse21sp1 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserShInterfaceGetPublicIdDataRequest21sp1Async instead.")]
        public static async Task<UserShInterfaceGetPublicIdDataResponse21sp1> UserShInterfaceGetPublicIdDataRequest21sp1(this OcipClient client, UserShInterfaceGetPublicIdDataRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserShInterfaceGetPublicIdDataResponse21sp1;
        }

        /// <summary>
        /// Returns the Sh non-transparent data stored against a Public User Identity (a SIP URI
        /// or TEL URI).
        /// The response is either a UserShInterfaceGetPublicIdDataResponse21sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<UserShInterfaceGetPublicIdDataResponse21sp1> UserShInterfaceGetPublicIdDataRequest21sp1Async(this OcipClient client, UserShInterfaceGetPublicIdDataRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserShInterfaceGetPublicIdDataResponse21sp1;
        }
        /// <summary>
        /// Returns the Sh non-transparent data stored against a userId.
        /// The response is either a UserShInterfaceGetUserIdDataResponse21sp1 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserShInterfaceGetUserIdDataRequest21sp1Async instead.")]
        public static async Task<UserShInterfaceGetUserIdDataResponse21sp1> UserShInterfaceGetUserIdDataRequest21sp1(this OcipClient client, UserShInterfaceGetUserIdDataRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserShInterfaceGetUserIdDataResponse21sp1;
        }

        /// <summary>
        /// Returns the Sh non-transparent data stored against a userId.
        /// The response is either a UserShInterfaceGetUserIdDataResponse21sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<UserShInterfaceGetUserIdDataResponse21sp1> UserShInterfaceGetUserIdDataRequest21sp1Async(this OcipClient client, UserShInterfaceGetUserIdDataRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserShInterfaceGetUserIdDataResponse21sp1;
        }
        /// <summary>
        /// Modifies the Sh Interface non-transparent data associated with a Public User Identity.
        /// The response is a SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserShInterfaceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserShInterfaceModifyRequest(this OcipClient client, UserShInterfaceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the Sh Interface non-transparent data associated with a Public User Identity.
        /// The response is a SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserShInterfaceModifyRequestAsync(this OcipClient client, UserShInterfaceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Dispatches a Public Identity refresh task on the local Application Server node for the specified public identity.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserShInterfacePublicIdentityRefreshTaskStartRequestAsync instead.")]
        public static async Task<SuccessResponse> UserShInterfacePublicIdentityRefreshTaskStartRequest(this OcipClient client, UserShInterfacePublicIdentityRefreshTaskStartRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Dispatches a Public Identity refresh task on the local Application Server node for the specified public identity.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserShInterfacePublicIdentityRefreshTaskStartRequestAsync(this OcipClient client, UserShInterfacePublicIdentityRefreshTaskStartRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Terminating Alternate Trunk Identity.
        /// The response is either a UserTerminatingAlternateTrunkIdentityGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserTerminatingAlternateTrunkIdentityGetRequestAsync instead.")]
        public static async Task<UserTerminatingAlternateTrunkIdentityGetResponse> UserTerminatingAlternateTrunkIdentityGetRequest(this OcipClient client, UserTerminatingAlternateTrunkIdentityGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserTerminatingAlternateTrunkIdentityGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Terminating Alternate Trunk Identity.
        /// The response is either a UserTerminatingAlternateTrunkIdentityGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserTerminatingAlternateTrunkIdentityGetResponse> UserTerminatingAlternateTrunkIdentityGetRequestAsync(this OcipClient client, UserTerminatingAlternateTrunkIdentityGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserTerminatingAlternateTrunkIdentityGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Terminating Alternate Trunk Identity.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserTerminatingAlternateTrunkIdentityModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserTerminatingAlternateTrunkIdentityModifyRequest(this OcipClient client, UserTerminatingAlternateTrunkIdentityModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Terminating Alternate Trunk Identity.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserTerminatingAlternateTrunkIdentityModifyRequestAsync(this OcipClient client, UserTerminatingAlternateTrunkIdentityModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get user Terminating CUG service settings.
        /// The response is either UserTerminatingClosedUserGroupGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserTerminatingClosedUserGroupGetRequestAsync instead.")]
        public static async Task<UserTerminatingClosedUserGroupGetResponse> UserTerminatingClosedUserGroupGetRequest(this OcipClient client, UserTerminatingClosedUserGroupGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserTerminatingClosedUserGroupGetResponse;
        }

        /// <summary>
        /// Get user Terminating CUG service settings.
        /// The response is either UserTerminatingClosedUserGroupGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserTerminatingClosedUserGroupGetResponse> UserTerminatingClosedUserGroupGetRequestAsync(this OcipClient client, UserTerminatingClosedUserGroupGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserTerminatingClosedUserGroupGetResponse;
        }
        /// <summary>
        /// Modify user Terminating CUG service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserTerminatingClosedUserGroupModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserTerminatingClosedUserGroupModifyRequest(this OcipClient client, UserTerminatingClosedUserGroupModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify user Terminating CUG service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserTerminatingClosedUserGroupModifyRequestAsync(this OcipClient client, UserTerminatingClosedUserGroupModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the user Xsi policy profile.
        /// The response is either a UserXsiPolicyProfileGetResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserXsiPolicyProfileGetRequestAsync instead.")]
        public static async Task<UserXsiPolicyProfileGetResponse> UserXsiPolicyProfileGetRequest(this OcipClient client, UserXsiPolicyProfileGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserXsiPolicyProfileGetResponse;
        }

        /// <summary>
        /// Get the user Xsi policy profile.
        /// The response is either a UserXsiPolicyProfileGetResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<UserXsiPolicyProfileGetResponse> UserXsiPolicyProfileGetRequestAsync(this OcipClient client, UserXsiPolicyProfileGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserXsiPolicyProfileGetResponse;
        }
        /// <summary>
        /// Modifies the default Xsi policy profile for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserXsiPolicyProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserXsiPolicyProfileModifyRequest(this OcipClient client, UserXsiPolicyProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the default Xsi policy profile for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserXsiPolicyProfileModifyRequestAsync(this OcipClient client, UserXsiPolicyProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
