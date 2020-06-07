using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceAutoAttendantExtensions
    {

        /// <summary>
        /// Add a Auto Attendant instance to a group.
        /// The domain is required in the serviceUserId.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// type, use AutoAttendantType.BASIC in XS mode.
        /// holidayMenu.
        /// The following elements are only valid for Standard Auto
        /// Attendants:
        /// holidayMenu
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantAddInstanceRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupAutoAttendantAddInstanceRequest20(this OcipClient client, GroupAutoAttendantAddInstanceRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Auto Attendant instance to a group.
        /// The domain is required in the serviceUserId.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// type, use AutoAttendantType.BASIC in XS mode.
        /// holidayMenu.
        /// The following elements are only valid for Standard Auto
        /// Attendants:
        /// holidayMenu
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantAddInstanceRequest20Async(this OcipClient client, GroupAutoAttendantAddInstanceRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Auto Attendant instance to a group and assign services to the Auto Attendant.
        /// The domain is required in the serviceUserId.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// If the phoneNumber has not been assigned to the group and addPhoneNumberToGroup is set to true,
        /// it will be added to group if the command is executed by a service provider administrator or above
        /// and the number is already assigned to the service provider. The command will fail otherwise.
        /// 
        /// The following elements are only used in AS data mode:
        /// type, use AutoAttendantType.BASIC in XS mode.
        /// holidayMenu.
        /// The following elements are only valid for Standard Auto
        /// Attendants:
        /// holidayMenu
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantConsolidatedAddInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAutoAttendantConsolidatedAddInstanceRequest(this OcipClient client, GroupAutoAttendantConsolidatedAddInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Auto Attendant instance to a group and assign services to the Auto Attendant.
        /// The domain is required in the serviceUserId.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// If the phoneNumber has not been assigned to the group and addPhoneNumberToGroup is set to true,
        /// it will be added to group if the command is executed by a service provider administrator or above
        /// and the number is already assigned to the service provider. The command will fail otherwise.
        /// 
        /// The following elements are only used in AS data mode:
        /// type, use AutoAttendantType.BASIC in XS mode.
        /// holidayMenu.
        /// The following elements are only valid for Standard Auto
        /// Attendants:
        /// holidayMenu
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantConsolidatedAddInstanceRequestAsync(this OcipClient client, GroupAutoAttendantConsolidatedAddInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Auto Attendant instance from a group and free up phone numbers.
        /// If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group if the command is executed by a service provider administrator or above.
        /// When set to 'Service Provider', they will be un-assigned from the group and service provider if the command is executed by a provisioning administrator or above.
        /// When omitted, the number(s) will be left assigned to the group.
        /// An ErrorResponse will be returned if any number cannot be unassigned because of insufficient privilege.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantConsolidatedDeleteInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAutoAttendantConsolidatedDeleteInstanceRequest(this OcipClient client, GroupAutoAttendantConsolidatedDeleteInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Auto Attendant instance from a group and free up phone numbers.
        /// If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group if the command is executed by a service provider administrator or above.
        /// When set to 'Service Provider', they will be un-assigned from the group and service provider if the command is executed by a provisioning administrator or above.
        /// When omitted, the number(s) will be left assigned to the group.
        /// An ErrorResponse will be returned if any number cannot be unassigned because of insufficient privilege.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantConsolidatedDeleteInstanceRequestAsync(this OcipClient client, GroupAutoAttendantConsolidatedDeleteInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify an Auto Attendant instance and assign services to the Auto Attendant.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// When phone numbers are un-assigned from the user, the unused numbers may be un-assigned from the group and service provider. If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group if the command is executed by a service provider administrator or above.
        /// When set to 'Service Provider', they will be un-assigned from the group and service provider if the command is executed by a provisioning administrator or above.
        /// When omitted, the number(s) will be left assigned to the group.
        /// An ErrorResponse will be returned if any number cannot be unassigned because of insufficient privilege.
        /// 
        /// If the phoneNumber has not been assigned to the group and addPhoneNumberToGroup is set to true, it will be added to group if needed if the command is executed by a service provider administrator and above. The command will fail otherwise.
        /// 
        /// The following elements are only used in AS data mode:
        /// holidayMenu.
        /// The following elements are only valid for Standard Auto
        /// Attendants:
        /// holidayMenu
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantConsolidatedModifyInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAutoAttendantConsolidatedModifyInstanceRequest(this OcipClient client, GroupAutoAttendantConsolidatedModifyInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an Auto Attendant instance and assign services to the Auto Attendant.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// When phone numbers are un-assigned from the user, the unused numbers may be un-assigned from the group and service provider. If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group if the command is executed by a service provider administrator or above.
        /// When set to 'Service Provider', they will be un-assigned from the group and service provider if the command is executed by a provisioning administrator or above.
        /// When omitted, the number(s) will be left assigned to the group.
        /// An ErrorResponse will be returned if any number cannot be unassigned because of insufficient privilege.
        /// 
        /// If the phoneNumber has not been assigned to the group and addPhoneNumberToGroup is set to true, it will be added to group if needed if the command is executed by a service provider administrator and above. The command will fail otherwise.
        /// 
        /// The following elements are only used in AS data mode:
        /// holidayMenu.
        /// The following elements are only valid for Standard Auto
        /// Attendants:
        /// holidayMenu
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantConsolidatedModifyInstanceRequestAsync(this OcipClient client, GroupAutoAttendantConsolidatedModifyInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Auto Attendant instance from a group.
        /// 
        /// If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be unassigned from the group if the command is executed by a service provider administrator or above.
        /// When set to 'Service Provider', they will be unassigned from the group and service provider if the command is executed by a provisioning administrator or above.
        /// When omitted, the number(s) will be left assigned to the group.
        /// An ErrorResponse with the type warning will be returned if any number cannot be unassigned because of insufficient privilege.
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantDeleteInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAutoAttendantDeleteInstanceRequest(this OcipClient client, GroupAutoAttendantDeleteInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Auto Attendant instance from a group.
        /// 
        /// If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be unassigned from the group if the command is executed by a service provider administrator or above.
        /// When set to 'Service Provider', they will be unassigned from the group and service provider if the command is executed by a provisioning administrator or above.
        /// When omitted, the number(s) will be left assigned to the group.
        /// An ErrorResponse with the type warning will be returned if any number cannot be unassigned because of insufficient privilege.
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantDeleteInstanceRequestAsync(this OcipClient client, GroupAutoAttendantDeleteInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Auto Attendant instances within a group.
        /// The response is either GroupAutoAttendantGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantGetInstanceListRequestAsync instead.")]
        public static async Task<GroupAutoAttendantGetInstanceListResponse> GroupAutoAttendantGetInstanceListRequest(this OcipClient client, GroupAutoAttendantGetInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAutoAttendantGetInstanceListResponse;
        }

        /// <summary>
        /// Get a list of Auto Attendant instances within a group.
        /// The response is either GroupAutoAttendantGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        public static async Task<GroupAutoAttendantGetInstanceListResponse> GroupAutoAttendantGetInstanceListRequestAsync(this OcipClient client, GroupAutoAttendantGetInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAutoAttendantGetInstanceListResponse;
        }
        /// <summary>
        /// Get a list of Auto Attendant instances within a group.
        /// The response is either GroupAutoAttendantGetInstancePagedSortedListResponse or ErrorResponse.
        /// If no sortOrder is included the response is sorted by Name ascending by default.
        /// 
        /// A limitation to the search by DN activation exists when the Number Activation mode is set to
        /// Off. In this case DNs not assigned to users are never returned by queries with the
        /// "dnActivationSearchCriteria" included.
        /// 
        /// If the responsePagingControl element is not provided,
        /// the paging startIndex will be set to 1 by default,
        /// and the responsePageSize will be set to the maximum responsePageSize by
        /// default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantGetInstancePagedSortedListRequestAsync instead.")]
        public static async Task<GroupAutoAttendantGetInstancePagedSortedListResponse> GroupAutoAttendantGetInstancePagedSortedListRequest(this OcipClient client, GroupAutoAttendantGetInstancePagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAutoAttendantGetInstancePagedSortedListResponse;
        }

        /// <summary>
        /// Get a list of Auto Attendant instances within a group.
        /// The response is either GroupAutoAttendantGetInstancePagedSortedListResponse or ErrorResponse.
        /// If no sortOrder is included the response is sorted by Name ascending by default.
        /// 
        /// A limitation to the search by DN activation exists when the Number Activation mode is set to
        /// Off. In this case DNs not assigned to users are never returned by queries with the
        /// "dnActivationSearchCriteria" included.
        /// 
        /// If the responsePagingControl element is not provided,
        /// the paging startIndex will be set to 1 by default,
        /// and the responsePageSize will be set to the maximum responsePageSize by
        /// default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// </summary>
        public static async Task<GroupAutoAttendantGetInstancePagedSortedListResponse> GroupAutoAttendantGetInstancePagedSortedListRequestAsync(this OcipClient client, GroupAutoAttendantGetInstancePagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAutoAttendantGetInstancePagedSortedListResponse;
        }
        /// <summary>
        /// Request to get all the information of a Auto Attendant instance.
        /// The response is either GroupAutoAttendantGetInstanceResponse20 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantGetInstanceRequest20Async instead.")]
        public static async Task<GroupAutoAttendantGetInstanceResponse20> GroupAutoAttendantGetInstanceRequest20(this OcipClient client, GroupAutoAttendantGetInstanceRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAutoAttendantGetInstanceResponse20;
        }

        /// <summary>
        /// Request to get all the information of a Auto Attendant instance.
        /// The response is either GroupAutoAttendantGetInstanceResponse20 or ErrorResponse.
        /// </summary>
        public static async Task<GroupAutoAttendantGetInstanceResponse20> GroupAutoAttendantGetInstanceRequest20Async(this OcipClient client, GroupAutoAttendantGetInstanceRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAutoAttendantGetInstanceResponse20;
        }
        /// <summary>
        /// Request to set the active status of Auto Attendant instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantModifyActiveInstanceListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAutoAttendantModifyActiveInstanceListRequest(this OcipClient client, GroupAutoAttendantModifyActiveInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to set the active status of Auto Attendant instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantModifyActiveInstanceListRequestAsync(this OcipClient client, GroupAutoAttendantModifyActiveInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify an Auto Attendant instance.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// holidayMenu.
        /// The following elements are only valid for Standard Auto
        /// Attendants:
        /// holidayMenu
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantModifyInstanceRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupAutoAttendantModifyInstanceRequest20(this OcipClient client, GroupAutoAttendantModifyInstanceRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an Auto Attendant instance.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// holidayMenu.
        /// The following elements are only valid for Standard Auto
        /// Attendants:
        /// holidayMenu
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantModifyInstanceRequest20Async(this OcipClient client, GroupAutoAttendantModifyInstanceRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add an Auto Attendant submenu instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantSubmenuAddRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupAutoAttendantSubmenuAddRequest20(this OcipClient client, GroupAutoAttendantSubmenuAddRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add an Auto Attendant submenu instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantSubmenuAddRequest20Async(this OcipClient client, GroupAutoAttendantSubmenuAddRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a submenu form an auto attendant.
        /// The response is either SuccessResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantSubmenuDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAutoAttendantSubmenuDeleteListRequest(this OcipClient client, GroupAutoAttendantSubmenuDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a submenu form an auto attendant.
        /// The response is either SuccessResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantSubmenuDeleteListRequestAsync(this OcipClient client, GroupAutoAttendantSubmenuDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Auto Attendant Submenus.
        /// The response is either GroupAutoAttendantSubmenuGetListResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantSubmenuGetListRequestAsync instead.")]
        public static async Task<GroupAutoAttendantSubmenuGetListResponse> GroupAutoAttendantSubmenuGetListRequest(this OcipClient client, GroupAutoAttendantSubmenuGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAutoAttendantSubmenuGetListResponse;
        }

        /// <summary>
        /// Get a list of Auto Attendant Submenus.
        /// The response is either GroupAutoAttendantSubmenuGetListResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// </summary>
        public static async Task<GroupAutoAttendantSubmenuGetListResponse> GroupAutoAttendantSubmenuGetListRequestAsync(this OcipClient client, GroupAutoAttendantSubmenuGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAutoAttendantSubmenuGetListResponse;
        }
        /// <summary>
        /// Request to get an Auto Attendant submenu instance.
        /// The response is either GroupAutoAttendantSubmenuGetResponse20 or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantSubmenuGetRequest20Async instead.")]
        public static async Task<GroupAutoAttendantSubmenuGetResponse20> GroupAutoAttendantSubmenuGetRequest20(this OcipClient client, GroupAutoAttendantSubmenuGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAutoAttendantSubmenuGetResponse20;
        }

        /// <summary>
        /// Request to get an Auto Attendant submenu instance.
        /// The response is either GroupAutoAttendantSubmenuGetResponse20 or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// </summary>
        public static async Task<GroupAutoAttendantSubmenuGetResponse20> GroupAutoAttendantSubmenuGetRequest20Async(this OcipClient client, GroupAutoAttendantSubmenuGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAutoAttendantSubmenuGetResponse20;
        }
        /// <summary>
        /// Get a list of Auto Attendant Business Hours Menu,After Hours Menu,Holiday Menu and Submenus that use this submenu.
        /// The response is either GroupAutoAttendantSubmenuGetUsageListResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantSubmenuGetUsageListRequestAsync instead.")]
        public static async Task<GroupAutoAttendantSubmenuGetUsageListResponse> GroupAutoAttendantSubmenuGetUsageListRequest(this OcipClient client, GroupAutoAttendantSubmenuGetUsageListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAutoAttendantSubmenuGetUsageListResponse;
        }

        /// <summary>
        /// Get a list of Auto Attendant Business Hours Menu,After Hours Menu,Holiday Menu and Submenus that use this submenu.
        /// The response is either GroupAutoAttendantSubmenuGetUsageListResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// </summary>
        public static async Task<GroupAutoAttendantSubmenuGetUsageListResponse> GroupAutoAttendantSubmenuGetUsageListRequestAsync(this OcipClient client, GroupAutoAttendantSubmenuGetUsageListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAutoAttendantSubmenuGetUsageListResponse;
        }
        /// <summary>
        /// Request to modify an Auto Attendant submenu instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantSubmenuModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupAutoAttendantSubmenuModifyRequest20(this OcipClient client, GroupAutoAttendantSubmenuModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an Auto Attendant submenu instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantSubmenuModifyRequest20Async(this OcipClient client, GroupAutoAttendantSubmenuModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
