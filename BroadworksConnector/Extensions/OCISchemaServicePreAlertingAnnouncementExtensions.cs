using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServicePreAlertingAnnouncementExtensions
    {

        /// <summary>
        /// Get the Enterprise pre-alerting service settings.
        /// The response is either a EnterprisePreAlertingAnnouncementGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterprisePreAlertingAnnouncementGetRequestAsync instead.")]
        public static async Task<EnterprisePreAlertingAnnouncementGetResponse> EnterprisePreAlertingAnnouncementGetRequest(this OcipClient client, EnterprisePreAlertingAnnouncementGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterprisePreAlertingAnnouncementGetResponse;
        }

        /// <summary>
        /// Get the Enterprise pre-alerting service settings.
        /// The response is either a EnterprisePreAlertingAnnouncementGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterprisePreAlertingAnnouncementGetResponse> EnterprisePreAlertingAnnouncementGetRequestAsync(this OcipClient client, EnterprisePreAlertingAnnouncementGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterprisePreAlertingAnnouncementGetResponse;
        }
        /// <summary>
        /// Modify the enterprise level pre-alerting service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterprisePreAlertingAnnouncementModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterprisePreAlertingAnnouncementModifyRequest(this OcipClient client, EnterprisePreAlertingAnnouncementModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the enterprise level pre-alerting service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterprisePreAlertingAnnouncementModifyRequestAsync(this OcipClient client, EnterprisePreAlertingAnnouncementModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the group’s PreAlertingservice settings.
        /// The response is either a GroupPreAlertingAnnouncementGetResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPreAlertingAnnouncementGetRequest20Async instead.")]
        public static async Task<GroupPreAlertingAnnouncementGetResponse20> GroupPreAlertingAnnouncementGetRequest20(this OcipClient client, GroupPreAlertingAnnouncementGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupPreAlertingAnnouncementGetResponse20;
        }

        /// <summary>
        /// Get the group’s PreAlertingservice settings.
        /// The response is either a GroupPreAlertingAnnouncementGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupPreAlertingAnnouncementGetResponse20> GroupPreAlertingAnnouncementGetRequest20Async(this OcipClient client, GroupPreAlertingAnnouncementGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupPreAlertingAnnouncementGetResponse20;
        }
        /// <summary>
        /// Modify the group level pre-alerting service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPreAlertingAnnouncementModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupPreAlertingAnnouncementModifyRequest20(this OcipClient client, GroupPreAlertingAnnouncementModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group level pre-alerting service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupPreAlertingAnnouncementModifyRequest20Async(this OcipClient client, GroupPreAlertingAnnouncementModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a criteria to the user's pre-alerting service.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPreAlertingAnnouncementAddCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPreAlertingAnnouncementAddCriteriaRequest(this OcipClient client, UserPreAlertingAnnouncementAddCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a criteria to the user's pre-alerting service.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPreAlertingAnnouncementAddCriteriaRequestAsync(this OcipClient client, UserPreAlertingAnnouncementAddCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a criteria from the user's pre-alerting service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPreAlertingAnnouncementDeleteCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPreAlertingAnnouncementDeleteCriteriaRequest(this OcipClient client, UserPreAlertingAnnouncementDeleteCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a criteria from the user's pre-alerting service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPreAlertingAnnouncementDeleteCriteriaRequestAsync(this OcipClient client, UserPreAlertingAnnouncementDeleteCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a criteria for the user's pre-alerting service.
        /// The response is either a UserPreAlertingAnnouncementGetCriteriaResponse21 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPreAlertingAnnouncementGetCriteriaRequest21Async instead.")]
        public static async Task<UserPreAlertingAnnouncementGetCriteriaResponse21> UserPreAlertingAnnouncementGetCriteriaRequest21(this OcipClient client, UserPreAlertingAnnouncementGetCriteriaRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPreAlertingAnnouncementGetCriteriaResponse21;
        }

        /// <summary>
        /// Get a criteria for the user's pre-alerting service.
        /// The response is either a UserPreAlertingAnnouncementGetCriteriaResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<UserPreAlertingAnnouncementGetCriteriaResponse21> UserPreAlertingAnnouncementGetCriteriaRequest21Async(this OcipClient client, UserPreAlertingAnnouncementGetCriteriaRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPreAlertingAnnouncementGetCriteriaResponse21;
        }
        /// <summary>
        /// Get the user's pre-alerting service setting.
        /// The response is either a UserPreAlertingAnnouncementGetResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPreAlertingAnnouncementGetRequest20Async instead.")]
        public static async Task<UserPreAlertingAnnouncementGetResponse20> UserPreAlertingAnnouncementGetRequest20(this OcipClient client, UserPreAlertingAnnouncementGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPreAlertingAnnouncementGetResponse20;
        }

        /// <summary>
        /// Get the user's pre-alerting service setting.
        /// The response is either a UserPreAlertingAnnouncementGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<UserPreAlertingAnnouncementGetResponse20> UserPreAlertingAnnouncementGetRequest20Async(this OcipClient client, UserPreAlertingAnnouncementGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPreAlertingAnnouncementGetResponse20;
        }
        /// <summary>
        /// Modify a criteria for the user's pre-alerting service.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPreAlertingAnnouncementModifyCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPreAlertingAnnouncementModifyCriteriaRequest(this OcipClient client, UserPreAlertingAnnouncementModifyCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a criteria for the user's pre-alerting service.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPreAlertingAnnouncementModifyCriteriaRequestAsync(this OcipClient client, UserPreAlertingAnnouncementModifyCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the user's pre-alerting service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPreAlertingAnnouncementModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> UserPreAlertingAnnouncementModifyRequest20(this OcipClient client, UserPreAlertingAnnouncementModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's pre-alerting service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPreAlertingAnnouncementModifyRequest20Async(this OcipClient client, UserPreAlertingAnnouncementModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
