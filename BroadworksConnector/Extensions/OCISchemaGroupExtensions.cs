using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaGroupExtensions
    {

        /// <summary>
        /// Request to add a group access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceAddRequest14Async instead.")]
        public static async Task<SuccessResponse> GroupAccessDeviceAddRequest14(this OcipClient client, GroupAccessDeviceAddRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a group access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAccessDeviceAddRequest14Async(this OcipClient client, GroupAccessDeviceAddRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of available ports in a device.
        /// The response is either GroupAccessDeviceAvailablePortGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceAvailablePortGetListRequestAsync instead.")]
        public static async Task<GroupAccessDeviceAvailablePortGetListResponse> GroupAccessDeviceAvailablePortGetListRequest(this OcipClient client, GroupAccessDeviceAvailablePortGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccessDeviceAvailablePortGetListResponse;
        }

        /// <summary>
        /// Request to get the list of available ports in a device.
        /// The response is either GroupAccessDeviceAvailablePortGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupAccessDeviceAvailablePortGetListResponse> GroupAccessDeviceAvailablePortGetListRequestAsync(this OcipClient client, GroupAccessDeviceAvailablePortGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccessDeviceAvailablePortGetListResponse;
        }
        /// <summary>
        /// Request to add a static configuration tag for a group access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceCustomTagAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAccessDeviceCustomTagAddRequest(this OcipClient client, GroupAccessDeviceCustomTagAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a static configuration tag for a group access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAccessDeviceCustomTagAddRequestAsync(this OcipClient client, GroupAccessDeviceCustomTagAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete static configuration tags for a group access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceCustomTagDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAccessDeviceCustomTagDeleteListRequest(this OcipClient client, GroupAccessDeviceCustomTagDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete static configuration tags for a group access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAccessDeviceCustomTagDeleteListRequestAsync(this OcipClient client, GroupAccessDeviceCustomTagDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of custom configuration tags managed by the Device Management System, on a per-device profile basis.
        /// The response is either GroupAccessDeviceCustomTagGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceCustomTagGetListRequestAsync instead.")]
        public static async Task<GroupAccessDeviceCustomTagGetListResponse> GroupAccessDeviceCustomTagGetListRequest(this OcipClient client, GroupAccessDeviceCustomTagGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccessDeviceCustomTagGetListResponse;
        }

        /// <summary>
        /// Request to get the list of custom configuration tags managed by the Device Management System, on a per-device profile basis.
        /// The response is either GroupAccessDeviceCustomTagGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupAccessDeviceCustomTagGetListResponse> GroupAccessDeviceCustomTagGetListRequestAsync(this OcipClient client, GroupAccessDeviceCustomTagGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccessDeviceCustomTagGetListResponse;
        }
        /// <summary>
        /// Request to modify a static configuration tag for a group access device.
        /// 
        /// The tagValueToEncrypt element can only be used by a system administrator.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceCustomTagModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAccessDeviceCustomTagModifyRequest(this OcipClient client, GroupAccessDeviceCustomTagModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag for a group access device.
        /// 
        /// The tagValueToEncrypt element can only be used by a system administrator.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAccessDeviceCustomTagModifyRequestAsync(this OcipClient client, GroupAccessDeviceCustomTagModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a specified group access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAccessDeviceDeleteRequest(this OcipClient client, GroupAccessDeviceDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a specified group access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAccessDeviceDeleteRequestAsync(this OcipClient client, GroupAccessDeviceDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of device files managed by the Device Management System, on a per-device profile basis.
        /// The response is either GroupAccessDeviceFileGetListResponse14sp8 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceFileGetListRequest14sp8Async instead.")]
        public static async Task<GroupAccessDeviceFileGetListResponse14sp8> GroupAccessDeviceFileGetListRequest14sp8(this OcipClient client, GroupAccessDeviceFileGetListRequest14sp8 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccessDeviceFileGetListResponse14sp8;
        }

        /// <summary>
        /// Request to get the list of device files managed by the Device Management System, on a per-device profile basis.
        /// The response is either GroupAccessDeviceFileGetListResponse14sp8 or ErrorResponse.
        /// </summary>
        public static async Task<GroupAccessDeviceFileGetListResponse14sp8> GroupAccessDeviceFileGetListRequest14sp8Async(this OcipClient client, GroupAccessDeviceFileGetListRequest14sp8 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccessDeviceFileGetListResponse14sp8;
        }
        /// <summary>
        /// Request to get a group device profile file.
        /// The response is either GroupAccessDeviceFileGetResponse20 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceFileGetRequest20Async instead.")]
        public static async Task<GroupAccessDeviceFileGetResponse20> GroupAccessDeviceFileGetRequest20(this OcipClient client, GroupAccessDeviceFileGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccessDeviceFileGetResponse20;
        }

        /// <summary>
        /// Request to get a group device profile file.
        /// The response is either GroupAccessDeviceFileGetResponse20 or ErrorResponse.
        /// </summary>
        public static async Task<GroupAccessDeviceFileGetResponse20> GroupAccessDeviceFileGetRequest20Async(this OcipClient client, GroupAccessDeviceFileGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccessDeviceFileGetResponse20;
        }
        /// <summary>
        /// Request to modify a specified group access device file.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceFileModifyRequest14sp8Async instead.")]
        public static async Task<SuccessResponse> GroupAccessDeviceFileModifyRequest14sp8(this OcipClient client, GroupAccessDeviceFileModifyRequest14sp8 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a specified group access device file.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAccessDeviceFileModifyRequest14sp8Async(this OcipClient client, GroupAccessDeviceFileModifyRequest14sp8 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of available access devices for assignment to a user
        /// within a group. The list includes devices created at the system, service provider, and group levels.
        /// The response is either GroupAccessDeviceGetAvailableDetailListResponse19 or
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceGetAvailableDetailListRequest19Async instead.")]
        public static async Task<GroupAccessDeviceGetAvailableDetailListResponse19> GroupAccessDeviceGetAvailableDetailListRequest19(this OcipClient client, GroupAccessDeviceGetAvailableDetailListRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccessDeviceGetAvailableDetailListResponse19;
        }

        /// <summary>
        /// Requests the list of available access devices for assignment to a user
        /// within a group. The list includes devices created at the system, service provider, and group levels.
        /// The response is either GroupAccessDeviceGetAvailableDetailListResponse19 or
        /// ErrorResponse.
        /// </summary>
        public static async Task<GroupAccessDeviceGetAvailableDetailListResponse19> GroupAccessDeviceGetAvailableDetailListRequest19Async(this OcipClient client, GroupAccessDeviceGetAvailableDetailListRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccessDeviceGetAvailableDetailListResponse19;
        }
        /// <summary>
        /// Requests the list of configurable device types of devices that have already been
        /// added to the group.
        /// The response is either GroupAccessDeviceGetEnhancedConfigurationTypeListResponse
        /// or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceGetEnhancedConfigurationTypeListRequestAsync instead.")]
        public static async Task<GroupAccessDeviceGetEnhancedConfigurationTypeListResponse> GroupAccessDeviceGetEnhancedConfigurationTypeListRequest(this OcipClient client, GroupAccessDeviceGetEnhancedConfigurationTypeListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccessDeviceGetEnhancedConfigurationTypeListResponse;
        }

        /// <summary>
        /// Requests the list of configurable device types of devices that have already been
        /// added to the group.
        /// The response is either GroupAccessDeviceGetEnhancedConfigurationTypeListResponse
        /// or ErrorResponse.
        /// </summary>
        public static async Task<GroupAccessDeviceGetEnhancedConfigurationTypeListResponse> GroupAccessDeviceGetEnhancedConfigurationTypeListRequestAsync(this OcipClient client, GroupAccessDeviceGetEnhancedConfigurationTypeListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccessDeviceGetEnhancedConfigurationTypeListResponse;
        }
        /// <summary>
        /// Requests the details of a specified configurable device type for a group.
        /// The response is either GroupAccessDeviceGetEnhancedConfigurationTypeResponse14
        /// or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceGetEnhancedConfigurationTypeRequest14Async instead.")]
        public static async Task<GroupAccessDeviceGetEnhancedConfigurationTypeResponse14> GroupAccessDeviceGetEnhancedConfigurationTypeRequest14(this OcipClient client, GroupAccessDeviceGetEnhancedConfigurationTypeRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccessDeviceGetEnhancedConfigurationTypeResponse14;
        }

        /// <summary>
        /// Requests the details of a specified configurable device type for a group.
        /// The response is either GroupAccessDeviceGetEnhancedConfigurationTypeResponse14
        /// or ErrorResponse.
        /// </summary>
        public static async Task<GroupAccessDeviceGetEnhancedConfigurationTypeResponse14> GroupAccessDeviceGetEnhancedConfigurationTypeRequest14Async(this OcipClient client, GroupAccessDeviceGetEnhancedConfigurationTypeRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccessDeviceGetEnhancedConfigurationTypeResponse14;
        }
        /// <summary>
        /// Requests the list of access devices in a group.
        /// The response is either GroupAccessDeviceGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceGetListRequestAsync instead.")]
        public static async Task<GroupAccessDeviceGetListResponse> GroupAccessDeviceGetListRequest(this OcipClient client, GroupAccessDeviceGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccessDeviceGetListResponse;
        }

        /// <summary>
        /// Requests the list of access devices in a group.
        /// The response is either GroupAccessDeviceGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupAccessDeviceGetListResponse> GroupAccessDeviceGetListRequestAsync(this OcipClient client, GroupAccessDeviceGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccessDeviceGetListResponse;
        }
        /// <summary>
        /// Requests the list of access devices in a group.
        /// The response is either GroupAccessDeviceGetPagedSortedListResponse or ErrorResponse.
        /// If no sortOrder is included, the response is sorted by Device Name ascending
        /// by default.  If the responsePagingControl element is not provided, the paging startIndex
        /// will be set to 1 by default, and the responsePageSize will be set to the maximum
        /// responsePageSize by default.
        /// Multiple search criteria are logically ANDed together unless the
        /// searchCriteriaModeOr option is included. Then the search criteria are logically
        /// ORed together.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceGetPagedSortedListRequestAsync instead.")]
        public static async Task<GroupAccessDeviceGetPagedSortedListResponse> GroupAccessDeviceGetPagedSortedListRequest(this OcipClient client, GroupAccessDeviceGetPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccessDeviceGetPagedSortedListResponse;
        }

        /// <summary>
        /// Requests the list of access devices in a group.
        /// The response is either GroupAccessDeviceGetPagedSortedListResponse or ErrorResponse.
        /// If no sortOrder is included, the response is sorted by Device Name ascending
        /// by default.  If the responsePagingControl element is not provided, the paging startIndex
        /// will be set to 1 by default, and the responsePageSize will be set to the maximum
        /// responsePageSize by default.
        /// Multiple search criteria are logically ANDed together unless the
        /// searchCriteriaModeOr option is included. Then the search criteria are logically
        /// ORed together.
        /// </summary>
        public static async Task<GroupAccessDeviceGetPagedSortedListResponse> GroupAccessDeviceGetPagedSortedListRequestAsync(this OcipClient client, GroupAccessDeviceGetPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccessDeviceGetPagedSortedListResponse;
        }
        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetResponse18sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceGetRequest18sp1Async instead.")]
        public static async Task<GroupAccessDeviceGetResponse18sp1> GroupAccessDeviceGetRequest18sp1(this OcipClient client, GroupAccessDeviceGetRequest18sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccessDeviceGetResponse18sp1;
        }

        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetResponse18sp1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupAccessDeviceGetResponse18sp1> GroupAccessDeviceGetRequest18sp1Async(this OcipClient client, GroupAccessDeviceGetRequest18sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccessDeviceGetResponse18sp1;
        }
        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetUserListResponse21sp1 or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceGetUserListRequest21sp1Async instead.")]
        public static async Task<GroupAccessDeviceGetUserListResponse21sp1> GroupAccessDeviceGetUserListRequest21sp1(this OcipClient client, GroupAccessDeviceGetUserListRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccessDeviceGetUserListResponse21sp1;
        }

        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetUserListResponse21sp1 or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// </summary>
        public static async Task<GroupAccessDeviceGetUserListResponse21sp1> GroupAccessDeviceGetUserListRequest21sp1Async(this OcipClient client, GroupAccessDeviceGetUserListRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccessDeviceGetUserListResponse21sp1;
        }
        /// <summary>
        /// Request to modify a specified group access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceModifyRequest14Async instead.")]
        public static async Task<SuccessResponse> GroupAccessDeviceModifyRequest14(this OcipClient client, GroupAccessDeviceModifyRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a specified group access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAccessDeviceModifyRequest14Async(this OcipClient client, GroupAccessDeviceModifyRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify attributes for line/ports assigned on the group device profile.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// privateIdentity
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceModifyUserRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAccessDeviceModifyUserRequest(this OcipClient client, GroupAccessDeviceModifyUserRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify attributes for line/ports assigned on the group device profile.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// privateIdentity
        /// </summary>
        public static async Task<SuccessResponse> GroupAccessDeviceModifyUserRequestAsync(this OcipClient client, GroupAccessDeviceModifyUserRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Reset a specific group SIP device that supports the reset operation.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceResetRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAccessDeviceResetRequest(this OcipClient client, GroupAccessDeviceResetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Reset a specific group SIP device that supports the reset operation.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAccessDeviceResetRequestAsync(this OcipClient client, GroupAccessDeviceResetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the custom configuration tag set defined at the access device.
        /// The response is either GroupAccessDeviceTagSetGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceTagSetGetRequestAsync instead.")]
        public static async Task<GroupAccessDeviceTagSetGetResponse> GroupAccessDeviceTagSetGetRequest(this OcipClient client, GroupAccessDeviceTagSetGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccessDeviceTagSetGetResponse;
        }

        /// <summary>
        /// Request to get the custom configuration tag set defined at the access device.
        /// The response is either GroupAccessDeviceTagSetGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupAccessDeviceTagSetGetResponse> GroupAccessDeviceTagSetGetRequestAsync(this OcipClient client, GroupAccessDeviceTagSetGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccessDeviceTagSetGetResponse;
        }
        /// <summary>
        /// Request to modify a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceTagSetModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAccessDeviceTagSetModifyRequest(this OcipClient client, GroupAccessDeviceTagSetModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAccessDeviceTagSetModifyRequestAsync(this OcipClient client, GroupAccessDeviceTagSetModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in Amplify data mode and ignored in AS and XS data mode:
        /// servicePolicy,
        /// callProcessingSliceId,
        /// provisioningSliceId,
        /// subscriberPartition.
        /// When the callProcessingSliceId or provisioningSliceId is not specified in the AmplifyDataMode,
        /// the default slice Id is assigned to the Group.
        /// Only Provisioning admin and above can change the callProcessingSliceId,
        /// provisioningSliceId, and subscriberPartition.
        /// 
        /// The following elements are only used in Amplify and XS data mode and ignored in AS mode:
        /// preferredDataCenter.
        /// Only Provisioning admin and above can change the preferredDataCenter.
        /// 
        /// The following elements are only used in XS data mode and ignored in Amplify and AS data mode:
        /// defaultUserCallingLineIdPhoneNumber.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAddRequest(this OcipClient client, GroupAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in Amplify data mode and ignored in AS and XS data mode:
        /// servicePolicy,
        /// callProcessingSliceId,
        /// provisioningSliceId,
        /// subscriberPartition.
        /// When the callProcessingSliceId or provisioningSliceId is not specified in the AmplifyDataMode,
        /// the default slice Id is assigned to the Group.
        /// Only Provisioning admin and above can change the callProcessingSliceId,
        /// provisioningSliceId, and subscriberPartition.
        /// 
        /// The following elements are only used in Amplify and XS data mode and ignored in AS mode:
        /// preferredDataCenter.
        /// Only Provisioning admin and above can change the preferredDataCenter.
        /// 
        /// The following elements are only used in XS data mode and ignored in Amplify and AS data mode:
        /// defaultUserCallingLineIdPhoneNumber.
        /// </summary>
        public static async Task<SuccessResponse> GroupAddRequestAsync(this OcipClient client, GroupAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a group administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAdminAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAdminAddRequest(this OcipClient client, GroupAdminAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a group administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAdminAddRequestAsync(this OcipClient client, GroupAdminAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a group administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAdminDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAdminDeleteRequest(this OcipClient client, GroupAdminDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a group administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAdminDeleteRequestAsync(this OcipClient client, GroupAdminDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of group and department administrators within the group.
        /// The response is either a GroupAdminGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAdminGetListRequestAsync instead.")]
        public static async Task<GroupAdminGetListResponse> GroupAdminGetListRequest(this OcipClient client, GroupAdminGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAdminGetListResponse;
        }

        /// <summary>
        /// Get a list of group and department administrators within the group.
        /// The response is either a GroupAdminGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupAdminGetListResponse> GroupAdminGetListRequestAsync(this OcipClient client, GroupAdminGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAdminGetListResponse;
        }
        /// <summary>
        /// Get a list of group and department administrators within the group.
        /// The response is either a GroupAdminGetPagedSortedListResponse or an ErrorResponse.
        /// If no sort criterion is included, the response is sorted by administrator id ascending by default.
        /// If the responsePagingControl element is not provided, the paging startIndex will be
        /// set to 1 by default, and the responsePageSize will be set to the maximum
        /// responsePageSize by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is
        /// included. Then the search criteria are logically ORed together.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAdminGetPagedSortedListRequestAsync instead.")]
        public static async Task<GroupAdminGetPagedSortedListResponse> GroupAdminGetPagedSortedListRequest(this OcipClient client, GroupAdminGetPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAdminGetPagedSortedListResponse;
        }

        /// <summary>
        /// Get a list of group and department administrators within the group.
        /// The response is either a GroupAdminGetPagedSortedListResponse or an ErrorResponse.
        /// If no sort criterion is included, the response is sorted by administrator id ascending by default.
        /// If the responsePagingControl element is not provided, the paging startIndex will be
        /// set to 1 by default, and the responsePageSize will be set to the maximum
        /// responsePageSize by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is
        /// included. Then the search criteria are logically ORed together.
        /// </summary>
        public static async Task<GroupAdminGetPagedSortedListResponse> GroupAdminGetPagedSortedListRequestAsync(this OcipClient client, GroupAdminGetPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAdminGetPagedSortedListResponse;
        }
        /// <summary>
        /// Requests the Group administrator's policy settings.
        /// The response is either GroupAdminGetPolicyResponse20 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAdminGetPolicyRequest20Async instead.")]
        public static async Task<GroupAdminGetPolicyResponse20> GroupAdminGetPolicyRequest20(this OcipClient client, GroupAdminGetPolicyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAdminGetPolicyResponse20;
        }

        /// <summary>
        /// Requests the Group administrator's policy settings.
        /// The response is either GroupAdminGetPolicyResponse20 or ErrorResponse.
        /// </summary>
        public static async Task<GroupAdminGetPolicyResponse20> GroupAdminGetPolicyRequest20Async(this OcipClient client, GroupAdminGetPolicyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAdminGetPolicyResponse20;
        }
        /// <summary>
        /// Get a group administrators profile.
        /// The response is either a GroupAdminGetResponse21sp1 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAdminGetRequest21sp1Async instead.")]
        public static async Task<GroupAdminGetResponse21sp1> GroupAdminGetRequest21sp1(this OcipClient client, GroupAdminGetRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAdminGetResponse21sp1;
        }

        /// <summary>
        /// Get a group administrators profile.
        /// The response is either a GroupAdminGetResponse21sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupAdminGetResponse21sp1> GroupAdminGetRequest21sp1Async(this OcipClient client, GroupAdminGetRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAdminGetResponse21sp1;
        }
        /// <summary>
        /// Requests the effective password rules setting for a group administrator.
        /// The response is either GroupAdministratorPasswordRulesGetResponse or
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAdministratorPasswordRulesGetRequestAsync instead.")]
        public static async Task<GroupAdministratorPasswordRulesGetResponse> GroupAdministratorPasswordRulesGetRequest(this OcipClient client, GroupAdministratorPasswordRulesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAdministratorPasswordRulesGetResponse;
        }

        /// <summary>
        /// Requests the effective password rules setting for a group administrator.
        /// The response is either GroupAdministratorPasswordRulesGetResponse or
        /// ErrorResponse.
        /// </summary>
        public static async Task<GroupAdministratorPasswordRulesGetResponse> GroupAdministratorPasswordRulesGetRequestAsync(this OcipClient client, GroupAdministratorPasswordRulesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAdministratorPasswordRulesGetResponse;
        }
        /// <summary>
        /// Request to modify the group administrator's policy settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// dialableCallerIDAccess
        /// verifyTranslationAndRoutingAccess
        /// communicationBarringUserProfileAccess (only applicable to groups in an Enterprise)
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAdminModifyPolicyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAdminModifyPolicyRequest(this OcipClient client, GroupAdminModifyPolicyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the group administrator's policy settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// dialableCallerIDAccess
        /// verifyTranslationAndRoutingAccess
        /// communicationBarringUserProfileAccess (only applicable to groups in an Enterprise)
        /// </summary>
        public static async Task<SuccessResponse> GroupAdminModifyPolicyRequestAsync(this OcipClient client, GroupAdminModifyPolicyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a group administrator.
        /// Since old password is not specified here, any password rule related to old password
        /// does not apply.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAdminModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAdminModifyRequest(this OcipClient client, GroupAdminModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a group administrator.
        /// Since old password is not specified here, any password rule related to old password
        /// does not apply.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAdminModifyRequestAsync(this OcipClient client, GroupAdminModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an announcement to the group announcement repository
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAnnouncementFileAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAnnouncementFileAddRequest(this OcipClient client, GroupAnnouncementFileAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an announcement to the group announcement repository
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAnnouncementFileAddRequestAsync(this OcipClient client, GroupAnnouncementFileAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete one or more announcements from the group announcement repository
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAnnouncementFileDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAnnouncementFileDeleteListRequest(this OcipClient client, GroupAnnouncementFileDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete one or more announcements from the group announcement repository
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAnnouncementFileDeleteListRequestAsync(this OcipClient client, GroupAnnouncementFileDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of available announcement files for a Group.
        /// The response is either a GroupAnnouncementFileGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAnnouncementFileGetListRequestAsync instead.")]
        public static async Task<GroupAnnouncementFileGetListResponse> GroupAnnouncementFileGetListRequest(this OcipClient client, GroupAnnouncementFileGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAnnouncementFileGetListResponse;
        }

        /// <summary>
        /// Get the list of available announcement files for a Group.
        /// The response is either a GroupAnnouncementFileGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupAnnouncementFileGetListResponse> GroupAnnouncementFileGetListRequestAsync(this OcipClient client, GroupAnnouncementFileGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAnnouncementFileGetListResponse;
        }
        /// <summary>
        /// Get the list of available announcement files for
        /// a Group.
        /// If the responsePagingControl element is not provided,
        /// the paging startIndex will be set to 1 by default,
        /// and the responsePageSize will be set to the maximum responsePageSize by
        /// default.
        /// If no sortOrder is included, the response is sorted by Name ascending by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// The response is either a GroupAnnouncementFileGetPagedSortedListResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAnnouncementFileGetPagedSortedListRequestAsync instead.")]
        public static async Task<GroupAnnouncementFileGetPagedSortedListResponse> GroupAnnouncementFileGetPagedSortedListRequest(this OcipClient client, GroupAnnouncementFileGetPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAnnouncementFileGetPagedSortedListResponse;
        }

        /// <summary>
        /// Get the list of available announcement files for
        /// a Group.
        /// If the responsePagingControl element is not provided,
        /// the paging startIndex will be set to 1 by default,
        /// and the responsePageSize will be set to the maximum responsePageSize by
        /// default.
        /// If no sortOrder is included, the response is sorted by Name ascending by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// The response is either a GroupAnnouncementFileGetPagedSortedListResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<GroupAnnouncementFileGetPagedSortedListResponse> GroupAnnouncementFileGetPagedSortedListRequestAsync(this OcipClient client, GroupAnnouncementFileGetPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAnnouncementFileGetPagedSortedListResponse;
        }
        /// <summary>
        /// Request to get the announcement repository file information.
        /// The response is either GroupAnnouncementFileGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAnnouncementFileGetRequestAsync instead.")]
        public static async Task<GroupAnnouncementFileGetResponse> GroupAnnouncementFileGetRequest(this OcipClient client, GroupAnnouncementFileGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAnnouncementFileGetResponse;
        }

        /// <summary>
        /// Request to get the announcement repository file information.
        /// The response is either GroupAnnouncementFileGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupAnnouncementFileGetResponse> GroupAnnouncementFileGetRequestAsync(this OcipClient client, GroupAnnouncementFileGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAnnouncementFileGetResponse;
        }
        /// <summary>
        /// Modify an existing announcement in the group repository
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAnnouncementFileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAnnouncementFileModifyRequest(this OcipClient client, GroupAnnouncementFileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing announcement in the group repository
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAnnouncementFileModifyRequestAsync(this OcipClient client, GroupAnnouncementFileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Return the disk space being used.
        /// The response is either a GroupAnnouncementRepositoryGetSettingsResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAnnouncementRepositoryGetSettingsRequestAsync instead.")]
        public static async Task<GroupAnnouncementRepositoryGetSettingsResponse> GroupAnnouncementRepositoryGetSettingsRequest(this OcipClient client, GroupAnnouncementRepositoryGetSettingsRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAnnouncementRepositoryGetSettingsResponse;
        }

        /// <summary>
        /// Return the disk space being used.
        /// The response is either a GroupAnnouncementRepositoryGetSettingsResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupAnnouncementRepositoryGetSettingsResponse> GroupAnnouncementRepositoryGetSettingsRequestAsync(this OcipClient client, GroupAnnouncementRepositoryGetSettingsRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAnnouncementRepositoryGetSettingsResponse;
        }
        /// <summary>
        /// Get the Application Server set for a group.
        /// The response is either a GroupApplicationServerSetGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupApplicationServerSetGetRequestAsync instead.")]
        public static async Task<GroupApplicationServerSetGetResponse> GroupApplicationServerSetGetRequest(this OcipClient client, GroupApplicationServerSetGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupApplicationServerSetGetResponse;
        }

        /// <summary>
        /// Get the Application Server set for a group.
        /// The response is either a GroupApplicationServerSetGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupApplicationServerSetGetResponse> GroupApplicationServerSetGetRequestAsync(this OcipClient client, GroupApplicationServerSetGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupApplicationServerSetGetResponse;
        }
        /// <summary>
        /// Modify the Application Server set for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupApplicationServerSetModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupApplicationServerSetModifyRequest(this OcipClient client, GroupApplicationServerSetModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Application Server set for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupApplicationServerSetModifyRequestAsync(this OcipClient client, GroupApplicationServerSetModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Activates or Deactivates the BroadWorks Mobile Manager.
        /// The deactivationReason is required when isActive is set to false.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksMobileManagerActivationRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupBroadWorksMobileManagerActivationRequest(this OcipClient client, GroupBroadWorksMobileManagerActivationRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Activates or Deactivates the BroadWorks Mobile Manager.
        /// The deactivationReason is required when isActive is set to false.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupBroadWorksMobileManagerActivationRequestAsync(this OcipClient client, GroupBroadWorksMobileManagerActivationRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a home zone to the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksMobileManagerAddHomeZoneRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupBroadWorksMobileManagerAddHomeZoneRequest(this OcipClient client, GroupBroadWorksMobileManagerAddHomeZoneRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a home zone to the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupBroadWorksMobileManagerAddHomeZoneRequestAsync(this OcipClient client, GroupBroadWorksMobileManagerAddHomeZoneRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add the BroadWorks Mobile Manager.
        /// Only one BroadWorks Mobile Manager can be added per group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksMobileManagerAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupBroadWorksMobileManagerAddRequest(this OcipClient client, GroupBroadWorksMobileManagerAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add the BroadWorks Mobile Manager.
        /// Only one BroadWorks Mobile Manager can be added per group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupBroadWorksMobileManagerAddRequestAsync(this OcipClient client, GroupBroadWorksMobileManagerAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of home zones from the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksMobileManagerDeleteHomeZoneListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupBroadWorksMobileManagerDeleteHomeZoneListRequest(this OcipClient client, GroupBroadWorksMobileManagerDeleteHomeZoneListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of home zones from the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupBroadWorksMobileManagerDeleteHomeZoneListRequestAsync(this OcipClient client, GroupBroadWorksMobileManagerDeleteHomeZoneListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a home zone from the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksMobileManagerDeleteHomeZoneRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupBroadWorksMobileManagerDeleteHomeZoneRequest(this OcipClient client, GroupBroadWorksMobileManagerDeleteHomeZoneRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a home zone from the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupBroadWorksMobileManagerDeleteHomeZoneRequestAsync(this OcipClient client, GroupBroadWorksMobileManagerDeleteHomeZoneRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksMobileManagerDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupBroadWorksMobileManagerDeleteRequest(this OcipClient client, GroupBroadWorksMobileManagerDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupBroadWorksMobileManagerDeleteRequestAsync(this OcipClient client, GroupBroadWorksMobileManagerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of domains of the BroadWorks Mobile Manager.
        /// The response is either GroupBroadWorksMobileManagerGetDomainListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksMobileManagerGetDomainListRequestAsync instead.")]
        public static async Task<GroupBroadWorksMobileManagerGetDomainListResponse> GroupBroadWorksMobileManagerGetDomainListRequest(this OcipClient client, GroupBroadWorksMobileManagerGetDomainListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupBroadWorksMobileManagerGetDomainListResponse;
        }

        /// <summary>
        /// Get the list of domains of the BroadWorks Mobile Manager.
        /// The response is either GroupBroadWorksMobileManagerGetDomainListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupBroadWorksMobileManagerGetDomainListResponse> GroupBroadWorksMobileManagerGetDomainListRequestAsync(this OcipClient client, GroupBroadWorksMobileManagerGetDomainListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupBroadWorksMobileManagerGetDomainListResponse;
        }
        /// <summary>
        /// Get the list of home zones of the BroadWorks Mobile Manager.
        /// The response is either GroupBroadWorksMobileManagerGetHomeZoneListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksMobileManagerGetHomeZoneListRequestAsync instead.")]
        public static async Task<GroupBroadWorksMobileManagerGetHomeZoneListResponse> GroupBroadWorksMobileManagerGetHomeZoneListRequest(this OcipClient client, GroupBroadWorksMobileManagerGetHomeZoneListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupBroadWorksMobileManagerGetHomeZoneListResponse;
        }

        /// <summary>
        /// Get the list of home zones of the BroadWorks Mobile Manager.
        /// The response is either GroupBroadWorksMobileManagerGetHomeZoneListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupBroadWorksMobileManagerGetHomeZoneListResponse> GroupBroadWorksMobileManagerGetHomeZoneListRequestAsync(this OcipClient client, GroupBroadWorksMobileManagerGetHomeZoneListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupBroadWorksMobileManagerGetHomeZoneListResponse;
        }
        /// <summary>
        /// Get a home zone from the BroadWorks Mobile Manager.
        /// The response is either GroupBroadWorksMobileManagerGetHomeZoneResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksMobileManagerGetHomeZoneRequestAsync instead.")]
        public static async Task<GroupBroadWorksMobileManagerGetHomeZoneResponse> GroupBroadWorksMobileManagerGetHomeZoneRequest(this OcipClient client, GroupBroadWorksMobileManagerGetHomeZoneRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupBroadWorksMobileManagerGetHomeZoneResponse;
        }

        /// <summary>
        /// Get a home zone from the BroadWorks Mobile Manager.
        /// The response is either GroupBroadWorksMobileManagerGetHomeZoneResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupBroadWorksMobileManagerGetHomeZoneResponse> GroupBroadWorksMobileManagerGetHomeZoneRequestAsync(this OcipClient client, GroupBroadWorksMobileManagerGetHomeZoneRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupBroadWorksMobileManagerGetHomeZoneResponse;
        }
        /// <summary>
        /// Get the BroadWorks Mobile Manager.
        /// The response is either GroupBroadWorksMobileManagerGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksMobileManagerGetRequestAsync instead.")]
        public static async Task<GroupBroadWorksMobileManagerGetResponse> GroupBroadWorksMobileManagerGetRequest(this OcipClient client, GroupBroadWorksMobileManagerGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupBroadWorksMobileManagerGetResponse;
        }

        /// <summary>
        /// Get the BroadWorks Mobile Manager.
        /// The response is either GroupBroadWorksMobileManagerGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupBroadWorksMobileManagerGetResponse> GroupBroadWorksMobileManagerGetRequestAsync(this OcipClient client, GroupBroadWorksMobileManagerGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupBroadWorksMobileManagerGetResponse;
        }
        /// <summary>
        /// Modify an existing home zone in the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksMobileManagerModifyHomeZoneRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupBroadWorksMobileManagerModifyHomeZoneRequest(this OcipClient client, GroupBroadWorksMobileManagerModifyHomeZoneRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing home zone in the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupBroadWorksMobileManagerModifyHomeZoneRequestAsync(this OcipClient client, GroupBroadWorksMobileManagerModifyHomeZoneRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the BroadWorks Mobile Manager settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksMobileManagerModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupBroadWorksMobileManagerModifyRequest(this OcipClient client, GroupBroadWorksMobileManagerModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the BroadWorks Mobile Manager settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupBroadWorksMobileManagerModifyRequestAsync(this OcipClient client, GroupBroadWorksMobileManagerModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Sends an email with the carrier information and certificate files.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksMobileManagerSendCarrierFilesRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupBroadWorksMobileManagerSendCarrierFilesRequest(this OcipClient client, GroupBroadWorksMobileManagerSendCarrierFilesRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Sends an email with the carrier information and certificate files.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupBroadWorksMobileManagerSendCarrierFilesRequestAsync(this OcipClient client, GroupBroadWorksMobileManagerSendCarrierFilesRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse22V2 or an
        /// ErrorResponse.
        /// 
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy,enterpriseCallsCLIDPolicy, groupCallsCLIDPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowDepartmentCLIDNameOverride)
        /// 
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// 
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls, maxCallTimeForUnansweredCallsMinutes,
        /// useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth, maxRedirectionDepth,
        /// useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations,
        /// useMaxConcurrentTerminatingAlertingRequests, maxConcurrentTerminatingAlertingRequests)
        /// 
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan, overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallProcessingGetPolicyRequest22V2Async instead.")]
        public static async Task<GroupCallProcessingGetPolicyResponse22V2> GroupCallProcessingGetPolicyRequest22V2(this OcipClient client, GroupCallProcessingGetPolicyRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallProcessingGetPolicyResponse22V2;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse22V2 or an
        /// ErrorResponse.
        /// 
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy,enterpriseCallsCLIDPolicy, groupCallsCLIDPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowDepartmentCLIDNameOverride)
        /// 
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// 
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls, maxCallTimeForUnansweredCallsMinutes,
        /// useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth, maxRedirectionDepth,
        /// useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations,
        /// useMaxConcurrentTerminatingAlertingRequests, maxConcurrentTerminatingAlertingRequests)
        /// 
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan, overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse22V2> GroupCallProcessingGetPolicyRequest22V2Async(this OcipClient client, GroupCallProcessingGetPolicyRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallProcessingGetPolicyResponse22V2;
        }
        /// <summary>
        /// Modify the group level data associated with Call Processing Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy,enterpriseCallsCLIDPolicy, groupCallsCLIDPolicy,  emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowConfigurableCLIDForRedirectingIdentity, allowDepartmentCLIDNameOverride
        /// useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable, useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailabl)
        /// 
        /// The allowDepartmentCLID attribute is automatically set to false when the useGroupName attribute is set to false.
        /// 
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// 
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls, useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls,
        /// useMaxCallTimeForAnsweredCalls, maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls,
        /// maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth,
        /// maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations,
        /// useMaxConcurrentTerminatingAlertingRequests, maxConcurrentTerminatingAlertingRequests,
        /// includeRedirectionsInMaximumNumberOfConcurrentCalls)
        /// 
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings (networkUsageSelection, enforceGroupCallingLineIdentityRestriction, allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan, overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing, routeOverrideDomain, routeOverridePrefix)
        /// The useGroupDCLIDSetting controls the Dialable Caller ID settings (enableDialableCallerID)
        /// 
        /// The useGroupPhoneListLookupSetting controls whether or not to use the enterprise/service provider setting for the Phone List Lookup policy (enablePhoneListLookup)
        /// 
        /// The following elements are only used in AS data mode:
        /// useGroupDCLIDSetting
        /// enableDialableCallerID
        /// allowConfigurableCLIDForRedirectingIdentity
        /// allowDepartmentCLIDNameOverride
        /// allowConfigurableCLIDForRedirectingIdentity
        /// enterpriseCallsCLIDPolicy
        /// groupCallsCLIDPolicy
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useGroupPhoneListLookupSetting
        /// enablePhoneListLookup
        /// useMaxConcurrentTerminatingAlertingRequests
        /// maxConcurrentTerminatingAlertingRequests
        /// includeRedirectionsInMaximumNumberOfConcurrentCalls
        /// useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable
        /// useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable
        /// allowMobileDNForRedirectingIdentity
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// routeOverrideDomain
        /// routeOverridePrefix
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallProcessingModifyPolicyRequest15sp2Async instead.")]
        public static async Task<SuccessResponse> GroupCallProcessingModifyPolicyRequest15sp2(this OcipClient client, GroupCallProcessingModifyPolicyRequest15sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group level data associated with Call Processing Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy,enterpriseCallsCLIDPolicy, groupCallsCLIDPolicy,  emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowConfigurableCLIDForRedirectingIdentity, allowDepartmentCLIDNameOverride
        /// useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable, useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailabl)
        /// 
        /// The allowDepartmentCLID attribute is automatically set to false when the useGroupName attribute is set to false.
        /// 
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// 
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls, useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls,
        /// useMaxCallTimeForAnsweredCalls, maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls,
        /// maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth,
        /// maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations,
        /// useMaxConcurrentTerminatingAlertingRequests, maxConcurrentTerminatingAlertingRequests,
        /// includeRedirectionsInMaximumNumberOfConcurrentCalls)
        /// 
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings (networkUsageSelection, enforceGroupCallingLineIdentityRestriction, allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan, overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing, routeOverrideDomain, routeOverridePrefix)
        /// The useGroupDCLIDSetting controls the Dialable Caller ID settings (enableDialableCallerID)
        /// 
        /// The useGroupPhoneListLookupSetting controls whether or not to use the enterprise/service provider setting for the Phone List Lookup policy (enablePhoneListLookup)
        /// 
        /// The following elements are only used in AS data mode:
        /// useGroupDCLIDSetting
        /// enableDialableCallerID
        /// allowConfigurableCLIDForRedirectingIdentity
        /// allowDepartmentCLIDNameOverride
        /// allowConfigurableCLIDForRedirectingIdentity
        /// enterpriseCallsCLIDPolicy
        /// groupCallsCLIDPolicy
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useGroupPhoneListLookupSetting
        /// enablePhoneListLookup
        /// useMaxConcurrentTerminatingAlertingRequests
        /// maxConcurrentTerminatingAlertingRequests
        /// includeRedirectionsInMaximumNumberOfConcurrentCalls
        /// useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable
        /// useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable
        /// allowMobileDNForRedirectingIdentity
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// routeOverrideDomain
        /// routeOverridePrefix
        /// </summary>
        public static async Task<SuccessResponse> GroupCallProcessingModifyPolicyRequest15sp2Async(this OcipClient client, GroupCallProcessingModifyPolicyRequest15sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add one or more entries to a group's common phone list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCommonPhoneListAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCommonPhoneListAddListRequest(this OcipClient client, GroupCommonPhoneListAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add one or more entries to a group's common phone list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCommonPhoneListAddListRequestAsync(this OcipClient client, GroupCommonPhoneListAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete one or more entries from a group's common phone list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCommonPhoneListDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCommonPhoneListDeleteListRequest(this OcipClient client, GroupCommonPhoneListDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete one or more entries from a group's common phone list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCommonPhoneListDeleteListRequestAsync(this OcipClient client, GroupCommonPhoneListDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a group's common phone list.
        /// The response is either a GroupCommonPhoneListGetListResponse or an ErrorResponse.
        /// The search can be done using multiple criterion.
        /// If the searchCriteriaModeOr is present, any result matching any one criteria is included in the results.
        /// Otherwise, only results matching all the search criterion are included in the results.
        /// If no search criteria is specified, all results are returned.
        /// Specifying searchCriteriaModeOr without any search criteria results in an ErrorResponse.
        /// In all cases, if a responseSizeLimit is specified and the number of matching results is more than this limit, then an
        /// ErrorResponse is returned.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCommonPhoneListGetListRequestAsync instead.")]
        public static async Task<GroupCommonPhoneListGetListResponse> GroupCommonPhoneListGetListRequest(this OcipClient client, GroupCommonPhoneListGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCommonPhoneListGetListResponse;
        }

        /// <summary>
        /// Get a group's common phone list.
        /// The response is either a GroupCommonPhoneListGetListResponse or an ErrorResponse.
        /// The search can be done using multiple criterion.
        /// If the searchCriteriaModeOr is present, any result matching any one criteria is included in the results.
        /// Otherwise, only results matching all the search criterion are included in the results.
        /// If no search criteria is specified, all results are returned.
        /// Specifying searchCriteriaModeOr without any search criteria results in an ErrorResponse.
        /// In all cases, if a responseSizeLimit is specified and the number of matching results is more than this limit, then an
        /// ErrorResponse is returned.
        /// </summary>
        public static async Task<GroupCommonPhoneListGetListResponse> GroupCommonPhoneListGetListRequestAsync(this OcipClient client, GroupCommonPhoneListGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCommonPhoneListGetListResponse;
        }
        /// <summary>
        /// Modify an entry in a group's common phone list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCommonPhoneListModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCommonPhoneListModifyRequest(this OcipClient client, GroupCommonPhoneListModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an entry in a group's common phone list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCommonPhoneListModifyRequestAsync(this OcipClient client, GroupCommonPhoneListModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a list of Communication Barring Authorization codes to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCommunicationBarringAuthorizationCodeAddListRequest21sp1Async instead.")]
        public static async Task<SuccessResponse> GroupCommunicationBarringAuthorizationCodeAddListRequest21sp1(this OcipClient client, GroupCommunicationBarringAuthorizationCodeAddListRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of Communication Barring Authorization codes to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCommunicationBarringAuthorizationCodeAddListRequest21sp1Async(this OcipClient client, GroupCommunicationBarringAuthorizationCodeAddListRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of Communication Barring Authorization codes from a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCommunicationBarringAuthorizationCodeDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCommunicationBarringAuthorizationCodeDeleteListRequest(this OcipClient client, GroupCommunicationBarringAuthorizationCodeDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of Communication Barring Authorization codes from a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCommunicationBarringAuthorizationCodeDeleteListRequestAsync(this OcipClient client, GroupCommunicationBarringAuthorizationCodeDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Communication Barring Authorization Codes for a group.
        /// The response is either GroupCommunicationBarringAuthorizationCodeGetListResponse21sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCommunicationBarringAuthorizationCodeGetListRequest21sp1Async instead.")]
        public static async Task<GroupCommunicationBarringAuthorizationCodeGetListResponse21sp1> GroupCommunicationBarringAuthorizationCodeGetListRequest21sp1(this OcipClient client, GroupCommunicationBarringAuthorizationCodeGetListRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCommunicationBarringAuthorizationCodeGetListResponse21sp1;
        }

        /// <summary>
        /// Get a list of Communication Barring Authorization Codes for a group.
        /// The response is either GroupCommunicationBarringAuthorizationCodeGetListResponse21sp1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupCommunicationBarringAuthorizationCodeGetListResponse21sp1> GroupCommunicationBarringAuthorizationCodeGetListRequest21sp1Async(this OcipClient client, GroupCommunicationBarringAuthorizationCodeGetListRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCommunicationBarringAuthorizationCodeGetListResponse21sp1;
        }
        /// <summary>
        /// Request the group Communication Barring Authorization Code setting.
        /// The response is either a GroupCommunicationBarringAuthorizationCodeGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCommunicationBarringAuthorizationCodeGetRequestAsync instead.")]
        public static async Task<GroupCommunicationBarringAuthorizationCodeGetResponse> GroupCommunicationBarringAuthorizationCodeGetRequest(this OcipClient client, GroupCommunicationBarringAuthorizationCodeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCommunicationBarringAuthorizationCodeGetResponse;
        }

        /// <summary>
        /// Request the group Communication Barring Authorization Code setting.
        /// The response is either a GroupCommunicationBarringAuthorizationCodeGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCommunicationBarringAuthorizationCodeGetResponse> GroupCommunicationBarringAuthorizationCodeGetRequestAsync(this OcipClient client, GroupCommunicationBarringAuthorizationCodeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCommunicationBarringAuthorizationCodeGetResponse;
        }
        /// <summary>
        /// Modify the group Communication Barring Authorization Code settings
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCommunicationBarringAuthorizationCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCommunicationBarringAuthorizationCodeModifyRequest(this OcipClient client, GroupCommunicationBarringAuthorizationCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group Communication Barring Authorization Code settings
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCommunicationBarringAuthorizationCodeModifyRequestAsync(this OcipClient client, GroupCommunicationBarringAuthorizationCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Gets Communication Barring setting for a group.
        /// The response is either a GroupCommunicationBarringGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCommunicationBarringGetRequestAsync instead.")]
        public static async Task<GroupCommunicationBarringGetResponse> GroupCommunicationBarringGetRequest(this OcipClient client, GroupCommunicationBarringGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCommunicationBarringGetResponse;
        }

        /// <summary>
        /// Gets Communication Barring setting for a group.
        /// The response is either a GroupCommunicationBarringGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCommunicationBarringGetResponse> GroupCommunicationBarringGetRequestAsync(this OcipClient client, GroupCommunicationBarringGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCommunicationBarringGetResponse;
        }
        /// <summary>
        /// Gets Communication Barring setting for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCommunicationBarringModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCommunicationBarringModifyRequest(this OcipClient client, GroupCommunicationBarringModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Gets Communication Barring setting for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCommunicationBarringModifyRequestAsync(this OcipClient client, GroupCommunicationBarringModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all communication barring profiles assigned to the group.
        /// The response is either a GroupCommunicationBarringProfileGetAssignedListResponse or an ErrorResponse.
        /// This command only applies to groups in an Enterprise. This command will fail for groups in a Service Provider.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCommunicationBarringProfileGetAssignedListRequestAsync instead.")]
        public static async Task<GroupCommunicationBarringProfileGetAssignedListResponse> GroupCommunicationBarringProfileGetAssignedListRequest(this OcipClient client, GroupCommunicationBarringProfileGetAssignedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCommunicationBarringProfileGetAssignedListResponse;
        }

        /// <summary>
        /// Get the list of all communication barring profiles assigned to the group.
        /// The response is either a GroupCommunicationBarringProfileGetAssignedListResponse or an ErrorResponse.
        /// This command only applies to groups in an Enterprise. This command will fail for groups in a Service Provider.
        /// </summary>
        public static async Task<GroupCommunicationBarringProfileGetAssignedListResponse> GroupCommunicationBarringProfileGetAssignedListRequestAsync(this OcipClient client, GroupCommunicationBarringProfileGetAssignedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCommunicationBarringProfileGetAssignedListResponse;
        }
        /// <summary>
        /// Assign a replacement list of Communication Barring Profiles to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// This command only applies to groups in an Enterprise. This command will fail for groups in a Service Provider.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCommunicationBarringProfileModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCommunicationBarringProfileModifyListRequest(this OcipClient client, GroupCommunicationBarringProfileModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a replacement list of Communication Barring Profiles to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// This command only applies to groups in an Enterprise. This command will fail for groups in a Service Provider.
        /// </summary>
        public static async Task<SuccessResponse> GroupCommunicationBarringProfileModifyListRequestAsync(this OcipClient client, GroupCommunicationBarringProfileModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Rebuild the group default config file for the specified device type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCPEConfigRebuildConfigFileRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCPEConfigRebuildConfigFileRequest(this OcipClient client, GroupCPEConfigRebuildConfigFileRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Rebuild the group default config file for the specified device type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCPEConfigRebuildConfigFileRequestAsync(this OcipClient client, GroupCPEConfigRebuildConfigFileRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Rebuild the config file for a specified device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// force
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCPEConfigRebuildDeviceConfigFileRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCPEConfigRebuildDeviceConfigFileRequest(this OcipClient client, GroupCPEConfigRebuildDeviceConfigFileRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Rebuild the config file for a specified device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// force
        /// </summary>
        public static async Task<SuccessResponse> GroupCPEConfigRebuildDeviceConfigFileRequestAsync(this OcipClient client, GroupCPEConfigRebuildDeviceConfigFileRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Reorder the lines of a group device. You can not add or delete line ports, only
        /// re-ordering the list is allowed. The ordered list of line ports can be obtained
        /// with the GroupAccessDeviceGetRequest16 command.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCPEConfigReorderDeviceLinePortsRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCPEConfigReorderDeviceLinePortsRequest(this OcipClient client, GroupCPEConfigReorderDeviceLinePortsRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Reorder the lines of a group device. You can not add or delete line ports, only
        /// re-ordering the list is allowed. The ordered list of line ports can be obtained
        /// with the GroupAccessDeviceGetRequest16 command.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCPEConfigReorderDeviceLinePortsRequestAsync(this OcipClient client, GroupCPEConfigReorderDeviceLinePortsRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Reset a specific group device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCPEConfigResetDeviceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCPEConfigResetDeviceRequest(this OcipClient client, GroupCPEConfigResetDeviceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Reset a specific group device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCPEConfigResetDeviceRequestAsync(this OcipClient client, GroupCPEConfigResetDeviceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Reset all the devices of the specified device type in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCPEConfigResetDeviceTypeRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCPEConfigResetDeviceTypeRequest(this OcipClient client, GroupCPEConfigResetDeviceTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Reset all the devices of the specified device type in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCPEConfigResetDeviceTypeRequestAsync(this OcipClient client, GroupCPEConfigResetDeviceTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to set a new group default configuration file for a device type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// When the element configFile is set to nil, the configuration file defined
        /// at the parent level is used.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCPEConfigSetConfigFileRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCPEConfigSetConfigFileRequest(this OcipClient client, GroupCPEConfigSetConfigFileRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to set a new group default configuration file for a device type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// When the element configFile is set to nil, the configuration file defined
        /// at the parent level is used.
        /// </summary>
        public static async Task<SuccessResponse> GroupCPEConfigSetConfigFileRequestAsync(this OcipClient client, GroupCPEConfigSetConfigFileRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Adds a Custom Contact Directory to a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCustomContactDirectoryAddRequest17Async instead.")]
        public static async Task<SuccessResponse> GroupCustomContactDirectoryAddRequest17(this OcipClient client, GroupCustomContactDirectoryAddRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Adds a Custom Contact Directory to a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCustomContactDirectoryAddRequest17Async(this OcipClient client, GroupCustomContactDirectoryAddRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deletes a Custom Contact Directory to a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCustomContactDirectoryDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCustomContactDirectoryDeleteRequest(this OcipClient client, GroupCustomContactDirectoryDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deletes a Custom Contact Directory to a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCustomContactDirectoryDeleteRequestAsync(this OcipClient client, GroupCustomContactDirectoryDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of users that can be part of a custom contact directory.
        /// The response is either GroupCustomContactDirectoryGetAvailableUserListResponse17 or  ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCustomContactDirectoryGetAvailableUserListRequest17Async instead.")]
        public static async Task<GroupCustomContactDirectoryGetAvailableUserListResponse17> GroupCustomContactDirectoryGetAvailableUserListRequest17(this OcipClient client, GroupCustomContactDirectoryGetAvailableUserListRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCustomContactDirectoryGetAvailableUserListResponse17;
        }

        /// <summary>
        /// Get a list of users that can be part of a custom contact directory.
        /// The response is either GroupCustomContactDirectoryGetAvailableUserListResponse17 or  ErrorResponse.
        /// </summary>
        public static async Task<GroupCustomContactDirectoryGetAvailableUserListResponse17> GroupCustomContactDirectoryGetAvailableUserListRequest17Async(this OcipClient client, GroupCustomContactDirectoryGetAvailableUserListRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCustomContactDirectoryGetAvailableUserListResponse17;
        }
        /// <summary>
        /// Gets the list of Custom Contact Directories for a group.
        /// The response is either GroupCustomContactDirectoryGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCustomContactDirectoryGetListRequestAsync instead.")]
        public static async Task<GroupCustomContactDirectoryGetListResponse> GroupCustomContactDirectoryGetListRequest(this OcipClient client, GroupCustomContactDirectoryGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCustomContactDirectoryGetListResponse;
        }

        /// <summary>
        /// Gets the list of Custom Contact Directories for a group.
        /// The response is either GroupCustomContactDirectoryGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCustomContactDirectoryGetListResponse> GroupCustomContactDirectoryGetListRequestAsync(this OcipClient client, GroupCustomContactDirectoryGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCustomContactDirectoryGetListResponse;
        }
        /// <summary>
        /// Gets a Custom Contact Directory in a group.
        /// The response is either GroupCustomContactDirectoryGetResponse17 or
        /// ErrorResponse.
        /// The search can be done using multiple criterion.
        /// If the searchCriteriaModeOr is present, any result matching any one criteria is included in the results.
        /// Otherwise, only results matching all the search criterion are included in the results.
        /// If no search criteria is specified, all results are returned.
        /// Specifying searchCriteriaModeOr without any search criteria results in an ErrorResponse.
        /// In all cases, if a responseSizeLimit is specified and the number of matching results is more than this limit, then an
        /// ErrorResponse is returned. The Receptionist Note column is only populated in AS mode; and populated only if the user
        /// sending the request is a the owner of this Receptionist Note and a Note exists.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCustomContactDirectoryGetRequest17Async instead.")]
        public static async Task<GroupCustomContactDirectoryGetResponse17> GroupCustomContactDirectoryGetRequest17(this OcipClient client, GroupCustomContactDirectoryGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCustomContactDirectoryGetResponse17;
        }

        /// <summary>
        /// Gets a Custom Contact Directory in a group.
        /// The response is either GroupCustomContactDirectoryGetResponse17 or
        /// ErrorResponse.
        /// The search can be done using multiple criterion.
        /// If the searchCriteriaModeOr is present, any result matching any one criteria is included in the results.
        /// Otherwise, only results matching all the search criterion are included in the results.
        /// If no search criteria is specified, all results are returned.
        /// Specifying searchCriteriaModeOr without any search criteria results in an ErrorResponse.
        /// In all cases, if a responseSizeLimit is specified and the number of matching results is more than this limit, then an
        /// ErrorResponse is returned. The Receptionist Note column is only populated in AS mode; and populated only if the user
        /// sending the request is a the owner of this Receptionist Note and a Note exists.
        /// </summary>
        public static async Task<GroupCustomContactDirectoryGetResponse17> GroupCustomContactDirectoryGetRequest17Async(this OcipClient client, GroupCustomContactDirectoryGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCustomContactDirectoryGetResponse17;
        }
        /// <summary>
        /// Adds a Custom Contact Directory to a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCustomContactDirectoryModifyRequest17Async instead.")]
        public static async Task<SuccessResponse> GroupCustomContactDirectoryModifyRequest17(this OcipClient client, GroupCustomContactDirectoryModifyRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Adds a Custom Contact Directory to a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCustomContactDirectoryModifyRequest17Async(this OcipClient client, GroupCustomContactDirectoryModifyRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDeleteRequest(this OcipClient client, GroupDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDeleteRequestAsync(this OcipClient client, GroupDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a department to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// callingLineIdName
        /// caliingLineIdPhoneNumber
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDepartmentAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDepartmentAddRequest(this OcipClient client, GroupDepartmentAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a department to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// callingLineIdName
        /// caliingLineIdPhoneNumber
        /// </summary>
        public static async Task<SuccessResponse> GroupDepartmentAddRequestAsync(this OcipClient client, GroupDepartmentAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a department administrator to a group department.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDepartmentAdminAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDepartmentAdminAddRequest(this OcipClient client, GroupDepartmentAdminAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a department administrator to a group department.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDepartmentAdminAddRequestAsync(this OcipClient client, GroupDepartmentAdminAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a group department administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDepartmentAdminDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDepartmentAdminDeleteRequest(this OcipClient client, GroupDepartmentAdminDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a group department administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDepartmentAdminDeleteRequestAsync(this OcipClient client, GroupDepartmentAdminDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of department administrators for the department.
        /// The response is either a GroupDepartmentAdminGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDepartmentAdminGetListRequestAsync instead.")]
        public static async Task<GroupDepartmentAdminGetListResponse> GroupDepartmentAdminGetListRequest(this OcipClient client, GroupDepartmentAdminGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDepartmentAdminGetListResponse;
        }

        /// <summary>
        /// Get a list of department administrators for the department.
        /// The response is either a GroupDepartmentAdminGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupDepartmentAdminGetListResponse> GroupDepartmentAdminGetListRequestAsync(this OcipClient client, GroupDepartmentAdminGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDepartmentAdminGetListResponse;
        }
        /// <summary>
        /// Get a group department administrators profile.
        /// The response is either a GroupDepartmentAdminGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDepartmentAdminGetRequestAsync instead.")]
        public static async Task<GroupDepartmentAdminGetResponse> GroupDepartmentAdminGetRequest(this OcipClient client, GroupDepartmentAdminGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDepartmentAdminGetResponse;
        }

        /// <summary>
        /// Get a group department administrators profile.
        /// The response is either a GroupDepartmentAdminGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupDepartmentAdminGetResponse> GroupDepartmentAdminGetRequestAsync(this OcipClient client, GroupDepartmentAdminGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDepartmentAdminGetResponse;
        }
        /// <summary>
        /// Modify a group department administrator.
        /// Since old password is not specified here, any password rule related to old password
        /// does not apply.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDepartmentAdminModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDepartmentAdminModifyRequest(this OcipClient client, GroupDepartmentAdminModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a group department administrator.
        /// Since old password is not specified here, any password rule related to old password
        /// does not apply.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDepartmentAdminModifyRequestAsync(this OcipClient client, GroupDepartmentAdminModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a department from a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDepartmentDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDepartmentDeleteRequest(this OcipClient client, GroupDepartmentDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a department from a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDepartmentDeleteRequestAsync(this OcipClient client, GroupDepartmentDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of departments that could be the parent department of the specified
        /// department. The department itself and all its descendents are not eligible to be
        /// the parent department. If the group belongs to an enterprise, it also returns the
        /// departments defined in the enterprise it belongs to.
        /// The response is either GroupDepartmentGetAvailableParentListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDepartmentGetAvailableParentListRequestAsync instead.")]
        public static async Task<GroupDepartmentGetAvailableParentListResponse> GroupDepartmentGetAvailableParentListRequest(this OcipClient client, GroupDepartmentGetAvailableParentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDepartmentGetAvailableParentListResponse;
        }

        /// <summary>
        /// Get a list of departments that could be the parent department of the specified
        /// department. The department itself and all its descendents are not eligible to be
        /// the parent department. If the group belongs to an enterprise, it also returns the
        /// departments defined in the enterprise it belongs to.
        /// The response is either GroupDepartmentGetAvailableParentListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupDepartmentGetAvailableParentListResponse> GroupDepartmentGetAvailableParentListRequestAsync(this OcipClient client, GroupDepartmentGetAvailableParentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDepartmentGetAvailableParentListResponse;
        }
        /// <summary>
        /// Request a list of departments in a group. You may request only the
        /// list of departments defined at the group-level, or you may request
        /// the list of all departments in the group including all the departments
        /// defined within the enterprise the group belongs to.
        /// The response is either GroupDepartmentGetListResponse18 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDepartmentGetListRequest18Async instead.")]
        public static async Task<GroupDepartmentGetListResponse18> GroupDepartmentGetListRequest18(this OcipClient client, GroupDepartmentGetListRequest18 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDepartmentGetListResponse18;
        }

        /// <summary>
        /// Request a list of departments in a group. You may request only the
        /// list of departments defined at the group-level, or you may request
        /// the list of all departments in the group including all the departments
        /// defined within the enterprise the group belongs to.
        /// The response is either GroupDepartmentGetListResponse18 or ErrorResponse.
        /// </summary>
        public static async Task<GroupDepartmentGetListResponse18> GroupDepartmentGetListRequest18Async(this OcipClient client, GroupDepartmentGetListRequest18 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDepartmentGetListResponse18;
        }
        /// <summary>
        /// Request the attributes of a department.
        /// The response is either a GroupDepartmentGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDepartmentGetRequestAsync instead.")]
        public static async Task<GroupDepartmentGetResponse> GroupDepartmentGetRequest(this OcipClient client, GroupDepartmentGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDepartmentGetResponse;
        }

        /// <summary>
        /// Request the attributes of a department.
        /// The response is either a GroupDepartmentGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupDepartmentGetResponse> GroupDepartmentGetRequestAsync(this OcipClient client, GroupDepartmentGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDepartmentGetResponse;
        }
        /// <summary>
        /// Modify a department of a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// callingLineIdName
        /// caliingLineIdPhoneNumber
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDepartmentModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDepartmentModifyRequest(this OcipClient client, GroupDepartmentModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a department of a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// callingLineIdName
        /// caliingLineIdPhoneNumber
        /// </summary>
        public static async Task<SuccessResponse> GroupDepartmentModifyRequestAsync(this OcipClient client, GroupDepartmentModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request device management's events for a specific queue.
        /// It is possible to restrict the number of rows returned using
        /// responseSizeLimit.
        /// If eventQueueType is not specified, the events from all the
        /// event queues are returned.
        /// The response is either a GroupDeviceManagementEventGetListResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDeviceManagementEventGetListRequest22Async instead.")]
        public static async Task<GroupDeviceManagementEventGetListResponse22> GroupDeviceManagementEventGetListRequest22(this OcipClient client, GroupDeviceManagementEventGetListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDeviceManagementEventGetListResponse22;
        }

        /// <summary>
        /// Request device management's events for a specific queue.
        /// It is possible to restrict the number of rows returned using
        /// responseSizeLimit.
        /// If eventQueueType is not specified, the events from all the
        /// event queues are returned.
        /// The response is either a GroupDeviceManagementEventGetListResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupDeviceManagementEventGetListResponse22> GroupDeviceManagementEventGetListRequest22Async(this OcipClient client, GroupDeviceManagementEventGetListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDeviceManagementEventGetListResponse22;
        }
        /// <summary>
        /// Request the number of access device of a particular device type and group.
        /// If countOnlyResetSupportedDevice is true, count only access devices if the device type supports reset.
        /// By default unmanaged device types are not allowed and devices are counted only if their device type supports Device Management.
        /// An error is returned if deviceType is specified but does not support device management.
        /// When allowUnmanagedDeviceType is true, unmanaged device type will be counted and a successful response is returned.
        /// The response is either GroupDeviceManagementGetAccessDeviceCountForDeviceTypeGroupResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDeviceManagementGetAccessDeviceCountForDeviceTypeGroupRequestAsync instead.")]
        public static async Task<GroupDeviceManagementGetAccessDeviceCountForDeviceTypeGroupResponse> GroupDeviceManagementGetAccessDeviceCountForDeviceTypeGroupRequest(this OcipClient client, GroupDeviceManagementGetAccessDeviceCountForDeviceTypeGroupRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDeviceManagementGetAccessDeviceCountForDeviceTypeGroupResponse;
        }

        /// <summary>
        /// Request the number of access device of a particular device type and group.
        /// If countOnlyResetSupportedDevice is true, count only access devices if the device type supports reset.
        /// By default unmanaged device types are not allowed and devices are counted only if their device type supports Device Management.
        /// An error is returned if deviceType is specified but does not support device management.
        /// When allowUnmanagedDeviceType is true, unmanaged device type will be counted and a successful response is returned.
        /// The response is either GroupDeviceManagementGetAccessDeviceCountForDeviceTypeGroupResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupDeviceManagementGetAccessDeviceCountForDeviceTypeGroupResponse> GroupDeviceManagementGetAccessDeviceCountForDeviceTypeGroupRequestAsync(this OcipClient client, GroupDeviceManagementGetAccessDeviceCountForDeviceTypeGroupRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDeviceManagementGetAccessDeviceCountForDeviceTypeGroupResponse;
        }
        /// <summary>
        /// Cancel pending and in progress events.  A list of individual events can
        /// be canceled.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDeviceManagementInProgressAndPendingEventCancelRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDeviceManagementInProgressAndPendingEventCancelRequest(this OcipClient client, GroupDeviceManagementInProgressAndPendingEventCancelRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Cancel pending and in progress events.  A list of individual events can
        /// be canceled.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDeviceManagementInProgressAndPendingEventCancelRequestAsync(this OcipClient client, GroupDeviceManagementInProgressAndPendingEventCancelRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a static configuration tag for an access device type used in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDeviceTypeCustomTagAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDeviceTypeCustomTagAddRequest(this OcipClient client, GroupDeviceTypeCustomTagAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a static configuration tag for an access device type used in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDeviceTypeCustomTagAddRequestAsync(this OcipClient client, GroupDeviceTypeCustomTagAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete static configuration tags for an access device type used in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDeviceTypeCustomTagDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDeviceTypeCustomTagDeleteListRequest(this OcipClient client, GroupDeviceTypeCustomTagDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete static configuration tags for an access device type used in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDeviceTypeCustomTagDeleteListRequestAsync(this OcipClient client, GroupDeviceTypeCustomTagDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of custom configuration tags managed by the Device Management System, on a per-device type basis for a group.
        /// The response is either GroupDeviceTypeCustomTagGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDeviceTypeCustomTagGetListRequestAsync instead.")]
        public static async Task<GroupDeviceTypeCustomTagGetListResponse> GroupDeviceTypeCustomTagGetListRequest(this OcipClient client, GroupDeviceTypeCustomTagGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDeviceTypeCustomTagGetListResponse;
        }

        /// <summary>
        /// Request to get the list of custom configuration tags managed by the Device Management System, on a per-device type basis for a group.
        /// The response is either GroupDeviceTypeCustomTagGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupDeviceTypeCustomTagGetListResponse> GroupDeviceTypeCustomTagGetListRequestAsync(this OcipClient client, GroupDeviceTypeCustomTagGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDeviceTypeCustomTagGetListResponse;
        }
        /// <summary>
        /// Request to modify a static configuration tag for an access device type used in a group.
        /// 
        /// The tagValueToEncrypt element can only be used by a system administrator.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDeviceTypeCustomTagModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDeviceTypeCustomTagModifyRequest(this OcipClient client, GroupDeviceTypeCustomTagModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag for an access device type used in a group.
        /// 
        /// The tagValueToEncrypt element can only be used by a system administrator.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDeviceTypeCustomTagModifyRequestAsync(this OcipClient client, GroupDeviceTypeCustomTagModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of device type files managed by the Device Management System, on a per-group basis.
        /// The response is either GroupDeviceTypeFileGetListResponse21 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDeviceTypeFileGetListRequest21Async instead.")]
        public static async Task<GroupDeviceTypeFileGetListResponse21> GroupDeviceTypeFileGetListRequest21(this OcipClient client, GroupDeviceTypeFileGetListRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDeviceTypeFileGetListResponse21;
        }

        /// <summary>
        /// Request to get the list of device type files managed by the Device Management System, on a per-group basis.
        /// The response is either GroupDeviceTypeFileGetListResponse21 or ErrorResponse.
        /// </summary>
        public static async Task<GroupDeviceTypeFileGetListResponse21> GroupDeviceTypeFileGetListRequest21Async(this OcipClient client, GroupDeviceTypeFileGetListRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDeviceTypeFileGetListResponse21;
        }
        /// <summary>
        /// Request to get a group device type file.
        /// The response is either GroupDeviceTypeFileGetResponse16sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDeviceTypeFileGetRequest16sp1Async instead.")]
        public static async Task<GroupDeviceTypeFileGetResponse16sp1> GroupDeviceTypeFileGetRequest16sp1(this OcipClient client, GroupDeviceTypeFileGetRequest16sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDeviceTypeFileGetResponse16sp1;
        }

        /// <summary>
        /// Request to get a group device type file.
        /// The response is either GroupDeviceTypeFileGetResponse16sp1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupDeviceTypeFileGetResponse16sp1> GroupDeviceTypeFileGetRequest16sp1Async(this OcipClient client, GroupDeviceTypeFileGetRequest16sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDeviceTypeFileGetResponse16sp1;
        }
        /// <summary>
        /// Request to modify a specified device type file for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDeviceTypeFileModifyRequest14sp8Async instead.")]
        public static async Task<SuccessResponse> GroupDeviceTypeFileModifyRequest14sp8(this OcipClient client, GroupDeviceTypeFileModifyRequest14sp8 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a specified device type file for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDeviceTypeFileModifyRequest14sp8Async(this OcipClient client, GroupDeviceTypeFileModifyRequest14sp8 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the custom configuration tag set defined for the group and device type.
        /// The response is either GroupDeviceTypeTagSetGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDeviceTypeTagSetGetRequestAsync instead.")]
        public static async Task<GroupDeviceTypeTagSetGetResponse> GroupDeviceTypeTagSetGetRequest(this OcipClient client, GroupDeviceTypeTagSetGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDeviceTypeTagSetGetResponse;
        }

        /// <summary>
        /// Request to get the custom configuration tag set defined for the group and device type.
        /// The response is either GroupDeviceTypeTagSetGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupDeviceTypeTagSetGetResponse> GroupDeviceTypeTagSetGetRequestAsync(this OcipClient client, GroupDeviceTypeTagSetGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDeviceTypeTagSetGetResponse;
        }
        /// <summary>
        /// Request to modify a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDeviceTypeTagSetModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDeviceTypeTagSetModifyRequest(this OcipClient client, GroupDeviceTypeTagSetModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDeviceTypeTagSetModifyRequestAsync(this OcipClient client, GroupDeviceTypeTagSetModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Dialable Caller ID Criteria. Criteria are added at the bottom of the list with the lowest priority. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDialableCallerIDCriteriaAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDialableCallerIDCriteriaAddRequest(this OcipClient client, GroupDialableCallerIDCriteriaAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Dialable Caller ID Criteria. Criteria are added at the bottom of the list with the lowest priority. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDialableCallerIDCriteriaAddRequestAsync(this OcipClient client, GroupDialableCallerIDCriteriaAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Dialable Caller ID Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDialableCallerIDCriteriaDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDialableCallerIDCriteriaDeleteRequest(this OcipClient client, GroupDialableCallerIDCriteriaDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Dialable Caller ID Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDialableCallerIDCriteriaDeleteRequestAsync(this OcipClient client, GroupDialableCallerIDCriteriaDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get an existing Dialable Caller ID Criteria.
        /// The response is either a GroupDialableCallerIDCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDialableCallerIDCriteriaGetRequestAsync instead.")]
        public static async Task<GroupDialableCallerIDCriteriaGetResponse> GroupDialableCallerIDCriteriaGetRequest(this OcipClient client, GroupDialableCallerIDCriteriaGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDialableCallerIDCriteriaGetResponse;
        }

        /// <summary>
        /// Get an existing Dialable Caller ID Criteria.
        /// The response is either a GroupDialableCallerIDCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupDialableCallerIDCriteriaGetResponse> GroupDialableCallerIDCriteriaGetRequestAsync(this OcipClient client, GroupDialableCallerIDCriteriaGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDialableCallerIDCriteriaGetResponse;
        }
        /// <summary>
        /// Modify a Dialable Caller ID Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDialableCallerIDCriteriaModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDialableCallerIDCriteriaModifyRequest(this OcipClient client, GroupDialableCallerIDCriteriaModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Dialable Caller ID Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDialableCallerIDCriteriaModifyRequestAsync(this OcipClient client, GroupDialableCallerIDCriteriaModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the Group's Dialable Caller ID settings and criteria list.
        /// The response is either a GroupDialableCallerIDGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDialableCallerIDGetRequestAsync instead.")]
        public static async Task<GroupDialableCallerIDGetResponse> GroupDialableCallerIDGetRequest(this OcipClient client, GroupDialableCallerIDGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDialableCallerIDGetResponse;
        }

        /// <summary>
        /// Get the Group's Dialable Caller ID settings and criteria list.
        /// The response is either a GroupDialableCallerIDGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupDialableCallerIDGetResponse> GroupDialableCallerIDGetRequestAsync(this OcipClient client, GroupDialableCallerIDGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDialableCallerIDGetResponse;
        }
        /// <summary>
        /// Modify the group's Dialable Caller ID settings and criteria list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDialableCallerIDModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDialableCallerIDModifyRequest(this OcipClient client, GroupDialableCallerIDModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group's Dialable Caller ID settings and criteria list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDialableCallerIDModifyRequestAsync(this OcipClient client, GroupDialableCallerIDModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a Group level Dial Plan Access Code and its all attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDialPlanPolicyAddAccessCodeRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDialPlanPolicyAddAccessCodeRequest(this OcipClient client, GroupDialPlanPolicyAddAccessCodeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a Group level Dial Plan Access Code and its all attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDialPlanPolicyAddAccessCodeRequestAsync(this OcipClient client, GroupDialPlanPolicyAddAccessCodeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a Group level Dial Plan Access Code and its all attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDialPlanPolicyDeleteAccessCodeRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDialPlanPolicyDeleteAccessCodeRequest(this OcipClient client, GroupDialPlanPolicyDeleteAccessCodeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a Group level Dial Plan Access Code and its all attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDialPlanPolicyDeleteAccessCodeRequestAsync(this OcipClient client, GroupDialPlanPolicyDeleteAccessCodeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the Group level data associated with Dial Plan Policy.
        /// The response is either a GroupDialPlanPolicyGetAccessCodeListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDialPlanPolicyGetAccessCodeListRequestAsync instead.")]
        public static async Task<GroupDialPlanPolicyGetAccessCodeListResponse> GroupDialPlanPolicyGetAccessCodeListRequest(this OcipClient client, GroupDialPlanPolicyGetAccessCodeListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDialPlanPolicyGetAccessCodeListResponse;
        }

        /// <summary>
        /// Request the Group level data associated with Dial Plan Policy.
        /// The response is either a GroupDialPlanPolicyGetAccessCodeListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<GroupDialPlanPolicyGetAccessCodeListResponse> GroupDialPlanPolicyGetAccessCodeListRequestAsync(this OcipClient client, GroupDialPlanPolicyGetAccessCodeListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDialPlanPolicyGetAccessCodeListResponse;
        }
        /// <summary>
        /// Request access code data associated with Group level Dial Plan Policy access codes.
        /// The response is either a GroupDialPlanPolicyGetAccessCodeResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDialPlanPolicyGetAccessCodeRequestAsync instead.")]
        public static async Task<GroupDialPlanPolicyGetAccessCodeResponse> GroupDialPlanPolicyGetAccessCodeRequest(this OcipClient client, GroupDialPlanPolicyGetAccessCodeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDialPlanPolicyGetAccessCodeResponse;
        }

        /// <summary>
        /// Request access code data associated with Group level Dial Plan Policy access codes.
        /// The response is either a GroupDialPlanPolicyGetAccessCodeResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupDialPlanPolicyGetAccessCodeResponse> GroupDialPlanPolicyGetAccessCodeRequestAsync(this OcipClient client, GroupDialPlanPolicyGetAccessCodeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDialPlanPolicyGetAccessCodeResponse;
        }
        /// <summary>
        /// Request the Group level data associated with Dial Plan Policy.
        /// The response is either a GroupDialPlanPolicyGetResponse17 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDialPlanPolicyGetRequest17Async instead.")]
        public static async Task<GroupDialPlanPolicyGetResponse17> GroupDialPlanPolicyGetRequest17(this OcipClient client, GroupDialPlanPolicyGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDialPlanPolicyGetResponse17;
        }

        /// <summary>
        /// Request the Group level data associated with Dial Plan Policy.
        /// The response is either a GroupDialPlanPolicyGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupDialPlanPolicyGetResponse17> GroupDialPlanPolicyGetRequest17Async(this OcipClient client, GroupDialPlanPolicyGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDialPlanPolicyGetResponse17;
        }
        /// <summary>
        /// Request to modify a Group level Dial Plan Access Code and its attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDialPlanPolicyModifyAccessCodeRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDialPlanPolicyModifyAccessCodeRequest(this OcipClient client, GroupDialPlanPolicyModifyAccessCodeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Group level Dial Plan Access Code and its attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDialPlanPolicyModifyAccessCodeRequestAsync(this OcipClient client, GroupDialPlanPolicyModifyAccessCodeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the Group level data associated with Dial Plan Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDialPlanPolicyModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDialPlanPolicyModifyRequest(this OcipClient client, GroupDialPlanPolicyModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Group level data associated with Dial Plan Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDialPlanPolicyModifyRequestAsync(this OcipClient client, GroupDialPlanPolicyModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the group's digit collection attributes.
        /// The response is either a GroupDigitCollectionGetResponse13mp4 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDigitCollectionGetRequest13mp4Async instead.")]
        public static async Task<GroupDigitCollectionGetResponse13mp4> GroupDigitCollectionGetRequest13mp4(this OcipClient client, GroupDigitCollectionGetRequest13mp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDigitCollectionGetResponse13mp4;
        }

        /// <summary>
        /// Request the group's digit collection attributes.
        /// The response is either a GroupDigitCollectionGetResponse13mp4 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupDigitCollectionGetResponse13mp4> GroupDigitCollectionGetRequest13mp4Async(this OcipClient client, GroupDigitCollectionGetRequest13mp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDigitCollectionGetResponse13mp4;
        }
        /// <summary>
        /// Modifies the group's digit collection attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDigitCollectionModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDigitCollectionModifyRequest(this OcipClient client, GroupDigitCollectionModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the group's digit collection attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDigitCollectionModifyRequestAsync(this OcipClient client, GroupDigitCollectionModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Activate a list of assigned DNs on a group. It is possible to activate either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// 
        /// It is not an error to activate an already activated DN
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDnActivateListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDnActivateListRequest(this OcipClient client, GroupDnActivateListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Activate a list of assigned DNs on a group. It is possible to activate either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// 
        /// It is not an error to activate an already activated DN
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDnActivateListRequestAsync(this OcipClient client, GroupDnActivateListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a list of service provider DNs to a group. It is possible to assign either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The DNs must have previously been added to the service provider or enterprise.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDnAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDnAssignListRequest(this OcipClient client, GroupDnAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of service provider DNs to a group. It is possible to assign either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The DNs must have previously been added to the service provider or enterprise.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDnAssignListRequestAsync(this OcipClient client, GroupDnAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deactivate a list of activated DNs on a group. The DNs then become available for
        /// activation again. It is possible to deactivate either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// It is not an error to deactivate an already deactivated DN.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDnDeactivateListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDnDeactivateListRequest(this OcipClient client, GroupDnDeactivateListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deactivate a list of activated DNs on a group. The DNs then become available for
        /// activation again. It is possible to deactivate either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// It is not an error to deactivate an already deactivated DN.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDnDeactivateListRequestAsync(this OcipClient client, GroupDnDeactivateListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of activated and deactivated DNs in a group.
        /// Ranges of DNs with identical assignment and activation properties are coalesced
        /// to a single table row entry.
        /// Only DNs assigned to a users are listed in the response when the number
        /// activation Mode is set to "User Activation Enabled"
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// The response is either a GroupDnGetActivationListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDnGetActivationListRequestAsync instead.")]
        public static async Task<GroupDnGetActivationListResponse> GroupDnGetActivationListRequest(this OcipClient client, GroupDnGetActivationListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDnGetActivationListResponse;
        }

        /// <summary>
        /// Get the list of activated and deactivated DNs in a group.
        /// Ranges of DNs with identical assignment and activation properties are coalesced
        /// to a single table row entry.
        /// Only DNs assigned to a users are listed in the response when the number
        /// activation Mode is set to "User Activation Enabled"
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// The response is either a GroupDnGetActivationListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupDnGetActivationListResponse> GroupDnGetActivationListRequestAsync(this OcipClient client, GroupDnGetActivationListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDnGetActivationListResponse;
        }
        /// <summary>
        /// Get the list of assigned and unassigned DNs in a group. Each DN can be assigned
        /// to a user and/or department. Ranges of DNs with identical assignment and activation properties
        /// are coalesced to a single table row entry.
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// The response is either a GroupDnGetAssignmentListResponse18 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDnGetAssignmentListRequest18Async instead.")]
        public static async Task<GroupDnGetAssignmentListResponse18> GroupDnGetAssignmentListRequest18(this OcipClient client, GroupDnGetAssignmentListRequest18 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDnGetAssignmentListResponse18;
        }

        /// <summary>
        /// Get the list of assigned and unassigned DNs in a group. Each DN can be assigned
        /// to a user and/or department. Ranges of DNs with identical assignment and activation properties
        /// are coalesced to a single table row entry.
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// The response is either a GroupDnGetAssignmentListResponse18 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupDnGetAssignmentListResponse18> GroupDnGetAssignmentListRequest18Async(this OcipClient client, GroupDnGetAssignmentListRequest18 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDnGetAssignmentListResponse18;
        }
        /// <summary>
        /// Get the list of assigned and unassigned DNs in a group. Each DN can be assigned
        /// to a user and/or department. Ranges of DNs with identical assignment and activation properties
        /// are coalesced to a single table row entry.
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the  responsePageSize will be set to  the maximum ResponsePageSize by default.
        /// If no sortOrder is included the response is sorted by Phone Number by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criterion are logically ORed together.
        /// 
        /// The department in both the search criteria and sort by fields refer to the department to which
        /// the dn belongs.
        /// 
        /// A limitation to the search by DN activation exists when the Number Activation mode is set to
        /// Off. In this case DNs not assigned to users are never returned by queries with the
        /// "dnActivationSearchCriteria" included.
        /// 
        /// The response is either a GroupDnGetAssignmentPagedSortedListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDnGetAssignmentPagedSortedListRequestAsync instead.")]
        public static async Task<GroupDnGetAssignmentPagedSortedListResponse> GroupDnGetAssignmentPagedSortedListRequest(this OcipClient client, GroupDnGetAssignmentPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDnGetAssignmentPagedSortedListResponse;
        }

        /// <summary>
        /// Get the list of assigned and unassigned DNs in a group. Each DN can be assigned
        /// to a user and/or department. Ranges of DNs with identical assignment and activation properties
        /// are coalesced to a single table row entry.
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the  responsePageSize will be set to  the maximum ResponsePageSize by default.
        /// If no sortOrder is included the response is sorted by Phone Number by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criterion are logically ORed together.
        /// 
        /// The department in both the search criteria and sort by fields refer to the department to which
        /// the dn belongs.
        /// 
        /// A limitation to the search by DN activation exists when the Number Activation mode is set to
        /// Off. In this case DNs not assigned to users are never returned by queries with the
        /// "dnActivationSearchCriteria" included.
        /// 
        /// The response is either a GroupDnGetAssignmentPagedSortedListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupDnGetAssignmentPagedSortedListResponse> GroupDnGetAssignmentPagedSortedListRequestAsync(this OcipClient client, GroupDnGetAssignmentPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDnGetAssignmentPagedSortedListResponse;
        }
        /// <summary>
        /// Get the list of DNs that are assigned to a group and still available for
        /// assignment to users or service instances within the group.
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// The response is either a GroupDnGetAvailableListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDnGetAvailableListRequestAsync instead.")]
        public static async Task<GroupDnGetAvailableListResponse> GroupDnGetAvailableListRequest(this OcipClient client, GroupDnGetAvailableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDnGetAvailableListResponse;
        }

        /// <summary>
        /// Get the list of DNs that are assigned to a group and still available for
        /// assignment to users or service instances within the group.
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// The response is either a GroupDnGetAvailableListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupDnGetAvailableListResponse> GroupDnGetAvailableListRequestAsync(this OcipClient client, GroupDnGetAvailableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDnGetAvailableListResponse;
        }
        /// <summary>
        /// Get a list of group DNs that are not assigned to user, service instances or IMRN pool.
        /// The Dns are returned in a list of DNs or DN ranges and formated in E164 format for display.
        /// The response is either a GroupDnGetAvailableRangesListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDnGetAvailableRangesListRequestAsync instead.")]
        public static async Task<GroupDnGetAvailableRangesListResponse> GroupDnGetAvailableRangesListRequest(this OcipClient client, GroupDnGetAvailableRangesListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDnGetAvailableRangesListResponse;
        }

        /// <summary>
        /// Get a list of group DNs that are not assigned to user, service instances or IMRN pool.
        /// The Dns are returned in a list of DNs or DN ranges and formated in E164 format for display.
        /// The response is either a GroupDnGetAvailableRangesListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupDnGetAvailableRangesListResponse> GroupDnGetAvailableRangesListRequestAsync(this OcipClient client, GroupDnGetAvailableRangesListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDnGetAvailableRangesListResponse;
        }
        /// <summary>
        /// Get the list of DNs that are assigned to a group and still available for
        /// assignment to users within the group with the department name, if the DN
        /// is assigned to the department.
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// The response is either a GroupDnGetDetailedAvailableListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDnGetDetailedAvailableListRequestAsync instead.")]
        public static async Task<GroupDnGetDetailedAvailableListResponse> GroupDnGetDetailedAvailableListRequest(this OcipClient client, GroupDnGetDetailedAvailableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDnGetDetailedAvailableListResponse;
        }

        /// <summary>
        /// Get the list of DNs that are assigned to a group and still available for
        /// assignment to users within the group with the department name, if the DN
        /// is assigned to the department.
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// The response is either a GroupDnGetDetailedAvailableListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupDnGetDetailedAvailableListResponse> GroupDnGetDetailedAvailableListRequestAsync(this OcipClient client, GroupDnGetDetailedAvailableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDnGetDetailedAvailableListResponse;
        }
        /// <summary>
        /// Get the list of DNs that are assigned to a group.
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// The response is either a GroupDnGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDnGetListRequestAsync instead.")]
        public static async Task<GroupDnGetListResponse> GroupDnGetListRequest(this OcipClient client, GroupDnGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDnGetListResponse;
        }

        /// <summary>
        /// Get the list of DNs that are assigned to a group.
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// The response is either a GroupDnGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupDnGetListResponse> GroupDnGetListRequestAsync(this OcipClient client, GroupDnGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDnGetListResponse;
        }
        /// <summary>
        /// Get the list of assigned and unassigned DN ranges in a group.
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// The response is either a GroupDnGetSummaryListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDnGetSummaryListRequestAsync instead.")]
        public static async Task<GroupDnGetSummaryListResponse> GroupDnGetSummaryListRequest(this OcipClient client, GroupDnGetSummaryListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDnGetSummaryListResponse;
        }

        /// <summary>
        /// Get the list of assigned and unassigned DN ranges in a group.
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// The response is either a GroupDnGetSummaryListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupDnGetSummaryListResponse> GroupDnGetSummaryListRequestAsync(this OcipClient client, GroupDnGetSummaryListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDnGetSummaryListResponse;
        }
        /// <summary>
        /// Assign a list of group DNs to a department. If the department is not specified, this
        /// will make the DNs become unassigned from any department.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDnListAssignDepartmentRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDnListAssignDepartmentRequest(this OcipClient client, GroupDnListAssignDepartmentRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of group DNs to a department. If the department is not specified, this
        /// will make the DNs become unassigned from any department.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDnListAssignDepartmentRequestAsync(this OcipClient client, GroupDnListAssignDepartmentRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Unassign a list of service provider DNs from a group. The DNs then become available for
        /// assignment to other groups. It is possible to unassign either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDnUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDnUnassignListRequest(this OcipClient client, GroupDnUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of service provider DNs from a group. The DNs then become available for
        /// assignment to other groups. It is possible to unassign either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDnUnassignListRequestAsync(this OcipClient client, GroupDnUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a list of domains to a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDomainAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDomainAssignListRequest(this OcipClient client, GroupDomainAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of domains to a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDomainAssignListRequestAsync(this OcipClient client, GroupDomainAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of all domains assigned to a group.
        /// The response is either GroupDomainGetAssignedListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDomainGetAssignedListRequestAsync instead.")]
        public static async Task<GroupDomainGetAssignedListResponse> GroupDomainGetAssignedListRequest(this OcipClient client, GroupDomainGetAssignedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDomainGetAssignedListResponse;
        }

        /// <summary>
        /// Requests the list of all domains assigned to a group.
        /// The response is either GroupDomainGetAssignedListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupDomainGetAssignedListResponse> GroupDomainGetAssignedListRequestAsync(this OcipClient client, GroupDomainGetAssignedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDomainGetAssignedListResponse;
        }
        /// <summary>
        /// Request a list of users within in a group that have a given domain assigned.
        /// The response is either GroupDomainGetAssignedUserListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDomainGetAssignedUserListRequestAsync instead.")]
        public static async Task<GroupDomainGetAssignedUserListResponse> GroupDomainGetAssignedUserListRequest(this OcipClient client, GroupDomainGetAssignedUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDomainGetAssignedUserListResponse;
        }

        /// <summary>
        /// Request a list of users within in a group that have a given domain assigned.
        /// The response is either GroupDomainGetAssignedUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupDomainGetAssignedUserListResponse> GroupDomainGetAssignedUserListRequestAsync(this OcipClient client, GroupDomainGetAssignedUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDomainGetAssignedUserListResponse;
        }
        /// <summary>
        /// Unassign a list of domains from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDomainUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupDomainUnassignListRequest(this OcipClient client, GroupDomainUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of domains from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupDomainUnassignListRequestAsync(this OcipClient client, GroupDomainUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the group level data associated with Emergency Call Notification.
        /// The response is either a GroupEmergencyCallNotificationGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEmergencyCallNotificationGetRequestAsync instead.")]
        public static async Task<GroupEmergencyCallNotificationGetResponse> GroupEmergencyCallNotificationGetRequest(this OcipClient client, GroupEmergencyCallNotificationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupEmergencyCallNotificationGetResponse;
        }

        /// <summary>
        /// Request the group level data associated with Emergency Call Notification.
        /// The response is either a GroupEmergencyCallNotificationGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<GroupEmergencyCallNotificationGetResponse> GroupEmergencyCallNotificationGetRequestAsync(this OcipClient client, GroupEmergencyCallNotificationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupEmergencyCallNotificationGetResponse;
        }
        /// <summary>
        /// Modify the group level data associated with Emergency Call Notification.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEmergencyCallNotificationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEmergencyCallNotificationModifyRequest(this OcipClient client, GroupEmergencyCallNotificationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group level data associated with Emergency Call Notification.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEmergencyCallNotificationModifyRequestAsync(this OcipClient client, GroupEmergencyCallNotificationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to search endpoints in the group.
        /// The response is either GroupEndpointGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEndpointGetListRequestAsync instead.")]
        public static async Task<GroupEndpointGetListResponse> GroupEndpointGetListRequest(this OcipClient client, GroupEndpointGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupEndpointGetListResponse;
        }

        /// <summary>
        /// Request to search endpoints in the group.
        /// The response is either GroupEndpointGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupEndpointGetListResponse> GroupEndpointGetListRequestAsync(this OcipClient client, GroupEndpointGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupEndpointGetListResponse;
        }
        /// <summary>
        /// Request the group level configuration for Exchange Integration.
        /// The response is either a GroupExchangeIntegrationGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupExchangeIntegrationGetRequestAsync instead.")]
        public static async Task<GroupExchangeIntegrationGetResponse> GroupExchangeIntegrationGetRequest(this OcipClient client, GroupExchangeIntegrationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupExchangeIntegrationGetResponse;
        }

        /// <summary>
        /// Request the group level configuration for Exchange Integration.
        /// The response is either a GroupExchangeIntegrationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupExchangeIntegrationGetResponse> GroupExchangeIntegrationGetRequestAsync(this OcipClient client, GroupExchangeIntegrationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupExchangeIntegrationGetResponse;
        }
        /// <summary>
        /// Modify the group level configuration for Exchange Integration.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupExchangeIntegrationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupExchangeIntegrationModifyRequest(this OcipClient client, GroupExchangeIntegrationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group level configuration for Exchange Integration.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupExchangeIntegrationModifyRequestAsync(this OcipClient client, GroupExchangeIntegrationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to assign the user services and service packs to all existing users within the group.
        /// BroadSoft recommends using this command only for small groups with less than 100 users.  This
        /// command will return an error if the group has over 500 users.  The recommended way to bulk
        /// assign/unassign services is Service Pack Migration.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupExistingUsersAssignUserServiceListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupExistingUsersAssignUserServiceListRequest(this OcipClient client, GroupExistingUsersAssignUserServiceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to assign the user services and service packs to all existing users within the group.
        /// BroadSoft recommends using this command only for small groups with less than 100 users.  This
        /// command will return an error if the group has over 500 users.  The recommended way to bulk
        /// assign/unassign services is Service Pack Migration.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupExistingUsersAssignUserServiceListRequestAsync(this OcipClient client, GroupExistingUsersAssignUserServiceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests to unassign the user services and service packs for all existing users within the group.
        /// BroadSoft recommends using this command only for small groups with less than 100 users.  This
        /// command will return an error if the group has over 500 users.  The recommended way to bulk
        /// assign/unassign services is Service Pack Migration.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupExistingUsersUnassignUserServiceListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupExistingUsersUnassignUserServiceListRequest(this OcipClient client, GroupExistingUsersUnassignUserServiceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Requests to unassign the user services and service packs for all existing users within the group.
        /// BroadSoft recommends using this command only for small groups with less than 100 users.  This
        /// command will return an error if the group has over 500 users.  The recommended way to bulk
        /// assign/unassign services is Service Pack Migration.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupExistingUsersUnassignUserServiceListRequestAsync(this OcipClient client, GroupExistingUsersUnassignUserServiceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the group's extension length.
        /// The response is either a GroupExtensionLengthGetResponse17 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupExtensionLengthGetRequest17Async instead.")]
        public static async Task<GroupExtensionLengthGetResponse17> GroupExtensionLengthGetRequest17(this OcipClient client, GroupExtensionLengthGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupExtensionLengthGetResponse17;
        }

        /// <summary>
        /// Request the group's extension length.
        /// The response is either a GroupExtensionLengthGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupExtensionLengthGetResponse17> GroupExtensionLengthGetRequest17Async(this OcipClient client, GroupExtensionLengthGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupExtensionLengthGetResponse17;
        }
        /// <summary>
        /// Modify the group's extension length range.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupExtensionLengthModifyRequest17Async instead.")]
        public static async Task<SuccessResponse> GroupExtensionLengthModifyRequest17(this OcipClient client, GroupExtensionLengthModifyRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group's extension length range.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupExtensionLengthModifyRequest17Async(this OcipClient client, GroupExtensionLengthModifyRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get group FAC code level and the list of feature access codes for a group.
        /// The response is either a GroupFeatureAccessCodeGetResponse21 or an
        /// ErrorResponse.
        /// Returned Feature Access Codes may be group specific, or Service Provider
        /// Feature Access Codes, depending on FAC code level.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFeatureAccessCodeGetRequest21Async instead.")]
        public static async Task<GroupFeatureAccessCodeGetResponse21> GroupFeatureAccessCodeGetRequest21(this OcipClient client, GroupFeatureAccessCodeGetRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupFeatureAccessCodeGetResponse21;
        }

        /// <summary>
        /// Get group FAC code level and the list of feature access codes for a group.
        /// The response is either a GroupFeatureAccessCodeGetResponse21 or an
        /// ErrorResponse.
        /// Returned Feature Access Codes may be group specific, or Service Provider
        /// Feature Access Codes, depending on FAC code level.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// </summary>
        public static async Task<GroupFeatureAccessCodeGetResponse21> GroupFeatureAccessCodeGetRequest21Async(this OcipClient client, GroupFeatureAccessCodeGetRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupFeatureAccessCodeGetResponse21;
        }
        /// <summary>
        /// Modify group FAC code level and the list of feature access codes for a
        /// group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Note: choice element is only valid when useFeatureAccessCodeLevel is set
        /// to "Group", otherwise an ErrorResponse will be returned.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFeatureAccessCodeModifyRequest21Async instead.")]
        public static async Task<SuccessResponse> GroupFeatureAccessCodeModifyRequest21(this OcipClient client, GroupFeatureAccessCodeModifyRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify group FAC code level and the list of feature access codes for a
        /// group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Note: choice element is only valid when useFeatureAccessCodeLevel is set
        /// to "Group", otherwise an ErrorResponse will be returned.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// </summary>
        public static async Task<SuccessResponse> GroupFeatureAccessCodeModifyRequest21Async(this OcipClient client, GroupFeatureAccessCodeModifyRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new group file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFileRepositoryDeviceUserAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupFileRepositoryDeviceUserAddRequest(this OcipClient client, GroupFileRepositoryDeviceUserAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new group file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFileRepositoryDeviceUserAddRequestAsync(this OcipClient client, GroupFileRepositoryDeviceUserAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a group file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFileRepositoryDeviceUserDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupFileRepositoryDeviceUserDeleteRequest(this OcipClient client, GroupFileRepositoryDeviceUserDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a group file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFileRepositoryDeviceUserDeleteRequestAsync(this OcipClient client, GroupFileRepositoryDeviceUserDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of group users for a file repository in the system.
        /// The response is either a GroupFileRepositoryDeviceUserGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFileRepositoryDeviceUserGetListRequestAsync instead.")]
        public static async Task<GroupFileRepositoryDeviceUserGetListResponse> GroupFileRepositoryDeviceUserGetListRequest(this OcipClient client, GroupFileRepositoryDeviceUserGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupFileRepositoryDeviceUserGetListResponse;
        }

        /// <summary>
        /// Request the list of group users for a file repository in the system.
        /// The response is either a GroupFileRepositoryDeviceUserGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupFileRepositoryDeviceUserGetListResponse> GroupFileRepositoryDeviceUserGetListRequestAsync(this OcipClient client, GroupFileRepositoryDeviceUserGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupFileRepositoryDeviceUserGetListResponse;
        }
        /// <summary>
        /// Modify a group file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFileRepositoryDeviceUserModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupFileRepositoryDeviceUserModifyRequest(this OcipClient client, GroupFileRepositoryDeviceUserModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a group file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupFileRepositoryDeviceUserModifyRequestAsync(this OcipClient client, GroupFileRepositoryDeviceUserModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the default profile for a group.
        /// The response is either a GroupGetDefaultResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGetDefaultRequestAsync instead.")]
        public static async Task<GroupGetDefaultResponse> GroupGetDefaultRequest(this OcipClient client, GroupGetDefaultRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGetDefaultResponse;
        }

        /// <summary>
        /// Request the default profile for a group.
        /// The response is either a GroupGetDefaultResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupGetDefaultResponse> GroupGetDefaultRequestAsync(this OcipClient client, GroupGetDefaultRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGetDefaultResponse;
        }
        /// <summary>
        /// Request the list of groups in a service provider or enterprise.
        /// If no sortOrder is included, the response is sorted by Group Id ascending by default.
        /// The response is either a GroupGetListInServiceProviderPagedSortedListResponse or an ErrorResponse.
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1 by
        /// default, and the responsePageSize will be set to the maximum responsePageSize by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is
        /// included. Then the search criteria are logically ORed together.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGetListInServiceProviderPagedSortedListRequestAsync instead.")]
        public static async Task<GroupGetListInServiceProviderPagedSortedListResponse> GroupGetListInServiceProviderPagedSortedListRequest(this OcipClient client, GroupGetListInServiceProviderPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGetListInServiceProviderPagedSortedListResponse;
        }

        /// <summary>
        /// Request the list of groups in a service provider or enterprise.
        /// If no sortOrder is included, the response is sorted by Group Id ascending by default.
        /// The response is either a GroupGetListInServiceProviderPagedSortedListResponse or an ErrorResponse.
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1 by
        /// default, and the responsePageSize will be set to the maximum responsePageSize by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is
        /// included. Then the search criteria are logically ORed together.
        /// </summary>
        public static async Task<GroupGetListInServiceProviderPagedSortedListResponse> GroupGetListInServiceProviderPagedSortedListRequestAsync(this OcipClient client, GroupGetListInServiceProviderPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGetListInServiceProviderPagedSortedListResponse;
        }
        /// <summary>
        /// Request the list of groups in a service provider or enterprise.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupGetListInServiceProviderResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGetListInServiceProviderRequestAsync instead.")]
        public static async Task<GroupGetListInServiceProviderResponse> GroupGetListInServiceProviderRequest(this OcipClient client, GroupGetListInServiceProviderRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGetListInServiceProviderResponse;
        }

        /// <summary>
        /// Request the list of groups in a service provider or enterprise.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupGetListInServiceProviderResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupGetListInServiceProviderResponse> GroupGetListInServiceProviderRequestAsync(this OcipClient client, GroupGetListInServiceProviderRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGetListInServiceProviderResponse;
        }
        /// <summary>
        /// Request the list of groups in the system.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All the groups
        /// in the administrator's reseller meeting the search criteria are returned.
        /// 
        /// The response is either a GroupGetListInSystemResponse or an ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGetListInSystemRequestAsync instead.")]
        public static async Task<GroupGetListInSystemResponse> GroupGetListInSystemRequest(this OcipClient client, GroupGetListInSystemRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGetListInSystemResponse;
        }

        /// <summary>
        /// Request the list of groups in the system.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All the groups
        /// in the administrator's reseller meeting the search criteria are returned.
        /// 
        /// The response is either a GroupGetListInSystemResponse or an ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        public static async Task<GroupGetListInSystemResponse> GroupGetListInSystemRequestAsync(this OcipClient client, GroupGetListInSystemRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGetListInSystemResponse;
        }
        /// <summary>
        /// Get the profile for a group.
        /// The response is either a GroupGetResponse22V2 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGetRequest22V2Async instead.")]
        public static async Task<GroupGetResponse22V2> GroupGetRequest22V2(this OcipClient client, GroupGetRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGetResponse22V2;
        }

        /// <summary>
        /// Get the profile for a group.
        /// The response is either a GroupGetResponse22V2 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupGetResponse22V2> GroupGetRequest22V2Async(this OcipClient client, GroupGetRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGetResponse22V2;
        }
        /// <summary>
        /// Get the list of users assigned the user service or service pack.
        /// The response is either a GroupGetUserServiceAssignedUserListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGetUserServiceAssignedUserListRequestAsync instead.")]
        public static async Task<GroupGetUserServiceAssignedUserListResponse> GroupGetUserServiceAssignedUserListRequest(this OcipClient client, GroupGetUserServiceAssignedUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGetUserServiceAssignedUserListResponse;
        }

        /// <summary>
        /// Get the list of users assigned the user service or service pack.
        /// The response is either a GroupGetUserServiceAssignedUserListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupGetUserServiceAssignedUserListResponse> GroupGetUserServiceAssignedUserListRequestAsync(this OcipClient client, GroupGetUserServiceAssignedUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGetUserServiceAssignedUserListResponse;
        }
        /// <summary>
        /// Assign a list of group DNs to the IMRN pool. It is possible to assign either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupIMRNAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupIMRNAssignListRequest(this OcipClient client, GroupIMRNAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of group DNs to the IMRN pool. It is possible to assign either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupIMRNAssignListRequestAsync(this OcipClient client, GroupIMRNAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a summary table of all DNs in a group IMRN pool.
        /// The response is either GroupIMRNGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupIMRNGetListRequestAsync instead.")]
        public static async Task<GroupIMRNGetListResponse> GroupIMRNGetListRequest(this OcipClient client, GroupIMRNGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupIMRNGetListResponse;
        }

        /// <summary>
        /// Request a summary table of all DNs in a group IMRN pool.
        /// The response is either GroupIMRNGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupIMRNGetListResponse> GroupIMRNGetListRequestAsync(this OcipClient client, GroupIMRNGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupIMRNGetListResponse;
        }
        /// <summary>
        /// Unassign a list of group DNs from the group IMRN pool. The DNs then become available for
        /// assignment to users. It is possible to delete either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupIMRNUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupIMRNUnassignListRequest(this OcipClient client, GroupIMRNUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of group DNs from the group IMRN pool. The DNs then become available for
        /// assignment to users. It is possible to delete either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupIMRNUnassignListRequestAsync(this OcipClient client, GroupIMRNUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the profile for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in Amplify data mode and ignored
        /// in AS and XS data mode:
        /// servicePolicy,
        /// callProcessingSliceId,
        /// provisioningSliceId,
        /// subscriberPartition.
        /// When the callProcessingSliceId or provisioningSliceId is set to nillable,
        /// it will be assigned to the default Slice.
        /// Only Provisioning admin and above can change the callProcessingSliceId, provisioningSliceId, and subscriberPartition.
        /// 
        /// The following elements are only used in Amplify and XS data mode and ignored in AS data mode:
        /// preferredDataCenter.
        /// Only Provisioning admin and above can change the preferredDataCenter.
        /// 
        /// The following elements are only used in XS data mode and ignored in Amplify and AS data mode:
        /// defaultUserCallingLineIdPhoneNumber.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupModifyRequest(this OcipClient client, GroupModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the profile for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in Amplify data mode and ignored
        /// in AS and XS data mode:
        /// servicePolicy,
        /// callProcessingSliceId,
        /// provisioningSliceId,
        /// subscriberPartition.
        /// When the callProcessingSliceId or provisioningSliceId is set to nillable,
        /// it will be assigned to the default Slice.
        /// Only Provisioning admin and above can change the callProcessingSliceId, provisioningSliceId, and subscriberPartition.
        /// 
        /// The following elements are only used in Amplify and XS data mode and ignored in AS data mode:
        /// preferredDataCenter.
        /// Only Provisioning admin and above can change the preferredDataCenter.
        /// 
        /// The following elements are only used in XS data mode and ignored in Amplify and AS data mode:
        /// defaultUserCallingLineIdPhoneNumber.
        /// </summary>
        public static async Task<SuccessResponse> GroupModifyRequestAsync(this OcipClient client, GroupModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a list of Network Classes of Service to a group.
        /// A default Network Class of Service must be specified unless there is already one assigned to the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupNetworkClassOfServiceAssignListRequest21Async instead.")]
        public static async Task<SuccessResponse> GroupNetworkClassOfServiceAssignListRequest21(this OcipClient client, GroupNetworkClassOfServiceAssignListRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Network Classes of Service to a group.
        /// A default Network Class of Service must be specified unless there is already one assigned to the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupNetworkClassOfServiceAssignListRequest21Async(this OcipClient client, GroupNetworkClassOfServiceAssignListRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a Network Classes of Service to all users with in a
        /// group. The Network Classes of Service must be currently assigned to
        /// the group. The response is either a SuccessResponse or
        /// an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupNetworkClassOfServiceAssignToAllUsersRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupNetworkClassOfServiceAssignToAllUsersRequest(this OcipClient client, GroupNetworkClassOfServiceAssignToAllUsersRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a Network Classes of Service to all users with in a
        /// group. The Network Classes of Service must be currently assigned to
        /// the group. The response is either a SuccessResponse or
        /// an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupNetworkClassOfServiceAssignToAllUsersRequestAsync(this OcipClient client, GroupNetworkClassOfServiceAssignToAllUsersRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Network Classes of Service assigned to a group.
        /// The response is either a GroupNetworkClassOfServiceGetAssignedListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupNetworkClassOfServiceGetAssignedListRequestAsync instead.")]
        public static async Task<GroupNetworkClassOfServiceGetAssignedListResponse> GroupNetworkClassOfServiceGetAssignedListRequest(this OcipClient client, GroupNetworkClassOfServiceGetAssignedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupNetworkClassOfServiceGetAssignedListResponse;
        }

        /// <summary>
        /// Get a list of Network Classes of Service assigned to a group.
        /// The response is either a GroupNetworkClassOfServiceGetAssignedListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<GroupNetworkClassOfServiceGetAssignedListResponse> GroupNetworkClassOfServiceGetAssignedListRequestAsync(this OcipClient client, GroupNetworkClassOfServiceGetAssignedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupNetworkClassOfServiceGetAssignedListResponse;
        }
        /// <summary>
        /// Get a list of users within a group that have a given Network Class
        /// of Service assigned.
        /// The response is either a GroupNetworkClassOfServiceGetAssignedUserListResponse21
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupNetworkClassOfServiceGetAssignedUserListRequest21Async instead.")]
        public static async Task<GroupNetworkClassOfServiceGetAssignedUserListResponse21> GroupNetworkClassOfServiceGetAssignedUserListRequest21(this OcipClient client, GroupNetworkClassOfServiceGetAssignedUserListRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupNetworkClassOfServiceGetAssignedUserListResponse21;
        }

        /// <summary>
        /// Get a list of users within a group that have a given Network Class
        /// of Service assigned.
        /// The response is either a GroupNetworkClassOfServiceGetAssignedUserListResponse21
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<GroupNetworkClassOfServiceGetAssignedUserListResponse21> GroupNetworkClassOfServiceGetAssignedUserListRequest21Async(this OcipClient client, GroupNetworkClassOfServiceGetAssignedUserListRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupNetworkClassOfServiceGetAssignedUserListResponse21;
        }
        /// <summary>
        /// Modifies the default Network Classes of Service of a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupNetworkClassOfServiceModifyDefaultRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupNetworkClassOfServiceModifyDefaultRequest(this OcipClient client, GroupNetworkClassOfServiceModifyDefaultRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the default Network Classes of Service of a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupNetworkClassOfServiceModifyDefaultRequestAsync(this OcipClient client, GroupNetworkClassOfServiceModifyDefaultRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Unassign a list of Network Classes of Service from a group.
        /// If the default Network Class of Service is being unassigned, a new one must be specified unless there are no more
        /// Network Classes of Service assigned to the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupNetworkClassOfServiceUnassignListRequest21Async instead.")]
        public static async Task<SuccessResponse> GroupNetworkClassOfServiceUnassignListRequest21(this OcipClient client, GroupNetworkClassOfServiceUnassignListRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of Network Classes of Service from a group.
        /// If the default Network Class of Service is being unassigned, a new one must be specified unless there are no more
        /// Network Classes of Service assigned to the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupNetworkClassOfServiceUnassignListRequest21Async(this OcipClient client, GroupNetworkClassOfServiceUnassignListRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to assign the user services and service packs to all new users created within the group
        /// after the completion of this request.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupNewUserTemplateAssignUserServiceListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupNewUserTemplateAssignUserServiceListRequest(this OcipClient client, GroupNewUserTemplateAssignUserServiceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to assign the user services and service packs to all new users created within the group
        /// after the completion of this request.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupNewUserTemplateAssignUserServiceListRequestAsync(this OcipClient client, GroupNewUserTemplateAssignUserServiceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests to unassign the user services and service packs for all new users created within the group
        /// after the completion of this request.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupNewUserTemplateUnassignUserServiceListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupNewUserTemplateUnassignUserServiceListRequest(this OcipClient client, GroupNewUserTemplateUnassignUserServiceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Requests to unassign the user services and service packs for all new users created within the group
        /// after the completion of this request.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupNewUserTemplateUnassignUserServiceListRequestAsync(this OcipClient client, GroupNewUserTemplateUnassignUserServiceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a list of Office Zones to a group.
        /// The Element defaultOfficeZone is required only for the first assignment, for subsequent assignments it is optional.
        /// Office Zones can only be assigned if the Location-Based Calling Restrictions has been authorized to the group otherwise the request will fail.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOfficeZoneAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOfficeZoneAssignListRequest(this OcipClient client, GroupOfficeZoneAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Office Zones to a group.
        /// The Element defaultOfficeZone is required only for the first assignment, for subsequent assignments it is optional.
        /// Office Zones can only be assigned if the Location-Based Calling Restrictions has been authorized to the group otherwise the request will fail.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOfficeZoneAssignListRequestAsync(this OcipClient client, GroupOfficeZoneAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Office Zones assigned to a group.
        /// The response is either a GroupOfficeZoneGetAssignedListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOfficeZoneGetAssignedListRequestAsync instead.")]
        public static async Task<GroupOfficeZoneGetAssignedListResponse> GroupOfficeZoneGetAssignedListRequest(this OcipClient client, GroupOfficeZoneGetAssignedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOfficeZoneGetAssignedListResponse;
        }

        /// <summary>
        /// Get a list of Office Zones assigned to a group.
        /// The response is either a GroupOfficeZoneGetAssignedListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOfficeZoneGetAssignedListResponse> GroupOfficeZoneGetAssignedListRequestAsync(this OcipClient client, GroupOfficeZoneGetAssignedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOfficeZoneGetAssignedListResponse;
        }
        /// <summary>
        /// Get a list of users within a group that have a given Office Zone assigned.
        /// The response is either a GroupOfficeZoneGetAssignedUserListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOfficeZoneGetAssignedUserListRequestAsync instead.")]
        public static async Task<GroupOfficeZoneGetAssignedUserListResponse> GroupOfficeZoneGetAssignedUserListRequest(this OcipClient client, GroupOfficeZoneGetAssignedUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOfficeZoneGetAssignedUserListResponse;
        }

        /// <summary>
        /// Get a list of users within a group that have a given Office Zone assigned.
        /// The response is either a GroupOfficeZoneGetAssignedUserListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOfficeZoneGetAssignedUserListResponse> GroupOfficeZoneGetAssignedUserListRequestAsync(this OcipClient client, GroupOfficeZoneGetAssignedUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOfficeZoneGetAssignedUserListResponse;
        }
        /// <summary>
        /// Unassign a list of OfficeZones from a group.  Note: a new default must be provided if unassigning the current default.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOfficeZoneUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOfficeZoneUnassignListRequest(this OcipClient client, GroupOfficeZoneUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of OfficeZones from a group.  Note: a new default must be provided if unassigning the current default.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOfficeZoneUnassignListRequestAsync(this OcipClient client, GroupOfficeZoneUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the group's password rules setting that is applicable to
        /// users within the group.
        /// The response is either GroupPasswordRulesGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPasswordRulesGetRequest22Async instead.")]
        public static async Task<GroupPasswordRulesGetResponse22> GroupPasswordRulesGetRequest22(this OcipClient client, GroupPasswordRulesGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupPasswordRulesGetResponse22;
        }

        /// <summary>
        /// Requests the group's password rules setting that is applicable to
        /// users within the group.
        /// The response is either GroupPasswordRulesGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<GroupPasswordRulesGetResponse22> GroupPasswordRulesGetRequest22Async(this OcipClient client, GroupPasswordRulesGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupPasswordRulesGetResponse22;
        }
        /// <summary>
        /// Request to modify the group's password rules setting that apply to the
        /// users within the group.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// forcePasswordChangeAfterReset
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPasswordRulesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupPasswordRulesModifyRequest(this OcipClient client, GroupPasswordRulesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the group's password rules setting that apply to the
        /// users within the group.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// forcePasswordChangeAfterReset
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupPasswordRulesModifyRequestAsync(this OcipClient client, GroupPasswordRulesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a table containing the phone directory for a group.
        /// The directory includes all users in the group and all entries in the group common phone list.
        /// 
        /// If the specified group is part of an enterprise, the directory
        /// includes all users in the enterprise and all entries in the enterprise
        /// common phone list and the common phone list of the specified group.
        /// 
        /// If the specified group is part of a service provider, the directory
        /// includes all users in the group and all entries in the common phone
        /// list of the specified group.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending with a secondary
        /// sort by User Last Name ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// ErrorResponse is returned if searchCriteriaExactUserGroup or searchCriteriaExactUserDepartment have multiple entries and searchCriteriaModeOr is not included.
        /// 
        /// The following elements are only used in AS data mode and ignored in Amplify and XS data mode:
        /// "sortByImpId"
        /// "searchCriteriaImpId"
        /// 
        /// The response is either GroupPhoneDirectoryGetPagedSortedListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPhoneDirectoryGetPagedSortedListRequestAsync instead.")]
        public static async Task<GroupPhoneDirectoryGetPagedSortedListResponse> GroupPhoneDirectoryGetPagedSortedListRequest(this OcipClient client, GroupPhoneDirectoryGetPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupPhoneDirectoryGetPagedSortedListResponse;
        }

        /// <summary>
        /// Request a table containing the phone directory for a group.
        /// The directory includes all users in the group and all entries in the group common phone list.
        /// 
        /// If the specified group is part of an enterprise, the directory
        /// includes all users in the enterprise and all entries in the enterprise
        /// common phone list and the common phone list of the specified group.
        /// 
        /// If the specified group is part of a service provider, the directory
        /// includes all users in the group and all entries in the common phone
        /// list of the specified group.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending with a secondary
        /// sort by User Last Name ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// ErrorResponse is returned if searchCriteriaExactUserGroup or searchCriteriaExactUserDepartment have multiple entries and searchCriteriaModeOr is not included.
        /// 
        /// The following elements are only used in AS data mode and ignored in Amplify and XS data mode:
        /// "sortByImpId"
        /// "searchCriteriaImpId"
        /// 
        /// The response is either GroupPhoneDirectoryGetPagedSortedListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupPhoneDirectoryGetPagedSortedListResponse> GroupPhoneDirectoryGetPagedSortedListRequestAsync(this OcipClient client, GroupPhoneDirectoryGetPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupPhoneDirectoryGetPagedSortedListResponse;
        }
        /// <summary>
        /// Requests the Group's policy settings.
        /// The response is either GroupPolicyGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPolicyGetRequest22Async instead.")]
        public static async Task<GroupPolicyGetResponse22> GroupPolicyGetRequest22(this OcipClient client, GroupPolicyGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupPolicyGetResponse22;
        }

        /// <summary>
        /// Requests the Group's policy settings.
        /// The response is either GroupPolicyGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<GroupPolicyGetResponse22> GroupPolicyGetRequest22Async(this OcipClient client, GroupPolicyGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupPolicyGetResponse22;
        }
        /// <summary>
        /// Request to modify the policies for a Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// userAutoAttendantNameDialingAccess
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPolicyModifyRequest22Async instead.")]
        public static async Task<SuccessResponse> GroupPolicyModifyRequest22(this OcipClient client, GroupPolicyModifyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the policies for a Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// userAutoAttendantNameDialingAccess
        /// </summary>
        public static async Task<SuccessResponse> GroupPolicyModifyRequest22Async(this OcipClient client, GroupPolicyModifyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the group's passcode rules setting.
        /// The response is either GroupPortalPasscodeRulesGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPortalPasscodeRulesGetRequest19Async instead.")]
        public static async Task<GroupPortalPasscodeRulesGetResponse> GroupPortalPasscodeRulesGetRequest19(this OcipClient client, GroupPortalPasscodeRulesGetRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupPortalPasscodeRulesGetResponse;
        }

        /// <summary>
        /// Requests the group's passcode rules setting.
        /// The response is either GroupPortalPasscodeRulesGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupPortalPasscodeRulesGetResponse> GroupPortalPasscodeRulesGetRequest19Async(this OcipClient client, GroupPortalPasscodeRulesGetRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupPortalPasscodeRulesGetResponse;
        }
        /// <summary>
        /// Request to modify the group's passcode rules setting.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// numberOfRepeatedDigits
        /// disallowRepeatedPatterns
        /// disallowContiguousSequences
        /// numberOfAscendingDigits
        /// numberOfDescendingDigits
        /// numberOfPreviousPasscodes
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPortalPasscodeRulesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupPortalPasscodeRulesModifyRequest(this OcipClient client, GroupPortalPasscodeRulesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the group's passcode rules setting.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// numberOfRepeatedDigits
        /// disallowRepeatedPatterns
        /// disallowContiguousSequences
        /// numberOfAscendingDigits
        /// numberOfDescendingDigits
        /// numberOfPreviousPasscodes
        /// </summary>
        public static async Task<SuccessResponse> GroupPortalPasscodeRulesModifyRequestAsync(this OcipClient client, GroupPortalPasscodeRulesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a list of route point external systems to a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointExternalSystemAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointExternalSystemAssignListRequest(this OcipClient client, GroupRoutePointExternalSystemAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of route point external systems to a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointExternalSystemAssignListRequestAsync(this OcipClient client, GroupRoutePointExternalSystemAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of all Route Point External Systems assigned to a group.
        /// The response is either GroupRoutePointExternalSystemGetAssignedListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointExternalSystemGetAssignedListRequestAsync instead.")]
        public static async Task<GroupRoutePointExternalSystemGetAssignedListResponse> GroupRoutePointExternalSystemGetAssignedListRequest(this OcipClient client, GroupRoutePointExternalSystemGetAssignedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointExternalSystemGetAssignedListResponse;
        }

        /// <summary>
        /// Requests the list of all Route Point External Systems assigned to a group.
        /// The response is either GroupRoutePointExternalSystemGetAssignedListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointExternalSystemGetAssignedListResponse> GroupRoutePointExternalSystemGetAssignedListRequestAsync(this OcipClient client, GroupRoutePointExternalSystemGetAssignedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointExternalSystemGetAssignedListResponse;
        }
        /// <summary>
        /// Request a list of route points within in a group that have a given external system assigned.
        /// The response is either GroupRoutePointExternalSystemGetAssignedRoutePointListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointExternalSystemGetAssignedRoutePointListRequestAsync instead.")]
        public static async Task<GroupRoutePointExternalSystemGetAssignedRoutePointListResponse> GroupRoutePointExternalSystemGetAssignedRoutePointListRequest(this OcipClient client, GroupRoutePointExternalSystemGetAssignedRoutePointListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointExternalSystemGetAssignedRoutePointListResponse;
        }

        /// <summary>
        /// Request a list of route points within in a group that have a given external system assigned.
        /// The response is either GroupRoutePointExternalSystemGetAssignedRoutePointListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointExternalSystemGetAssignedRoutePointListResponse> GroupRoutePointExternalSystemGetAssignedRoutePointListRequestAsync(this OcipClient client, GroupRoutePointExternalSystemGetAssignedRoutePointListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointExternalSystemGetAssignedRoutePointListResponse;
        }
        /// <summary>
        /// Unassign a list of route point external systems from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointExternalSystemUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointExternalSystemUnassignListRequest(this OcipClient client, GroupRoutePointExternalSystemUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of route point external systems from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointExternalSystemUnassignListRequestAsync(this OcipClient client, GroupRoutePointExternalSystemUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the routing profile for the group.
        /// The response is either a GroupRoutingProfileGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutingProfileGetRequestAsync instead.")]
        public static async Task<GroupRoutingProfileGetResponse> GroupRoutingProfileGetRequest(this OcipClient client, GroupRoutingProfileGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutingProfileGetResponse;
        }

        /// <summary>
        /// Request the routing profile for the group.
        /// The response is either a GroupRoutingProfileGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutingProfileGetResponse> GroupRoutingProfileGetRequestAsync(this OcipClient client, GroupRoutingProfileGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutingProfileGetResponse;
        }
        /// <summary>
        /// Requests to modify the routing profile for a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutingProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutingProfileModifyRequest(this OcipClient client, GroupRoutingProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Requests to modify the routing profile for a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutingProfileModifyRequestAsync(this OcipClient client, GroupRoutingProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an event to group schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupScheduleAddEventRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupScheduleAddEventRequest(this OcipClient client, GroupScheduleAddEventRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an event to group schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        public static async Task<SuccessResponse> GroupScheduleAddEventRequestAsync(this OcipClient client, GroupScheduleAddEventRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a group schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupScheduleAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupScheduleAddRequest(this OcipClient client, GroupScheduleAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a group schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupScheduleAddRequestAsync(this OcipClient client, GroupScheduleAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of events from a group schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupScheduleDeleteEventListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupScheduleDeleteEventListRequest(this OcipClient client, GroupScheduleDeleteEventListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of events from a group schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupScheduleDeleteEventListRequestAsync(this OcipClient client, GroupScheduleDeleteEventListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of group schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupScheduleDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupScheduleDeleteListRequest(this OcipClient client, GroupScheduleDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of group schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupScheduleDeleteListRequestAsync(this OcipClient client, GroupScheduleDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of events of a group schedule.
        /// The response is either a GroupScheduleGetEventDetailListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupScheduleGetEventDetailListRequestAsync instead.")]
        public static async Task<GroupScheduleGetEventDetailListResponse> GroupScheduleGetEventDetailListRequest(this OcipClient client, GroupScheduleGetEventDetailListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupScheduleGetEventDetailListResponse;
        }

        /// <summary>
        /// Get the list of events of a group schedule.
        /// The response is either a GroupScheduleGetEventDetailListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupScheduleGetEventDetailListResponse> GroupScheduleGetEventDetailListRequestAsync(this OcipClient client, GroupScheduleGetEventDetailListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupScheduleGetEventDetailListResponse;
        }
        /// <summary>
        /// Get the list of events of a group schedule.
        /// The response is either a GroupScheduleGetEventListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupScheduleGetEventListRequestAsync instead.")]
        public static async Task<GroupScheduleGetEventListResponse> GroupScheduleGetEventListRequest(this OcipClient client, GroupScheduleGetEventListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupScheduleGetEventListResponse;
        }

        /// <summary>
        /// Get the list of events of a group schedule.
        /// The response is either a GroupScheduleGetEventListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupScheduleGetEventListResponse> GroupScheduleGetEventListRequestAsync(this OcipClient client, GroupScheduleGetEventListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupScheduleGetEventListResponse;
        }
        /// <summary>
        /// Get an event from a group schedule.
        /// The response is either a GroupScheduleGetEventResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupScheduleGetEventRequestAsync instead.")]
        public static async Task<GroupScheduleGetEventResponse> GroupScheduleGetEventRequest(this OcipClient client, GroupScheduleGetEventRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupScheduleGetEventResponse;
        }

        /// <summary>
        /// Get an event from a group schedule.
        /// The response is either a GroupScheduleGetEventResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupScheduleGetEventResponse> GroupScheduleGetEventRequestAsync(this OcipClient client, GroupScheduleGetEventRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupScheduleGetEventResponse;
        }
        /// <summary>
        /// Get the list of schedules viewable by a group. The list can be filtered by schedule type.
        /// The response is either a GroupScheduleGetListResponse17sp1 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupScheduleGetListRequest17sp1Async instead.")]
        public static async Task<GroupScheduleGetListResponse17sp1> GroupScheduleGetListRequest17sp1(this OcipClient client, GroupScheduleGetListRequest17sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupScheduleGetListResponse17sp1;
        }

        /// <summary>
        /// Get the list of schedules viewable by a group. The list can be filtered by schedule type.
        /// The response is either a GroupScheduleGetListResponse17sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupScheduleGetListResponse17sp1> GroupScheduleGetListRequest17sp1Async(this OcipClient client, GroupScheduleGetListRequest17sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupScheduleGetListResponse17sp1;
        }
        /// <summary>
        /// Get the list of schedules viewable by a group.
        /// The response is either a GroupScheduleGetPagedSortedListResponse or an ErrorResponse.
        /// If no sortOrder is included, the response is sorted by Name ascending by default.
        /// If the responsePagingControl element is not provided, the paging startIndex will be
        /// set to 1 by default, and the responsePageSize will be set to the maximum
        /// responsePageSize by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option
        /// is included. Then the search criteria are logically ORed together.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupScheduleGetPagedSortedListRequestAsync instead.")]
        public static async Task<GroupScheduleGetPagedSortedListResponse> GroupScheduleGetPagedSortedListRequest(this OcipClient client, GroupScheduleGetPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupScheduleGetPagedSortedListResponse;
        }

        /// <summary>
        /// Get the list of schedules viewable by a group.
        /// The response is either a GroupScheduleGetPagedSortedListResponse or an ErrorResponse.
        /// If no sortOrder is included, the response is sorted by Name ascending by default.
        /// If the responsePagingControl element is not provided, the paging startIndex will be
        /// set to 1 by default, and the responsePageSize will be set to the maximum
        /// responsePageSize by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option
        /// is included. Then the search criteria are logically ORed together.
        /// </summary>
        public static async Task<GroupScheduleGetPagedSortedListResponse> GroupScheduleGetPagedSortedListRequestAsync(this OcipClient client, GroupScheduleGetPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupScheduleGetPagedSortedListResponse;
        }
        /// <summary>
        /// Modify an event of a group schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupScheduleModifyEventRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupScheduleModifyEventRequest(this OcipClient client, GroupScheduleModifyEventRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an event of a group schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        public static async Task<SuccessResponse> GroupScheduleModifyEventRequestAsync(this OcipClient client, GroupScheduleModifyEventRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a group schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupScheduleModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupScheduleModifyRequest(this OcipClient client, GroupScheduleModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a group schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupScheduleModifyRequestAsync(this OcipClient client, GroupScheduleModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of services using a group schedule.
        /// The response is either a GroupScheduleUsageResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupScheduleUsageRequestAsync instead.")]
        public static async Task<GroupScheduleUsageResponse> GroupScheduleUsageRequest(this OcipClient client, GroupScheduleUsageRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupScheduleUsageResponse;
        }

        /// <summary>
        /// Get the list of services using a group schedule.
        /// The response is either a GroupScheduleUsageResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupScheduleUsageResponse> GroupScheduleUsageRequestAsync(this OcipClient client, GroupScheduleUsageRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupScheduleUsageResponse;
        }
        /// <summary>
        /// Get the available group security classification list. If it is not customized, it returns the system default list.
        /// The response is either an GroupSecurityClassificationCustomizationGetAvailableListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupSecurityClassificationCustomizationGetAvailableListRequestAsync instead.")]
        public static async Task<GroupSecurityClassificationCustomizationGetAvailableListResponse> GroupSecurityClassificationCustomizationGetAvailableListRequest(this OcipClient client, GroupSecurityClassificationCustomizationGetAvailableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupSecurityClassificationCustomizationGetAvailableListResponse;
        }

        /// <summary>
        /// Get the available group security classification list. If it is not customized, it returns the system default list.
        /// The response is either an GroupSecurityClassificationCustomizationGetAvailableListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupSecurityClassificationCustomizationGetAvailableListResponse> GroupSecurityClassificationCustomizationGetAvailableListRequestAsync(this OcipClient client, GroupSecurityClassificationCustomizationGetAvailableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupSecurityClassificationCustomizationGetAvailableListResponse;
        }
        /// <summary>
        /// Assign one or more group services to the group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupServiceAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupServiceAssignListRequest(this OcipClient client, GroupServiceAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign one or more group services to the group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupServiceAssignListRequestAsync(this OcipClient client, GroupServiceAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the group's service authorization status.
        /// The response is either GroupServiceGetAuthorizationListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupServiceGetAuthorizationListRequestAsync instead.")]
        public static async Task<GroupServiceGetAuthorizationListResponse> GroupServiceGetAuthorizationListRequest(this OcipClient client, GroupServiceGetAuthorizationListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupServiceGetAuthorizationListResponse;
        }

        /// <summary>
        /// Requests the group's service authorization status.
        /// The response is either GroupServiceGetAuthorizationListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupServiceGetAuthorizationListResponse> GroupServiceGetAuthorizationListRequestAsync(this OcipClient client, GroupServiceGetAuthorizationListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupServiceGetAuthorizationListResponse;
        }
        /// <summary>
        /// Requests the group's service authorization information for a specific service or service pack.
        /// The response is either GroupServiceGetAuthorizationResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupServiceGetAuthorizationRequestAsync instead.")]
        public static async Task<GroupServiceGetAuthorizationResponse> GroupServiceGetAuthorizationRequest(this OcipClient client, GroupServiceGetAuthorizationRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupServiceGetAuthorizationResponse;
        }

        /// <summary>
        /// Requests the group's service authorization information for a specific service or service pack.
        /// The response is either GroupServiceGetAuthorizationResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupServiceGetAuthorizationResponse> GroupServiceGetAuthorizationRequestAsync(this OcipClient client, GroupServiceGetAuthorizationRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupServiceGetAuthorizationResponse;
        }
        /// <summary>
        /// Requests the list of services and service packs authorized to a group.
        /// The response is either GroupServiceGetAuthorizedListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupServiceGetAuthorizedListRequestAsync instead.")]
        public static async Task<GroupServiceGetAuthorizedListResponse> GroupServiceGetAuthorizedListRequest(this OcipClient client, GroupServiceGetAuthorizedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupServiceGetAuthorizedListResponse;
        }

        /// <summary>
        /// Requests the list of services and service packs authorized to a group.
        /// The response is either GroupServiceGetAuthorizedListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupServiceGetAuthorizedListResponse> GroupServiceGetAuthorizedListRequestAsync(this OcipClient client, GroupServiceGetAuthorizedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupServiceGetAuthorizedListResponse;
        }
        /// <summary>
        /// Request to determine if a GroupService is assigned to the group.
        /// The response is either GroupServiceIsAssignedResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupServiceIsAssignedRequestAsync instead.")]
        public static async Task<GroupServiceIsAssignedResponse> GroupServiceIsAssignedRequest(this OcipClient client, GroupServiceIsAssignedRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupServiceIsAssignedResponse;
        }

        /// <summary>
        /// Request to determine if a GroupService is assigned to the group.
        /// The response is either GroupServiceIsAssignedResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupServiceIsAssignedResponse> GroupServiceIsAssignedRequestAsync(this OcipClient client, GroupServiceIsAssignedRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupServiceIsAssignedResponse;
        }
        /// <summary>
        /// Requests to change the group's service authorization status.
        /// The boolean flags are used to authorize or unauthorize services and packs.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupServiceModifyAuthorizationListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupServiceModifyAuthorizationListRequest(this OcipClient client, GroupServiceModifyAuthorizationListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Requests to change the group's service authorization status.
        /// The boolean flags are used to authorize or unauthorize services and packs.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupServiceModifyAuthorizationListRequestAsync(this OcipClient client, GroupServiceModifyAuthorizationListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Lookup if the given number is defined in the specified service in the group.
        /// The response is GroupServicePhoneNumberLookupResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupServicePhoneNumberLookupRequestAsync instead.")]
        public static async Task<GroupServicePhoneNumberLookupResponse> GroupServicePhoneNumberLookupRequest(this OcipClient client, GroupServicePhoneNumberLookupRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupServicePhoneNumberLookupResponse;
        }

        /// <summary>
        /// Lookup if the given number is defined in the specified service in the group.
        /// The response is GroupServicePhoneNumberLookupResponse.
        /// </summary>
        public static async Task<GroupServicePhoneNumberLookupResponse> GroupServicePhoneNumberLookupRequestAsync(this OcipClient client, GroupServicePhoneNumberLookupRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupServicePhoneNumberLookupResponse;
        }
        /// <summary>
        /// Unassign one or more of the group's assigned services.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupServiceUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupServiceUnassignListRequest(this OcipClient client, GroupServiceUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign one or more of the group's assigned services.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupServiceUnassignListRequestAsync(this OcipClient client, GroupServiceUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of devices can be assigned to session admission control group for the group.
        /// The response is either an GroupSessionAdmissionControlGetAvailableDeviceListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupSessionAdmissionControlGetAvailableDeviceListRequestAsync instead.")]
        public static async Task<GroupSessionAdmissionControlGetAvailableDeviceListResponse> GroupSessionAdmissionControlGetAvailableDeviceListRequest(this OcipClient client, GroupSessionAdmissionControlGetAvailableDeviceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupSessionAdmissionControlGetAvailableDeviceListResponse;
        }

        /// <summary>
        /// Request to get the list of devices can be assigned to session admission control group for the group.
        /// The response is either an GroupSessionAdmissionControlGetAvailableDeviceListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupSessionAdmissionControlGetAvailableDeviceListResponse> GroupSessionAdmissionControlGetAvailableDeviceListRequestAsync(this OcipClient client, GroupSessionAdmissionControlGetAvailableDeviceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupSessionAdmissionControlGetAvailableDeviceListResponse;
        }
        /// <summary>
        /// Get the session admission control capacity for the group.
        /// The response is either a GroupSessionAdmissionControlGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupSessionAdmissionControlGetRequestAsync instead.")]
        public static async Task<GroupSessionAdmissionControlGetResponse> GroupSessionAdmissionControlGetRequest(this OcipClient client, GroupSessionAdmissionControlGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupSessionAdmissionControlGetResponse;
        }

        /// <summary>
        /// Get the session admission control capacity for the group.
        /// The response is either a GroupSessionAdmissionControlGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupSessionAdmissionControlGetResponse> GroupSessionAdmissionControlGetRequestAsync(this OcipClient client, GroupSessionAdmissionControlGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupSessionAdmissionControlGetResponse;
        }
        /// <summary>
        /// Request to add one ore more devices to a group level session admission control group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupSessionAdmissionControlGroupAddDeviceListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupSessionAdmissionControlGroupAddDeviceListRequest(this OcipClient client, GroupSessionAdmissionControlGroupAddDeviceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add one ore more devices to a group level session admission control group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupSessionAdmissionControlGroupAddDeviceListRequestAsync(this OcipClient client, GroupSessionAdmissionControlGroupAddDeviceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a session admission control group for the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Note that to provision the accessInfoPattern element, the
        /// captureAccessInfoInPaniHeader system parameter needs to be set to "true".
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupSessionAdmissionControlGroupAddRequest19sp1Async instead.")]
        public static async Task<SuccessResponse> GroupSessionAdmissionControlGroupAddRequest19sp1(this OcipClient client, GroupSessionAdmissionControlGroupAddRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a session admission control group for the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Note that to provision the accessInfoPattern element, the
        /// captureAccessInfoInPaniHeader system parameter needs to be set to "true".
        /// </summary>
        public static async Task<SuccessResponse> GroupSessionAdmissionControlGroupAddRequest19sp1Async(this OcipClient client, GroupSessionAdmissionControlGroupAddRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete one or more devices from a group level session admission control group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupSessionAdmissionControlGroupDeleteDeviceListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupSessionAdmissionControlGroupDeleteDeviceListRequest(this OcipClient client, GroupSessionAdmissionControlGroupDeleteDeviceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete one or more devices from a group level session admission control group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupSessionAdmissionControlGroupDeleteDeviceListRequestAsync(this OcipClient client, GroupSessionAdmissionControlGroupDeleteDeviceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete one or more session admission control groups for the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupSessionAdmissionControlGroupDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupSessionAdmissionControlGroupDeleteListRequest(this OcipClient client, GroupSessionAdmissionControlGroupDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete one or more session admission control groups for the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupSessionAdmissionControlGroupDeleteListRequestAsync(this OcipClient client, GroupSessionAdmissionControlGroupDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of session admission control group for the group.
        /// The response is either a GroupSessionAdmissionControlGroupGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupSessionAdmissionControlGroupGetListRequestAsync instead.")]
        public static async Task<GroupSessionAdmissionControlGroupGetListResponse> GroupSessionAdmissionControlGroupGetListRequest(this OcipClient client, GroupSessionAdmissionControlGroupGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupSessionAdmissionControlGroupGetListResponse;
        }

        /// <summary>
        /// Request to get the list of session admission control group for the group.
        /// The response is either a GroupSessionAdmissionControlGroupGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupSessionAdmissionControlGroupGetListResponse> GroupSessionAdmissionControlGroupGetListRequestAsync(this OcipClient client, GroupSessionAdmissionControlGroupGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupSessionAdmissionControlGroupGetListResponse;
        }
        /// <summary>
        /// Request to get a session admission control group for the group.
        /// The response is either a GroupSessionAdmissionControlGroupGetResponse21sp1V2 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupSessionAdmissionControlGroupGetRequest21sp1V2Async instead.")]
        public static async Task<GroupSessionAdmissionControlGroupGetResponse21sp1V2> GroupSessionAdmissionControlGroupGetRequest21sp1V2(this OcipClient client, GroupSessionAdmissionControlGroupGetRequest21sp1V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupSessionAdmissionControlGroupGetResponse21sp1V2;
        }

        /// <summary>
        /// Request to get a session admission control group for the group.
        /// The response is either a GroupSessionAdmissionControlGroupGetResponse21sp1V2 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupSessionAdmissionControlGroupGetResponse21sp1V2> GroupSessionAdmissionControlGroupGetRequest21sp1V2Async(this OcipClient client, GroupSessionAdmissionControlGroupGetRequest21sp1V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupSessionAdmissionControlGroupGetResponse21sp1V2;
        }
        /// <summary>
        /// Request to modify a session admission control group for the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Note that to provision the accessInfoPattern element, the
        /// captureAccessInfoInPaniHeader system parameter needs to be set to "true".
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupSessionAdmissionControlGroupModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupSessionAdmissionControlGroupModifyRequest(this OcipClient client, GroupSessionAdmissionControlGroupModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a session admission control group for the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Note that to provision the accessInfoPattern element, the
        /// captureAccessInfoInPaniHeader system parameter needs to be set to "true".
        /// </summary>
        public static async Task<SuccessResponse> GroupSessionAdmissionControlGroupModifyRequestAsync(this OcipClient client, GroupSessionAdmissionControlGroupModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify session admission control capacity for the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupSessionAdmissionControlModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupSessionAdmissionControlModifyRequest(this OcipClient client, GroupSessionAdmissionControlModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify session admission control capacity for the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupSessionAdmissionControlModifyRequestAsync(this OcipClient client, GroupSessionAdmissionControlModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Returns a list of all Public User Identities and associated data in a group.
        /// The response is either a GroupShInterfaceGetUserListResponse21sp1 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupShInterfaceGetUserListRequest21sp1Async instead.")]
        public static async Task<GroupShInterfaceGetUserListResponse21sp1> GroupShInterfaceGetUserListRequest21sp1(this OcipClient client, GroupShInterfaceGetUserListRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupShInterfaceGetUserListResponse21sp1;
        }

        /// <summary>
        /// Returns a list of all Public User Identities and associated data in a group.
        /// The response is either a GroupShInterfaceGetUserListResponse21sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupShInterfaceGetUserListResponse21sp1> GroupShInterfaceGetUserListRequest21sp1Async(this OcipClient client, GroupShInterfaceGetUserListRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupShInterfaceGetUserListResponse21sp1;
        }
        /// <summary>
        /// Requests the list of available trunk groups within a group.
        /// The response is either GroupTrunkGroupGetAvailableDetailListResponse or
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupGetAvailableDetailListRequestAsync instead.")]
        public static async Task<GroupTrunkGroupGetAvailableDetailListResponse> GroupTrunkGroupGetAvailableDetailListRequest(this OcipClient client, GroupTrunkGroupGetAvailableDetailListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupTrunkGroupGetAvailableDetailListResponse;
        }

        /// <summary>
        /// Requests the list of available trunk groups within a group.
        /// The response is either GroupTrunkGroupGetAvailableDetailListResponse or
        /// ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetAvailableDetailListResponse> GroupTrunkGroupGetAvailableDetailListRequestAsync(this OcipClient client, GroupTrunkGroupGetAvailableDetailListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupTrunkGroupGetAvailableDetailListResponse;
        }
        /// <summary>
        /// Get a list of users and the service settings for a Call Forwarding service.
        /// The response is either GroupUserCallForwardingSettingsGetListResponse or ErrorResponse.
        /// By default, virtual users and non-virtual users that match the selected search criteria are included in the response when "includeVirtualUsers" is present; otherwise, if "includeVirtualUsers" is absent, then only non-virtual users are returned.
        /// The search can be performed using multiple criteria. If search criteria is specified, only the users matching all of the specified search criteria are included in the response. If no search criteria is specified, all results are returned.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupUserCallForwardingSettingsGetListRequestAsync instead.")]
        public static async Task<GroupUserCallForwardingSettingsGetListResponse> GroupUserCallForwardingSettingsGetListRequest(this OcipClient client, GroupUserCallForwardingSettingsGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupUserCallForwardingSettingsGetListResponse;
        }

        /// <summary>
        /// Get a list of users and the service settings for a Call Forwarding service.
        /// The response is either GroupUserCallForwardingSettingsGetListResponse or ErrorResponse.
        /// By default, virtual users and non-virtual users that match the selected search criteria are included in the response when "includeVirtualUsers" is present; otherwise, if "includeVirtualUsers" is absent, then only non-virtual users are returned.
        /// The search can be performed using multiple criteria. If search criteria is specified, only the users matching all of the specified search criteria are included in the response. If no search criteria is specified, all results are returned.
        /// </summary>
        public static async Task<GroupUserCallForwardingSettingsGetListResponse> GroupUserCallForwardingSettingsGetListRequestAsync(this OcipClient client, GroupUserCallForwardingSettingsGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupUserCallForwardingSettingsGetListResponse;
        }
        /// <summary>
        /// Get a list of users and the default or custom calling plan setting.
        /// The response is either GroupUserCallingPlanSettingsGetListResponse or ErrorResponse.
        /// By default, virtual users and non-virtual users that match the selected search criteria are included in the response when "includeVirtualUsers" is present; otherwise, if "includeVirtualUsers" is absent, then only non-virtual users are returned.
        /// The search can be performed using multiple criteria. If search criteria is specified, only the users matching all of the specified search criteria are included in the response. If no search criteria is specified, all results are returned.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupUserCallingPlanSettingsGetListRequestAsync instead.")]
        public static async Task<GroupUserCallingPlanSettingsGetListResponse> GroupUserCallingPlanSettingsGetListRequest(this OcipClient client, GroupUserCallingPlanSettingsGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupUserCallingPlanSettingsGetListResponse;
        }

        /// <summary>
        /// Get a list of users and the default or custom calling plan setting.
        /// The response is either GroupUserCallingPlanSettingsGetListResponse or ErrorResponse.
        /// By default, virtual users and non-virtual users that match the selected search criteria are included in the response when "includeVirtualUsers" is present; otherwise, if "includeVirtualUsers" is absent, then only non-virtual users are returned.
        /// The search can be performed using multiple criteria. If search criteria is specified, only the users matching all of the specified search criteria are included in the response. If no search criteria is specified, all results are returned.
        /// </summary>
        public static async Task<GroupUserCallingPlanSettingsGetListResponse> GroupUserCallingPlanSettingsGetListRequestAsync(this OcipClient client, GroupUserCallingPlanSettingsGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupUserCallingPlanSettingsGetListResponse;
        }
        /// <summary>
        /// Get a list of users and the Call Waiting service status (active or not active).
        /// The response is either GroupUserCallWaitingSettingsGetListResponse or ErrorResponse.
        /// By default, virtual users and non-virtual users that match the selected search criteria are included in the response when "includeVirtualUsers" is present; otherwise, if "includeVirtualUsers" is absent, then only non-virtual users are returned.
        /// The search can be performed using multiple criteria. If search criteria is specified, only the users matching all of the specified search criteria are included in the response. If no search criteria is specified, all results are returned.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupUserCallWaitingSettingsGetListRequestAsync instead.")]
        public static async Task<GroupUserCallWaitingSettingsGetListResponse> GroupUserCallWaitingSettingsGetListRequest(this OcipClient client, GroupUserCallWaitingSettingsGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupUserCallWaitingSettingsGetListResponse;
        }

        /// <summary>
        /// Get a list of users and the Call Waiting service status (active or not active).
        /// The response is either GroupUserCallWaitingSettingsGetListResponse or ErrorResponse.
        /// By default, virtual users and non-virtual users that match the selected search criteria are included in the response when "includeVirtualUsers" is present; otherwise, if "includeVirtualUsers" is absent, then only non-virtual users are returned.
        /// The search can be performed using multiple criteria. If search criteria is specified, only the users matching all of the specified search criteria are included in the response. If no search criteria is specified, all results are returned.
        /// </summary>
        public static async Task<GroupUserCallWaitingSettingsGetListResponse> GroupUserCallWaitingSettingsGetListRequestAsync(this OcipClient client, GroupUserCallWaitingSettingsGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupUserCallWaitingSettingsGetListResponse;
        }
        /// <summary>
        /// Get a list of users and their Hoteling Guest service status (active or not active).
        /// The response is either GroupUserHotelingGuestSettingsGetListResponse or ErrorResponse.
        /// By default, virtual users and non-virtual users that match the selected search criteria are included in the response when "includeVirtualUsers" is present; otherwise, if "includeVirtualUsers" is absent, then only non-virtual users are returned.
        /// The search can be performed using multiple criteria. If search criteria is specified, only the users matching all of the specified search criteria are included in the response. If no search criteria is specified, all results are returned.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupUserHotelingGuestSettingsGetListRequestAsync instead.")]
        public static async Task<GroupUserHotelingGuestSettingsGetListResponse> GroupUserHotelingGuestSettingsGetListRequest(this OcipClient client, GroupUserHotelingGuestSettingsGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupUserHotelingGuestSettingsGetListResponse;
        }

        /// <summary>
        /// Get a list of users and their Hoteling Guest service status (active or not active).
        /// The response is either GroupUserHotelingGuestSettingsGetListResponse or ErrorResponse.
        /// By default, virtual users and non-virtual users that match the selected search criteria are included in the response when "includeVirtualUsers" is present; otherwise, if "includeVirtualUsers" is absent, then only non-virtual users are returned.
        /// The search can be performed using multiple criteria. If search criteria is specified, only the users matching all of the specified search criteria are included in the response. If no search criteria is specified, all results are returned.
        /// </summary>
        public static async Task<GroupUserHotelingGuestSettingsGetListResponse> GroupUserHotelingGuestSettingsGetListRequestAsync(this OcipClient client, GroupUserHotelingGuestSettingsGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupUserHotelingGuestSettingsGetListResponse;
        }

    }
}
