using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceProviderExtensions
    {

        /// <summary>
        /// Request to add a service provider access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceAddRequest22V2Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceAddRequest22V2(this OcipClient client, ServiceProviderAccessDeviceAddRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a service provider access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceAddRequest22V2Async(this OcipClient client, ServiceProviderAccessDeviceAddRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add or modify a list of static configuration tag for a service provider access
        /// device.  If the tag does not exist, it is added.  If the tag exists, its
        /// value is updated.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceCustomTagAddOrModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceCustomTagAddOrModifyListRequest(this OcipClient client, ServiceProviderAccessDeviceCustomTagAddOrModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add or modify a list of static configuration tag for a service provider access
        /// device.  If the tag does not exist, it is added.  If the tag exists, its
        /// value is updated.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceCustomTagAddOrModifyListRequestAsync(this OcipClient client, ServiceProviderAccessDeviceCustomTagAddOrModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a static configuration tag for a service provider access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceCustomTagAddRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceCustomTagAddRequest(this OcipClient client, ServiceProviderAccessDeviceCustomTagAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a static configuration tag for a service provider access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceCustomTagAddRequestAsync(this OcipClient client, ServiceProviderAccessDeviceCustomTagAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete static configuration tags for a service provider access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceCustomTagDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceCustomTagDeleteListRequest(this OcipClient client, ServiceProviderAccessDeviceCustomTagDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete static configuration tags for a service provider access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceCustomTagDeleteListRequestAsync(this OcipClient client, ServiceProviderAccessDeviceCustomTagDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of custom configuration tags managed by the Device Management System, on a per-device profile basis.
        /// The response is either ServiceProviderAccessDeviceCustomTagGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceCustomTagGetListRequestAsync instead.")]
        public static async Task<ServiceProviderAccessDeviceCustomTagGetListResponse> ServiceProviderAccessDeviceCustomTagGetListRequest(this OcipClient client, ServiceProviderAccessDeviceCustomTagGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceCustomTagGetListResponse;
        }

        /// <summary>
        /// Request to get the list of custom configuration tags managed by the Device Management System, on a per-device profile basis.
        /// The response is either ServiceProviderAccessDeviceCustomTagGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceCustomTagGetListResponse> ServiceProviderAccessDeviceCustomTagGetListRequestAsync(this OcipClient client, ServiceProviderAccessDeviceCustomTagGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceCustomTagGetListResponse;
        }
        /// <summary>
        /// Request to modify a static configuration tag for a service provider access device.
        /// 
        /// The tagValueToEncrypt element can only be used by a system administrator.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceCustomTagModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceCustomTagModifyRequest(this OcipClient client, ServiceProviderAccessDeviceCustomTagModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag for a service provider access device.
        /// 
        /// The tagValueToEncrypt element can only be used by a system administrator.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceCustomTagModifyRequestAsync(this OcipClient client, ServiceProviderAccessDeviceCustomTagModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a specified service provider access device.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// deviceExternalId
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceDeleteRequest(this OcipClient client, ServiceProviderAccessDeviceDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a specified service provider access device.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// deviceExternalId
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceDeleteRequestAsync(this OcipClient client, ServiceProviderAccessDeviceDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the activation information for a device configured at the Service Provider level.
        /// Returns a ServiceProviderAccessDeviceDeviceActivationGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceDeviceActivationGetRequestAsync instead.")]
        public static async Task<ServiceProviderAccessDeviceDeviceActivationGetResponse> ServiceProviderAccessDeviceDeviceActivationGetRequest(this OcipClient client, ServiceProviderAccessDeviceDeviceActivationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceDeviceActivationGetResponse;
        }

        /// <summary>
        /// Requests the activation information for a device configured at the Service Provider level.
        /// Returns a ServiceProviderAccessDeviceDeviceActivationGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceDeviceActivationGetResponse> ServiceProviderAccessDeviceDeviceActivationGetRequestAsync(this OcipClient client, ServiceProviderAccessDeviceDeviceActivationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceDeviceActivationGetResponse;
        }
        /// <summary>
        /// Activates or deactivates a device configured at the Service Provider level. It is only possible
        /// for this request to activate a device which is deactivated. Trying to activate a
        /// device in the activating state will result in an error response since only the DAS is
        /// allowed to execute this operation.
        /// Returns a SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceDeviceActivationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceDeviceActivationModifyRequest(this OcipClient client, ServiceProviderAccessDeviceDeviceActivationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Activates or deactivates a device configured at the Service Provider level. It is only possible
        /// for this request to activate a device which is deactivated. Trying to activate a
        /// device in the activating state will result in an error response since only the DAS is
        /// allowed to execute this operation.
        /// Returns a SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceDeviceActivationModifyRequestAsync(this OcipClient client, ServiceProviderAccessDeviceDeviceActivationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of device files managed by the Device Management System, on a per-device profile basis.
        /// The response is either ServiceProviderAccessDeviceFileGetListResponse14sp8 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceFileGetListRequest14sp8Async instead.")]
        public static async Task<ServiceProviderAccessDeviceFileGetListResponse14sp8> ServiceProviderAccessDeviceFileGetListRequest14sp8(this OcipClient client, ServiceProviderAccessDeviceFileGetListRequest14sp8 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceFileGetListResponse14sp8;
        }

        /// <summary>
        /// Request to get the list of device files managed by the Device Management System, on a per-device profile basis.
        /// The response is either ServiceProviderAccessDeviceFileGetListResponse14sp8 or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceFileGetListResponse14sp8> ServiceProviderAccessDeviceFileGetListRequest14sp8Async(this OcipClient client, ServiceProviderAccessDeviceFileGetListRequest14sp8 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceFileGetListResponse14sp8;
        }
        /// <summary>
        /// Request to get a service provider device profile file.
        /// The response is either ServiceProviderAccessDeviceFileGetResponse20 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceFileGetRequest20Async instead.")]
        public static async Task<ServiceProviderAccessDeviceFileGetResponse20> ServiceProviderAccessDeviceFileGetRequest20(this OcipClient client, ServiceProviderAccessDeviceFileGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceFileGetResponse20;
        }

        /// <summary>
        /// Request to get a service provider device profile file.
        /// The response is either ServiceProviderAccessDeviceFileGetResponse20 or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceFileGetResponse20> ServiceProviderAccessDeviceFileGetRequest20Async(this OcipClient client, ServiceProviderAccessDeviceFileGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceFileGetResponse20;
        }
        /// <summary>
        /// Request to modify a specified service provider/enterprise access device file.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceFileModifyRequest14sp8Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceFileModifyRequest14sp8(this OcipClient client, ServiceProviderAccessDeviceFileModifyRequest14sp8 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a specified service provider/enterprise access device file.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceFileModifyRequest14sp8Async(this OcipClient client, ServiceProviderAccessDeviceFileModifyRequest14sp8 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a new activation code for a device configured at the Service Provider level.
        /// Returns a SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceGenerateActivationCodeRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceGenerateActivationCodeRequest(this OcipClient client, ServiceProviderAccessDeviceGenerateActivationCodeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Requests a new activation code for a device configured at the Service Provider level.
        /// Returns a SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceGenerateActivationCodeRequestAsync(this OcipClient client, ServiceProviderAccessDeviceGenerateActivationCodeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all available custom tags managed by the Device Management System, on a per-device profile basis.
        /// The response is either ServiceProviderAccessDeviceGetAvailableCustomTagListResponse or ErrorResponse.
        /// The following elements are used in AS mode and ignored in XS data mode:
        /// tagSetName
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceGetAvailableCustomTagListRequestAsync instead.")]
        public static async Task<ServiceProviderAccessDeviceGetAvailableCustomTagListResponse> ServiceProviderAccessDeviceGetAvailableCustomTagListRequest(this OcipClient client, ServiceProviderAccessDeviceGetAvailableCustomTagListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceGetAvailableCustomTagListResponse;
        }

        /// <summary>
        /// Get the list of all available custom tags managed by the Device Management System, on a per-device profile basis.
        /// The response is either ServiceProviderAccessDeviceGetAvailableCustomTagListResponse or ErrorResponse.
        /// The following elements are used in AS mode and ignored in XS data mode:
        /// tagSetName
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetAvailableCustomTagListResponse> ServiceProviderAccessDeviceGetAvailableCustomTagListRequestAsync(this OcipClient client, ServiceProviderAccessDeviceGetAvailableCustomTagListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceGetAvailableCustomTagListResponse;
        }
        /// <summary>
        /// Requests the list of configurable device types of devices that have already been
        /// added to the service provider.
        /// The response is either ServiceProviderAccessDeviceGetEnhancedConfigurationTypeListResponse
        /// or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceGetEnhancedConfigurationTypeListRequestAsync instead.")]
        public static async Task<ServiceProviderAccessDeviceGetEnhancedConfigurationTypeListResponse> ServiceProviderAccessDeviceGetEnhancedConfigurationTypeListRequest(this OcipClient client, ServiceProviderAccessDeviceGetEnhancedConfigurationTypeListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceGetEnhancedConfigurationTypeListResponse;
        }

        /// <summary>
        /// Requests the list of configurable device types of devices that have already been
        /// added to the service provider.
        /// The response is either ServiceProviderAccessDeviceGetEnhancedConfigurationTypeListResponse
        /// or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetEnhancedConfigurationTypeListResponse> ServiceProviderAccessDeviceGetEnhancedConfigurationTypeListRequestAsync(this OcipClient client, ServiceProviderAccessDeviceGetEnhancedConfigurationTypeListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceGetEnhancedConfigurationTypeListResponse;
        }
        /// <summary>
        /// Requests the details of a specified configurable device type for a service provider.
        /// The response is either ServiceProviderAccessDeviceGetEnhancedConfigurationTypeResponse
        /// or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceGetEnhancedConfigurationTypeRequestAsync instead.")]
        public static async Task<ServiceProviderAccessDeviceGetEnhancedConfigurationTypeResponse> ServiceProviderAccessDeviceGetEnhancedConfigurationTypeRequest(this OcipClient client, ServiceProviderAccessDeviceGetEnhancedConfigurationTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceGetEnhancedConfigurationTypeResponse;
        }

        /// <summary>
        /// Requests the details of a specified configurable device type for a service provider.
        /// The response is either ServiceProviderAccessDeviceGetEnhancedConfigurationTypeResponse
        /// or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetEnhancedConfigurationTypeResponse> ServiceProviderAccessDeviceGetEnhancedConfigurationTypeRequestAsync(this OcipClient client, ServiceProviderAccessDeviceGetEnhancedConfigurationTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceGetEnhancedConfigurationTypeResponse;
        }
        /// <summary>
        /// Requests the list of linked leaf devices for the service provider level tree device passed in the request.
        /// A tree device is a device associated with a device type that has the option
        /// supportLinks set to "Support Links from Devices". Many leaf devices can be linked to it.
        /// A leaf device is a device associated with a device type that has the option
        /// supportLinks set to "Support Link to Device". It can be linked to only one tree device.
        /// The list includes devices created at the system, service provider, and group levels.
        /// 
        /// The response is either ServiceProviderAccessDeviceGetLinkedLeafDeviceListResponse or
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceGetLinkedLeafDeviceListRequestAsync instead.")]
        public static async Task<ServiceProviderAccessDeviceGetLinkedLeafDeviceListResponse> ServiceProviderAccessDeviceGetLinkedLeafDeviceListRequest(this OcipClient client, ServiceProviderAccessDeviceGetLinkedLeafDeviceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceGetLinkedLeafDeviceListResponse;
        }

        /// <summary>
        /// Requests the list of linked leaf devices for the service provider level tree device passed in the request.
        /// A tree device is a device associated with a device type that has the option
        /// supportLinks set to "Support Links from Devices". Many leaf devices can be linked to it.
        /// A leaf device is a device associated with a device type that has the option
        /// supportLinks set to "Support Link to Device". It can be linked to only one tree device.
        /// The list includes devices created at the system, service provider, and group levels.
        /// 
        /// The response is either ServiceProviderAccessDeviceGetLinkedLeafDeviceListResponse or
        /// ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetLinkedLeafDeviceListResponse> ServiceProviderAccessDeviceGetLinkedLeafDeviceListRequestAsync(this OcipClient client, ServiceProviderAccessDeviceGetLinkedLeafDeviceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceGetLinkedLeafDeviceListResponse;
        }
        /// <summary>
        /// Requests the tree device linked with the service provider level leaf device passed in the request.
        /// A tree device is a device associated with a device type that has the option
        /// supportLinks set to "Support Links from Devices". Many leaf devices can be linked to it.
        /// A leaf device is a device associated with a device type that has the option
        /// supportLinks set to "Support Link to Device". It can be linked to only one tree device.
        /// 
        /// The response is either ServiceProviderAccessDeviceGetLinkedTreeDeviceResponse or
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceGetLinkedTreeDeviceRequestAsync instead.")]
        public static async Task<ServiceProviderAccessDeviceGetLinkedTreeDeviceResponse> ServiceProviderAccessDeviceGetLinkedTreeDeviceRequest(this OcipClient client, ServiceProviderAccessDeviceGetLinkedTreeDeviceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceGetLinkedTreeDeviceResponse;
        }

        /// <summary>
        /// Requests the tree device linked with the service provider level leaf device passed in the request.
        /// A tree device is a device associated with a device type that has the option
        /// supportLinks set to "Support Links from Devices". Many leaf devices can be linked to it.
        /// A leaf device is a device associated with a device type that has the option
        /// supportLinks set to "Support Link to Device". It can be linked to only one tree device.
        /// 
        /// The response is either ServiceProviderAccessDeviceGetLinkedTreeDeviceResponse or
        /// ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetLinkedTreeDeviceResponse> ServiceProviderAccessDeviceGetLinkedTreeDeviceRequestAsync(this OcipClient client, ServiceProviderAccessDeviceGetLinkedTreeDeviceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceGetLinkedTreeDeviceResponse;
        }
        /// <summary>
        /// Requests the list of access devices in a service provider.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// serviceProviderExternalId
        /// 
        /// The response is either ServiceProviderAccessDeviceGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceGetListRequestAsync instead.")]
        public static async Task<ServiceProviderAccessDeviceGetListResponse> ServiceProviderAccessDeviceGetListRequest(this OcipClient client, ServiceProviderAccessDeviceGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceGetListResponse;
        }

        /// <summary>
        /// Requests the list of access devices in a service provider.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// serviceProviderExternalId
        /// 
        /// The response is either ServiceProviderAccessDeviceGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetListResponse> ServiceProviderAccessDeviceGetListRequestAsync(this OcipClient client, ServiceProviderAccessDeviceGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceGetListResponse;
        }
        /// <summary>
        /// Get the list of all native tags with logic managed by the Device Management System, on a per-device profile basis.
        /// The response is either ServiceProviderAccessDeviceGetNativeTagsWithLogicListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceGetNativeTagsWithLogicListRequestAsync instead.")]
        public static async Task<ServiceProviderAccessDeviceGetNativeTagsWithLogicListResponse> ServiceProviderAccessDeviceGetNativeTagsWithLogicListRequest(this OcipClient client, ServiceProviderAccessDeviceGetNativeTagsWithLogicListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceGetNativeTagsWithLogicListResponse;
        }

        /// <summary>
        /// Get the list of all native tags with logic managed by the Device Management System, on a per-device profile basis.
        /// The response is either ServiceProviderAccessDeviceGetNativeTagsWithLogicListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetNativeTagsWithLogicListResponse> ServiceProviderAccessDeviceGetNativeTagsWithLogicListRequestAsync(this OcipClient client, ServiceProviderAccessDeviceGetNativeTagsWithLogicListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceGetNativeTagsWithLogicListResponse;
        }
        /// <summary>
        /// Requests the list of service provider level access devices.
        /// The response is either ServiceProviderAccessDeviceGetPagedSortedListResponse or ErrorResponse.
        /// If no sortOrder is included, the response is sorted by Device Name ascending
        /// by default.  If the responsePagingControl element is not provided, the paging startIndex
        /// will be set to 1 by default, and the responsePageSize will be set to the maximum
        /// responsePageSize by default.
        /// Multiple search criteria are logically ANDed together unless the
        /// searchCriteriaModeOr option is included. Then the search criteria are logically
        /// ORed together.
        /// The getVisualDeviceManagementAPIDevicesOnly element can only be set when CloudPBX is licenced.
        /// If the getVisualDeviceManagementAPIDevicesOnly element is not set, all devices are returned with Visual Device Management API flag set to empty.
        /// If the getVisualDeviceManagementAPIDevicesOnly element is set to true, only SIP devices supporting Visual Device Management API are returned.
        /// If the getVisualDeviceManagementAPIDevicesOnly element is set to false, all SIP devices are returned with their current Visual Device Management API flag value.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceGetPagedSortedListRequestAsync instead.")]
        public static async Task<ServiceProviderAccessDeviceGetPagedSortedListResponse> ServiceProviderAccessDeviceGetPagedSortedListRequest(this OcipClient client, ServiceProviderAccessDeviceGetPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceGetPagedSortedListResponse;
        }

        /// <summary>
        /// Requests the list of service provider level access devices.
        /// The response is either ServiceProviderAccessDeviceGetPagedSortedListResponse or ErrorResponse.
        /// If no sortOrder is included, the response is sorted by Device Name ascending
        /// by default.  If the responsePagingControl element is not provided, the paging startIndex
        /// will be set to 1 by default, and the responsePageSize will be set to the maximum
        /// responsePageSize by default.
        /// Multiple search criteria are logically ANDed together unless the
        /// searchCriteriaModeOr option is included. Then the search criteria are logically
        /// ORed together.
        /// The getVisualDeviceManagementAPIDevicesOnly element can only be set when CloudPBX is licenced.
        /// If the getVisualDeviceManagementAPIDevicesOnly element is not set, all devices are returned with Visual Device Management API flag set to empty.
        /// If the getVisualDeviceManagementAPIDevicesOnly element is set to true, only SIP devices supporting Visual Device Management API are returned.
        /// If the getVisualDeviceManagementAPIDevicesOnly element is set to false, all SIP devices are returned with their current Visual Device Management API flag value.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetPagedSortedListResponse> ServiceProviderAccessDeviceGetPagedSortedListRequestAsync(this OcipClient client, ServiceProviderAccessDeviceGetPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceGetPagedSortedListResponse;
        }
        /// <summary>
        /// Requests the configuration of a specified service provider access device.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// deviceExternalId
        /// 
        /// The response is either ServiceProviderAccessDeviceGetResponse24 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceGetRequest24Async instead.")]
        public static async Task<ServiceProviderAccessDeviceGetResponse24> ServiceProviderAccessDeviceGetRequest24(this OcipClient client, ServiceProviderAccessDeviceGetRequest24 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceGetResponse24;
        }

        /// <summary>
        /// Requests the configuration of a specified service provider access device.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// deviceExternalId
        /// 
        /// The response is either ServiceProviderAccessDeviceGetResponse24 or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetResponse24> ServiceProviderAccessDeviceGetRequest24Async(this OcipClient client, ServiceProviderAccessDeviceGetRequest24 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceGetResponse24;
        }
        /// <summary>
        /// Requests the list of users on a specified device.
        /// The response is either ServiceProviderAccessDeviceGetUserListResponse21sp1 or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceGetUserListRequest21sp1Async instead.")]
        public static async Task<ServiceProviderAccessDeviceGetUserListResponse21sp1> ServiceProviderAccessDeviceGetUserListRequest21sp1(this OcipClient client, ServiceProviderAccessDeviceGetUserListRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceGetUserListResponse21sp1;
        }

        /// <summary>
        /// Requests the list of users on a specified device.
        /// The response is either ServiceProviderAccessDeviceGetUserListResponse21sp1 or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetUserListResponse21sp1> ServiceProviderAccessDeviceGetUserListRequest21sp1Async(this OcipClient client, ServiceProviderAccessDeviceGetUserListRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceGetUserListResponse21sp1;
        }
        /// <summary>
        /// Request to link one or more leaf devices to a service provider level tree device.
        /// A tree device is a device associated with a device type that has the option
        /// supportLinks set to "Support Links from Devices". Many leaf devices can be linked to it.
        /// A leaf device is a device associated with a device type that has the option
        /// supportLinks set to "Support Link to Device". It can be linked to only one tree device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceLinkDeviceListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceLinkDeviceListRequest(this OcipClient client, ServiceProviderAccessDeviceLinkDeviceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to link one or more leaf devices to a service provider level tree device.
        /// A tree device is a device associated with a device type that has the option
        /// supportLinks set to "Support Links from Devices". Many leaf devices can be linked to it.
        /// A leaf device is a device associated with a device type that has the option
        /// supportLinks set to "Support Link to Device". It can be linked to only one tree device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceLinkDeviceListRequestAsync(this OcipClient client, ServiceProviderAccessDeviceLinkDeviceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a specified service provider access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// deviceExternalId
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceModifyRequest22Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceModifyRequest22(this OcipClient client, ServiceProviderAccessDeviceModifyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a specified service provider access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// deviceExternalId
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceModifyRequest22Async(this OcipClient client, ServiceProviderAccessDeviceModifyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify attributes for line/ports assigned on the service provider device profile.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// privateIdentity
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceModifyUserRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceModifyUserRequest(this OcipClient client, ServiceProviderAccessDeviceModifyUserRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify attributes for line/ports assigned on the service provider device profile.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// privateIdentity
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceModifyUserRequestAsync(this OcipClient client, ServiceProviderAccessDeviceModifyUserRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Reset a specific service provider SIP device that supports the reset operation.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceResetRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceResetRequest(this OcipClient client, ServiceProviderAccessDeviceResetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Reset a specific service provider SIP device that supports the reset operation.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceResetRequestAsync(this OcipClient client, ServiceProviderAccessDeviceResetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the custom configuration tag set defined at the access device.
        /// The response is either ServiceProviderAccessDeviceTagSetGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceTagSetGetRequestAsync instead.")]
        public static async Task<ServiceProviderAccessDeviceTagSetGetResponse> ServiceProviderAccessDeviceTagSetGetRequest(this OcipClient client, ServiceProviderAccessDeviceTagSetGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceTagSetGetResponse;
        }

        /// <summary>
        /// Request to get the custom configuration tag set defined at the access device.
        /// The response is either ServiceProviderAccessDeviceTagSetGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceTagSetGetResponse> ServiceProviderAccessDeviceTagSetGetRequestAsync(this OcipClient client, ServiceProviderAccessDeviceTagSetGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceTagSetGetResponse;
        }
        /// <summary>
        /// Request to modify a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceTagSetModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceTagSetModifyRequest(this OcipClient client, ServiceProviderAccessDeviceTagSetModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceTagSetModifyRequestAsync(this OcipClient client, ServiceProviderAccessDeviceTagSetModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to unlink one or more leaf access devices from a tree device.
        /// A leaf device is a device associated with a device type that has the option
        /// supportLinks set to "Support Link to Device". It can be linked to only one tree device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceUnlinkDeviceListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceUnlinkDeviceListRequest(this OcipClient client, ServiceProviderAccessDeviceUnlinkDeviceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to unlink one or more leaf access devices from a tree device.
        /// A leaf device is a device associated with a device type that has the option
        /// supportLinks set to "Support Link to Device". It can be linked to only one tree device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceUnlinkDeviceListRequestAsync(this OcipClient client, ServiceProviderAccessDeviceUnlinkDeviceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a service provider administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdminAddRequest14Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderAdminAddRequest14(this OcipClient client, ServiceProviderAdminAddRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a service provider administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAdminAddRequest14Async(this OcipClient client, ServiceProviderAdminAddRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add an alternate admin Id to a service provider administrator.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdminAlternateIdAddRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderAdminAlternateIdAddRequest(this OcipClient client, ServiceProviderAdminAlternateIdAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add an alternate admin Id to a service provider administrator.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAdminAlternateIdAddRequestAsync(this OcipClient client, ServiceProviderAdminAlternateIdAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete an alternate admin user id of a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdminAlternateIdDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderAdminAlternateIdDeleteRequest(this OcipClient client, ServiceProviderAdminAlternateIdDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete an alternate admin user id of a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAdminAlternateIdDeleteRequestAsync(this OcipClient client, ServiceProviderAdminAlternateIdDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the admin id and the list of alternate admin ids of an admin.
        /// The response is either ServiceProviderAdminAlternateIdGetListResponse or ErrorResponse.
        /// The "userId" can be either the admin user Id or an alternate admin user Id.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdminAlternateIdGetListRequestAsync instead.")]
        public static async Task<ServiceProviderAdminAlternateIdGetListResponse> ServiceProviderAdminAlternateIdGetListRequest(this OcipClient client, ServiceProviderAdminAlternateIdGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAdminAlternateIdGetListResponse;
        }

        /// <summary>
        /// Request to get the admin id and the list of alternate admin ids of an admin.
        /// The response is either ServiceProviderAdminAlternateIdGetListResponse or ErrorResponse.
        /// The "userId" can be either the admin user Id or an alternate admin user Id.
        /// </summary>
        public static async Task<ServiceProviderAdminAlternateIdGetListResponse> ServiceProviderAdminAlternateIdGetListRequestAsync(this OcipClient client, ServiceProviderAdminAlternateIdGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAdminAlternateIdGetListResponse;
        }
        /// <summary>
        /// Request to modify an alternate id of a service provider admin.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdminAlternateIdModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderAdminAlternateIdModifyRequest(this OcipClient client, ServiceProviderAdminAlternateIdModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an alternate id of a service provider admin.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAdminAlternateIdModifyRequestAsync(this OcipClient client, ServiceProviderAdminAlternateIdModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a service provider administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdminDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderAdminDeleteRequest(this OcipClient client, ServiceProviderAdminDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a service provider administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAdminDeleteRequestAsync(this OcipClient client, ServiceProviderAdminDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of service provider administrators.
        /// The response is either a ServiceProviderAdminGetListResponse14 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdminGetListRequest14Async instead.")]
        public static async Task<ServiceProviderAdminGetListResponse14> ServiceProviderAdminGetListRequest14(this OcipClient client, ServiceProviderAdminGetListRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAdminGetListResponse14;
        }

        /// <summary>
        /// Get a list of service provider administrators.
        /// The response is either a ServiceProviderAdminGetListResponse14 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAdminGetListResponse14> ServiceProviderAdminGetListRequest14Async(this OcipClient client, ServiceProviderAdminGetListRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAdminGetListResponse14;
        }
        /// <summary>
        /// Get a list of service provider administrators.
        /// The response is either a ServiceProviderAdminGetPagedSortedListResponse or an ErrorResponse.
        /// If no sortOrder is included, the response is sorted by Administrator ID ascending by default.
        /// If the responsePagingControl element is not provided, the paging startIndex will be
        /// set to 1 by default, and the responsePageSize will be set to the maximum
        /// responsePageSize by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is
        /// included. Then the search criteria are logically ORed together.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdminGetPagedSortedListRequestAsync instead.")]
        public static async Task<ServiceProviderAdminGetPagedSortedListResponse> ServiceProviderAdminGetPagedSortedListRequest(this OcipClient client, ServiceProviderAdminGetPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAdminGetPagedSortedListResponse;
        }

        /// <summary>
        /// Get a list of service provider administrators.
        /// The response is either a ServiceProviderAdminGetPagedSortedListResponse or an ErrorResponse.
        /// If no sortOrder is included, the response is sorted by Administrator ID ascending by default.
        /// If the responsePagingControl element is not provided, the paging startIndex will be
        /// set to 1 by default, and the responsePageSize will be set to the maximum
        /// responsePageSize by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is
        /// included. Then the search criteria are logically ORed together.
        /// </summary>
        public static async Task<ServiceProviderAdminGetPagedSortedListResponse> ServiceProviderAdminGetPagedSortedListRequestAsync(this OcipClient client, ServiceProviderAdminGetPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAdminGetPagedSortedListResponse;
        }
        /// <summary>
        /// Requests the service provider administrator's policy settings.
        /// The response is either ServiceProviderAdminGetPolicyResponse20 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdminGetPolicyRequest20Async instead.")]
        public static async Task<ServiceProviderAdminGetPolicyResponse20> ServiceProviderAdminGetPolicyRequest20(this OcipClient client, ServiceProviderAdminGetPolicyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAdminGetPolicyResponse20;
        }

        /// <summary>
        /// Requests the service provider administrator's policy settings.
        /// The response is either ServiceProviderAdminGetPolicyResponse20 or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAdminGetPolicyResponse20> ServiceProviderAdminGetPolicyRequest20Async(this OcipClient client, ServiceProviderAdminGetPolicyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAdminGetPolicyResponse20;
        }
        /// <summary>
        /// Get a service provider administrators profile.
        /// The response is either a ServiceProviderAdminGetResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdminGetRequest22Async instead.")]
        public static async Task<ServiceProviderAdminGetResponse22> ServiceProviderAdminGetRequest22(this OcipClient client, ServiceProviderAdminGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAdminGetResponse22;
        }

        /// <summary>
        /// Get a service provider administrators profile.
        /// The response is either a ServiceProviderAdminGetResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAdminGetResponse22> ServiceProviderAdminGetRequest22Async(this OcipClient client, ServiceProviderAdminGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAdminGetResponse22;
        }
        /// <summary>
        /// Requests the effective password rules setting for a service provider administrator
        /// The response is either ServiceProviderAdministratorPasswordRulesGetResponse or
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdministratorPasswordRulesGetRequestAsync instead.")]
        public static async Task<ServiceProviderAdministratorPasswordRulesGetResponse> ServiceProviderAdministratorPasswordRulesGetRequest(this OcipClient client, ServiceProviderAdministratorPasswordRulesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAdministratorPasswordRulesGetResponse;
        }

        /// <summary>
        /// Requests the effective password rules setting for a service provider administrator
        /// The response is either ServiceProviderAdministratorPasswordRulesGetResponse or
        /// ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAdministratorPasswordRulesGetResponse> ServiceProviderAdministratorPasswordRulesGetRequestAsync(this OcipClient client, ServiceProviderAdministratorPasswordRulesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAdministratorPasswordRulesGetResponse;
        }
        /// <summary>
        /// Request to modify the service provider administrator's policy settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The networkPolicyAccess is only modified for the enterprise administrator.
        /// The following elements are only used in AS data mode:
        /// dialableCallerIDAccess
        /// verifyTranslationAndroutingAccess
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdminModifyPolicyRequest14Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderAdminModifyPolicyRequest14(this OcipClient client, ServiceProviderAdminModifyPolicyRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the service provider administrator's policy settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The networkPolicyAccess is only modified for the enterprise administrator.
        /// The following elements are only used in AS data mode:
        /// dialableCallerIDAccess
        /// verifyTranslationAndroutingAccess
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAdminModifyPolicyRequest14Async(this OcipClient client, ServiceProviderAdminModifyPolicyRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a service provider administrator.
        /// Since old password is not specified here, any password rule related to old password
        /// does not apply.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdminModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderAdminModifyRequest(this OcipClient client, ServiceProviderAdminModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a service provider administrator.
        /// Since old password is not specified here, any password rule related to old password
        /// does not apply.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAdminModifyRequestAsync(this OcipClient client, ServiceProviderAdminModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a service provider or enterprise's answer confirmation settings.
        /// The response is either a ServiceProviderAnswerConfirmationGetResponse16 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAnswerConfirmationGetRequest16Async instead.")]
        public static async Task<ServiceProviderAnswerConfirmationGetResponse16> ServiceProviderAnswerConfirmationGetRequest16(this OcipClient client, ServiceProviderAnswerConfirmationGetRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAnswerConfirmationGetResponse16;
        }

        /// <summary>
        /// Get a service provider or enterprise's answer confirmation settings.
        /// The response is either a ServiceProviderAnswerConfirmationGetResponse16 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAnswerConfirmationGetResponse16> ServiceProviderAnswerConfirmationGetRequest16Async(this OcipClient client, ServiceProviderAnswerConfirmationGetRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAnswerConfirmationGetResponse16;
        }
        /// <summary>
        /// Modify a service provider or enterprise's answer confirmation settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAnswerConfirmationModifyRequest16Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderAnswerConfirmationModifyRequest16(this OcipClient client, ServiceProviderAnswerConfirmationModifyRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a service provider or enterprise's answer confirmation settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAnswerConfirmationModifyRequest16Async(this OcipClient client, ServiceProviderAnswerConfirmationModifyRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the Application Server set for a service provider or enterprise.
        /// The response is either a ServiceProviderApplicationServerSetGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderApplicationServerSetGetRequestAsync instead.")]
        public static async Task<ServiceProviderApplicationServerSetGetResponse> ServiceProviderApplicationServerSetGetRequest(this OcipClient client, ServiceProviderApplicationServerSetGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderApplicationServerSetGetResponse;
        }

        /// <summary>
        /// Get the Application Server set for a service provider or enterprise.
        /// The response is either a ServiceProviderApplicationServerSetGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderApplicationServerSetGetResponse> ServiceProviderApplicationServerSetGetRequestAsync(this OcipClient client, ServiceProviderApplicationServerSetGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderApplicationServerSetGetResponse;
        }
        /// <summary>
        /// Modify the Application Server set assigned to the service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderApplicationServerSetModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderApplicationServerSetModifyRequest(this OcipClient client, ServiceProviderApplicationServerSetModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Application Server set assigned to the service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderApplicationServerSetModifyRequestAsync(this OcipClient client, ServiceProviderApplicationServerSetModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse22V3 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCallProcessingGetPolicyRequest22V3Async instead.")]
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse22V3> ServiceProviderCallProcessingGetPolicyRequest22V3(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest22V3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCallProcessingGetPolicyResponse22V3;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse22V3 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse22V3> ServiceProviderCallProcessingGetPolicyRequest22V3Async(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest22V3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCallProcessingGetPolicyResponse22V3;
        }
        /// <summary>
        /// Modify the service provider level data associated with Call Processing
        /// Policy. The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// useServiceProviderDCLIDSetting
        /// enableDialableCallerID
        /// allowConfigurableCLIDForRedirectingIdentity
        /// enterpriseCallsCLIDPolicy
        /// groupCallsCLIDPolicy
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// enablePhoneListLookup
        /// useMaxConcurrentTerminatingAlertingRequests
        /// maxConcurrentTerminatingAlertingRequests
        /// includeRedirectionsInMaximumNumberOfConcurrentCalls
        /// useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable
        /// useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable
        /// allowMobileDNForRedirectingIdentity
        /// enableGatewayRoutePolicy
        /// networkCallsGatewayRouteIdentity
        /// networkURLCallsGatewayRouteIdentity
        /// emergencyCallsGatewayRouteIdentity
        /// repairCallsGatewayRouteIdentity
        /// callTypingErrorsGatewayRouteIdentity
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// routeOverrideDomain
        /// routeOverridePrefix
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCallProcessingModifyPolicyRequest15Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderCallProcessingModifyPolicyRequest15(this OcipClient client, ServiceProviderCallProcessingModifyPolicyRequest15 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the service provider level data associated with Call Processing
        /// Policy. The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// useServiceProviderDCLIDSetting
        /// enableDialableCallerID
        /// allowConfigurableCLIDForRedirectingIdentity
        /// enterpriseCallsCLIDPolicy
        /// groupCallsCLIDPolicy
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// enablePhoneListLookup
        /// useMaxConcurrentTerminatingAlertingRequests
        /// maxConcurrentTerminatingAlertingRequests
        /// includeRedirectionsInMaximumNumberOfConcurrentCalls
        /// useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable
        /// useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable
        /// allowMobileDNForRedirectingIdentity
        /// enableGatewayRoutePolicy
        /// networkCallsGatewayRouteIdentity
        /// networkURLCallsGatewayRouteIdentity
        /// emergencyCallsGatewayRouteIdentity
        /// repairCallsGatewayRouteIdentity
        /// callTypingErrorsGatewayRouteIdentity
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// routeOverrideDomain
        /// routeOverridePrefix
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCallProcessingModifyPolicyRequest15Async(this OcipClient client, ServiceProviderCallProcessingModifyPolicyRequest15 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a list of Communication Barring Criteria to a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringCriteriaAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringCriteriaAssignListRequest(this OcipClient client, ServiceProviderCommunicationBarringCriteriaAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Communication Barring Criteria to a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringCriteriaAssignListRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringCriteriaAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Communication Barring Criteria assigned to a service provider.
        /// The response is either a ServiceProviderCommunicationBarringCriteriaGetAssignedListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringCriteriaGetAssignedListRequestAsync instead.")]
        public static async Task<ServiceProviderCommunicationBarringCriteriaGetAssignedListResponse> ServiceProviderCommunicationBarringCriteriaGetAssignedListRequest(this OcipClient client, ServiceProviderCommunicationBarringCriteriaGetAssignedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCommunicationBarringCriteriaGetAssignedListResponse;
        }

        /// <summary>
        /// Get a list of Communication Barring Criteria assigned to a service provider.
        /// The response is either a ServiceProviderCommunicationBarringCriteriaGetAssignedListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringCriteriaGetAssignedListResponse> ServiceProviderCommunicationBarringCriteriaGetAssignedListRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringCriteriaGetAssignedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCommunicationBarringCriteriaGetAssignedListResponse;
        }
        /// <summary>
        /// Unassign a list of Communication Barring Criteria from a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringCriteriaUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringCriteriaUnassignListRequest(this OcipClient client, ServiceProviderCommunicationBarringCriteriaUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of Communication Barring Criteria from a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringCriteriaUnassignListRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringCriteriaUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringDigitPatternCriteriaAddRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringDigitPatternCriteriaAddRequest(this OcipClient client, ServiceProviderCommunicationBarringDigitPatternCriteriaAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringDigitPatternCriteriaAddRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringDigitPatternCriteriaAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an existing Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringDigitPatternCriteriaDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringDigitPatternCriteriaDeleteRequest(this OcipClient client, ServiceProviderCommunicationBarringDigitPatternCriteriaDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an existing Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringDigitPatternCriteriaDeleteRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringDigitPatternCriteriaDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all Digit Pattern Criteria defined for the service provider.
        /// The response is either a ServiceProviderCommunicationBarringDigitPatternCriteriaGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringDigitPatternCriteriaGetListRequestAsync instead.")]
        public static async Task<ServiceProviderCommunicationBarringDigitPatternCriteriaGetListResponse> ServiceProviderCommunicationBarringDigitPatternCriteriaGetListRequest(this OcipClient client, ServiceProviderCommunicationBarringDigitPatternCriteriaGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCommunicationBarringDigitPatternCriteriaGetListResponse;
        }

        /// <summary>
        /// Get the list of all Digit Pattern Criteria defined for the service provider.
        /// The response is either a ServiceProviderCommunicationBarringDigitPatternCriteriaGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringDigitPatternCriteriaGetListResponse> ServiceProviderCommunicationBarringDigitPatternCriteriaGetListRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringDigitPatternCriteriaGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCommunicationBarringDigitPatternCriteriaGetListResponse;
        }
        /// <summary>
        /// Get an existing Digit Pattern Criteria.
        /// The response is either a ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListRequestAsync instead.")]
        public static async Task<ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListResponse> ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListRequest(this OcipClient client, ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListResponse;
        }

        /// <summary>
        /// Get an existing Digit Pattern Criteria.
        /// The response is either a ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListResponse> ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListResponse;
        }
        /// <summary>
        /// Get an existing Digit Pattern Criteria.
        /// The response is either a ServiceProviderCommunicationBarringDigitPatternCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringDigitPatternCriteriaGetRequestAsync instead.")]
        public static async Task<ServiceProviderCommunicationBarringDigitPatternCriteriaGetResponse> ServiceProviderCommunicationBarringDigitPatternCriteriaGetRequest(this OcipClient client, ServiceProviderCommunicationBarringDigitPatternCriteriaGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCommunicationBarringDigitPatternCriteriaGetResponse;
        }

        /// <summary>
        /// Get an existing Digit Pattern Criteria.
        /// The response is either a ServiceProviderCommunicationBarringDigitPatternCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringDigitPatternCriteriaGetResponse> ServiceProviderCommunicationBarringDigitPatternCriteriaGetRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringDigitPatternCriteriaGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCommunicationBarringDigitPatternCriteriaGetResponse;
        }
        /// <summary>
        /// Modify an existing Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringDigitPatternCriteriaModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringDigitPatternCriteriaModifyRequest(this OcipClient client, ServiceProviderCommunicationBarringDigitPatternCriteriaModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringDigitPatternCriteriaModifyRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringDigitPatternCriteriaModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a list of Communication Barring Incoming Criteria to a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringIncomingCriteriaAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringIncomingCriteriaAssignListRequest(this OcipClient client, ServiceProviderCommunicationBarringIncomingCriteriaAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Communication Barring Incoming Criteria to a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringIncomingCriteriaAssignListRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringIncomingCriteriaAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Communication Barring Incoming Criteria assigned to a service provider.
        /// The response is either a ServiceProviderCommunicationBarringIncomingCriteriaGetAssignedListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringIncomingCriteriaGetAssignedListRequestAsync instead.")]
        public static async Task<ServiceProviderCommunicationBarringIncomingCriteriaGetAssignedListResponse> ServiceProviderCommunicationBarringIncomingCriteriaGetAssignedListRequest(this OcipClient client, ServiceProviderCommunicationBarringIncomingCriteriaGetAssignedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCommunicationBarringIncomingCriteriaGetAssignedListResponse;
        }

        /// <summary>
        /// Get a list of Communication Barring Incoming Criteria assigned to a service provider.
        /// The response is either a ServiceProviderCommunicationBarringIncomingCriteriaGetAssignedListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringIncomingCriteriaGetAssignedListResponse> ServiceProviderCommunicationBarringIncomingCriteriaGetAssignedListRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringIncomingCriteriaGetAssignedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCommunicationBarringIncomingCriteriaGetAssignedListResponse;
        }
        /// <summary>
        /// Unassign a list of Communication Barring Incoming Criteria from a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringIncomingCriteriaUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringIncomingCriteriaUnassignListRequest(this OcipClient client, ServiceProviderCommunicationBarringIncomingCriteriaUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of Communication Barring Incoming Criteria from a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringIncomingCriteriaUnassignListRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringIncomingCriteriaUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Communication Barring Profile.
        /// The priorities for OriginatingRules, RedirectingRules, CallMeNowRules and IncomingRules are requantized to consecutive integers as part of the add.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction, use value "Block" in XS data mode
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// applyToAttendedCallTransfers, use value "false" in XS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringProfileAddRequest19sp1Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringProfileAddRequest19sp1(this OcipClient client, ServiceProviderCommunicationBarringProfileAddRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Communication Barring Profile.
        /// The priorities for OriginatingRules, RedirectingRules, CallMeNowRules and IncomingRules are requantized to consecutive integers as part of the add.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction, use value "Block" in XS data mode
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// applyToAttendedCallTransfers, use value "false" in XS data mode
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringProfileAddRequest19sp1Async(this OcipClient client, ServiceProviderCommunicationBarringProfileAddRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deletes an existing Communication Barring Profile.  Optionally, a new default profile can be chosen if the current default profile is being deleted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringProfileDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringProfileDeleteRequest(this OcipClient client, ServiceProviderCommunicationBarringProfileDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deletes an existing Communication Barring Profile.  Optionally, a new default profile can be chosen if the current default profile is being deleted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringProfileDeleteRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringProfileDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of groups within a service provider that have a given
        /// Communication Barring Profile assigned.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetAssignedGroupListResponse
        /// or an ErorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringProfileGetAssignedGroupListRequestAsync instead.")]
        public static async Task<ServiceProviderCommunicationBarringProfileGetAssignedGroupListResponse> ServiceProviderCommunicationBarringProfileGetAssignedGroupListRequest(this OcipClient client, ServiceProviderCommunicationBarringProfileGetAssignedGroupListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetAssignedGroupListResponse;
        }

        /// <summary>
        /// Get a list of groups within a service provider that have a given
        /// Communication Barring Profile assigned.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetAssignedGroupListResponse
        /// or an ErorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringProfileGetAssignedGroupListResponse> ServiceProviderCommunicationBarringProfileGetAssignedGroupListRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringProfileGetAssignedGroupListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetAssignedGroupListResponse;
        }
        /// <summary>
        /// Get a list of Communication Barring profiles within a service provider that have a given Communication Barring Criteria assigned.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetCriteriaUsageListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringProfileGetCriteriaUsageListRequestAsync instead.")]
        public static async Task<ServiceProviderCommunicationBarringProfileGetCriteriaUsageListResponse> ServiceProviderCommunicationBarringProfileGetCriteriaUsageListRequest(this OcipClient client, ServiceProviderCommunicationBarringProfileGetCriteriaUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetCriteriaUsageListResponse;
        }

        /// <summary>
        /// Get a list of Communication Barring profiles within a service provider that have a given Communication Barring Criteria assigned.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetCriteriaUsageListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringProfileGetCriteriaUsageListResponse> ServiceProviderCommunicationBarringProfileGetCriteriaUsageListRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringProfileGetCriteriaUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetCriteriaUsageListResponse;
        }
        /// <summary>
        /// Get the list of Profiles that use a specific Digit Pattern Criteria.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringProfileGetDigitPatternCriteriaUsageListRequestAsync instead.")]
        public static async Task<ServiceProviderCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse> ServiceProviderCommunicationBarringProfileGetDigitPatternCriteriaUsageListRequest(this OcipClient client, ServiceProviderCommunicationBarringProfileGetDigitPatternCriteriaUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse;
        }

        /// <summary>
        /// Get the list of Profiles that use a specific Digit Pattern Criteria.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse> ServiceProviderCommunicationBarringProfileGetDigitPatternCriteriaUsageListRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringProfileGetDigitPatternCriteriaUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse;
        }
        /// <summary>
        /// Get a list of Communication Barring profiles within a service provider that have a given Communication Barring Incoming Criteria assigned.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetIncomingCriteriaUsageListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringProfileGetIncomingCriteriaUsageListRequestAsync instead.")]
        public static async Task<ServiceProviderCommunicationBarringProfileGetIncomingCriteriaUsageListResponse> ServiceProviderCommunicationBarringProfileGetIncomingCriteriaUsageListRequest(this OcipClient client, ServiceProviderCommunicationBarringProfileGetIncomingCriteriaUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetIncomingCriteriaUsageListResponse;
        }

        /// <summary>
        /// Get a list of Communication Barring profiles within a service provider that have a given Communication Barring Incoming Criteria assigned.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetIncomingCriteriaUsageListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringProfileGetIncomingCriteriaUsageListResponse> ServiceProviderCommunicationBarringProfileGetIncomingCriteriaUsageListRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringProfileGetIncomingCriteriaUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetIncomingCriteriaUsageListResponse;
        }
        /// <summary>
        /// Get the list of all Communication Barring Profiles.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringProfileGetListRequestAsync instead.")]
        public static async Task<ServiceProviderCommunicationBarringProfileGetListResponse> ServiceProviderCommunicationBarringProfileGetListRequest(this OcipClient client, ServiceProviderCommunicationBarringProfileGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetListResponse;
        }

        /// <summary>
        /// Get the list of all Communication Barring Profiles.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringProfileGetListResponse> ServiceProviderCommunicationBarringProfileGetListRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringProfileGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetListResponse;
        }
        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetResponse19sp1V2 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringProfileGetRequest19sp1V2Async instead.")]
        public static async Task<ServiceProviderCommunicationBarringProfileGetResponse19sp1V2> ServiceProviderCommunicationBarringProfileGetRequest19sp1V2(this OcipClient client, ServiceProviderCommunicationBarringProfileGetRequest19sp1V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetResponse19sp1V2;
        }

        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetResponse19sp1V2 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringProfileGetResponse19sp1V2> ServiceProviderCommunicationBarringProfileGetRequest19sp1V2Async(this OcipClient client, ServiceProviderCommunicationBarringProfileGetRequest19sp1V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetResponse19sp1V2;
        }
        /// <summary>
        /// Modifies the default Communication Barring Profile of a Service Provider.  If a default has been previously selected, this command will swap the default profile with the profile provided.  Selecting a nil profile will cause the service provider to not have a default Communicaton Barring Profile.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringProfileModifyDefaultRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringProfileModifyDefaultRequest(this OcipClient client, ServiceProviderCommunicationBarringProfileModifyDefaultRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the default Communication Barring Profile of a Service Provider.  If a default has been previously selected, this command will swap the default profile with the profile provided.  Selecting a nil profile will cause the service provider to not have a default Communicaton Barring Profile.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringProfileModifyDefaultRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringProfileModifyDefaultRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify an existing Communication Barring Profile.
        /// The priorities for OriginatingRules, RedirectingRules, CallMeNowRules and IncomingRules are requantized to consecutive integers as part of the modify.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// applyToAttendedCallTransfers
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringProfileModifyRequest(this OcipClient client, ServiceProviderCommunicationBarringProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing Communication Barring Profile.
        /// The priorities for OriginatingRules, RedirectingRules, CallMeNowRules and IncomingRules are requantized to consecutive integers as part of the modify.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// applyToAttendedCallTransfers
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringProfileModifyRequestAsync(this OcipClient client, ServiceProviderCommunicationBarringProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// serviceProviderExtenalId
        /// 
        /// The following elements are only used in Amplify data mode and ignored in AS and XS data mode:
        /// servicePolicy,
        /// callProcessingSliceId,
        /// provisioningSliceId,
        /// subscriberPartition.
        /// When the callProcessingSliceId or provisioningSliceId is not specified in the AmplifyDataMode,
        /// the default slice Id is assigned to the service provider.
        /// Only Provisioning admin and above can change the callProcessingSliceId,  provisioningSliceId, andsubscriberPartition.
        /// 
        /// The following elements are only used in Amplify and XS data mode and ignored in AS data mode:
        /// preferredDataCenter.
        /// Only Provisioning admin and above can change the preferredDataCenter.
        /// 
        /// The following data elements are only used in AS data mode:
        /// resellerId
        /// resellerName
        /// 
        /// The following behavior is only applicable in CloudPBX:
        /// - when new resellerId, that does not exist in the system, is specified, the new
        /// Reseller is created the given resellerId and resellerName (if provided) and enterprise/Service Provider
        /// is moved to the newly created Reseller.
        /// 
        /// resellerName element is ignored if the reseller the service provider is being moved to 	already exists.
        /// 
        /// The following elements are optional for the service provider. If the elements are included,
        /// they will be either added, authorized, or modified on the service provider. Should any of the
        /// following elements be rejected to due existing system settings, the service provider will not
        /// be added and the response will be an ErrorResponse:
        /// domain
        /// admin
        /// groupServiceAuthorization
        /// userServiceAuthorization
        /// servicePack
        /// phoneNumber
        /// dnRange
        /// routingProfile
        /// meetMeConferencingAllocatedPorts
        /// trunkGroupMaxActiveCalls
        /// trunkGroupBurstingMaxActiveCalls
        /// voiceMessagingGroupSettings
        /// voiceMessagingVoicePortalScope
        /// 
        /// When a group or user service is included that is not activated or is not licensed,
        /// the response will be an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderConsolidatedAddRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderConsolidatedAddRequest(this OcipClient client, ServiceProviderConsolidatedAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// serviceProviderExtenalId
        /// 
        /// The following elements are only used in Amplify data mode and ignored in AS and XS data mode:
        /// servicePolicy,
        /// callProcessingSliceId,
        /// provisioningSliceId,
        /// subscriberPartition.
        /// When the callProcessingSliceId or provisioningSliceId is not specified in the AmplifyDataMode,
        /// the default slice Id is assigned to the service provider.
        /// Only Provisioning admin and above can change the callProcessingSliceId,  provisioningSliceId, andsubscriberPartition.
        /// 
        /// The following elements are only used in Amplify and XS data mode and ignored in AS data mode:
        /// preferredDataCenter.
        /// Only Provisioning admin and above can change the preferredDataCenter.
        /// 
        /// The following data elements are only used in AS data mode:
        /// resellerId
        /// resellerName
        /// 
        /// The following behavior is only applicable in CloudPBX:
        /// - when new resellerId, that does not exist in the system, is specified, the new
        /// Reseller is created the given resellerId and resellerName (if provided) and enterprise/Service Provider
        /// is moved to the newly created Reseller.
        /// 
        /// resellerName element is ignored if the reseller the service provider is being moved to 	already exists.
        /// 
        /// The following elements are optional for the service provider. If the elements are included,
        /// they will be either added, authorized, or modified on the service provider. Should any of the
        /// following elements be rejected to due existing system settings, the service provider will not
        /// be added and the response will be an ErrorResponse:
        /// domain
        /// admin
        /// groupServiceAuthorization
        /// userServiceAuthorization
        /// servicePack
        /// phoneNumber
        /// dnRange
        /// routingProfile
        /// meetMeConferencingAllocatedPorts
        /// trunkGroupMaxActiveCalls
        /// trunkGroupBurstingMaxActiveCalls
        /// voiceMessagingGroupSettings
        /// voiceMessagingVoicePortalScope
        /// 
        /// When a group or user service is included that is not activated or is not licensed,
        /// the response will be an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderConsolidatedAddRequestAsync(this OcipClient client, ServiceProviderConsolidatedAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Rebuild the service provider default config file for the specified device type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCPEConfigRebuildConfigFileRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderCPEConfigRebuildConfigFileRequest(this OcipClient client, ServiceProviderCPEConfigRebuildConfigFileRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Rebuild the service provider default config file for the specified device type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCPEConfigRebuildConfigFileRequestAsync(this OcipClient client, ServiceProviderCPEConfigRebuildConfigFileRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Rebuild the config file for a specified device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCPEConfigRebuildDeviceConfigFileRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderCPEConfigRebuildDeviceConfigFileRequest(this OcipClient client, ServiceProviderCPEConfigRebuildDeviceConfigFileRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Rebuild the config file for a specified device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCPEConfigRebuildDeviceConfigFileRequestAsync(this OcipClient client, ServiceProviderCPEConfigRebuildDeviceConfigFileRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Reorder the lines of a Service Provider device. You can not add or delete line ports, only
        /// re-ordering the list is allowed. The ordered list of line ports can be obtained
        /// with the ServiceProviderAccessDeviceGetRequest command.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCPEConfigReorderDeviceLinePortsRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderCPEConfigReorderDeviceLinePortsRequest(this OcipClient client, ServiceProviderCPEConfigReorderDeviceLinePortsRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Reorder the lines of a Service Provider device. You can not add or delete line ports, only
        /// re-ordering the list is allowed. The ordered list of line ports can be obtained
        /// with the ServiceProviderAccessDeviceGetRequest command.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCPEConfigReorderDeviceLinePortsRequestAsync(this OcipClient client, ServiceProviderCPEConfigReorderDeviceLinePortsRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Reset a specific service provider or enterprise device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCPEConfigResetDeviceRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderCPEConfigResetDeviceRequest(this OcipClient client, ServiceProviderCPEConfigResetDeviceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Reset a specific service provider or enterprise device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCPEConfigResetDeviceRequestAsync(this OcipClient client, ServiceProviderCPEConfigResetDeviceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Reset all the devices of the specified device type in a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCPEConfigResetDeviceTypeRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderCPEConfigResetDeviceTypeRequest(this OcipClient client, ServiceProviderCPEConfigResetDeviceTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Reset all the devices of the specified device type in a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCPEConfigResetDeviceTypeRequestAsync(this OcipClient client, ServiceProviderCPEConfigResetDeviceTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to set a new service provider default configuration file for a device type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// When the element configFile is set to nil, the configuration file defined
        /// at the parent level is used.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCPEConfigSetConfigFileRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderCPEConfigSetConfigFileRequest(this OcipClient client, ServiceProviderCPEConfigSetConfigFileRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to set a new service provider default configuration file for a device type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// When the element configFile is set to nil, the configuration file defined
        /// at the parent level is used.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCPEConfigSetConfigFileRequestAsync(this OcipClient client, ServiceProviderCPEConfigSetConfigFileRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDeleteRequest(this OcipClient client, ServiceProviderDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDeleteRequestAsync(this OcipClient client, ServiceProviderDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the Device Activation policy of a service provider or an enterprise.
        /// The response is either a ServiceProviderDeviceActivationPolicyGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDeviceActivationPolicyGetRequestAsync instead.")]
        public static async Task<ServiceProviderDeviceActivationPolicyGetResponse> ServiceProviderDeviceActivationPolicyGetRequest(this OcipClient client, ServiceProviderDeviceActivationPolicyGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDeviceActivationPolicyGetResponse;
        }

        /// <summary>
        /// Request the Device Activation policy of a service provider or an enterprise.
        /// The response is either a ServiceProviderDeviceActivationPolicyGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDeviceActivationPolicyGetResponse> ServiceProviderDeviceActivationPolicyGetRequestAsync(this OcipClient client, ServiceProviderDeviceActivationPolicyGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDeviceActivationPolicyGetResponse;
        }
        /// <summary>
        /// Modify the Device Activation policy of a service provider or an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDeviceActivationPolicyModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDeviceActivationPolicyModifyRequest(this OcipClient client, ServiceProviderDeviceActivationPolicyModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Device Activation policy of a service provider or an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDeviceActivationPolicyModifyRequestAsync(this OcipClient client, ServiceProviderDeviceActivationPolicyModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request device management's events for a specific queue.
        /// It is possible to restrict the number of rows returned using
        /// responseSizeLimit.
        /// If eventQueueType is not specified, the events from all the
        /// event queues are returned.
        /// The response is either a ServiceProviderDeviceManagementEventGetListResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDeviceManagementEventGetListRequest22Async instead.")]
        public static async Task<ServiceProviderDeviceManagementEventGetListResponse22> ServiceProviderDeviceManagementEventGetListRequest22(this OcipClient client, ServiceProviderDeviceManagementEventGetListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDeviceManagementEventGetListResponse22;
        }

        /// <summary>
        /// Request device management's events for a specific queue.
        /// It is possible to restrict the number of rows returned using
        /// responseSizeLimit.
        /// If eventQueueType is not specified, the events from all the
        /// event queues are returned.
        /// The response is either a ServiceProviderDeviceManagementEventGetListResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDeviceManagementEventGetListResponse22> ServiceProviderDeviceManagementEventGetListRequest22Async(this OcipClient client, ServiceProviderDeviceManagementEventGetListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDeviceManagementEventGetListResponse22;
        }
        /// <summary>
        /// Request the number of access device of a particular device type and service provider.
        /// If countOnlyResetSupportedDevice is true, count only access devices if the device type supports reset.
        /// By default unmanaged device types are not allowed and devices are counted only if their device type supports Device Management.
        /// An error is returned if deviceType is specified but does not support device management.
        /// When allowUnmanagedDeviceType is true, unmanaged device type will be counted and a successful response is returned.
        /// The response is either ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderRequestAsync instead.")]
        public static async Task<ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderResponse> ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderRequest(this OcipClient client, ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderResponse;
        }

        /// <summary>
        /// Request the number of access device of a particular device type and service provider.
        /// If countOnlyResetSupportedDevice is true, count only access devices if the device type supports reset.
        /// By default unmanaged device types are not allowed and devices are counted only if their device type supports Device Management.
        /// An error is returned if deviceType is specified but does not support device management.
        /// When allowUnmanagedDeviceType is true, unmanaged device type will be counted and a successful response is returned.
        /// The response is either ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderResponse> ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderRequestAsync(this OcipClient client, ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderResponse;
        }
        /// <summary>
        /// Cancel pending and in progress events.  A list of individual events can
        /// be canceled.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDeviceManagementInProgressAndPendingEventCancelRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDeviceManagementInProgressAndPendingEventCancelRequest(this OcipClient client, ServiceProviderDeviceManagementInProgressAndPendingEventCancelRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Cancel pending and in progress events.  A list of individual events can
        /// be canceled.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDeviceManagementInProgressAndPendingEventCancelRequestAsync(this OcipClient client, ServiceProviderDeviceManagementInProgressAndPendingEventCancelRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the service provider level device profile authentication password rule settings.
        /// The response is either a ServiceProviderDeviceProfileAuthenticationPasswordRulesGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDeviceProfileAuthenticationPasswordRulesGetRequestAsync instead.")]
        public static async Task<ServiceProviderDeviceProfileAuthenticationPasswordRulesGetResponse> ServiceProviderDeviceProfileAuthenticationPasswordRulesGetRequest(this OcipClient client, ServiceProviderDeviceProfileAuthenticationPasswordRulesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDeviceProfileAuthenticationPasswordRulesGetResponse;
        }

        /// <summary>
        /// Request to get the service provider level device profile authentication password rule settings.
        /// The response is either a ServiceProviderDeviceProfileAuthenticationPasswordRulesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDeviceProfileAuthenticationPasswordRulesGetResponse> ServiceProviderDeviceProfileAuthenticationPasswordRulesGetRequestAsync(this OcipClient client, ServiceProviderDeviceProfileAuthenticationPasswordRulesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDeviceProfileAuthenticationPasswordRulesGetResponse;
        }
        /// <summary>
        /// Request to modify the service provider level device profile authentication password rule settings. The useServiceProviderSettings element can only be modified by a system administrator or a provisioning administrator.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDeviceProfileAuthenticationPasswordRulesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDeviceProfileAuthenticationPasswordRulesModifyRequest(this OcipClient client, ServiceProviderDeviceProfileAuthenticationPasswordRulesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the service provider level device profile authentication password rule settings. The useServiceProviderSettings element can only be modified by a system administrator or a provisioning administrator.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDeviceProfileAuthenticationPasswordRulesModifyRequestAsync(this OcipClient client, ServiceProviderDeviceProfileAuthenticationPasswordRulesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a static configuration tag for an access device type used in a service provider.
        /// 
        /// The following elements are only used in XS data mode:
        /// isTagValueEncrypted, use value "false" in AS data mode
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The tagValueToEncrypt element can only be used by a system administrator.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDeviceTypeCustomTagAddRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDeviceTypeCustomTagAddRequest(this OcipClient client, ServiceProviderDeviceTypeCustomTagAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a static configuration tag for an access device type used in a service provider.
        /// 
        /// The following elements are only used in XS data mode:
        /// isTagValueEncrypted, use value "false" in AS data mode
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The tagValueToEncrypt element can only be used by a system administrator.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDeviceTypeCustomTagAddRequestAsync(this OcipClient client, ServiceProviderDeviceTypeCustomTagAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete static configuration tags for an access device type used in a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDeviceTypeCustomTagDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDeviceTypeCustomTagDeleteListRequest(this OcipClient client, ServiceProviderDeviceTypeCustomTagDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete static configuration tags for an access device type used in a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDeviceTypeCustomTagDeleteListRequestAsync(this OcipClient client, ServiceProviderDeviceTypeCustomTagDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of custom configuration tags managed by the Device Management System, on a per-device type basis for a service provider.
        /// The response is either ServiceProviderDeviceTypeCustomTagGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDeviceTypeCustomTagGetListRequestAsync instead.")]
        public static async Task<ServiceProviderDeviceTypeCustomTagGetListResponse> ServiceProviderDeviceTypeCustomTagGetListRequest(this OcipClient client, ServiceProviderDeviceTypeCustomTagGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDeviceTypeCustomTagGetListResponse;
        }

        /// <summary>
        /// Request to get the list of custom configuration tags managed by the Device Management System, on a per-device type basis for a service provider.
        /// The response is either ServiceProviderDeviceTypeCustomTagGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDeviceTypeCustomTagGetListResponse> ServiceProviderDeviceTypeCustomTagGetListRequestAsync(this OcipClient client, ServiceProviderDeviceTypeCustomTagGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDeviceTypeCustomTagGetListResponse;
        }
        /// <summary>
        /// Request to modify a static configuration tag for an access device type used in a service provider.
        /// 
        /// The tagValueToEncrypt element can only be used by a system administrator.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDeviceTypeCustomTagModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDeviceTypeCustomTagModifyRequest(this OcipClient client, ServiceProviderDeviceTypeCustomTagModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag for an access device type used in a service provider.
        /// 
        /// The tagValueToEncrypt element can only be used by a system administrator.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDeviceTypeCustomTagModifyRequestAsync(this OcipClient client, ServiceProviderDeviceTypeCustomTagModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of device type files managed by the Device Management System, on a per-service provider basis.
        /// The response is either ServiceProviderDeviceTypeFileGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDeviceTypeFileGetListRequestAsync instead.")]
        public static async Task<ServiceProviderDeviceTypeFileGetListResponse> ServiceProviderDeviceTypeFileGetListRequest(this OcipClient client, ServiceProviderDeviceTypeFileGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDeviceTypeFileGetListResponse;
        }

        /// <summary>
        /// Request to get the list of device type files managed by the Device Management System, on a per-service provider basis.
        /// The response is either ServiceProviderDeviceTypeFileGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDeviceTypeFileGetListResponse> ServiceProviderDeviceTypeFileGetListRequestAsync(this OcipClient client, ServiceProviderDeviceTypeFileGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDeviceTypeFileGetListResponse;
        }
        /// <summary>
        /// Request to get a service provider device type file.
        /// The response is either ServiceProviderDeviceTypeFileGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDeviceTypeFileGetRequestAsync instead.")]
        public static async Task<ServiceProviderDeviceTypeFileGetResponse> ServiceProviderDeviceTypeFileGetRequest(this OcipClient client, ServiceProviderDeviceTypeFileGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDeviceTypeFileGetResponse;
        }

        /// <summary>
        /// Request to get a service provider device type file.
        /// The response is either ServiceProviderDeviceTypeFileGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDeviceTypeFileGetResponse> ServiceProviderDeviceTypeFileGetRequestAsync(this OcipClient client, ServiceProviderDeviceTypeFileGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDeviceTypeFileGetResponse;
        }
        /// <summary>
        /// Request to modify a specified device type file for a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDeviceTypeFileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDeviceTypeFileModifyRequest(this OcipClient client, ServiceProviderDeviceTypeFileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a specified device type file for a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDeviceTypeFileModifyRequestAsync(this OcipClient client, ServiceProviderDeviceTypeFileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the custom configuration tag set defined for the service provider and device type.
        /// The response is either ServiceProviderDeviceTypeTagSetGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDeviceTypeTagSetGetRequestAsync instead.")]
        public static async Task<ServiceProviderDeviceTypeTagSetGetResponse> ServiceProviderDeviceTypeTagSetGetRequest(this OcipClient client, ServiceProviderDeviceTypeTagSetGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDeviceTypeTagSetGetResponse;
        }

        /// <summary>
        /// Request to get the custom configuration tag set defined for the service provider and device type.
        /// The response is either ServiceProviderDeviceTypeTagSetGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDeviceTypeTagSetGetResponse> ServiceProviderDeviceTypeTagSetGetRequestAsync(this OcipClient client, ServiceProviderDeviceTypeTagSetGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDeviceTypeTagSetGetResponse;
        }
        /// <summary>
        /// Request to modify a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDeviceTypeTagSetModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDeviceTypeTagSetModifyRequest(this OcipClient client, ServiceProviderDeviceTypeTagSetModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDeviceTypeTagSetModifyRequestAsync(this OcipClient client, ServiceProviderDeviceTypeTagSetModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Dialable Caller ID Criteria. Criteria are added at the bottom of the list with the lowest priority. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDialableCallerIDCriteriaAddRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDialableCallerIDCriteriaAddRequest(this OcipClient client, ServiceProviderDialableCallerIDCriteriaAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Dialable Caller ID Criteria. Criteria are added at the bottom of the list with the lowest priority. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDialableCallerIDCriteriaAddRequestAsync(this OcipClient client, ServiceProviderDialableCallerIDCriteriaAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Dialable Caller ID Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDialableCallerIDCriteriaDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDialableCallerIDCriteriaDeleteRequest(this OcipClient client, ServiceProviderDialableCallerIDCriteriaDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Dialable Caller ID Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDialableCallerIDCriteriaDeleteRequestAsync(this OcipClient client, ServiceProviderDialableCallerIDCriteriaDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get an existing Dialable Caller ID Criteria.
        /// The response is either a ServiceProviderDialableCallerIDCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDialableCallerIDCriteriaGetRequestAsync instead.")]
        public static async Task<ServiceProviderDialableCallerIDCriteriaGetResponse> ServiceProviderDialableCallerIDCriteriaGetRequest(this OcipClient client, ServiceProviderDialableCallerIDCriteriaGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDialableCallerIDCriteriaGetResponse;
        }

        /// <summary>
        /// Get an existing Dialable Caller ID Criteria.
        /// The response is either a ServiceProviderDialableCallerIDCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDialableCallerIDCriteriaGetResponse> ServiceProviderDialableCallerIDCriteriaGetRequestAsync(this OcipClient client, ServiceProviderDialableCallerIDCriteriaGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDialableCallerIDCriteriaGetResponse;
        }
        /// <summary>
        /// Modify a Dialable Caller ID Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDialableCallerIDCriteriaModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDialableCallerIDCriteriaModifyRequest(this OcipClient client, ServiceProviderDialableCallerIDCriteriaModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Dialable Caller ID Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDialableCallerIDCriteriaModifyRequestAsync(this OcipClient client, ServiceProviderDialableCallerIDCriteriaModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the service provider?s Dialable Caller ID settings and criteria list.
        /// The response is either a ServiceProviderDialableCallerIDGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDialableCallerIDGetRequestAsync instead.")]
        public static async Task<ServiceProviderDialableCallerIDGetResponse> ServiceProviderDialableCallerIDGetRequest(this OcipClient client, ServiceProviderDialableCallerIDGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDialableCallerIDGetResponse;
        }

        /// <summary>
        /// Get the service provider?s Dialable Caller ID settings and criteria list.
        /// The response is either a ServiceProviderDialableCallerIDGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDialableCallerIDGetResponse> ServiceProviderDialableCallerIDGetRequestAsync(this OcipClient client, ServiceProviderDialableCallerIDGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDialableCallerIDGetResponse;
        }
        /// <summary>
        /// Modify the service provider?s Dialable Caller ID settings and criteria list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDialableCallerIDModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDialableCallerIDModifyRequest(this OcipClient client, ServiceProviderDialableCallerIDModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the service provider?s Dialable Caller ID settings and criteria list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDialableCallerIDModifyRequestAsync(this OcipClient client, ServiceProviderDialableCallerIDModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a Service Provider level Dial Plan Access Code and its all attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDialPlanPolicyAddAccessCodeRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDialPlanPolicyAddAccessCodeRequest(this OcipClient client, ServiceProviderDialPlanPolicyAddAccessCodeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a Service Provider level Dial Plan Access Code and its all attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDialPlanPolicyAddAccessCodeRequestAsync(this OcipClient client, ServiceProviderDialPlanPolicyAddAccessCodeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a Service Provider level Dial Plan Access Code and its all attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDialPlanPolicyDeleteAccessCodeRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDialPlanPolicyDeleteAccessCodeRequest(this OcipClient client, ServiceProviderDialPlanPolicyDeleteAccessCodeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a Service Provider level Dial Plan Access Code and its all attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDialPlanPolicyDeleteAccessCodeRequestAsync(this OcipClient client, ServiceProviderDialPlanPolicyDeleteAccessCodeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the Service Provider level data associated with Dial Plan Policy.
        /// The response is either a ServiceProviderDialPlanPolicyGetAccessCodeListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDialPlanPolicyGetAccessCodeListRequestAsync instead.")]
        public static async Task<ServiceProviderDialPlanPolicyGetAccessCodeListResponse> ServiceProviderDialPlanPolicyGetAccessCodeListRequest(this OcipClient client, ServiceProviderDialPlanPolicyGetAccessCodeListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDialPlanPolicyGetAccessCodeListResponse;
        }

        /// <summary>
        /// Request the Service Provider level data associated with Dial Plan Policy.
        /// The response is either a ServiceProviderDialPlanPolicyGetAccessCodeListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDialPlanPolicyGetAccessCodeListResponse> ServiceProviderDialPlanPolicyGetAccessCodeListRequestAsync(this OcipClient client, ServiceProviderDialPlanPolicyGetAccessCodeListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDialPlanPolicyGetAccessCodeListResponse;
        }
        /// <summary>
        /// Request access code data associated with Service Provider level Dial Plan Policy access codes.
        /// The response is either a ServiceProviderDialPlanPolicyGetAccessCodeResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDialPlanPolicyGetAccessCodeRequestAsync instead.")]
        public static async Task<ServiceProviderDialPlanPolicyGetAccessCodeResponse> ServiceProviderDialPlanPolicyGetAccessCodeRequest(this OcipClient client, ServiceProviderDialPlanPolicyGetAccessCodeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDialPlanPolicyGetAccessCodeResponse;
        }

        /// <summary>
        /// Request access code data associated with Service Provider level Dial Plan Policy access codes.
        /// The response is either a ServiceProviderDialPlanPolicyGetAccessCodeResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDialPlanPolicyGetAccessCodeResponse> ServiceProviderDialPlanPolicyGetAccessCodeRequestAsync(this OcipClient client, ServiceProviderDialPlanPolicyGetAccessCodeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDialPlanPolicyGetAccessCodeResponse;
        }
        /// <summary>
        /// Request the Service Provider level data associated with Dial Plan Policy.
        /// The response is either a ServiceProviderDialPlanPolicyGetResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDialPlanPolicyGetRequest22Async instead.")]
        public static async Task<ServiceProviderDialPlanPolicyGetResponse22> ServiceProviderDialPlanPolicyGetRequest22(this OcipClient client, ServiceProviderDialPlanPolicyGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDialPlanPolicyGetResponse22;
        }

        /// <summary>
        /// Request the Service Provider level data associated with Dial Plan Policy.
        /// The response is either a ServiceProviderDialPlanPolicyGetResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDialPlanPolicyGetResponse22> ServiceProviderDialPlanPolicyGetRequest22Async(this OcipClient client, ServiceProviderDialPlanPolicyGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDialPlanPolicyGetResponse22;
        }
        /// <summary>
        /// Request to modify a Service Provider level Dial Plan Access Code and its attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDialPlanPolicyModifyAccessCodeRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDialPlanPolicyModifyAccessCodeRequest(this OcipClient client, ServiceProviderDialPlanPolicyModifyAccessCodeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Service Provider level Dial Plan Access Code and its attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDialPlanPolicyModifyAccessCodeRequestAsync(this OcipClient client, ServiceProviderDialPlanPolicyModifyAccessCodeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the Service Provider level data associated with Dial Plan Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// overrideResolvedDeviceDigitMap
        /// deviceDigitMap
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDialPlanPolicyModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDialPlanPolicyModifyRequest(this OcipClient client, ServiceProviderDialPlanPolicyModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Service Provider level data associated with Dial Plan Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// overrideResolvedDeviceDigitMap
        /// deviceDigitMap
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDialPlanPolicyModifyRequestAsync(this OcipClient client, ServiceProviderDialPlanPolicyModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the service provider's digit collection attributes.
        /// The response is either a ServiceProviderDigitCollectionGetResponse13mp4 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDigitCollectionGetRequest13mp4Async instead.")]
        public static async Task<ServiceProviderDigitCollectionGetResponse13mp4> ServiceProviderDigitCollectionGetRequest13mp4(this OcipClient client, ServiceProviderDigitCollectionGetRequest13mp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDigitCollectionGetResponse13mp4;
        }

        /// <summary>
        /// Request the service provider's digit collection attributes.
        /// The response is either a ServiceProviderDigitCollectionGetResponse13mp4 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDigitCollectionGetResponse13mp4> ServiceProviderDigitCollectionGetRequest13mp4Async(this OcipClient client, ServiceProviderDigitCollectionGetRequest13mp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDigitCollectionGetResponse13mp4;
        }
        /// <summary>
        /// Modifies the service provider's digit collection attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDigitCollectionModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDigitCollectionModifyRequest(this OcipClient client, ServiceProviderDigitCollectionModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the service provider's digit collection attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDigitCollectionModifyRequestAsync(this OcipClient client, ServiceProviderDigitCollectionModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Adds DNs to a service provider. It is possible to add either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDnAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDnAddListRequest(this OcipClient client, ServiceProviderDnAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Adds DNs to a service provider. It is possible to add either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDnAddListRequestAsync(this OcipClient client, ServiceProviderDnAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deletes DNs from a service provider. It is possible to delete either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDnDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDnDeleteListRequest(this OcipClient client, ServiceProviderDnDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deletes DNs from a service provider. It is possible to delete either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDnDeleteListRequestAsync(this OcipClient client, ServiceProviderDnDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a list of available DNs not yet assigned to any group.
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// The response is either ServiceProviderDnGetAvailableListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDnGetAvailableListRequestAsync instead.")]
        public static async Task<ServiceProviderDnGetAvailableListResponse> ServiceProviderDnGetAvailableListRequest(this OcipClient client, ServiceProviderDnGetAvailableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDnGetAvailableListResponse;
        }

        /// <summary>
        /// Request a list of available DNs not yet assigned to any group.
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// The response is either ServiceProviderDnGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDnGetAvailableListResponse> ServiceProviderDnGetAvailableListRequestAsync(this OcipClient client, ServiceProviderDnGetAvailableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDnGetAvailableListResponse;
        }
        /// <summary>
        /// Validates DNs given in the request
        /// The response is ServiceProviderDnGetStatusListResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDnGetStatusListRequestAsync instead.")]
        public static async Task<ServiceProviderDnGetStatusListResponse> ServiceProviderDnGetStatusListRequest(this OcipClient client, ServiceProviderDnGetStatusListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDnGetStatusListResponse;
        }

        /// <summary>
        /// Validates DNs given in the request
        /// The response is ServiceProviderDnGetStatusListResponse.
        /// </summary>
        public static async Task<ServiceProviderDnGetStatusListResponse> ServiceProviderDnGetStatusListRequestAsync(this OcipClient client, ServiceProviderDnGetStatusListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDnGetStatusListResponse;
        }
        /// <summary>
        /// Request a summary table of all DNs in a service provider.
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// The search can be done using multiple criteria. Only results matching all the search criteria are included in the results.
        /// The response is either ServiceProviderDnGetSummaryListResponse or ErrorResponse.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaDn, searchCriteriaGroupId
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDnGetSummaryListRequestAsync instead.")]
        public static async Task<ServiceProviderDnGetSummaryListResponse> ServiceProviderDnGetSummaryListRequest(this OcipClient client, ServiceProviderDnGetSummaryListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDnGetSummaryListResponse;
        }

        /// <summary>
        /// Request a summary table of all DNs in a service provider.
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// The search can be done using multiple criteria. Only results matching all the search criteria are included in the results.
        /// The response is either ServiceProviderDnGetSummaryListResponse or ErrorResponse.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaDn, searchCriteriaGroupId
        /// </summary>
        public static async Task<ServiceProviderDnGetSummaryListResponse> ServiceProviderDnGetSummaryListRequestAsync(this OcipClient client, ServiceProviderDnGetSummaryListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDnGetSummaryListResponse;
        }
        /// <summary>
        /// Assign a list of domains to a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDomainAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDomainAssignListRequest(this OcipClient client, ServiceProviderDomainAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of domains to a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDomainAssignListRequestAsync(this OcipClient client, ServiceProviderDomainAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a list of groups within a service provider that have a given domain assigned.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a ServiceProviderDomainGetAssignedGroupListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDomainGetAssignedGroupListRequestAsync instead.")]
        public static async Task<ServiceProviderDomainGetAssignedGroupListResponse> ServiceProviderDomainGetAssignedGroupListRequest(this OcipClient client, ServiceProviderDomainGetAssignedGroupListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDomainGetAssignedGroupListResponse;
        }

        /// <summary>
        /// Requests a list of groups within a service provider that have a given domain assigned.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a ServiceProviderDomainGetAssignedGroupListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDomainGetAssignedGroupListResponse> ServiceProviderDomainGetAssignedGroupListRequestAsync(this OcipClient client, ServiceProviderDomainGetAssignedGroupListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDomainGetAssignedGroupListResponse;
        }
        /// <summary>
        /// Requests the list of all matching domains assigned to a service provider .
        /// The response is either ServiceProviderDomainGetAssignedListResponse22 or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and will be ignored in XS data mode:
        /// responseSizeLimit
        /// searchCriteriaDomainName
        /// searchCriteriaExactDomainLevel
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDomainGetAssignedListRequest22Async instead.")]
        public static async Task<ServiceProviderDomainGetAssignedListResponse22> ServiceProviderDomainGetAssignedListRequest22(this OcipClient client, ServiceProviderDomainGetAssignedListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDomainGetAssignedListResponse22;
        }

        /// <summary>
        /// Requests the list of all matching domains assigned to a service provider .
        /// The response is either ServiceProviderDomainGetAssignedListResponse22 or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and will be ignored in XS data mode:
        /// responseSizeLimit
        /// searchCriteriaDomainName
        /// searchCriteriaExactDomainLevel
        /// </summary>
        public static async Task<ServiceProviderDomainGetAssignedListResponse22> ServiceProviderDomainGetAssignedListRequest22Async(this OcipClient client, ServiceProviderDomainGetAssignedListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDomainGetAssignedListResponse22;
        }
        /// <summary>
        /// Unassign a list of domains from a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDomainUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderDomainUnassignListRequest(this OcipClient client, ServiceProviderDomainUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of domains from a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDomainUnassignListRequestAsync(this OcipClient client, ServiceProviderDomainUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the service provider level data associated with Emergency Call Notification.
        /// The response is either a ServiceProviderEmergencyCallNotificationGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderEmergencyCallNotificationGetRequestAsync instead.")]
        public static async Task<ServiceProviderEmergencyCallNotificationGetResponse> ServiceProviderEmergencyCallNotificationGetRequest(this OcipClient client, ServiceProviderEmergencyCallNotificationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderEmergencyCallNotificationGetResponse;
        }

        /// <summary>
        /// Request the service provider level data associated with Emergency Call Notification.
        /// The response is either a ServiceProviderEmergencyCallNotificationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderEmergencyCallNotificationGetResponse> ServiceProviderEmergencyCallNotificationGetRequestAsync(this OcipClient client, ServiceProviderEmergencyCallNotificationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderEmergencyCallNotificationGetResponse;
        }
        /// <summary>
        /// Modify the service provider or enterprise level data associated with Emergency
        /// Call Notification.  The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderEmergencyCallNotificationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderEmergencyCallNotificationModifyRequest(this OcipClient client, ServiceProviderEmergencyCallNotificationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the service provider or enterprise level data associated with Emergency
        /// Call Notification.  The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderEmergencyCallNotificationModifyRequestAsync(this OcipClient client, ServiceProviderEmergencyCallNotificationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to search endpoints in the service provider/enterprise.
        /// The response is either ServiceProviderEndpointGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderEndpointGetListRequestAsync instead.")]
        public static async Task<ServiceProviderEndpointGetListResponse> ServiceProviderEndpointGetListRequest(this OcipClient client, ServiceProviderEndpointGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderEndpointGetListResponse;
        }

        /// <summary>
        /// Request to search endpoints in the service provider/enterprise.
        /// The response is either ServiceProviderEndpointGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderEndpointGetListResponse> ServiceProviderEndpointGetListRequestAsync(this OcipClient client, ServiceProviderEndpointGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderEndpointGetListResponse;
        }
        /// <summary>
        /// Request the service provider's extension length.
        /// The response is either a ServiceProviderExtensionLengthGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderExtensionLengthGetRequestAsync instead.")]
        public static async Task<ServiceProviderExtensionLengthGetResponse> ServiceProviderExtensionLengthGetRequest(this OcipClient client, ServiceProviderExtensionLengthGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderExtensionLengthGetResponse;
        }

        /// <summary>
        /// Request the service provider's extension length.
        /// The response is either a ServiceProviderExtensionLengthGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderExtensionLengthGetResponse> ServiceProviderExtensionLengthGetRequestAsync(this OcipClient client, ServiceProviderExtensionLengthGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderExtensionLengthGetResponse;
        }
        /// <summary>
        /// Modify the service provider's extension length range.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderExtensionLengthModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderExtensionLengthModifyRequest(this OcipClient client, ServiceProviderExtensionLengthModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the service provider's extension length range.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderExtensionLengthModifyRequestAsync(this OcipClient client, ServiceProviderExtensionLengthModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of feature access codes for a service provider or enterprise.
        /// The response is either a ServiceProviderFeatureAccessCodeGetListResponse21 or an ErrorResponse.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderFeatureAccessCodeGetListRequest21Async instead.")]
        public static async Task<ServiceProviderFeatureAccessCodeGetListResponse21> ServiceProviderFeatureAccessCodeGetListRequest21(this OcipClient client, ServiceProviderFeatureAccessCodeGetListRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderFeatureAccessCodeGetListResponse21;
        }

        /// <summary>
        /// Get the list of feature access codes for a service provider or enterprise.
        /// The response is either a ServiceProviderFeatureAccessCodeGetListResponse21 or an ErrorResponse.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// </summary>
        public static async Task<ServiceProviderFeatureAccessCodeGetListResponse21> ServiceProviderFeatureAccessCodeGetListRequest21Async(this OcipClient client, ServiceProviderFeatureAccessCodeGetListRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderFeatureAccessCodeGetListResponse21;
        }
        /// <summary>
        /// Modify a list of feature access codes for a service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderFeatureAccessCodeModifyListRequest21Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderFeatureAccessCodeModifyListRequest21(this OcipClient client, ServiceProviderFeatureAccessCodeModifyListRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a list of feature access codes for a service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderFeatureAccessCodeModifyListRequest21Async(this OcipClient client, ServiceProviderFeatureAccessCodeModifyListRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new service provider file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderFileRepositoryDeviceUserAddRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderFileRepositoryDeviceUserAddRequest(this OcipClient client, ServiceProviderFileRepositoryDeviceUserAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new service provider file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderFileRepositoryDeviceUserAddRequestAsync(this OcipClient client, ServiceProviderFileRepositoryDeviceUserAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a service provider file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderFileRepositoryDeviceUserDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderFileRepositoryDeviceUserDeleteRequest(this OcipClient client, ServiceProviderFileRepositoryDeviceUserDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a service provider file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderFileRepositoryDeviceUserDeleteRequestAsync(this OcipClient client, ServiceProviderFileRepositoryDeviceUserDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of service provider users for a file repository in the system.
        /// The response is either a ServiceProviderFileRepositoryDeviceUserGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderFileRepositoryDeviceUserGetListRequestAsync instead.")]
        public static async Task<ServiceProviderFileRepositoryDeviceUserGetListResponse> ServiceProviderFileRepositoryDeviceUserGetListRequest(this OcipClient client, ServiceProviderFileRepositoryDeviceUserGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderFileRepositoryDeviceUserGetListResponse;
        }

        /// <summary>
        /// Request the list of service provider users for a file repository in the system.
        /// The response is either a ServiceProviderFileRepositoryDeviceUserGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderFileRepositoryDeviceUserGetListResponse> ServiceProviderFileRepositoryDeviceUserGetListRequestAsync(this OcipClient client, ServiceProviderFileRepositoryDeviceUserGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderFileRepositoryDeviceUserGetListResponse;
        }
        /// <summary>
        /// Modify a service provider file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderFileRepositoryDeviceUserModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderFileRepositoryDeviceUserModifyRequest(this OcipClient client, ServiceProviderFileRepositoryDeviceUserModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a service provider file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderFileRepositoryDeviceUserModifyRequestAsync(this OcipClient client, ServiceProviderFileRepositoryDeviceUserModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of available leaf devices that can be linked to a tree device within a specific service provider.
        /// A leaf device is a device associated with a device type that has the option
        /// supportLinks set to "Support Link to Device". It can be linked to only one tree device.
        /// The list returned includes devices created at the system, service provider, and group levels.
        /// The response is either ServiceProviderGetAvailableLeafDeviceListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderGetAvailableLeafDeviceListRequestAsync instead.")]
        public static async Task<ServiceProviderGetAvailableLeafDeviceListResponse> ServiceProviderGetAvailableLeafDeviceListRequest(this OcipClient client, ServiceProviderGetAvailableLeafDeviceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderGetAvailableLeafDeviceListResponse;
        }

        /// <summary>
        /// Requests the list of available leaf devices that can be linked to a tree device within a specific service provider.
        /// A leaf device is a device associated with a device type that has the option
        /// supportLinks set to "Support Link to Device". It can be linked to only one tree device.
        /// The list returned includes devices created at the system, service provider, and group levels.
        /// The response is either ServiceProviderGetAvailableLeafDeviceListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderGetAvailableLeafDeviceListResponse> ServiceProviderGetAvailableLeafDeviceListRequestAsync(this OcipClient client, ServiceProviderGetAvailableLeafDeviceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderGetAvailableLeafDeviceListResponse;
        }
        /// <summary>
        /// Requests the list of available tree devices to which a leaf device can be linked to within a specific service provider.
        /// A tree device is a device associated with a device type that has the option
        /// supportLinks set to "Support Links from Devices". Many leaf devices can be linked to it.
        /// The list returned includes devices created at the system, service provider, and group levels.
        /// The response is either ServiceProviderGetAvailableTreeDeviceListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderGetAvailableTreeDeviceListRequestAsync instead.")]
        public static async Task<ServiceProviderGetAvailableTreeDeviceListResponse> ServiceProviderGetAvailableTreeDeviceListRequest(this OcipClient client, ServiceProviderGetAvailableTreeDeviceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderGetAvailableTreeDeviceListResponse;
        }

        /// <summary>
        /// Requests the list of available tree devices to which a leaf device can be linked to within a specific service provider.
        /// A tree device is a device associated with a device type that has the option
        /// supportLinks set to "Support Links from Devices". Many leaf devices can be linked to it.
        /// The list returned includes devices created at the system, service provider, and group levels.
        /// The response is either ServiceProviderGetAvailableTreeDeviceListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderGetAvailableTreeDeviceListResponse> ServiceProviderGetAvailableTreeDeviceListRequestAsync(this OcipClient client, ServiceProviderGetAvailableTreeDeviceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderGetAvailableTreeDeviceListResponse;
        }
        /// <summary>
        /// Request the default profile for a service provider or enterprise.
        /// The response is either a ServiceProviderGetDefaultResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderGetDefaultRequestAsync instead.")]
        public static async Task<ServiceProviderGetDefaultResponse> ServiceProviderGetDefaultRequest(this OcipClient client, ServiceProviderGetDefaultRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderGetDefaultResponse;
        }

        /// <summary>
        /// Request the default profile for a service provider or enterprise.
        /// The response is either a ServiceProviderGetDefaultResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderGetDefaultResponse> ServiceProviderGetDefaultRequestAsync(this OcipClient client, ServiceProviderGetDefaultRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderGetDefaultResponse;
        }
        /// <summary>
        /// Request a list of service providers and/or enterprises in the system.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. Service providers/enterprise
        /// within the administrator's reseller meeting the search criteria are returned.
        /// The response is either a ServiceProviderGetListResponse or an ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderGetListRequestAsync instead.")]
        public static async Task<ServiceProviderGetListResponse> ServiceProviderGetListRequest(this OcipClient client, ServiceProviderGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderGetListResponse;
        }

        /// <summary>
        /// Request a list of service providers and/or enterprises in the system.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. Service providers/enterprise
        /// within the administrator's reseller meeting the search criteria are returned.
        /// The response is either a ServiceProviderGetListResponse or an ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        public static async Task<ServiceProviderGetListResponse> ServiceProviderGetListRequestAsync(this OcipClient client, ServiceProviderGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderGetListResponse;
        }
        /// <summary>
        /// Request a list of service providers and/or enterprises in the system.
        /// The response is either a ServiceProviderGetPagedSortedListResponse or an ErrorResponse.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. Service providers/enterprise
        /// within the administrator's reseller meeting the search criteria are returned.
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1 by
        /// default, and the responsePageSize will be set to the maximum responsePageSize by default.
        /// If no sortOrder is included, the response is sorted by Service Provider Id ascending by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is
        /// included. Then the search criteria are logically ORed together.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderGetPagedSortedListRequestAsync instead.")]
        public static async Task<ServiceProviderGetPagedSortedListResponse> ServiceProviderGetPagedSortedListRequest(this OcipClient client, ServiceProviderGetPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderGetPagedSortedListResponse;
        }

        /// <summary>
        /// Request a list of service providers and/or enterprises in the system.
        /// The response is either a ServiceProviderGetPagedSortedListResponse or an ErrorResponse.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. Service providers/enterprise
        /// within the administrator's reseller meeting the search criteria are returned.
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1 by
        /// default, and the responsePageSize will be set to the maximum responsePageSize by default.
        /// If no sortOrder is included, the response is sorted by Service Provider Id ascending by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is
        /// included. Then the search criteria are logically ORed together.
        /// </summary>
        public static async Task<ServiceProviderGetPagedSortedListResponse> ServiceProviderGetPagedSortedListRequestAsync(this OcipClient client, ServiceProviderGetPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderGetPagedSortedListResponse;
        }
        /// <summary>
        /// Get the profile for a service provider or enterprise.
        /// The response is either a ServiceProviderGetResponse22V4 or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// serviceProviderExtenalId
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderGetRequest22V4Async instead.")]
        public static async Task<ServiceProviderGetResponse22V4> ServiceProviderGetRequest22V4(this OcipClient client, ServiceProviderGetRequest22V4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderGetResponse22V4;
        }

        /// <summary>
        /// Get the profile for a service provider or enterprise.
        /// The response is either a ServiceProviderGetResponse22V4 or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// serviceProviderExtenalId
        /// </summary>
        public static async Task<ServiceProviderGetResponse22V4> ServiceProviderGetRequest22V4Async(this OcipClient client, ServiceProviderGetRequest22V4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderGetResponse22V4;
        }
        /// <summary>
        /// Request to get the Alternate Carrier Selection parameters.
        /// The response is either a ServiceProviderHPBXAlternateCarrierSelectionGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderHPBXAlternateCarrierSelectionGetRequestAsync instead.")]
        public static async Task<ServiceProviderHPBXAlternateCarrierSelectionGetResponse> ServiceProviderHPBXAlternateCarrierSelectionGetRequest(this OcipClient client, ServiceProviderHPBXAlternateCarrierSelectionGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderHPBXAlternateCarrierSelectionGetResponse;
        }

        /// <summary>
        /// Request to get the Alternate Carrier Selection parameters.
        /// The response is either a ServiceProviderHPBXAlternateCarrierSelectionGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderHPBXAlternateCarrierSelectionGetResponse> ServiceProviderHPBXAlternateCarrierSelectionGetRequestAsync(this OcipClient client, ServiceProviderHPBXAlternateCarrierSelectionGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderHPBXAlternateCarrierSelectionGetResponse;
        }
        /// <summary>
        /// Request to modify the Alternate Carrier Selection parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderHPBXAlternateCarrierSelectionModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderHPBXAlternateCarrierSelectionModifyRequest(this OcipClient client, ServiceProviderHPBXAlternateCarrierSelectionModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the Alternate Carrier Selection parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderHPBXAlternateCarrierSelectionModifyRequestAsync(this OcipClient client, ServiceProviderHPBXAlternateCarrierSelectionModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a list of service provider DNs to the IMRN pool. It is possible to assign either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderIMRNAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderIMRNAssignListRequest(this OcipClient client, ServiceProviderIMRNAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of service provider DNs to the IMRN pool. It is possible to assign either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderIMRNAssignListRequestAsync(this OcipClient client, ServiceProviderIMRNAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Returns a list of dns or dn ranges in a service provider IMRN pool. The response is either ServiceProviderIMRNGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderIMRNGetListRequestAsync instead.")]
        public static async Task<ServiceProviderIMRNGetListResponse> ServiceProviderIMRNGetListRequest(this OcipClient client, ServiceProviderIMRNGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderIMRNGetListResponse;
        }

        /// <summary>
        /// Returns a list of dns or dn ranges in a service provider IMRN pool. The response is either ServiceProviderIMRNGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderIMRNGetListResponse> ServiceProviderIMRNGetListRequestAsync(this OcipClient client, ServiceProviderIMRNGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderIMRNGetListResponse;
        }
        /// <summary>
        /// Unassign a list of service provider DNs from the service provider IMRN pool. The DNs then become available for
        /// assignment to groups. It is possible to delete either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderIMRNUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderIMRNUnassignListRequest(this OcipClient client, ServiceProviderIMRNUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of service provider DNs from the service provider IMRN pool. The DNs then become available for
        /// assignment to groups. It is possible to delete either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderIMRNUnassignListRequestAsync(this OcipClient client, ServiceProviderIMRNUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a language for a service provder.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderLanguageAddRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderLanguageAddRequest(this OcipClient client, ServiceProviderLanguageAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a language for a service provder.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderLanguageAddRequestAsync(this OcipClient client, ServiceProviderLanguageAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a language from a service provider supported languages.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderLanguageDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderLanguageDeleteRequest(this OcipClient client, ServiceProviderLanguageDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a language from a service provider supported languages.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderLanguageDeleteRequestAsync(this OcipClient client, ServiceProviderLanguageDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of languages that a user or admin in a service provider is allowed to use.
        /// The list will either be the system or service provider languages list, depending on the useServiceProviderLanguages flag.
        /// The response is either a ServiceProviderLanguageGetAvailableListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderLanguageGetAvailableListRequestAsync instead.")]
        public static async Task<ServiceProviderLanguageGetAvailableListResponse> ServiceProviderLanguageGetAvailableListRequest(this OcipClient client, ServiceProviderLanguageGetAvailableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderLanguageGetAvailableListResponse;
        }

        /// <summary>
        /// Request the list of languages that a user or admin in a service provider is allowed to use.
        /// The list will either be the system or service provider languages list, depending on the useServiceProviderLanguages flag.
        /// The response is either a ServiceProviderLanguageGetAvailableListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderLanguageGetAvailableListResponse> ServiceProviderLanguageGetAvailableListRequestAsync(this OcipClient client, ServiceProviderLanguageGetAvailableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderLanguageGetAvailableListResponse;
        }
        /// <summary>
        /// Request the defined languages for a service provider.
        /// The response is either a ServiceProviderLanguageGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderLanguageGetListRequestAsync instead.")]
        public static async Task<ServiceProviderLanguageGetListResponse> ServiceProviderLanguageGetListRequest(this OcipClient client, ServiceProviderLanguageGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderLanguageGetListResponse;
        }

        /// <summary>
        /// Request the defined languages for a service provider.
        /// The response is either a ServiceProviderLanguageGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderLanguageGetListResponse> ServiceProviderLanguageGetListRequestAsync(this OcipClient client, ServiceProviderLanguageGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderLanguageGetListResponse;
        }
        /// <summary>
        /// Request to modify a language properties for a service provider/enterprise.
        /// If the becomeDefaultLanguage element is present, the language in this request
        /// Becomes the default language for the service provider/enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderLanguageModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderLanguageModifyRequest(this OcipClient client, ServiceProviderLanguageModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a language properties for a service provider/enterprise.
        /// If the becomeDefaultLanguage element is present, the language in this request
        /// Becomes the default language for the service provider/enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderLanguageModifyRequestAsync(this OcipClient client, ServiceProviderLanguageModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the profile for a service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in Amplify data mode and ignored
        /// in AS and XS data mode:
        /// servicePolicy,
        /// callProcessingSliceId,
        /// provisioningSliceId,
        /// subscriberPartition.
        /// When the callProcessingSliceId or provisioningSliceId is set to nillable,
        /// it will be assigned to the default Slice.
        /// Only Provisioning admin and above can change the callProcessingSliceId,
        /// provisioningSliceId, and subscriberPartition.
        /// 
        /// The following element is only used in AS data mode and ignored
        /// in Amplify and XS data mode:
        /// resellerId
        /// resellerName
        /// 
        /// resellerId and resellerName can only be configured by a Reseller or higher level administrator.
        /// 
        /// The following behavior is only applicable in CloudPBX:
        /// - when existing resellerId is specified, enterprise/Service Provider shall be moved to
        /// requesting reseller.
        /// - when new resellerId, that does not exist in the system, is specified, the new
        /// Reseller is created the given resellerId and resellerName (if provided) and 	enterprise/Service Provider is moved to the newly created Reseller.
        /// 
        /// resellerName element is ignored if the reseller the service provider is being moved to 	already exists.
        /// 
        /// 
        /// The following elements are only used in Amplify and XS data mode and ignored in AS data mode:
        /// preferredDataCenter.
        /// Only Provisioning admin and above can change the preferredDataCenter.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// defaultExtensionLength
        /// locationRoutingPrefixDigit
        /// locationCodeLength
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderModifyRequest(this OcipClient client, ServiceProviderModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the profile for a service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in Amplify data mode and ignored
        /// in AS and XS data mode:
        /// servicePolicy,
        /// callProcessingSliceId,
        /// provisioningSliceId,
        /// subscriberPartition.
        /// When the callProcessingSliceId or provisioningSliceId is set to nillable,
        /// it will be assigned to the default Slice.
        /// Only Provisioning admin and above can change the callProcessingSliceId,
        /// provisioningSliceId, and subscriberPartition.
        /// 
        /// The following element is only used in AS data mode and ignored
        /// in Amplify and XS data mode:
        /// resellerId
        /// resellerName
        /// 
        /// resellerId and resellerName can only be configured by a Reseller or higher level administrator.
        /// 
        /// The following behavior is only applicable in CloudPBX:
        /// - when existing resellerId is specified, enterprise/Service Provider shall be moved to
        /// requesting reseller.
        /// - when new resellerId, that does not exist in the system, is specified, the new
        /// Reseller is created the given resellerId and resellerName (if provided) and 	enterprise/Service Provider is moved to the newly created Reseller.
        /// 
        /// resellerName element is ignored if the reseller the service provider is being moved to 	already exists.
        /// 
        /// 
        /// The following elements are only used in Amplify and XS data mode and ignored in AS data mode:
        /// preferredDataCenter.
        /// Only Provisioning admin and above can change the preferredDataCenter.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// defaultExtensionLength
        /// locationRoutingPrefixDigit
        /// locationCodeLength
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderModifyRequestAsync(this OcipClient client, ServiceProviderModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a list of Network Classes of Service to a service provider.
        /// A default Network Class of Service must be specified unless
        /// there is already one assigned to the service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderNetworkClassOfServiceAssignListRequest21Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceAssignListRequest21(this OcipClient client, ServiceProviderNetworkClassOfServiceAssignListRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Network Classes of Service to a service provider.
        /// A default Network Class of Service must be specified unless
        /// there is already one assigned to the service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceAssignListRequest21Async(this OcipClient client, ServiceProviderNetworkClassOfServiceAssignListRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a list of Network Classes of Service to all groups with in a
        /// service provider. If it is the first assigned Network Class of Service in
        /// the group, it will be set as the default one.
        /// The Network Classes of Service must be currently
        /// assigned to the service provider. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderNetworkClassOfServiceAssignListToAllGroupsRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceAssignListToAllGroupsRequest(this OcipClient client, ServiceProviderNetworkClassOfServiceAssignListToAllGroupsRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Network Classes of Service to all groups with in a
        /// service provider. If it is the first assigned Network Class of Service in
        /// the group, it will be set as the default one.
        /// The Network Classes of Service must be currently
        /// assigned to the service provider. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceAssignListToAllGroupsRequestAsync(this OcipClient client, ServiceProviderNetworkClassOfServiceAssignListToAllGroupsRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a Network Classes of Service to all users with in a
        /// service provider. This will also assign the Network Class of Service
        /// to all the groups in the service provider if it is not assigned yet.
        /// If it is the first assigned Network Class of Service in the group,
        /// it will be set as the default one.
        /// However, the Network Classes of Service must be currently assigned to
        /// the service provider. The response is either a SuccessResponse or
        /// an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderNetworkClassOfServiceAssignToAllUsersRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceAssignToAllUsersRequest(this OcipClient client, ServiceProviderNetworkClassOfServiceAssignToAllUsersRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a Network Classes of Service to all users with in a
        /// service provider. This will also assign the Network Class of Service
        /// to all the groups in the service provider if it is not assigned yet.
        /// If it is the first assigned Network Class of Service in the group,
        /// it will be set as the default one.
        /// However, the Network Classes of Service must be currently assigned to
        /// the service provider. The response is either a SuccessResponse or
        /// an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceAssignToAllUsersRequestAsync(this OcipClient client, ServiceProviderNetworkClassOfServiceAssignToAllUsersRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of groups within a service provider that have a given
        /// Network Class of Service assigned.
        /// The response is either a ServiceProviderNetworkClassOfServiceGetAssignedGroupListResponse
        /// or an ErorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderNetworkClassOfServiceGetAssignedGroupListRequestAsync instead.")]
        public static async Task<ServiceProviderNetworkClassOfServiceGetAssignedGroupListResponse> ServiceProviderNetworkClassOfServiceGetAssignedGroupListRequest(this OcipClient client, ServiceProviderNetworkClassOfServiceGetAssignedGroupListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderNetworkClassOfServiceGetAssignedGroupListResponse;
        }

        /// <summary>
        /// Get a list of groups within a service provider that have a given
        /// Network Class of Service assigned.
        /// The response is either a ServiceProviderNetworkClassOfServiceGetAssignedGroupListResponse
        /// or an ErorResponse.
        /// </summary>
        public static async Task<ServiceProviderNetworkClassOfServiceGetAssignedGroupListResponse> ServiceProviderNetworkClassOfServiceGetAssignedGroupListRequestAsync(this OcipClient client, ServiceProviderNetworkClassOfServiceGetAssignedGroupListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderNetworkClassOfServiceGetAssignedGroupListResponse;
        }
        /// <summary>
        /// Get a list of Network Classes of Service assigned to a service provider.
        /// The response is either a ServiceProviderNetworkClassOfServiceGetAssignedListResponse
        /// or an ErorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderNetworkClassOfServiceGetAssignedListRequestAsync instead.")]
        public static async Task<ServiceProviderNetworkClassOfServiceGetAssignedListResponse> ServiceProviderNetworkClassOfServiceGetAssignedListRequest(this OcipClient client, ServiceProviderNetworkClassOfServiceGetAssignedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderNetworkClassOfServiceGetAssignedListResponse;
        }

        /// <summary>
        /// Get a list of Network Classes of Service assigned to a service provider.
        /// The response is either a ServiceProviderNetworkClassOfServiceGetAssignedListResponse
        /// or an ErorResponse.
        /// </summary>
        public static async Task<ServiceProviderNetworkClassOfServiceGetAssignedListResponse> ServiceProviderNetworkClassOfServiceGetAssignedListRequestAsync(this OcipClient client, ServiceProviderNetworkClassOfServiceGetAssignedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderNetworkClassOfServiceGetAssignedListResponse;
        }
        /// <summary>
        /// Modifies the default Network Classes of Service of a Service Provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderNetworkClassOfServiceModifyDefaultRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceModifyDefaultRequest(this OcipClient client, ServiceProviderNetworkClassOfServiceModifyDefaultRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the default Network Classes of Service of a Service Provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceModifyDefaultRequestAsync(this OcipClient client, ServiceProviderNetworkClassOfServiceModifyDefaultRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Unassign a list of Network Classes of Service from a service provider.
        /// If the default Network Class of Service is being unassigned, a new one must be specified unless there are no more
        /// Network Classes of Service assigned to the service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderNetworkClassOfServiceUnassignListRequest21Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceUnassignListRequest21(this OcipClient client, ServiceProviderNetworkClassOfServiceUnassignListRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of Network Classes of Service from a service provider.
        /// If the default Network Class of Service is being unassigned, a new one must be specified unless there are no more
        /// Network Classes of Service assigned to the service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceUnassignListRequest21Async(this OcipClient client, ServiceProviderNetworkClassOfServiceUnassignListRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a list of the Service Provider Number Portability Query Digit Patterns.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderNumberPortabilityQueryAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderNumberPortabilityQueryAddListRequest(this OcipClient client, ServiceProviderNumberPortabilityQueryAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of the Service Provider Number Portability Query Digit Patterns.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderNumberPortabilityQueryAddListRequestAsync(this OcipClient client, ServiceProviderNumberPortabilityQueryAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the Service Provider Number Portability Query Digit Pattern Trigger List information.
        /// The response is either a ServiceProviderNumberPortabilityQueryGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderNumberPortabilityQueryGetRequestAsync instead.")]
        public static async Task<ServiceProviderNumberPortabilityQueryGetResponse> ServiceProviderNumberPortabilityQueryGetRequest(this OcipClient client, ServiceProviderNumberPortabilityQueryGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderNumberPortabilityQueryGetResponse;
        }

        /// <summary>
        /// Request to get the Service Provider Number Portability Query Digit Pattern Trigger List information.
        /// The response is either a ServiceProviderNumberPortabilityQueryGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderNumberPortabilityQueryGetResponse> ServiceProviderNumberPortabilityQueryGetRequestAsync(this OcipClient client, ServiceProviderNumberPortabilityQueryGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderNumberPortabilityQueryGetResponse;
        }
        /// <summary>
        /// Modify the Service Provider Number Portability Query information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderNumberPortabilityQueryModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderNumberPortabilityQueryModifyRequest(this OcipClient client, ServiceProviderNumberPortabilityQueryModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Service Provider Number Portability Query information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderNumberPortabilityQueryModifyRequestAsync(this OcipClient client, ServiceProviderNumberPortabilityQueryModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a list of Office Zones to a service provider.
        /// The Element defaultOfficeZone is required only for the first assignment, for subsequent assignments it is optional.
        /// Office Zones can only be assigned if the Location-Based Calling Restrictions has been authorized to the service provider otherwise the request will fail.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderOfficeZoneAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderOfficeZoneAssignListRequest(this OcipClient client, ServiceProviderOfficeZoneAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Office Zones to a service provider.
        /// The Element defaultOfficeZone is required only for the first assignment, for subsequent assignments it is optional.
        /// Office Zones can only be assigned if the Location-Based Calling Restrictions has been authorized to the service provider otherwise the request will fail.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderOfficeZoneAssignListRequestAsync(this OcipClient client, ServiceProviderOfficeZoneAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of groups within a service provider that have a given Office Zone assigned.
        /// The response is either a ServiceProviderOfficeZoneGetAssignedGroupListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderOfficeZoneGetAssignedGroupListRequestAsync instead.")]
        public static async Task<ServiceProviderOfficeZoneGetAssignedGroupListResponse> ServiceProviderOfficeZoneGetAssignedGroupListRequest(this OcipClient client, ServiceProviderOfficeZoneGetAssignedGroupListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderOfficeZoneGetAssignedGroupListResponse;
        }

        /// <summary>
        /// Get a list of groups within a service provider that have a given Office Zone assigned.
        /// The response is either a ServiceProviderOfficeZoneGetAssignedGroupListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderOfficeZoneGetAssignedGroupListResponse> ServiceProviderOfficeZoneGetAssignedGroupListRequestAsync(this OcipClient client, ServiceProviderOfficeZoneGetAssignedGroupListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderOfficeZoneGetAssignedGroupListResponse;
        }
        /// <summary>
        /// Get a list of Office Zones assigned to a service provider.
        /// The response is either a ServiceProviderOfficeZoneGetAssignedListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderOfficeZoneGetAssignedListRequestAsync instead.")]
        public static async Task<ServiceProviderOfficeZoneGetAssignedListResponse> ServiceProviderOfficeZoneGetAssignedListRequest(this OcipClient client, ServiceProviderOfficeZoneGetAssignedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderOfficeZoneGetAssignedListResponse;
        }

        /// <summary>
        /// Get a list of Office Zones assigned to a service provider.
        /// The response is either a ServiceProviderOfficeZoneGetAssignedListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderOfficeZoneGetAssignedListResponse> ServiceProviderOfficeZoneGetAssignedListRequestAsync(this OcipClient client, ServiceProviderOfficeZoneGetAssignedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderOfficeZoneGetAssignedListResponse;
        }
        /// <summary>
        /// Unassign a list of OfficeZones from a service provider.  Note: a new default must be provided if unassigning the current default.
        /// Office Zones can only be unassigned if the Location-Based Calling Restrictions has been authorized to the service provider otherwise the request will fail.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderOfficeZoneUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderOfficeZoneUnassignListRequest(this OcipClient client, ServiceProviderOfficeZoneUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of OfficeZones from a service provider.  Note: a new default must be provided if unassigning the current default.
        /// Office Zones can only be unassigned if the Location-Based Calling Restrictions has been authorized to the service provider otherwise the request will fail.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderOfficeZoneUnassignListRequestAsync(this OcipClient client, ServiceProviderOfficeZoneUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the service provider's password rules setting applicable to
        /// Administrators (Group and Department) and Users.
        /// The response is either ServiceProviderPasswordRulesGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderPasswordRulesGetRequest22Async instead.")]
        public static async Task<ServiceProviderPasswordRulesGetResponse22> ServiceProviderPasswordRulesGetRequest22(this OcipClient client, ServiceProviderPasswordRulesGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderPasswordRulesGetResponse22;
        }

        /// <summary>
        /// Requests the service provider's password rules setting applicable to
        /// Administrators (Group and Department) and Users.
        /// The response is either ServiceProviderPasswordRulesGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderPasswordRulesGetResponse22> ServiceProviderPasswordRulesGetRequest22Async(this OcipClient client, ServiceProviderPasswordRulesGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderPasswordRulesGetResponse22;
        }
        /// <summary>
        /// Request to modify the service provider's password rules settings
        /// setting applicable to Administrators (Group and Department) and Users.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// forcePasswordChangeAfterReset
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderPasswordRulesModifyRequest14sp3Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderPasswordRulesModifyRequest14sp3(this OcipClient client, ServiceProviderPasswordRulesModifyRequest14sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the service provider's password rules settings
        /// setting applicable to Administrators (Group and Department) and Users.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// forcePasswordChangeAfterReset
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderPasswordRulesModifyRequest14sp3Async(this OcipClient client, ServiceProviderPasswordRulesModifyRequest14sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the service provider's passcode rules setting.
        /// The response is either ServiceProviderPortalPasscodeRulesGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderPortalPasscodeRulesGetRequest22Async instead.")]
        public static async Task<ServiceProviderPortalPasscodeRulesGetResponse22> ServiceProviderPortalPasscodeRulesGetRequest22(this OcipClient client, ServiceProviderPortalPasscodeRulesGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderPortalPasscodeRulesGetResponse22;
        }

        /// <summary>
        /// Requests the service provider's passcode rules setting.
        /// The response is either ServiceProviderPortalPasscodeRulesGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderPortalPasscodeRulesGetResponse22> ServiceProviderPortalPasscodeRulesGetRequest22Async(this OcipClient client, ServiceProviderPortalPasscodeRulesGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderPortalPasscodeRulesGetResponse22;
        }
        /// <summary>
        /// Request to modify the service provider's passcode rules setting.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// numberOfRepeatedDigits
        /// disallowRepeatedPatterns
        /// disallowContiguousSequences
        /// numberOfAscendingDigits
        /// numberOfDescendingDigits
        /// numberOfPreviousPasscodes
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// enableDefaultPasscode
        /// defaultPasscode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderPortalPasscodeRulesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderPortalPasscodeRulesModifyRequest(this OcipClient client, ServiceProviderPortalPasscodeRulesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the service provider's passcode rules setting.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// numberOfRepeatedDigits
        /// disallowRepeatedPatterns
        /// disallowContiguousSequences
        /// numberOfAscendingDigits
        /// numberOfDescendingDigits
        /// numberOfPreviousPasscodes
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// enableDefaultPasscode
        /// defaultPasscode
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderPortalPasscodeRulesModifyRequestAsync(this OcipClient client, ServiceProviderPortalPasscodeRulesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a list of route point external systems to a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRoutePointExternalSystemAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderRoutePointExternalSystemAssignListRequest(this OcipClient client, ServiceProviderRoutePointExternalSystemAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of route point external systems to a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRoutePointExternalSystemAssignListRequestAsync(this OcipClient client, ServiceProviderRoutePointExternalSystemAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a list of groups within a service provider that have a given external system assigned.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a ServiceProviderRoutePointExternalSystemGetAssignedGroupListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRoutePointExternalSystemGetAssignedGroupListRequestAsync instead.")]
        public static async Task<ServiceProviderRoutePointExternalSystemGetAssignedGroupListResponse> ServiceProviderRoutePointExternalSystemGetAssignedGroupListRequest(this OcipClient client, ServiceProviderRoutePointExternalSystemGetAssignedGroupListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderRoutePointExternalSystemGetAssignedGroupListResponse;
        }

        /// <summary>
        /// Requests a list of groups within a service provider that have a given external system assigned.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a ServiceProviderRoutePointExternalSystemGetAssignedGroupListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderRoutePointExternalSystemGetAssignedGroupListResponse> ServiceProviderRoutePointExternalSystemGetAssignedGroupListRequestAsync(this OcipClient client, ServiceProviderRoutePointExternalSystemGetAssignedGroupListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderRoutePointExternalSystemGetAssignedGroupListResponse;
        }
        /// <summary>
        /// Requests the list of all Route Point External Systems assigned to a service provider.
        /// The response is either ServiceProviderRoutePointExternalSystemGetAssignedListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRoutePointExternalSystemGetAssignedListRequestAsync instead.")]
        public static async Task<ServiceProviderRoutePointExternalSystemGetAssignedListResponse> ServiceProviderRoutePointExternalSystemGetAssignedListRequest(this OcipClient client, ServiceProviderRoutePointExternalSystemGetAssignedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderRoutePointExternalSystemGetAssignedListResponse;
        }

        /// <summary>
        /// Requests the list of all Route Point External Systems assigned to a service provider.
        /// The response is either ServiceProviderRoutePointExternalSystemGetAssignedListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderRoutePointExternalSystemGetAssignedListResponse> ServiceProviderRoutePointExternalSystemGetAssignedListRequestAsync(this OcipClient client, ServiceProviderRoutePointExternalSystemGetAssignedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderRoutePointExternalSystemGetAssignedListResponse;
        }
        /// <summary>
        /// Unassign a list of route point external systems from a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRoutePointExternalSystemUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderRoutePointExternalSystemUnassignListRequest(this OcipClient client, ServiceProviderRoutePointExternalSystemUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of route point external systems from a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRoutePointExternalSystemUnassignListRequestAsync(this OcipClient client, ServiceProviderRoutePointExternalSystemUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the routing profile for the service provider/enterprise.
        /// The response is either a ServiceProviderRoutingProfileGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRoutingProfileGetRequestAsync instead.")]
        public static async Task<ServiceProviderRoutingProfileGetResponse> ServiceProviderRoutingProfileGetRequest(this OcipClient client, ServiceProviderRoutingProfileGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderRoutingProfileGetResponse;
        }

        /// <summary>
        /// Request the routing profile for the service provider/enterprise.
        /// The response is either a ServiceProviderRoutingProfileGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderRoutingProfileGetResponse> ServiceProviderRoutingProfileGetRequestAsync(this OcipClient client, ServiceProviderRoutingProfileGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderRoutingProfileGetResponse;
        }
        /// <summary>
        /// Requests to modify the routing profile for a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRoutingProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderRoutingProfileModifyRequest(this OcipClient client, ServiceProviderRoutingProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Requests to modify the routing profile for a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRoutingProfileModifyRequestAsync(this OcipClient client, ServiceProviderRoutingProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an event to service provider schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderScheduleAddEventRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderScheduleAddEventRequest(this OcipClient client, ServiceProviderScheduleAddEventRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an event to service provider schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderScheduleAddEventRequestAsync(this OcipClient client, ServiceProviderScheduleAddEventRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a service provider schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderScheduleAddRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderScheduleAddRequest(this OcipClient client, ServiceProviderScheduleAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a service provider schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderScheduleAddRequestAsync(this OcipClient client, ServiceProviderScheduleAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of events from a service provider schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderScheduleDeleteEventListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderScheduleDeleteEventListRequest(this OcipClient client, ServiceProviderScheduleDeleteEventListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of events from a service provider schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderScheduleDeleteEventListRequestAsync(this OcipClient client, ServiceProviderScheduleDeleteEventListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of service provider schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderScheduleDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderScheduleDeleteListRequest(this OcipClient client, ServiceProviderScheduleDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of service provider schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderScheduleDeleteListRequestAsync(this OcipClient client, ServiceProviderScheduleDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of events of a service provider schedule.
        /// The response is either a ServiceProviderScheduleGetEventDetailListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderScheduleGetEventDetailListRequestAsync instead.")]
        public static async Task<ServiceProviderScheduleGetEventDetailListResponse> ServiceProviderScheduleGetEventDetailListRequest(this OcipClient client, ServiceProviderScheduleGetEventDetailListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderScheduleGetEventDetailListResponse;
        }

        /// <summary>
        /// Get the list of events of a service provider schedule.
        /// The response is either a ServiceProviderScheduleGetEventDetailListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderScheduleGetEventDetailListResponse> ServiceProviderScheduleGetEventDetailListRequestAsync(this OcipClient client, ServiceProviderScheduleGetEventDetailListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderScheduleGetEventDetailListResponse;
        }
        /// <summary>
        /// Get the list of events of a service provider schedule.
        /// The response is either a ServiceProviderScheduleGetEventListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderScheduleGetEventListRequestAsync instead.")]
        public static async Task<ServiceProviderScheduleGetEventListResponse> ServiceProviderScheduleGetEventListRequest(this OcipClient client, ServiceProviderScheduleGetEventListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderScheduleGetEventListResponse;
        }

        /// <summary>
        /// Get the list of events of a service provider schedule.
        /// The response is either a ServiceProviderScheduleGetEventListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderScheduleGetEventListResponse> ServiceProviderScheduleGetEventListRequestAsync(this OcipClient client, ServiceProviderScheduleGetEventListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderScheduleGetEventListResponse;
        }
        /// <summary>
        /// Get an event from a service provider schedule.
        /// The response is either a ServiceProviderScheduleGetEventResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderScheduleGetEventRequestAsync instead.")]
        public static async Task<ServiceProviderScheduleGetEventResponse> ServiceProviderScheduleGetEventRequest(this OcipClient client, ServiceProviderScheduleGetEventRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderScheduleGetEventResponse;
        }

        /// <summary>
        /// Get an event from a service provider schedule.
        /// The response is either a ServiceProviderScheduleGetEventResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderScheduleGetEventResponse> ServiceProviderScheduleGetEventRequestAsync(this OcipClient client, ServiceProviderScheduleGetEventRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderScheduleGetEventResponse;
        }
        /// <summary>
        /// Get the list of a service provider schedules. The list can be filtered by schedule type.
        /// The response is either a ServiceProviderScheduleGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderScheduleGetListRequestAsync instead.")]
        public static async Task<ServiceProviderScheduleGetListResponse> ServiceProviderScheduleGetListRequest(this OcipClient client, ServiceProviderScheduleGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderScheduleGetListResponse;
        }

        /// <summary>
        /// Get the list of a service provider schedules. The list can be filtered by schedule type.
        /// The response is either a ServiceProviderScheduleGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderScheduleGetListResponse> ServiceProviderScheduleGetListRequestAsync(this OcipClient client, ServiceProviderScheduleGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderScheduleGetListResponse;
        }
        /// <summary>
        /// Modify an event of a service provider schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderScheduleModifyEventRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderScheduleModifyEventRequest(this OcipClient client, ServiceProviderScheduleModifyEventRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an event of a service provider schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderScheduleModifyEventRequestAsync(this OcipClient client, ServiceProviderScheduleModifyEventRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a service provider schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderScheduleModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderScheduleModifyRequest(this OcipClient client, ServiceProviderScheduleModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a service provider schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderScheduleModifyRequestAsync(this OcipClient client, ServiceProviderScheduleModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the service provider's service authorization status.
        /// The response is either ServiceProviderServiceGetAuthorizationListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServiceGetAuthorizationListRequestAsync instead.")]
        public static async Task<ServiceProviderServiceGetAuthorizationListResponse> ServiceProviderServiceGetAuthorizationListRequest(this OcipClient client, ServiceProviderServiceGetAuthorizationListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderServiceGetAuthorizationListResponse;
        }

        /// <summary>
        /// Requests the service provider's service authorization status.
        /// The response is either ServiceProviderServiceGetAuthorizationListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderServiceGetAuthorizationListResponse> ServiceProviderServiceGetAuthorizationListRequestAsync(this OcipClient client, ServiceProviderServiceGetAuthorizationListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderServiceGetAuthorizationListResponse;
        }
        /// <summary>
        /// Requests the service provider's service authorization information for a specific service or service pack.
        /// The response is either ServiceProviderServiceGetAuthorizationResponse or ErrorResponse.
        /// 
        /// The following element is used in AS mode and triggers an ErrorResponse in XS data mode:
        /// servicePackName
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServiceGetAuthorizationRequestAsync instead.")]
        public static async Task<ServiceProviderServiceGetAuthorizationResponse> ServiceProviderServiceGetAuthorizationRequest(this OcipClient client, ServiceProviderServiceGetAuthorizationRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderServiceGetAuthorizationResponse;
        }

        /// <summary>
        /// Requests the service provider's service authorization information for a specific service or service pack.
        /// The response is either ServiceProviderServiceGetAuthorizationResponse or ErrorResponse.
        /// 
        /// The following element is used in AS mode and triggers an ErrorResponse in XS data mode:
        /// servicePackName
        /// </summary>
        public static async Task<ServiceProviderServiceGetAuthorizationResponse> ServiceProviderServiceGetAuthorizationRequestAsync(this OcipClient client, ServiceProviderServiceGetAuthorizationRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderServiceGetAuthorizationResponse;
        }
        /// <summary>
        /// Requests the list of all user services assignable to users in the specified service provider.
        /// The response is either ServiceProviderServiceGetUserAssignableListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServiceGetUserAssignableListRequestAsync instead.")]
        public static async Task<ServiceProviderServiceGetUserAssignableListResponse> ServiceProviderServiceGetUserAssignableListRequest(this OcipClient client, ServiceProviderServiceGetUserAssignableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderServiceGetUserAssignableListResponse;
        }

        /// <summary>
        /// Requests the list of all user services assignable to users in the specified service provider.
        /// The response is either ServiceProviderServiceGetUserAssignableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderServiceGetUserAssignableListResponse> ServiceProviderServiceGetUserAssignableListRequestAsync(this OcipClient client, ServiceProviderServiceGetUserAssignableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderServiceGetUserAssignableListResponse;
        }
        /// <summary>
        /// Requests to change the service provider's service authorization status.
        /// The boolean flags are used to authorize or unauthorize services.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServiceModifyAuthorizationListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderServiceModifyAuthorizationListRequest(this OcipClient client, ServiceProviderServiceModifyAuthorizationListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Requests to change the service provider's service authorization status.
        /// The boolean flags are used to authorize or unauthorize services.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServiceModifyAuthorizationListRequestAsync(this OcipClient client, ServiceProviderServiceModifyAuthorizationListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a service pack to a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackAddRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderServicePackAddRequest(this OcipClient client, ServiceProviderServicePackAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a service pack to a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackAddRequestAsync(this OcipClient client, ServiceProviderServicePackAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add services to a service pack if the pack has not been authorized to a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackAddServiceListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderServicePackAddServiceListRequest(this OcipClient client, ServiceProviderServicePackAddServiceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add services to a service pack if the pack has not been authorized to a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackAddServiceListRequestAsync(this OcipClient client, ServiceProviderServicePackAddServiceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a service pack from a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderServicePackDeleteRequest(this OcipClient client, ServiceProviderServicePackDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a service pack from a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackDeleteRequestAsync(this OcipClient client, ServiceProviderServicePackDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a service pack details.
        /// The response is either ServiceProviderServicePackGetDetailListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackGetDetailListRequestAsync instead.")]
        public static async Task<ServiceProviderServicePackGetDetailListResponse> ServiceProviderServicePackGetDetailListRequest(this OcipClient client, ServiceProviderServicePackGetDetailListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderServicePackGetDetailListResponse;
        }

        /// <summary>
        /// Request to get a service pack details.
        /// The response is either ServiceProviderServicePackGetDetailListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderServicePackGetDetailListResponse> ServiceProviderServicePackGetDetailListRequestAsync(this OcipClient client, ServiceProviderServicePackGetDetailListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderServicePackGetDetailListResponse;
        }
        /// <summary>
        /// Request to get a list of defined service packs for a service provider.
        /// The response is either ServiceProviderServicePackGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackGetListRequestAsync instead.")]
        public static async Task<ServiceProviderServicePackGetListResponse> ServiceProviderServicePackGetListRequest(this OcipClient client, ServiceProviderServicePackGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderServicePackGetListResponse;
        }

        /// <summary>
        /// Request to get a list of defined service packs for a service provider.
        /// The response is either ServiceProviderServicePackGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderServicePackGetListResponse> ServiceProviderServicePackGetListRequestAsync(this OcipClient client, ServiceProviderServicePackGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderServicePackGetListResponse;
        }
        /// <summary>
        /// Request to get the list of service packs containing a specified service.
        /// The response is either ServiceProviderServicePackGetServiceUsageListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackGetServiceUsageListRequestAsync instead.")]
        public static async Task<ServiceProviderServicePackGetServiceUsageListResponse> ServiceProviderServicePackGetServiceUsageListRequest(this OcipClient client, ServiceProviderServicePackGetServiceUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderServicePackGetServiceUsageListResponse;
        }

        /// <summary>
        /// Request to get the list of service packs containing a specified service.
        /// The response is either ServiceProviderServicePackGetServiceUsageListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderServicePackGetServiceUsageListResponse> ServiceProviderServicePackGetServiceUsageListRequestAsync(this OcipClient client, ServiceProviderServicePackGetServiceUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderServicePackGetServiceUsageListResponse;
        }
        /// <summary>
        /// Request to get the service pack utilization for a service provider.
        /// For each service pack, a table of groups utilizing the pack is returned.
        /// The response is either ServiceProviderServicePackGetUtilizationListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackGetUtilizationListRequestAsync instead.")]
        public static async Task<ServiceProviderServicePackGetUtilizationListResponse> ServiceProviderServicePackGetUtilizationListRequest(this OcipClient client, ServiceProviderServicePackGetUtilizationListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderServicePackGetUtilizationListResponse;
        }

        /// <summary>
        /// Request to get the service pack utilization for a service provider.
        /// For each service pack, a table of groups utilizing the pack is returned.
        /// The response is either ServiceProviderServicePackGetUtilizationListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderServicePackGetUtilizationListResponse> ServiceProviderServicePackGetUtilizationListRequestAsync(this OcipClient client, ServiceProviderServicePackGetUtilizationListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderServicePackGetUtilizationListResponse;
        }
        /// <summary>
        /// Create a service pack migration task.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackMigrationTaskAddRequest21Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskAddRequest21(this OcipClient client, ServiceProviderServicePackMigrationTaskAddRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Create a service pack migration task.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskAddRequest21Async(this OcipClient client, ServiceProviderServicePackMigrationTaskAddRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Makes a copy of one or more existing service pack migration tasks. A copied task
        /// can be edited with other commands and scheduled for future execution. The
        /// name of the new task is chosen automatically. The name will
        /// be "Copy (number) of taskName".
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackMigrationTaskCopyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskCopyRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskCopyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Makes a copy of one or more existing service pack migration tasks. A copied task
        /// can be edited with other commands and scheduled for future execution. The
        /// name of the new task is chosen automatically. The name will
        /// be "Copy (number) of taskName".
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskCopyRequestAsync(this OcipClient client, ServiceProviderServicePackMigrationTaskCopyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deletes a service pack migration task. It is not possible to delete a task while it is
        /// currently executing.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackMigrationTaskDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskDeleteRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deletes a service pack migration task. It is not possible to delete a task while it is
        /// currently executing.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskDeleteRequestAsync(this OcipClient client, ServiceProviderServicePackMigrationTaskDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a list of groups to migrate.
        /// The response is either ServiceProviderServicePackMigrationTaskGetAvailableGroupListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackMigrationTaskGetAvailableGroupListRequestAsync instead.")]
        public static async Task<ServiceProviderServicePackMigrationTaskGetAvailableGroupListResponse> ServiceProviderServicePackMigrationTaskGetAvailableGroupListRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskGetAvailableGroupListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderServicePackMigrationTaskGetAvailableGroupListResponse;
        }

        /// <summary>
        /// Requests a list of groups to migrate.
        /// The response is either ServiceProviderServicePackMigrationTaskGetAvailableGroupListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderServicePackMigrationTaskGetAvailableGroupListResponse> ServiceProviderServicePackMigrationTaskGetAvailableGroupListRequestAsync(this OcipClient client, ServiceProviderServicePackMigrationTaskGetAvailableGroupListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderServicePackMigrationTaskGetAvailableGroupListResponse;
        }
        /// <summary>
        /// Requests a list of all service pack migration tasks for a service provider.
        /// The response is either ServiceProviderServicePackMigrationTaskGetListResponse21
        /// or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackMigrationTaskGetListRequest21Async instead.")]
        public static async Task<ServiceProviderServicePackMigrationTaskGetListResponse21> ServiceProviderServicePackMigrationTaskGetListRequest21(this OcipClient client, ServiceProviderServicePackMigrationTaskGetListRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderServicePackMigrationTaskGetListResponse21;
        }

        /// <summary>
        /// Requests a list of all service pack migration tasks for a service provider.
        /// The response is either ServiceProviderServicePackMigrationTaskGetListResponse21
        /// or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderServicePackMigrationTaskGetListResponse21> ServiceProviderServicePackMigrationTaskGetListRequest21Async(this OcipClient client, ServiceProviderServicePackMigrationTaskGetListRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderServicePackMigrationTaskGetListResponse21;
        }
        /// <summary>
        /// Requests the details of a specified service pack migration task.
        /// The response is either ServiceProviderServicePackMigrationTaskGetResponse21
        /// or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackMigrationTaskGetRequest21Async instead.")]
        public static async Task<ServiceProviderServicePackMigrationTaskGetResponse21> ServiceProviderServicePackMigrationTaskGetRequest21(this OcipClient client, ServiceProviderServicePackMigrationTaskGetRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderServicePackMigrationTaskGetResponse21;
        }

        /// <summary>
        /// Requests the details of a specified service pack migration task.
        /// The response is either ServiceProviderServicePackMigrationTaskGetResponse21
        /// or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderServicePackMigrationTaskGetResponse21> ServiceProviderServicePackMigrationTaskGetRequest21Async(this OcipClient client, ServiceProviderServicePackMigrationTaskGetRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderServicePackMigrationTaskGetResponse21;
        }
        /// <summary>
        /// Replace the list of services and packs to be assigned to users during the service pack migration.
        /// Modification is only allowed prior to task execution.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackMigrationTaskModifyAssignmentListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskModifyAssignmentListRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskModifyAssignmentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Replace the list of services and packs to be assigned to users during the service pack migration.
        /// Modification is only allowed prior to task execution.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskModifyAssignmentListRequestAsync(this OcipClient client, ServiceProviderServicePackMigrationTaskModifyAssignmentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Replace the list of groups to be migrated for a specified service pack migration task.
        /// Modification is only allowed prior to task execution.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackMigrationTaskModifyGroupListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskModifyGroupListRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskModifyGroupListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Replace the list of groups to be migrated for a specified service pack migration task.
        /// Modification is only allowed prior to task execution.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskModifyGroupListRequestAsync(this OcipClient client, ServiceProviderServicePackMigrationTaskModifyGroupListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Replace the list of services and packs to be removed from users during the service pack migration.
        /// Modification is only allowed prior to task execution.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackMigrationTaskModifyRemovalListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskModifyRemovalListRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskModifyRemovalListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Replace the list of services and packs to be removed from users during the service pack migration.
        /// Modification is only allowed prior to task execution.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskModifyRemovalListRequestAsync(this OcipClient client, ServiceProviderServicePackMigrationTaskModifyRemovalListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the properties of a specified service pack migration task.
        /// Modification is only allowed prior to task execution.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackMigrationTaskModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskModifyRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the properties of a specified service pack migration task.
        /// Modification is only allowed prior to task execution.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskModifyRequestAsync(this OcipClient client, ServiceProviderServicePackMigrationTaskModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Replace the list of services and packs used to select which users will be migrated.
        /// Modification is only allowed prior to task execution.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackMigrationTaskModifyUserSelectionRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskModifyUserSelectionRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskModifyUserSelectionRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Replace the list of services and packs used to select which users will be migrated.
        /// Modification is only allowed prior to task execution.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskModifyUserSelectionRequestAsync(this OcipClient client, ServiceProviderServicePackMigrationTaskModifyUserSelectionRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Terminates a service pack migration task that is currently executing.
        /// Modification is only allowed prior to task execution.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackMigrationTaskTerminateRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskTerminateRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskTerminateRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Terminates a service pack migration task that is currently executing.
        /// Modification is only allowed prior to task execution.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskTerminateRequestAsync(this OcipClient client, ServiceProviderServicePackMigrationTaskTerminateRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests to modify a service pack for a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderServicePackModifyRequest(this OcipClient client, ServiceProviderServicePackModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Requests to modify a service pack for a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackModifyRequestAsync(this OcipClient client, ServiceProviderServicePackModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Lookup if the given number is defined in the specified service in the service provider.
        /// The response is ServiceProviderServicePhoneNumberLookupResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePhoneNumberLookupRequestAsync instead.")]
        public static async Task<ServiceProviderServicePhoneNumberLookupResponse> ServiceProviderServicePhoneNumberLookupRequest(this OcipClient client, ServiceProviderServicePhoneNumberLookupRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderServicePhoneNumberLookupResponse;
        }

        /// <summary>
        /// Lookup if the given number is defined in the specified service in the service provider.
        /// The response is ServiceProviderServicePhoneNumberLookupResponse.
        /// </summary>
        public static async Task<ServiceProviderServicePhoneNumberLookupResponse> ServiceProviderServicePhoneNumberLookupRequestAsync(this OcipClient client, ServiceProviderServicePhoneNumberLookupRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderServicePhoneNumberLookupResponse;
        }
        /// <summary>
        /// Get the session admission control capacity for the service provider.
        /// The response is either a ServiceProviderSessionAdmissionControlGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderSessionAdmissionControlGetRequestAsync instead.")]
        public static async Task<ServiceProviderSessionAdmissionControlGetResponse> ServiceProviderSessionAdmissionControlGetRequest(this OcipClient client, ServiceProviderSessionAdmissionControlGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderSessionAdmissionControlGetResponse;
        }

        /// <summary>
        /// Get the session admission control capacity for the service provider.
        /// The response is either a ServiceProviderSessionAdmissionControlGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderSessionAdmissionControlGetResponse> ServiceProviderSessionAdmissionControlGetRequestAsync(this OcipClient client, ServiceProviderSessionAdmissionControlGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderSessionAdmissionControlGetResponse;
        }
        /// <summary>
        /// Request to modify session admission control capacity for the service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderSessionAdmissionControlModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderSessionAdmissionControlModifyRequest(this OcipClient client, ServiceProviderSessionAdmissionControlModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify session admission control capacity for the service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderSessionAdmissionControlModifyRequestAsync(this OcipClient client, ServiceProviderSessionAdmissionControlModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the Service Provider Session Admission White List information.
        /// The response is either a ServiceProviderSessionAdmissionControlWhiteListGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderSessionAdmissionControlWhiteListGetRequestAsync instead.")]
        public static async Task<ServiceProviderSessionAdmissionControlWhiteListGetResponse> ServiceProviderSessionAdmissionControlWhiteListGetRequest(this OcipClient client, ServiceProviderSessionAdmissionControlWhiteListGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderSessionAdmissionControlWhiteListGetResponse;
        }

        /// <summary>
        /// Request to get the Service Provider Session Admission White List information.
        /// The response is either a ServiceProviderSessionAdmissionControlWhiteListGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderSessionAdmissionControlWhiteListGetResponse> ServiceProviderSessionAdmissionControlWhiteListGetRequestAsync(this OcipClient client, ServiceProviderSessionAdmissionControlWhiteListGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderSessionAdmissionControlWhiteListGetResponse;
        }
        /// <summary>
        /// Modify the Service Provider Session Admission Control White List information.
        /// The number of digit pattern entries is limited to 100.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderSessionAdmissionControlWhiteListModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderSessionAdmissionControlWhiteListModifyRequest(this OcipClient client, ServiceProviderSessionAdmissionControlWhiteListModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Service Provider Session Admission Control White List information.
        /// The number of digit pattern entries is limited to 100.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderSessionAdmissionControlWhiteListModifyRequestAsync(this OcipClient client, ServiceProviderSessionAdmissionControlWhiteListModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the service provider level SIP authentication password rule settings.
        /// The response is either a ServiceProviderSIPAuthenticationPasswordRulesGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderSIPAuthenticationPasswordRulesGetRequestAsync instead.")]
        public static async Task<ServiceProviderSIPAuthenticationPasswordRulesGetResponse> ServiceProviderSIPAuthenticationPasswordRulesGetRequest(this OcipClient client, ServiceProviderSIPAuthenticationPasswordRulesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderSIPAuthenticationPasswordRulesGetResponse;
        }

        /// <summary>
        /// Request to get the service provider level SIP authentication password rule settings.
        /// The response is either a ServiceProviderSIPAuthenticationPasswordRulesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderSIPAuthenticationPasswordRulesGetResponse> ServiceProviderSIPAuthenticationPasswordRulesGetRequestAsync(this OcipClient client, ServiceProviderSIPAuthenticationPasswordRulesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderSIPAuthenticationPasswordRulesGetResponse;
        }
        /// <summary>
        /// Request to modify the service provider level SIP authentication password rule settings. The useServiceProviderSettings element can only be modified by a system administrator or a provisioning administrator.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderSIPAuthenticationPasswordRulesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderSIPAuthenticationPasswordRulesModifyRequest(this OcipClient client, ServiceProviderSIPAuthenticationPasswordRulesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the service provider level SIP authentication password rule settings. The useServiceProviderSettings element can only be modified by a system administrator or a provisioning administrator.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderSIPAuthenticationPasswordRulesModifyRequestAsync(this OcipClient client, ServiceProviderSIPAuthenticationPasswordRulesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get service provider Stir Shaken service settings.
        /// The response is either ServiceProviderStirShakenGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderStirShakenGetRequestAsync instead.")]
        public static async Task<ServiceProviderStirShakenGetResponse> ServiceProviderStirShakenGetRequest(this OcipClient client, ServiceProviderStirShakenGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderStirShakenGetResponse;
        }

        /// <summary>
        /// Get service provider Stir Shaken service settings.
        /// The response is either ServiceProviderStirShakenGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderStirShakenGetResponse> ServiceProviderStirShakenGetRequestAsync(this OcipClient client, ServiceProviderStirShakenGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderStirShakenGetResponse;
        }
        /// <summary>
        /// Modify service provider Stir Shaken service settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderStirShakenModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderStirShakenModifyRequest(this OcipClient client, ServiceProviderStirShakenModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify service provider Stir Shaken service settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderStirShakenModifyRequestAsync(this OcipClient client, ServiceProviderStirShakenModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of template files used to support a VDM device defined at service provider level.
        /// The response is either ServiceProviderTemplateOnlyDeviceFileGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderTemplateOnlyDeviceFileGetListRequestAsync instead.")]
        public static async Task<ServiceProviderTemplateOnlyDeviceFileGetListResponse> ServiceProviderTemplateOnlyDeviceFileGetListRequest(this OcipClient client, ServiceProviderTemplateOnlyDeviceFileGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderTemplateOnlyDeviceFileGetListResponse;
        }

        /// <summary>
        /// Request to get the list of template files used to support a VDM device defined at service provider level.
        /// The response is either ServiceProviderTemplateOnlyDeviceFileGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderTemplateOnlyDeviceFileGetListResponse> ServiceProviderTemplateOnlyDeviceFileGetListRequestAsync(this OcipClient client, ServiceProviderTemplateOnlyDeviceFileGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderTemplateOnlyDeviceFileGetListResponse;
        }
        /// <summary>
        /// Get the third-party emergency call service settings for the service provider.
        /// The response is either a ServiceProviderThirdPartyEmergencyCallingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderThirdPartyEmergencyCallingGetRequestAsync instead.")]
        public static async Task<ServiceProviderThirdPartyEmergencyCallingGetResponse> ServiceProviderThirdPartyEmergencyCallingGetRequest(this OcipClient client, ServiceProviderThirdPartyEmergencyCallingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderThirdPartyEmergencyCallingGetResponse;
        }

        /// <summary>
        /// Get the third-party emergency call service settings for the service provider.
        /// The response is either a ServiceProviderThirdPartyEmergencyCallingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderThirdPartyEmergencyCallingGetResponse> ServiceProviderThirdPartyEmergencyCallingGetRequestAsync(this OcipClient client, ServiceProviderThirdPartyEmergencyCallingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderThirdPartyEmergencyCallingGetResponse;
        }
        /// <summary>
        /// Modify the third-party emergency call service settings for the service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderThirdPartyEmergencyCallingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderThirdPartyEmergencyCallingModifyRequest(this OcipClient client, ServiceProviderThirdPartyEmergencyCallingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the third-party emergency call service settings for the service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderThirdPartyEmergencyCallingModifyRequestAsync(this OcipClient client, ServiceProviderThirdPartyEmergencyCallingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the information for a specified device supporting visual device management.
        /// The response is either a ServiceProviderVisualDeviceManagementGetDeviceInfoResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderVisualDeviceManagementGetDeviceInfoRequestAsync instead.")]
        public static async Task<ServiceProviderVisualDeviceManagementGetDeviceInfoResponse> ServiceProviderVisualDeviceManagementGetDeviceInfoRequest(this OcipClient client, ServiceProviderVisualDeviceManagementGetDeviceInfoRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderVisualDeviceManagementGetDeviceInfoResponse;
        }

        /// <summary>
        /// Get the information for a specified device supporting visual device management.
        /// The response is either a ServiceProviderVisualDeviceManagementGetDeviceInfoResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderVisualDeviceManagementGetDeviceInfoResponse> ServiceProviderVisualDeviceManagementGetDeviceInfoRequestAsync(this OcipClient client, ServiceProviderVisualDeviceManagementGetDeviceInfoRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderVisualDeviceManagementGetDeviceInfoResponse;
        }
        /// <summary>
        /// Assign a list of group and user Xsi policy profile to a service provider.
        /// At service provider level, only one service provider Xsi policy profile can be assigned to service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderXsiPolicyProfileAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderXsiPolicyProfileAssignListRequest(this OcipClient client, ServiceProviderXsiPolicyProfileAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of group and user Xsi policy profile to a service provider.
        /// At service provider level, only one service provider Xsi policy profile can be assigned to service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderXsiPolicyProfileAssignListRequestAsync(this OcipClient client, ServiceProviderXsiPolicyProfileAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of group within a service provider that have a given
        /// group Xsi policy profile assigned.
        /// The response is either a ServiceProviderXsiPolicyProfileGetAssignedGroupListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderXsiPolicyProfileGetAssignedGroupListRequestAsync instead.")]
        public static async Task<ServiceProviderXsiPolicyProfileGetAssignedGroupListResponse> ServiceProviderXsiPolicyProfileGetAssignedGroupListRequest(this OcipClient client, ServiceProviderXsiPolicyProfileGetAssignedGroupListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderXsiPolicyProfileGetAssignedGroupListResponse;
        }

        /// <summary>
        /// Get a list of group within a service provider that have a given
        /// group Xsi policy profile assigned.
        /// The response is either a ServiceProviderXsiPolicyProfileGetAssignedGroupListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderXsiPolicyProfileGetAssignedGroupListResponse> ServiceProviderXsiPolicyProfileGetAssignedGroupListRequestAsync(this OcipClient client, ServiceProviderXsiPolicyProfileGetAssignedGroupListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderXsiPolicyProfileGetAssignedGroupListResponse;
        }
        /// <summary>
        /// Get a list of Xsi policy profile assigned.
        /// The response is either a ServiceProviderXsiPolicyProfileGetAssignedListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderXsiPolicyProfileGetAssignedListRequestAsync instead.")]
        public static async Task<ServiceProviderXsiPolicyProfileGetAssignedListResponse> ServiceProviderXsiPolicyProfileGetAssignedListRequest(this OcipClient client, ServiceProviderXsiPolicyProfileGetAssignedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderXsiPolicyProfileGetAssignedListResponse;
        }

        /// <summary>
        /// Get a list of Xsi policy profile assigned.
        /// The response is either a ServiceProviderXsiPolicyProfileGetAssignedListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderXsiPolicyProfileGetAssignedListResponse> ServiceProviderXsiPolicyProfileGetAssignedListRequestAsync(this OcipClient client, ServiceProviderXsiPolicyProfileGetAssignedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderXsiPolicyProfileGetAssignedListResponse;
        }
        /// <summary>
        /// Modifies the default Xsi policy profile for a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderXsiPolicyProfileModifyDefaultRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderXsiPolicyProfileModifyDefaultRequest(this OcipClient client, ServiceProviderXsiPolicyProfileModifyDefaultRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the default Xsi policy profile for a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderXsiPolicyProfileModifyDefaultRequestAsync(this OcipClient client, ServiceProviderXsiPolicyProfileModifyDefaultRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Unassign a list of Xsi policy profile.
        /// Unassign a list of Xsi policy profile.
        /// Only group and user level Xsi policy profile can be unassigned.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderXsiPolicyProfileUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderXsiPolicyProfileUnassignListRequest(this OcipClient client, ServiceProviderXsiPolicyProfileUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of Xsi policy profile.
        /// Unassign a list of Xsi policy profile.
        /// Only group and user level Xsi policy profile can be unassigned.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderXsiPolicyProfileUnassignListRequestAsync(this OcipClient client, ServiceProviderXsiPolicyProfileUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
