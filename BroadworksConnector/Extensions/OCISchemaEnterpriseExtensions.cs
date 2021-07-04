using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaEnterpriseExtensions
    {

        /// <summary>
        /// Activates or Deactivates the BroadWorks Mobile Manager.
        /// The deactivationReason is required when isActive is set to false.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseBroadWorksMobileManagerActivationRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseBroadWorksMobileManagerActivationRequest(this OcipClient client, EnterpriseBroadWorksMobileManagerActivationRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Activates or Deactivates the BroadWorks Mobile Manager.
        /// The deactivationReason is required when isActive is set to false.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseBroadWorksMobileManagerActivationRequestAsync(this OcipClient client, EnterpriseBroadWorksMobileManagerActivationRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a home zone to the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseBroadWorksMobileManagerAddHomeZoneRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseBroadWorksMobileManagerAddHomeZoneRequest(this OcipClient client, EnterpriseBroadWorksMobileManagerAddHomeZoneRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a home zone to the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseBroadWorksMobileManagerAddHomeZoneRequestAsync(this OcipClient client, EnterpriseBroadWorksMobileManagerAddHomeZoneRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add the BroadWorks Mobile Manager.
        /// Only one BroadWorks Mobile Manager can be added per
        /// enterprise.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseBroadWorksMobileManagerAddRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseBroadWorksMobileManagerAddRequest(this OcipClient client, EnterpriseBroadWorksMobileManagerAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add the BroadWorks Mobile Manager.
        /// Only one BroadWorks Mobile Manager can be added per
        /// enterprise.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseBroadWorksMobileManagerAddRequestAsync(this OcipClient client, EnterpriseBroadWorksMobileManagerAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of home zones from the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseBroadWorksMobileManagerDeleteHomeZoneListRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseBroadWorksMobileManagerDeleteHomeZoneListRequest(this OcipClient client, EnterpriseBroadWorksMobileManagerDeleteHomeZoneListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of home zones from the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseBroadWorksMobileManagerDeleteHomeZoneListRequestAsync(this OcipClient client, EnterpriseBroadWorksMobileManagerDeleteHomeZoneListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a home zone from the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseBroadWorksMobileManagerDeleteHomeZoneRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseBroadWorksMobileManagerDeleteHomeZoneRequest(this OcipClient client, EnterpriseBroadWorksMobileManagerDeleteHomeZoneRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a home zone from the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseBroadWorksMobileManagerDeleteHomeZoneRequestAsync(this OcipClient client, EnterpriseBroadWorksMobileManagerDeleteHomeZoneRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseBroadWorksMobileManagerDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseBroadWorksMobileManagerDeleteRequest(this OcipClient client, EnterpriseBroadWorksMobileManagerDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseBroadWorksMobileManagerDeleteRequestAsync(this OcipClient client, EnterpriseBroadWorksMobileManagerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of domains of the BroadWorks Mobile Manager.
        /// The response is either EnterpriseBroadWorksMobileManagerGetDomainListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseBroadWorksMobileManagerGetDomainListRequestAsync instead.")]
        public static async Task<EnterpriseBroadWorksMobileManagerGetDomainListResponse> EnterpriseBroadWorksMobileManagerGetDomainListRequest(this OcipClient client, EnterpriseBroadWorksMobileManagerGetDomainListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseBroadWorksMobileManagerGetDomainListResponse;
        }

        /// <summary>
        /// Get the list of domains of the BroadWorks Mobile Manager.
        /// The response is either EnterpriseBroadWorksMobileManagerGetDomainListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseBroadWorksMobileManagerGetDomainListResponse> EnterpriseBroadWorksMobileManagerGetDomainListRequestAsync(this OcipClient client, EnterpriseBroadWorksMobileManagerGetDomainListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseBroadWorksMobileManagerGetDomainListResponse;
        }
        /// <summary>
        /// Get the list of home zones of the BroadWorks Mobile Manager.
        /// The response is either EnterpriseBroadWorksMobileManagerGetHomeZoneListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseBroadWorksMobileManagerGetHomeZoneListRequestAsync instead.")]
        public static async Task<EnterpriseBroadWorksMobileManagerGetHomeZoneListResponse> EnterpriseBroadWorksMobileManagerGetHomeZoneListRequest(this OcipClient client, EnterpriseBroadWorksMobileManagerGetHomeZoneListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseBroadWorksMobileManagerGetHomeZoneListResponse;
        }

        /// <summary>
        /// Get the list of home zones of the BroadWorks Mobile Manager.
        /// The response is either EnterpriseBroadWorksMobileManagerGetHomeZoneListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseBroadWorksMobileManagerGetHomeZoneListResponse> EnterpriseBroadWorksMobileManagerGetHomeZoneListRequestAsync(this OcipClient client, EnterpriseBroadWorksMobileManagerGetHomeZoneListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseBroadWorksMobileManagerGetHomeZoneListResponse;
        }
        /// <summary>
        /// Get a home zone from the BroadWorks Mobile Manager.
        /// The response is either EnterpriseBroadWorksMobileManagerGetHomeZoneResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseBroadWorksMobileManagerGetHomeZoneRequestAsync instead.")]
        public static async Task<EnterpriseBroadWorksMobileManagerGetHomeZoneResponse> EnterpriseBroadWorksMobileManagerGetHomeZoneRequest(this OcipClient client, EnterpriseBroadWorksMobileManagerGetHomeZoneRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseBroadWorksMobileManagerGetHomeZoneResponse;
        }

        /// <summary>
        /// Get a home zone from the BroadWorks Mobile Manager.
        /// The response is either EnterpriseBroadWorksMobileManagerGetHomeZoneResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseBroadWorksMobileManagerGetHomeZoneResponse> EnterpriseBroadWorksMobileManagerGetHomeZoneRequestAsync(this OcipClient client, EnterpriseBroadWorksMobileManagerGetHomeZoneRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseBroadWorksMobileManagerGetHomeZoneResponse;
        }
        /// <summary>
        /// Get the BroadWorks Mobile Manager.
        /// The response is either EnterpriseBroadWorksMobileManagerGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseBroadWorksMobileManagerGetRequestAsync instead.")]
        public static async Task<EnterpriseBroadWorksMobileManagerGetResponse> EnterpriseBroadWorksMobileManagerGetRequest(this OcipClient client, EnterpriseBroadWorksMobileManagerGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseBroadWorksMobileManagerGetResponse;
        }

        /// <summary>
        /// Get the BroadWorks Mobile Manager.
        /// The response is either EnterpriseBroadWorksMobileManagerGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseBroadWorksMobileManagerGetResponse> EnterpriseBroadWorksMobileManagerGetRequestAsync(this OcipClient client, EnterpriseBroadWorksMobileManagerGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseBroadWorksMobileManagerGetResponse;
        }
        /// <summary>
        /// Modify an existing home zone in the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseBroadWorksMobileManagerModifyHomeZoneRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseBroadWorksMobileManagerModifyHomeZoneRequest(this OcipClient client, EnterpriseBroadWorksMobileManagerModifyHomeZoneRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing home zone in the BroadWorks Mobile Manager.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseBroadWorksMobileManagerModifyHomeZoneRequestAsync(this OcipClient client, EnterpriseBroadWorksMobileManagerModifyHomeZoneRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the BroadWorks Mobile Manager settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseBroadWorksMobileManagerModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseBroadWorksMobileManagerModifyRequest(this OcipClient client, EnterpriseBroadWorksMobileManagerModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the BroadWorks Mobile Manager settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseBroadWorksMobileManagerModifyRequestAsync(this OcipClient client, EnterpriseBroadWorksMobileManagerModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Sends an email with the carrier information and certificate files.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseBroadWorksMobileManagerSendCarrierFilesRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseBroadWorksMobileManagerSendCarrierFilesRequest(this OcipClient client, EnterpriseBroadWorksMobileManagerSendCarrierFilesRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Sends an email with the carrier information and certificate files.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseBroadWorksMobileManagerSendCarrierFilesRequestAsync(this OcipClient client, EnterpriseBroadWorksMobileManagerSendCarrierFilesRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add one or more entries to an enterprise's common phone list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCommonPhoneListAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCommonPhoneListAddListRequest(this OcipClient client, EnterpriseCommonPhoneListAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add one or more entries to an enterprise's common phone list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCommonPhoneListAddListRequestAsync(this OcipClient client, EnterpriseCommonPhoneListAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete one or more entries from an enterprise's common phone list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCommonPhoneListDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCommonPhoneListDeleteListRequest(this OcipClient client, EnterpriseCommonPhoneListDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete one or more entries from an enterprise's common phone list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCommonPhoneListDeleteListRequestAsync(this OcipClient client, EnterpriseCommonPhoneListDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get an enterprise's common phone list.
        /// The response is either a EnterpriseCommonPhoneListGetListResponse or an ErrorResponse.
        /// The search can be done using multiple criterion.
        /// If the searchCriteriaModeOr is present, any result matching any one criteria is included in the results.
        /// Otherwise, only results matching all the search criterion are included in the results.
        /// If no search criteria is specified, all results are returned.
        /// Specifying searchCriteriaModeOr without any search criteria results in an ErrorResponse.
        /// In all cases, if a responseSizeLimit is specified and the number of matching results is more than this limit, then an
        /// ErrorResponse is returned.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCommonPhoneListGetListRequestAsync instead.")]
        public static async Task<EnterpriseCommonPhoneListGetListResponse> EnterpriseCommonPhoneListGetListRequest(this OcipClient client, EnterpriseCommonPhoneListGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCommonPhoneListGetListResponse;
        }

        /// <summary>
        /// Get an enterprise's common phone list.
        /// The response is either a EnterpriseCommonPhoneListGetListResponse or an ErrorResponse.
        /// The search can be done using multiple criterion.
        /// If the searchCriteriaModeOr is present, any result matching any one criteria is included in the results.
        /// Otherwise, only results matching all the search criterion are included in the results.
        /// If no search criteria is specified, all results are returned.
        /// Specifying searchCriteriaModeOr without any search criteria results in an ErrorResponse.
        /// In all cases, if a responseSizeLimit is specified and the number of matching results is more than this limit, then an
        /// ErrorResponse is returned.
        /// </summary>
        public static async Task<EnterpriseCommonPhoneListGetListResponse> EnterpriseCommonPhoneListGetListRequestAsync(this OcipClient client, EnterpriseCommonPhoneListGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCommonPhoneListGetListResponse;
        }
        /// <summary>
        /// Modify an entry in an enterprise's common phone list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCommonPhoneListModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCommonPhoneListModifyRequest(this OcipClient client, EnterpriseCommonPhoneListModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an entry in an enterprise's common phone list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCommonPhoneListModifyRequestAsync(this OcipClient client, EnterpriseCommonPhoneListModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a list of Communication Barring Authorization codes to an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCommunicationBarringAuthorizationCodeAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCommunicationBarringAuthorizationCodeAddListRequest(this OcipClient client, EnterpriseCommunicationBarringAuthorizationCodeAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of Communication Barring Authorization codes to an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCommunicationBarringAuthorizationCodeAddListRequestAsync(this OcipClient client, EnterpriseCommunicationBarringAuthorizationCodeAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of Communication Barring Authorization Codes from an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCommunicationBarringAuthorizationCodeDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCommunicationBarringAuthorizationCodeDeleteListRequest(this OcipClient client, EnterpriseCommunicationBarringAuthorizationCodeDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of Communication Barring Authorization Codes from an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCommunicationBarringAuthorizationCodeDeleteListRequestAsync(this OcipClient client, EnterpriseCommunicationBarringAuthorizationCodeDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Communication Barring Authorization Codes in an enterprise.
        /// The response is either EnterpriseCommunicationBarringAuthorizationCodeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCommunicationBarringAuthorizationCodeGetListRequestAsync instead.")]
        public static async Task<EnterpriseCommunicationBarringAuthorizationCodeGetListResponse> EnterpriseCommunicationBarringAuthorizationCodeGetListRequest(this OcipClient client, EnterpriseCommunicationBarringAuthorizationCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCommunicationBarringAuthorizationCodeGetListResponse;
        }

        /// <summary>
        /// Get a list of Communication Barring Authorization Codes in an enterprise.
        /// The response is either EnterpriseCommunicationBarringAuthorizationCodeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCommunicationBarringAuthorizationCodeGetListResponse> EnterpriseCommunicationBarringAuthorizationCodeGetListRequestAsync(this OcipClient client, EnterpriseCommunicationBarringAuthorizationCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCommunicationBarringAuthorizationCodeGetListResponse;
        }
        /// <summary>
        /// Request the enterprise Communication Barring Authorization code settings.
        /// The response is either a EnterpriseCommunicationBarringAuthorizationCodeGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCommunicationBarringAuthorizationCodeGetRequestAsync instead.")]
        public static async Task<EnterpriseCommunicationBarringAuthorizationCodeGetResponse> EnterpriseCommunicationBarringAuthorizationCodeGetRequest(this OcipClient client, EnterpriseCommunicationBarringAuthorizationCodeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCommunicationBarringAuthorizationCodeGetResponse;
        }

        /// <summary>
        /// Request the enterprise Communication Barring Authorization code settings.
        /// The response is either a EnterpriseCommunicationBarringAuthorizationCodeGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCommunicationBarringAuthorizationCodeGetResponse> EnterpriseCommunicationBarringAuthorizationCodeGetRequestAsync(this OcipClient client, EnterpriseCommunicationBarringAuthorizationCodeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCommunicationBarringAuthorizationCodeGetResponse;
        }
        /// <summary>
        /// Modify the enterprise Communication Barring Authorization code settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCommunicationBarringAuthorizationCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCommunicationBarringAuthorizationCodeModifyRequest(this OcipClient client, EnterpriseCommunicationBarringAuthorizationCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the enterprise Communication Barring Authorization code settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCommunicationBarringAuthorizationCodeModifyRequestAsync(this OcipClient client, EnterpriseCommunicationBarringAuthorizationCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a department to enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseDepartmentAddRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseDepartmentAddRequest(this OcipClient client, EnterpriseDepartmentAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a department to enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseDepartmentAddRequestAsync(this OcipClient client, EnterpriseDepartmentAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a department from an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseDepartmentDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseDepartmentDeleteRequest(this OcipClient client, EnterpriseDepartmentDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a department from an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseDepartmentDeleteRequestAsync(this OcipClient client, EnterpriseDepartmentDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of enterprise level departments in an enterprise that could be the parent of the
        /// specified department. The department itself and all its decendents are not eligible to be
        /// the parent department.
        /// The response is either EnterpriseDepartmentGetAvailableParentListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseDepartmentGetAvailableParentListRequestAsync instead.")]
        public static async Task<EnterpriseDepartmentGetAvailableParentListResponse> EnterpriseDepartmentGetAvailableParentListRequest(this OcipClient client, EnterpriseDepartmentGetAvailableParentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseDepartmentGetAvailableParentListResponse;
        }

        /// <summary>
        /// Get a list of enterprise level departments in an enterprise that could be the parent of the
        /// specified department. The department itself and all its decendents are not eligible to be
        /// the parent department.
        /// The response is either EnterpriseDepartmentGetAvailableParentListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseDepartmentGetAvailableParentListResponse> EnterpriseDepartmentGetAvailableParentListRequestAsync(this OcipClient client, EnterpriseDepartmentGetAvailableParentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseDepartmentGetAvailableParentListResponse;
        }
        /// <summary>
        /// Request a list of departments in an enterprise. You may request only the
        /// list of departments defined at the enterprise-level, or you may request
        /// the list of all departments in the enterprise including all the departments
        /// defined within the groups inside the enterprise.
        /// The response is either EnterpriseDepartmentGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseDepartmentGetListRequestAsync instead.")]
        public static async Task<EnterpriseDepartmentGetListResponse> EnterpriseDepartmentGetListRequest(this OcipClient client, EnterpriseDepartmentGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseDepartmentGetListResponse;
        }

        /// <summary>
        /// Request a list of departments in an enterprise. You may request only the
        /// list of departments defined at the enterprise-level, or you may request
        /// the list of all departments in the enterprise including all the departments
        /// defined within the groups inside the enterprise.
        /// The response is either EnterpriseDepartmentGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseDepartmentGetListResponse> EnterpriseDepartmentGetListRequestAsync(this OcipClient client, EnterpriseDepartmentGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseDepartmentGetListResponse;
        }
        /// <summary>
        /// Modify a department of an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseDepartmentModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseDepartmentModifyRequest(this OcipClient client, EnterpriseDepartmentModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a department of an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseDepartmentModifyRequestAsync(this OcipClient client, EnterpriseDepartmentModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a table containing the phone directory for an enterprise.
        /// The directory includes all users in the enterprise and all entries in the enterprise common phone list.
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
        /// The response is either EnterprisePhoneDirectoryGetPagedSortedListResponse or ErrorResponse.
        /// 
        /// ErrorResponse is returned if searchCriteriaExactUserGroup or searchCriteriaExactUserDepartment have multiple entries and searchCriteriaModeOr is not included
        /// 
        /// The following elements are only used in AS data mode and ignored in Amplify and XS data mode:
        /// "sortByImpId"
        /// "searchCriteriaImpId"
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterprisePhoneDirectoryGetPagedSortedListRequestAsync instead.")]
        public static async Task<EnterprisePhoneDirectoryGetPagedSortedListResponse> EnterprisePhoneDirectoryGetPagedSortedListRequest(this OcipClient client, EnterprisePhoneDirectoryGetPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterprisePhoneDirectoryGetPagedSortedListResponse;
        }

        /// <summary>
        /// Request a table containing the phone directory for an enterprise.
        /// The directory includes all users in the enterprise and all entries in the enterprise common phone list.
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
        /// The response is either EnterprisePhoneDirectoryGetPagedSortedListResponse or ErrorResponse.
        /// 
        /// ErrorResponse is returned if searchCriteriaExactUserGroup or searchCriteriaExactUserDepartment have multiple entries and searchCriteriaModeOr is not included
        /// 
        /// The following elements are only used in AS data mode and ignored in Amplify and XS data mode:
        /// "sortByImpId"
        /// "searchCriteriaImpId"
        /// </summary>
        public static async Task<EnterprisePhoneDirectoryGetPagedSortedListResponse> EnterprisePhoneDirectoryGetPagedSortedListRequestAsync(this OcipClient client, EnterprisePhoneDirectoryGetPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterprisePhoneDirectoryGetPagedSortedListResponse;
        }
        /// <summary>
        /// Get the enterprise security classification list. If it is not customized, it returns the system default list.
        /// The response is either an EnterpriseSecurityClassificationCustomizationGetAvailableListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseSecurityClassificationCustomizationGetAvailableListRequestAsync instead.")]
        public static async Task<EnterpriseSecurityClassificationCustomizationGetAvailableListResponse> EnterpriseSecurityClassificationCustomizationGetAvailableListRequest(this OcipClient client, EnterpriseSecurityClassificationCustomizationGetAvailableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseSecurityClassificationCustomizationGetAvailableListResponse;
        }

        /// <summary>
        /// Get the enterprise security classification list. If it is not customized, it returns the system default list.
        /// The response is either an EnterpriseSecurityClassificationCustomizationGetAvailableListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseSecurityClassificationCustomizationGetAvailableListResponse> EnterpriseSecurityClassificationCustomizationGetAvailableListRequestAsync(this OcipClient client, EnterpriseSecurityClassificationCustomizationGetAvailableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseSecurityClassificationCustomizationGetAvailableListResponse;
        }
        /// <summary>
        /// Request to get the list of devices can be assigned to session admission control group for the enterprise.
        /// The response is either an EnterpriseSessionAdmissionControlGetAvailableDeviceListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseSessionAdmissionControlGetAvailableDeviceListRequestAsync instead.")]
        public static async Task<EnterpriseSessionAdmissionControlGetAvailableDeviceListResponse> EnterpriseSessionAdmissionControlGetAvailableDeviceListRequest(this OcipClient client, EnterpriseSessionAdmissionControlGetAvailableDeviceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseSessionAdmissionControlGetAvailableDeviceListResponse;
        }

        /// <summary>
        /// Request to get the list of devices can be assigned to session admission control group for the enterprise.
        /// The response is either an EnterpriseSessionAdmissionControlGetAvailableDeviceListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseSessionAdmissionControlGetAvailableDeviceListResponse> EnterpriseSessionAdmissionControlGetAvailableDeviceListRequestAsync(this OcipClient client, EnterpriseSessionAdmissionControlGetAvailableDeviceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseSessionAdmissionControlGetAvailableDeviceListResponse;
        }
        /// <summary>
        /// Request to add one or more devices to an enterprise level session admission control group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseSessionAdmissionControlGroupAddDeviceListRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseSessionAdmissionControlGroupAddDeviceListRequest(this OcipClient client, EnterpriseSessionAdmissionControlGroupAddDeviceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add one or more devices to an enterprise level session admission control group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseSessionAdmissionControlGroupAddDeviceListRequestAsync(this OcipClient client, EnterpriseSessionAdmissionControlGroupAddDeviceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a session admission control group for the enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Note that to provision the accessInfoPattern element, the
        /// captureAccessInfoInPaniHeader system parameter needs to be set to "true".
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseSessionAdmissionControlGroupAddRequest19sp1Async instead.")]
        public static async Task<SuccessResponse> EnterpriseSessionAdmissionControlGroupAddRequest19sp1(this OcipClient client, EnterpriseSessionAdmissionControlGroupAddRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a session admission control group for the enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Note that to provision the accessInfoPattern element, the
        /// captureAccessInfoInPaniHeader system parameter needs to be set to "true".
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseSessionAdmissionControlGroupAddRequest19sp1Async(this OcipClient client, EnterpriseSessionAdmissionControlGroupAddRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete one or more devices from an enterprise level session admission control group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseSessionAdmissionControlGroupDeleteDeviceListRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseSessionAdmissionControlGroupDeleteDeviceListRequest(this OcipClient client, EnterpriseSessionAdmissionControlGroupDeleteDeviceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete one or more devices from an enterprise level session admission control group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseSessionAdmissionControlGroupDeleteDeviceListRequestAsync(this OcipClient client, EnterpriseSessionAdmissionControlGroupDeleteDeviceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete one or more session admission control groups for the enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseSessionAdmissionControlGroupDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseSessionAdmissionControlGroupDeleteListRequest(this OcipClient client, EnterpriseSessionAdmissionControlGroupDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete one or more session admission control groups for the enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseSessionAdmissionControlGroupDeleteListRequestAsync(this OcipClient client, EnterpriseSessionAdmissionControlGroupDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of session admission control group for the enterprise.
        /// The response is either an EnterpriseSessionAdmissionControlGroupGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseSessionAdmissionControlGroupGetListRequestAsync instead.")]
        public static async Task<EnterpriseSessionAdmissionControlGroupGetListResponse> EnterpriseSessionAdmissionControlGroupGetListRequest(this OcipClient client, EnterpriseSessionAdmissionControlGroupGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseSessionAdmissionControlGroupGetListResponse;
        }

        /// <summary>
        /// Request to get the list of session admission control group for the enterprise.
        /// The response is either an EnterpriseSessionAdmissionControlGroupGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseSessionAdmissionControlGroupGetListResponse> EnterpriseSessionAdmissionControlGroupGetListRequestAsync(this OcipClient client, EnterpriseSessionAdmissionControlGroupGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseSessionAdmissionControlGroupGetListResponse;
        }
        /// <summary>
        /// Request to get a session admission control group for the enterprise.
        /// The response is either an EnterpriseSessionAdmissionControlGroupGetResponse21sp1V2 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseSessionAdmissionControlGroupGetRequest21sp1V2Async instead.")]
        public static async Task<EnterpriseSessionAdmissionControlGroupGetResponse21sp1V2> EnterpriseSessionAdmissionControlGroupGetRequest21sp1V2(this OcipClient client, EnterpriseSessionAdmissionControlGroupGetRequest21sp1V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseSessionAdmissionControlGroupGetResponse21sp1V2;
        }

        /// <summary>
        /// Request to get a session admission control group for the enterprise.
        /// The response is either an EnterpriseSessionAdmissionControlGroupGetResponse21sp1V2 or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseSessionAdmissionControlGroupGetResponse21sp1V2> EnterpriseSessionAdmissionControlGroupGetRequest21sp1V2Async(this OcipClient client, EnterpriseSessionAdmissionControlGroupGetRequest21sp1V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseSessionAdmissionControlGroupGetResponse21sp1V2;
        }
        /// <summary>
        /// Request to modify a session admission control group for the enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Note that to provision the accessInfoPattern element, the
        /// captureAccessInfoInPaniHeader system parameter needs to be set to "true".
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseSessionAdmissionControlGroupModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseSessionAdmissionControlGroupModifyRequest(this OcipClient client, EnterpriseSessionAdmissionControlGroupModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a session admission control group for the enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Note that to provision the accessInfoPattern element, the
        /// captureAccessInfoInPaniHeader system parameter needs to be set to "true".
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseSessionAdmissionControlGroupModifyRequestAsync(this OcipClient client, EnterpriseSessionAdmissionControlGroupModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of users and the service settings for a Call Forwarding service.
        /// The response is either EnterpriseUserCallForwardingSettingsGetListResponse or ErrorResponse.
        /// By default, virtual users and non-virtual users that match the selected search criteria are included in the response when "includeVirtualUsers" is present; otherwise, if "includeVirtualUsers" is absent, then only non-virtual users are returned.
        /// The search can be performed using multiple criteria. If search criteria is specified, only the users matching all of the specified search criteria are included in the response. If no search criteria is specified, all results are returned.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseUserCallForwardingSettingsGetListRequestAsync instead.")]
        public static async Task<EnterpriseUserCallForwardingSettingsGetListResponse> EnterpriseUserCallForwardingSettingsGetListRequest(this OcipClient client, EnterpriseUserCallForwardingSettingsGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseUserCallForwardingSettingsGetListResponse;
        }

        /// <summary>
        /// Get a list of users and the service settings for a Call Forwarding service.
        /// The response is either EnterpriseUserCallForwardingSettingsGetListResponse or ErrorResponse.
        /// By default, virtual users and non-virtual users that match the selected search criteria are included in the response when "includeVirtualUsers" is present; otherwise, if "includeVirtualUsers" is absent, then only non-virtual users are returned.
        /// The search can be performed using multiple criteria. If search criteria is specified, only the users matching all of the specified search criteria are included in the response. If no search criteria is specified, all results are returned.
        /// </summary>
        public static async Task<EnterpriseUserCallForwardingSettingsGetListResponse> EnterpriseUserCallForwardingSettingsGetListRequestAsync(this OcipClient client, EnterpriseUserCallForwardingSettingsGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseUserCallForwardingSettingsGetListResponse;
        }
        /// <summary>
        /// Get a list of users and the default or custom calling plan setting.
        /// The response is either EnterpriseUserCallingPlanSettingsGetListResponse or ErrorResponse.
        /// By default, virtual users and non-virtual users that match the selected search criteria are included in the response when "includeVirtualUsers" is present; otherwise, if "includeVirtualUsers" is absent, then only non-virtual users are returned.
        /// The search can be performed using multiple criteria. If search criteria is specified, only the users matching all of the specified search criteria are included in the response. If no search criteria is specified, all results are returned.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseUserCallingPlanSettingsGetListRequestAsync instead.")]
        public static async Task<EnterpriseUserCallingPlanSettingsGetListResponse> EnterpriseUserCallingPlanSettingsGetListRequest(this OcipClient client, EnterpriseUserCallingPlanSettingsGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseUserCallingPlanSettingsGetListResponse;
        }

        /// <summary>
        /// Get a list of users and the default or custom calling plan setting.
        /// The response is either EnterpriseUserCallingPlanSettingsGetListResponse or ErrorResponse.
        /// By default, virtual users and non-virtual users that match the selected search criteria are included in the response when "includeVirtualUsers" is present; otherwise, if "includeVirtualUsers" is absent, then only non-virtual users are returned.
        /// The search can be performed using multiple criteria. If search criteria is specified, only the users matching all of the specified search criteria are included in the response. If no search criteria is specified, all results are returned.
        /// </summary>
        public static async Task<EnterpriseUserCallingPlanSettingsGetListResponse> EnterpriseUserCallingPlanSettingsGetListRequestAsync(this OcipClient client, EnterpriseUserCallingPlanSettingsGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseUserCallingPlanSettingsGetListResponse;
        }
        /// <summary>
        /// Get a list of users and the Call Waiting service status (active or not active).
        /// The response is either EnterpriseUserCallWaitingSettingsGetListResponse or ErrorResponse.
        /// By default, virtual users and non-virtual users that match the selected search criteria are included in the response when "includeVirtualUsers" is present; otherwise, if "includeVirtualUsers" is absent, then only non-virtual users are returned.
        /// The search can be performed using multiple criteria. If search criteria is specified, only the users matching all of the specified search criteria are included in the response. If no search criteria is specified, all results are returned.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseUserCallWaitingSettingsGetListRequestAsync instead.")]
        public static async Task<EnterpriseUserCallWaitingSettingsGetListResponse> EnterpriseUserCallWaitingSettingsGetListRequest(this OcipClient client, EnterpriseUserCallWaitingSettingsGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseUserCallWaitingSettingsGetListResponse;
        }

        /// <summary>
        /// Get a list of users and the Call Waiting service status (active or not active).
        /// The response is either EnterpriseUserCallWaitingSettingsGetListResponse or ErrorResponse.
        /// By default, virtual users and non-virtual users that match the selected search criteria are included in the response when "includeVirtualUsers" is present; otherwise, if "includeVirtualUsers" is absent, then only non-virtual users are returned.
        /// The search can be performed using multiple criteria. If search criteria is specified, only the users matching all of the specified search criteria are included in the response. If no search criteria is specified, all results are returned.
        /// </summary>
        public static async Task<EnterpriseUserCallWaitingSettingsGetListResponse> EnterpriseUserCallWaitingSettingsGetListRequestAsync(this OcipClient client, EnterpriseUserCallWaitingSettingsGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseUserCallWaitingSettingsGetListResponse;
        }
        /// <summary>
        /// Get a list of users and their Hoteling Guest service status (active or not active).
        /// The response is either EnterpriseUserHotelingGuestSettingsGetListResponse or ErrorResponse.
        /// By default, virtual users and non-virtual users that match the selected search criteria are included in the response when "includeVirtualUsers" is present; otherwise, if "includeVirtualUsers" is absent, then only non-virtual users are returned.
        /// The search can be performed using multiple criteria. If search criteria is specified, only the users matching all of the specified search criteria are included in the response. If no search criteria is specified, all results are returned.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseUserHotelingGuestSettingsGetListRequestAsync instead.")]
        public static async Task<EnterpriseUserHotelingGuestSettingsGetListResponse> EnterpriseUserHotelingGuestSettingsGetListRequest(this OcipClient client, EnterpriseUserHotelingGuestSettingsGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseUserHotelingGuestSettingsGetListResponse;
        }

        /// <summary>
        /// Get a list of users and their Hoteling Guest service status (active or not active).
        /// The response is either EnterpriseUserHotelingGuestSettingsGetListResponse or ErrorResponse.
        /// By default, virtual users and non-virtual users that match the selected search criteria are included in the response when "includeVirtualUsers" is present; otherwise, if "includeVirtualUsers" is absent, then only non-virtual users are returned.
        /// The search can be performed using multiple criteria. If search criteria is specified, only the users matching all of the specified search criteria are included in the response. If no search criteria is specified, all results are returned.
        /// </summary>
        public static async Task<EnterpriseUserHotelingGuestSettingsGetListResponse> EnterpriseUserHotelingGuestSettingsGetListRequestAsync(this OcipClient client, EnterpriseUserHotelingGuestSettingsGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseUserHotelingGuestSettingsGetListResponse;
        }
        /// <summary>
        /// Add the enterprise level data associated with a Voice VPN location code.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseVoiceVPNAddPolicyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseVoiceVPNAddPolicyRequest(this OcipClient client, EnterpriseVoiceVPNAddPolicyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add the enterprise level data associated with a Voice VPN location code.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseVoiceVPNAddPolicyRequestAsync(this OcipClient client, EnterpriseVoiceVPNAddPolicyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a enterprise voice VPN location.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseVoiceVPNDeletePolicyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseVoiceVPNDeletePolicyRequest(this OcipClient client, EnterpriseVoiceVPNDeletePolicyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a enterprise voice VPN location.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseVoiceVPNDeletePolicyRequestAsync(this OcipClient client, EnterpriseVoiceVPNDeletePolicyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the Voice VPN default settings for the enterprise.
        /// The response is EnterpriseVoiceVPNGetDefaultResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseVoiceVPNGetDefaultRequestAsync instead.")]
        public static async Task<EnterpriseVoiceVPNGetDefaultResponse> EnterpriseVoiceVPNGetDefaultRequest(this OcipClient client, EnterpriseVoiceVPNGetDefaultRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseVoiceVPNGetDefaultResponse;
        }

        /// <summary>
        /// Request the Voice VPN default settings for the enterprise.
        /// The response is EnterpriseVoiceVPNGetDefaultResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseVoiceVPNGetDefaultResponse> EnterpriseVoiceVPNGetDefaultRequestAsync(this OcipClient client, EnterpriseVoiceVPNGetDefaultRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseVoiceVPNGetDefaultResponse;
        }
        /// <summary>
        /// Request the list of Voice VPN locations.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a EnterpriseVoiceVPNGetPolicyListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseVoiceVPNGetPolicyListRequestAsync instead.")]
        public static async Task<EnterpriseVoiceVPNGetPolicyListResponse> EnterpriseVoiceVPNGetPolicyListRequest(this OcipClient client, EnterpriseVoiceVPNGetPolicyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseVoiceVPNGetPolicyListResponse;
        }

        /// <summary>
        /// Request the list of Voice VPN locations.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a EnterpriseVoiceVPNGetPolicyListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseVoiceVPNGetPolicyListResponse> EnterpriseVoiceVPNGetPolicyListRequestAsync(this OcipClient client, EnterpriseVoiceVPNGetPolicyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseVoiceVPNGetPolicyListResponse;
        }
        /// <summary>
        /// Request the enterprise level data associated with Voice VPN location code.
        /// The response is either a EnterpriseVoiceVPNGetPolicyResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseVoiceVPNGetPolicyRequestAsync instead.")]
        public static async Task<EnterpriseVoiceVPNGetPolicyResponse> EnterpriseVoiceVPNGetPolicyRequest(this OcipClient client, EnterpriseVoiceVPNGetPolicyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseVoiceVPNGetPolicyResponse;
        }

        /// <summary>
        /// Request the enterprise level data associated with Voice VPN location code.
        /// The response is either a EnterpriseVoiceVPNGetPolicyResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseVoiceVPNGetPolicyResponse> EnterpriseVoiceVPNGetPolicyRequestAsync(this OcipClient client, EnterpriseVoiceVPNGetPolicyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseVoiceVPNGetPolicyResponse;
        }
        /// <summary>
        /// Request the enterprise level data associated with Voice VPN.
        /// The response is either a EnterpriseVoiceVPNGetResponse14sp3 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseVoiceVPNGetRequest14sp3Async instead.")]
        public static async Task<EnterpriseVoiceVPNGetResponse14sp3> EnterpriseVoiceVPNGetRequest14sp3(this OcipClient client, EnterpriseVoiceVPNGetRequest14sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseVoiceVPNGetResponse14sp3;
        }

        /// <summary>
        /// Request the enterprise level data associated with Voice VPN.
        /// The response is either a EnterpriseVoiceVPNGetResponse14sp3 or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseVoiceVPNGetResponse14sp3> EnterpriseVoiceVPNGetRequest14sp3Async(this OcipClient client, EnterpriseVoiceVPNGetRequest14sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseVoiceVPNGetResponse14sp3;
        }
        /// <summary>
        /// Modify the enterprise level data associated with a Voice VPN location code.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseVoiceVPNModifyPolicyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseVoiceVPNModifyPolicyRequest(this OcipClient client, EnterpriseVoiceVPNModifyPolicyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the enterprise level data associated with a Voice VPN location code.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseVoiceVPNModifyPolicyRequestAsync(this OcipClient client, EnterpriseVoiceVPNModifyPolicyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the enterprise voice VPN level data associated with voice VPN.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseVoiceVPNModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseVoiceVPNModifyRequest(this OcipClient client, EnterpriseVoiceVPNModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the enterprise voice VPN level data associated with voice VPN.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseVoiceVPNModifyRequestAsync(this OcipClient client, EnterpriseVoiceVPNModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
