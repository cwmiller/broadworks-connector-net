using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceExecutiveExtensions
    {

        /// <summary>
        /// Request to get the Executive system parameters.
        /// The response is either SystemExecutiveGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExecutiveGetRequestAsync instead.")]
        public static async Task<SystemExecutiveGetResponse> SystemExecutiveGetRequest(this OcipClient client, SystemExecutiveGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemExecutiveGetResponse;
        }

        /// <summary>
        /// Request to get the Executive system parameters.
        /// The response is either SystemExecutiveGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemExecutiveGetResponse> SystemExecutiveGetRequestAsync(this OcipClient client, SystemExecutiveGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemExecutiveGetResponse;
        }
        /// <summary>
        /// Request to modify the Executive system parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemExecutiveModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemExecutiveModifyRequest(this OcipClient client, SystemExecutiveModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the Executive system parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExecutiveModifyRequestAsync(this OcipClient client, SystemExecutiveModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a filtering criteria to an executive user.
        /// Both executive and the executive assistant can run this command.
        /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserExecutiveAddFilteringSelectiveCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserExecutiveAddFilteringSelectiveCriteriaRequest(this OcipClient client, UserExecutiveAddFilteringSelectiveCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a filtering criteria to an executive user.
        /// Both executive and the executive assistant can run this command.
        /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserExecutiveAddFilteringSelectiveCriteriaRequestAsync(this OcipClient client, UserExecutiveAddFilteringSelectiveCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a filtering criteria from an executive user.
        /// Both executive and the executive assistant can run this command.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserExecutiveDeleteFilteringSelectiveCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserExecutiveDeleteFilteringSelectiveCriteriaRequest(this OcipClient client, UserExecutiveDeleteFilteringSelectiveCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a filtering criteria from an executive user.
        /// Both executive and the executive assistant can run this command.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserExecutiveDeleteFilteringSelectiveCriteriaRequestAsync(this OcipClient client, UserExecutiveDeleteFilteringSelectiveCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the assistant setting and the list of assistants assigned to an executive.
        /// The response is either UserExecutiveGetAssistantResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserExecutiveGetAssistantRequestAsync instead.")]
        public static async Task<UserExecutiveGetAssistantResponse> UserExecutiveGetAssistantRequest(this OcipClient client, UserExecutiveGetAssistantRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserExecutiveGetAssistantResponse;
        }

        /// <summary>
        /// Get the assistant setting and the list of assistants assigned to an executive.
        /// The response is either UserExecutiveGetAssistantResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserExecutiveGetAssistantResponse> UserExecutiveGetAssistantRequestAsync(this OcipClient client, UserExecutiveGetAssistantRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserExecutiveGetAssistantResponse;
        }
        /// <summary>
        /// Get a list of users that can be assigned to an executive.
        /// Searching for users by group only makes sense when the executive user is part of an Enterprise.
        /// The response is either UserExecutiveGetAvailableAssistantListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserExecutiveGetAvailableAssistantListRequestAsync instead.")]
        public static async Task<UserExecutiveGetAvailableAssistantListResponse> UserExecutiveGetAvailableAssistantListRequest(this OcipClient client, UserExecutiveGetAvailableAssistantListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserExecutiveGetAvailableAssistantListResponse;
        }

        /// <summary>
        /// Get a list of users that can be assigned to an executive.
        /// Searching for users by group only makes sense when the executive user is part of an Enterprise.
        /// The response is either UserExecutiveGetAvailableAssistantListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserExecutiveGetAvailableAssistantListResponse> UserExecutiveGetAvailableAssistantListRequestAsync(this OcipClient client, UserExecutiveGetAvailableAssistantListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserExecutiveGetAvailableAssistantListResponse;
        }
        /// <summary>
        /// Get the filtering setting and the list of filtering criteria defined for an executive user.
        /// Both executive and the executive assistant can run this command.
        /// The response is either UserExecutiveGetFilteringResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserExecutiveGetFilteringRequestAsync instead.")]
        public static async Task<UserExecutiveGetFilteringResponse> UserExecutiveGetFilteringRequest(this OcipClient client, UserExecutiveGetFilteringRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserExecutiveGetFilteringResponse;
        }

        /// <summary>
        /// Get the filtering setting and the list of filtering criteria defined for an executive user.
        /// Both executive and the executive assistant can run this command.
        /// The response is either UserExecutiveGetFilteringResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserExecutiveGetFilteringResponse> UserExecutiveGetFilteringRequestAsync(this OcipClient client, UserExecutiveGetFilteringRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserExecutiveGetFilteringResponse;
        }
        /// <summary>
        /// Get a filtering criteria for an executive user.
        /// Both executive and the executive assistant can run this command.
        /// The response is either UserExecutiveGetFilteringSelectiveCriteriaResponse21 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserExecutiveGetFilteringSelectiveCriteriaRequest21Async instead.")]
        public static async Task<UserExecutiveGetFilteringSelectiveCriteriaResponse21> UserExecutiveGetFilteringSelectiveCriteriaRequest21(this OcipClient client, UserExecutiveGetFilteringSelectiveCriteriaRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserExecutiveGetFilteringSelectiveCriteriaResponse21;
        }

        /// <summary>
        /// Get a filtering criteria for an executive user.
        /// Both executive and the executive assistant can run this command.
        /// The response is either UserExecutiveGetFilteringSelectiveCriteriaResponse21 or ErrorResponse.
        /// </summary>
        public static async Task<UserExecutiveGetFilteringSelectiveCriteriaResponse21> UserExecutiveGetFilteringSelectiveCriteriaRequest21Async(this OcipClient client, UserExecutiveGetFilteringSelectiveCriteriaRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserExecutiveGetFilteringSelectiveCriteriaResponse21;
        }
        /// <summary>
        /// Get the screening and alerting setting of an executive. Both executive and the executive assistant can run this command.
        /// The response is either UserExecutiveGetScreeningAlertingResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserExecutiveGetScreeningAlertingRequestAsync instead.")]
        public static async Task<UserExecutiveGetScreeningAlertingResponse> UserExecutiveGetScreeningAlertingRequest(this OcipClient client, UserExecutiveGetScreeningAlertingRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserExecutiveGetScreeningAlertingResponse;
        }

        /// <summary>
        /// Get the screening and alerting setting of an executive. Both executive and the executive assistant can run this command.
        /// The response is either UserExecutiveGetScreeningAlertingResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserExecutiveGetScreeningAlertingResponse> UserExecutiveGetScreeningAlertingRequestAsync(this OcipClient client, UserExecutiveGetScreeningAlertingRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserExecutiveGetScreeningAlertingResponse;
        }
        /// <summary>
        /// Request to modify the assistant setting and the list of assistants assigned to an executive user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserExecutiveModifyAssistantRequestAsync instead.")]
        public static async Task<SuccessResponse> UserExecutiveModifyAssistantRequest(this OcipClient client, UserExecutiveModifyAssistantRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the assistant setting and the list of assistants assigned to an executive user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserExecutiveModifyAssistantRequestAsync(this OcipClient client, UserExecutiveModifyAssistantRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the filtering setting for an executive user.
        /// Both executive and the executive assistant can run this command.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserExecutiveModifyFilteringRequestAsync instead.")]
        public static async Task<SuccessResponse> UserExecutiveModifyFilteringRequest(this OcipClient client, UserExecutiveModifyFilteringRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the filtering setting for an executive user.
        /// Both executive and the executive assistant can run this command.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserExecutiveModifyFilteringRequestAsync(this OcipClient client, UserExecutiveModifyFilteringRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a filtering selective criteria for an executive.
        /// Both executive and the executive assistant can run this command.
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserExecutiveModifyFilteringSelectiveCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserExecutiveModifyFilteringSelectiveCriteriaRequest(this OcipClient client, UserExecutiveModifyFilteringSelectiveCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a filtering selective criteria for an executive.
        /// Both executive and the executive assistant can run this command.
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserExecutiveModifyFilteringSelectiveCriteriaRequestAsync(this OcipClient client, UserExecutiveModifyFilteringSelectiveCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the screening and alerting setting of an executive.
        /// Both executive and the executive assistant can run this command.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserExecutiveModifyScreeningAlertingRequestAsync instead.")]
        public static async Task<SuccessResponse> UserExecutiveModifyScreeningAlertingRequest(this OcipClient client, UserExecutiveModifyScreeningAlertingRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the screening and alerting setting of an executive.
        /// Both executive and the executive assistant can run this command.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserExecutiveModifyScreeningAlertingRequestAsync(this OcipClient client, UserExecutiveModifyScreeningAlertingRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
