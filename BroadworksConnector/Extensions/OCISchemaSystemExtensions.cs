using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaSystemExtensions
    {

        /// <summary>
        /// Request to add a system-level access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceAddRequest(this OcipClient client, SystemAccessDeviceAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a system-level access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceAddRequestAsync(this OcipClient client, SystemAccessDeviceAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a static configuration tag for a system access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceCustomTagAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceCustomTagAddRequest(this OcipClient client, SystemAccessDeviceCustomTagAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a static configuration tag for a system access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceCustomTagAddRequestAsync(this OcipClient client, SystemAccessDeviceCustomTagAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete static configuration tags for a system access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceCustomTagDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceCustomTagDeleteListRequest(this OcipClient client, SystemAccessDeviceCustomTagDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete static configuration tags for a system access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceCustomTagDeleteListRequestAsync(this OcipClient client, SystemAccessDeviceCustomTagDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of custom configuration tags managed by the Device Management System, on a per-device profile basis.
        /// The response is either SystemAccessDeviceCustomTagGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceCustomTagGetListRequestAsync instead.")]
        public static async Task<SystemAccessDeviceCustomTagGetListResponse> SystemAccessDeviceCustomTagGetListRequest(this OcipClient client, SystemAccessDeviceCustomTagGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceCustomTagGetListResponse;
        }

        /// <summary>
        /// Request to get the list of custom configuration tags managed by the Device Management System, on a per-device profile basis.
        /// The response is either SystemAccessDeviceCustomTagGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceCustomTagGetListResponse> SystemAccessDeviceCustomTagGetListRequestAsync(this OcipClient client, SystemAccessDeviceCustomTagGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceCustomTagGetListResponse;
        }
        /// <summary>
        /// Request to modify a static configuration tag for a system access device.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceCustomTagModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceCustomTagModifyRequest(this OcipClient client, SystemAccessDeviceCustomTagModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag for a system access device.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceCustomTagModifyRequestAsync(this OcipClient client, SystemAccessDeviceCustomTagModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a specified system access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceDeleteRequest(this OcipClient client, SystemAccessDeviceDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a specified system access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceDeleteRequestAsync(this OcipClient client, SystemAccessDeviceDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of device files managed by the Device Management System, on a per-device profile basis.
        /// The response is either SystemAccessDeviceFileGetListResponse14sp8 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceFileGetListRequest14sp8Async instead.")]
        public static async Task<SystemAccessDeviceFileGetListResponse14sp8> SystemAccessDeviceFileGetListRequest14sp8(this OcipClient client, SystemAccessDeviceFileGetListRequest14sp8 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceFileGetListResponse14sp8;
        }

        /// <summary>
        /// Request to get the list of device files managed by the Device Management System, on a per-device profile basis.
        /// The response is either SystemAccessDeviceFileGetListResponse14sp8 or ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceFileGetListResponse14sp8> SystemAccessDeviceFileGetListRequest14sp8Async(this OcipClient client, SystemAccessDeviceFileGetListRequest14sp8 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceFileGetListResponse14sp8;
        }
        /// <summary>
        /// Request to get a device profile file.
        /// The response is either SystemAccessDeviceFileGetResponse20 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceFileGetRequest20Async instead.")]
        public static async Task<SystemAccessDeviceFileGetResponse20> SystemAccessDeviceFileGetRequest20(this OcipClient client, SystemAccessDeviceFileGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceFileGetResponse20;
        }

        /// <summary>
        /// Request to get a device profile file.
        /// The response is either SystemAccessDeviceFileGetResponse20 or ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceFileGetResponse20> SystemAccessDeviceFileGetRequest20Async(this OcipClient client, SystemAccessDeviceFileGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceFileGetResponse20;
        }
        /// <summary>
        /// Request to modify a specified system access device file.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceFileModifyRequest14sp8Async instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceFileModifyRequest14sp8(this OcipClient client, SystemAccessDeviceFileModifyRequest14sp8 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a specified system access device file.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceFileModifyRequest14sp8Async(this OcipClient client, SystemAccessDeviceFileModifyRequest14sp8 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of all access devices in the entire system.
        /// Prior to release 14, this functionality was provided with the SystemAccessDeviceGetListRequest14.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All the device
        /// profiles in the administrator's reseller meeting the search criteria are returned.
        /// 
        /// The response is either SystemAccessDeviceGetAllResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceGetAllRequestAsync instead.")]
        public static async Task<SystemAccessDeviceGetAllResponse> SystemAccessDeviceGetAllRequest(this OcipClient client, SystemAccessDeviceGetAllRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceGetAllResponse;
        }

        /// <summary>
        /// Requests the list of all access devices in the entire system.
        /// Prior to release 14, this functionality was provided with the SystemAccessDeviceGetListRequest14.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All the device
        /// profiles in the administrator's reseller meeting the search criteria are returned.
        /// 
        /// The response is either SystemAccessDeviceGetAllResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        public static async Task<SystemAccessDeviceGetAllResponse> SystemAccessDeviceGetAllRequestAsync(this OcipClient client, SystemAccessDeviceGetAllRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceGetAllResponse;
        }
        /// <summary>
        /// Requests the list of access devices defined at the System-level.
        /// Prior to release 14, this command requested a list of all devices in the entire system. That
        /// functionality is now moved to the SystemAccessDeviceGetAllRequest.
        /// The response is either SystemAccessDeviceGetListResponse14 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceGetListRequest14Async instead.")]
        public static async Task<SystemAccessDeviceGetListResponse14> SystemAccessDeviceGetListRequest14(this OcipClient client, SystemAccessDeviceGetListRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceGetListResponse14;
        }

        /// <summary>
        /// Requests the list of access devices defined at the System-level.
        /// Prior to release 14, this command requested a list of all devices in the entire system. That
        /// functionality is now moved to the SystemAccessDeviceGetAllRequest.
        /// The response is either SystemAccessDeviceGetListResponse14 or ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceGetListResponse14> SystemAccessDeviceGetListRequest14Async(this OcipClient client, SystemAccessDeviceGetListRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceGetListResponse14;
        }
        /// <summary>
        /// Requests the configuration of a specified system access device.
        /// The response is either SystemAccessDeviceGetResponse18sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceGetRequest18sp1Async instead.")]
        public static async Task<SystemAccessDeviceGetResponse18sp1> SystemAccessDeviceGetRequest18sp1(this OcipClient client, SystemAccessDeviceGetRequest18sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceGetResponse18sp1;
        }

        /// <summary>
        /// Requests the configuration of a specified system access device.
        /// The response is either SystemAccessDeviceGetResponse18sp1 or ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceGetResponse18sp1> SystemAccessDeviceGetRequest18sp1Async(this OcipClient client, SystemAccessDeviceGetRequest18sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceGetResponse18sp1;
        }
        /// <summary>
        /// Requests the users associated with a specified system access device.
        /// The response is either SystemAccessDeviceGetUserListResponse21sp1 or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceGetUserListRequest21sp1Async instead.")]
        public static async Task<SystemAccessDeviceGetUserListResponse21sp1> SystemAccessDeviceGetUserListRequest21sp1(this OcipClient client, SystemAccessDeviceGetUserListRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceGetUserListResponse21sp1;
        }

        /// <summary>
        /// Requests the users associated with a specified system access device.
        /// The response is either SystemAccessDeviceGetUserListResponse21sp1 or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// </summary>
        public static async Task<SystemAccessDeviceGetUserListResponse21sp1> SystemAccessDeviceGetUserListRequest21sp1Async(this OcipClient client, SystemAccessDeviceGetUserListRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceGetUserListResponse21sp1;
        }
        /// <summary>
        /// Request to modify a specified system access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceModifyRequest(this OcipClient client, SystemAccessDeviceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a specified system access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceModifyRequestAsync(this OcipClient client, SystemAccessDeviceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify attributes for line/ports assigned on the system device profile.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// privateIdentity
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceModifyUserRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceModifyUserRequest(this OcipClient client, SystemAccessDeviceModifyUserRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify attributes for line/ports assigned on the system device profile.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// privateIdentity
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceModifyUserRequestAsync(this OcipClient client, SystemAccessDeviceModifyUserRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a device type to be monitored.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceMonitorAddDeviceTypeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceMonitorAddDeviceTypeRequest(this OcipClient client, SystemAccessDeviceMonitorAddDeviceTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a device type to be monitored.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceMonitorAddDeviceTypeRequestAsync(this OcipClient client, SystemAccessDeviceMonitorAddDeviceTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Remove a device type to be monitored.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceMonitorDeleteDeviceTypeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceMonitorDeleteDeviceTypeRequest(this OcipClient client, SystemAccessDeviceMonitorDeleteDeviceTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Remove a device type to be monitored.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceMonitorDeleteDeviceTypeRequestAsync(this OcipClient client, SystemAccessDeviceMonitorDeleteDeviceTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of monitored device types.
        /// The response is either a SystemAccessDeviceMonitorGetDeviceTypeListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceMonitorGetDeviceTypeListRequestAsync instead.")]
        public static async Task<SystemAccessDeviceMonitorGetDeviceTypeListResponse> SystemAccessDeviceMonitorGetDeviceTypeListRequest(this OcipClient client, SystemAccessDeviceMonitorGetDeviceTypeListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceMonitorGetDeviceTypeListResponse;
        }

        /// <summary>
        /// Get a list of monitored device types.
        /// The response is either a SystemAccessDeviceMonitorGetDeviceTypeListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceMonitorGetDeviceTypeListResponse> SystemAccessDeviceMonitorGetDeviceTypeListRequestAsync(this OcipClient client, SystemAccessDeviceMonitorGetDeviceTypeListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceMonitorGetDeviceTypeListResponse;
        }
        /// <summary>
        /// Request to get the list of Access Device Monitor system parameters.
        /// The response is either SystemAccessDeviceMonitorParametersGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceMonitorParametersGetRequestAsync instead.")]
        public static async Task<SystemAccessDeviceMonitorParametersGetResponse> SystemAccessDeviceMonitorParametersGetRequest(this OcipClient client, SystemAccessDeviceMonitorParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceMonitorParametersGetResponse;
        }

        /// <summary>
        /// Request to get the list of Access Device Monitor system parameters.
        /// The response is either SystemAccessDeviceMonitorParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceMonitorParametersGetResponse> SystemAccessDeviceMonitorParametersGetRequestAsync(this OcipClient client, SystemAccessDeviceMonitorParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceMonitorParametersGetResponse;
        }
        /// <summary>
        /// Request to modify Access Device Monitor system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceMonitorParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceMonitorParametersModifyRequest(this OcipClient client, SystemAccessDeviceMonitorParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Access Device Monitor system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceMonitorParametersModifyRequestAsync(this OcipClient client, SystemAccessDeviceMonitorParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Reset a specific system SIP device that supports the reset operation.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceResetRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceResetRequest(this OcipClient client, SystemAccessDeviceResetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Reset a specific system SIP device that supports the reset operation.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceResetRequestAsync(this OcipClient client, SystemAccessDeviceResetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the custom configuration tag set defined at the access device.
        /// The response is either SystemAccessDeviceTagSetGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceTagSetGetRequestAsync instead.")]
        public static async Task<SystemAccessDeviceTagSetGetResponse> SystemAccessDeviceTagSetGetRequest(this OcipClient client, SystemAccessDeviceTagSetGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceTagSetGetResponse;
        }

        /// <summary>
        /// Request to get the custom configuration tag set defined at the access device.
        /// The response is either SystemAccessDeviceTagSetGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceTagSetGetResponse> SystemAccessDeviceTagSetGetRequestAsync(this OcipClient client, SystemAccessDeviceTagSetGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceTagSetGetResponse;
        }
        /// <summary>
        /// Request to modify a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceTagSetModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceTagSetModifyRequest(this OcipClient client, SystemAccessDeviceTagSetModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceTagSetModifyRequestAsync(this OcipClient client, SystemAccessDeviceTagSetModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of device types supporting enhanced configuration.
        /// The response is either SystemAccessDeviceTypeGetEnhancedConfigurableListResponse
        /// or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceTypeGetEnhancedConfigurableListRequestAsync instead.")]
        public static async Task<SystemAccessDeviceTypeGetEnhancedConfigurableListResponse> SystemAccessDeviceTypeGetEnhancedConfigurableListRequest(this OcipClient client, SystemAccessDeviceTypeGetEnhancedConfigurableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceTypeGetEnhancedConfigurableListResponse;
        }

        /// <summary>
        /// Requests the list of device types supporting enhanced configuration.
        /// The response is either SystemAccessDeviceTypeGetEnhancedConfigurableListResponse
        /// or ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceTypeGetEnhancedConfigurableListResponse> SystemAccessDeviceTypeGetEnhancedConfigurableListRequestAsync(this OcipClient client, SystemAccessDeviceTypeGetEnhancedConfigurableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceTypeGetEnhancedConfigurableListResponse;
        }
        /// <summary>
        /// Requests the list of access device types.
        /// The response is either SystemAccessDeviceTypeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceTypeGetListRequestAsync instead.")]
        public static async Task<SystemAccessDeviceTypeGetListResponse> SystemAccessDeviceTypeGetListRequest(this OcipClient client, SystemAccessDeviceTypeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceTypeGetListResponse;
        }

        /// <summary>
        /// Requests the list of access device types.
        /// The response is either SystemAccessDeviceTypeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemAccessDeviceTypeGetListResponse> SystemAccessDeviceTypeGetListRequestAsync(this OcipClient client, SystemAccessDeviceTypeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceTypeGetListResponse;
        }
        /// <summary>
        /// Request to add a ChargingFunctionElement Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingAddChargingFunctionElementServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccountingAddChargingFunctionElementServerRequest(this OcipClient client, SystemAccountingAddChargingFunctionElementServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a ChargingFunctionElement Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccountingAddChargingFunctionElementServerRequestAsync(this OcipClient client, SystemAccountingAddChargingFunctionElementServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a Radius Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingAddRadiusServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccountingAddRadiusServerRequest(this OcipClient client, SystemAccountingAddRadiusServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a Radius Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccountingAddRadiusServerRequestAsync(this OcipClient client, SystemAccountingAddRadiusServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a ChargingFunctionElementServer from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingDeleteChargingFunctionElementServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccountingDeleteChargingFunctionElementServerRequest(this OcipClient client, SystemAccountingDeleteChargingFunctionElementServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a ChargingFunctionElementServer from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccountingDeleteChargingFunctionElementServerRequestAsync(this OcipClient client, SystemAccountingDeleteChargingFunctionElementServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a Radius Server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingDeleteRadiusServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccountingDeleteRadiusServerRequest(this OcipClient client, SystemAccountingDeleteRadiusServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a Radius Server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccountingDeleteRadiusServerRequestAsync(this OcipClient client, SystemAccountingDeleteRadiusServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of ChargingFunctionElementServers defined in the system.
        /// The response is either a SystemAccountingGetChargingFunctionElementServerListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingGetChargingFunctionElementServerListRequestAsync instead.")]
        public static async Task<SystemAccountingGetChargingFunctionElementServerListResponse> SystemAccountingGetChargingFunctionElementServerListRequest(this OcipClient client, SystemAccountingGetChargingFunctionElementServerListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccountingGetChargingFunctionElementServerListResponse;
        }

        /// <summary>
        /// Request to get a list of ChargingFunctionElementServers defined in the system.
        /// The response is either a SystemAccountingGetChargingFunctionElementServerListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemAccountingGetChargingFunctionElementServerListResponse> SystemAccountingGetChargingFunctionElementServerListRequestAsync(this OcipClient client, SystemAccountingGetChargingFunctionElementServerListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccountingGetChargingFunctionElementServerListResponse;
        }
        /// <summary>
        /// Request to get a list of Radius Servers defined in the system.
        /// The response is either a SystemAccountingGetRadiusServerListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingGetRadiusServerListRequestAsync instead.")]
        public static async Task<SystemAccountingGetRadiusServerListResponse> SystemAccountingGetRadiusServerListRequest(this OcipClient client, SystemAccountingGetRadiusServerListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccountingGetRadiusServerListResponse;
        }

        /// <summary>
        /// Request to get a list of Radius Servers defined in the system.
        /// The response is either a SystemAccountingGetRadiusServerListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemAccountingGetRadiusServerListResponse> SystemAccountingGetRadiusServerListRequestAsync(this OcipClient client, SystemAccountingGetRadiusServerListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccountingGetRadiusServerListResponse;
        }
        /// <summary>
        /// Add an Attribute Value Pair (AVP) combination to disable. The AVP
        /// combination includes a diameter AVP and a vendor ID. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingInhibitedAttributeValuePairCodeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccountingInhibitedAttributeValuePairCodeAddRequest(this OcipClient client, SystemAccountingInhibitedAttributeValuePairCodeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an Attribute Value Pair (AVP) combination to disable. The AVP
        /// combination includes a diameter AVP and a vendor ID. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccountingInhibitedAttributeValuePairCodeAddRequestAsync(this OcipClient client, SystemAccountingInhibitedAttributeValuePairCodeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Remove an Attribute Value Pair (AVP) combination from the list of disabled AVP
        /// codes. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingInhibitedAttributeValuePairCodeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccountingInhibitedAttributeValuePairCodeDeleteRequest(this OcipClient client, SystemAccountingInhibitedAttributeValuePairCodeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Remove an Attribute Value Pair (AVP) combination from the list of disabled AVP
        /// codes. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccountingInhibitedAttributeValuePairCodeDeleteRequestAsync(this OcipClient client, SystemAccountingInhibitedAttributeValuePairCodeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Attribute Value Pair (AVP) combinations that are
        /// disabled. The response is either a SystemAccountingInhibitedAttributeValuePairCodeGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingInhibitedAttributeValuePairCodeGetListRequestAsync instead.")]
        public static async Task<SystemAccountingInhibitedAttributeValuePairCodeGetListResponse> SystemAccountingInhibitedAttributeValuePairCodeGetListRequest(this OcipClient client, SystemAccountingInhibitedAttributeValuePairCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccountingInhibitedAttributeValuePairCodeGetListResponse;
        }

        /// <summary>
        /// Get a list of Attribute Value Pair (AVP) combinations that are
        /// disabled. The response is either a SystemAccountingInhibitedAttributeValuePairCodeGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemAccountingInhibitedAttributeValuePairCodeGetListResponse> SystemAccountingInhibitedAttributeValuePairCodeGetListRequestAsync(this OcipClient client, SystemAccountingInhibitedAttributeValuePairCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccountingInhibitedAttributeValuePairCodeGetListResponse;
        }
        /// <summary>
        /// Request to modify a ChargingFunctionElementServer in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingModifyChargingFunctionElementServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccountingModifyChargingFunctionElementServerRequest(this OcipClient client, SystemAccountingModifyChargingFunctionElementServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a ChargingFunctionElementServer in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccountingModifyChargingFunctionElementServerRequestAsync(this OcipClient client, SystemAccountingModifyChargingFunctionElementServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a Radius Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingModifyRadiusServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccountingModifyRadiusServerRequest(this OcipClient client, SystemAccountingModifyRadiusServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Radius Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccountingModifyRadiusServerRequestAsync(this OcipClient client, SystemAccountingModifyRadiusServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Reorder the charging function element servers. You can not add or delete addresses,
        /// only re-ordering the list is allowed. The ordered list of addresses can be obtained
        /// with the SystemAccountingGetChargingFunctionElementServerListRequest command.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccountingReorderChargingFunctionElementServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccountingReorderChargingFunctionElementServerRequest(this OcipClient client, SystemAccountingReorderChargingFunctionElementServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Reorder the charging function element servers. You can not add or delete addresses,
        /// only re-ordering the list is allowed. The ordered list of addresses can be obtained
        /// with the SystemAccountingGetChargingFunctionElementServerListRequest command.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAccountingReorderChargingFunctionElementServerRequestAsync(this OcipClient client, SystemAccountingReorderChargingFunctionElementServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a system or provisioning administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAdminAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAdminAddRequest(this OcipClient client, SystemAdminAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a system or provisioning administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAdminAddRequestAsync(this OcipClient client, SystemAdminAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a system or provisioning administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAdminDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAdminDeleteRequest(this OcipClient client, SystemAdminDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a system or provisioning administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAdminDeleteRequestAsync(this OcipClient client, SystemAdminDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of system administrators.
        /// The response is either a SystemAdminGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAdminGetListRequestAsync instead.")]
        public static async Task<SystemAdminGetResponse> SystemAdminGetListRequest(this OcipClient client, SystemAdminGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAdminGetResponse;
        }

        /// <summary>
        /// Get a list of system administrators.
        /// The response is either a SystemAdminGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemAdminGetResponse> SystemAdminGetListRequestAsync(this OcipClient client, SystemAdminGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAdminGetResponse;
        }
        /// <summary>
        /// Get a system or provisioning administrators profile.
        /// The response is either a SystemAdminGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAdminGetRequestAsync instead.")]
        public static async Task<SystemAdminGetResponse> SystemAdminGetRequest(this OcipClient client, SystemAdminGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAdminGetResponse;
        }

        /// <summary>
        /// Get a system or provisioning administrators profile.
        /// The response is either a SystemAdminGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemAdminGetResponse> SystemAdminGetRequestAsync(this OcipClient client, SystemAdminGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAdminGetResponse;
        }
        /// <summary>
        /// Modify a system or provisioning administrator.
        /// Since old password is not specified here, any password rule related to old password
        /// does not apply.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAdminModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAdminModifyRequest(this OcipClient client, SystemAdminModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a system or provisioning administrator.
        /// Since old password is not specified here, any password rule related to old password
        /// does not apply.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAdminModifyRequestAsync(this OcipClient client, SystemAdminModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a system-level Application Server alias to the system.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAliasAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAliasAddRequest(this OcipClient client, SystemAliasAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a system-level Application Server alias to the system.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAliasAddRequestAsync(this OcipClient client, SystemAliasAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a system-level Application Server alias from the system.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAliasDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAliasDeleteRequest(this OcipClient client, SystemAliasDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a system-level Application Server alias from the system.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAliasDeleteRequestAsync(this OcipClient client, SystemAliasDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of all system-level Application Server aliases.
        /// The response is either SystemAliasGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAliasGetListRequestAsync instead.")]
        public static async Task<SystemAliasGetListResponse> SystemAliasGetListRequest(this OcipClient client, SystemAliasGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAliasGetListResponse;
        }

        /// <summary>
        /// Requests the list of all system-level Application Server aliases.
        /// The response is either SystemAliasGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemAliasGetListResponse> SystemAliasGetListRequestAsync(this OcipClient client, SystemAliasGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAliasGetListResponse;
        }
        /// <summary>
        /// Request to get the list of alternate user ids.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All the alternate
        /// user ids in the administrator's reseller meeting the search criteria are returned.
        /// 
        /// The response is either SystemAlternateUserIdGetListResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAlternateUserIdGetListRequestAsync instead.")]
        public static async Task<SystemAlternateUserIdGetListResponse> SystemAlternateUserIdGetListRequest(this OcipClient client, SystemAlternateUserIdGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAlternateUserIdGetListResponse;
        }

        /// <summary>
        /// Request to get the list of alternate user ids.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All the alternate
        /// user ids in the administrator's reseller meeting the search criteria are returned.
        /// 
        /// The response is either SystemAlternateUserIdGetListResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        public static async Task<SystemAlternateUserIdGetListResponse> SystemAlternateUserIdGetListRequestAsync(this OcipClient client, SystemAlternateUserIdGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAlternateUserIdGetListResponse;
        }
        /// <summary>
        /// Add an application controller, which is a server where remote
        /// application resides and controls the Route Point.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemApplicationControllerAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemApplicationControllerAddRequest(this OcipClient client, SystemApplicationControllerAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an application controller, which is a server where remote
        /// application resides and controls the Route Point.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemApplicationControllerAddRequestAsync(this OcipClient client, SystemApplicationControllerAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an application controller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemApplicationControllerDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemApplicationControllerDeleteRequest(this OcipClient client, SystemApplicationControllerDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an application controller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemApplicationControllerDeleteRequestAsync(this OcipClient client, SystemApplicationControllerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of application controllers that are configured for the system.
        /// The response is either SystemApplicationControllerGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemApplicationControllerGetListRequestAsync instead.")]
        public static async Task<SystemApplicationControllerGetListResponse> SystemApplicationControllerGetListRequest(this OcipClient client, SystemApplicationControllerGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemApplicationControllerGetListResponse;
        }

        /// <summary>
        /// Get a list of application controllers that are configured for the system.
        /// The response is either SystemApplicationControllerGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemApplicationControllerGetListResponse> SystemApplicationControllerGetListRequestAsync(this OcipClient client, SystemApplicationControllerGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemApplicationControllerGetListResponse;
        }
        /// <summary>
        /// Request to get the list of Application Server Registration system parameters.
        /// The response is either SystemASRParametersGetResponse14sp7 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemASRParametersGetRequest14sp7Async instead.")]
        public static async Task<SystemASRParametersGetResponse14sp7> SystemASRParametersGetRequest14sp7(this OcipClient client, SystemASRParametersGetRequest14sp7 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemASRParametersGetResponse14sp7;
        }

        /// <summary>
        /// Request to get the list of Application Server Registration system parameters.
        /// The response is either SystemASRParametersGetResponse14sp7 or ErrorResponse.
        /// </summary>
        public static async Task<SystemASRParametersGetResponse14sp7> SystemASRParametersGetRequest14sp7Async(this OcipClient client, SystemASRParametersGetRequest14sp7 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemASRParametersGetResponse14sp7;
        }
        /// <summary>
        /// Request to get the list of Application Server Registration system parameters.
        /// The response is either SystemASRParametersGetResponse23 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemASRParametersGetRequest23Async instead.")]
        public static async Task<SystemASRParametersGetResponse23> SystemASRParametersGetRequest23(this OcipClient client, SystemASRParametersGetRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemASRParametersGetResponse23;
        }

        /// <summary>
        /// Request to get the list of Application Server Registration system parameters.
        /// The response is either SystemASRParametersGetResponse23 or ErrorResponse.
        /// </summary>
        public static async Task<SystemASRParametersGetResponse23> SystemASRParametersGetRequest23Async(this OcipClient client, SystemASRParametersGetRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemASRParametersGetResponse23;
        }
        /// <summary>
        /// Request to modify Application Server Registration system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// enableCustomMessageControl
        /// customNumberOfUsersPerMessage
        /// customMessageIntervalMilliseconds
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemASRParametersModifyRequest14sp7Async instead.")]
        public static async Task<SuccessResponse> SystemASRParametersModifyRequest14sp7(this OcipClient client, SystemASRParametersModifyRequest14sp7 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Application Server Registration system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// enableCustomMessageControl
        /// customNumberOfUsersPerMessage
        /// customMessageIntervalMilliseconds
        /// </summary>
        public static async Task<SuccessResponse> SystemASRParametersModifyRequest14sp7Async(this OcipClient client, SystemASRParametersModifyRequest14sp7 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to export system wide authentication lockout data to a file. All locked out device profiles, sip endpoints, and sip trunk groups are returned.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAuthenticationLockoutExportDataGetRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAuthenticationLockoutExportDataGetRequest(this OcipClient client, SystemAuthenticationLockoutExportDataGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to export system wide authentication lockout data to a file. All locked out device profiles, sip endpoints, and sip trunk groups are returned.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAuthenticationLockoutExportDataGetRequestAsync(this OcipClient client, SystemAuthenticationLockoutExportDataGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the authentication lockout settings in the system.
        /// The response is either a SystemAuthenticationLockoutSettingsGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAuthenticationLockoutSettingsGetRequestAsync instead.")]
        public static async Task<SystemAuthenticationLockoutSettingsGetResponse> SystemAuthenticationLockoutSettingsGetRequest(this OcipClient client, SystemAuthenticationLockoutSettingsGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAuthenticationLockoutSettingsGetResponse;
        }

        /// <summary>
        /// Request to get the authentication lockout settings in the system.
        /// The response is either a SystemAuthenticationLockoutSettingsGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemAuthenticationLockoutSettingsGetResponse> SystemAuthenticationLockoutSettingsGetRequestAsync(this OcipClient client, SystemAuthenticationLockoutSettingsGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAuthenticationLockoutSettingsGetResponse;
        }
        /// <summary>
        /// Request to modify the system level device password lockout settings
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAuthenticationLockoutSettingsModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAuthenticationLockoutSettingsModifyRequest(this OcipClient client, SystemAuthenticationLockoutSettingsModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system level device password lockout settings
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAuthenticationLockoutSettingsModifyRequestAsync(this OcipClient client, SystemAuthenticationLockoutSettingsModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the system interface attributes for Messaging Server/BroadCloud.
        /// The response is either SystemBroadCloudGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBroadCloudGetRequestAsync instead.")]
        public static async Task<SystemBroadCloudGetResponse> SystemBroadCloudGetRequest(this OcipClient client, SystemBroadCloudGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBroadCloudGetResponse;
        }

        /// <summary>
        /// Get the system interface attributes for Messaging Server/BroadCloud.
        /// The response is either SystemBroadCloudGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemBroadCloudGetResponse> SystemBroadCloudGetRequestAsync(this OcipClient client, SystemBroadCloudGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBroadCloudGetResponse;
        }
        /// <summary>
        /// Modify the system interface attributes for Messaging Server/BroadCloud.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBroadCloudModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBroadCloudModifyRequest(this OcipClient client, SystemBroadCloudModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system interface attributes for Messaging Server/BroadCloud.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadCloudModifyRequestAsync(this OcipClient client, SystemBroadCloudModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the BroadWorks Mobile Manager service system settings.
        /// The response is either SystemBroadWorksMobileManagerGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBroadWorksMobileManagerGetRequestAsync instead.")]
        public static async Task<SystemBroadWorksMobileManagerGetResponse> SystemBroadWorksMobileManagerGetRequest(this OcipClient client, SystemBroadWorksMobileManagerGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBroadWorksMobileManagerGetResponse;
        }

        /// <summary>
        /// Get the BroadWorks Mobile Manager service system settings.
        /// The response is either SystemBroadWorksMobileManagerGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemBroadWorksMobileManagerGetResponse> SystemBroadWorksMobileManagerGetRequestAsync(this OcipClient client, SystemBroadWorksMobileManagerGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBroadWorksMobileManagerGetResponse;
        }
        /// <summary>
        /// Modify the BroadWorks Mobile Manager service system settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBroadWorksMobileManagerModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBroadWorksMobileManagerModifyRequest(this OcipClient client, SystemBroadWorksMobileManagerModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the BroadWorks Mobile Manager service system settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobileManagerModifyRequestAsync(this OcipClient client, SystemBroadWorksMobileManagerModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of System Diameter base parameters.
        /// The response is either SystemBwDiameterBaseDataGetResponse17sp3 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterBaseDataGetRequest17sp3Async instead.")]
        public static async Task<SystemBwDiameterBaseDataGetResponse17sp3> SystemBwDiameterBaseDataGetRequest17sp3(this OcipClient client, SystemBwDiameterBaseDataGetRequest17sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBwDiameterBaseDataGetResponse17sp3;
        }

        /// <summary>
        /// Requests the list of System Diameter base parameters.
        /// The response is either SystemBwDiameterBaseDataGetResponse17sp3 or ErrorResponse.
        /// </summary>
        public static async Task<SystemBwDiameterBaseDataGetResponse17sp3> SystemBwDiameterBaseDataGetRequest17sp3Async(this OcipClient client, SystemBwDiameterBaseDataGetRequest17sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBwDiameterBaseDataGetResponse17sp3;
        }
        /// <summary>
        /// Requests the list of System Diameter base parameters.
        /// The response is either SystemBwDiameterBaseDataGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterBaseDataGetRequest22Async instead.")]
        public static async Task<SystemBwDiameterBaseDataGetResponse22> SystemBwDiameterBaseDataGetRequest22(this OcipClient client, SystemBwDiameterBaseDataGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBwDiameterBaseDataGetResponse22;
        }

        /// <summary>
        /// Requests the list of System Diameter base parameters.
        /// The response is either SystemBwDiameterBaseDataGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemBwDiameterBaseDataGetResponse22> SystemBwDiameterBaseDataGetRequest22Async(this OcipClient client, SystemBwDiameterBaseDataGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBwDiameterBaseDataGetResponse22;
        }
        /// <summary>
        /// Modifies the System Diameter base parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterBaseDataModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterBaseDataModifyRequest(this OcipClient client, SystemBwDiameterBaseDataModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the System Diameter base parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterBaseDataModifyRequestAsync(this OcipClient client, SystemBwDiameterBaseDataModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a static entry in the Diameter Peer Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterPeerAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterPeerAddRequest(this OcipClient client, SystemBwDiameterPeerAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a static entry in the Diameter Peer Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterPeerAddRequestAsync(this OcipClient client, SystemBwDiameterPeerAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a static entry in the Diameter Peer Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterPeerAddRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterPeerAddRequest22(this OcipClient client, SystemBwDiameterPeerAddRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a static entry in the Diameter Peer Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterPeerAddRequest22Async(this OcipClient client, SystemBwDiameterPeerAddRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Remove a Diameter peer.  A peer cannot be removed if is referenced by a Realm Routing Table entry.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterPeerDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterPeerDeleteRequest(this OcipClient client, SystemBwDiameterPeerDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Remove a Diameter peer.  A peer cannot be removed if is referenced by a Realm Routing Table entry.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterPeerDeleteRequestAsync(this OcipClient client, SystemBwDiameterPeerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of Diameter peers.
        /// The response is either SystemBwDiameterPeerGetListResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterPeerGetListRequestAsync instead.")]
        public static async Task<SystemBwDiameterPeerGetListResponse> SystemBwDiameterPeerGetListRequest(this OcipClient client, SystemBwDiameterPeerGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBwDiameterPeerGetListResponse;
        }

        /// <summary>
        /// Requests the list of Diameter peers.
        /// The response is either SystemBwDiameterPeerGetListResponse or ErrorResponse
        /// </summary>
        public static async Task<SystemBwDiameterPeerGetListResponse> SystemBwDiameterPeerGetListRequestAsync(this OcipClient client, SystemBwDiameterPeerGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBwDiameterPeerGetListResponse;
        }
        /// <summary>
        /// Modifies the attributes of an entry in the Diameter Peer Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterPeerModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterPeerModifyRequest(this OcipClient client, SystemBwDiameterPeerModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the attributes of an entry in the Diameter Peer Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterPeerModifyRequestAsync(this OcipClient client, SystemBwDiameterPeerModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Diameter routing peer.  The realm must refer to a Diameter routing realm whose action is relay.  The destinationPeerIdentity must refer to an existing Diameter peer whose mode is active.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterRoutingPeerAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterRoutingPeerAddRequest(this OcipClient client, SystemBwDiameterRoutingPeerAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Diameter routing peer.  The realm must refer to a Diameter routing realm whose action is relay.  The destinationPeerIdentity must refer to an existing Diameter peer whose mode is active.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterRoutingPeerAddRequestAsync(this OcipClient client, SystemBwDiameterRoutingPeerAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Remove a Diameter routing peer.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterRoutingPeerDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterRoutingPeerDeleteRequest(this OcipClient client, SystemBwDiameterRoutingPeerDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Remove a Diameter routing peer.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterRoutingPeerDeleteRequestAsync(this OcipClient client, SystemBwDiameterRoutingPeerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of Diameter routing peers associated with the specified realm. The response is either SystemBwDiameterRoutingPeerGetListResponse or  ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterRoutingPeerGetListRequestAsync instead.")]
        public static async Task<SystemBwDiameterRoutingPeerGetListResponse> SystemBwDiameterRoutingPeerGetListRequest(this OcipClient client, SystemBwDiameterRoutingPeerGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBwDiameterRoutingPeerGetListResponse;
        }

        /// <summary>
        /// Requests the list of Diameter routing peers associated with the specified realm. The response is either SystemBwDiameterRoutingPeerGetListResponse or  ErrorResponse.
        /// </summary>
        public static async Task<SystemBwDiameterRoutingPeerGetListResponse> SystemBwDiameterRoutingPeerGetListRequestAsync(this OcipClient client, SystemBwDiameterRoutingPeerGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBwDiameterRoutingPeerGetListResponse;
        }
        /// <summary>
        /// Modify a Diameter routing peer.  The realm must refer to a Diameter routing realm whose action is relay.  The destinationPeerIdentity must refer to an existing Diameter peer whose mode is active.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterRoutingPeerModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterRoutingPeerModifyRequest(this OcipClient client, SystemBwDiameterRoutingPeerModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Diameter routing peer.  The realm must refer to a Diameter routing realm whose action is relay.  The destinationPeerIdentity must refer to an existing Diameter peer whose mode is active.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterRoutingPeerModifyRequestAsync(this OcipClient client, SystemBwDiameterRoutingPeerModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a static entry in the Realm Routing Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterRoutingRealmAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterRoutingRealmAddRequest(this OcipClient client, SystemBwDiameterRoutingRealmAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a static entry in the Realm Routing Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterRoutingRealmAddRequestAsync(this OcipClient client, SystemBwDiameterRoutingRealmAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a static entry in the Realm Routing Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterRoutingRealmDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterRoutingRealmDeleteRequest(this OcipClient client, SystemBwDiameterRoutingRealmDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a static entry in the Realm Routing Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterRoutingRealmDeleteRequestAsync(this OcipClient client, SystemBwDiameterRoutingRealmDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of Diameter routing realms.
        /// The response is either SystemBwDiameterRoutingRealmGetListResponse or  ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterRoutingRealmGetListRequestAsync instead.")]
        public static async Task<SystemBwDiameterRoutingRealmGetListResponse> SystemBwDiameterRoutingRealmGetListRequest(this OcipClient client, SystemBwDiameterRoutingRealmGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBwDiameterRoutingRealmGetListResponse;
        }

        /// <summary>
        /// Requests the list of Diameter routing realms.
        /// The response is either SystemBwDiameterRoutingRealmGetListResponse or  ErrorResponse.
        /// </summary>
        public static async Task<SystemBwDiameterRoutingRealmGetListResponse> SystemBwDiameterRoutingRealmGetListRequestAsync(this OcipClient client, SystemBwDiameterRoutingRealmGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBwDiameterRoutingRealmGetListResponse;
        }
        /// <summary>
        /// Modify a static entry in the Realm Routing Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBwDiameterRoutingRealmModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBwDiameterRoutingRealmModifyRequest(this OcipClient client, SystemBwDiameterRoutingRealmModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a static entry in the Realm Routing Table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBwDiameterRoutingRealmModifyRequestAsync(this OcipClient client, SystemBwDiameterRoutingRealmModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse23 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingGetPolicyRequest23Async instead.")]
        public static async Task<SystemCallProcessingGetPolicyResponse23> SystemCallProcessingGetPolicyRequest23(this OcipClient client, SystemCallProcessingGetPolicyRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse23;
        }

        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse23 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse23> SystemCallProcessingGetPolicyRequest23Async(this OcipClient client, SystemCallProcessingGetPolicyRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse23;
        }
        /// <summary>
        /// Modify the system level data associated with Call Processing Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// enableDialableCallerID
        /// allowConfigurableCLIDForRedirectingIdentity
        /// enterpriseCallsCLIDPolicy
        /// enterpriseGroupCallsCLIDPolicy
        /// serviceProviderGroupCallsCLIDPolicy
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// maxConferenceParties
        /// enablePhoneListLookup
        /// useMaxConcurrentTerminatingAlertingRequests
        /// maxConcurrentTerminatingAlertingRequests
        /// delayTimerToRemoveCancelledCallsInSeconds
        /// includeRedirectionsInMaximumNumberOfConcurrentCalls
        /// useUserPhoneNumberForGroupCallsWhenInternalClidUnavailable
        /// useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable
        /// allowMobileDNForRedirectingIdentity
        /// conferenceDisableClampTones
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// routeOverrideDomain
        /// routeOverridePrefix
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingModifyPolicyRequest15Async instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingModifyPolicyRequest15(this OcipClient client, SystemCallProcessingModifyPolicyRequest15 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Call Processing Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// enableDialableCallerID
        /// allowConfigurableCLIDForRedirectingIdentity
        /// enterpriseCallsCLIDPolicy
        /// enterpriseGroupCallsCLIDPolicy
        /// serviceProviderGroupCallsCLIDPolicy
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// maxConferenceParties
        /// enablePhoneListLookup
        /// useMaxConcurrentTerminatingAlertingRequests
        /// maxConcurrentTerminatingAlertingRequests
        /// delayTimerToRemoveCancelledCallsInSeconds
        /// includeRedirectionsInMaximumNumberOfConcurrentCalls
        /// useUserPhoneNumberForGroupCallsWhenInternalClidUnavailable
        /// useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable
        /// allowMobileDNForRedirectingIdentity
        /// conferenceDisableClampTones
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// routeOverrideDomain
        /// routeOverridePrefix
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingModifyPolicyRequest15Async(this OcipClient client, SystemCallProcessingModifyPolicyRequest15 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a call processing policy profile to system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileAddRequest21Async instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileAddRequest21(this OcipClient client, SystemCallProcessingPolicyProfileAddRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a call processing policy profile to system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileAddRequest21Async(this OcipClient client, SystemCallProcessingPolicyProfileAddRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Auto Attendant subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileAutoAttendantProfileGetResponse22 or an
        /// ErrorResponse.
        /// The response contains the call processing policy profile setting for Auto Attendant.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileAutoAttendantProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileAutoAttendantProfileGetResponse22> SystemCallProcessingPolicyProfileAutoAttendantProfileGetRequest22(this OcipClient client, SystemCallProcessingPolicyProfileAutoAttendantProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileAutoAttendantProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Auto Attendant subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileAutoAttendantProfileGetResponse22 or an
        /// ErrorResponse.
        /// The response contains the call processing policy profile setting for Auto Attendant.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileAutoAttendantProfileGetResponse22> SystemCallProcessingPolicyProfileAutoAttendantProfileGetRequest22Async(this OcipClient client, SystemCallProcessingPolicyProfileAutoAttendantProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileAutoAttendantProfileGetResponse22;
        }
        /// <summary>
        /// The response is either SuccessResponse and ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileAutoAttendantProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileAutoAttendantProfileModifyRequest(this OcipClient client, SystemCallProcessingPolicyProfileAutoAttendantProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse and ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileAutoAttendantProfileModifyRequestAsync(this OcipClient client, SystemCallProcessingPolicyProfileAutoAttendantProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile BroadWorks Anywhere subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetResponse22> SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetRequest22(this OcipClient client, SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile BroadWorks Anywhere subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetResponse22> SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetRequest22Async(this OcipClient client, SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetResponse22;
        }
        /// <summary>
        /// The response is either a SuccessResponse or an ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileModifyRequest(this OcipClient client, SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either a SuccessResponse or an ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileModifyRequestAsync(this OcipClient client, SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Call Center subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileCallCenterProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileCallCenterProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileCallCenterProfileGetResponse22> SystemCallProcessingPolicyProfileCallCenterProfileGetRequest22(this OcipClient client, SystemCallProcessingPolicyProfileCallCenterProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileCallCenterProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Call Center subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileCallCenterProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileCallCenterProfileGetResponse22> SystemCallProcessingPolicyProfileCallCenterProfileGetRequest22Async(this OcipClient client, SystemCallProcessingPolicyProfileCallCenterProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileCallCenterProfileGetResponse22;
        }
        /// <summary>
        /// The response is either a SuccessResponse or an ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileCallCenterProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileCallCenterProfileModifyRequest(this OcipClient client, SystemCallProcessingPolicyProfileCallCenterProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either a SuccessResponse or an ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileCallCenterProfileModifyRequestAsync(this OcipClient client, SystemCallProcessingPolicyProfileCallCenterProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Collaborate subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileCollaborateProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileCollaborateProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileCollaborateProfileGetResponse22> SystemCallProcessingPolicyProfileCollaborateProfileGetRequest22(this OcipClient client, SystemCallProcessingPolicyProfileCollaborateProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileCollaborateProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Collaborate subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileCollaborateProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileCollaborateProfileGetResponse22> SystemCallProcessingPolicyProfileCollaborateProfileGetRequest22Async(this OcipClient client, SystemCallProcessingPolicyProfileCollaborateProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileCollaborateProfileGetResponse22;
        }
        /// <summary>
        /// Request to get to modify the call processing policy profile collaborate subscriber type profile.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileCollaborateProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileCollaborateProfileModifyRequest(this OcipClient client, SystemCallProcessingPolicyProfileCollaborateProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to get to modify the call processing policy profile collaborate subscriber type profile.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileCollaborateProfileModifyRequestAsync(this OcipClient client, SystemCallProcessingPolicyProfileCollaborateProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a call processing policy profile from system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileDeleteRequest(this OcipClient client, SystemCallProcessingPolicyProfileDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a call processing policy profile from system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileDeleteRequestAsync(this OcipClient client, SystemCallProcessingPolicyProfileDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Find-me/Follow-me subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetResponse22> SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetRequest22(this OcipClient client, SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Find-me/Follow-me subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetResponse22> SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetRequest22Async(this OcipClient client, SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetResponse22;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileFindMeFollowMeProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileFindMeFollowMeProfileModifyRequest(this OcipClient client, SystemCallProcessingPolicyProfileFindMeFollowMeProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileFindMeFollowMeProfileModifyRequestAsync(this OcipClient client, SystemCallProcessingPolicyProfileFindMeFollowMeProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Flexible Seating Host subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetResponse> SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetRequest22(this OcipClient client, SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetResponse;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Flexible Seating Host subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetResponse> SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetRequest22Async(this OcipClient client, SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetResponse;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileModifyRequest(this OcipClient client, SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileModifyRequestAsync(this OcipClient client, SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a list of NCOSs that have a given CallP Policy Profile assigned.
        /// The response is either a SystemCallProcessingPolicyProfileGetAssignedNCOSListResponse or
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileGetAssignedNCOSListRequestAsync instead.")]
        public static async Task<SystemCallProcessingPolicyProfileGetAssignedNCOSListResponse> SystemCallProcessingPolicyProfileGetAssignedNCOSListRequest(this OcipClient client, SystemCallProcessingPolicyProfileGetAssignedNCOSListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileGetAssignedNCOSListResponse;
        }

        /// <summary>
        /// Request a list of NCOSs that have a given CallP Policy Profile assigned.
        /// The response is either a SystemCallProcessingPolicyProfileGetAssignedNCOSListResponse or
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileGetAssignedNCOSListResponse> SystemCallProcessingPolicyProfileGetAssignedNCOSListRequestAsync(this OcipClient client, SystemCallProcessingPolicyProfileGetAssignedNCOSListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileGetAssignedNCOSListResponse;
        }
        /// <summary>
        /// Get the list of all Call Processing Policy Profiles.
        /// The response is either a SystemCallProcessingPolicyProfileGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileGetListRequestAsync instead.")]
        public static async Task<SystemCallProcessingPolicyProfileGetListResponse> SystemCallProcessingPolicyProfileGetListRequest(this OcipClient client, SystemCallProcessingPolicyProfileGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileGetListResponse;
        }

        /// <summary>
        /// Get the list of all Call Processing Policy Profiles.
        /// The response is either a SystemCallProcessingPolicyProfileGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileGetListResponse> SystemCallProcessingPolicyProfileGetListRequestAsync(this OcipClient client, SystemCallProcessingPolicyProfileGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileGetListResponse;
        }
        /// <summary>
        /// Request to get a call processing policy profile in system.
        /// The response is either a SystemCallProcessingPolicyProfileGetResponse21 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileGetRequest21Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileGetResponse21> SystemCallProcessingPolicyProfileGetRequest21(this OcipClient client, SystemCallProcessingPolicyProfileGetRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileGetResponse21;
        }

        /// <summary>
        /// Request to get a call processing policy profile in system.
        /// The response is either a SystemCallProcessingPolicyProfileGetResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileGetResponse21> SystemCallProcessingPolicyProfileGetRequest21Async(this OcipClient client, SystemCallProcessingPolicyProfileGetRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileGetResponse21;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Group Paging subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileGroupPagingProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileGroupPagingProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileGroupPagingProfileGetResponse22> SystemCallProcessingPolicyProfileGroupPagingProfileGetRequest22(this OcipClient client, SystemCallProcessingPolicyProfileGroupPagingProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileGroupPagingProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Group Paging subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileGroupPagingProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileGroupPagingProfileGetResponse22> SystemCallProcessingPolicyProfileGroupPagingProfileGetRequest22Async(this OcipClient client, SystemCallProcessingPolicyProfileGroupPagingProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileGroupPagingProfileGetResponse22;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileGroupPagingProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileGroupPagingProfileModifyRequest(this OcipClient client, SystemCallProcessingPolicyProfileGroupPagingProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileGroupPagingProfileModifyRequestAsync(this OcipClient client, SystemCallProcessingPolicyProfileGroupPagingProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Hunt Group subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileHuntGroupProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileHuntGroupProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileHuntGroupProfileGetResponse22> SystemCallProcessingPolicyProfileHuntGroupProfileGetRequest22(this OcipClient client, SystemCallProcessingPolicyProfileHuntGroupProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileHuntGroupProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Hunt Group subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileHuntGroupProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileHuntGroupProfileGetResponse22> SystemCallProcessingPolicyProfileHuntGroupProfileGetRequest22Async(this OcipClient client, SystemCallProcessingPolicyProfileHuntGroupProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileHuntGroupProfileGetResponse22;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileHuntGroupProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileHuntGroupProfileModifyRequest(this OcipClient client, SystemCallProcessingPolicyProfileHuntGroupProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileHuntGroupProfileModifyRequestAsync(this OcipClient client, SystemCallProcessingPolicyProfileHuntGroupProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Instant Group Call subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileInstantGroupCallProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileInstantGroupCallProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileInstantGroupCallProfileGetResponse22> SystemCallProcessingPolicyProfileInstantGroupCallProfileGetRequest22(this OcipClient client, SystemCallProcessingPolicyProfileInstantGroupCallProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileInstantGroupCallProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Instant Group Call subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileInstantGroupCallProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileInstantGroupCallProfileGetResponse22> SystemCallProcessingPolicyProfileInstantGroupCallProfileGetRequest22Async(this OcipClient client, SystemCallProcessingPolicyProfileInstantGroupCallProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileInstantGroupCallProfileGetResponse22;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileInstantGroupCallProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileInstantGroupCallProfileModifyRequest(this OcipClient client, SystemCallProcessingPolicyProfileInstantGroupCallProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileInstantGroupCallProfileModifyRequestAsync(this OcipClient client, SystemCallProcessingPolicyProfileInstantGroupCallProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Meet-Me Conferencing subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetResponse22> SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetRequest22(this OcipClient client, SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Meet-Me Conferencing subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetResponse22> SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetRequest22Async(this OcipClient client, SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetResponse22;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileMeetMeConferencingProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileMeetMeConferencingProfileModifyRequest(this OcipClient client, SystemCallProcessingPolicyProfileMeetMeConferencingProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileMeetMeConferencingProfileModifyRequestAsync(this OcipClient client, SystemCallProcessingPolicyProfileMeetMeConferencingProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a call processing policy profile in system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileModifyRequest21Async instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileModifyRequest21(this OcipClient client, SystemCallProcessingPolicyProfileModifyRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call processing policy profile in system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileModifyRequest21Async(this OcipClient client, SystemCallProcessingPolicyProfileModifyRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Route Point subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileRoutePointProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileRoutePointProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileRoutePointProfileGetResponse22> SystemCallProcessingPolicyProfileRoutePointProfileGetRequest22(this OcipClient client, SystemCallProcessingPolicyProfileRoutePointProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileRoutePointProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Route Point subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileRoutePointProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileRoutePointProfileGetResponse22> SystemCallProcessingPolicyProfileRoutePointProfileGetRequest22Async(this OcipClient client, SystemCallProcessingPolicyProfileRoutePointProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileRoutePointProfileGetResponse22;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileRoutePointProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileRoutePointProfileModifyRequest(this OcipClient client, SystemCallProcessingPolicyProfileRoutePointProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileRoutePointProfileModifyRequestAsync(this OcipClient client, SystemCallProcessingPolicyProfileRoutePointProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Trunk Group Pilot user subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22> SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22(this OcipClient client, SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Trunk Group Pilot user subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22> SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22Async(this OcipClient client, SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Trunk Group Pilot user subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22V2 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22V2Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22V2> SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22V2(this OcipClient client, SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22V2;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Trunk Group Pilot user subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22V2 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22V2> SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22V2Async(this OcipClient client, SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse22V2;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileTrunkGroupPilotProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileTrunkGroupPilotProfileModifyRequest(this OcipClient client, SystemCallProcessingPolicyProfileTrunkGroupPilotProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileTrunkGroupPilotProfileModifyRequestAsync(this OcipClient client, SystemCallProcessingPolicyProfileTrunkGroupPilotProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile user subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileUserProfileGetResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileUserProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileUserProfileGetResponse22> SystemCallProcessingPolicyProfileUserProfileGetRequest22(this OcipClient client, SystemCallProcessingPolicyProfileUserProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileUserProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile user subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileUserProfileGetResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileUserProfileGetResponse22> SystemCallProcessingPolicyProfileUserProfileGetRequest22Async(this OcipClient client, SystemCallProcessingPolicyProfileUserProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileUserProfileGetResponse22;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile user subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileUserProfileGetResponse22V2 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileUserProfileGetRequest22V2Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileUserProfileGetResponse22V2> SystemCallProcessingPolicyProfileUserProfileGetRequest22V2(this OcipClient client, SystemCallProcessingPolicyProfileUserProfileGetRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileUserProfileGetResponse22V2;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile user subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileUserProfileGetResponse22V2 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileUserProfileGetResponse22V2> SystemCallProcessingPolicyProfileUserProfileGetRequest22V2Async(this OcipClient client, SystemCallProcessingPolicyProfileUserProfileGetRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileUserProfileGetResponse22V2;
        }
        /// <summary>
        /// Modify a call processing policy profile user subscriber type profile in system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileUserProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileUserProfileModifyRequest(this OcipClient client, SystemCallProcessingPolicyProfileUserProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call processing policy profile user subscriber type profile in system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileUserProfileModifyRequestAsync(this OcipClient client, SystemCallProcessingPolicyProfileUserProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile Voice Portal subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileVoicePortalProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileVoicePortalProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileVoicePortalProfileGetResponse22> SystemCallProcessingPolicyProfileVoicePortalProfileGetRequest22(this OcipClient client, SystemCallProcessingPolicyProfileVoicePortalProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileVoicePortalProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Voice Portal subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileVoicePortalProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileVoicePortalProfileGetResponse22> SystemCallProcessingPolicyProfileVoicePortalProfileGetRequest22Async(this OcipClient client, SystemCallProcessingPolicyProfileVoicePortalProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileVoicePortalProfileGetResponse22;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileVoicePortalProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileVoicePortalProfileModifyRequest(this OcipClient client, SystemCallProcessingPolicyProfileVoicePortalProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileVoicePortalProfileModifyRequestAsync(this OcipClient client, SystemCallProcessingPolicyProfileVoicePortalProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the configuration for a call processing policy profile VoiceXML subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileVoiceXMLProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileVoiceXMLProfileGetRequest22Async instead.")]
        public static async Task<SystemCallProcessingPolicyProfileVoiceXMLProfileGetResponse22> SystemCallProcessingPolicyProfileVoiceXMLProfileGetRequest22(this OcipClient client, SystemCallProcessingPolicyProfileVoiceXMLProfileGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingPolicyProfileVoiceXMLProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile VoiceXML subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileVoiceXMLProfileGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileVoiceXMLProfileGetResponse22> SystemCallProcessingPolicyProfileVoiceXMLProfileGetRequest22Async(this OcipClient client, SystemCallProcessingPolicyProfileVoiceXMLProfileGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingPolicyProfileVoiceXMLProfileGetResponse22;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingPolicyProfileVoiceXMLProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileVoiceXMLProfileModifyRequest(this OcipClient client, SystemCallProcessingPolicyProfileVoiceXMLProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileVoiceXMLProfileModifyRequestAsync(this OcipClient client, SystemCallProcessingPolicyProfileVoiceXMLProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a system call type mapping.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallTypeAddMappingRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallTypeAddMappingRequest(this OcipClient client, SystemCallTypeAddMappingRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a system call type mapping.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallTypeAddMappingRequestAsync(this OcipClient client, SystemCallTypeAddMappingRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a system call type mapping.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallTypeDeleteMappingRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallTypeDeleteMappingRequest(this OcipClient client, SystemCallTypeDeleteMappingRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a system call type mapping.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallTypeDeleteMappingRequestAsync(this OcipClient client, SystemCallTypeDeleteMappingRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of system call types.
        /// The response is either SystemCallTypeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallTypeGetListRequestAsync instead.")]
        public static async Task<SystemCallTypeGetListResponse> SystemCallTypeGetListRequest(this OcipClient client, SystemCallTypeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallTypeGetListResponse;
        }

        /// <summary>
        /// Get a list of system call types.
        /// The response is either SystemCallTypeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemCallTypeGetListResponse> SystemCallTypeGetListRequestAsync(this OcipClient client, SystemCallTypeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallTypeGetListResponse;
        }
        /// <summary>
        /// Get a list of system call type mappings.
        /// The response is either SystemCallTypeGetMappingListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallTypeGetMappingListRequestAsync instead.")]
        public static async Task<SystemCallTypeGetMappingListResponse> SystemCallTypeGetMappingListRequest(this OcipClient client, SystemCallTypeGetMappingListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallTypeGetMappingListResponse;
        }

        /// <summary>
        /// Get a list of system call type mappings.
        /// The response is either SystemCallTypeGetMappingListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemCallTypeGetMappingListResponse> SystemCallTypeGetMappingListRequestAsync(this OcipClient client, SystemCallTypeGetMappingListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallTypeGetMappingListResponse;
        }
        /// <summary>
        /// Request to add one or more prefixes to the list of prefixes to be matched.
        /// Matched prefixes will result in CLID delivery for Korea.
        /// Prefix 00X must be sent using uppercase X.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCLIDDeliveryPrefixAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCLIDDeliveryPrefixAddListRequest(this OcipClient client, SystemCLIDDeliveryPrefixAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add one or more prefixes to the list of prefixes to be matched.
        /// Matched prefixes will result in CLID delivery for Korea.
        /// Prefix 00X must be sent using uppercase X.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCLIDDeliveryPrefixAddListRequestAsync(this OcipClient client, SystemCLIDDeliveryPrefixAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete one or more prefixes from the system.
        /// Prefix 00X must be sent using uppercase X.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCLIDDeliveryPrefixDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCLIDDeliveryPrefixDeleteListRequest(this OcipClient client, SystemCLIDDeliveryPrefixDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete one or more prefixes from the system.
        /// Prefix 00X must be sent using uppercase X.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCLIDDeliveryPrefixDeleteListRequestAsync(this OcipClient client, SystemCLIDDeliveryPrefixDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of provisioned prefixes in the system.
        /// The response is either a SystemCLIDDeliveryPrefixGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCLIDDeliveryPrefixGetListRequestAsync instead.")]
        public static async Task<SystemCLIDDeliveryPrefixGetListResponse> SystemCLIDDeliveryPrefixGetListRequest(this OcipClient client, SystemCLIDDeliveryPrefixGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCLIDDeliveryPrefixGetListResponse;
        }

        /// <summary>
        /// Request to get the list of provisioned prefixes in the system.
        /// The response is either a SystemCLIDDeliveryPrefixGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCLIDDeliveryPrefixGetListResponse> SystemCLIDDeliveryPrefixGetListRequestAsync(this OcipClient client, SystemCLIDDeliveryPrefixGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCLIDDeliveryPrefixGetListResponse;
        }
        /// <summary>
        /// Request to add a client identity entry to the list of client identities in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemClientIdentityAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemClientIdentityAddRequest(this OcipClient client, SystemClientIdentityAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a client identity entry to the list of client identities in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemClientIdentityAddRequestAsync(this OcipClient client, SystemClientIdentityAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a client identity.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemClientIdentityDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemClientIdentityDeleteRequest(this OcipClient client, SystemClientIdentityDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a client identity.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemClientIdentityDeleteRequestAsync(this OcipClient client, SystemClientIdentityDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of client identities.
        /// The response is either a SystemClientIdentityGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemClientIdentityGetListRequestAsync instead.")]
        public static async Task<SystemClientIdentityGetListResponse> SystemClientIdentityGetListRequest(this OcipClient client, SystemClientIdentityGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemClientIdentityGetListResponse;
        }

        /// <summary>
        /// Request to get a list of client identities.
        /// The response is either a SystemClientIdentityGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemClientIdentityGetListResponse> SystemClientIdentityGetListRequestAsync(this OcipClient client, SystemClientIdentityGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemClientIdentityGetListResponse;
        }
        /// <summary>
        /// Request to get the list of Client Session (web and CLI) system parameters.
        /// The response is either SystemClientSessionParametersGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemClientSessionParametersGetRequestAsync instead.")]
        public static async Task<SystemClientSessionParametersGetResponse> SystemClientSessionParametersGetRequest(this OcipClient client, SystemClientSessionParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemClientSessionParametersGetResponse;
        }

        /// <summary>
        /// Request to get the list of Client Session (web and CLI) system parameters.
        /// The response is either SystemClientSessionParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemClientSessionParametersGetResponse> SystemClientSessionParametersGetRequestAsync(this OcipClient client, SystemClientSessionParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemClientSessionParametersGetResponse;
        }
        /// <summary>
        /// Request to modify Client Session (web and CLI) system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemClientSessionParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemClientSessionParametersModifyRequest(this OcipClient client, SystemClientSessionParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Client Session (web and CLI) system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemClientSessionParametersModifyRequestAsync(this OcipClient client, SystemClientSessionParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a codec to the ordered list of codecs supported by the system.
        /// The ordered list of codecs is sent to MGCP devices when creating connections.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCodecAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCodecAddRequest(this OcipClient client, SystemCodecAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a codec to the ordered list of codecs supported by the system.
        /// The ordered list of codecs is sent to MGCP devices when creating connections.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCodecAddRequestAsync(this OcipClient client, SystemCodecAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a supported codec from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCodecDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCodecDeleteRequest(this OcipClient client, SystemCodecDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a supported codec from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCodecDeleteRequestAsync(this OcipClient client, SystemCodecDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the ordered list of supported codecs in the system.
        /// The ordered list of codecs is sent to MGCP devices when creating connections.
        /// The response is either a SystemCodecGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCodecGetListRequestAsync instead.")]
        public static async Task<SystemCodecGetListResponse> SystemCodecGetListRequest(this OcipClient client, SystemCodecGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCodecGetListResponse;
        }

        /// <summary>
        /// Request to get the ordered list of supported codecs in the system.
        /// The ordered list of codecs is sent to MGCP devices when creating connections.
        /// The response is either a SystemCodecGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCodecGetListResponse> SystemCodecGetListRequestAsync(this OcipClient client, SystemCodecGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCodecGetListResponse;
        }
        /// <summary>
        /// Add a Communication Barring Alternate Call Indicator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringAlternateCallIndicatorAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringAlternateCallIndicatorAddRequest(this OcipClient client, SystemCommunicationBarringAlternateCallIndicatorAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Communication Barring Alternate Call Indicator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringAlternateCallIndicatorAddRequestAsync(this OcipClient client, SystemCommunicationBarringAlternateCallIndicatorAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Communication Barring Alternate Call Indicator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringAlternateCallIndicatorDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringAlternateCallIndicatorDeleteRequest(this OcipClient client, SystemCommunicationBarringAlternateCallIndicatorDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Communication Barring Alternate Call Indicator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringAlternateCallIndicatorDeleteRequestAsync(this OcipClient client, SystemCommunicationBarringAlternateCallIndicatorDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get all the Communication Barring Alternate Call Indicator defined
        /// in the system. The response is either a SystemCommunicationBarringAlternateCallIndicatorGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringAlternateCallIndicatorGetListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringAlternateCallIndicatorGetListResponse> SystemCommunicationBarringAlternateCallIndicatorGetListRequest(this OcipClient client, SystemCommunicationBarringAlternateCallIndicatorGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringAlternateCallIndicatorGetListResponse;
        }

        /// <summary>
        /// Get all the Communication Barring Alternate Call Indicator defined
        /// in the system. The response is either a SystemCommunicationBarringAlternateCallIndicatorGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringAlternateCallIndicatorGetListResponse> SystemCommunicationBarringAlternateCallIndicatorGetListRequestAsync(this OcipClient client, SystemCommunicationBarringAlternateCallIndicatorGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringAlternateCallIndicatorGetListResponse;
        }
        /// <summary>
        /// Modify a Communication Barring Alternate Call Indicator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringAlternateCallIndicatorModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringAlternateCallIndicatorModifyRequest(this OcipClient client, SystemCommunicationBarringAlternateCallIndicatorModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Communication Barring Alternate Call Indicator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringAlternateCallIndicatorModifyRequestAsync(this OcipClient client, SystemCommunicationBarringAlternateCallIndicatorModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Communication Barring Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringCallTypeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringCallTypeAddRequest(this OcipClient client, SystemCommunicationBarringCallTypeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Communication Barring Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringCallTypeAddRequestAsync(this OcipClient client, SystemCommunicationBarringCallTypeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Communication Barring Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringCallTypeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringCallTypeDeleteRequest(this OcipClient client, SystemCommunicationBarringCallTypeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Communication Barring Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringCallTypeDeleteRequestAsync(this OcipClient client, SystemCommunicationBarringCallTypeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get all the Communication Barring Call Types defined in the system.
        /// The response is either a SystemCommunicationBarringCallTypeGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringCallTypeGetListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringCallTypeGetListResponse> SystemCommunicationBarringCallTypeGetListRequest(this OcipClient client, SystemCommunicationBarringCallTypeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringCallTypeGetListResponse;
        }

        /// <summary>
        /// Get all the Communication Barring Call Types defined in the system.
        /// The response is either a SystemCommunicationBarringCallTypeGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringCallTypeGetListResponse> SystemCommunicationBarringCallTypeGetListRequestAsync(this OcipClient client, SystemCommunicationBarringCallTypeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringCallTypeGetListResponse;
        }
        /// <summary>
        /// Modify a Communication Barring Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringCallTypeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringCallTypeModifyRequest(this OcipClient client, SystemCommunicationBarringCallTypeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Communication Barring Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringCallTypeModifyRequestAsync(this OcipClient client, SystemCommunicationBarringCallTypeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Communication Barring Criteria.
        /// The following elements are only used in AS data mode:
        /// matchNumberPortabilityStatus
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringCriteriaAddRequest17Async instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringCriteriaAddRequest17(this OcipClient client, SystemCommunicationBarringCriteriaAddRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Communication Barring Criteria.
        /// The following elements are only used in AS data mode:
        /// matchNumberPortabilityStatus
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringCriteriaAddRequest17Async(this OcipClient client, SystemCommunicationBarringCriteriaAddRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an existing Communication Barring Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringCriteriaDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringCriteriaDeleteRequest(this OcipClient client, SystemCommunicationBarringCriteriaDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an existing Communication Barring Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringCriteriaDeleteRequestAsync(this OcipClient client, SystemCommunicationBarringCriteriaDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all Communication Barring Criteria.
        /// The response is either a SystemCommunicationBarringCriteriaGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringCriteriaGetListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringCriteriaGetListResponse> SystemCommunicationBarringCriteriaGetListRequest(this OcipClient client, SystemCommunicationBarringCriteriaGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringCriteriaGetListResponse;
        }

        /// <summary>
        /// Get the list of all Communication Barring Criteria.
        /// The response is either a SystemCommunicationBarringCriteriaGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringCriteriaGetListResponse> SystemCommunicationBarringCriteriaGetListRequestAsync(this OcipClient client, SystemCommunicationBarringCriteriaGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringCriteriaGetListResponse;
        }
        /// <summary>
        /// Get an existing Communication Barring Criteria.
        /// The response is either a SystemCommunicationBarringCriteriaGetResponse19sp1 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringCriteriaGetRequest19sp1Async instead.")]
        public static async Task<SystemCommunicationBarringCriteriaGetResponse19sp1> SystemCommunicationBarringCriteriaGetRequest19sp1(this OcipClient client, SystemCommunicationBarringCriteriaGetRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringCriteriaGetResponse19sp1;
        }

        /// <summary>
        /// Get an existing Communication Barring Criteria.
        /// The response is either a SystemCommunicationBarringCriteriaGetResponse19sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringCriteriaGetResponse19sp1> SystemCommunicationBarringCriteriaGetRequest19sp1Async(this OcipClient client, SystemCommunicationBarringCriteriaGetRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringCriteriaGetResponse19sp1;
        }
        /// <summary>
        /// Modify an existing Communication Barring Criteria.
        /// The following elements are only used in AS data mode:
        /// matchNumberPortabilityStatus
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// matchOtherGETS
        /// matchNotGETS
        /// matchGETSAN
        /// matchGETSNT
        /// matchGETSFC
        /// matchGETSFCAN
        /// matchGETSFCNT
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringCriteriaModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringCriteriaModifyRequest(this OcipClient client, SystemCommunicationBarringCriteriaModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing Communication Barring Criteria.
        /// The following elements are only used in AS data mode:
        /// matchNumberPortabilityStatus
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// matchOtherGETS
        /// matchNotGETS
        /// matchGETSAN
        /// matchGETSNT
        /// matchGETSFC
        /// matchGETSFCAN
        /// matchGETSFCNT
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringCriteriaModifyRequestAsync(this OcipClient client, SystemCommunicationBarringCriteriaModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringDigitPatternCriteriaAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringDigitPatternCriteriaAddRequest(this OcipClient client, SystemCommunicationBarringDigitPatternCriteriaAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringDigitPatternCriteriaAddRequestAsync(this OcipClient client, SystemCommunicationBarringDigitPatternCriteriaAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an existing Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringDigitPatternCriteriaDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringDigitPatternCriteriaDeleteRequest(this OcipClient client, SystemCommunicationBarringDigitPatternCriteriaDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an existing Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringDigitPatternCriteriaDeleteRequestAsync(this OcipClient client, SystemCommunicationBarringDigitPatternCriteriaDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all Digit Pattern Criteria defined at the system level.
        /// The response is either a SystemCommunicationBarringDigitPatternCriteriaGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringDigitPatternCriteriaGetListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringDigitPatternCriteriaGetListResponse> SystemCommunicationBarringDigitPatternCriteriaGetListRequest(this OcipClient client, SystemCommunicationBarringDigitPatternCriteriaGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringDigitPatternCriteriaGetListResponse;
        }

        /// <summary>
        /// Get the list of all Digit Pattern Criteria defined at the system level.
        /// The response is either a SystemCommunicationBarringDigitPatternCriteriaGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringDigitPatternCriteriaGetListResponse> SystemCommunicationBarringDigitPatternCriteriaGetListRequestAsync(this OcipClient client, SystemCommunicationBarringDigitPatternCriteriaGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringDigitPatternCriteriaGetListResponse;
        }
        /// <summary>
        /// Get an existing Digit Pattern Criteria.
        /// The response is either a SystemCommunicationBarringDigitPatternCriteriaGetPatternListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringDigitPatternCriteriaGetPatternListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringDigitPatternCriteriaGetPatternListResponse> SystemCommunicationBarringDigitPatternCriteriaGetPatternListRequest(this OcipClient client, SystemCommunicationBarringDigitPatternCriteriaGetPatternListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringDigitPatternCriteriaGetPatternListResponse;
        }

        /// <summary>
        /// Get an existing Digit Pattern Criteria.
        /// The response is either a SystemCommunicationBarringDigitPatternCriteriaGetPatternListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringDigitPatternCriteriaGetPatternListResponse> SystemCommunicationBarringDigitPatternCriteriaGetPatternListRequestAsync(this OcipClient client, SystemCommunicationBarringDigitPatternCriteriaGetPatternListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringDigitPatternCriteriaGetPatternListResponse;
        }
        /// <summary>
        /// Get an existing Communication Barring Digit Pattern Criteria.
        /// The response is either a SystemCommunicationBarringDigitPatternCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringDigitPatternCriteriaGetRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringDigitPatternCriteriaGetResponse> SystemCommunicationBarringDigitPatternCriteriaGetRequest(this OcipClient client, SystemCommunicationBarringDigitPatternCriteriaGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringDigitPatternCriteriaGetResponse;
        }

        /// <summary>
        /// Get an existing Communication Barring Digit Pattern Criteria.
        /// The response is either a SystemCommunicationBarringDigitPatternCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringDigitPatternCriteriaGetResponse> SystemCommunicationBarringDigitPatternCriteriaGetRequestAsync(this OcipClient client, SystemCommunicationBarringDigitPatternCriteriaGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringDigitPatternCriteriaGetResponse;
        }
        /// <summary>
        /// Modify an existing Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringDigitPatternCriteriaModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringDigitPatternCriteriaModifyRequest(this OcipClient client, SystemCommunicationBarringDigitPatternCriteriaModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringDigitPatternCriteriaModifyRequestAsync(this OcipClient client, SystemCommunicationBarringDigitPatternCriteriaModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with Communication Barring.
        /// The response is either a SystemCommunicationBarringGetResponse21sp1 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringGetRequest21sp1Async instead.")]
        public static async Task<SystemCommunicationBarringGetResponse21sp1> SystemCommunicationBarringGetRequest21sp1(this OcipClient client, SystemCommunicationBarringGetRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringGetResponse21sp1;
        }

        /// <summary>
        /// Request the system level data associated with Communication Barring.
        /// The response is either a SystemCommunicationBarringGetResponse21sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringGetResponse21sp1> SystemCommunicationBarringGetRequest21sp1Async(this OcipClient client, SystemCommunicationBarringGetRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringGetResponse21sp1;
        }
        /// <summary>
        /// Add a new Communication Barring Incoming Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringIncomingCriteriaAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringIncomingCriteriaAddRequest(this OcipClient client, SystemCommunicationBarringIncomingCriteriaAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Communication Barring Incoming Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringIncomingCriteriaAddRequestAsync(this OcipClient client, SystemCommunicationBarringIncomingCriteriaAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an existing Communication Barring Incoming Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringIncomingCriteriaDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringIncomingCriteriaDeleteRequest(this OcipClient client, SystemCommunicationBarringIncomingCriteriaDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an existing Communication Barring Incoming Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringIncomingCriteriaDeleteRequestAsync(this OcipClient client, SystemCommunicationBarringIncomingCriteriaDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all Communication Barring Incoming Criteria.
        /// The response is either a SystemCommunicationBarringIncomingCriteriaGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringIncomingCriteriaGetListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringIncomingCriteriaGetListResponse> SystemCommunicationBarringIncomingCriteriaGetListRequest(this OcipClient client, SystemCommunicationBarringIncomingCriteriaGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringIncomingCriteriaGetListResponse;
        }

        /// <summary>
        /// Get the list of all Communication Barring Incoming Criteria.
        /// The response is either a SystemCommunicationBarringIncomingCriteriaGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringIncomingCriteriaGetListResponse> SystemCommunicationBarringIncomingCriteriaGetListRequestAsync(this OcipClient client, SystemCommunicationBarringIncomingCriteriaGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringIncomingCriteriaGetListResponse;
        }
        /// <summary>
        /// Get an existing Communication Barring Incoming Criteria.
        /// The response is either a SystemCommunicationBarringIncomingCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringIncomingCriteriaGetRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringIncomingCriteriaGetResponse> SystemCommunicationBarringIncomingCriteriaGetRequest(this OcipClient client, SystemCommunicationBarringIncomingCriteriaGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringIncomingCriteriaGetResponse;
        }

        /// <summary>
        /// Get an existing Communication Barring Incoming Criteria.
        /// The response is either a SystemCommunicationBarringIncomingCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringIncomingCriteriaGetResponse> SystemCommunicationBarringIncomingCriteriaGetRequestAsync(this OcipClient client, SystemCommunicationBarringIncomingCriteriaGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringIncomingCriteriaGetResponse;
        }
        /// <summary>
        /// Modify an existing Communication Barring Incoming Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringIncomingCriteriaModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringIncomingCriteriaModifyRequest(this OcipClient client, SystemCommunicationBarringIncomingCriteriaModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing Communication Barring Incoming Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringIncomingCriteriaModifyRequestAsync(this OcipClient client, SystemCommunicationBarringIncomingCriteriaModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Communication Barring.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// vmCallbackScreening
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringModifyRequest(this OcipClient client, SystemCommunicationBarringModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Communication Barring.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// vmCallbackScreening
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringModifyRequestAsync(this OcipClient client, SystemCommunicationBarringModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Communication Barring Profile.
        /// The priorities for IncomingRules are requantized to consecutive integers as part of the add.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction, use value "Block" in XS data mode
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// applyToAttendedCallTransfers, use value "false" in XS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileAddRequest19sp1Async instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringProfileAddRequest19sp1(this OcipClient client, SystemCommunicationBarringProfileAddRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Communication Barring Profile.
        /// The priorities for IncomingRules are requantized to consecutive integers as part of the add.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction, use value "Block" in XS data mode
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// applyToAttendedCallTransfers, use value "false" in XS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringProfileAddRequest19sp1Async(this OcipClient client, SystemCommunicationBarringProfileAddRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an existing Communication Barring Profile.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringProfileDeleteRequest(this OcipClient client, SystemCommunicationBarringProfileDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an existing Communication Barring Profile.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringProfileDeleteRequestAsync(this OcipClient client, SystemCommunicationBarringProfileDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of Communication Barring Proifles that uses a specific
        /// Communication Barring criteria.
        /// The response is either a SystemCommunicationBarringProfileGetCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileGetCriteriaUsageListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringProfileGetCriteriaUsageListResponse> SystemCommunicationBarringProfileGetCriteriaUsageListRequest(this OcipClient client, SystemCommunicationBarringProfileGetCriteriaUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringProfileGetCriteriaUsageListResponse;
        }

        /// <summary>
        /// Get the list of Communication Barring Proifles that uses a specific
        /// Communication Barring criteria.
        /// The response is either a SystemCommunicationBarringProfileGetCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringProfileGetCriteriaUsageListResponse> SystemCommunicationBarringProfileGetCriteriaUsageListRequestAsync(this OcipClient client, SystemCommunicationBarringProfileGetCriteriaUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringProfileGetCriteriaUsageListResponse;
        }
        /// <summary>
        /// Get the list of Profiles that use a specific Digit Pattern Criteria.
        /// The response is either a SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse> SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListRequest(this OcipClient client, SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse;
        }

        /// <summary>
        /// Get the list of Profiles that use a specific Digit Pattern Criteria.
        /// The response is either a SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse> SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListRequestAsync(this OcipClient client, SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse;
        }
        /// <summary>
        /// Get the list of Communication Barring Proifles that uses a specific
        /// Communication Barring Incoming criteria.
        /// The response is either a SystemCommunicationBarringProfileGetIncomingCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileGetIncomingCriteriaUsageListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringProfileGetIncomingCriteriaUsageListResponse> SystemCommunicationBarringProfileGetIncomingCriteriaUsageListRequest(this OcipClient client, SystemCommunicationBarringProfileGetIncomingCriteriaUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringProfileGetIncomingCriteriaUsageListResponse;
        }

        /// <summary>
        /// Get the list of Communication Barring Proifles that uses a specific
        /// Communication Barring Incoming criteria.
        /// The response is either a SystemCommunicationBarringProfileGetIncomingCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringProfileGetIncomingCriteriaUsageListResponse> SystemCommunicationBarringProfileGetIncomingCriteriaUsageListRequestAsync(this OcipClient client, SystemCommunicationBarringProfileGetIncomingCriteriaUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringProfileGetIncomingCriteriaUsageListResponse;
        }
        /// <summary>
        /// Get the list of all Communication Barring Profiles.
        /// The response is either a SystemCommunicationBarringProfileGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileGetListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringProfileGetListResponse> SystemCommunicationBarringProfileGetListRequest(this OcipClient client, SystemCommunicationBarringProfileGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringProfileGetListResponse;
        }

        /// <summary>
        /// Get the list of all Communication Barring Profiles.
        /// The response is either a SystemCommunicationBarringProfileGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringProfileGetListResponse> SystemCommunicationBarringProfileGetListRequestAsync(this OcipClient client, SystemCommunicationBarringProfileGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringProfileGetListResponse;
        }
        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a SystemCommunicationBarringProfileGetResponse19sp1V2
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileGetRequest19sp1V2Async instead.")]
        public static async Task<SystemCommunicationBarringProfileGetResponse19sp1V2> SystemCommunicationBarringProfileGetRequest19sp1V2(this OcipClient client, SystemCommunicationBarringProfileGetRequest19sp1V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringProfileGetResponse19sp1V2;
        }

        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a SystemCommunicationBarringProfileGetResponse19sp1V2
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringProfileGetResponse19sp1V2> SystemCommunicationBarringProfileGetRequest19sp1V2Async(this OcipClient client, SystemCommunicationBarringProfileGetRequest19sp1V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringProfileGetResponse19sp1V2;
        }
        /// <summary>
        /// Modify an existing Communication Barring Profile.
        /// When the originatingDefaultAction is not Treatment, originatingDefaultTreatmentId
        /// will be automatically cleared. Also when the action of originatingRule is not Treatment,
        /// treatmentId will be automatically cleared for the rule.
        /// The priorities for IncomingRules are requantized to consecutive integers as part of the modify.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// applyToAttendedCallTransfers
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringProfileModifyRequest(this OcipClient client, SystemCommunicationBarringProfileModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing Communication Barring Profile.
        /// When the originatingDefaultAction is not Treatment, originatingDefaultTreatmentId
        /// will be automatically cleared. Also when the action of originatingRule is not Treatment,
        /// treatmentId will be automatically cleared for the rule.
        /// The priorities for IncomingRules are requantized to consecutive integers as part of the modify.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// applyToAttendedCallTransfers
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringProfileModifyRequestAsync(this OcipClient client, SystemCommunicationBarringProfileModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of Service Providers that use a specific
        /// Communication Barring Criteria.
        /// The response is either a SystemCommunicationBarringServiceProviderGetCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringServiceProviderGetCriteriaUsageListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringServiceProviderGetCriteriaUsageListResponse> SystemCommunicationBarringServiceProviderGetCriteriaUsageListRequest(this OcipClient client, SystemCommunicationBarringServiceProviderGetCriteriaUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringServiceProviderGetCriteriaUsageListResponse;
        }

        /// <summary>
        /// Get the list of Service Providers that use a specific
        /// Communication Barring Criteria.
        /// The response is either a SystemCommunicationBarringServiceProviderGetCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringServiceProviderGetCriteriaUsageListResponse> SystemCommunicationBarringServiceProviderGetCriteriaUsageListRequestAsync(this OcipClient client, SystemCommunicationBarringServiceProviderGetCriteriaUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringServiceProviderGetCriteriaUsageListResponse;
        }
        /// <summary>
        /// Get the list of Service Providers that use a specific
        /// Communication Barring Incoming Criteria.
        /// The response is either a SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListResponse> SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListRequest(this OcipClient client, SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListResponse;
        }

        /// <summary>
        /// Get the list of Service Providers that use a specific
        /// Communication Barring Incoming Criteria.
        /// The response is either a SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListResponse> SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListRequestAsync(this OcipClient client, SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringServiceProviderGetIncomingCriteriaUsageListResponse;
        }
        /// <summary>
        /// Request to get the File System parameters.
        /// change of behavior is that CLI System/MediaFileSystem/get will no longer show the password
        /// The response is either SystemConfigurableFileSystemGetResponse23 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConfigurableFileSystemGetRequest23Async instead.")]
        public static async Task<SystemConfigurableFileSystemGetResponse23> SystemConfigurableFileSystemGetRequest23(this OcipClient client, SystemConfigurableFileSystemGetRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemConfigurableFileSystemGetResponse23;
        }

        /// <summary>
        /// Request to get the File System parameters.
        /// change of behavior is that CLI System/MediaFileSystem/get will no longer show the password
        /// The response is either SystemConfigurableFileSystemGetResponse23 or ErrorResponse.
        /// </summary>
        public static async Task<SystemConfigurableFileSystemGetResponse23> SystemConfigurableFileSystemGetRequest23Async(this OcipClient client, SystemConfigurableFileSystemGetRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemConfigurableFileSystemGetResponse23;
        }
        /// <summary>
        /// Request to modify File System parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConfigurableFileSystemModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemConfigurableFileSystemModifyRequest(this OcipClient client, SystemConfigurableFileSystemModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify File System parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemConfigurableFileSystemModifyRequestAsync(this OcipClient client, SystemConfigurableFileSystemModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a configurable treatment.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConfigurableTreatmentAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemConfigurableTreatmentAddRequest(this OcipClient client, SystemConfigurableTreatmentAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a configurable treatment.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemConfigurableTreatmentAddRequestAsync(this OcipClient client, SystemConfigurableTreatmentAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a configurable treatment.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConfigurableTreatmentDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemConfigurableTreatmentDeleteRequest(this OcipClient client, SystemConfigurableTreatmentDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a configurable treatment.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemConfigurableTreatmentDeleteRequestAsync(this OcipClient client, SystemConfigurableTreatmentDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of configurable treatments.
        /// The response is either a SystemConfigurableTreatmentGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConfigurableTreatmentGetListRequestAsync instead.")]
        public static async Task<SystemConfigurableTreatmentGetListResponse> SystemConfigurableTreatmentGetListRequest(this OcipClient client, SystemConfigurableTreatmentGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemConfigurableTreatmentGetListResponse;
        }

        /// <summary>
        /// Get a list of configurable treatments.
        /// The response is either a SystemConfigurableTreatmentGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemConfigurableTreatmentGetListResponse> SystemConfigurableTreatmentGetListRequestAsync(this OcipClient client, SystemConfigurableTreatmentGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemConfigurableTreatmentGetListResponse;
        }
        /// <summary>
        /// Get all the attributes of a configurable treatment.
        /// The response is either a SystemConfigurableTreatmentGetResponse16 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConfigurableTreatmentGetRequest16Async instead.")]
        public static async Task<SystemConfigurableTreatmentGetResponse16> SystemConfigurableTreatmentGetRequest16(this OcipClient client, SystemConfigurableTreatmentGetRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemConfigurableTreatmentGetResponse16;
        }

        /// <summary>
        /// Get all the attributes of a configurable treatment.
        /// The response is either a SystemConfigurableTreatmentGetResponse16 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemConfigurableTreatmentGetResponse16> SystemConfigurableTreatmentGetRequest16Async(this OcipClient client, SystemConfigurableTreatmentGetRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemConfigurableTreatmentGetResponse16;
        }
        /// <summary>
        /// Modify the fields for a configurable treatment.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConfigurableTreatmentModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemConfigurableTreatmentModifyRequest(this OcipClient client, SystemConfigurableTreatmentModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for a configurable treatment.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemConfigurableTreatmentModifyRequestAsync(this OcipClient client, SystemConfigurableTreatmentModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a country code to the system.
        /// If ringPeriodMilliseconds is not specified, a default of 6000 milliseconds is assumed.
        /// If offHookWarningTimerSeconds is not specified, a default of 30 seconds is assumed.
        /// If enableNationalPrefix is not specified, a default of false is assumed.
        /// If nationalPrefix is not specified, a default of null string is assumed.
        /// If disableNationalPrefixForOffNetCalls is not specified, a default of false is assumed.
        /// The following elements are only used in AS data mode:
        /// disableNationalPrefixForOffNetCalls.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCountryCodeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCountryCodeAddRequest(this OcipClient client, SystemCountryCodeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a country code to the system.
        /// If ringPeriodMilliseconds is not specified, a default of 6000 milliseconds is assumed.
        /// If offHookWarningTimerSeconds is not specified, a default of 30 seconds is assumed.
        /// If enableNationalPrefix is not specified, a default of false is assumed.
        /// If nationalPrefix is not specified, a default of null string is assumed.
        /// If disableNationalPrefixForOffNetCalls is not specified, a default of false is assumed.
        /// The following elements are only used in AS data mode:
        /// disableNationalPrefixForOffNetCalls.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCountryCodeAddRequestAsync(this OcipClient client, SystemCountryCodeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a country code from the system.
        /// A country code cannot be deleted if it is the default country code or
        /// if any carriers or call type mappings are defined against it.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCountryCodeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCountryCodeDeleteRequest(this OcipClient client, SystemCountryCodeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a country code from the system.
        /// A country code cannot be deleted if it is the default country code or
        /// if any carriers or call type mappings are defined against it.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCountryCodeDeleteRequestAsync(this OcipClient client, SystemCountryCodeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request data for all country codes.
        /// The response is either a SystemCountryCodeGetListResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCountryCodeGetListRequestAsync instead.")]
        public static async Task<SystemCountryCodeGetListResponse> SystemCountryCodeGetListRequest(this OcipClient client, SystemCountryCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCountryCodeGetListResponse;
        }

        /// <summary>
        /// Request data for all country codes.
        /// The response is either a SystemCountryCodeGetListResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCountryCodeGetListResponse> SystemCountryCodeGetListRequestAsync(this OcipClient client, SystemCountryCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCountryCodeGetListResponse;
        }
        /// <summary>
        /// Modify the attributes of a country code.
        /// If becomeDefaultCountryCode is true, the country code
        /// in this request becomes the default country code for the system.
        /// The following elements are only used in AS data mode:
        /// disableNationalPrefixForOffNetCalls
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCountryCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCountryCodeModifyRequest(this OcipClient client, SystemCountryCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the attributes of a country code.
        /// If becomeDefaultCountryCode is true, the country code
        /// in this request becomes the default country code for the system.
        /// The following elements are only used in AS data mode:
        /// disableNationalPrefixForOffNetCalls
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCountryCodeModifyRequestAsync(this OcipClient client, SystemCountryCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a device CPE config file server.
        /// The following elements are only used in AS data mode:
        /// extendedCaptureFileRepositoryName
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigAddFileServerRequest14sp6Async instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigAddFileServerRequest14sp6(this OcipClient client, SystemCPEConfigAddFileServerRequest14sp6 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a device CPE config file server.
        /// The following elements are only used in AS data mode:
        /// extendedCaptureFileRepositoryName
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigAddFileServerRequest14sp6Async(this OcipClient client, SystemCPEConfigAddFileServerRequest14sp6 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a device CPE config file server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigDeleteFileServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigDeleteFileServerRequest(this OcipClient client, SystemCPEConfigDeleteFileServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a device CPE config file server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigDeleteFileServerRequestAsync(this OcipClient client, SystemCPEConfigDeleteFileServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of device CPE config file servers.
        /// The response is either SystemCPEConfigGetFileServerListResponse14sp6 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigGetFileServerListRequest14sp6Async instead.")]
        public static async Task<SystemCPEConfigGetFileServerListResponse14sp6> SystemCPEConfigGetFileServerListRequest14sp6(this OcipClient client, SystemCPEConfigGetFileServerListRequest14sp6 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCPEConfigGetFileServerListResponse14sp6;
        }

        /// <summary>
        /// Requests the list of device CPE config file servers.
        /// The response is either SystemCPEConfigGetFileServerListResponse14sp6 or ErrorResponse.
        /// </summary>
        public static async Task<SystemCPEConfigGetFileServerListResponse14sp6> SystemCPEConfigGetFileServerListRequest14sp6Async(this OcipClient client, SystemCPEConfigGetFileServerListRequest14sp6 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCPEConfigGetFileServerListResponse14sp6;
        }
        /// <summary>
        /// Modify a device CPE config file server.
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigModifyFileServerRequest14sp6Async instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigModifyFileServerRequest14sp6(this OcipClient client, SystemCPEConfigModifyFileServerRequest14sp6 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a device CPE config file server.
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigModifyFileServerRequest14sp6Async(this OcipClient client, SystemCPEConfigModifyFileServerRequest14sp6 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of CPE Config system parameters.
        /// The response is either SystemCPEConfigParametersGetResponse21 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigParametersGetRequest21Async instead.")]
        public static async Task<SystemCPEConfigParametersGetResponse21> SystemCPEConfigParametersGetRequest21(this OcipClient client, SystemCPEConfigParametersGetRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCPEConfigParametersGetResponse21;
        }

        /// <summary>
        /// Request to get the list of CPE Config system parameters.
        /// The response is either SystemCPEConfigParametersGetResponse21 or ErrorResponse.
        /// </summary>
        public static async Task<SystemCPEConfigParametersGetResponse21> SystemCPEConfigParametersGetRequest21Async(this OcipClient client, SystemCPEConfigParametersGetRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCPEConfigParametersGetResponse21;
        }
        /// <summary>
        /// Request to modify CPE Config system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in the AS data mode and ignored in the XS data mode:
        /// allowDeviceCredentialsRetrieval
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigParametersModifyRequest21Async instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigParametersModifyRequest21(this OcipClient client, SystemCPEConfigParametersModifyRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify CPE Config system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in the AS data mode and ignored in the XS data mode:
        /// allowDeviceCredentialsRetrieval
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigParametersModifyRequest21Async(this OcipClient client, SystemCPEConfigParametersModifyRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Rebuild the system default config file for the specified device type.
        /// If the device type is not specified, all files for all device types in the system are rebuilt.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigRebuildConfigFileRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigRebuildConfigFileRequest(this OcipClient client, SystemCPEConfigRebuildConfigFileRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Rebuild the system default config file for the specified device type.
        /// If the device type is not specified, all files for all device types in the system are rebuilt.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigRebuildConfigFileRequestAsync(this OcipClient client, SystemCPEConfigRebuildConfigFileRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Rebuild the config file for a specified device.
        /// The following elements are only used in AS data mode:
        /// force
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigRebuildDeviceConfigFileRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigRebuildDeviceConfigFileRequest(this OcipClient client, SystemCPEConfigRebuildDeviceConfigFileRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Rebuild the config file for a specified device.
        /// The following elements are only used in AS data mode:
        /// force
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigRebuildDeviceConfigFileRequestAsync(this OcipClient client, SystemCPEConfigRebuildDeviceConfigFileRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Reorder the lines of a System device. You can not add or delete line ports, only
        /// re-ordering the list is allowed. The ordered list of line ports can be obtained
        /// with the SystemAccessDeviceGetRequest16 command.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigReorderDeviceLinePortsRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigReorderDeviceLinePortsRequest(this OcipClient client, SystemCPEConfigReorderDeviceLinePortsRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Reorder the lines of a System device. You can not add or delete line ports, only
        /// re-ordering the list is allowed. The ordered list of line ports can be obtained
        /// with the SystemAccessDeviceGetRequest16 command.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigReorderDeviceLinePortsRequestAsync(this OcipClient client, SystemCPEConfigReorderDeviceLinePortsRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Reset a specific system device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigResetDeviceRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigResetDeviceRequest(this OcipClient client, SystemCPEConfigResetDeviceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Reset a specific system device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigResetDeviceRequestAsync(this OcipClient client, SystemCPEConfigResetDeviceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Reset all the devices of the specified device type in the system.
        /// If the device type is not specified, all device in the system are reset.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigResetDeviceTypeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigResetDeviceTypeRequest(this OcipClient client, SystemCPEConfigResetDeviceTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Reset all the devices of the specified device type in the system.
        /// If the device type is not specified, all device in the system are reset.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigResetDeviceTypeRequestAsync(this OcipClient client, SystemCPEConfigResetDeviceTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to set a new system default configuration file for a device type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCPEConfigSetConfigFileRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCPEConfigSetConfigFileRequest(this OcipClient client, SystemCPEConfigSetConfigFileRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to set a new system default configuration file for a device type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigSetConfigFileRequestAsync(this OcipClient client, SystemCPEConfigSetConfigFileRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Gets the system level attributes of the Cr Interface.
        /// The response is either a SystemCrInterfaceGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCrInterfaceGetRequest22Async instead.")]
        public static async Task<SystemCrInterfaceGetResponse> SystemCrInterfaceGetRequest22(this OcipClient client, SystemCrInterfaceGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCrInterfaceGetResponse;
        }

        /// <summary>
        /// Gets the system level attributes of the Cr Interface.
        /// The response is either a SystemCrInterfaceGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCrInterfaceGetResponse> SystemCrInterfaceGetRequest22Async(this OcipClient client, SystemCrInterfaceGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCrInterfaceGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Cr Interface.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCrInterfaceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCrInterfaceModifyRequest(this OcipClient client, SystemCrInterfaceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Cr Interface.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCrInterfaceModifyRequestAsync(this OcipClient client, SystemCrInterfaceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of OCI request prefixes including if they trigger DM
        /// automatic rebuild event or not.
        /// The response is either a SystemDeviceManagementAutoRebuildConfigGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementAutoRebuildConfigGetListRequestAsync instead.")]
        public static async Task<SystemDeviceManagementAutoRebuildConfigGetListResponse> SystemDeviceManagementAutoRebuildConfigGetListRequest(this OcipClient client, SystemDeviceManagementAutoRebuildConfigGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceManagementAutoRebuildConfigGetListResponse;
        }

        /// <summary>
        /// Request the list of OCI request prefixes including if they trigger DM
        /// automatic rebuild event or not.
        /// The response is either a SystemDeviceManagementAutoRebuildConfigGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceManagementAutoRebuildConfigGetListResponse> SystemDeviceManagementAutoRebuildConfigGetListRequestAsync(this OcipClient client, SystemDeviceManagementAutoRebuildConfigGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceManagementAutoRebuildConfigGetListResponse;
        }
        /// <summary>
        /// Request to enable or disable automatic trigger of DM events for
        /// OCI request prefixes, regardless of the request's
        /// version.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementAutoRebuildConfigModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementAutoRebuildConfigModifyListRequest(this OcipClient client, SystemDeviceManagementAutoRebuildConfigModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to enable or disable automatic trigger of DM events for
        /// OCI request prefixes, regardless of the request's
        /// version.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementAutoRebuildConfigModifyListRequestAsync(this OcipClient client, SystemDeviceManagementAutoRebuildConfigModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request device management's events for a specific queue.
        /// It is possible to restrict the number of rows returned using
        /// responseSizeLimit.
        /// If eventQueueType is not specified, the events from all the
        /// event queues are returned.
        /// The response is either a SystemDeviceManagementEventGetListResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementEventGetListRequest22Async instead.")]
        public static async Task<SystemDeviceManagementEventGetListResponse22> SystemDeviceManagementEventGetListRequest22(this OcipClient client, SystemDeviceManagementEventGetListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceManagementEventGetListResponse22;
        }

        /// <summary>
        /// Request device management's events for a specific queue.
        /// It is possible to restrict the number of rows returned using
        /// responseSizeLimit.
        /// If eventQueueType is not specified, the events from all the
        /// event queues are returned.
        /// The response is either a SystemDeviceManagementEventGetListResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceManagementEventGetListResponse22> SystemDeviceManagementEventGetListRequest22Async(this OcipClient client, SystemDeviceManagementEventGetListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceManagementEventGetListResponse22;
        }
        /// <summary>
        /// Request the number of access device of a particular device type or all
        /// device types if deviceType is not specified.
        /// If countOnlyResetSupportedDevice is true, count only access devices if the device type supports reset.
        /// By default unmanaged device types are not allowed and devices are counted only if their device type supports Device Management.
        /// An error is returned if deviceType is specified but does not support device management.
        /// When allowUnmanagedDeviceType is true, unmanaged device type will be counted and a successful response is returned.
        /// The response is either SystemDeviceManagementGetAccessDeviceCountForDeviceTypeResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementGetAccessDeviceCountForDeviceTypeRequestAsync instead.")]
        public static async Task<SystemDeviceManagementGetAccessDeviceCountForDeviceTypeResponse> SystemDeviceManagementGetAccessDeviceCountForDeviceTypeRequest(this OcipClient client, SystemDeviceManagementGetAccessDeviceCountForDeviceTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceManagementGetAccessDeviceCountForDeviceTypeResponse;
        }

        /// <summary>
        /// Request the number of access device of a particular device type or all
        /// device types if deviceType is not specified.
        /// If countOnlyResetSupportedDevice is true, count only access devices if the device type supports reset.
        /// By default unmanaged device types are not allowed and devices are counted only if their device type supports Device Management.
        /// An error is returned if deviceType is specified but does not support device management.
        /// When allowUnmanagedDeviceType is true, unmanaged device type will be counted and a successful response is returned.
        /// The response is either SystemDeviceManagementGetAccessDeviceCountForDeviceTypeResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceManagementGetAccessDeviceCountForDeviceTypeResponse> SystemDeviceManagementGetAccessDeviceCountForDeviceTypeRequestAsync(this OcipClient client, SystemDeviceManagementGetAccessDeviceCountForDeviceTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceManagementGetAccessDeviceCountForDeviceTypeResponse;
        }
        /// <summary>
        /// Request a summary table of the number of events in state 'Pending',
        /// 'Queued Internally', and 'Completed' in the system per action.
        /// One row is returned per action.
        /// Actions are as per the DeviceManagementEventActionType (ex: Delete, Download, Rebuild, Reset, Upload).
        /// The state 'Queued Internally' includes total for events with status
        /// equal to 'Queued' and 'In Progress' as per DeviceManagementEventStatus.
        /// The response is either SystemDeviceManagementGetEventStatusSummaryCountResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementGetEventStatusSummaryCountRequestAsync instead.")]
        public static async Task<SystemDeviceManagementGetEventStatusSummaryCountResponse> SystemDeviceManagementGetEventStatusSummaryCountRequest(this OcipClient client, SystemDeviceManagementGetEventStatusSummaryCountRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceManagementGetEventStatusSummaryCountResponse;
        }

        /// <summary>
        /// Request a summary table of the number of events in state 'Pending',
        /// 'Queued Internally', and 'Completed' in the system per action.
        /// One row is returned per action.
        /// Actions are as per the DeviceManagementEventActionType (ex: Delete, Download, Rebuild, Reset, Upload).
        /// The state 'Queued Internally' includes total for events with status
        /// equal to 'Queued' and 'In Progress' as per DeviceManagementEventStatus.
        /// The response is either SystemDeviceManagementGetEventStatusSummaryCountResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceManagementGetEventStatusSummaryCountResponse> SystemDeviceManagementGetEventStatusSummaryCountRequestAsync(this OcipClient client, SystemDeviceManagementGetEventStatusSummaryCountRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceManagementGetEventStatusSummaryCountResponse;
        }
        /// <summary>
        /// Cancel pending and in progress events.  Either all events, multiple
        /// events, or a list of specified events can be canceled.
        /// When specifying multiple events, an event must meet all specified
        /// criteria to be canceled.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementInProgressAndPendingEventCancelRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementInProgressAndPendingEventCancelRequest(this OcipClient client, SystemDeviceManagementInProgressAndPendingEventCancelRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Cancel pending and in progress events.  Either all events, multiple
        /// events, or a list of specified events can be canceled.
        /// When specifying multiple events, an event must meet all specified
        /// criteria to be canceled.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementInProgressAndPendingEventCancelRequestAsync(this OcipClient client, SystemDeviceManagementInProgressAndPendingEventCancelRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Switch the device type for a specified device.
        /// To switch a system level device profile, serviceProviderId and groupId should not be present.
        /// To switch a service provider level device profile, only serviceProviderId should be specified.
        /// To switch a group level device profile, serviceProviderId and groupId should specified.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementSwitchDeviceTypeDeviceRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementSwitchDeviceTypeDeviceRequest(this OcipClient client, SystemDeviceManagementSwitchDeviceTypeDeviceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Switch the device type for a specified device.
        /// To switch a system level device profile, serviceProviderId and groupId should not be present.
        /// To switch a service provider level device profile, only serviceProviderId should be specified.
        /// To switch a group level device profile, serviceProviderId and groupId should specified.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementSwitchDeviceTypeDeviceRequestAsync(this OcipClient client, SystemDeviceManagementSwitchDeviceTypeDeviceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Switch the device type for all devices at the specified scope for a device type.
        /// To switch all the device type's device profiles for the system, neither the serviceProviderId and groupId should be present.
        /// To switch all the device type's device profiles for a service provider, only serviceProviderId should be specified.
        /// To switch all the device type's device profiles for a group, serviceProviderId and groupId should specified.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementSwitchDeviceTypeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementSwitchDeviceTypeRequest(this OcipClient client, SystemDeviceManagementSwitchDeviceTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Switch the device type for all devices at the specified scope for a device type.
        /// To switch all the device type's device profiles for the system, neither the serviceProviderId and groupId should be present.
        /// To switch all the device type's device profiles for a service provider, only serviceProviderId should be specified.
        /// To switch all the device type's device profiles for a group, serviceProviderId and groupId should specified.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementSwitchDeviceTypeRequestAsync(this OcipClient client, SystemDeviceManagementSwitchDeviceTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a static configuration tag.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// isTagValueEncrypted
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementTagAddRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementTagAddRequest22(this OcipClient client, SystemDeviceManagementTagAddRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a static configuration tag.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// isTagValueEncrypted
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementTagAddRequest22Async(this OcipClient client, SystemDeviceManagementTagAddRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete static configuration tags.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementTagDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementTagDeleteListRequest(this OcipClient client, SystemDeviceManagementTagDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete static configuration tags.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementTagDeleteListRequestAsync(this OcipClient client, SystemDeviceManagementTagDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of custom configuration tags managed by the Device Management System.
        /// The response is either SystemDeviceManagementTagGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementTagGetListRequestAsync instead.")]
        public static async Task<SystemDeviceManagementTagGetListResponse> SystemDeviceManagementTagGetListRequest(this OcipClient client, SystemDeviceManagementTagGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceManagementTagGetListResponse;
        }

        /// <summary>
        /// Request to get the list of custom configuration tags managed by the Device Management System.
        /// The response is either SystemDeviceManagementTagGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceManagementTagGetListResponse> SystemDeviceManagementTagGetListRequestAsync(this OcipClient client, SystemDeviceManagementTagGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceManagementTagGetListResponse;
        }
        /// <summary>
        /// Request to modify a static configuration tag.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementTagModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementTagModifyRequest(this OcipClient client, SystemDeviceManagementTagModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementTagModifyRequestAsync(this OcipClient client, SystemDeviceManagementTagModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a static configuration tag set.
        /// When the optional element resellerId is specified, the tag set created is at reseller level. Tag set name
        /// should be unique through out the system including all the reseller level tag sets.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// resellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementTagSetAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementTagSetAddRequest(this OcipClient client, SystemDeviceManagementTagSetAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a static configuration tag set.
        /// When the optional element resellerId is specified, the tag set created is at reseller level. Tag set name
        /// should be unique through out the system including all the reseller level tag sets.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// resellerId
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementTagSetAddRequestAsync(this OcipClient client, SystemDeviceManagementTagSetAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementTagSetDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementTagSetDeleteRequest(this OcipClient client, SystemDeviceManagementTagSetDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementTagSetDeleteRequestAsync(this OcipClient client, SystemDeviceManagementTagSetDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of custom configuration tag sets managed by the Device Management System.
        /// If excludeReseller is set, only system level tag sets are returned.
        /// If resellerId is specified, all system level tag sets and the tag sets in the reseller are returned.
        /// If reseller administrator sends the request, resellerId is not specified, the administrator's resellerId is used.
        /// If neither excludeReseller nor resellerId is specified, all system level and reseller level tag sets are returned.
        /// 
        /// The response is either SystemDeviceManagementTagSetGetListResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementTagSetGetListRequest22Async instead.")]
        public static async Task<SystemDeviceManagementTagSetGetListResponse22> SystemDeviceManagementTagSetGetListRequest22(this OcipClient client, SystemDeviceManagementTagSetGetListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceManagementTagSetGetListResponse22;
        }

        /// <summary>
        /// Request to get the list of custom configuration tag sets managed by the Device Management System.
        /// If excludeReseller is set, only system level tag sets are returned.
        /// If resellerId is specified, all system level tag sets and the tag sets in the reseller are returned.
        /// If reseller administrator sends the request, resellerId is not specified, the administrator's resellerId is used.
        /// If neither excludeReseller nor resellerId is specified, all system level and reseller level tag sets are returned.
        /// 
        /// The response is either SystemDeviceManagementTagSetGetListResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceManagementTagSetGetListResponse22> SystemDeviceManagementTagSetGetListRequest22Async(this OcipClient client, SystemDeviceManagementTagSetGetListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceManagementTagSetGetListResponse22;
        }
        /// <summary>
        /// Request to modify a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementTagSetModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceManagementTagSetModifyRequest(this OcipClient client, SystemDeviceManagementTagSetModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementTagSetModifyRequestAsync(this OcipClient client, SystemDeviceManagementTagSetModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to clear all device password authentication lockouts in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceProfileAuthenticationLockoutClearAllRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceProfileAuthenticationLockoutClearAllRequest(this OcipClient client, SystemDeviceProfileAuthenticationLockoutClearAllRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to clear all device password authentication lockouts in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceProfileAuthenticationLockoutClearAllRequestAsync(this OcipClient client, SystemDeviceProfileAuthenticationLockoutClearAllRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to clear device profile authentication lockouts in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceProfileAuthenticationLockoutClearRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceProfileAuthenticationLockoutClearRequest(this OcipClient client, SystemDeviceProfileAuthenticationLockoutClearRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to clear device profile authentication lockouts in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceProfileAuthenticationLockoutClearRequestAsync(this OcipClient client, SystemDeviceProfileAuthenticationLockoutClearRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get device password authentication lockout data in the system.
        /// The response is either a SystemDeviceProfileAuthenticationLockoutGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceProfileAuthenticationLockoutGetRequestAsync instead.")]
        public static async Task<SystemDeviceProfileAuthenticationLockoutGetResponse> SystemDeviceProfileAuthenticationLockoutGetRequest(this OcipClient client, SystemDeviceProfileAuthenticationLockoutGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceProfileAuthenticationLockoutGetResponse;
        }

        /// <summary>
        /// Request to get device password authentication lockout data in the system.
        /// The response is either a SystemDeviceProfileAuthenticationLockoutGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceProfileAuthenticationLockoutGetResponse> SystemDeviceProfileAuthenticationLockoutGetRequestAsync(this OcipClient client, SystemDeviceProfileAuthenticationLockoutGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceProfileAuthenticationLockoutGetResponse;
        }
        /// <summary>
        /// Request to get the system level device profile authentication password rule settings.
        /// The response is either a SystemDeviceProfileAuthenticationPasswordRulesGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceProfileAuthenticationPasswordRulesGetRequestAsync instead.")]
        public static async Task<SystemDeviceProfileAuthenticationPasswordRulesGetResponse> SystemDeviceProfileAuthenticationPasswordRulesGetRequest(this OcipClient client, SystemDeviceProfileAuthenticationPasswordRulesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceProfileAuthenticationPasswordRulesGetResponse;
        }

        /// <summary>
        /// Request to get the system level device profile authentication password rule settings.
        /// The response is either a SystemDeviceProfileAuthenticationPasswordRulesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceProfileAuthenticationPasswordRulesGetResponse> SystemDeviceProfileAuthenticationPasswordRulesGetRequestAsync(this OcipClient client, SystemDeviceProfileAuthenticationPasswordRulesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceProfileAuthenticationPasswordRulesGetResponse;
        }
        /// <summary>
        /// Request to modify the system level device profile authentication password rule settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceProfileAuthenticationPasswordRulesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceProfileAuthenticationPasswordRulesModifyRequest(this OcipClient client, SystemDeviceProfileAuthenticationPasswordRulesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system level device profile authentication password rule settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceProfileAuthenticationPasswordRulesModifyRequestAsync(this OcipClient client, SystemDeviceProfileAuthenticationPasswordRulesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to export an existing Device Type to a Device Type Archive File (DTAF).
        /// The response is either a SystemDeviceTypeExportResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceTypeExportRequestAsync instead.")]
        public static async Task<SystemDeviceTypeExportResponse> SystemDeviceTypeExportRequest(this OcipClient client, SystemDeviceTypeExportRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceTypeExportResponse;
        }

        /// <summary>
        /// Request to export an existing Device Type to a Device Type Archive File (DTAF).
        /// The response is either a SystemDeviceTypeExportResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceTypeExportResponse> SystemDeviceTypeExportRequestAsync(this OcipClient client, SystemDeviceTypeExportRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceTypeExportResponse;
        }
        /// <summary>
        /// Requests a list of non-obsolete Identity/device profile types defined in the system and resellers. It is possible
        /// to get either all conference device types or all non-conference types. This command is similar
        /// to the SystemSIPDeviceTypeGetListRequest and SystemMGCPDeviceTypeGetListRequest
        /// but gets both SIP and MGCP types.
        /// If excludeReseller is specified, only system level available device types are returned.
        /// If resellerId is specified, all the system level available device types and the device types in the given reseller are returned.
        /// If reseller administrator sends the request, resellerId is not specified, the administrator's resellerId is used.
        /// If neither excludeReseller nor resellerId is specified, all the system level and reseller level available device types are returned.
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// resellerId
        /// 
        /// The response is either SystemDeviceTypeGetAvailableListResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceTypeGetAvailableListRequest22Async instead.")]
        public static async Task<SystemDeviceTypeGetAvailableListResponse22> SystemDeviceTypeGetAvailableListRequest22(this OcipClient client, SystemDeviceTypeGetAvailableListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceTypeGetAvailableListResponse22;
        }

        /// <summary>
        /// Requests a list of non-obsolete Identity/device profile types defined in the system and resellers. It is possible
        /// to get either all conference device types or all non-conference types. This command is similar
        /// to the SystemSIPDeviceTypeGetListRequest and SystemMGCPDeviceTypeGetListRequest
        /// but gets both SIP and MGCP types.
        /// If excludeReseller is specified, only system level available device types are returned.
        /// If resellerId is specified, all the system level available device types and the device types in the given reseller are returned.
        /// If reseller administrator sends the request, resellerId is not specified, the administrator's resellerId is used.
        /// If neither excludeReseller nor resellerId is specified, all the system level and reseller level available device types are returned.
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// resellerId
        /// 
        /// The response is either SystemDeviceTypeGetAvailableListResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceTypeGetAvailableListResponse22> SystemDeviceTypeGetAvailableListRequest22Async(this OcipClient client, SystemDeviceTypeGetAvailableListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceTypeGetAvailableListResponse22;
        }
        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse22 or ErrorResponse.
        /// Note: The elements deviceTypeConfigurationOption and staticLineOrdering apply to SIP device types only. Therefore, only present in the response when the device type is SIP.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceTypeGetRequest22Async instead.")]
        public static async Task<SystemDeviceTypeGetResponse22> SystemDeviceTypeGetRequest22(this OcipClient client, SystemDeviceTypeGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceTypeGetResponse22;
        }

        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse22 or ErrorResponse.
        /// Note: The elements deviceTypeConfigurationOption and staticLineOrdering apply to SIP device types only. Therefore, only present in the response when the device type is SIP.
        /// </summary>
        public static async Task<SystemDeviceTypeGetResponse22> SystemDeviceTypeGetRequest22Async(this OcipClient client, SystemDeviceTypeGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceTypeGetResponse22;
        }
        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse22V2 or ErrorResponse.
        /// Note: The elements deviceTypeConfigurationOption and staticLineOrdering apply to SIP device types only. Therefore, only present in the response when the device type is SIP.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceTypeGetRequest22V2Async instead.")]
        public static async Task<SystemDeviceTypeGetResponse22V2> SystemDeviceTypeGetRequest22V2(this OcipClient client, SystemDeviceTypeGetRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceTypeGetResponse22V2;
        }

        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse22V2 or ErrorResponse.
        /// Note: The elements deviceTypeConfigurationOption and staticLineOrdering apply to SIP device types only. Therefore, only present in the response when the device type is SIP.
        /// </summary>
        public static async Task<SystemDeviceTypeGetResponse22V2> SystemDeviceTypeGetRequest22V2Async(this OcipClient client, SystemDeviceTypeGetRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceTypeGetResponse22V2;
        }
        /// <summary>
        /// Request to import a Device Type Archive File (DTAF) as a new Device Type.  The URL supports the HTTP and the FILE protocols.
        /// When the optional element resellerId is specified, the device type created is at reseller level.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode and ignored in XS data mode:
        /// resellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceTypeImportRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDeviceTypeImportRequest(this OcipClient client, SystemDeviceTypeImportRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to import a Device Type Archive File (DTAF) as a new Device Type.  The URL supports the HTTP and the FILE protocols.
        /// When the optional element resellerId is specified, the device type created is at reseller level.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode and ignored in XS data mode:
        /// resellerId
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceTypeImportRequestAsync(this OcipClient client, SystemDeviceTypeImportRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Dialable Caller ID Criteria. Criteria are added at the bottom of the list with the lowest priority. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialableCallerIDCriteriaAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDialableCallerIDCriteriaAddRequest(this OcipClient client, SystemDialableCallerIDCriteriaAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Dialable Caller ID Criteria. Criteria are added at the bottom of the list with the lowest priority. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDialableCallerIDCriteriaAddRequestAsync(this OcipClient client, SystemDialableCallerIDCriteriaAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Dialable Caller ID Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialableCallerIDCriteriaDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDialableCallerIDCriteriaDeleteRequest(this OcipClient client, SystemDialableCallerIDCriteriaDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Dialable Caller ID Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDialableCallerIDCriteriaDeleteRequestAsync(this OcipClient client, SystemDialableCallerIDCriteriaDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get an existing Dialable Caller ID Criteria.
        /// The response is either a SystemDialableCallerIDCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialableCallerIDCriteriaGetRequestAsync instead.")]
        public static async Task<SystemDialableCallerIDCriteriaGetResponse> SystemDialableCallerIDCriteriaGetRequest(this OcipClient client, SystemDialableCallerIDCriteriaGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDialableCallerIDCriteriaGetResponse;
        }

        /// <summary>
        /// Get an existing Dialable Caller ID Criteria.
        /// The response is either a SystemDialableCallerIDCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDialableCallerIDCriteriaGetResponse> SystemDialableCallerIDCriteriaGetRequestAsync(this OcipClient client, SystemDialableCallerIDCriteriaGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDialableCallerIDCriteriaGetResponse;
        }
        /// <summary>
        /// Modify a Dialable Caller ID Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialableCallerIDCriteriaModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDialableCallerIDCriteriaModifyRequest(this OcipClient client, SystemDialableCallerIDCriteriaModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Dialable Caller ID Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDialableCallerIDCriteriaModifyRequestAsync(this OcipClient client, SystemDialableCallerIDCriteriaModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the system level Dialable Caller ID criteria list.
        /// The response is either a SystemDialableCallerIDGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialableCallerIDGetRequestAsync instead.")]
        public static async Task<SystemDialableCallerIDGetResponse> SystemDialableCallerIDGetRequest(this OcipClient client, SystemDialableCallerIDGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDialableCallerIDGetResponse;
        }

        /// <summary>
        /// Get the system level Dialable Caller ID criteria list.
        /// The response is either a SystemDialableCallerIDGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDialableCallerIDGetResponse> SystemDialableCallerIDGetRequestAsync(this OcipClient client, SystemDialableCallerIDGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDialableCallerIDGetResponse;
        }
        /// <summary>
        /// Modify the system level Dialable Caller ID criteria list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialableCallerIDModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDialableCallerIDModifyRequest(this OcipClient client, SystemDialableCallerIDModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level Dialable Caller ID criteria list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDialableCallerIDModifyRequestAsync(this OcipClient client, SystemDialableCallerIDModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a system-level Dial Plan Access Code and its all attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialPlanPolicyAddAccessCodeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDialPlanPolicyAddAccessCodeRequest(this OcipClient client, SystemDialPlanPolicyAddAccessCodeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a system-level Dial Plan Access Code and its all attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDialPlanPolicyAddAccessCodeRequestAsync(this OcipClient client, SystemDialPlanPolicyAddAccessCodeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a system-level Dial Plan Access Code and its all attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialPlanPolicyDeleteAccessCodeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDialPlanPolicyDeleteAccessCodeRequest(this OcipClient client, SystemDialPlanPolicyDeleteAccessCodeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a system-level Dial Plan Access Code and its all attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDialPlanPolicyDeleteAccessCodeRequestAsync(this OcipClient client, SystemDialPlanPolicyDeleteAccessCodeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level Access Codes data associated with Dial Plan Policy.
        /// The response is either a SystemDialPlanPolicyGetAccessCodeListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialPlanPolicyGetAccessCodeListRequestAsync instead.")]
        public static async Task<SystemDialPlanPolicyGetAccessCodeListResponse> SystemDialPlanPolicyGetAccessCodeListRequest(this OcipClient client, SystemDialPlanPolicyGetAccessCodeListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDialPlanPolicyGetAccessCodeListResponse;
        }

        /// <summary>
        /// Request the system level Access Codes data associated with Dial Plan Policy.
        /// The response is either a SystemDialPlanPolicyGetAccessCodeListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDialPlanPolicyGetAccessCodeListResponse> SystemDialPlanPolicyGetAccessCodeListRequestAsync(this OcipClient client, SystemDialPlanPolicyGetAccessCodeListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDialPlanPolicyGetAccessCodeListResponse;
        }
        /// <summary>
        /// Request access code data associated with system level Dial Plan Policy access codes.
        /// The response is either a SystemDialPlanPolicyGetAccessCodeResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialPlanPolicyGetAccessCodeRequestAsync instead.")]
        public static async Task<SystemDialPlanPolicyGetAccessCodeResponse> SystemDialPlanPolicyGetAccessCodeRequest(this OcipClient client, SystemDialPlanPolicyGetAccessCodeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDialPlanPolicyGetAccessCodeResponse;
        }

        /// <summary>
        /// Request access code data associated with system level Dial Plan Policy access codes.
        /// The response is either a SystemDialPlanPolicyGetAccessCodeResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDialPlanPolicyGetAccessCodeResponse> SystemDialPlanPolicyGetAccessCodeRequestAsync(this OcipClient client, SystemDialPlanPolicyGetAccessCodeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDialPlanPolicyGetAccessCodeResponse;
        }
        /// <summary>
        /// Request the system level data associated with Dial Plan Policy.
        /// The response is either a SystemDialPlanPolicyGetResponse17 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialPlanPolicyGetRequest17Async instead.")]
        public static async Task<SystemDialPlanPolicyGetResponse17> SystemDialPlanPolicyGetRequest17(this OcipClient client, SystemDialPlanPolicyGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDialPlanPolicyGetResponse17;
        }

        /// <summary>
        /// Request the system level data associated with Dial Plan Policy.
        /// The response is either a SystemDialPlanPolicyGetResponse17 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemDialPlanPolicyGetResponse17> SystemDialPlanPolicyGetRequest17Async(this OcipClient client, SystemDialPlanPolicyGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDialPlanPolicyGetResponse17;
        }
        /// <summary>
        /// Request to modify a system-level Dial Plan Access Code and its attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialPlanPolicyModifyAccessCodeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDialPlanPolicyModifyAccessCodeRequest(this OcipClient client, SystemDialPlanPolicyModifyAccessCodeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a system-level Dial Plan Access Code and its attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDialPlanPolicyModifyAccessCodeRequestAsync(this OcipClient client, SystemDialPlanPolicyModifyAccessCodeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Dial Plan Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialPlanPolicyModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDialPlanPolicyModifyRequest(this OcipClient client, SystemDialPlanPolicyModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Dial Plan Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDialPlanPolicyModifyRequestAsync(this OcipClient client, SystemDialPlanPolicyModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system's digit collection attributes.
        /// The response is either a SystemDigitCollectionGetResponse13mp4 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDigitCollectionGetRequest13mp4Async instead.")]
        public static async Task<SystemDigitCollectionGetResponse13mp4> SystemDigitCollectionGetRequest13mp4(this OcipClient client, SystemDigitCollectionGetRequest13mp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDigitCollectionGetResponse13mp4;
        }

        /// <summary>
        /// Request the system's digit collection attributes.
        /// The response is either a SystemDigitCollectionGetResponse13mp4 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemDigitCollectionGetResponse13mp4> SystemDigitCollectionGetRequest13mp4Async(this OcipClient client, SystemDigitCollectionGetRequest13mp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDigitCollectionGetResponse13mp4;
        }
        /// <summary>
        /// Modifies the system's digit collection attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDigitCollectionModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDigitCollectionModifyRequest(this OcipClient client, SystemDigitCollectionModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the system's digit collection attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDigitCollectionModifyRequestAsync(this OcipClient client, SystemDigitCollectionModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a summary table of all DNs in the system. If resellerId is specified,
        /// the DNs assigned to the enterprises/service providers within the reseller are returned.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// The search can be done using multiple criteria. Only results matching all the search criteria are included in the results.
        /// 
        /// The response is either SystemDnGetSummaryListResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// resellerId
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaDn, searchCriteriaServiceProviderId, searchCriteriaExactOrganizationType
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDnGetSummaryListRequestAsync instead.")]
        public static async Task<SystemDnGetSummaryListResponse> SystemDnGetSummaryListRequest(this OcipClient client, SystemDnGetSummaryListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDnGetSummaryListResponse;
        }

        /// <summary>
        /// Request a summary table of all DNs in the system. If resellerId is specified,
        /// the DNs assigned to the enterprises/service providers within the reseller are returned.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// The search can be done using multiple criteria. Only results matching all the search criteria are included in the results.
        /// 
        /// The response is either SystemDnGetSummaryListResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// resellerId
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaDn, searchCriteriaServiceProviderId, searchCriteriaExactOrganizationType
        /// </summary>
        public static async Task<SystemDnGetSummaryListResponse> SystemDnGetSummaryListRequestAsync(this OcipClient client, SystemDnGetSummaryListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDnGetSummaryListResponse;
        }
        /// <summary>
        /// Request a list of DN utilizations by service providers. If resellerId is specified,
        /// the DNs assigned to the enterprises/service providers within the reseller are returned.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemDnGetUtilizationListResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// resellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDnGetUtilizationListRequestAsync instead.")]
        public static async Task<SystemDnGetUtilizationListResponse> SystemDnGetUtilizationListRequest(this OcipClient client, SystemDnGetUtilizationListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDnGetUtilizationListResponse;
        }

        /// <summary>
        /// Request a list of DN utilizations by service providers. If resellerId is specified,
        /// the DNs assigned to the enterprises/service providers within the reseller are returned.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemDnGetUtilizationListResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// resellerId
        /// </summary>
        public static async Task<SystemDnGetUtilizationListResponse> SystemDnGetUtilizationListRequestAsync(this OcipClient client, SystemDnGetUtilizationListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDnGetUtilizationListResponse;
        }
        /// <summary>
        /// Get the utilization of a single DN.
        /// The response is either SystemDnGetUtilizationResponse14sp3 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDnGetUtilizationRequest14sp3Async instead.")]
        public static async Task<SystemDnGetUtilizationResponse14sp3> SystemDnGetUtilizationRequest14sp3(this OcipClient client, SystemDnGetUtilizationRequest14sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDnGetUtilizationResponse14sp3;
        }

        /// <summary>
        /// Get the utilization of a single DN.
        /// The response is either SystemDnGetUtilizationResponse14sp3 or ErrorResponse.
        /// </summary>
        public static async Task<SystemDnGetUtilizationResponse14sp3> SystemDnGetUtilizationRequest14sp3Async(this OcipClient client, SystemDnGetUtilizationRequest14sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDnGetUtilizationResponse14sp3;
        }
        /// <summary>
        /// Add a system or reseller domain to the system.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDomainAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDomainAddRequest(this OcipClient client, SystemDomainAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a system or reseller domain to the system.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDomainAddRequestAsync(this OcipClient client, SystemDomainAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a system domain from the system.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDomainDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDomainDeleteRequest(this OcipClient client, SystemDomainDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a system domain from the system.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDomainDeleteRequestAsync(this OcipClient client, SystemDomainDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a list of service providers that have a given domain assigned.
        /// If resellerId is specified, only the service providers within the reseller should be returned.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemDomainGetAssignedServiceProviderListResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// resellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDomainGetAssignedServiceProviderListRequestAsync instead.")]
        public static async Task<SystemDomainGetAssignedServiceProviderListResponse> SystemDomainGetAssignedServiceProviderListRequest(this OcipClient client, SystemDomainGetAssignedServiceProviderListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDomainGetAssignedServiceProviderListResponse;
        }

        /// <summary>
        /// Request a list of service providers that have a given domain assigned.
        /// If resellerId is specified, only the service providers within the reseller should be returned.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemDomainGetAssignedServiceProviderListResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// resellerId
        /// </summary>
        public static async Task<SystemDomainGetAssignedServiceProviderListResponse> SystemDomainGetAssignedServiceProviderListRequestAsync(this OcipClient client, SystemDomainGetAssignedServiceProviderListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDomainGetAssignedServiceProviderListResponse;
        }
        /// <summary>
        /// Requests the list of all system-level domains and all reseller level domains.
        /// If excludeReseller is specified, returns all the system-level domain names only.
        /// If resellerId is specified, returns all the system-level domain names and the given reseller's domains.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemDomainGetListResponse22 or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// includeReseller
        /// resellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDomainGetListRequest22Async instead.")]
        public static async Task<SystemDomainGetListResponse22> SystemDomainGetListRequest22(this OcipClient client, SystemDomainGetListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDomainGetListResponse22;
        }

        /// <summary>
        /// Requests the list of all system-level domains and all reseller level domains.
        /// If excludeReseller is specified, returns all the system-level domain names only.
        /// If resellerId is specified, returns all the system-level domain names and the given reseller's domains.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemDomainGetListResponse22 or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// includeReseller
        /// resellerId
        /// </summary>
        public static async Task<SystemDomainGetListResponse22> SystemDomainGetListRequest22Async(this OcipClient client, SystemDomainGetListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDomainGetListResponse22;
        }
        /// <summary>
        /// Requests the list of all matching system-level domains and all matching reseller level domains.
        /// If excludeReseller is specified, returns all matching system-level domain names only.
        /// If resellerId is specified, returns all matching system-level domain names and the given reseller's domains.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemDomainGetListResponse22V2 or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and will be ignored in XS data mode:
        /// includeReseller
        /// resellerId
        /// responseSizeLimit
        /// searchCriteriaDomainName
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDomainGetListRequest22V2Async instead.")]
        public static async Task<SystemDomainGetListResponse22V2> SystemDomainGetListRequest22V2(this OcipClient client, SystemDomainGetListRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDomainGetListResponse22V2;
        }

        /// <summary>
        /// Requests the list of all matching system-level domains and all matching reseller level domains.
        /// If excludeReseller is specified, returns all matching system-level domain names only.
        /// If resellerId is specified, returns all matching system-level domain names and the given reseller's domains.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemDomainGetListResponse22V2 or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and will be ignored in XS data mode:
        /// includeReseller
        /// resellerId
        /// responseSizeLimit
        /// searchCriteriaDomainName
        /// </summary>
        public static async Task<SystemDomainGetListResponse22V2> SystemDomainGetListRequest22V2Async(this OcipClient client, SystemDomainGetListRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDomainGetListResponse22V2;
        }
        /// <summary>
        /// Request to get the list of system Domain parameters.
        /// The response is either SystemDomainParametersGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDomainParametersGetRequestAsync instead.")]
        public static async Task<SystemDomainParametersGetResponse> SystemDomainParametersGetRequest(this OcipClient client, SystemDomainParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDomainParametersGetResponse;
        }

        /// <summary>
        /// Request to get the list of system Domain parameters.
        /// The response is either SystemDomainParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemDomainParametersGetResponse> SystemDomainParametersGetRequestAsync(this OcipClient client, SystemDomainParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDomainParametersGetResponse;
        }
        /// <summary>
        /// Request to modify system Domain parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useAliasForDomain
        /// 
        /// The following elements are only used in AS and XS data mode and ignored in Amplify data mode:
        /// defaultDomain
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDomainParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDomainParametersModifyRequest(this OcipClient client, SystemDomainParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify system Domain parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useAliasForDomain
        /// 
        /// The following elements are only used in AS and XS data mode and ignored in Amplify data mode:
        /// defaultDomain
        /// </summary>
        public static async Task<SuccessResponse> SystemDomainParametersModifyRequestAsync(this OcipClient client, SystemDomainParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the system DTMF transmission configurations.
        /// The response is either SystemDTMFTransmissionGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDTMFTransmissionGetRequestAsync instead.")]
        public static async Task<SystemDTMFTransmissionGetResponse> SystemDTMFTransmissionGetRequest(this OcipClient client, SystemDTMFTransmissionGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDTMFTransmissionGetResponse;
        }

        /// <summary>
        /// Get the system DTMF transmission configurations.
        /// The response is either SystemDTMFTransmissionGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemDTMFTransmissionGetResponse> SystemDTMFTransmissionGetRequestAsync(this OcipClient client, SystemDTMFTransmissionGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDTMFTransmissionGetResponse;
        }
        /// <summary>
        /// Modify the DTMF transmission settings.
        /// The response is either SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDTMFTransmissionModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemDTMFTransmissionModifyRequest(this OcipClient client, SystemDTMFTransmissionModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the DTMF transmission settings.
        /// The response is either SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemDTMFTransmissionModifyRequestAsync(this OcipClient client, SystemDTMFTransmissionModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the system Emergency Call DDos Protection configurations.
        /// The response is either SystemEmergencyCallDDoSProtectionGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEmergencyCallDDoSProtectionGetRequestAsync instead.")]
        public static async Task<SystemEmergencyCallDDoSProtectionGetResponse> SystemEmergencyCallDDoSProtectionGetRequest(this OcipClient client, SystemEmergencyCallDDoSProtectionGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemEmergencyCallDDoSProtectionGetResponse;
        }

        /// <summary>
        /// Get the system Emergency Call DDos Protection configurations.
        /// The response is either SystemEmergencyCallDDoSProtectionGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemEmergencyCallDDoSProtectionGetResponse> SystemEmergencyCallDDoSProtectionGetRequestAsync(this OcipClient client, SystemEmergencyCallDDoSProtectionGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemEmergencyCallDDoSProtectionGetResponse;
        }
        /// <summary>
        /// Modify the Emergency Call DDos Protection settings.
        /// The response is either SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEmergencyCallDDoSProtectionModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemEmergencyCallDDoSProtectionModifyRequest(this OcipClient client, SystemEmergencyCallDDoSProtectionModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Emergency Call DDos Protection settings.
        /// The response is either SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemEmergencyCallDDoSProtectionModifyRequestAsync(this OcipClient client, SystemEmergencyCallDDoSProtectionModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with Emergency Call Notification.
        /// The response is either a SystemEmergencyCallNotificationGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEmergencyCallNotificationGetRequestAsync instead.")]
        public static async Task<SystemEmergencyCallNotificationGetResponse> SystemEmergencyCallNotificationGetRequest(this OcipClient client, SystemEmergencyCallNotificationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemEmergencyCallNotificationGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Emergency Call Notification.
        /// The response is either a SystemEmergencyCallNotificationGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemEmergencyCallNotificationGetResponse> SystemEmergencyCallNotificationGetRequestAsync(this OcipClient client, SystemEmergencyCallNotificationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemEmergencyCallNotificationGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Emergency Call Notification.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEmergencyCallNotificationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemEmergencyCallNotificationModifyRequest(this OcipClient client, SystemEmergencyCallNotificationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Emergency Call Notification.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemEmergencyCallNotificationModifyRequestAsync(this OcipClient client, SystemEmergencyCallNotificationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to search endpoints in the system.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All endpoints
        /// in the administrator's reseller meeting the search criteria are returned.
        /// 
        /// The response is either SystemEndpointGetListResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEndpointGetListRequestAsync instead.")]
        public static async Task<SystemEndpointGetListResponse> SystemEndpointGetListRequest(this OcipClient client, SystemEndpointGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemEndpointGetListResponse;
        }

        /// <summary>
        /// Request to search endpoints in the system.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All endpoints
        /// in the administrator's reseller meeting the search criteria are returned.
        /// 
        /// The response is either SystemEndpointGetListResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        public static async Task<SystemEndpointGetListResponse> SystemEndpointGetListRequestAsync(this OcipClient client, SystemEndpointGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemEndpointGetListResponse;
        }
        /// <summary>
        /// Request to get the expensive call notification service parameters.
        /// The response is either a SystemExpensiveCallNotificationGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExpensiveCallNotificationGetRequestAsync instead.")]
        public static async Task<SystemExpensiveCallNotificationGetResponse> SystemExpensiveCallNotificationGetRequest(this OcipClient client, SystemExpensiveCallNotificationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemExpensiveCallNotificationGetResponse;
        }

        /// <summary>
        /// Request to get the expensive call notification service parameters.
        /// The response is either a SystemExpensiveCallNotificationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemExpensiveCallNotificationGetResponse> SystemExpensiveCallNotificationGetRequestAsync(this OcipClient client, SystemExpensiveCallNotificationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemExpensiveCallNotificationGetResponse;
        }
        /// <summary>
        /// Modify the expensive call notification service parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExpensiveCallNotificationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemExpensiveCallNotificationModifyRequest(this OcipClient client, SystemExpensiveCallNotificationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the expensive call notification service parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExpensiveCallNotificationModifyRequestAsync(this OcipClient client, SystemExpensiveCallNotificationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an alternate call indicator to the list of expensive alternate call indicators.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExpensiveCallTypeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemExpensiveCallTypeAddRequest(this OcipClient client, SystemExpensiveCallTypeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an alternate call indicator to the list of expensive alternate call indicators.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExpensiveCallTypeAddRequestAsync(this OcipClient client, SystemExpensiveCallTypeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an alternate call indicator from the list of expensive alternate call indicators.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExpensiveCallTypeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemExpensiveCallTypeDeleteRequest(this OcipClient client, SystemExpensiveCallTypeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an alternate call indicator from the list of expensive alternate call indicators.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExpensiveCallTypeDeleteRequestAsync(this OcipClient client, SystemExpensiveCallTypeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of expensive alternate call indicators in the system.
        /// The response is either a SystemExpensiveCallTypeGetListResponse16sp1
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExpensiveCallTypeGetListRequest16sp1Async instead.")]
        public static async Task<SystemExpensiveCallTypeGetListResponse16sp1> SystemExpensiveCallTypeGetListRequest16sp1(this OcipClient client, SystemExpensiveCallTypeGetListRequest16sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemExpensiveCallTypeGetListResponse16sp1;
        }

        /// <summary>
        /// Request to get the list of expensive alternate call indicators in the system.
        /// The response is either a SystemExpensiveCallTypeGetListResponse16sp1
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemExpensiveCallTypeGetListResponse16sp1> SystemExpensiveCallTypeGetListRequest16sp1Async(this OcipClient client, SystemExpensiveCallTypeGetListRequest16sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemExpensiveCallTypeGetListResponse16sp1;
        }
        /// <summary>
        /// Modify an existing call indicator in the list of expensive alternate call indicators.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExpensiveCallTypeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemExpensiveCallTypeModifyRequest(this OcipClient client, SystemExpensiveCallTypeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing call indicator in the list of expensive alternate call indicators.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExpensiveCallTypeModifyRequestAsync(this OcipClient client, SystemExpensiveCallTypeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to export Application Server addressing data, such as DNs, extensions, alias and user ids
        /// to a file so they can be uploaded to a Network Server.
        /// In XS data mode, response is sent without waiting for completion.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExportAddressingDataRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemExportAddressingDataRequest(this OcipClient client, SystemExportAddressingDataRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to export Application Server addressing data, such as DNs, extensions, alias and user ids
        /// to a file so they can be uploaded to a Network Server.
        /// In XS data mode, response is sent without waiting for completion.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExportAddressingDataRequestAsync(this OcipClient client, SystemExportAddressingDataRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to export all users that have BroadCloud services, such as
        /// user profile information and BroadCloud services related information for that user
        /// to a file so they can be uploaded to a Messaging Server/BroadCloud.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExportBroadCloudDataRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemExportBroadCloudDataRequest(this OcipClient client, SystemExportBroadCloudDataRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to export all users that have BroadCloud services, such as
        /// user profile information and BroadCloud services related information for that user
        /// to a file so they can be uploaded to a Messaging Server/BroadCloud.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExportBroadCloudDataRequestAsync(this OcipClient client, SystemExportBroadCloudDataRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request subscribers be exported to files on the AS filesystem.
        /// The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// 
        /// ***** Warning *****:
        /// This activity should only be done during non-busy hours on the secondary
        /// provisioning server because this may cause large amounts of data to be
        /// dumped to disk and it may take some time to execute.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExportSubscriberRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemExportSubscriberRequest(this OcipClient client, SystemExportSubscriberRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request subscribers be exported to files on the AS filesystem.
        /// The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// 
        /// ***** Warning *****:
        /// This activity should only be done during non-busy hours on the secondary
        /// provisioning server because this may cause large amounts of data to be
        /// dumped to disk and it may take some time to execute.
        /// </summary>
        public static async Task<SuccessResponse> SystemExportSubscriberRequestAsync(this OcipClient client, SystemExportSubscriberRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system's extension range.
        /// The response is either a SystemExtensionLengthGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExtensionLengthGetRequestAsync instead.")]
        public static async Task<SystemExtensionLengthGetResponse> SystemExtensionLengthGetRequest(this OcipClient client, SystemExtensionLengthGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemExtensionLengthGetResponse;
        }

        /// <summary>
        /// Request the system's extension range.
        /// The response is either a SystemExtensionLengthGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemExtensionLengthGetResponse> SystemExtensionLengthGetRequestAsync(this OcipClient client, SystemExtensionLengthGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemExtensionLengthGetResponse;
        }
        /// <summary>
        /// Modify the group's extension length range.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExtensionLengthModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemExtensionLengthModifyRequest(this OcipClient client, SystemExtensionLengthModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group's extension length range.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExtensionLengthModifyRequestAsync(this OcipClient client, SystemExtensionLengthModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an entry to the external authentication access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExternalAuthenticationAddACLEntryRequest14sp2Async instead.")]
        public static async Task<SuccessResponse> SystemExternalAuthenticationAddACLEntryRequest14sp2(this OcipClient client, SystemExternalAuthenticationAddACLEntryRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an entry to the external authentication access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExternalAuthenticationAddACLEntryRequest14sp2Async(this OcipClient client, SystemExternalAuthenticationAddACLEntryRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an entry from the external authentication access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExternalAuthenticationDeleteACLEntryRequest14sp2Async instead.")]
        public static async Task<SuccessResponse> SystemExternalAuthenticationDeleteACLEntryRequest14sp2(this OcipClient client, SystemExternalAuthenticationDeleteACLEntryRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry from the external authentication access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExternalAuthenticationDeleteACLEntryRequest14sp2Async(this OcipClient client, SystemExternalAuthenticationDeleteACLEntryRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the external authentication access control list.
        /// The response is either SystemExternalAuthenticationGetACLListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExternalAuthenticationGetACLListRequestAsync instead.")]
        public static async Task<SystemExternalAuthenticationGetACLListResponse> SystemExternalAuthenticationGetACLListRequest(this OcipClient client, SystemExternalAuthenticationGetACLListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemExternalAuthenticationGetACLListResponse;
        }

        /// <summary>
        /// Get the external authentication access control list.
        /// The response is either SystemExternalAuthenticationGetACLListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemExternalAuthenticationGetACLListResponse> SystemExternalAuthenticationGetACLListRequestAsync(this OcipClient client, SystemExternalAuthenticationGetACLListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemExternalAuthenticationGetACLListResponse;
        }
        /// <summary>
        /// Modify an entry from the external authentication access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExternalAuthenticationModifyACLEntryRequest14sp2Async instead.")]
        public static async Task<SuccessResponse> SystemExternalAuthenticationModifyACLEntryRequest14sp2(this OcipClient client, SystemExternalAuthenticationModifyACLEntryRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an entry from the external authentication access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExternalAuthenticationModifyACLEntryRequest14sp2Async(this OcipClient client, SystemExternalAuthenticationModifyACLEntryRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of External Emergency Routing system parameters.
        /// The response is either SystemExternalEmergencyRoutingParametersGetResponse13mp13 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExternalEmergencyRoutingParametersGetRequest13mp13Async instead.")]
        public static async Task<SystemExternalEmergencyRoutingParametersGetResponse13mp13> SystemExternalEmergencyRoutingParametersGetRequest13mp13(this OcipClient client, SystemExternalEmergencyRoutingParametersGetRequest13mp13 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemExternalEmergencyRoutingParametersGetResponse13mp13;
        }

        /// <summary>
        /// Request to get the list of External Emergency Routing system parameters.
        /// The response is either SystemExternalEmergencyRoutingParametersGetResponse13mp13 or ErrorResponse.
        /// </summary>
        public static async Task<SystemExternalEmergencyRoutingParametersGetResponse13mp13> SystemExternalEmergencyRoutingParametersGetRequest13mp13Async(this OcipClient client, SystemExternalEmergencyRoutingParametersGetRequest13mp13 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemExternalEmergencyRoutingParametersGetResponse13mp13;
        }
        /// <summary>
        /// Request to modify Call External Emergency Routing system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExternalEmergencyRoutingParametersModifyRequest13mp13Async instead.")]
        public static async Task<SuccessResponse> SystemExternalEmergencyRoutingParametersModifyRequest13mp13(this OcipClient client, SystemExternalEmergencyRoutingParametersModifyRequest13mp13 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Call External Emergency Routing system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExternalEmergencyRoutingParametersModifyRequest13mp13Async(this OcipClient client, SystemExternalEmergencyRoutingParametersModifyRequest13mp13 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get list of default Feature Access Codes defined on system
        /// level.
        /// The response is either SystemFeatureAccessCodeGetListResponse20 or
        /// ErrorResponse.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFeatureAccessCodeGetListRequest21Async instead.")]
        public static async Task<SystemFeatureAccessCodeGetListResponse20> SystemFeatureAccessCodeGetListRequest21(this OcipClient client, SystemFeatureAccessCodeGetListRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemFeatureAccessCodeGetListResponse20;
        }

        /// <summary>
        /// Request to get list of default Feature Access Codes defined on system
        /// level.
        /// The response is either SystemFeatureAccessCodeGetListResponse20 or
        /// ErrorResponse.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// </summary>
        public static async Task<SystemFeatureAccessCodeGetListResponse20> SystemFeatureAccessCodeGetListRequest21Async(this OcipClient client, SystemFeatureAccessCodeGetListRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemFeatureAccessCodeGetListResponse20;
        }
        /// <summary>
        /// Modify default Feature Access Codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFeatureAccessCodeModifyListRequest21Async instead.")]
        public static async Task<SuccessResponse> SystemFeatureAccessCodeModifyListRequest21(this OcipClient client, SystemFeatureAccessCodeModifyListRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify default Feature Access Codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// </summary>
        public static async Task<SuccessResponse> SystemFeatureAccessCodeModifyListRequest21Async(this OcipClient client, SystemFeatureAccessCodeModifyListRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the contents of a file.  This transaction is only allowed to get content for files under
        /// /var/broadworks/userfiles/AuditLogs/ or /var/broadworks/IpDeviceConfig/.
        /// The response is either a SystemFileGetContentResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileGetContentRequestAsync instead.")]
        public static async Task<SystemFileGetContentResponse> SystemFileGetContentRequest(this OcipClient client, SystemFileGetContentRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemFileGetContentResponse;
        }

        /// <summary>
        /// Requests the contents of a file.  This transaction is only allowed to get content for files under
        /// /var/broadworks/userfiles/AuditLogs/ or /var/broadworks/IpDeviceConfig/.
        /// The response is either a SystemFileGetContentResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemFileGetContentResponse> SystemFileGetContentRequestAsync(this OcipClient client, SystemFileGetContentRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemFileGetContentResponse;
        }
        /// <summary>
        /// Add a new file repository.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceAddRequest20Async instead.")]
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceAddRequest20(this OcipClient client, SystemFileRepositoryDeviceAddRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new file repository.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceAddRequest20Async(this OcipClient client, SystemFileRepositoryDeviceAddRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a file repository.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceDeleteRequest(this OcipClient client, SystemFileRepositoryDeviceDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a file repository.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceDeleteRequestAsync(this OcipClient client, SystemFileRepositoryDeviceDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of file repositories in the system.
        /// The response is either a SystemFileRepositoryDeviceGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceGetListRequestAsync instead.")]
        public static async Task<SystemFileRepositoryDeviceGetListResponse> SystemFileRepositoryDeviceGetListRequest(this OcipClient client, SystemFileRepositoryDeviceGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemFileRepositoryDeviceGetListResponse;
        }

        /// <summary>
        /// Request the list of file repositories in the system.
        /// The response is either a SystemFileRepositoryDeviceGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemFileRepositoryDeviceGetListResponse> SystemFileRepositoryDeviceGetListRequestAsync(this OcipClient client, SystemFileRepositoryDeviceGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemFileRepositoryDeviceGetListResponse;
        }
        /// <summary>
        /// Request to get the file repository information.  The response is either SystemFileRepositoryDeviceGetResponse20 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceGetRequest20Async instead.")]
        public static async Task<SystemFileRepositoryDeviceGetResponse20> SystemFileRepositoryDeviceGetRequest20(this OcipClient client, SystemFileRepositoryDeviceGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemFileRepositoryDeviceGetResponse20;
        }

        /// <summary>
        /// Request to get the file repository information.  The response is either SystemFileRepositoryDeviceGetResponse20 or ErrorResponse.
        /// </summary>
        public static async Task<SystemFileRepositoryDeviceGetResponse20> SystemFileRepositoryDeviceGetRequest20Async(this OcipClient client, SystemFileRepositoryDeviceGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemFileRepositoryDeviceGetResponse20;
        }
        /// <summary>
        /// Modify a file repository.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceModifyRequest(this OcipClient client, SystemFileRepositoryDeviceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a file repository.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceModifyRequestAsync(this OcipClient client, SystemFileRepositoryDeviceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the file repository information.  The response is either SystemFileRepositoryDeviceGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceGetRequest22Async instead.")]
        public static async Task<SystemFileRepositoryDeviceGetResponse22> SystemFileRepositoryDeviceGetRequest22(this OcipClient client, SystemFileRepositoryDeviceGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemFileRepositoryDeviceGetResponse22;
        }

        /// <summary>
        /// Request to get the file repository information.  The response is either SystemFileRepositoryDeviceGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemFileRepositoryDeviceGetResponse22> SystemFileRepositoryDeviceGetRequest22Async(this OcipClient client, SystemFileRepositoryDeviceGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemFileRepositoryDeviceGetResponse22;
        }
        /// <summary>
        /// Modify a file repository.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceModifyRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceModifyRequest22(this OcipClient client, SystemFileRepositoryDeviceModifyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a file repository.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceModifyRequest22Async(this OcipClient client, SystemFileRepositoryDeviceModifyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceUserAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceUserAddRequest(this OcipClient client, SystemFileRepositoryDeviceUserAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceUserAddRequestAsync(this OcipClient client, SystemFileRepositoryDeviceUserAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceUserDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceUserDeleteRequest(this OcipClient client, SystemFileRepositoryDeviceUserDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceUserDeleteRequestAsync(this OcipClient client, SystemFileRepositoryDeviceUserDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of users for a file repository in the system.
        /// The response is either a SystemFileRepositoryDeviceUserGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceUserGetListRequestAsync instead.")]
        public static async Task<SystemFileRepositoryDeviceUserGetListResponse> SystemFileRepositoryDeviceUserGetListRequest(this OcipClient client, SystemFileRepositoryDeviceUserGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemFileRepositoryDeviceUserGetListResponse;
        }

        /// <summary>
        /// Request the list of users for a file repository in the system.
        /// The response is either a SystemFileRepositoryDeviceUserGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemFileRepositoryDeviceUserGetListResponse> SystemFileRepositoryDeviceUserGetListRequestAsync(this OcipClient client, SystemFileRepositoryDeviceUserGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemFileRepositoryDeviceUserGetListResponse;
        }
        /// <summary>
        /// Request a user of a file repository in the system.
        /// The response is either a SystemFileRepositoryDeviceUserGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceUserGetRequestAsync instead.")]
        public static async Task<SystemFileRepositoryDeviceUserGetResponse> SystemFileRepositoryDeviceUserGetRequest(this OcipClient client, SystemFileRepositoryDeviceUserGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemFileRepositoryDeviceUserGetResponse;
        }

        /// <summary>
        /// Request a user of a file repository in the system.
        /// The response is either a SystemFileRepositoryDeviceUserGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemFileRepositoryDeviceUserGetResponse> SystemFileRepositoryDeviceUserGetRequestAsync(this OcipClient client, SystemFileRepositoryDeviceUserGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemFileRepositoryDeviceUserGetResponse;
        }
        /// <summary>
        /// Modify a file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFileRepositoryDeviceUserModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceUserModifyRequest(this OcipClient client, SystemFileRepositoryDeviceUserModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceUserModifyRequestAsync(this OcipClient client, SystemFileRepositoryDeviceUserModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Peer SIP Connection system parameters
        /// The response is a SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGeographicRedundancyPeerSipConnectionMonitoringGetRequestAsync instead.")]
        public static async Task<SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse> SystemGeographicRedundancyPeerSipConnectionMonitoringGetRequest(this OcipClient client, SystemGeographicRedundancyPeerSipConnectionMonitoringGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse;
        }

        /// <summary>
        /// Request to get the list of Peer SIP Connection system parameters
        /// The response is a SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse.
        /// </summary>
        public static async Task<SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse> SystemGeographicRedundancyPeerSipConnectionMonitoringGetRequestAsync(this OcipClient client, SystemGeographicRedundancyPeerSipConnectionMonitoringGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse;
        }
        /// <summary>
        /// Modify the list of Peer SIP Connection Monitoring system parameters
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGeographicRedundancyPeerSipConnectionMonitoringModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGeographicRedundancyPeerSipConnectionMonitoringModifyRequest(this OcipClient client, SystemGeographicRedundancyPeerSipConnectionMonitoringModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the list of Peer SIP Connection Monitoring system parameters
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGeographicRedundancyPeerSipConnectionMonitoringModifyRequestAsync(this OcipClient client, SystemGeographicRedundancyPeerSipConnectionMonitoringModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Geographic Redundancy Proxy system parameters
        /// The response is a SystemGeographicRedundancyProxyGetResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGeographicRedundancyProxyGetRequestAsync instead.")]
        public static async Task<SystemGeographicRedundancyProxyGetResponse> SystemGeographicRedundancyProxyGetRequest(this OcipClient client, SystemGeographicRedundancyProxyGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGeographicRedundancyProxyGetResponse;
        }

        /// <summary>
        /// Request to get the list of Geographic Redundancy Proxy system parameters
        /// The response is a SystemGeographicRedundancyProxyGetResponse.
        /// </summary>
        public static async Task<SystemGeographicRedundancyProxyGetResponse> SystemGeographicRedundancyProxyGetRequestAsync(this OcipClient client, SystemGeographicRedundancyProxyGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGeographicRedundancyProxyGetResponse;
        }
        /// <summary>
        /// Modify the list of Geographic Redundancy Proxysystem parameters
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGeographicRedundancyProxyModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGeographicRedundancyProxyModifyRequest(this OcipClient client, SystemGeographicRedundancyProxyModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the list of Geographic Redundancy Proxysystem parameters
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGeographicRedundancyProxyModifyRequestAsync(this OcipClient client, SystemGeographicRedundancyProxyModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of users that are unreachable from the primary application server.
        /// The response is a SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22Async instead.")]
        public static async Task<SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22> SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22(this OcipClient client, SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22;
        }

        /// <summary>
        /// Get the list of users that are unreachable from the primary application server.
        /// The response is a SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22> SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22Async(this OcipClient client, SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22;
        }
        /// <summary>
        /// Get the list of registration contacts.
        /// This request handles all levels of administration privileges.  The content of the response will only contain
        /// items within the scope of the requester's login id.  At the system level any of the choice parameters may be
        /// specified to filter the registrations listed.  At the reseller level, the resellerId must be specified.
        /// ResellerId is not valid at service provider, group or user level. At the service provider level the
        /// serviceProviderId must be specified for the service provider and group options.  When using the userId or
        /// linePort options the specified value must be valid for that service provider login.  At the group level
        /// the servicProviderId and the groupId must be specified for the group option. When using the userId or linePort
        /// options the specified value must be valid for that group login.
        /// The serviceProviderId option is not valid at the group level.  At the user level when using the userId or
        /// linePort options the specified value must be valid for that user login.  The serviceProviderId and groupId
        /// options are not valid at the user level.
        /// The response is either SystemGetRegistrationContactListResponse21sp1 or ErrorResponse.
        /// The RegistrationEndpointType21sp1 is sent in response The Endpoint Type column contains one of the enumerated RegistrationEndpointType21sp1 values.
        /// The value Mobility in Endpoint Type column is only applicable in AS data mode.
        /// 
        /// The following elements are only used in AS data mode:
        /// resellerId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGetRegistrationContactListRequest21sp1Async instead.")]
        public static async Task<SystemGetRegistrationContactListResponse21sp1> SystemGetRegistrationContactListRequest21sp1(this OcipClient client, SystemGetRegistrationContactListRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGetRegistrationContactListResponse21sp1;
        }

        /// <summary>
        /// Get the list of registration contacts.
        /// This request handles all levels of administration privileges.  The content of the response will only contain
        /// items within the scope of the requester's login id.  At the system level any of the choice parameters may be
        /// specified to filter the registrations listed.  At the reseller level, the resellerId must be specified.
        /// ResellerId is not valid at service provider, group or user level. At the service provider level the
        /// serviceProviderId must be specified for the service provider and group options.  When using the userId or
        /// linePort options the specified value must be valid for that service provider login.  At the group level
        /// the servicProviderId and the groupId must be specified for the group option. When using the userId or linePort
        /// options the specified value must be valid for that group login.
        /// The serviceProviderId option is not valid at the group level.  At the user level when using the userId or
        /// linePort options the specified value must be valid for that user login.  The serviceProviderId and groupId
        /// options are not valid at the user level.
        /// The response is either SystemGetRegistrationContactListResponse21sp1 or ErrorResponse.
        /// The RegistrationEndpointType21sp1 is sent in response The Endpoint Type column contains one of the enumerated RegistrationEndpointType21sp1 values.
        /// The value Mobility in Endpoint Type column is only applicable in AS data mode.
        /// 
        /// The following elements are only used in AS data mode:
        /// resellerId
        /// </summary>
        public static async Task<SystemGetRegistrationContactListResponse21sp1> SystemGetRegistrationContactListRequest21sp1Async(this OcipClient client, SystemGetRegistrationContactListRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGetRegistrationContactListResponse21sp1;
        }
        /// <summary>
        /// Add a GETS AVP Code map at the system level.  It maps a Diameter AVP Code with a vendor ID for.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSAvpCodeMapAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSAvpCodeMapAddRequest(this OcipClient client, SystemGETSAvpCodeMapAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a GETS AVP Code map at the system level.  It maps a Diameter AVP Code with a vendor ID for.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSAvpCodeMapAddRequestAsync(this OcipClient client, SystemGETSAvpCodeMapAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a system GETS AVP Code map.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSAvpCodeMapDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSAvpCodeMapDeleteRequest(this OcipClient client, SystemGETSAvpCodeMapDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a system GETS AVP Code map.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSAvpCodeMapDeleteRequestAsync(this OcipClient client, SystemGETSAvpCodeMapDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of GETS AVP Code Maps at the system level.
        /// The response is either SystemGETSAvpCodeMapGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSAvpCodeMapGetListRequestAsync instead.")]
        public static async Task<SystemGETSAvpCodeMapGetListResponse> SystemGETSAvpCodeMapGetListRequest(this OcipClient client, SystemGETSAvpCodeMapGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGETSAvpCodeMapGetListResponse;
        }

        /// <summary>
        /// Get a list of GETS AVP Code Maps at the system level.
        /// The response is either SystemGETSAvpCodeMapGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemGETSAvpCodeMapGetListResponse> SystemGETSAvpCodeMapGetListRequestAsync(this OcipClient client, SystemGETSAvpCodeMapGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGETSAvpCodeMapGetListResponse;
        }
        /// <summary>
        /// Get the GETS system settings.
        /// The response is either SystemGETSGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSGetRequestAsync instead.")]
        public static async Task<SystemGETSGetResponse> SystemGETSGetRequest(this OcipClient client, SystemGETSGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGETSGetResponse;
        }

        /// <summary>
        /// Get the GETS system settings.
        /// The response is either SystemGETSGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemGETSGetResponse> SystemGETSGetRequestAsync(this OcipClient client, SystemGETSGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGETSGetResponse;
        }
        /// <summary>
        /// Modify GETS system settings.
        /// The following elements are only used in AS data mode and ignored in the Amplify data mode:
        /// callIdentifierMode
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSModifyRequest(this OcipClient client, SystemGETSModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify GETS system settings.
        /// The following elements are only used in AS data mode and ignored in the Amplify data mode:
        /// callIdentifierMode
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSModifyRequestAsync(this OcipClient client, SystemGETSModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a GETS reserved Number.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSNumberAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSNumberAddRequest(this OcipClient client, SystemGETSNumberAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a GETS reserved Number.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSNumberAddRequestAsync(this OcipClient client, SystemGETSNumberAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a GETS reserved Number.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSNumberDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSNumberDeleteRequest(this OcipClient client, SystemGETSNumberDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a GETS reserved Number.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSNumberDeleteRequestAsync(this OcipClient client, SystemGETSNumberDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of GETS reserved Numbers.
        /// The response is either SystemGETSNumberGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSNumberGetListRequestAsync instead.")]
        public static async Task<SystemGETSNumberGetListResponse> SystemGETSNumberGetListRequest(this OcipClient client, SystemGETSNumberGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGETSNumberGetListResponse;
        }

        /// <summary>
        /// Get a list of GETS reserved Numbers.
        /// The response is either SystemGETSNumberGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemGETSNumberGetListResponse> SystemGETSNumberGetListRequestAsync(this OcipClient client, SystemGETSNumberGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGETSNumberGetListResponse;
        }
        /// <summary>
        /// Modify a GETS reserved Number.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSNumberModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSNumberModifyRequest(this OcipClient client, SystemGETSNumberModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a GETS reserved Number.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSNumberModifyRequestAsync(this OcipClient client, SystemGETSNumberModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a GETS reserved FAC.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSReservedFeatureAccessCodeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSReservedFeatureAccessCodeAddRequest(this OcipClient client, SystemGETSReservedFeatureAccessCodeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a GETS reserved FAC.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSReservedFeatureAccessCodeAddRequestAsync(this OcipClient client, SystemGETSReservedFeatureAccessCodeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a GETS reserved FAC.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSReservedFeatureAccessCodeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSReservedFeatureAccessCodeDeleteRequest(this OcipClient client, SystemGETSReservedFeatureAccessCodeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a GETS reserved FAC.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSReservedFeatureAccessCodeDeleteRequestAsync(this OcipClient client, SystemGETSReservedFeatureAccessCodeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of GETS reserved FAC.
        /// The response is either SystemGETSReservedFeatureAccessCodeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSReservedFeatureAccessCodeGetListRequestAsync instead.")]
        public static async Task<SystemGETSReservedFeatureAccessCodeGetListResponse> SystemGETSReservedFeatureAccessCodeGetListRequest(this OcipClient client, SystemGETSReservedFeatureAccessCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGETSReservedFeatureAccessCodeGetListResponse;
        }

        /// <summary>
        /// Get a list of GETS reserved FAC.
        /// The response is either SystemGETSReservedFeatureAccessCodeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemGETSReservedFeatureAccessCodeGetListResponse> SystemGETSReservedFeatureAccessCodeGetListRequestAsync(this OcipClient client, SystemGETSReservedFeatureAccessCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGETSReservedFeatureAccessCodeGetListResponse;
        }
        /// <summary>
        /// Modify a GETS reserved FAC.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSReservedFeatureAccessCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSReservedFeatureAccessCodeModifyRequest(this OcipClient client, SystemGETSReservedFeatureAccessCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a GETS reserved FAC.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSReservedFeatureAccessCodeModifyRequestAsync(this OcipClient client, SystemGETSReservedFeatureAccessCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a GETS Resource Priority.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSResourcePriorityAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSResourcePriorityAddRequest(this OcipClient client, SystemGETSResourcePriorityAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a GETS Resource Priority.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSResourcePriorityAddRequestAsync(this OcipClient client, SystemGETSResourcePriorityAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a GETS Resource Priority.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSResourcePriorityDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSResourcePriorityDeleteRequest(this OcipClient client, SystemGETSResourcePriorityDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a GETS Resource Priority.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSResourcePriorityDeleteRequestAsync(this OcipClient client, SystemGETSResourcePriorityDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of GETS Resource Priorities.
        /// The response is either SystemGETSResourcePriorityGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSResourcePriorityGetListRequestAsync instead.")]
        public static async Task<SystemGETSResourcePriorityGetListResponse> SystemGETSResourcePriorityGetListRequest(this OcipClient client, SystemGETSResourcePriorityGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGETSResourcePriorityGetListResponse;
        }

        /// <summary>
        /// Get a list of GETS Resource Priorities.
        /// The response is either SystemGETSResourcePriorityGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemGETSResourcePriorityGetListResponse> SystemGETSResourcePriorityGetListRequestAsync(this OcipClient client, SystemGETSResourcePriorityGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGETSResourcePriorityGetListResponse;
        }
        /// <summary>
        /// Modify a GETS reserved Resource Priority.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSResourcePriorityModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSResourcePriorityModifyRequest(this OcipClient client, SystemGETSResourcePriorityModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a GETS reserved Resource Priority.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSResourcePriorityModifyRequestAsync(this OcipClient client, SystemGETSResourcePriorityModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a GETS Session Priority map.  It maps a priority level with a session priority AVP value.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSSessionPriorityMapAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSSessionPriorityMapAddRequest(this OcipClient client, SystemGETSSessionPriorityMapAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a GETS Session Priority map.  It maps a priority level with a session priority AVP value.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSSessionPriorityMapAddRequestAsync(this OcipClient client, SystemGETSSessionPriorityMapAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a GETS Session Priority map.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSSessionPriorityMapDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSSessionPriorityMapDeleteRequest(this OcipClient client, SystemGETSSessionPriorityMapDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a GETS Session Priority map.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSSessionPriorityMapDeleteRequestAsync(this OcipClient client, SystemGETSSessionPriorityMapDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of GETS Session Priority maps.
        /// The response is either SystemGETSSessionPriorityMapGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSSessionPriorityMapGetListRequestAsync instead.")]
        public static async Task<SystemGETSSessionPriorityMapGetListResponse> SystemGETSSessionPriorityMapGetListRequest(this OcipClient client, SystemGETSSessionPriorityMapGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGETSSessionPriorityMapGetListResponse;
        }

        /// <summary>
        /// Get a list of GETS Session Priority maps.
        /// The response is either SystemGETSSessionPriorityMapGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemGETSSessionPriorityMapGetListResponse> SystemGETSSessionPriorityMapGetListRequestAsync(this OcipClient client, SystemGETSSessionPriorityMapGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGETSSessionPriorityMapGetListResponse;
        }
        /// <summary>
        /// Modify a GETS Session Priority Map.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGETSSessionPriorityMapModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGETSSessionPriorityMapModifyRequest(this OcipClient client, SystemGETSSessionPriorityMapModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a GETS Session Priority Map.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGETSSessionPriorityMapModifyRequestAsync(this OcipClient client, SystemGETSSessionPriorityMapModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Home Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHomeNetworkAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemHomeNetworkAddRequest(this OcipClient client, SystemHomeNetworkAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Home Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemHomeNetworkAddRequestAsync(this OcipClient client, SystemHomeNetworkAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Home Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHomeNetworkDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemHomeNetworkDeleteRequest(this OcipClient client, SystemHomeNetworkDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Home Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemHomeNetworkDeleteRequestAsync(this OcipClient client, SystemHomeNetworkDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all Home Networks.
        /// The response is either a SystemHomeNetworkGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHomeNetworkGetListRequestAsync instead.")]
        public static async Task<SystemHomeNetworkGetListResponse> SystemHomeNetworkGetListRequest(this OcipClient client, SystemHomeNetworkGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemHomeNetworkGetListResponse;
        }

        /// <summary>
        /// Get the list of all Home Networks.
        /// The response is either a SystemHomeNetworkGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemHomeNetworkGetListResponse> SystemHomeNetworkGetListRequestAsync(this OcipClient client, SystemHomeNetworkGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemHomeNetworkGetListResponse;
        }
        /// <summary>
        /// Add a new alternate carrier for CbC and Preselection.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHPBXAlternateCarrierSelectionAddCarrierRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemHPBXAlternateCarrierSelectionAddCarrierRequest(this OcipClient client, SystemHPBXAlternateCarrierSelectionAddCarrierRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new alternate carrier for CbC and Preselection.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemHPBXAlternateCarrierSelectionAddCarrierRequestAsync(this OcipClient client, SystemHPBXAlternateCarrierSelectionAddCarrierRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an alternate carrier for CbC and Preselection.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHPBXAlternateCarrierSelectionDeleteCarrierRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemHPBXAlternateCarrierSelectionDeleteCarrierRequest(this OcipClient client, SystemHPBXAlternateCarrierSelectionDeleteCarrierRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an alternate carrier for CbC and Preselection.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemHPBXAlternateCarrierSelectionDeleteCarrierRequestAsync(this OcipClient client, SystemHPBXAlternateCarrierSelectionDeleteCarrierRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of alternate carriers available for CbC and Preselection.
        /// The response is either a SystemHPBXAlternateCarrierSelectionGetCarrierListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHPBXAlternateCarrierSelectionGetCarrierListRequestAsync instead.")]
        public static async Task<SystemHPBXAlternateCarrierSelectionGetCarrierListResponse> SystemHPBXAlternateCarrierSelectionGetCarrierListRequest(this OcipClient client, SystemHPBXAlternateCarrierSelectionGetCarrierListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemHPBXAlternateCarrierSelectionGetCarrierListResponse;
        }

        /// <summary>
        /// Request the list of alternate carriers available for CbC and Preselection.
        /// The response is either a SystemHPBXAlternateCarrierSelectionGetCarrierListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemHPBXAlternateCarrierSelectionGetCarrierListResponse> SystemHPBXAlternateCarrierSelectionGetCarrierListRequestAsync(this OcipClient client, SystemHPBXAlternateCarrierSelectionGetCarrierListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemHPBXAlternateCarrierSelectionGetCarrierListResponse;
        }
        /// <summary>
        /// Modify an alternate carrier for CbC and Preselection.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHPBXAlternateCarrierSelectionModifyCarrierRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemHPBXAlternateCarrierSelectionModifyCarrierRequest(this OcipClient client, SystemHPBXAlternateCarrierSelectionModifyCarrierRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an alternate carrier for CbC and Preselection.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemHPBXAlternateCarrierSelectionModifyCarrierRequestAsync(this OcipClient client, SystemHPBXAlternateCarrierSelectionModifyCarrierRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the hPBX mobile termination related configuration parameters.
        /// The response is either a SystemHPBXMobileTerminationGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHPBXMobileTerminationGetRequestAsync instead.")]
        public static async Task<SystemHPBXMobileTerminationGetResponse> SystemHPBXMobileTerminationGetRequest(this OcipClient client, SystemHPBXMobileTerminationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemHPBXMobileTerminationGetResponse;
        }

        /// <summary>
        /// Request to get the hPBX mobile termination related configuration parameters.
        /// The response is either a SystemHPBXMobileTerminationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemHPBXMobileTerminationGetResponse> SystemHPBXMobileTerminationGetRequestAsync(this OcipClient client, SystemHPBXMobileTerminationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemHPBXMobileTerminationGetResponse;
        }
        /// <summary>
        /// Request to modify the hPBX mobile termination related configuration parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHPBXMobileTerminationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemHPBXMobileTerminationModifyRequest(this OcipClient client, SystemHPBXMobileTerminationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the hPBX mobile termination related configuration parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemHPBXMobileTerminationModifyRequestAsync(this OcipClient client, SystemHPBXMobileTerminationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a language to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLanguageAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemLanguageAddRequest(this OcipClient client, SystemLanguageAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a language to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemLanguageAddRequestAsync(this OcipClient client, SystemLanguageAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a language from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLanguageDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemLanguageDeleteRequest(this OcipClient client, SystemLanguageDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a language from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemLanguageDeleteRequestAsync(this OcipClient client, SystemLanguageDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the defined languages in the system.
        /// The response is either a SystemLanguageGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLanguageGetListRequestAsync instead.")]
        public static async Task<SystemLanguageGetListResponse> SystemLanguageGetListRequest(this OcipClient client, SystemLanguageGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemLanguageGetListResponse;
        }

        /// <summary>
        /// Request the defined languages in the system.
        /// The response is either a SystemLanguageGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemLanguageGetListResponse> SystemLanguageGetListRequestAsync(this OcipClient client, SystemLanguageGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemLanguageGetListResponse;
        }
        /// <summary>
        /// Request to modify a language properties in the system.
        /// If the becomeDefaultLanguage element is present, the language in this request becomes
        /// the default language for the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLanguageModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemLanguageModifyRequest(this OcipClient client, SystemLanguageModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a language properties in the system.
        /// If the becomeDefaultLanguage element is present, the language in this request becomes
        /// the default language for the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemLanguageModifyRequestAsync(this OcipClient client, SystemLanguageModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get all the licensing information.
        /// The response is either SystemLicensingGetResponse14sp3 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLicensingGetRequest14sp3Async instead.")]
        public static async Task<SystemLicensingGetResponse14sp3> SystemLicensingGetRequest14sp3(this OcipClient client, SystemLicensingGetRequest14sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemLicensingGetResponse14sp3;
        }

        /// <summary>
        /// Get all the licensing information.
        /// The response is either SystemLicensingGetResponse14sp3 or ErrorResponse.
        /// </summary>
        public static async Task<SystemLicensingGetResponse14sp3> SystemLicensingGetRequest14sp3Async(this OcipClient client, SystemLicensingGetRequest14sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemLicensingGetResponse14sp3;
        }
        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLicensingGetSystemLicenseListRequest22Async instead.")]
        public static async Task<SystemLicensingGetSystemLicenseListResponse22> SystemLicensingGetSystemLicenseListRequest22(this OcipClient client, SystemLicensingGetSystemLicenseListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse22;
        }

        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemLicensingGetSystemLicenseListResponse22> SystemLicensingGetSystemLicenseListRequest22Async(this OcipClient client, SystemLicensingGetSystemLicenseListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse22;
        }
        /// <summary>
        /// Load a new license file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLicensingReloadRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemLicensingReloadRequest(this OcipClient client, SystemLicensingReloadRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Load a new license file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemLicensingReloadRequestAsync(this OcipClient client, SystemLicensingReloadRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Mail system parameters.
        /// The response is either SystemMailParametersGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMailParametersGetRequest22Async instead.")]
        public static async Task<SystemMailParametersGetResponse22> SystemMailParametersGetRequest22(this OcipClient client, SystemMailParametersGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMailParametersGetResponse22;
        }

        /// <summary>
        /// Request to get the list of Mail system parameters.
        /// The response is either SystemMailParametersGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemMailParametersGetResponse22> SystemMailParametersGetRequest22Async(this OcipClient client, SystemMailParametersGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMailParametersGetResponse22;
        }
        /// <summary>
        /// Request to modify Mail system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMailParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMailParametersModifyRequest(this OcipClient client, SystemMailParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Mail system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMailParametersModifyRequestAsync(this OcipClient client, SystemMailParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a Media to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaAddRequest16Async instead.")]
        public static async Task<SuccessResponse> SystemMediaAddRequest16(this OcipClient client, SystemMediaAddRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a Media to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaAddRequest16Async(this OcipClient client, SystemMediaAddRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a Media from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaDeleteRequest(this OcipClient client, SystemMediaDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a Media from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaDeleteRequestAsync(this OcipClient client, SystemMediaDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of media in the system.
        /// The response is either a SystemMediaGetListResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGetListRequestAsync instead.")]
        public static async Task<SystemMediaGetListResponse> SystemMediaGetListRequest(this OcipClient client, SystemMediaGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMediaGetListResponse;
        }

        /// <summary>
        /// Request to get a list of media in the system.
        /// The response is either a SystemMediaGetListResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemMediaGetListResponse> SystemMediaGetListRequestAsync(this OcipClient client, SystemMediaGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMediaGetListResponse;
        }
        /// <summary>
        /// Request to add a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGroupAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaGroupAddRequest(this OcipClient client, SystemMediaGroupAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaGroupAddRequestAsync(this OcipClient client, SystemMediaGroupAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a media to a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGroupCodecAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaGroupCodecAddRequest(this OcipClient client, SystemMediaGroupCodecAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a media to a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaGroupCodecAddRequestAsync(this OcipClient client, SystemMediaGroupCodecAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete media from a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGroupCodecDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaGroupCodecDeleteRequest(this OcipClient client, SystemMediaGroupCodecDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete media from a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaGroupCodecDeleteRequestAsync(this OcipClient client, SystemMediaGroupCodecDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of media under a media group.
        /// The response is either SystemMediaGroupCodecGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGroupCodecGetListRequestAsync instead.")]
        public static async Task<SystemMediaGroupCodecGetListResponse> SystemMediaGroupCodecGetListRequest(this OcipClient client, SystemMediaGroupCodecGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMediaGroupCodecGetListResponse;
        }

        /// <summary>
        /// Request to get the list of media under a media group.
        /// The response is either SystemMediaGroupCodecGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemMediaGroupCodecGetListResponse> SystemMediaGroupCodecGetListRequestAsync(this OcipClient client, SystemMediaGroupCodecGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMediaGroupCodecGetListResponse;
        }
        /// <summary>
        /// Request to modify a media associated with a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGroupCodecModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaGroupCodecModifyRequest(this OcipClient client, SystemMediaGroupCodecModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a media associated with a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaGroupCodecModifyRequestAsync(this OcipClient client, SystemMediaGroupCodecModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGroupDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaGroupDeleteRequest(this OcipClient client, SystemMediaGroupDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaGroupDeleteRequestAsync(this OcipClient client, SystemMediaGroupDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of media groups.
        /// The response is either SystemMediaGroupGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGroupGetListRequestAsync instead.")]
        public static async Task<SystemMediaGroupGetListResponse> SystemMediaGroupGetListRequest(this OcipClient client, SystemMediaGroupGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMediaGroupGetListResponse;
        }

        /// <summary>
        /// Request to get the list of media groups.
        /// The response is either SystemMediaGroupGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemMediaGroupGetListResponse> SystemMediaGroupGetListRequestAsync(this OcipClient client, SystemMediaGroupGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMediaGroupGetListResponse;
        }
        /// <summary>
        /// Request to modify a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGroupModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaGroupModifyRequest(this OcipClient client, SystemMediaGroupModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a media group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaGroupModifyRequestAsync(this OcipClient client, SystemMediaGroupModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of SAC groups associated with a media group.
        /// The response is either SystemMediaGroupUsageListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaGroupUsageListRequestAsync instead.")]
        public static async Task<SystemMediaGroupUsageListResponse> SystemMediaGroupUsageListRequest(this OcipClient client, SystemMediaGroupUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMediaGroupUsageListResponse;
        }

        /// <summary>
        /// Request to get the list of SAC groups associated with a media group.
        /// The response is either SystemMediaGroupUsageListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemMediaGroupUsageListResponse> SystemMediaGroupUsageListRequestAsync(this OcipClient client, SystemMediaGroupUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMediaGroupUsageListResponse;
        }
        /// <summary>
        /// Request to modify a media.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaModifyRequest(this OcipClient client, SystemMediaModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a media.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaModifyRequestAsync(this OcipClient client, SystemMediaModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a Media Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaServerAddRequest14Async instead.")]
        public static async Task<SuccessResponse> SystemMediaServerAddRequest14(this OcipClient client, SystemMediaServerAddRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a Media Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaServerAddRequest14Async(this OcipClient client, SystemMediaServerAddRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a Media Server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaServerDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaServerDeleteRequest(this OcipClient client, SystemMediaServerDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a Media Server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaServerDeleteRequestAsync(this OcipClient client, SystemMediaServerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of Media Servers defined in the system.
        /// The response is either a SystemMediaServerGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaServerGetListRequestAsync instead.")]
        public static async Task<SystemMediaServerGetListResponse> SystemMediaServerGetListRequest(this OcipClient client, SystemMediaServerGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMediaServerGetListResponse;
        }

        /// <summary>
        /// Request to get a list of Media Servers defined in the system.
        /// The response is either a SystemMediaServerGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemMediaServerGetListResponse> SystemMediaServerGetListRequestAsync(this OcipClient client, SystemMediaServerGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMediaServerGetListResponse;
        }
        /// <summary>
        /// Request to modify a Media Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaServerModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaServerModifyRequest(this OcipClient client, SystemMediaServerModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Media Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaServerModifyRequestAsync(this OcipClient client, SystemMediaServerModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Media Server system parameters.
        /// The response is either SystemMediaServerParametersGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaServerParametersGetRequestAsync instead.")]
        public static async Task<SystemMediaServerParametersGetResponse> SystemMediaServerParametersGetRequest(this OcipClient client, SystemMediaServerParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMediaServerParametersGetResponse;
        }

        /// <summary>
        /// Request to get the list of Media Server system parameters.
        /// The response is either SystemMediaServerParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemMediaServerParametersGetResponse> SystemMediaServerParametersGetRequestAsync(this OcipClient client, SystemMediaServerParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMediaServerParametersGetResponse;
        }
        /// <summary>
        /// Request to modify Media Server system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaServerParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaServerParametersModifyRequest(this OcipClient client, SystemMediaServerParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Media Server system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaServerParametersModifyRequestAsync(this OcipClient client, SystemMediaServerParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a Media Set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaSetAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaSetAddRequest(this OcipClient client, SystemMediaSetAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a Media Set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaSetAddRequestAsync(this OcipClient client, SystemMediaSetAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a Media Set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaSetDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaSetDeleteRequest(this OcipClient client, SystemMediaSetDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a Media Set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaSetDeleteRequestAsync(this OcipClient client, SystemMediaSetDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Media Sets in the system.
        /// The response is either a SystemMediaSetGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaSetGetListRequestAsync instead.")]
        public static async Task<SystemMediaSetGetListResponse> SystemMediaSetGetListRequest(this OcipClient client, SystemMediaSetGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMediaSetGetListResponse;
        }

        /// <summary>
        /// Request to get the list of Media Sets in the system.
        /// The response is either a SystemMediaSetGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemMediaSetGetListResponse> SystemMediaSetGetListRequestAsync(this OcipClient client, SystemMediaSetGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMediaSetGetListResponse;
        }
        /// <summary>
        /// Request to get a Media Set.
        /// The response is either a SystemMediaSetGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaSetGetRequestAsync instead.")]
        public static async Task<SystemMediaSetGetResponse> SystemMediaSetGetRequest(this OcipClient client, SystemMediaSetGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMediaSetGetResponse;
        }

        /// <summary>
        /// Request to get a Media Set.
        /// The response is either a SystemMediaSetGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemMediaSetGetResponse> SystemMediaSetGetRequestAsync(this OcipClient client, SystemMediaSetGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMediaSetGetResponse;
        }
        /// <summary>
        /// Request to modify a Media Set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMediaSetModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMediaSetModifyRequest(this OcipClient client, SystemMediaSetModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Media Set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaSetModifyRequestAsync(this OcipClient client, SystemMediaSetModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of mgcp device types in the system.
        /// See Also: SystemDeviceTypeGetAvailableListRequest14sp3.
        /// The response is either SystemMGCPDeviceTypeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMGCPDeviceTypeGetListRequestAsync instead.")]
        public static async Task<SystemMGCPDeviceTypeGetListResponse> SystemMGCPDeviceTypeGetListRequest(this OcipClient client, SystemMGCPDeviceTypeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMGCPDeviceTypeGetListResponse;
        }

        /// <summary>
        /// Request to get the list of mgcp device types in the system.
        /// See Also: SystemDeviceTypeGetAvailableListRequest14sp3.
        /// The response is either SystemMGCPDeviceTypeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemMGCPDeviceTypeGetListResponse> SystemMGCPDeviceTypeGetListRequestAsync(this OcipClient client, SystemMGCPDeviceTypeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMGCPDeviceTypeGetListResponse;
        }
        /// <summary>
        /// Request to get a mgcp device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemMGCPDeviceTypeGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMGCPDeviceTypeGetRequestAsync instead.")]
        public static async Task<SystemMGCPDeviceTypeGetResponse> SystemMGCPDeviceTypeGetRequest(this OcipClient client, SystemMGCPDeviceTypeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMGCPDeviceTypeGetResponse;
        }

        /// <summary>
        /// Request to get a mgcp device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemMGCPDeviceTypeGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemMGCPDeviceTypeGetResponse> SystemMGCPDeviceTypeGetRequestAsync(this OcipClient client, SystemMGCPDeviceTypeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMGCPDeviceTypeGetResponse;
        }
        /// <summary>
        /// Request to modify a mgcp device type. In release 14, this is limited to changing the obsolete flag.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMGCPDeviceTypeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMGCPDeviceTypeModifyRequest(this OcipClient client, SystemMGCPDeviceTypeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a mgcp device type. In release 14, this is limited to changing the obsolete flag.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMGCPDeviceTypeModifyRequestAsync(this OcipClient client, SystemMGCPDeviceTypeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of migrated users.
        /// If the optional parameter userListSizeLimit is set, then the list returned in the response will contain entries up to value of userListSizeLimit.
        /// The response is either SystemMigratedUsersGetListResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMigratedUsersGetListRequest22Async instead.")]
        public static async Task<SystemMigratedUsersGetListResponse22> SystemMigratedUsersGetListRequest22(this OcipClient client, SystemMigratedUsersGetListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMigratedUsersGetListResponse22;
        }

        /// <summary>
        /// Get a list of migrated users.
        /// If the optional parameter userListSizeLimit is set, then the list returned in the response will contain entries up to value of userListSizeLimit.
        /// The response is either SystemMigratedUsersGetListResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemMigratedUsersGetListResponse22> SystemMigratedUsersGetListRequest22Async(this OcipClient client, SystemMigratedUsersGetListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMigratedUsersGetListResponse22;
        }
        /// <summary>
        /// Request the system level data associated with Multimedia Policy.
        /// The response is either a SystemMultimediaPolicyGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMultimediaPolicyGetRequestAsync instead.")]
        public static async Task<SystemMultimediaPolicyGetResponse> SystemMultimediaPolicyGetRequest(this OcipClient client, SystemMultimediaPolicyGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMultimediaPolicyGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Multimedia Policy.
        /// The response is either a SystemMultimediaPolicyGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemMultimediaPolicyGetResponse> SystemMultimediaPolicyGetRequestAsync(this OcipClient client, SystemMultimediaPolicyGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMultimediaPolicyGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Multimedia Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMultimediaPolicyModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMultimediaPolicyModifyRequest(this OcipClient client, SystemMultimediaPolicyModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Multimedia Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMultimediaPolicyModifyRequestAsync(this OcipClient client, SystemMultimediaPolicyModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Network Class of Service.
        /// The following elements are only used in AS data mode:
        /// callProcessingPolicyProfileName
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkClassOfServiceAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkClassOfServiceAddRequest(this OcipClient client, SystemNetworkClassOfServiceAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Network Class of Service.
        /// The following elements are only used in AS data mode:
        /// callProcessingPolicyProfileName
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkClassOfServiceAddRequestAsync(this OcipClient client, SystemNetworkClassOfServiceAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Network Class of Service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkClassOfServiceDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkClassOfServiceDeleteRequest(this OcipClient client, SystemNetworkClassOfServiceDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Network Class of Service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkClassOfServiceDeleteRequestAsync(this OcipClient client, SystemNetworkClassOfServiceDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a list of service providers that have a given Network Class
        /// of Service assigned.
        /// The response is either a SystemNetworkClassOfServiceGetAssignedServiceProviderListResponse or
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkClassOfServiceGetAssignedServiceProviderListRequestAsync instead.")]
        public static async Task<SystemNetworkClassOfServiceGetAssignedServiceProviderListResponse> SystemNetworkClassOfServiceGetAssignedServiceProviderListRequest(this OcipClient client, SystemNetworkClassOfServiceGetAssignedServiceProviderListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkClassOfServiceGetAssignedServiceProviderListResponse;
        }

        /// <summary>
        /// Request a list of service providers that have a given Network Class
        /// of Service assigned.
        /// The response is either a SystemNetworkClassOfServiceGetAssignedServiceProviderListResponse or
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemNetworkClassOfServiceGetAssignedServiceProviderListResponse> SystemNetworkClassOfServiceGetAssignedServiceProviderListRequestAsync(this OcipClient client, SystemNetworkClassOfServiceGetAssignedServiceProviderListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkClassOfServiceGetAssignedServiceProviderListResponse;
        }
        /// <summary>
        /// Get the list of Network Classes of Service that contain a specific
        /// Communication Barring Profile.
        /// The response is either a SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListRequestAsync instead.")]
        public static async Task<SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListResponse> SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListRequest(this OcipClient client, SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListResponse;
        }

        /// <summary>
        /// Get the list of Network Classes of Service that contain a specific
        /// Communication Barring Profile.
        /// The response is either a SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListResponse> SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListRequestAsync(this OcipClient client, SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListResponse;
        }
        /// <summary>
        /// Get the list of all Network Classes of Service.
        /// The response is either a SystemNetworkClassOfServiceGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkClassOfServiceGetListRequestAsync instead.")]
        public static async Task<SystemNetworkClassOfServiceGetListResponse> SystemNetworkClassOfServiceGetListRequest(this OcipClient client, SystemNetworkClassOfServiceGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkClassOfServiceGetListResponse;
        }

        /// <summary>
        /// Get the list of all Network Classes of Service.
        /// The response is either a SystemNetworkClassOfServiceGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemNetworkClassOfServiceGetListResponse> SystemNetworkClassOfServiceGetListRequestAsync(this OcipClient client, SystemNetworkClassOfServiceGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkClassOfServiceGetListResponse;
        }
        /// <summary>
        /// Get an existing Network Class of Service.
        /// The response is either a SystemNetworkClassOfServiceGetResponse19sp1
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkClassOfServiceGetRequest19sp1Async instead.")]
        public static async Task<SystemNetworkClassOfServiceGetResponse19sp1> SystemNetworkClassOfServiceGetRequest19sp1(this OcipClient client, SystemNetworkClassOfServiceGetRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkClassOfServiceGetResponse19sp1;
        }

        /// <summary>
        /// Get an existing Network Class of Service.
        /// The response is either a SystemNetworkClassOfServiceGetResponse19sp1
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemNetworkClassOfServiceGetResponse19sp1> SystemNetworkClassOfServiceGetRequest19sp1Async(this OcipClient client, SystemNetworkClassOfServiceGetRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkClassOfServiceGetResponse19sp1;
        }
        /// <summary>
        /// Modify an existing Network Class of Service.
        /// The following elements are only used in AS data mode:
        /// callProcessingPolicyProfileName
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkClassOfServiceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkClassOfServiceModifyRequest(this OcipClient client, SystemNetworkClassOfServiceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing Network Class of Service.
        /// The following elements are only used in AS data mode:
        /// callProcessingPolicyProfileName
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkClassOfServiceModifyRequestAsync(this OcipClient client, SystemNetworkClassOfServiceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Network Device Polling system parameters.
        /// The response is either SystemNetworkDeviceMonitorParametersGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkDeviceMonitorParametersGetRequestAsync instead.")]
        public static async Task<SystemNetworkDeviceMonitorParametersGetResponse> SystemNetworkDeviceMonitorParametersGetRequest(this OcipClient client, SystemNetworkDeviceMonitorParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkDeviceMonitorParametersGetResponse;
        }

        /// <summary>
        /// Request to get the list of Network Device Polling system parameters.
        /// The response is either SystemNetworkDeviceMonitorParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemNetworkDeviceMonitorParametersGetResponse> SystemNetworkDeviceMonitorParametersGetRequestAsync(this OcipClient client, SystemNetworkDeviceMonitorParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkDeviceMonitorParametersGetResponse;
        }
        /// <summary>
        /// Request to modify Network Device Polling system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkDeviceMonitorParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkDeviceMonitorParametersModifyRequest(this OcipClient client, SystemNetworkDeviceMonitorParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Network Device Polling system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkDeviceMonitorParametersModifyRequestAsync(this OcipClient client, SystemNetworkDeviceMonitorParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with network progression.
        /// The response is either a SystemNetworkProgressionGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkProgressionGetRequestAsync instead.")]
        public static async Task<SystemNetworkProgressionGetResponse> SystemNetworkProgressionGetRequest(this OcipClient client, SystemNetworkProgressionGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkProgressionGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with network progression.
        /// The response is either a SystemNetworkProgressionGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemNetworkProgressionGetResponse> SystemNetworkProgressionGetRequestAsync(this OcipClient client, SystemNetworkProgressionGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkProgressionGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with network progression.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkProgressionModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkProgressionModifyRequest(this OcipClient client, SystemNetworkProgressionModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with network progression.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkProgressionModifyRequestAsync(this OcipClient client, SystemNetworkProgressionModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a routing Network Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkRoutingServerAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkRoutingServerAddRequest(this OcipClient client, SystemNetworkRoutingServerAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a routing Network Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkRoutingServerAddRequestAsync(this OcipClient client, SystemNetworkRoutingServerAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a routing Network Server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkRoutingServerDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkRoutingServerDeleteRequest(this OcipClient client, SystemNetworkRoutingServerDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a routing Network Server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkRoutingServerDeleteRequestAsync(this OcipClient client, SystemNetworkRoutingServerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of routing Network Servers defined in the system.
        /// The response is either a SystemNetworkRoutingServerGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkRoutingServerGetListRequestAsync instead.")]
        public static async Task<SystemNetworkRoutingServerGetListResponse> SystemNetworkRoutingServerGetListRequest(this OcipClient client, SystemNetworkRoutingServerGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkRoutingServerGetListResponse;
        }

        /// <summary>
        /// Request to get a list of routing Network Servers defined in the system.
        /// The response is either a SystemNetworkRoutingServerGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemNetworkRoutingServerGetListResponse> SystemNetworkRoutingServerGetListRequestAsync(this OcipClient client, SystemNetworkRoutingServerGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkRoutingServerGetListResponse;
        }
        /// <summary>
        /// Request to modify a routing Network Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkRoutingServerModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkRoutingServerModifyRequest(this OcipClient client, SystemNetworkRoutingServerModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a routing Network Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkRoutingServerModifyRequestAsync(this OcipClient client, SystemNetworkRoutingServerModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Network Server Sync system parameters.
        /// The response is either SystemNetworkServerSyncParametersGetResponse17sp4 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkServerSyncParametersGetRequest17sp4Async instead.")]
        public static async Task<SystemNetworkServerSyncParametersGetResponse17sp4> SystemNetworkServerSyncParametersGetRequest17sp4(this OcipClient client, SystemNetworkServerSyncParametersGetRequest17sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkServerSyncParametersGetResponse17sp4;
        }

        /// <summary>
        /// Request to get the list of Network Server Sync system parameters.
        /// The response is either SystemNetworkServerSyncParametersGetResponse17sp4 or ErrorResponse.
        /// </summary>
        public static async Task<SystemNetworkServerSyncParametersGetResponse17sp4> SystemNetworkServerSyncParametersGetRequest17sp4Async(this OcipClient client, SystemNetworkServerSyncParametersGetRequest17sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkServerSyncParametersGetResponse17sp4;
        }
        /// <summary>
        /// Request to modify Network Server Sync system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// syncTrunkGroups
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkServerSyncParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkServerSyncParametersModifyRequest(this OcipClient client, SystemNetworkServerSyncParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Network Server Sync system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// syncTrunkGroups
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkServerSyncParametersModifyRequestAsync(this OcipClient client, SystemNetworkServerSyncParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a Network Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// order
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkSynchingServerAddRequest22V2Async instead.")]
        public static async Task<SuccessResponse> SystemNetworkSynchingServerAddRequest22V2(this OcipClient client, SystemNetworkSynchingServerAddRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a Network Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// order
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkSynchingServerAddRequest22V2Async(this OcipClient client, SystemNetworkSynchingServerAddRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a Network Server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkSynchingServerDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNetworkSynchingServerDeleteRequest(this OcipClient client, SystemNetworkSynchingServerDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a Network Server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkSynchingServerDeleteRequestAsync(this OcipClient client, SystemNetworkSynchingServerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of Network Servers defined in the system.
        /// The response is either a SystemNetworkSynchingServerGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkSynchingServerGetListRequestAsync instead.")]
        public static async Task<SystemNetworkSynchingServerGetListResponse> SystemNetworkSynchingServerGetListRequest(this OcipClient client, SystemNetworkSynchingServerGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkSynchingServerGetListResponse;
        }

        /// <summary>
        /// Request to get a list of Network Servers defined in the system.
        /// The response is either a SystemNetworkSynchingServerGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemNetworkSynchingServerGetListResponse> SystemNetworkSynchingServerGetListRequestAsync(this OcipClient client, SystemNetworkSynchingServerGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkSynchingServerGetListResponse;
        }
        /// <summary>
        /// Request to modify a Network Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// becomePreferred
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// order
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkSynchingServerModifyRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemNetworkSynchingServerModifyRequest22(this OcipClient client, SystemNetworkSynchingServerModifyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Network Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// becomePreferred
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// order
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkSynchingServerModifyRequest22Async(this OcipClient client, SystemNetworkSynchingServerModifyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the number activation state and enterprise trunk number range activation status.
        /// The response is either SystemNumberActivationGetResponse21 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberActivationGetRequest21Async instead.")]
        public static async Task<SystemNumberActivationGetResponse21> SystemNumberActivationGetRequest21(this OcipClient client, SystemNumberActivationGetRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNumberActivationGetResponse21;
        }

        /// <summary>
        /// Request to get the number activation state and enterprise trunk number range activation status.
        /// The response is either SystemNumberActivationGetResponse21 or ErrorResponse.
        /// </summary>
        public static async Task<SystemNumberActivationGetResponse21> SystemNumberActivationGetRequest21Async(this OcipClient client, SystemNumberActivationGetRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNumberActivationGetResponse21;
        }
        /// <summary>
        /// Request to modify system number activation and enterprise trunk number range activation setting.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following element values are only applicable in AS data mode:
        /// enableEnterpriseTrunkNumberRangeActivation
        /// numberActivationMode = Group And User Activation Enabled will raise an error in XS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberActivationModifyRequest18sp1Async instead.")]
        public static async Task<SuccessResponse> SystemNumberActivationModifyRequest18sp1(this OcipClient client, SystemNumberActivationModifyRequest18sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify system number activation and enterprise trunk number range activation setting.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following element values are only applicable in AS data mode:
        /// enableEnterpriseTrunkNumberRangeActivation
        /// numberActivationMode = Group And User Activation Enabled will raise an error in XS data mode.
        /// </summary>
        public static async Task<SuccessResponse> SystemNumberActivationModifyRequest18sp1Async(this OcipClient client, SystemNumberActivationModifyRequest18sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a System Number Portability Query Status Digit Pattern mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryDigitPatternAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryDigitPatternAddRequest(this OcipClient client, SystemNumberPortabilityQueryDigitPatternAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a System Number Portability Query Status Digit Pattern mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryDigitPatternAddRequestAsync(this OcipClient client, SystemNumberPortabilityQueryDigitPatternAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a list of System Number Portability Status Digit Pattern mappings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryDigitPatternDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryDigitPatternDeleteListRequest(this OcipClient client, SystemNumberPortabilityQueryDigitPatternDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a list of System Number Portability Status Digit Pattern mappings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryDigitPatternDeleteListRequestAsync(this OcipClient client, SystemNumberPortabilityQueryDigitPatternDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the System Number Portability Query Digit Pattern List information.
        /// The response is either a SystemNumberPortabilityQueryDigitPatternGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryDigitPatternGetListRequestAsync instead.")]
        public static async Task<SystemNumberPortabilityQueryDigitPatternGetListResponse> SystemNumberPortabilityQueryDigitPatternGetListRequest(this OcipClient client, SystemNumberPortabilityQueryDigitPatternGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNumberPortabilityQueryDigitPatternGetListResponse;
        }

        /// <summary>
        /// Request to get the System Number Portability Query Digit Pattern List information.
        /// The response is either a SystemNumberPortabilityQueryDigitPatternGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemNumberPortabilityQueryDigitPatternGetListResponse> SystemNumberPortabilityQueryDigitPatternGetListRequestAsync(this OcipClient client, SystemNumberPortabilityQueryDigitPatternGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNumberPortabilityQueryDigitPatternGetListResponse;
        }
        /// <summary>
        /// Request to get a System Number Portability Status Digit Pattern mapping.
        /// The response is either a SystemNumberPortabilityQueryDigitPatternGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryDigitPatternGetRequestAsync instead.")]
        public static async Task<SystemNumberPortabilityQueryDigitPatternGetResponse> SystemNumberPortabilityQueryDigitPatternGetRequest(this OcipClient client, SystemNumberPortabilityQueryDigitPatternGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNumberPortabilityQueryDigitPatternGetResponse;
        }

        /// <summary>
        /// Request to get a System Number Portability Status Digit Pattern mapping.
        /// The response is either a SystemNumberPortabilityQueryDigitPatternGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemNumberPortabilityQueryDigitPatternGetResponse> SystemNumberPortabilityQueryDigitPatternGetRequestAsync(this OcipClient client, SystemNumberPortabilityQueryDigitPatternGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNumberPortabilityQueryDigitPatternGetResponse;
        }
        /// <summary>
        /// Request to modify a System Number Portability Status Digit Pattern mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryDigitPatternModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryDigitPatternModifyRequest(this OcipClient client, SystemNumberPortabilityQueryDigitPatternModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a System Number Portability Status Digit Pattern mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryDigitPatternModifyRequestAsync(this OcipClient client, SystemNumberPortabilityQueryDigitPatternModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get system Number Portability Query Parameters.
        /// The response is either SystemNumberPortabilityQueryGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryGetRequestAsync instead.")]
        public static async Task<SystemNumberPortabilityQueryGetResponse> SystemNumberPortabilityQueryGetRequest(this OcipClient client, SystemNumberPortabilityQueryGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNumberPortabilityQueryGetResponse;
        }

        /// <summary>
        /// Get system Number Portability Query Parameters.
        /// The response is either SystemNumberPortabilityQueryGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemNumberPortabilityQueryGetResponse> SystemNumberPortabilityQueryGetRequestAsync(this OcipClient client, SystemNumberPortabilityQueryGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNumberPortabilityQueryGetResponse;
        }
        /// <summary>
        /// Modify system Number Portability Query Parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryModifyRequest(this OcipClient client, SystemNumberPortabilityQueryModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify system Number Portability Query Parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryModifyRequestAsync(this OcipClient client, SystemNumberPortabilityQueryModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a system number portability status information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryStatusAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryStatusAddRequest(this OcipClient client, SystemNumberPortabilityQueryStatusAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a system number portability status information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryStatusAddRequestAsync(this OcipClient client, SystemNumberPortabilityQueryStatusAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of system number portability query statuses.
        /// The number of status entries is limited to 100.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryStatusDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryStatusDeleteListRequest(this OcipClient client, SystemNumberPortabilityQueryStatusDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of system number portability query statuses.
        /// The number of status entries is limited to 100.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryStatusDeleteListRequestAsync(this OcipClient client, SystemNumberPortabilityQueryStatusDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list system Number Portability Query Statuses.
        /// The response is either SystemNumberPortabilityQueryStatusGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryStatusGetListRequestAsync instead.")]
        public static async Task<SystemNumberPortabilityQueryStatusGetListResponse> SystemNumberPortabilityQueryStatusGetListRequest(this OcipClient client, SystemNumberPortabilityQueryStatusGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNumberPortabilityQueryStatusGetListResponse;
        }

        /// <summary>
        /// Get a list system Number Portability Query Statuses.
        /// The response is either SystemNumberPortabilityQueryStatusGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemNumberPortabilityQueryStatusGetListResponse> SystemNumberPortabilityQueryStatusGetListRequestAsync(this OcipClient client, SystemNumberPortabilityQueryStatusGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNumberPortabilityQueryStatusGetListResponse;
        }
        /// <summary>
        /// Get information for a system Number Portability Query Status.
        /// The response is either SystemNumberPortabilityQueryStatusGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryStatusGetRequestAsync instead.")]
        public static async Task<SystemNumberPortabilityQueryStatusGetResponse> SystemNumberPortabilityQueryStatusGetRequest(this OcipClient client, SystemNumberPortabilityQueryStatusGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNumberPortabilityQueryStatusGetResponse;
        }

        /// <summary>
        /// Get information for a system Number Portability Query Status.
        /// The response is either SystemNumberPortabilityQueryStatusGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemNumberPortabilityQueryStatusGetResponse> SystemNumberPortabilityQueryStatusGetRequestAsync(this OcipClient client, SystemNumberPortabilityQueryStatusGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNumberPortabilityQueryStatusGetResponse;
        }
        /// <summary>
        /// Modify the system number portability status information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberPortabilityQueryStatusModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryStatusModifyRequest(this OcipClient client, SystemNumberPortabilityQueryStatusModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system number portability status information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNumberPortabilityQueryStatusModifyRequestAsync(this OcipClient client, SystemNumberPortabilityQueryStatusModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an entry to the OCI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIAddACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCIAddACLEntryRequest(this OcipClient client, SystemOCIAddACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an entry to the OCI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCIAddACLEntryRequestAsync(this OcipClient client, SystemOCIAddACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an entry to the OCI call control access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlAddACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlAddACLEntryRequest(this OcipClient client, SystemOCICallControlAddACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an entry to the OCI call control access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlAddACLEntryRequestAsync(this OcipClient client, SystemOCICallControlAddACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an entry to the OCI call control application access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlApplicationAddACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlApplicationAddACLEntryRequest(this OcipClient client, SystemOCICallControlApplicationAddACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an entry to the OCI call control application access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlApplicationAddACLEntryRequestAsync(this OcipClient client, SystemOCICallControlApplicationAddACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an application to the OCI call control application list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlApplicationAddRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlApplicationAddRequest22(this OcipClient client, SystemOCICallControlApplicationAddRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an application to the OCI call control application list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlApplicationAddRequest22Async(this OcipClient client, SystemOCICallControlApplicationAddRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an entry from the OCI call control application access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlApplicationDeleteACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlApplicationDeleteACLEntryRequest(this OcipClient client, SystemOCICallControlApplicationDeleteACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry from the OCI call control application access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlApplicationDeleteACLEntryRequestAsync(this OcipClient client, SystemOCICallControlApplicationDeleteACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an entry from the OCI call control application list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlApplicationDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlApplicationDeleteRequest(this OcipClient client, SystemOCICallControlApplicationDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry from the OCI call control application list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlApplicationDeleteRequestAsync(this OcipClient client, SystemOCICallControlApplicationDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the OCI call control access control list.
        /// The response is either SystemOCICallControlApplicationGetACLListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlApplicationGetACLListRequestAsync instead.")]
        public static async Task<SystemOCICallControlApplicationGetACLListResponse> SystemOCICallControlApplicationGetACLListRequest(this OcipClient client, SystemOCICallControlApplicationGetACLListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOCICallControlApplicationGetACLListResponse;
        }

        /// <summary>
        /// Get the OCI call control access control list.
        /// The response is either SystemOCICallControlApplicationGetACLListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemOCICallControlApplicationGetACLListResponse> SystemOCICallControlApplicationGetACLListRequestAsync(this OcipClient client, SystemOCICallControlApplicationGetACLListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOCICallControlApplicationGetACLListResponse;
        }
        /// <summary>
        /// Get the OCI call control application list.
        /// The response is either SystemOCICallControlApplicationGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlApplicationGetListRequestAsync instead.")]
        public static async Task<SystemOCICallControlApplicationGetListResponse> SystemOCICallControlApplicationGetListRequest(this OcipClient client, SystemOCICallControlApplicationGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOCICallControlApplicationGetListResponse;
        }

        /// <summary>
        /// Get the OCI call control application list.
        /// The response is either SystemOCICallControlApplicationGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemOCICallControlApplicationGetListResponse> SystemOCICallControlApplicationGetListRequestAsync(this OcipClient client, SystemOCICallControlApplicationGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOCICallControlApplicationGetListResponse;
        }
        /// <summary>
        /// Modify an entry from the call control access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlApplicationModifyACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlApplicationModifyACLEntryRequest(this OcipClient client, SystemOCICallControlApplicationModifyACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an entry from the call control access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlApplicationModifyACLEntryRequestAsync(this OcipClient client, SystemOCICallControlApplicationModifyACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify an application from the OCI call control application list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlApplicationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlApplicationModifyRequest(this OcipClient client, SystemOCICallControlApplicationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an application from the OCI call control application list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlApplicationModifyRequestAsync(this OcipClient client, SystemOCICallControlApplicationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an entry from the OCI call control access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlDeleteACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlDeleteACLEntryRequest(this OcipClient client, SystemOCICallControlDeleteACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry from the OCI call control access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlDeleteACLEntryRequestAsync(this OcipClient client, SystemOCICallControlDeleteACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the OCI call control access control list.
        /// The response is either SystemOCICallControlGetACLListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlGetACLListRequestAsync instead.")]
        public static async Task<SystemOCICallControlGetACLListResponse> SystemOCICallControlGetACLListRequest(this OcipClient client, SystemOCICallControlGetACLListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOCICallControlGetACLListResponse;
        }

        /// <summary>
        /// Get the OCI call control access control list.
        /// The response is either SystemOCICallControlGetACLListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemOCICallControlGetACLListResponse> SystemOCICallControlGetACLListRequestAsync(this OcipClient client, SystemOCICallControlGetACLListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOCICallControlGetACLListResponse;
        }
        /// <summary>
        /// Modify an entry from the call control access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlModifyACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlModifyACLEntryRequest(this OcipClient client, SystemOCICallControlModifyACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an entry from the call control access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlModifyACLEntryRequestAsync(this OcipClient client, SystemOCICallControlModifyACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an entry from the OCI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIDeleteACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCIDeleteACLEntryRequest(this OcipClient client, SystemOCIDeleteACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry from the OCI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCIDeleteACLEntryRequestAsync(this OcipClient client, SystemOCIDeleteACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the OCI access control list.
        /// The response is either SystemOCIGetACLListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIGetACLListRequestAsync instead.")]
        public static async Task<SystemOCIGetACLListResponse> SystemOCIGetACLListRequest(this OcipClient client, SystemOCIGetACLListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOCIGetACLListResponse;
        }

        /// <summary>
        /// Get the OCI access control list.
        /// The response is either SystemOCIGetACLListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemOCIGetACLListResponse> SystemOCIGetACLListRequestAsync(this OcipClient client, SystemOCIGetACLListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOCIGetACLListResponse;
        }
        /// <summary>
        /// Modify an entry in the OCI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIModifyACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCIModifyACLEntryRequest(this OcipClient client, SystemOCIModifyACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an entry in the OCI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCIModifyACLEntryRequestAsync(this OcipClient client, SystemOCIModifyACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an entry to the OCI Reporting Access Control List.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingAddACLEntryRequest13mp9Async instead.")]
        public static async Task<SuccessResponse> SystemOCIReportingAddACLEntryRequest13mp9(this OcipClient client, SystemOCIReportingAddACLEntryRequest13mp9 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an entry to the OCI Reporting Access Control List.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCIReportingAddACLEntryRequest13mp9Async(this OcipClient client, SystemOCIReportingAddACLEntryRequest13mp9 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a list of reported messages for a host in the OCI Reporting
        /// Access Control List. The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingAddMessageNameListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCIReportingAddMessageNameListRequest(this OcipClient client, SystemOCIReportingAddMessageNameListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of reported messages for a host in the OCI Reporting
        /// Access Control List. The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCIReportingAddMessageNameListRequestAsync(this OcipClient client, SystemOCIReportingAddMessageNameListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an entry from the OCI Reporting Access Control List.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingDeleteACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCIReportingDeleteACLEntryRequest(this OcipClient client, SystemOCIReportingDeleteACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry from the OCI Reporting Access Control List.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCIReportingDeleteACLEntryRequestAsync(this OcipClient client, SystemOCIReportingDeleteACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of reported messages from a host in the OCI Reporting
        /// Access Control List. The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingDeleteMessageNameListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCIReportingDeleteMessageNameListRequest(this OcipClient client, SystemOCIReportingDeleteMessageNameListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of reported messages from a host in the OCI Reporting
        /// Access Control List. The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCIReportingDeleteMessageNameListRequestAsync(this OcipClient client, SystemOCIReportingDeleteMessageNameListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the OCI Reporting Access Control List.
        /// The response is either a SystemOCIReportingGetACLListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingGetACLListRequestAsync instead.")]
        public static async Task<SystemOCIReportingGetACLListResponse> SystemOCIReportingGetACLListRequest(this OcipClient client, SystemOCIReportingGetACLListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOCIReportingGetACLListResponse;
        }

        /// <summary>
        /// Get the OCI Reporting Access Control List.
        /// The response is either a SystemOCIReportingGetACLListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemOCIReportingGetACLListResponse> SystemOCIReportingGetACLListRequestAsync(this OcipClient client, SystemOCIReportingGetACLListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOCIReportingGetACLListResponse;
        }
        /// <summary>
        /// Get a list of restricted messages from a host in the OCI Reporting
        /// Access Control List. The response is either a SystemOCIReportingGetMessageNameListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingGetMessageNameListRequestAsync instead.")]
        public static async Task<SystemOCIReportingGetMessageNameListResponse> SystemOCIReportingGetMessageNameListRequest(this OcipClient client, SystemOCIReportingGetMessageNameListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOCIReportingGetMessageNameListResponse;
        }

        /// <summary>
        /// Get a list of restricted messages from a host in the OCI Reporting
        /// Access Control List. The response is either a SystemOCIReportingGetMessageNameListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemOCIReportingGetMessageNameListResponse> SystemOCIReportingGetMessageNameListRequestAsync(this OcipClient client, SystemOCIReportingGetMessageNameListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOCIReportingGetMessageNameListResponse;
        }
        /// <summary>
        /// Modify the description on an entry in the OCI Reporting Access Control List.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingModifyACLEntryRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCIReportingModifyACLEntryRequest(this OcipClient client, SystemOCIReportingModifyACLEntryRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the description on an entry in the OCI Reporting Access Control List.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCIReportingModifyACLEntryRequestAsync(this OcipClient client, SystemOCIReportingModifyACLEntryRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of OCIReporting system parameters.
        /// The response is either SystemOCIReportingParametersGetResponse14sp1 or
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingParametersGetRequest14sp1Async instead.")]
        public static async Task<SystemOCIReportingParametersGetResponse14sp1> SystemOCIReportingParametersGetRequest14sp1(this OcipClient client, SystemOCIReportingParametersGetRequest14sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOCIReportingParametersGetResponse14sp1;
        }

        /// <summary>
        /// Request to get the list of OCIReporting system parameters.
        /// The response is either SystemOCIReportingParametersGetResponse14sp1 or
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemOCIReportingParametersGetResponse14sp1> SystemOCIReportingParametersGetRequest14sp1Async(this OcipClient client, SystemOCIReportingParametersGetRequest14sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOCIReportingParametersGetResponse14sp1;
        }
        /// <summary>
        /// Request to get the list of OCIReporting system parameters.
        /// The response is either SystemOCIReportingParametersGetResponse22 or
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingParametersGetRequest22Async instead.")]
        public static async Task<SystemOCIReportingParametersGetResponse22> SystemOCIReportingParametersGetRequest22(this OcipClient client, SystemOCIReportingParametersGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOCIReportingParametersGetResponse22;
        }

        /// <summary>
        /// Request to get the list of OCIReporting system parameters.
        /// The response is either SystemOCIReportingParametersGetResponse22 or
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemOCIReportingParametersGetResponse22> SystemOCIReportingParametersGetRequest22Async(this OcipClient client, SystemOCIReportingParametersGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOCIReportingParametersGetResponse22;
        }
        /// <summary>
        /// Request to modify OCI Reporting system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCIReportingParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOCIReportingParametersModifyRequest(this OcipClient client, SystemOCIReportingParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify OCI Reporting system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCIReportingParametersModifyRequestAsync(this OcipClient client, SystemOCIReportingParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Office Zone.  The zoneList is an ordered list with the first member being of the highest priority.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOfficeZoneAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOfficeZoneAddRequest(this OcipClient client, SystemOfficeZoneAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Office Zone.  The zoneList is an ordered list with the first member being of the highest priority.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOfficeZoneAddRequestAsync(this OcipClient client, SystemOfficeZoneAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an Office Zone.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOfficeZoneDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOfficeZoneDeleteRequest(this OcipClient client, SystemOfficeZoneDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an Office Zone.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOfficeZoneDeleteRequestAsync(this OcipClient client, SystemOfficeZoneDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a list of service providers that have a given Office Zone assigned.  The response is either a SystemOfficeZoneGetAssignedServiceProviderListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOfficeZoneGetAssignedServiceProviderListRequestAsync instead.")]
        public static async Task<SystemOfficeZoneGetAssignedServiceProviderListResponse> SystemOfficeZoneGetAssignedServiceProviderListRequest(this OcipClient client, SystemOfficeZoneGetAssignedServiceProviderListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOfficeZoneGetAssignedServiceProviderListResponse;
        }

        /// <summary>
        /// Request a list of service providers that have a given Office Zone assigned.  The response is either a SystemOfficeZoneGetAssignedServiceProviderListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemOfficeZoneGetAssignedServiceProviderListResponse> SystemOfficeZoneGetAssignedServiceProviderListRequestAsync(this OcipClient client, SystemOfficeZoneGetAssignedServiceProviderListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOfficeZoneGetAssignedServiceProviderListResponse;
        }
        /// <summary>
        /// Get the list of all Office Zones.
        /// The response is either a SystemOfficeZoneGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOfficeZoneGetListRequestAsync instead.")]
        public static async Task<SystemOfficeZoneGetListResponse> SystemOfficeZoneGetListRequest(this OcipClient client, SystemOfficeZoneGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOfficeZoneGetListResponse;
        }

        /// <summary>
        /// Get the list of all Office Zones.
        /// The response is either a SystemOfficeZoneGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemOfficeZoneGetListResponse> SystemOfficeZoneGetListRequestAsync(this OcipClient client, SystemOfficeZoneGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOfficeZoneGetListResponse;
        }
        /// <summary>
        /// Get an existing Office Zone.
        /// The response is either a SystemOfficeZoneGetResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOfficeZoneGetRequestAsync instead.")]
        public static async Task<SystemOfficeZoneGetResponse> SystemOfficeZoneGetRequest(this OcipClient client, SystemOfficeZoneGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOfficeZoneGetResponse;
        }

        /// <summary>
        /// Get an existing Office Zone.
        /// The response is either a SystemOfficeZoneGetResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemOfficeZoneGetResponse> SystemOfficeZoneGetRequestAsync(this OcipClient client, SystemOfficeZoneGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOfficeZoneGetResponse;
        }
        /// <summary>
        /// Get the list of Office Zones that contain a specific
        /// Zone.
        /// The response is either a SystemOfficeZoneGetZoneUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOfficeZoneGetZoneUsageListRequestAsync instead.")]
        public static async Task<SystemOfficeZoneGetZoneUsageListResponse> SystemOfficeZoneGetZoneUsageListRequest(this OcipClient client, SystemOfficeZoneGetZoneUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOfficeZoneGetZoneUsageListResponse;
        }

        /// <summary>
        /// Get the list of Office Zones that contain a specific
        /// Zone.
        /// The response is either a SystemOfficeZoneGetZoneUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemOfficeZoneGetZoneUsageListResponse> SystemOfficeZoneGetZoneUsageListRequestAsync(this OcipClient client, SystemOfficeZoneGetZoneUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOfficeZoneGetZoneUsageListResponse;
        }
        /// <summary>
        /// Modify an existing Office Zone.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOfficeZoneModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOfficeZoneModifyRequest(this OcipClient client, SystemOfficeZoneModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing Office Zone.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOfficeZoneModifyRequestAsync(this OcipClient client, SystemOfficeZoneModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the system's password rules setting applicable to
        /// System administrator, Provisioning Administrator,
        /// and/or Service Provider Administrator, Group Administrator, Department Administrator, user.
        /// The response is either SystemPasswordRulesGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPasswordRulesGetRequest22Async instead.")]
        public static async Task<SystemPasswordRulesGetResponse22> SystemPasswordRulesGetRequest22(this OcipClient client, SystemPasswordRulesGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPasswordRulesGetResponse22;
        }

        /// <summary>
        /// Requests the system's password rules setting applicable to
        /// System administrator, Provisioning Administrator,
        /// and/or Service Provider Administrator, Group Administrator, Department Administrator, user.
        /// The response is either SystemPasswordRulesGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemPasswordRulesGetResponse22> SystemPasswordRulesGetRequest22Async(this OcipClient client, SystemPasswordRulesGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPasswordRulesGetResponse22;
        }
        /// <summary>
        /// Request to modify the system providers password rule
        /// setting applicable to System Adminstrator, Provisioning Administrator,
        /// and/or Service Provider Administrator, Group Administrator, Department Administrator, User.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// forcePasswordChangeAfterReset
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPasswordRulesModifyRequest14sp3Async instead.")]
        public static async Task<SuccessResponse> SystemPasswordRulesModifyRequest14sp3(this OcipClient client, SystemPasswordRulesModifyRequest14sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system providers password rule
        /// setting applicable to System Adminstrator, Provisioning Administrator,
        /// and/or Service Provider Administrator, Group Administrator, Department Administrator, User.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// forcePasswordChangeAfterReset
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPasswordRulesModifyRequest14sp3Async(this OcipClient client, SystemPasswordRulesModifyRequest14sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the password security parameters for the system.
        /// The response is either a SystemPasswordSecurityParametersGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPasswordSecurityParametersGetRequestAsync instead.")]
        public static async Task<SystemPasswordSecurityParametersGetResponse> SystemPasswordSecurityParametersGetRequest(this OcipClient client, SystemPasswordSecurityParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPasswordSecurityParametersGetResponse;
        }

        /// <summary>
        /// Get the password security parameters for the system.
        /// The response is either a SystemPasswordSecurityParametersGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemPasswordSecurityParametersGetResponse> SystemPasswordSecurityParametersGetRequestAsync(this OcipClient client, SystemPasswordSecurityParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPasswordSecurityParametersGetResponse;
        }
        /// <summary>
        /// Modify the password security settings for the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPasswordSecurityParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPasswordSecurityParametersModifyRequest(this OcipClient client, SystemPasswordSecurityParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the password security settings for the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPasswordSecurityParametersModifyRequestAsync(this OcipClient client, SystemPasswordSecurityParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Generate a performance measurements report.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementGenerateReportRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPerformanceMeasurementGenerateReportRequest(this OcipClient client, SystemPerformanceMeasurementGenerateReportRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Generate a performance measurements report.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPerformanceMeasurementGenerateReportRequestAsync(this OcipClient client, SystemPerformanceMeasurementGenerateReportRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingAddFileServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingAddFileServerRequest(this OcipClient client, SystemPerformanceMeasurementReportingAddFileServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingAddFileServerRequestAsync(this OcipClient client, SystemPerformanceMeasurementReportingAddFileServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingDeleteFileServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingDeleteFileServerRequest(this OcipClient client, SystemPerformanceMeasurementReportingDeleteFileServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingDeleteFileServerRequestAsync(this OcipClient client, SystemPerformanceMeasurementReportingDeleteFileServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list performance measurements reporting ftp servers.
        /// The response is either SystemPerformanceMeasurementReportingGetFileServerListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingGetFileServerListRequestAsync instead.")]
        public static async Task<SystemPerformanceMeasurementReportingGetFileServerListResponse> SystemPerformanceMeasurementReportingGetFileServerListRequest(this OcipClient client, SystemPerformanceMeasurementReportingGetFileServerListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPerformanceMeasurementReportingGetFileServerListResponse;
        }

        /// <summary>
        /// Requests the list performance measurements reporting ftp servers.
        /// The response is either SystemPerformanceMeasurementReportingGetFileServerListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemPerformanceMeasurementReportingGetFileServerListResponse> SystemPerformanceMeasurementReportingGetFileServerListRequestAsync(this OcipClient client, SystemPerformanceMeasurementReportingGetFileServerListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPerformanceMeasurementReportingGetFileServerListResponse;
        }
        /// <summary>
        /// Add a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingAddFileServerRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingAddFileServerRequest22(this OcipClient client, SystemPerformanceMeasurementReportingAddFileServerRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingAddFileServerRequest22Async(this OcipClient client, SystemPerformanceMeasurementReportingAddFileServerRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingDeleteFileServerRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingDeleteFileServerRequest22(this OcipClient client, SystemPerformanceMeasurementReportingDeleteFileServerRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingDeleteFileServerRequest22Async(this OcipClient client, SystemPerformanceMeasurementReportingDeleteFileServerRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list performance measurements reporting ftp servers.
        /// The response is either SystemPerformanceMeasurementReportingGetFileServerListResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingGetFileServerListRequest22Async instead.")]
        public static async Task<SystemPerformanceMeasurementReportingGetFileServerListResponse22> SystemPerformanceMeasurementReportingGetFileServerListRequest22(this OcipClient client, SystemPerformanceMeasurementReportingGetFileServerListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPerformanceMeasurementReportingGetFileServerListResponse22;
        }

        /// <summary>
        /// Requests the list performance measurements reporting ftp servers.
        /// The response is either SystemPerformanceMeasurementReportingGetFileServerListResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemPerformanceMeasurementReportingGetFileServerListResponse22> SystemPerformanceMeasurementReportingGetFileServerListRequest22Async(this OcipClient client, SystemPerformanceMeasurementReportingGetFileServerListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPerformanceMeasurementReportingGetFileServerListResponse22;
        }
        /// <summary>
        /// Requests the performance measurements reporting settings.
        /// The response is either SystemPerformanceMeasurementReportingGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingGetRequest22Async instead.")]
        public static async Task<SystemPerformanceMeasurementReportingGetResponse22> SystemPerformanceMeasurementReportingGetRequest22(this OcipClient client, SystemPerformanceMeasurementReportingGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPerformanceMeasurementReportingGetResponse22;
        }

        /// <summary>
        /// Requests the performance measurements reporting settings.
        /// The response is either SystemPerformanceMeasurementReportingGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemPerformanceMeasurementReportingGetResponse22> SystemPerformanceMeasurementReportingGetRequest22Async(this OcipClient client, SystemPerformanceMeasurementReportingGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPerformanceMeasurementReportingGetResponse22;
        }
        /// <summary>
        /// Modify a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingModifyFileServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingModifyFileServerRequest(this OcipClient client, SystemPerformanceMeasurementReportingModifyFileServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingModifyFileServerRequestAsync(this OcipClient client, SystemPerformanceMeasurementReportingModifyFileServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingModifyFileServerRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingModifyFileServerRequest22(this OcipClient client, SystemPerformanceMeasurementReportingModifyFileServerRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a performance measurements reporting ftp server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingModifyFileServerRequest22Async(this OcipClient client, SystemPerformanceMeasurementReportingModifyFileServerRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the performance measurements reporting settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPerformanceMeasurementReportingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingModifyRequest(this OcipClient client, SystemPerformanceMeasurementReportingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the performance measurements reporting settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPerformanceMeasurementReportingModifyRequestAsync(this OcipClient client, SystemPerformanceMeasurementReportingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPolicyGetDefaultRequest22Async instead.")]
        public static async Task<SystemPolicyGetDefaultResponse22> SystemPolicyGetDefaultRequest22(this OcipClient client, SystemPolicyGetDefaultRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPolicyGetDefaultResponse22;
        }

        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemPolicyGetDefaultResponse22> SystemPolicyGetDefaultRequest22Async(this OcipClient client, SystemPolicyGetDefaultRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPolicyGetDefaultResponse22;
        }
        /// <summary>
        /// Request to modify the system's default policy settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// GroupAdminDialableCallerIDAccess
        /// ServiceProviderAdminDialableCallerIDAccess
        /// GroupAdminCommunicationBarringUserProfileAccess (This element is only used for groups in an Enterprise)
        /// GroupAdminVerifyTranslationAndRoutingAccess
        /// ServiceProviderVerifyTranslationAndRoutingAccess
        /// groupUserAutoAttendantNameDialingAccess
        /// The following elements are only used in XS data mode:
        /// serviceProviderAdminCommunicationBarringAccess
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPolicyModifyDefaultRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemPolicyModifyDefaultRequest22(this OcipClient client, SystemPolicyModifyDefaultRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system's default policy settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// GroupAdminDialableCallerIDAccess
        /// ServiceProviderAdminDialableCallerIDAccess
        /// GroupAdminCommunicationBarringUserProfileAccess (This element is only used for groups in an Enterprise)
        /// GroupAdminVerifyTranslationAndRoutingAccess
        /// ServiceProviderVerifyTranslationAndRoutingAccess
        /// groupUserAutoAttendantNameDialingAccess
        /// The following elements are only used in XS data mode:
        /// serviceProviderAdminCommunicationBarringAccess
        /// </summary>
        public static async Task<SuccessResponse> SystemPolicyModifyDefaultRequest22Async(this OcipClient client, SystemPolicyModifyDefaultRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the system passcode rules setting.
        /// The response is either SystemPortalPasscodeRulesGetResponse19 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPortalPasscodeRulesGetRequest19Async instead.")]
        public static async Task<SystemPortalPasscodeRulesGetResponse19> SystemPortalPasscodeRulesGetRequest19(this OcipClient client, SystemPortalPasscodeRulesGetRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPortalPasscodeRulesGetResponse19;
        }

        /// <summary>
        /// Requests the system passcode rules setting.
        /// The response is either SystemPortalPasscodeRulesGetResponse19 or ErrorResponse.
        /// </summary>
        public static async Task<SystemPortalPasscodeRulesGetResponse19> SystemPortalPasscodeRulesGetRequest19Async(this OcipClient client, SystemPortalPasscodeRulesGetRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPortalPasscodeRulesGetResponse19;
        }
        /// <summary>
        /// Request to modify the system passcode rules setting.
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
        [Obsolete("This method is deprecated. Use SystemPortalPasscodeRulesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPortalPasscodeRulesModifyRequest(this OcipClient client, SystemPortalPasscodeRulesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system passcode rules setting.
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
        public static async Task<SuccessResponse> SystemPortalPasscodeRulesModifyRequestAsync(this OcipClient client, SystemPortalPasscodeRulesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the system's provisioning validation attributes.
        /// The response is either a SystemProvisioningValidationGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemProvisioningValidationGetRequest22Async instead.")]
        public static async Task<SystemProvisioningValidationGetResponse22> SystemProvisioningValidationGetRequest22(this OcipClient client, SystemProvisioningValidationGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemProvisioningValidationGetResponse22;
        }

        /// <summary>
        /// Request to get the system's provisioning validation attributes.
        /// The response is either a SystemProvisioningValidationGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemProvisioningValidationGetResponse22> SystemProvisioningValidationGetRequest22Async(this OcipClient client, SystemProvisioningValidationGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemProvisioningValidationGetResponse22;
        }
        /// <summary>
        /// Request to modify the system's provisioning validation attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// denyMobilityNumberAsRedirectionDestination
        /// denyEnterpriseNumberAsNetworkLocationDestination
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemProvisioningValidationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemProvisioningValidationModifyRequest(this OcipClient client, SystemProvisioningValidationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system's provisioning validation attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// denyMobilityNumberAsRedirectionDestination
        /// denyEnterpriseNumberAsNetworkLocationDestination
        /// </summary>
        public static async Task<SuccessResponse> SystemProvisioningValidationModifyRequestAsync(this OcipClient client, SystemProvisioningValidationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add an application to the list of allowed push notification applications.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPushNotificationAllowedApplicationAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPushNotificationAllowedApplicationAddRequest(this OcipClient client, SystemPushNotificationAllowedApplicationAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add an application to the list of allowed push notification applications.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPushNotificationAllowedApplicationAddRequestAsync(this OcipClient client, SystemPushNotificationAllowedApplicationAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to remove an application from the list of allowed push notification applications.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPushNotificationAllowedApplicationDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPushNotificationAllowedApplicationDeleteRequest(this OcipClient client, SystemPushNotificationAllowedApplicationDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to remove an application from the list of allowed push notification applications.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPushNotificationAllowedApplicationDeleteRequestAsync(this OcipClient client, SystemPushNotificationAllowedApplicationDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of allowed push notification applications.
        /// The response is either SystemPushNotificationAllowedApplicationGetListResponse or
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPushNotificationAllowedApplicationGetListRequestAsync instead.")]
        public static async Task<SystemPushNotificationAllowedApplicationGetListResponse> SystemPushNotificationAllowedApplicationGetListRequest(this OcipClient client, SystemPushNotificationAllowedApplicationGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPushNotificationAllowedApplicationGetListResponse;
        }

        /// <summary>
        /// Request to get the list of allowed push notification applications.
        /// The response is either SystemPushNotificationAllowedApplicationGetListResponse or
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemPushNotificationAllowedApplicationGetListResponse> SystemPushNotificationAllowedApplicationGetListRequestAsync(this OcipClient client, SystemPushNotificationAllowedApplicationGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPushNotificationAllowedApplicationGetListResponse;
        }
        /// <summary>
        /// Request to modify an application in the list of allowed push notification applications.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPushNotificationAllowedApplicationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPushNotificationAllowedApplicationModifyRequest(this OcipClient client, SystemPushNotificationAllowedApplicationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an application in the list of allowed push notification applications.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPushNotificationAllowedApplicationModifyRequestAsync(this OcipClient client, SystemPushNotificationAllowedApplicationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of push notification system parameters.
        /// The response is either SystemPushNotificationParametersGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPushNotificationParametersGetRequestAsync instead.")]
        public static async Task<SystemPushNotificationParametersGetResponse> SystemPushNotificationParametersGetRequest(this OcipClient client, SystemPushNotificationParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPushNotificationParametersGetResponse;
        }

        /// <summary>
        /// Request to get the list of push notification system parameters.
        /// The response is either SystemPushNotificationParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemPushNotificationParametersGetResponse> SystemPushNotificationParametersGetRequestAsync(this OcipClient client, SystemPushNotificationParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPushNotificationParametersGetResponse;
        }
        /// <summary>
        /// Request to modify push notification system parameters.
        /// 
        /// The following elements are only used in AS data mode and ignored in the Amplify data mode:
        /// subscriptionEventsPerSecond
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPushNotificationParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPushNotificationParametersModifyRequest(this OcipClient client, SystemPushNotificationParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify push notification system parameters.
        /// 
        /// The following elements are only used in AS data mode and ignored in the Amplify data mode:
        /// subscriptionEventsPerSecond
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPushNotificationParametersModifyRequestAsync(this OcipClient client, SystemPushNotificationParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Redundancy system parameters.
        /// The response is either SystemRedundancyParametersGetResponse16sp2 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRedundancyParametersGetRequest16sp2Async instead.")]
        public static async Task<SystemRedundancyParametersGetResponse16sp2> SystemRedundancyParametersGetRequest16sp2(this OcipClient client, SystemRedundancyParametersGetRequest16sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRedundancyParametersGetResponse16sp2;
        }

        /// <summary>
        /// Request to get the list of Redundancy system parameters.
        /// The response is either SystemRedundancyParametersGetResponse16sp2 or ErrorResponse.
        /// </summary>
        public static async Task<SystemRedundancyParametersGetResponse16sp2> SystemRedundancyParametersGetRequest16sp2Async(this OcipClient client, SystemRedundancyParametersGetRequest16sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRedundancyParametersGetResponse16sp2;
        }
        /// <summary>
        /// Request to modify Redundancy system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRedundancyParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRedundancyParametersModifyRequest(this OcipClient client, SystemRedundancyParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Redundancy system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRedundancyParametersModifyRequestAsync(this OcipClient client, SystemRedundancyParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Roaming Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoamingNetworkAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoamingNetworkAddRequest(this OcipClient client, SystemRoamingNetworkAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Roaming Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoamingNetworkAddRequestAsync(this OcipClient client, SystemRoamingNetworkAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Roaming Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoamingNetworkDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoamingNetworkDeleteRequest(this OcipClient client, SystemRoamingNetworkDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Roaming Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoamingNetworkDeleteRequestAsync(this OcipClient client, SystemRoamingNetworkDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all Roaming Networks.
        /// The response is either a SystemRoamingNetworkGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoamingNetworkGetListRequestAsync instead.")]
        public static async Task<SystemRoamingNetworkGetListResponse> SystemRoamingNetworkGetListRequest(this OcipClient client, SystemRoamingNetworkGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRoamingNetworkGetListResponse;
        }

        /// <summary>
        /// Get the list of all Roaming Networks.
        /// The response is either a SystemRoamingNetworkGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemRoamingNetworkGetListResponse> SystemRoamingNetworkGetListRequestAsync(this OcipClient client, SystemRoamingNetworkGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRoamingNetworkGetListResponse;
        }
        /// <summary>
        /// Modify a Roaming Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoamingNetworkModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoamingNetworkModifyRequest(this OcipClient client, SystemRoamingNetworkModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Roaming Network.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoamingNetworkModifyRequestAsync(this OcipClient client, SystemRoamingNetworkModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an Route Point External System, which is a cluster of Application
        /// Controllers.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutePointExternalSystemAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemAddRequest(this OcipClient client, SystemRoutePointExternalSystemAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an Route Point External System, which is a cluster of Application
        /// Controllers.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemAddRequestAsync(this OcipClient client, SystemRoutePointExternalSystemAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an application controller to Route Point External System.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutePointExternalSystemApplicationControllerAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemApplicationControllerAddListRequest(this OcipClient client, SystemRoutePointExternalSystemApplicationControllerAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an application controller to Route Point External System.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemApplicationControllerAddListRequestAsync(this OcipClient client, SystemRoutePointExternalSystemApplicationControllerAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an application controller for Route Point External System.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutePointExternalSystemApplicationControllerDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemApplicationControllerDeleteListRequest(this OcipClient client, SystemRoutePointExternalSystemApplicationControllerDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an application controller for Route Point External System.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemApplicationControllerDeleteListRequestAsync(this OcipClient client, SystemRoutePointExternalSystemApplicationControllerDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Application Controllers assigned to the Route Point External Systems specified.
        /// The response is either SystemRoutePointExternalSystemApplicationControllerGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutePointExternalSystemApplicationControllerGetRequestAsync instead.")]
        public static async Task<SystemRoutePointExternalSystemApplicationControllerGetResponse> SystemRoutePointExternalSystemApplicationControllerGetRequest(this OcipClient client, SystemRoutePointExternalSystemApplicationControllerGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRoutePointExternalSystemApplicationControllerGetResponse;
        }

        /// <summary>
        /// Get a list of Application Controllers assigned to the Route Point External Systems specified.
        /// The response is either SystemRoutePointExternalSystemApplicationControllerGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemRoutePointExternalSystemApplicationControllerGetResponse> SystemRoutePointExternalSystemApplicationControllerGetRequestAsync(this OcipClient client, SystemRoutePointExternalSystemApplicationControllerGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRoutePointExternalSystemApplicationControllerGetResponse;
        }
        /// <summary>
        /// Delete an Route Point External System.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutePointExternalSystemDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemDeleteRequest(this OcipClient client, SystemRoutePointExternalSystemDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an Route Point External System.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemDeleteRequestAsync(this OcipClient client, SystemRoutePointExternalSystemDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Route Point External Systems that are configured for the system.
        /// The response is either SystemRoutePointExternalSystemGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutePointExternalSystemGetListRequestAsync instead.")]
        public static async Task<SystemRoutePointExternalSystemGetListResponse> SystemRoutePointExternalSystemGetListRequest(this OcipClient client, SystemRoutePointExternalSystemGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRoutePointExternalSystemGetListResponse;
        }

        /// <summary>
        /// Get a list of Route Point External Systems that are configured for the system.
        /// The response is either SystemRoutePointExternalSystemGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemRoutePointExternalSystemGetListResponse> SystemRoutePointExternalSystemGetListRequestAsync(this OcipClient client, SystemRoutePointExternalSystemGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRoutePointExternalSystemGetListResponse;
        }
        /// <summary>
        /// Get a list of Route Points that are using the specified Route Point External System.
        /// The response is either a SystemRoutePointExternalSystemGetRoutePointListResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutePointExternalSystemGetRoutePointListRequestAsync instead.")]
        public static async Task<SystemRoutePointExternalSystemGetRoutePointListResponse> SystemRoutePointExternalSystemGetRoutePointListRequest(this OcipClient client, SystemRoutePointExternalSystemGetRoutePointListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRoutePointExternalSystemGetRoutePointListResponse;
        }

        /// <summary>
        /// Get a list of Route Points that are using the specified Route Point External System.
        /// The response is either a SystemRoutePointExternalSystemGetRoutePointListResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemRoutePointExternalSystemGetRoutePointListResponse> SystemRoutePointExternalSystemGetRoutePointListRequestAsync(this OcipClient client, SystemRoutePointExternalSystemGetRoutePointListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRoutePointExternalSystemGetRoutePointListResponse;
        }
        /// <summary>
        /// Modify an Route Point External System.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutePointExternalSystemModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemModifyRequest(this OcipClient client, SystemRoutePointExternalSystemModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an Route Point External System.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutePointExternalSystemModifyRequestAsync(this OcipClient client, SystemRoutePointExternalSystemModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a routing device to a route.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingAddRouteDeviceRequest14Async instead.")]
        public static async Task<SuccessResponse> SystemRoutingAddRouteDeviceRequest14(this OcipClient client, SystemRoutingAddRouteDeviceRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a routing device to a route.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutingAddRouteDeviceRequest14Async(this OcipClient client, SystemRoutingAddRouteDeviceRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a route to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingAddRouteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutingAddRouteRequest(this OcipClient client, SystemRoutingAddRouteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a route to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutingAddRouteRequestAsync(this OcipClient client, SystemRoutingAddRouteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a digit routing table entry to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingAddTranslationRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutingAddTranslationRequest(this OcipClient client, SystemRoutingAddTranslationRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a digit routing table entry to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutingAddTranslationRequestAsync(this OcipClient client, SystemRoutingAddTranslationRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a routing device from a route.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingDeleteRouteDeviceRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutingDeleteRouteDeviceRequest(this OcipClient client, SystemRoutingDeleteRouteDeviceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a routing device from a route.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutingDeleteRouteDeviceRequestAsync(this OcipClient client, SystemRoutingDeleteRouteDeviceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a route from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingDeleteRouteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutingDeleteRouteRequest(this OcipClient client, SystemRoutingDeleteRouteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a route from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutingDeleteRouteRequestAsync(this OcipClient client, SystemRoutingDeleteRouteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a digit routing table entry from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingDeleteTranslationRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutingDeleteTranslationRequest(this OcipClient client, SystemRoutingDeleteTranslationRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a digit routing table entry from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutingDeleteTranslationRequestAsync(this OcipClient client, SystemRoutingDeleteTranslationRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system's general routing attributes.
        /// The response is either a SystemRoutingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingGetRequestAsync instead.")]
        public static async Task<SystemRoutingGetResponse> SystemRoutingGetRequest(this OcipClient client, SystemRoutingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRoutingGetResponse;
        }

        /// <summary>
        /// Request the system's general routing attributes.
        /// The response is either a SystemRoutingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemRoutingGetResponse> SystemRoutingGetRequestAsync(this OcipClient client, SystemRoutingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRoutingGetResponse;
        }
        /// <summary>
        /// Request to get a list of devices for a route.
        /// The response is either a SystemRoutingGetRouteDeviceListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingGetRouteDeviceListRequestAsync instead.")]
        public static async Task<SystemRoutingGetRouteDeviceListResponse> SystemRoutingGetRouteDeviceListRequest(this OcipClient client, SystemRoutingGetRouteDeviceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRoutingGetRouteDeviceListResponse;
        }

        /// <summary>
        /// Request to get a list of devices for a route.
        /// The response is either a SystemRoutingGetRouteDeviceListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemRoutingGetRouteDeviceListResponse> SystemRoutingGetRouteDeviceListRequestAsync(this OcipClient client, SystemRoutingGetRouteDeviceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRoutingGetRouteDeviceListResponse;
        }
        /// <summary>
        /// Request to get a list of routes in the system.
        /// The response is either a SystemRoutingGetRouteListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingGetRouteListRequestAsync instead.")]
        public static async Task<SystemRoutingGetRouteListResponse> SystemRoutingGetRouteListRequest(this OcipClient client, SystemRoutingGetRouteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRoutingGetRouteListResponse;
        }

        /// <summary>
        /// Request to get a list of routes in the system.
        /// The response is either a SystemRoutingGetRouteListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemRoutingGetRouteListResponse> SystemRoutingGetRouteListRequestAsync(this OcipClient client, SystemRoutingGetRouteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRoutingGetRouteListResponse;
        }
        /// <summary>
        /// Request to get the system digit routing table.
        /// The response is either a SystemRoutingGetTranslationListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingGetTranslationListRequestAsync instead.")]
        public static async Task<SystemRoutingGetTranslationListResponse> SystemRoutingGetTranslationListRequest(this OcipClient client, SystemRoutingGetTranslationListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRoutingGetTranslationListResponse;
        }

        /// <summary>
        /// Request to get the system digit routing table.
        /// The response is either a SystemRoutingGetTranslationListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemRoutingGetTranslationListResponse> SystemRoutingGetTranslationListRequestAsync(this OcipClient client, SystemRoutingGetTranslationListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRoutingGetTranslationListResponse;
        }
        /// <summary>
        /// Modifies the system's general routing attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutingModifyRequest(this OcipClient client, SystemRoutingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the system's general routing attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutingModifyRequestAsync(this OcipClient client, SystemRoutingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a routing device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingModifyRouteDeviceRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutingModifyRouteDeviceRequest(this OcipClient client, SystemRoutingModifyRouteDeviceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a routing device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutingModifyRouteDeviceRequestAsync(this OcipClient client, SystemRoutingModifyRouteDeviceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a digit routing table entry in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingModifyTranslationRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRoutingModifyTranslationRequest(this OcipClient client, SystemRoutingModifyTranslationRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a digit routing table entry in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemRoutingModifyTranslationRequestAsync(this OcipClient client, SystemRoutingModifyTranslationRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of system routing profiles.
        /// 
        /// If resellerId is specified, the routing profiles assigned to the given reseller are returned. If reseller administrator sends the request, resellerId is not specified, the administrator’s resellerId is used.
        /// If system or provisioning administrator sends the request, resellerId is not specified, all system routing profiles are returned.
        /// 
        /// The response is either a SystemRoutingProfileGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRoutingProfileGetListRequestAsync instead.")]
        public static async Task<SystemRoutingProfileGetListResponse> SystemRoutingProfileGetListRequest(this OcipClient client, SystemRoutingProfileGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRoutingProfileGetListResponse;
        }

        /// <summary>
        /// Request to get the list of system routing profiles.
        /// 
        /// If resellerId is specified, the routing profiles assigned to the given reseller are returned. If reseller administrator sends the request, resellerId is not specified, the administrator’s resellerId is used.
        /// If system or provisioning administrator sends the request, resellerId is not specified, all system routing profiles are returned.
        /// 
        /// The response is either a SystemRoutingProfileGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemRoutingProfileGetListResponse> SystemRoutingProfileGetListRequestAsync(this OcipClient client, SystemRoutingProfileGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRoutingProfileGetListResponse;
        }
        /// <summary>
        /// Get the system call admission control parameters.
        /// The response is either a SystemRuntimeDataPublicationGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRuntimeDataPublicationGetRequestAsync instead.")]
        public static async Task<SystemRuntimeDataPublicationGetResponse> SystemRuntimeDataPublicationGetRequest(this OcipClient client, SystemRuntimeDataPublicationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRuntimeDataPublicationGetResponse;
        }

        /// <summary>
        /// Get the system call admission control parameters.
        /// The response is either a SystemRuntimeDataPublicationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemRuntimeDataPublicationGetResponse> SystemRuntimeDataPublicationGetRequestAsync(this OcipClient client, SystemRuntimeDataPublicationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRuntimeDataPublicationGetResponse;
        }
        /// <summary>
        /// Modify the system call admission control parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// enableRuntimeDataSync,
        /// runtimeIntervalInMilliSeconds
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRuntimeDataPublicationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemRuntimeDataPublicationModifyRequest(this OcipClient client, SystemRuntimeDataPublicationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system call admission control parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// enableRuntimeDataSync,
        /// runtimeIntervalInMilliSeconds
        /// </summary>
        public static async Task<SuccessResponse> SystemRuntimeDataPublicationModifyRequestAsync(this OcipClient client, SystemRuntimeDataPublicationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an event to system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemScheduleAddEventRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemScheduleAddEventRequest(this OcipClient client, SystemScheduleAddEventRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an event to system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        public static async Task<SuccessResponse> SystemScheduleAddEventRequestAsync(this OcipClient client, SystemScheduleAddEventRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemScheduleAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemScheduleAddRequest(this OcipClient client, SystemScheduleAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemScheduleAddRequestAsync(this OcipClient client, SystemScheduleAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of events from a system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemScheduleDeleteEventListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemScheduleDeleteEventListRequest(this OcipClient client, SystemScheduleDeleteEventListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of events from a system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemScheduleDeleteEventListRequestAsync(this OcipClient client, SystemScheduleDeleteEventListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemScheduleDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemScheduleDeleteListRequest(this OcipClient client, SystemScheduleDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemScheduleDeleteListRequestAsync(this OcipClient client, SystemScheduleDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of events of a system schedule.
        /// The response is either a SystemScheduleGetEventListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemScheduleGetEventListRequestAsync instead.")]
        public static async Task<SystemScheduleGetEventListResponse> SystemScheduleGetEventListRequest(this OcipClient client, SystemScheduleGetEventListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemScheduleGetEventListResponse;
        }

        /// <summary>
        /// Get the list of events of a system schedule.
        /// The response is either a SystemScheduleGetEventListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemScheduleGetEventListResponse> SystemScheduleGetEventListRequestAsync(this OcipClient client, SystemScheduleGetEventListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemScheduleGetEventListResponse;
        }
        /// <summary>
        /// Get an event from a system schedule.
        /// The response is either a SystemScheduleGetEventResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemScheduleGetEventRequestAsync instead.")]
        public static async Task<SystemScheduleGetEventResponse> SystemScheduleGetEventRequest(this OcipClient client, SystemScheduleGetEventRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemScheduleGetEventResponse;
        }

        /// <summary>
        /// Get an event from a system schedule.
        /// The response is either a SystemScheduleGetEventResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemScheduleGetEventResponse> SystemScheduleGetEventRequestAsync(this OcipClient client, SystemScheduleGetEventRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemScheduleGetEventResponse;
        }
        /// <summary>
        /// Get the list of a system schedules. The list can be filtered by schedule type.
        /// The response is either a SystemScheduleGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemScheduleGetListRequestAsync instead.")]
        public static async Task<SystemScheduleGetListResponse> SystemScheduleGetListRequest(this OcipClient client, SystemScheduleGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemScheduleGetListResponse;
        }

        /// <summary>
        /// Get the list of a system schedules. The list can be filtered by schedule type.
        /// The response is either a SystemScheduleGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemScheduleGetListResponse> SystemScheduleGetListRequestAsync(this OcipClient client, SystemScheduleGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemScheduleGetListResponse;
        }
        /// <summary>
        /// Modify an event of a system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemScheduleModifyEventRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemScheduleModifyEventRequest(this OcipClient client, SystemScheduleModifyEventRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an event of a system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        public static async Task<SuccessResponse> SystemScheduleModifyEventRequestAsync(this OcipClient client, SystemScheduleModifyEventRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemScheduleModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemScheduleModifyRequest(this OcipClient client, SystemScheduleModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a system schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemScheduleModifyRequestAsync(this OcipClient client, SystemScheduleModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with Selective Services.
        /// The response is either a SystemSelectiveServicesGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSelectiveServicesGetRequest22Async instead.")]
        public static async Task<SystemSelectiveServicesGetResponse22> SystemSelectiveServicesGetRequest22(this OcipClient client, SystemSelectiveServicesGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSelectiveServicesGetResponse22;
        }

        /// <summary>
        /// Request the system level data associated with Selective Services.
        /// The response is either a SystemSelectiveServicesGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemSelectiveServicesGetResponse22> SystemSelectiveServicesGetRequest22Async(this OcipClient client, SystemSelectiveServicesGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSelectiveServicesGetResponse22;
        }
        /// <summary>
        /// Modify the system level data associated with SystemSelectiveServicesRequest.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSelectiveServicesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSelectiveServicesModifyRequest(this OcipClient client, SystemSelectiveServicesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with SystemSelectiveServicesRequest.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSelectiveServicesModifyRequestAsync(this OcipClient client, SystemSelectiveServicesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Server Addresses.
        /// The response is either SystemServerAddressesGetResponse or ErrorResponse.
        /// See also:
        /// PrimaryInfoGetRequest
        /// PublicClusterGetFullyQualifiedDomainNameRequest
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServerAddressesGetRequestAsync instead.")]
        public static async Task<SystemServerAddressesGetResponse> SystemServerAddressesGetRequest(this OcipClient client, SystemServerAddressesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemServerAddressesGetResponse;
        }

        /// <summary>
        /// Request to get the list of Server Addresses.
        /// The response is either SystemServerAddressesGetResponse or ErrorResponse.
        /// See also:
        /// PrimaryInfoGetRequest
        /// PublicClusterGetFullyQualifiedDomainNameRequest
        /// </summary>
        public static async Task<SystemServerAddressesGetResponse> SystemServerAddressesGetRequestAsync(this OcipClient client, SystemServerAddressesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemServerAddressesGetResponse;
        }
        /// <summary>
        /// Request to modify Server Addresses.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServerAddressesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemServerAddressesModifyRequest(this OcipClient client, SystemServerAddressesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Server Addresses.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemServerAddressesModifyRequestAsync(this OcipClient client, SystemServerAddressesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the Service Activation Access Code system parameters.
        /// The response is either a SystemServiceActivationAccessCodeGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServiceActivationAccessCodeGetRequestAsync instead.")]
        public static async Task<SystemServiceActivationAccessCodeGetResponse> SystemServiceActivationAccessCodeGetRequest(this OcipClient client, SystemServiceActivationAccessCodeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemServiceActivationAccessCodeGetResponse;
        }

        /// <summary>
        /// Get the Service Activation Access Code system parameters.
        /// The response is either a SystemServiceActivationAccessCodeGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemServiceActivationAccessCodeGetResponse> SystemServiceActivationAccessCodeGetRequestAsync(this OcipClient client, SystemServiceActivationAccessCodeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemServiceActivationAccessCodeGetResponse;
        }
        /// <summary>
        /// Request to modify Service Activation Access Code system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServiceActivationAccessCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemServiceActivationAccessCodeModifyRequest(this OcipClient client, SystemServiceActivationAccessCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Service Activation Access Code system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemServiceActivationAccessCodeModifyRequestAsync(this OcipClient client, SystemServiceActivationAccessCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the default attributes for a service that are used when assigning the feature.
        /// The response is either a SystemServiceAttributeDefaultGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServiceAttributeDefaultGetListRequestAsync instead.")]
        public static async Task<SystemServiceAttributeDefaultGetListResponse> SystemServiceAttributeDefaultGetListRequest(this OcipClient client, SystemServiceAttributeDefaultGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemServiceAttributeDefaultGetListResponse;
        }

        /// <summary>
        /// Request to get the default attributes for a service that are used when assigning the feature.
        /// The response is either a SystemServiceAttributeDefaultGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemServiceAttributeDefaultGetListResponse> SystemServiceAttributeDefaultGetListRequestAsync(this OcipClient client, SystemServiceAttributeDefaultGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemServiceAttributeDefaultGetListResponse;
        }
        /// <summary>
        /// Request to modify a list of default attributes that are used when assigning the feature.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServiceAttributeDefaultModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemServiceAttributeDefaultModifyListRequest(this OcipClient client, SystemServiceAttributeDefaultModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a list of default attributes that are used when assigning the feature.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemServiceAttributeDefaultModifyListRequestAsync(this OcipClient client, SystemServiceAttributeDefaultModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a service code for the purpose of providing free format routable strings for dialing
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServiceCodeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemServiceCodeAddRequest(this OcipClient client, SystemServiceCodeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a service code for the purpose of providing free format routable strings for dialing
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemServiceCodeAddRequestAsync(this OcipClient client, SystemServiceCodeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a service code for the purpose of providing free format routable strings for dialing
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServiceCodeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemServiceCodeDeleteRequest(this OcipClient client, SystemServiceCodeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a service code for the purpose of providing free format routable strings for dialing
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemServiceCodeDeleteRequestAsync(this OcipClient client, SystemServiceCodeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get all service codes that have been defined in the system.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either SystemServiceCodeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServiceCodeGetListRequestAsync instead.")]
        public static async Task<SystemServiceCodeGetListResponse> SystemServiceCodeGetListRequest(this OcipClient client, SystemServiceCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemServiceCodeGetListResponse;
        }

        /// <summary>
        /// Request to get all service codes that have been defined in the system.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either SystemServiceCodeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemServiceCodeGetListResponse> SystemServiceCodeGetListRequestAsync(this OcipClient client, SystemServiceCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemServiceCodeGetListResponse;
        }
        /// <summary>
        /// Request to modify service code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServiceCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemServiceCodeModifyRequest(this OcipClient client, SystemServiceCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify service code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemServiceCodeModifyRequestAsync(this OcipClient client, SystemServiceCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get system level Service Pack Migration parameters.
        /// The response is either a SystemServicePackMigrationGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServicePackMigrationGetRequestAsync instead.")]
        public static async Task<SystemServicePackMigrationGetResponse> SystemServicePackMigrationGetRequest(this OcipClient client, SystemServicePackMigrationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemServicePackMigrationGetResponse;
        }

        /// <summary>
        /// Get system level Service Pack Migration parameters.
        /// The response is either a SystemServicePackMigrationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemServicePackMigrationGetResponse> SystemServicePackMigrationGetRequestAsync(this OcipClient client, SystemServicePackMigrationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemServicePackMigrationGetResponse;
        }
        /// <summary>
        /// Modify system level settings for Service Pack Migration.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServicePackMigrationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemServicePackMigrationModifyRequest(this OcipClient client, SystemServicePackMigrationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify system level settings for Service Pack Migration.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemServicePackMigrationModifyRequestAsync(this OcipClient client, SystemServicePackMigrationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Lookup if the given number is defined in the specified service in the system.
        /// The response is SystemServicePhoneNumberLookupResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemServicePhoneNumberLookupRequestAsync instead.")]
        public static async Task<SystemServicePhoneNumberLookupResponse> SystemServicePhoneNumberLookupRequest(this OcipClient client, SystemServicePhoneNumberLookupRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemServicePhoneNumberLookupResponse;
        }

        /// <summary>
        /// Lookup if the given number is defined in the specified service in the system.
        /// The response is SystemServicePhoneNumberLookupResponse.
        /// </summary>
        public static async Task<SystemServicePhoneNumberLookupResponse> SystemServicePhoneNumberLookupRequestAsync(this OcipClient client, SystemServicePhoneNumberLookupRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemServicePhoneNumberLookupResponse;
        }
        /// <summary>
        /// Get the session admission control settings for the system.
        /// The response is either a SystemSessionAdmissionControlGetResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSessionAdmissionControlGetRequest22Async instead.")]
        public static async Task<SystemSessionAdmissionControlGetResponse22> SystemSessionAdmissionControlGetRequest22(this OcipClient client, SystemSessionAdmissionControlGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSessionAdmissionControlGetResponse22;
        }

        /// <summary>
        /// Get the session admission control settings for the system.
        /// The response is either a SystemSessionAdmissionControlGetResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSessionAdmissionControlGetResponse22> SystemSessionAdmissionControlGetRequest22Async(this OcipClient client, SystemSessionAdmissionControlGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSessionAdmissionControlGetResponse22;
        }
        /// <summary>
        /// Modify the session admission control settings for the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSessionAdmissionControlModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSessionAdmissionControlModifyRequest(this OcipClient client, SystemSessionAdmissionControlModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the session admission control settings for the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSessionAdmissionControlModifyRequestAsync(this OcipClient client, SystemSessionAdmissionControlModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with session audit.
        /// The response is either a SystemSessionAuditGetResponse23 or
        /// an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSessionAuditGetRequest23Async instead.")]
        public static async Task<SystemSessionAuditGetResponse23> SystemSessionAuditGetRequest23(this OcipClient client, SystemSessionAuditGetRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSessionAuditGetResponse23;
        }

        /// <summary>
        /// Request the system level data associated with session audit.
        /// The response is either a SystemSessionAuditGetResponse23 or
        /// an ErrorResponse.
        /// </summary>
        public static async Task<SystemSessionAuditGetResponse23> SystemSessionAuditGetRequest23Async(this OcipClient client, SystemSessionAuditGetRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSessionAuditGetResponse23;
        }
        /// <summary>
        /// Modify the system level data associated with session audit.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// alwaysAllowRefreshForMS
        /// msAuditIntervalSeconds
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSessionAuditModifyRequest14sp3Async instead.")]
        public static async Task<SuccessResponse> SystemSessionAuditModifyRequest14sp3(this OcipClient client, SystemSessionAuditModifyRequest14sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with session audit.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// alwaysAllowRefreshForMS
        /// msAuditIntervalSeconds
        /// </summary>
        public static async Task<SuccessResponse> SystemSessionAuditModifyRequest14sp3Async(this OcipClient client, SystemSessionAuditModifyRequest14sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Retrieves the Sh Interface system parameters.
        /// The response is either a SystemShInterfaceParametersGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemShInterfaceParametersGetRequest17Async instead.")]
        public static async Task<SystemShInterfaceParametersGetResponse> SystemShInterfaceParametersGetRequest17(this OcipClient client, SystemShInterfaceParametersGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemShInterfaceParametersGetResponse;
        }

        /// <summary>
        /// Retrieves the Sh Interface system parameters.
        /// The response is either a SystemShInterfaceParametersGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemShInterfaceParametersGetResponse> SystemShInterfaceParametersGetRequest17Async(this OcipClient client, SystemShInterfaceParametersGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemShInterfaceParametersGetResponse;
        }
        /// <summary>
        /// Modifies the Sh Interface system parameters.  This request must be submitted on both nodes in the redundant Application Server cluster in order for the changes to take effect on each node without requiring a restart.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemShInterfaceParametersModifyRequest17Async instead.")]
        public static async Task<SuccessResponse> SystemShInterfaceParametersModifyRequest17(this OcipClient client, SystemShInterfaceParametersModifyRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the Sh Interface system parameters.  This request must be submitted on both nodes in the redundant Application Server cluster in order for the changes to take effect on each node without requiring a restart.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemShInterfaceParametersModifyRequest17Async(this OcipClient client, SystemShInterfaceParametersModifyRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Retrieves the status of the system refresh task on the local Application Server node.
        /// The response is either a SystemShInterfaceRefreshTaskGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemShInterfaceRefreshTaskGetRequestAsync instead.")]
        public static async Task<SystemShInterfaceRefreshTaskGetResponse> SystemShInterfaceRefreshTaskGetRequest(this OcipClient client, SystemShInterfaceRefreshTaskGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemShInterfaceRefreshTaskGetResponse;
        }

        /// <summary>
        /// Retrieves the status of the system refresh task on the local Application Server node.
        /// The response is either a SystemShInterfaceRefreshTaskGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemShInterfaceRefreshTaskGetResponse> SystemShInterfaceRefreshTaskGetRequestAsync(this OcipClient client, SystemShInterfaceRefreshTaskGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemShInterfaceRefreshTaskGetResponse;
        }
        /// <summary>
        /// Dispatches the system refresh task on the local Application Server node.  At most one instance of the system refresh task may run on an Application Server node at a given point in time.  If the system refresh task is already running when this request is made, an ErrorResponse is returned.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemShInterfaceRefreshTaskStartRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemShInterfaceRefreshTaskStartRequest(this OcipClient client, SystemShInterfaceRefreshTaskStartRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Dispatches the system refresh task on the local Application Server node.  At most one instance of the system refresh task may run on an Application Server node at a given point in time.  If the system refresh task is already running when this request is made, an ErrorResponse is returned.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemShInterfaceRefreshTaskStartRequestAsync(this OcipClient client, SystemShInterfaceRefreshTaskStartRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Terminates the system refresh task in progress on the local Application Server node.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemShInterfaceRefreshTaskTerminateRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemShInterfaceRefreshTaskTerminateRequest(this OcipClient client, SystemShInterfaceRefreshTaskTerminateRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Terminates the system refresh task in progress on the local Application Server node.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemShInterfaceRefreshTaskTerminateRequestAsync(this OcipClient client, SystemShInterfaceRefreshTaskTerminateRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an entry to the SIP access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPAddACLEntryRequest14sp2Async instead.")]
        public static async Task<SuccessResponse> SystemSIPAddACLEntryRequest14sp2(this OcipClient client, SystemSIPAddACLEntryRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an entry to the SIP access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPAddACLEntryRequest14sp2Async(this OcipClient client, SystemSIPAddACLEntryRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a content type for the SIP interface.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPAddContentTypeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPAddContentTypeRequest(this OcipClient client, SystemSIPAddContentTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a content type for the SIP interface.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPAddContentTypeRequestAsync(this OcipClient client, SystemSIPAddContentTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to clear sip authentication endpoint lockouts in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPAuthenticationEndpointLockoutClearRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPAuthenticationEndpointLockoutClearRequest(this OcipClient client, SystemSIPAuthenticationEndpointLockoutClearRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to clear sip authentication endpoint lockouts in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPAuthenticationEndpointLockoutClearRequestAsync(this OcipClient client, SystemSIPAuthenticationEndpointLockoutClearRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get sip authentication endpoint lockout data in the system.
        /// The response is either a SystemSIPAuthenticationEndpointLockoutGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPAuthenticationEndpointLockoutGetRequestAsync instead.")]
        public static async Task<SystemSIPAuthenticationEndpointLockoutGetResponse> SystemSIPAuthenticationEndpointLockoutGetRequest(this OcipClient client, SystemSIPAuthenticationEndpointLockoutGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPAuthenticationEndpointLockoutGetResponse;
        }

        /// <summary>
        /// Request to get sip authentication endpoint lockout data in the system.
        /// The response is either a SystemSIPAuthenticationEndpointLockoutGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPAuthenticationEndpointLockoutGetResponse> SystemSIPAuthenticationEndpointLockoutGetRequestAsync(this OcipClient client, SystemSIPAuthenticationEndpointLockoutGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPAuthenticationEndpointLockoutGetResponse;
        }
        /// <summary>
        /// Request to clear all sip authentication lockouts (both endpoint and trunk group) in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPAuthenticationLockoutClearAllRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPAuthenticationLockoutClearAllRequest(this OcipClient client, SystemSIPAuthenticationLockoutClearAllRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to clear all sip authentication lockouts (both endpoint and trunk group) in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPAuthenticationLockoutClearAllRequestAsync(this OcipClient client, SystemSIPAuthenticationLockoutClearAllRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the system level SIP authentication password rule settings.
        /// The response is either a SystemSIPAuthenticationPasswordRulesGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPAuthenticationPasswordRulesGetRequestAsync instead.")]
        public static async Task<SystemSIPAuthenticationPasswordRulesGetResponse> SystemSIPAuthenticationPasswordRulesGetRequest(this OcipClient client, SystemSIPAuthenticationPasswordRulesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPAuthenticationPasswordRulesGetResponse;
        }

        /// <summary>
        /// Request to get the system level SIP authentication password rule settings.
        /// The response is either a SystemSIPAuthenticationPasswordRulesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPAuthenticationPasswordRulesGetResponse> SystemSIPAuthenticationPasswordRulesGetRequestAsync(this OcipClient client, SystemSIPAuthenticationPasswordRulesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPAuthenticationPasswordRulesGetResponse;
        }
        /// <summary>
        /// Request to modify the system level SIP authentication password rule settings
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPAuthenticationPasswordRulesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPAuthenticationPasswordRulesModifyRequest(this OcipClient client, SystemSIPAuthenticationPasswordRulesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system level SIP authentication password rule settings
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPAuthenticationPasswordRulesModifyRequestAsync(this OcipClient client, SystemSIPAuthenticationPasswordRulesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to clear sip authentication trunk group lockouts in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPAuthenticationTrunkGroupLockoutClearRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPAuthenticationTrunkGroupLockoutClearRequest(this OcipClient client, SystemSIPAuthenticationTrunkGroupLockoutClearRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to clear sip authentication trunk group lockouts in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPAuthenticationTrunkGroupLockoutClearRequestAsync(this OcipClient client, SystemSIPAuthenticationTrunkGroupLockoutClearRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get sip authentication trunk group lockout data in the system.
        /// The response is either a SystemSIPAuthenticationTrunkGroupLockoutGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPAuthenticationTrunkGroupLockoutGetRequestAsync instead.")]
        public static async Task<SystemSIPAuthenticationTrunkGroupLockoutGetResponse> SystemSIPAuthenticationTrunkGroupLockoutGetRequest(this OcipClient client, SystemSIPAuthenticationTrunkGroupLockoutGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPAuthenticationTrunkGroupLockoutGetResponse;
        }

        /// <summary>
        /// Request to get sip authentication trunk group lockout data in the system.
        /// The response is either a SystemSIPAuthenticationTrunkGroupLockoutGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPAuthenticationTrunkGroupLockoutGetResponse> SystemSIPAuthenticationTrunkGroupLockoutGetRequestAsync(this OcipClient client, SystemSIPAuthenticationTrunkGroupLockoutGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPAuthenticationTrunkGroupLockoutGetResponse;
        }
        /// <summary>
        /// Delete an entry from the SIP access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeleteACLEntryRequest14sp2Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeleteACLEntryRequest14sp2(this OcipClient client, SystemSIPDeleteACLEntryRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry from the SIP access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeleteACLEntryRequest14sp2Async(this OcipClient client, SystemSIPDeleteACLEntryRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a content type for the SIP interface.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeleteContentTypeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPDeleteContentTypeRequest(this OcipClient client, SystemSIPDeleteContentTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a content type for the SIP interface.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeleteContentTypeRequestAsync(this OcipClient client, SystemSIPDeleteContentTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to apply an extended file capture value to all the profile instances associated to a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceFileApplyExtendedCaptureToAllDeviceProfilesRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceFileApplyExtendedCaptureToAllDeviceProfilesRequest(this OcipClient client, SystemSIPDeviceFileApplyExtendedCaptureToAllDeviceProfilesRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to apply an extended file capture value to all the profile instances associated to a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceFileApplyExtendedCaptureToAllDeviceProfilesRequestAsync(this OcipClient client, SystemSIPDeviceFileApplyExtendedCaptureToAllDeviceProfilesRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// 
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagement, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// resellerId
        /// 
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeAddRequest22V3Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest22V3(this OcipClient client, SystemSIPDeviceTypeAddRequest22V3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// 
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagement, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// resellerId
        /// 
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest22V3Async(this OcipClient client, SystemSIPDeviceTypeAddRequest22V3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// 
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagement, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// supportCallingPartyCategoryInOutboundFromHeader, use value "true" in XS data mode
        /// resellerId
        /// 
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeAddRequest23Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest23(this OcipClient client, SystemSIPDeviceTypeAddRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// 
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagement, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// supportCallingPartyCategoryInOutboundFromHeader, use value "true" in XS data mode
        /// resellerId
        /// 
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest23Async(this OcipClient client, SystemSIPDeviceTypeAddRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeDeleteRequest(this OcipClient client, SystemSIPDeviceTypeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeDeleteRequestAsync(this OcipClient client, SystemSIPDeviceTypeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeFileAddRequest21sp1Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileAddRequest21sp1(this OcipClient client, SystemSIPDeviceTypeFileAddRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileAddRequest21sp1Async(this OcipClient client, SystemSIPDeviceTypeFileAddRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeFileDeleteRequest14sp8Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileDeleteRequest14sp8(this OcipClient client, SystemSIPDeviceTypeFileDeleteRequest14sp8 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileDeleteRequest14sp8Async(this OcipClient client, SystemSIPDeviceTypeFileDeleteRequest14sp8 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of device files managed by the Device Management System, on a per-device type basis.
        /// The response is either SystemSIPDeviceTypeFileGetListResponse14sp8 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeFileGetListRequest14sp8Async instead.")]
        public static async Task<SystemSIPDeviceTypeFileGetListResponse14sp8> SystemSIPDeviceTypeFileGetListRequest14sp8(this OcipClient client, SystemSIPDeviceTypeFileGetListRequest14sp8 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeFileGetListResponse14sp8;
        }

        /// <summary>
        /// Request to get the list of device files managed by the Device Management System, on a per-device type basis.
        /// The response is either SystemSIPDeviceTypeFileGetListResponse14sp8 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeFileGetListResponse14sp8> SystemSIPDeviceTypeFileGetListRequest14sp8Async(this OcipClient client, SystemSIPDeviceTypeFileGetListRequest14sp8 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeFileGetListResponse14sp8;
        }
        /// <summary>
        /// Request to get a sip device type file.
        /// The response is either SystemSIPDeviceTypeFileGetResponse21sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeFileGetRequest21sp1Async instead.")]
        public static async Task<SystemSIPDeviceTypeFileGetResponse21sp1> SystemSIPDeviceTypeFileGetRequest21sp1(this OcipClient client, SystemSIPDeviceTypeFileGetRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeFileGetResponse21sp1;
        }

        /// <summary>
        /// Request to get a sip device type file.
        /// The response is either SystemSIPDeviceTypeFileGetResponse21sp1 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeFileGetResponse21sp1> SystemSIPDeviceTypeFileGetRequest21sp1Async(this OcipClient client, SystemSIPDeviceTypeFileGetRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeFileGetResponse21sp1;
        }
        /// <summary>
        /// Request to modify a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// When macInCert is set to true, macInNonRequestURI will be reset to false.
        /// When macInNonRequestURI is set to true, macInCert will be reset to false.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeFileModifyRequest16sp1Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileModifyRequest16sp1(this OcipClient client, SystemSIPDeviceTypeFileModifyRequest16sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// When macInCert is set to true, macInNonRequestURI will be reset to false.
        /// When macInNonRequestURI is set to true, macInCert will be reset to false.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileModifyRequest16sp1Async(this OcipClient client, SystemSIPDeviceTypeFileModifyRequest16sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of sip device types in the system.
        /// If includeSystemLevel is specified, all system level device types and the reseller device types matching search criteria
        /// are returned even when searchCriteriaResellerId is specified.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All system level device
        /// types and the device types in the administrator's reseller meeting the search criteria are returned.
        /// See Also: SystemDeviceTypeGetAvailableListRequest22 in AS data mode, SystemDeviceTypeGetAvailableListRequest19 in XS data mode.
        /// The response is either SystemSIPDeviceTypeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeGetListRequestAsync instead.")]
        public static async Task<SystemSIPDeviceTypeGetListResponse> SystemSIPDeviceTypeGetListRequest(this OcipClient client, SystemSIPDeviceTypeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeGetListResponse;
        }

        /// <summary>
        /// Request to get the list of sip device types in the system.
        /// If includeSystemLevel is specified, all system level device types and the reseller device types matching search criteria
        /// are returned even when searchCriteriaResellerId is specified.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All system level device
        /// types and the device types in the administrator's reseller meeting the search criteria are returned.
        /// See Also: SystemDeviceTypeGetAvailableListRequest22 in AS data mode, SystemDeviceTypeGetAvailableListRequest19 in XS data mode.
        /// The response is either SystemSIPDeviceTypeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetListResponse> SystemSIPDeviceTypeGetListRequestAsync(this OcipClient client, SystemSIPDeviceTypeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeGetListResponse;
        }
        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse22V4 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeGetRequest22V4Async instead.")]
        public static async Task<SystemSIPDeviceTypeGetResponse22V4> SystemSIPDeviceTypeGetRequest22V4(this OcipClient client, SystemSIPDeviceTypeGetRequest22V4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse22V4;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse22V4 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse22V4> SystemSIPDeviceTypeGetRequest22V4Async(this OcipClient client, SystemSIPDeviceTypeGetRequest22V4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse22V4;
        }
        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse23 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeGetRequest23Async instead.")]
        public static async Task<SystemSIPDeviceTypeGetResponse23> SystemSIPDeviceTypeGetRequest23(this OcipClient client, SystemSIPDeviceTypeGetRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse23;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse23 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse23> SystemSIPDeviceTypeGetRequest23Async(this OcipClient client, SystemSIPDeviceTypeGetRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse23;
        }
        /// <summary>
        /// Request to get the list of device language names mapped to BroadWorks language names, per-device type.
        /// The response is either SystemSIPDeviceTypeLanguageMappingGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeLanguageMappingGetListRequestAsync instead.")]
        public static async Task<SystemSIPDeviceTypeLanguageMappingGetListResponse> SystemSIPDeviceTypeLanguageMappingGetListRequest(this OcipClient client, SystemSIPDeviceTypeLanguageMappingGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeLanguageMappingGetListResponse;
        }

        /// <summary>
        /// Request to get the list of device language names mapped to BroadWorks language names, per-device type.
        /// The response is either SystemSIPDeviceTypeLanguageMappingGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeLanguageMappingGetListResponse> SystemSIPDeviceTypeLanguageMappingGetListRequestAsync(this OcipClient client, SystemSIPDeviceTypeLanguageMappingGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeLanguageMappingGetListResponse;
        }
        /// <summary>
        /// Request to modify the device language name that is mapped to a BroadWorks language name. The request can be used to map many languages.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeLanguageMappingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeLanguageMappingModifyRequest(this OcipClient client, SystemSIPDeviceTypeLanguageMappingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the device language name that is mapped to a BroadWorks language name. The request can be used to map many languages.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeLanguageMappingModifyRequestAsync(this OcipClient client, SystemSIPDeviceTypeLanguageMappingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are not changeable:
        /// numberOfPorts
        /// SignalingAddressType
        /// isConferenceDevice
        /// isMusicOnHoldDevice
        /// isMobilityManagerDevice
        /// deviceTypeConfigurationOption
        /// staticLineOrdering
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// supportClientSessionInfo
        /// supportCallInfoConferenceSubscriptionURI
        /// supportRemotePartyInfo
        /// supportVisualDeviceManagement
        /// bypassMediaTreatment
        /// supportCauseParameter
        /// 
        /// The following elements are only used in XS data mode and ignored in AS mode:
        /// enhancedForICS
        /// supports3G4GContinuity
        /// publishesOwnPresence
        /// locationNetwork
        /// allowTerminationBasedOnICSI
        /// roamingMode
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// When macInCert is set to true, macInNonRequestURI will be reset to false.
        /// When macInNonRequestURI is set to true, macInCert will be reset to false.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeModifyRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest22(this OcipClient client, SystemSIPDeviceTypeModifyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are not changeable:
        /// numberOfPorts
        /// SignalingAddressType
        /// isConferenceDevice
        /// isMusicOnHoldDevice
        /// isMobilityManagerDevice
        /// deviceTypeConfigurationOption
        /// staticLineOrdering
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// supportClientSessionInfo
        /// supportCallInfoConferenceSubscriptionURI
        /// supportRemotePartyInfo
        /// supportVisualDeviceManagement
        /// bypassMediaTreatment
        /// supportCauseParameter
        /// 
        /// The following elements are only used in XS data mode and ignored in AS mode:
        /// enhancedForICS
        /// supports3G4GContinuity
        /// publishesOwnPresence
        /// locationNetwork
        /// allowTerminationBasedOnICSI
        /// roamingMode
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// When macInCert is set to true, macInNonRequestURI will be reset to false.
        /// When macInNonRequestURI is set to true, macInCert will be reset to false.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest22Async(this OcipClient client, SystemSIPDeviceTypeModifyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are not changeable:
        /// numberOfPorts
        /// SignalingAddressType
        /// isConferenceDevice
        /// isMusicOnHoldDevice
        /// isMobilityManagerDevice
        /// deviceTypeConfigurationOption
        /// staticLineOrdering
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// supportClientSessionInfo
        /// supportCallInfoConferenceSubscriptionURI
        /// supportRemotePartyInfo
        /// supportVisualDeviceManagement
        /// bypassMediaTreatment
        /// supportCauseParameter
        /// supportCallingPartyCategoryInOutboundFromHeader
        /// 
        /// The following elements are only used in XS data mode and ignored in AS mode:
        /// enhancedForICS
        /// supports3G4GContinuity
        /// publishesOwnPresence
        /// locationNetwork
        /// allowTerminationBasedOnICSI
        /// roamingMode
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// When macInCert is set to true, macInNonRequestURI will be reset to false.
        /// When macInNonRequestURI is set to true, macInCert will be reset to false.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeModifyRequest22V2Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest22V2(this OcipClient client, SystemSIPDeviceTypeModifyRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are not changeable:
        /// numberOfPorts
        /// SignalingAddressType
        /// isConferenceDevice
        /// isMusicOnHoldDevice
        /// isMobilityManagerDevice
        /// deviceTypeConfigurationOption
        /// staticLineOrdering
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// supportClientSessionInfo
        /// supportCallInfoConferenceSubscriptionURI
        /// supportRemotePartyInfo
        /// supportVisualDeviceManagement
        /// bypassMediaTreatment
        /// supportCauseParameter
        /// supportCallingPartyCategoryInOutboundFromHeader
        /// 
        /// The following elements are only used in XS data mode and ignored in AS mode:
        /// enhancedForICS
        /// supports3G4GContinuity
        /// publishesOwnPresence
        /// locationNetwork
        /// allowTerminationBasedOnICSI
        /// roamingMode
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// When macInCert is set to true, macInNonRequestURI will be reset to false.
        /// When macInNonRequestURI is set to true, macInCert will be reset to false.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest22V2Async(this OcipClient client, SystemSIPDeviceTypeModifyRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of BroadWorks services that can be integrated to a device type and the level of integration for this device type.
        /// The response is either SystemSIPDeviceTypeServiceGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeServiceGetRequestAsync instead.")]
        public static async Task<SystemSIPDeviceTypeServiceGetResponse> SystemSIPDeviceTypeServiceGetRequest(this OcipClient client, SystemSIPDeviceTypeServiceGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeServiceGetResponse;
        }

        /// <summary>
        /// Request to get the list of BroadWorks services that can be integrated to a device type and the level of integration for this device type.
        /// The response is either SystemSIPDeviceTypeServiceGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeServiceGetResponse> SystemSIPDeviceTypeServiceGetRequestAsync(this OcipClient client, SystemSIPDeviceTypeServiceGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeServiceGetResponse;
        }
        /// <summary>
        /// Request to set the level of integration that a device type has in relation to BroadWorks services.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeServiceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeServiceModifyRequest(this OcipClient client, SystemSIPDeviceTypeServiceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to set the level of integration that a device type has in relation to BroadWorks services.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeServiceModifyRequestAsync(this OcipClient client, SystemSIPDeviceTypeServiceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of SIP Diversion Cause values.
        /// The response is either a SystemSIPDiversionReasonGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDiversionReasonGetRequestAsync instead.")]
        public static async Task<SystemSIPDiversionReasonGetResponse> SystemSIPDiversionReasonGetRequest(this OcipClient client, SystemSIPDiversionReasonGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDiversionReasonGetResponse;
        }

        /// <summary>
        /// Request to get the list of SIP Diversion Cause values.
        /// The response is either a SystemSIPDiversionReasonGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDiversionReasonGetResponse> SystemSIPDiversionReasonGetRequestAsync(this OcipClient client, SystemSIPDiversionReasonGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDiversionReasonGetResponse;
        }
        /// <summary>
        /// Request to modify the SIP cause value for a given diversion reason.
        /// The response is either a SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDiversionReasonModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPDiversionReasonModifyRequest(this OcipClient client, SystemSIPDiversionReasonModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the SIP cause value for a given diversion reason.
        /// The response is either a SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDiversionReasonModifyRequestAsync(this OcipClient client, SystemSIPDiversionReasonModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the SIP access control list.
        /// The response is either SystemSIPGetACLListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPGetACLListRequestAsync instead.")]
        public static async Task<SystemSIPGetACLListResponse> SystemSIPGetACLListRequest(this OcipClient client, SystemSIPGetACLListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPGetACLListResponse;
        }

        /// <summary>
        /// Get the SIP access control list.
        /// The response is either SystemSIPGetACLListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPGetACLListResponse> SystemSIPGetACLListRequestAsync(this OcipClient client, SystemSIPGetACLListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPGetACLListResponse;
        }
        /// <summary>
        /// Get the content type list for the SIP interface.
        /// The response is either SystemSIPGetContentTypeListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPGetContentTypeListRequestAsync instead.")]
        public static async Task<SystemSIPGetContentTypeListResponse> SystemSIPGetContentTypeListRequest(this OcipClient client, SystemSIPGetContentTypeListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPGetContentTypeListResponse;
        }

        /// <summary>
        /// Get the content type list for the SIP interface.
        /// The response is either SystemSIPGetContentTypeListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPGetContentTypeListResponse> SystemSIPGetContentTypeListRequestAsync(this OcipClient client, SystemSIPGetContentTypeListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPGetContentTypeListResponse;
        }
        /// <summary>
        /// Modify an entry from the SIP access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPModifyACLEntryRequest14sp2Async instead.")]
        public static async Task<SuccessResponse> SystemSIPModifyACLEntryRequest14sp2(this OcipClient client, SystemSIPModifyACLEntryRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an entry from the SIP access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPModifyACLEntryRequest14sp2Async(this OcipClient client, SystemSIPModifyACLEntryRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify an content type for the SIP interface.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPModifyContentTypeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSIPModifyContentTypeRequest(this OcipClient client, SystemSIPModifyContentTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an content type for the SIP interface.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPModifyContentTypeRequestAsync(this OcipClient client, SystemSIPModifyContentTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an entry to the SMDI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIAddACLEntryRequest14sp2Async instead.")]
        public static async Task<SuccessResponse> SystemSMDIAddACLEntryRequest14sp2(this OcipClient client, SystemSMDIAddACLEntryRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an entry to the SMDI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIAddACLEntryRequest14sp2Async(this OcipClient client, SystemSMDIAddACLEntryRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an entry from the SMDI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIDeleteACLEntryRequest14sp2Async instead.")]
        public static async Task<SuccessResponse> SystemSMDIDeleteACLEntryRequest14sp2(this OcipClient client, SystemSMDIDeleteACLEntryRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry from the SMDI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIDeleteACLEntryRequest14sp2Async(this OcipClient client, SystemSMDIDeleteACLEntryRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the SMDI access control list.
        /// The response is either SystemSMDIGetACLListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIGetACLListRequestAsync instead.")]
        public static async Task<SystemSMDIGetACLListResponse> SystemSMDIGetACLListRequest(this OcipClient client, SystemSMDIGetACLListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSMDIGetACLListResponse;
        }

        /// <summary>
        /// Get the SMDI access control list.
        /// The response is either SystemSMDIGetACLListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSMDIGetACLListResponse> SystemSMDIGetACLListRequestAsync(this OcipClient client, SystemSMDIGetACLListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSMDIGetACLListResponse;
        }
        /// <summary>
        /// Modify an entry from the SMDI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIModifyACLEntryRequest14sp2Async instead.")]
        public static async Task<SuccessResponse> SystemSMDIModifyACLEntryRequest14sp2(this OcipClient client, SystemSMDIModifyACLEntryRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an entry from the SMDI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIModifyACLEntryRequest14sp2Async(this OcipClient client, SystemSMDIModifyACLEntryRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of SMDI system parameters.
        /// The response is either SystemSMDIParametersGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIParametersGetRequestAsync instead.")]
        public static async Task<SystemSMDIParametersGetResponse> SystemSMDIParametersGetRequest(this OcipClient client, SystemSMDIParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSMDIParametersGetResponse;
        }

        /// <summary>
        /// Request to get the list of SMDI system parameters.
        /// The response is either SystemSMDIParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSMDIParametersGetResponse> SystemSMDIParametersGetRequestAsync(this OcipClient client, SystemSMDIParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSMDIParametersGetResponse;
        }
        /// <summary>
        /// Request to modify SMDI system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSMDIParametersModifyRequest(this OcipClient client, SystemSMDIParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify SMDI system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIParametersModifyRequestAsync(this OcipClient client, SystemSMDIParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with SMPP external interface.
        /// The response is either a SystemSMPPGetResponse21 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMPPGetRequest22Async instead.")]
        public static async Task<SystemSMPPGetResponse21> SystemSMPPGetRequest22(this OcipClient client, SystemSMPPGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSMPPGetResponse21;
        }

        /// <summary>
        /// Request the system level data associated with SMPP external interface.
        /// The response is either a SystemSMPPGetResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSMPPGetResponse21> SystemSMPPGetRequest22Async(this OcipClient client, SystemSMPPGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSMPPGetResponse21;
        }
        /// <summary>
        /// Request to modify the system level data associated with the SMPP external interface.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMPPModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSMPPModifyRequest(this OcipClient client, SystemSMPPModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system level data associated with the SMPP external interface.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMPPModifyRequestAsync(this OcipClient client, SystemSMPPModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the software version of the Application Server.
        /// The response is either SystemSoftwareVersionGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSoftwareVersionGetRequestAsync instead.")]
        public static async Task<SystemSoftwareVersionGetResponse> SystemSoftwareVersionGetRequest(this OcipClient client, SystemSoftwareVersionGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSoftwareVersionGetResponse;
        }

        /// <summary>
        /// Requests the software version of the Application Server.
        /// The response is either SystemSoftwareVersionGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSoftwareVersionGetResponse> SystemSoftwareVersionGetRequestAsync(this OcipClient client, SystemSoftwareVersionGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSoftwareVersionGetResponse;
        }
        /// <summary>
        /// Requests the list of state and province names.
        /// The response is either SystemStateOrProvinceGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemStateOrProvinceGetListRequestAsync instead.")]
        public static async Task<SystemStateOrProvinceGetListResponse> SystemStateOrProvinceGetListRequest(this OcipClient client, SystemStateOrProvinceGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemStateOrProvinceGetListResponse;
        }

        /// <summary>
        /// Requests the list of state and province names.
        /// The response is either SystemStateOrProvinceGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemStateOrProvinceGetListResponse> SystemStateOrProvinceGetListRequestAsync(this OcipClient client, SystemStateOrProvinceGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemStateOrProvinceGetListResponse;
        }
        /// <summary>
        /// Get the system call processing configuration for all subscribers
        /// The response is either a SystemSubscriberGetCallProcessingParametersResponse18sp1
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSubscriberGetCallProcessingParametersRequest18sp1Async instead.")]
        public static async Task<SystemSubscriberGetCallProcessingParametersResponse18sp1> SystemSubscriberGetCallProcessingParametersRequest18sp1(this OcipClient client, SystemSubscriberGetCallProcessingParametersRequest18sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSubscriberGetCallProcessingParametersResponse18sp1;
        }

        /// <summary>
        /// Get the system call processing configuration for all subscribers
        /// The response is either a SystemSubscriberGetCallProcessingParametersResponse18sp1
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSubscriberGetCallProcessingParametersResponse18sp1> SystemSubscriberGetCallProcessingParametersRequest18sp1Async(this OcipClient client, SystemSubscriberGetCallProcessingParametersRequest18sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSubscriberGetCallProcessingParametersResponse18sp1;
        }
        /// <summary>
        /// Get the system login configuration for all subscribers.
        /// The response is either a SystemSubscriberGetLoginParametersResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSubscriberGetLoginParametersRequestAsync instead.")]
        public static async Task<SystemSubscriberGetLoginParametersResponse> SystemSubscriberGetLoginParametersRequest(this OcipClient client, SystemSubscriberGetLoginParametersRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSubscriberGetLoginParametersResponse;
        }

        /// <summary>
        /// Get the system login configuration for all subscribers.
        /// The response is either a SystemSubscriberGetLoginParametersResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSubscriberGetLoginParametersResponse> SystemSubscriberGetLoginParametersRequestAsync(this OcipClient client, SystemSubscriberGetLoginParametersRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSubscriberGetLoginParametersResponse;
        }
        /// <summary>
        /// Get the system provisioning configuration for all subscribers
        /// The response is either a SystemSubscriberGetProvisioningParametersResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSubscriberGetProvisioningParametersRequestAsync instead.")]
        public static async Task<SystemSubscriberGetProvisioningParametersResponse> SystemSubscriberGetProvisioningParametersRequest(this OcipClient client, SystemSubscriberGetProvisioningParametersRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSubscriberGetProvisioningParametersResponse;
        }

        /// <summary>
        /// Get the system provisioning configuration for all subscribers
        /// The response is either a SystemSubscriberGetProvisioningParametersResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSubscriberGetProvisioningParametersResponse> SystemSubscriberGetProvisioningParametersRequestAsync(this OcipClient client, SystemSubscriberGetProvisioningParametersRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSubscriberGetProvisioningParametersResponse;
        }
        /// <summary>
        /// Modify the system call processing configuration for all subscribers.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in XS data mode and ignored in the AS data mode:
        /// minNoAnswerNumberOfRings
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// isExtendedCallingLineIdActive
        /// isRingTimeOutActive
        /// ringTimeoutSeconds
        /// allowEmergencyRemoteOfficeOriginations
        /// incomingCallToUserAliasMode
        /// bypassTerminationLoopDetection
        /// honorCLIDBlockingForEmergencyCalls
        /// useUnicodeIdentityName
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSubscriberModifyCallProcessingParametersRequest14sp7Async instead.")]
        public static async Task<SuccessResponse> SystemSubscriberModifyCallProcessingParametersRequest14sp7(this OcipClient client, SystemSubscriberModifyCallProcessingParametersRequest14sp7 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system call processing configuration for all subscribers.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in XS data mode and ignored in the AS data mode:
        /// minNoAnswerNumberOfRings
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// isExtendedCallingLineIdActive
        /// isRingTimeOutActive
        /// ringTimeoutSeconds
        /// allowEmergencyRemoteOfficeOriginations
        /// incomingCallToUserAliasMode
        /// bypassTerminationLoopDetection
        /// honorCLIDBlockingForEmergencyCalls
        /// useUnicodeIdentityName
        /// </summary>
        public static async Task<SuccessResponse> SystemSubscriberModifyCallProcessingParametersRequest14sp7Async(this OcipClient client, SystemSubscriberModifyCallProcessingParametersRequest14sp7 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the system login configuration for all subscribers
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSubscriberModifyLoginParametersRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSubscriberModifyLoginParametersRequest(this OcipClient client, SystemSubscriberModifyLoginParametersRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system login configuration for all subscribers
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSubscriberModifyLoginParametersRequestAsync(this OcipClient client, SystemSubscriberModifyLoginParametersRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the system provisioning configuration for all subscribers.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSubscriberModifyProvisioningParametersRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSubscriberModifyProvisioningParametersRequest(this OcipClient client, SystemSubscriberModifyProvisioningParametersRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system provisioning configuration for all subscribers.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSubscriberModifyProvisioningParametersRequestAsync(this OcipClient client, SystemSubscriberModifyProvisioningParametersRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the data associated with Call Processing Policy for system service instances.
        /// The response is either SystemSystemServiceCallProcessingPoliciesGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemServiceCallProcessingPoliciesGetRequestAsync instead.")]
        public static async Task<SystemSystemServiceCallProcessingPoliciesGetResponse> SystemSystemServiceCallProcessingPoliciesGetRequest(this OcipClient client, SystemSystemServiceCallProcessingPoliciesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSystemServiceCallProcessingPoliciesGetResponse;
        }

        /// <summary>
        /// Request the data associated with Call Processing Policy for system service instances.
        /// The response is either SystemSystemServiceCallProcessingPoliciesGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSystemServiceCallProcessingPoliciesGetResponse> SystemSystemServiceCallProcessingPoliciesGetRequestAsync(this OcipClient client, SystemSystemServiceCallProcessingPoliciesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSystemServiceCallProcessingPoliciesGetResponse;
        }
        /// <summary>
        /// Request the data associated with Call Processing Policy for system service instances.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemServiceCallProcessingPoliciesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSystemServiceCallProcessingPoliciesModifyRequest(this OcipClient client, SystemSystemServiceCallProcessingPoliciesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request the data associated with Call Processing Policy for system service instances.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSystemServiceCallProcessingPoliciesModifyRequestAsync(this OcipClient client, SystemSystemServiceCallProcessingPoliciesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Adds system service Dns. It is possible to add either: a single DN,
        /// a list of DNs a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemServiceDnAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSystemServiceDnAddListRequest(this OcipClient client, SystemSystemServiceDnAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Adds system service Dns. It is possible to add either: a single DN,
        /// a list of DNs a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSystemServiceDnAddListRequestAsync(this OcipClient client, SystemSystemServiceDnAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deletes system service DNs. It is possible to delete either:
        /// a single DN,
        /// a list of DNs, a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemServiceDnDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSystemServiceDnDeleteListRequest(this OcipClient client, SystemSystemServiceDnDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deletes system service DNs. It is possible to delete either:
        /// a single DN,
        /// a list of DNs, a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSystemServiceDnDeleteListRequestAsync(this OcipClient client, SystemSystemServiceDnDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a list of system service DNs not yet in use.
        /// The response is either SystemSystemServiceDnGetAvailableListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemServiceDnGetAvailableListRequestAsync instead.")]
        public static async Task<SystemSystemServiceDnGetAvailableListResponse> SystemSystemServiceDnGetAvailableListRequest(this OcipClient client, SystemSystemServiceDnGetAvailableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSystemServiceDnGetAvailableListResponse;
        }

        /// <summary>
        /// Request a list of system service DNs not yet in use.
        /// The response is either SystemSystemServiceDnGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSystemServiceDnGetAvailableListResponse> SystemSystemServiceDnGetAvailableListRequestAsync(this OcipClient client, SystemSystemServiceDnGetAvailableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSystemServiceDnGetAvailableListResponse;
        }
        /// <summary>
        /// Request a summary table of all System Service DNs.
        /// The response is either SystemSystemServiceDnGetSummaryListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemServiceDnGetSummaryListRequestAsync instead.")]
        public static async Task<SystemSystemServiceDnGetSummaryListResponse> SystemSystemServiceDnGetSummaryListRequest(this OcipClient client, SystemSystemServiceDnGetSummaryListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSystemServiceDnGetSummaryListResponse;
        }

        /// <summary>
        /// Request a summary table of all System Service DNs.
        /// The response is either SystemSystemServiceDnGetSummaryListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSystemServiceDnGetSummaryListResponse> SystemSystemServiceDnGetSummaryListRequestAsync(this OcipClient client, SystemSystemServiceDnGetSummaryListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSystemServiceDnGetSummaryListResponse;
        }
        /// <summary>
        /// Request a list of System Service DN utilization.
        /// The response is either SystemSystemServiceDnGetUsageListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemServiceDnGetUsageListRequestAsync instead.")]
        public static async Task<SystemSystemServiceDnGetUsageListResponse> SystemSystemServiceDnGetUsageListRequest(this OcipClient client, SystemSystemServiceDnGetUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSystemServiceDnGetUsageListResponse;
        }

        /// <summary>
        /// Request a list of System Service DN utilization.
        /// The response is either SystemSystemServiceDnGetUsageListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSystemServiceDnGetUsageListResponse> SystemSystemServiceDnGetUsageListRequestAsync(this OcipClient client, SystemSystemServiceDnGetUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSystemServiceDnGetUsageListResponse;
        }
        /// <summary>
        /// Request to add a system voice portal instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in IMS mode:
        /// publicUserIdentity, ignored in standalone mode if provided.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemVoicePortalAddRequest21sp1Async instead.")]
        public static async Task<SuccessResponse> SystemSystemVoicePortalAddRequest21sp1(this OcipClient client, SystemSystemVoicePortalAddRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a system voice portal instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in IMS mode:
        /// publicUserIdentity, ignored in standalone mode if provided.
        /// </summary>
        public static async Task<SuccessResponse> SystemSystemVoicePortalAddRequest21sp1Async(this OcipClient client, SystemSystemVoicePortalAddRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a system voice portal instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemVoicePortalDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSystemVoicePortalDeleteRequest(this OcipClient client, SystemSystemVoicePortalDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a system voice portal instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSystemVoicePortalDeleteRequestAsync(this OcipClient client, SystemSystemVoicePortalDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of the system voice portals.
        /// The response is either SystemSystemVoicePortalGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemVoicePortalGetListRequestAsync instead.")]
        public static async Task<SystemSystemVoicePortalGetListResponse> SystemSystemVoicePortalGetListRequest(this OcipClient client, SystemSystemVoicePortalGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSystemVoicePortalGetListResponse;
        }

        /// <summary>
        /// Request to get the list of the system voice portals.
        /// The response is either SystemSystemVoicePortalGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSystemVoicePortalGetListResponse> SystemSystemVoicePortalGetListRequestAsync(this OcipClient client, SystemSystemVoicePortalGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSystemVoicePortalGetListResponse;
        }
        /// <summary>
        /// Request to get a system voice portal instance.
        /// The response is either SystemSystemVoicePortalGetResponse21sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemVoicePortalGetRequest21sp1Async instead.")]
        public static async Task<SystemSystemVoicePortalGetResponse21sp1> SystemSystemVoicePortalGetRequest21sp1(this OcipClient client, SystemSystemVoicePortalGetRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSystemVoicePortalGetResponse21sp1;
        }

        /// <summary>
        /// Request to get a system voice portal instance.
        /// The response is either SystemSystemVoicePortalGetResponse21sp1 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSystemVoicePortalGetResponse21sp1> SystemSystemVoicePortalGetRequest21sp1Async(this OcipClient client, SystemSystemVoicePortalGetRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSystemVoicePortalGetResponse21sp1;
        }
        /// <summary>
        /// Request to update a System  Voice portal instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSystemVoicePortalModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSystemVoicePortalModifyRequest(this OcipClient client, SystemSystemVoicePortalModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to update a System  Voice portal instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSystemVoicePortalModifyRequestAsync(this OcipClient client, SystemSystemVoicePortalModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the configured time zone of the server processing the request and the list of time zone names.
        /// The response is either SystemTimeZoneGetListResponse20 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTimeZoneGetListRequest20Async instead.")]
        public static async Task<SystemTimeZoneGetListResponse20> SystemTimeZoneGetListRequest20(this OcipClient client, SystemTimeZoneGetListRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTimeZoneGetListResponse20;
        }

        /// <summary>
        /// Requests the configured time zone of the server processing the request and the list of time zone names.
        /// The response is either SystemTimeZoneGetListResponse20 or ErrorResponse.
        /// </summary>
        public static async Task<SystemTimeZoneGetListResponse20> SystemTimeZoneGetListRequest20Async(this OcipClient client, SystemTimeZoneGetListRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTimeZoneGetListResponse20;
        }
        /// <summary>
        /// Add an Access SIP Status Code Mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingAccessSIPStatusAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingAccessSIPStatusAddRequest(this OcipClient client, SystemTreatmentMappingAccessSIPStatusAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an Access SIP Status Code Mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingAccessSIPStatusAddRequestAsync(this OcipClient client, SystemTreatmentMappingAccessSIPStatusAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an Access SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingAccessSIPStatusDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingAccessSIPStatusDeleteRequest(this OcipClient client, SystemTreatmentMappingAccessSIPStatusDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an Access SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingAccessSIPStatusDeleteRequestAsync(this OcipClient client, SystemTreatmentMappingAccessSIPStatusDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a table of all the existing Access Side SIP Status Code Mappings in the system.
        /// The response is either an SystemTreatmentMappingAccessSIPStatusGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingAccessSIPStatusGetListRequestAsync instead.")]
        public static async Task<SystemTreatmentMappingAccessSIPStatusGetListResponse> SystemTreatmentMappingAccessSIPStatusGetListRequest(this OcipClient client, SystemTreatmentMappingAccessSIPStatusGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTreatmentMappingAccessSIPStatusGetListResponse;
        }

        /// <summary>
        /// Requests a table of all the existing Access Side SIP Status Code Mappings in the system.
        /// The response is either an SystemTreatmentMappingAccessSIPStatusGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemTreatmentMappingAccessSIPStatusGetListResponse> SystemTreatmentMappingAccessSIPStatusGetListRequestAsync(this OcipClient client, SystemTreatmentMappingAccessSIPStatusGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTreatmentMappingAccessSIPStatusGetListResponse;
        }
        /// <summary>
        /// Modify the fields for an Access SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingAccessSIPStatusModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingAccessSIPStatusModifyRequest(this OcipClient client, SystemTreatmentMappingAccessSIPStatusModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for an Access SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingAccessSIPStatusModifyRequestAsync(this OcipClient client, SystemTreatmentMappingAccessSIPStatusModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceAddRequest23Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest23(this OcipClient client, SystemTreatmentMappingCallBlockingServiceAddRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest23Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceAddRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceDeleteRequest23Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest23(this OcipClient client, SystemTreatmentMappingCallBlockingServiceDeleteRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest23Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceDeleteRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a table of all the existing Call Blocking Service Mappings in the system.
        /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse23
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceGetListRequest23Async instead.")]
        public static async Task<SystemTreatmentMappingCallBlockingServiceGetListResponse23> SystemTreatmentMappingCallBlockingServiceGetListRequest23(this OcipClient client, SystemTreatmentMappingCallBlockingServiceGetListRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTreatmentMappingCallBlockingServiceGetListResponse23;
        }

        /// <summary>
        /// Requests a table of all the existing Call Blocking Service Mappings in the system.
        /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse23
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemTreatmentMappingCallBlockingServiceGetListResponse23> SystemTreatmentMappingCallBlockingServiceGetListRequest23Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceGetListRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTreatmentMappingCallBlockingServiceGetListResponse23;
        }
        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceModifyRequest23Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest23(this OcipClient client, SystemTreatmentMappingCallBlockingServiceModifyRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest23Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceModifyRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add an Internal Release Cause mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingInternalReleaseCauseAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingInternalReleaseCauseAddRequest(this OcipClient client, SystemTreatmentMappingInternalReleaseCauseAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an Internal Release Cause mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingInternalReleaseCauseAddRequestAsync(this OcipClient client, SystemTreatmentMappingInternalReleaseCauseAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an Internal Release Cause mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingInternalReleaseCauseDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingInternalReleaseCauseDeleteRequest(this OcipClient client, SystemTreatmentMappingInternalReleaseCauseDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an Internal Release Cause mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingInternalReleaseCauseDeleteRequestAsync(this OcipClient client, SystemTreatmentMappingInternalReleaseCauseDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a table of all the Internal Release Cause mappings in the system.
        /// The response is either a SystemTreatmentMappingInternalReleaseCauseGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingInternalReleaseCauseGetListRequestAsync instead.")]
        public static async Task<SystemTreatmentMappingInternalReleaseCauseGetListResponse> SystemTreatmentMappingInternalReleaseCauseGetListRequest(this OcipClient client, SystemTreatmentMappingInternalReleaseCauseGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTreatmentMappingInternalReleaseCauseGetListResponse;
        }

        /// <summary>
        /// Requests a table of all the Internal Release Cause mappings in the system.
        /// The response is either a SystemTreatmentMappingInternalReleaseCauseGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemTreatmentMappingInternalReleaseCauseGetListResponse> SystemTreatmentMappingInternalReleaseCauseGetListRequestAsync(this OcipClient client, SystemTreatmentMappingInternalReleaseCauseGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTreatmentMappingInternalReleaseCauseGetListResponse;
        }
        /// <summary>
        /// Modify the fields for an Internal Release Cause mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingInternalReleaseCauseModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingInternalReleaseCauseModifyRequest(this OcipClient client, SystemTreatmentMappingInternalReleaseCauseModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for an Internal Release Cause mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingInternalReleaseCauseModifyRequestAsync(this OcipClient client, SystemTreatmentMappingInternalReleaseCauseModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Network Server Treatment mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingNetworkServerTreatmentAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkServerTreatmentAddRequest(this OcipClient client, SystemTreatmentMappingNetworkServerTreatmentAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Network Server Treatment mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkServerTreatmentAddRequestAsync(this OcipClient client, SystemTreatmentMappingNetworkServerTreatmentAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a NS Treatment mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingNetworkServerTreatmentDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkServerTreatmentDeleteRequest(this OcipClient client, SystemTreatmentMappingNetworkServerTreatmentDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a NS Treatment mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkServerTreatmentDeleteRequestAsync(this OcipClient client, SystemTreatmentMappingNetworkServerTreatmentDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a table of all the existing NS Treatment Mappings in the system.
        /// The response is either a   SystemTreatmentMappingNetworkServerTreatmentGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingNetworkServerTreatmentGetListRequestAsync instead.")]
        public static async Task<SystemTreatmentMappingNetworkServerTreatmentGetListResponse> SystemTreatmentMappingNetworkServerTreatmentGetListRequest(this OcipClient client, SystemTreatmentMappingNetworkServerTreatmentGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTreatmentMappingNetworkServerTreatmentGetListResponse;
        }

        /// <summary>
        /// Requests a table of all the existing NS Treatment Mappings in the system.
        /// The response is either a   SystemTreatmentMappingNetworkServerTreatmentGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemTreatmentMappingNetworkServerTreatmentGetListResponse> SystemTreatmentMappingNetworkServerTreatmentGetListRequestAsync(this OcipClient client, SystemTreatmentMappingNetworkServerTreatmentGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTreatmentMappingNetworkServerTreatmentGetListResponse;
        }
        /// <summary>
        /// Modify the fields for a Network Server Treatment mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingNetworkServerTreatmentModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkServerTreatmentModifyRequest(this OcipClient client, SystemTreatmentMappingNetworkServerTreatmentModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for a Network Server Treatment mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkServerTreatmentModifyRequestAsync(this OcipClient client, SystemTreatmentMappingNetworkServerTreatmentModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Network SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingNetworkSIPStatusAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkSIPStatusAddRequest(this OcipClient client, SystemTreatmentMappingNetworkSIPStatusAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Network SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkSIPStatusAddRequestAsync(this OcipClient client, SystemTreatmentMappingNetworkSIPStatusAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Network SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingNetworkSIPStatusDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkSIPStatusDeleteRequest(this OcipClient client, SystemTreatmentMappingNetworkSIPStatusDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Network SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkSIPStatusDeleteRequestAsync(this OcipClient client, SystemTreatmentMappingNetworkSIPStatusDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a table of all the existing Network SIP Status Code Mappings in the system.
        /// The response is either an SystemTreatmentMappingNetworkSIPStatusGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingNetworkSIPStatusGetListRequestAsync instead.")]
        public static async Task<SystemTreatmentMappingNetworkSIPStatusGetListResponse> SystemTreatmentMappingNetworkSIPStatusGetListRequest(this OcipClient client, SystemTreatmentMappingNetworkSIPStatusGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTreatmentMappingNetworkSIPStatusGetListResponse;
        }

        /// <summary>
        /// Requests a table of all the existing Network SIP Status Code Mappings in the system.
        /// The response is either an SystemTreatmentMappingNetworkSIPStatusGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemTreatmentMappingNetworkSIPStatusGetListResponse> SystemTreatmentMappingNetworkSIPStatusGetListRequestAsync(this OcipClient client, SystemTreatmentMappingNetworkSIPStatusGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTreatmentMappingNetworkSIPStatusGetListResponse;
        }
        /// <summary>
        /// Modify the fields for a Network SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingNetworkSIPStatusModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkSIPStatusModifyRequest(this OcipClient client, SystemTreatmentMappingNetworkSIPStatusModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for a Network SIP Status Code mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingNetworkSIPStatusModifyRequestAsync(this OcipClient client, SystemTreatmentMappingNetworkSIPStatusModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Q850 Cause Value mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingQ850CauseAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingQ850CauseAddRequest(this OcipClient client, SystemTreatmentMappingQ850CauseAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Q850 Cause Value mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingQ850CauseAddRequestAsync(this OcipClient client, SystemTreatmentMappingQ850CauseAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Q850 Cause Value mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingQ850CauseDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingQ850CauseDeleteRequest(this OcipClient client, SystemTreatmentMappingQ850CauseDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Q850 Cause Value mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingQ850CauseDeleteRequestAsync(this OcipClient client, SystemTreatmentMappingQ850CauseDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a table of all the existing Q850 Cause Value Mappings in the system.
        /// The response is either a SystemTreatmentMappingQ850CauseGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingQ850CauseGetListRequestAsync instead.")]
        public static async Task<SystemTreatmentMappingQ850CauseGetListResponse> SystemTreatmentMappingQ850CauseGetListRequest(this OcipClient client, SystemTreatmentMappingQ850CauseGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTreatmentMappingQ850CauseGetListResponse;
        }

        /// <summary>
        /// Requests a table of all the existing Q850 Cause Value Mappings in the system.
        /// The response is either a SystemTreatmentMappingQ850CauseGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemTreatmentMappingQ850CauseGetListResponse> SystemTreatmentMappingQ850CauseGetListRequestAsync(this OcipClient client, SystemTreatmentMappingQ850CauseGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTreatmentMappingQ850CauseGetListResponse;
        }
        /// <summary>
        /// Modify the fields for a Q850CauseValue mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingQ850CauseModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingQ850CauseModifyRequest(this OcipClient client, SystemTreatmentMappingQ850CauseModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for a Q850CauseValue mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingQ850CauseModifyRequestAsync(this OcipClient client, SystemTreatmentMappingQ850CauseModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Represents a Verify Translation and Routing request which can be either a request containing
        /// parameters or a request containing a SIP message. The response is a SystemVerifyTranslationAndRoutingResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVerifyTranslationAndRoutingRequestAsync instead.")]
        public static async Task<SystemVerifyTranslationAndRoutingResponse> SystemVerifyTranslationAndRoutingRequest(this OcipClient client, SystemVerifyTranslationAndRoutingRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemVerifyTranslationAndRoutingResponse;
        }

        /// <summary>
        /// Represents a Verify Translation and Routing request which can be either a request containing
        /// parameters or a request containing a SIP message. The response is a SystemVerifyTranslationAndRoutingResponse.
        /// </summary>
        public static async Task<SystemVerifyTranslationAndRoutingResponse> SystemVerifyTranslationAndRoutingRequestAsync(this OcipClient client, SystemVerifyTranslationAndRoutingRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemVerifyTranslationAndRoutingResponse;
        }
        /// <summary>
        /// Request to add a video server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVideoServerAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemVideoServerAddRequest(this OcipClient client, SystemVideoServerAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a video server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVideoServerAddRequestAsync(this OcipClient client, SystemVideoServerAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a video server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVideoServerDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemVideoServerDeleteRequest(this OcipClient client, SystemVideoServerDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a video server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVideoServerDeleteRequestAsync(this OcipClient client, SystemVideoServerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of video servers defined in the system.
        /// The response is either a SystemVideoServerGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVideoServerGetListRequestAsync instead.")]
        public static async Task<SystemVideoServerGetListResponse> SystemVideoServerGetListRequest(this OcipClient client, SystemVideoServerGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemVideoServerGetListResponse;
        }

        /// <summary>
        /// Request to get a list of video servers defined in the system.
        /// The response is either a SystemVideoServerGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemVideoServerGetListResponse> SystemVideoServerGetListRequestAsync(this OcipClient client, SystemVideoServerGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemVideoServerGetListResponse;
        }
        /// <summary>
        /// Request to modify a video server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVideoServerModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemVideoServerModifyRequest(this OcipClient client, SystemVideoServerModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a video server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVideoServerModifyRequestAsync(this OcipClient client, SystemVideoServerModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of video server system parameters.
        /// The response is either SystemVideoServerParametersGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVideoServerParametersGetRequestAsync instead.")]
        public static async Task<SystemVideoServerParametersGetResponse> SystemVideoServerParametersGetRequest(this OcipClient client, SystemVideoServerParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemVideoServerParametersGetResponse;
        }

        /// <summary>
        /// Request to get the list of video server system parameters.
        /// The response is either SystemVideoServerParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemVideoServerParametersGetResponse> SystemVideoServerParametersGetRequestAsync(this OcipClient client, SystemVideoServerParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemVideoServerParametersGetResponse;
        }
        /// <summary>
        /// Request to modify video server system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVideoServerParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemVideoServerParametersModifyRequest(this OcipClient client, SystemVideoServerParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify video server system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVideoServerParametersModifyRequestAsync(this OcipClient client, SystemVideoServerParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Zone and optional Net Addresses and Physical Locations.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemZoneAddRequest(this OcipClient client, SystemZoneAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Zone and optional Net Addresses and Physical Locations.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemZoneAddRequestAsync(this OcipClient client, SystemZoneAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Returns a zone calling physical location for a given zone.
        /// The response is SystemZoneCallingZonePhysicalLocationGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneCallingZonePhysicalLocationGetRequestAsync instead.")]
        public static async Task<SystemZoneCallingZonePhysicalLocationGetResponse> SystemZoneCallingZonePhysicalLocationGetRequest(this OcipClient client, SystemZoneCallingZonePhysicalLocationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemZoneCallingZonePhysicalLocationGetResponse;
        }

        /// <summary>
        /// Returns a zone calling physical location for a given zone.
        /// The response is SystemZoneCallingZonePhysicalLocationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemZoneCallingZonePhysicalLocationGetResponse> SystemZoneCallingZonePhysicalLocationGetRequestAsync(this OcipClient client, SystemZoneCallingZonePhysicalLocationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemZoneCallingZonePhysicalLocationGetResponse;
        }
        /// <summary>
        /// Modifies a zone calling physical location for a given zone.
        /// The response is a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneCallingZonePhysicalLocationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemZoneCallingZonePhysicalLocationModifyRequest(this OcipClient client, SystemZoneCallingZonePhysicalLocationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies a zone calling physical location for a given zone.
        /// The response is a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemZoneCallingZonePhysicalLocationModifyRequestAsync(this OcipClient client, SystemZoneCallingZonePhysicalLocationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Zone.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemZoneDeleteRequest(this OcipClient client, SystemZoneDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Zone.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemZoneDeleteRequestAsync(this OcipClient client, SystemZoneDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all Zones.
        /// The response is either a SystemZoneGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneGetListRequestAsync instead.")]
        public static async Task<SystemZoneGetListResponse> SystemZoneGetListRequest(this OcipClient client, SystemZoneGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemZoneGetListResponse;
        }

        /// <summary>
        /// Get the list of all Zones.
        /// The response is either a SystemZoneGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemZoneGetListResponse> SystemZoneGetListRequestAsync(this OcipClient client, SystemZoneGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemZoneGetListResponse;
        }
        /// <summary>
        /// Adds a list of physical locations to a zone
        /// The response is SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneLocationBasedPhysicalLocationAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemZoneLocationBasedPhysicalLocationAddListRequest(this OcipClient client, SystemZoneLocationBasedPhysicalLocationAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Adds a list of physical locations to a zone
        /// The response is SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemZoneLocationBasedPhysicalLocationAddListRequestAsync(this OcipClient client, SystemZoneLocationBasedPhysicalLocationAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deletes a list of physical addresses from a zone
        /// The response is SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneLocationBasedPhysicalLocationDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemZoneLocationBasedPhysicalLocationDeleteListRequest(this OcipClient client, SystemZoneLocationBasedPhysicalLocationDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deletes a list of physical addresses from a zone
        /// The response is SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemZoneLocationBasedPhysicalLocationDeleteListRequestAsync(this OcipClient client, SystemZoneLocationBasedPhysicalLocationDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Gets a list of physical locations assigned to a zone.
        /// The response is SystemZoneLocationBasedPhysicalLocationGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneLocationBasedPhysicalLocationGetListRequestAsync instead.")]
        public static async Task<SystemZoneLocationBasedPhysicalLocationGetListResponse> SystemZoneLocationBasedPhysicalLocationGetListRequest(this OcipClient client, SystemZoneLocationBasedPhysicalLocationGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemZoneLocationBasedPhysicalLocationGetListResponse;
        }

        /// <summary>
        /// Gets a list of physical locations assigned to a zone.
        /// The response is SystemZoneLocationBasedPhysicalLocationGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemZoneLocationBasedPhysicalLocationGetListResponse> SystemZoneLocationBasedPhysicalLocationGetListRequestAsync(this OcipClient client, SystemZoneLocationBasedPhysicalLocationGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemZoneLocationBasedPhysicalLocationGetListResponse;
        }
        /// <summary>
        /// Adds a list of IP addresses to a zone
        /// The response is SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneNetAddressAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemZoneNetAddressAddListRequest(this OcipClient client, SystemZoneNetAddressAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Adds a list of IP addresses to a zone
        /// The response is SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemZoneNetAddressAddListRequestAsync(this OcipClient client, SystemZoneNetAddressAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deletes a list of IP addresses from a zone
        /// The response is SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneNetAddressDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemZoneNetAddressDeleteListRequest(this OcipClient client, SystemZoneNetAddressDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deletes a list of IP addresses from a zone
        /// The response is SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemZoneNetAddressDeleteListRequestAsync(this OcipClient client, SystemZoneNetAddressDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Gets a list of IP Addresses and/or Ranges assigned to a zone.
        /// The response is SystemZoneNetAddressGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemZoneNetAddressGetListRequestAsync instead.")]
        public static async Task<SystemZoneNetAddressGetListResponse> SystemZoneNetAddressGetListRequest(this OcipClient client, SystemZoneNetAddressGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemZoneNetAddressGetListResponse;
        }

        /// <summary>
        /// Gets a list of IP Addresses and/or Ranges assigned to a zone.
        /// The response is SystemZoneNetAddressGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemZoneNetAddressGetListResponse> SystemZoneNetAddressGetListRequestAsync(this OcipClient client, SystemZoneNetAddressGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemZoneNetAddressGetListResponse;
        }

    }
}
