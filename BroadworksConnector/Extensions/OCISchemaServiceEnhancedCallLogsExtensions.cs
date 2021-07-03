using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceEnhancedCallLogsExtensions
    {

        /// <summary>
        /// Get the enhanced call log database schema instance associated with a group of
        /// a service provider.
        /// The response is either a GroupEnhancedCallLogsSchemaInstanceGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnhancedCallLogsSchemaInstanceGetRequestAsync instead.")]
        public static async Task<GroupEnhancedCallLogsSchemaInstanceGetResponse> GroupEnhancedCallLogsSchemaInstanceGetRequest(this OcipClient client, GroupEnhancedCallLogsSchemaInstanceGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupEnhancedCallLogsSchemaInstanceGetResponse;
        }

        /// <summary>
        /// Get the enhanced call log database schema instance associated with a group of
        /// a service provider.
        /// The response is either a GroupEnhancedCallLogsSchemaInstanceGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEnhancedCallLogsSchemaInstanceGetResponse> GroupEnhancedCallLogsSchemaInstanceGetRequestAsync(this OcipClient client, GroupEnhancedCallLogsSchemaInstanceGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupEnhancedCallLogsSchemaInstanceGetResponse;
        }
        /// <summary>
        /// Modify the Enhanced Call Logs schema instance associated with a group of a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnhancedCallLogsSchemaInstanceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEnhancedCallLogsSchemaInstanceModifyRequest(this OcipClient client, GroupEnhancedCallLogsSchemaInstanceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Enhanced Call Logs schema instance associated with a group of a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnhancedCallLogsSchemaInstanceModifyRequestAsync(this OcipClient client, GroupEnhancedCallLogsSchemaInstanceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the service provider's enhanced call log settings.
        /// The response is either a ServiceProviderEnhancedCallLogsGetResponse17sp4 or an ErrorResponse.
        /// This command will return an ErrorResponse if DBS is used as the call log server.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderEnhancedCallLogsGetRequest17sp4Async instead.")]
        public static async Task<ServiceProviderEnhancedCallLogsGetResponse17sp4> ServiceProviderEnhancedCallLogsGetRequest17sp4(this OcipClient client, ServiceProviderEnhancedCallLogsGetRequest17sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderEnhancedCallLogsGetResponse17sp4;
        }

        /// <summary>
        /// Get the service provider's enhanced call log settings.
        /// The response is either a ServiceProviderEnhancedCallLogsGetResponse17sp4 or an ErrorResponse.
        /// This command will return an ErrorResponse if DBS is used as the call log server.
        /// </summary>
        public static async Task<ServiceProviderEnhancedCallLogsGetResponse17sp4> ServiceProviderEnhancedCallLogsGetRequest17sp4Async(this OcipClient client, ServiceProviderEnhancedCallLogsGetRequest17sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderEnhancedCallLogsGetResponse17sp4;
        }
        /// <summary>
        /// Modify the Service Provider level data associated with Enhanced Call Logs.
        /// Configures the maximum number of logged calls and maximum age of your user's call logs.
        /// Log entries are deleted when either of the two limits is reached.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderEnhancedCallLogsModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderEnhancedCallLogsModifyRequest(this OcipClient client, ServiceProviderEnhancedCallLogsModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Service Provider level data associated with Enhanced Call Logs.
        /// Configures the maximum number of logged calls and maximum age of your user's call logs.
        /// Log entries are deleted when either of the two limits is reached.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderEnhancedCallLogsModifyRequestAsync(this OcipClient client, ServiceProviderEnhancedCallLogsModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the enhanced call log database schema instance associated with this
        /// service provider.
        /// The response is either a ServiceProviderEnhancedCallLogsSchemaInstanceGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderEnhancedCallLogsSchemaInstanceGetRequestAsync instead.")]
        public static async Task<ServiceProviderEnhancedCallLogsSchemaInstanceGetResponse> ServiceProviderEnhancedCallLogsSchemaInstanceGetRequest(this OcipClient client, ServiceProviderEnhancedCallLogsSchemaInstanceGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderEnhancedCallLogsSchemaInstanceGetResponse;
        }

        /// <summary>
        /// Get the enhanced call log database schema instance associated with this
        /// service provider.
        /// The response is either a ServiceProviderEnhancedCallLogsSchemaInstanceGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderEnhancedCallLogsSchemaInstanceGetResponse> ServiceProviderEnhancedCallLogsSchemaInstanceGetRequestAsync(this OcipClient client, ServiceProviderEnhancedCallLogsSchemaInstanceGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderEnhancedCallLogsSchemaInstanceGetResponse;
        }
        /// <summary>
        /// Modify the Enhanced Call Logs schema instance associated with this Service Provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderEnhancedCallLogsSchemaInstanceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderEnhancedCallLogsSchemaInstanceModifyRequest(this OcipClient client, ServiceProviderEnhancedCallLogsSchemaInstanceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Enhanced Call Logs schema instance associated with this Service Provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderEnhancedCallLogsSchemaInstanceModifyRequestAsync(this OcipClient client, ServiceProviderEnhancedCallLogsSchemaInstanceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level database schema instances defined for Enhanced Call Logs.
        /// For each instance, the number of actual users (users that have the Enhanced Call Logs service,
        /// are assigned to that schema instance and have recorded call logs on the NDS) are given.
        /// The response is either a SystemEnhancedCallLogsActiveSchemaInstanceGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEnhancedCallLogsActiveSchemaInstanceGetListRequestAsync instead.")]
        public static async Task<SystemEnhancedCallLogsActiveSchemaInstanceGetListResponse> SystemEnhancedCallLogsActiveSchemaInstanceGetListRequest(this OcipClient client, SystemEnhancedCallLogsActiveSchemaInstanceGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemEnhancedCallLogsActiveSchemaInstanceGetListResponse;
        }

        /// <summary>
        /// Request the system level database schema instances defined for Enhanced Call Logs.
        /// For each instance, the number of actual users (users that have the Enhanced Call Logs service,
        /// are assigned to that schema instance and have recorded call logs on the NDS) are given.
        /// The response is either a SystemEnhancedCallLogsActiveSchemaInstanceGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemEnhancedCallLogsActiveSchemaInstanceGetListResponse> SystemEnhancedCallLogsActiveSchemaInstanceGetListRequestAsync(this OcipClient client, SystemEnhancedCallLogsActiveSchemaInstanceGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemEnhancedCallLogsActiveSchemaInstanceGetListResponse;
        }
        /// <summary>
        /// Request the system level data associated with Enhanced Call Logs. The response is either a SystemEnhancedCallLogsGetResponse22V2 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEnhancedCallLogsGetRequest22V2Async instead.")]
        public static async Task<SystemEnhancedCallLogsGetResponse22V2> SystemEnhancedCallLogsGetRequest22V2(this OcipClient client, SystemEnhancedCallLogsGetRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemEnhancedCallLogsGetResponse22V2;
        }

        /// <summary>
        /// Request the system level data associated with Enhanced Call Logs. The response is either a SystemEnhancedCallLogsGetResponse22V2 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemEnhancedCallLogsGetResponse22V2> SystemEnhancedCallLogsGetRequest22V2Async(this OcipClient client, SystemEnhancedCallLogsGetRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemEnhancedCallLogsGetResponse22V2;
        }
        /// <summary>
        /// Modify the system level data associated with Enhanced Call Logs.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEnhancedCallLogsModifyRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemEnhancedCallLogsModifyRequest22(this OcipClient client, SystemEnhancedCallLogsModifyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Enhanced Call Logs.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemEnhancedCallLogsModifyRequest22Async(this OcipClient client, SystemEnhancedCallLogsModifyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level database schema instances defined for Enhanced Call Logs.
        /// For each instance, the number of actual users (users that have the Enhanced Call Logs service
        /// and are assigned to that schema instance) and the number of potential users are given
        /// (users part of a group or service provider using that schema instance).
        /// The response is either a SystemEnhancedCallLogsSchemaInstanceGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEnhancedCallLogsSchemaInstanceGetListRequestAsync instead.")]
        public static async Task<SystemEnhancedCallLogsSchemaInstanceGetListResponse> SystemEnhancedCallLogsSchemaInstanceGetListRequest(this OcipClient client, SystemEnhancedCallLogsSchemaInstanceGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemEnhancedCallLogsSchemaInstanceGetListResponse;
        }

        /// <summary>
        /// Request the system level database schema instances defined for Enhanced Call Logs.
        /// For each instance, the number of actual users (users that have the Enhanced Call Logs service
        /// and are assigned to that schema instance) and the number of potential users are given
        /// (users part of a group or service provider using that schema instance).
        /// The response is either a SystemEnhancedCallLogsSchemaInstanceGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemEnhancedCallLogsSchemaInstanceGetListResponse> SystemEnhancedCallLogsSchemaInstanceGetListRequestAsync(this OcipClient client, SystemEnhancedCallLogsSchemaInstanceGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemEnhancedCallLogsSchemaInstanceGetListResponse;
        }
        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls logs (placed, received, missed) are returned.
        /// The filters "dateTimeRange", "numberFilter", "redirectedNumberFilter", "accountAuthorizationCodeFilter"
        /// "callAuthorizationCodeFilter" and "subscriberType" are ignored if call logs are stored in CDS. When
        /// "ReceivedOrMissed" is specified as "callLogType" and call logs are stored in CDS, all call logs including
        /// placed will be returned.
        /// It is possible to restrict the number of rows returned using responsePagingControl. If responsePagingControl
        /// is not specified, the value of Enhanced Call Logs system parameter maxNonPagedResponseSize will control
        /// the maximum number of call logs can be returned.
        /// The response is either a UserEnhancedCallLogsGetListResponse23 or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// callAuthorizationCodeFilter
        /// </summary>
        [Obsolete("This method is deprecated. Use UserEnhancedCallLogsGetListRequest23Async instead.")]
        public static async Task<UserEnhancedCallLogsGetListResponse23> UserEnhancedCallLogsGetListRequest23(this OcipClient client, UserEnhancedCallLogsGetListRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserEnhancedCallLogsGetListResponse23;
        }

        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls logs (placed, received, missed) are returned.
        /// The filters "dateTimeRange", "numberFilter", "redirectedNumberFilter", "accountAuthorizationCodeFilter"
        /// "callAuthorizationCodeFilter" and "subscriberType" are ignored if call logs are stored in CDS. When
        /// "ReceivedOrMissed" is specified as "callLogType" and call logs are stored in CDS, all call logs including
        /// placed will be returned.
        /// It is possible to restrict the number of rows returned using responsePagingControl. If responsePagingControl
        /// is not specified, the value of Enhanced Call Logs system parameter maxNonPagedResponseSize will control
        /// the maximum number of call logs can be returned.
        /// The response is either a UserEnhancedCallLogsGetListResponse23 or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// callAuthorizationCodeFilter
        /// </summary>
        public static async Task<UserEnhancedCallLogsGetListResponse23> UserEnhancedCallLogsGetListRequest23Async(this OcipClient client, UserEnhancedCallLogsGetListRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserEnhancedCallLogsGetListResponse23;
        }

    }
}
