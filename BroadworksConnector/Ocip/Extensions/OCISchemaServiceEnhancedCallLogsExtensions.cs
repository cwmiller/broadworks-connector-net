using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceEnhancedCallLogsExtensions
    {

        /// <summary>
        /// Get the enhanced call log database schema instance associated with a group of
        /// a service provider.
        /// The response is either a GroupEnhancedCallLogsSchemaInstanceGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEnhancedCallLogsSchemaInstanceGetResponse> GroupEnhancedCallLogsSchemaInstanceGetRequest(this OcipClient client, GroupEnhancedCallLogsSchemaInstanceGetRequest request)
        {
            return await client.Call(request) as GroupEnhancedCallLogsSchemaInstanceGetResponse;
        }

        /// <summary>
        /// Modify the Enhanced Call Logs schema instance associated with a group of a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnhancedCallLogsSchemaInstanceModifyRequest(this OcipClient client, GroupEnhancedCallLogsSchemaInstanceModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the enhanced call log database schema instance associated with this
        /// service provider.
        /// The response is either a ServiceProviderEnhancedCallLogsSchemaInstanceGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderEnhancedCallLogsSchemaInstanceGetResponse> ServiceProviderEnhancedCallLogsSchemaInstanceGetRequest(this OcipClient client, ServiceProviderEnhancedCallLogsSchemaInstanceGetRequest request)
        {
            return await client.Call(request) as ServiceProviderEnhancedCallLogsSchemaInstanceGetResponse;
        }

        /// <summary>
        /// Modify the Enhanced Call Logs schema instance associated with this Service Provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderEnhancedCallLogsSchemaInstanceModifyRequest(this OcipClient client, ServiceProviderEnhancedCallLogsSchemaInstanceModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the service provider's enhanced call log settings.
        /// The response is either a ServiceProviderEnhancedCallLogsGetResponse17sp4 or an ErrorResponse.
        /// This command will return an ErrorResponse if DBS is used as the call log server.
        /// </summary>
        public static async Task<ServiceProviderEnhancedCallLogsGetResponse17sp4> ServiceProviderEnhancedCallLogsGetRequest17sp4(this OcipClient client, ServiceProviderEnhancedCallLogsGetRequest17sp4 request)
        {
            return await client.Call(request) as ServiceProviderEnhancedCallLogsGetResponse17sp4;
        }

        /// <summary>
        /// Modify the Service Provider level data associated with Enhanced Call Logs.
        /// Configures the maximum number of logged calls and maximum age of your user's call logs.
        /// Log entries are deleted when either of the two limits is reached.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderEnhancedCallLogsModifyRequest(this OcipClient client, ServiceProviderEnhancedCallLogsModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the system level data associated with Enhanced Call Logs. The response is either a SystemEnhancedCallLogsGetResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemEnhancedCallLogsGetResponse22> SystemEnhancedCallLogsGetRequest22(this OcipClient client, SystemEnhancedCallLogsGetRequest22 request)
        {
            return await client.Call(request) as SystemEnhancedCallLogsGetResponse22;
        }

        /// <summary>
        /// Modify the system level data associated with Enhanced Call Logs.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemEnhancedCallLogsModifyRequest22(this OcipClient client, SystemEnhancedCallLogsModifyRequest22 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the system level database schema instances defined for Enhanced Call Logs.
        /// For each instance, the number of actual users (users that have the Enhanced Call Logs service
        /// and are assigned to that schema instance) and the number of potential users are given
        /// (users part of a group or service provider using that schema instance).
        /// The response is either a SystemEnhancedCallLogsSchemaInstanceGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemEnhancedCallLogsSchemaInstanceGetListResponse> SystemEnhancedCallLogsSchemaInstanceGetListRequest(this OcipClient client, SystemEnhancedCallLogsSchemaInstanceGetListRequest request)
        {
            return await client.Call(request) as SystemEnhancedCallLogsSchemaInstanceGetListResponse;
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
        /// The response is either a UserEnhancedCallLogsGetListResponse22 or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// callAuthorizationCodeFilter
        /// </summary>
        public static async Task<UserEnhancedCallLogsGetListResponse22> UserEnhancedCallLogsGetListRequest22(this OcipClient client, UserEnhancedCallLogsGetListRequest22 request)
        {
            return await client.Call(request) as UserEnhancedCallLogsGetListResponse22;
        }


    }
}
