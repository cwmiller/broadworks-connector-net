using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceSharedCallAppearanceExtensions
    {

        /// <summary>
        /// Associate an access device instance to the user's Shared Call Appearance.
        /// 
        /// The following elements are ignored in XS data mode:
        /// allowVideo, useValue true in AS data mode
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSharedCallAppearanceAddEndpointRequest22Async instead.")]
        public static async Task<SuccessResponse> UserSharedCallAppearanceAddEndpointRequest22(this OcipClient client, UserSharedCallAppearanceAddEndpointRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Associate an access device instance to the user's Shared Call Appearance.
        /// 
        /// The following elements are ignored in XS data mode:
        /// allowVideo, useValue true in AS data mode
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSharedCallAppearanceAddEndpointRequest22Async(this OcipClient client, UserSharedCallAppearanceAddEndpointRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Disassociate one or more of a user's Shared Call Appearance endpoints.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSharedCallAppearanceDeleteEndpointListRequest14Async instead.")]
        public static async Task<SuccessResponse> UserSharedCallAppearanceDeleteEndpointListRequest14(this OcipClient client, UserSharedCallAppearanceDeleteEndpointListRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Disassociate one or more of a user's Shared Call Appearance endpoints.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSharedCallAppearanceDeleteEndpointListRequest14Async(this OcipClient client, UserSharedCallAppearanceDeleteEndpointListRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the user's Shared Call Appearance endpoint setting.
        /// The response is either a UserSharedCallAppearanceGetEndpointResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSharedCallAppearanceGetEndpointRequest22Async instead.")]
        public static async Task<UserSharedCallAppearanceGetEndpointResponse22> UserSharedCallAppearanceGetEndpointRequest22(this OcipClient client, UserSharedCallAppearanceGetEndpointRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSharedCallAppearanceGetEndpointResponse22;
        }

        /// <summary>
        /// Get the user's Shared Call Appearance endpoint setting.
        /// The response is either a UserSharedCallAppearanceGetEndpointResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<UserSharedCallAppearanceGetEndpointResponse22> UserSharedCallAppearanceGetEndpointRequest22Async(this OcipClient client, UserSharedCallAppearanceGetEndpointRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSharedCallAppearanceGetEndpointResponse22;
        }
        /// <summary>
        /// Get the user's Shared Call Appearance service setting.
        /// The response is either a UserSharedCallAppearanceGetResponse21sp1 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSharedCallAppearanceGetRequest21sp1Async instead.")]
        public static async Task<UserSharedCallAppearanceGetResponse21sp1> UserSharedCallAppearanceGetRequest21sp1(this OcipClient client, UserSharedCallAppearanceGetRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSharedCallAppearanceGetResponse21sp1;
        }

        /// <summary>
        /// Get the user's Shared Call Appearance service setting.
        /// The response is either a UserSharedCallAppearanceGetResponse21sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<UserSharedCallAppearanceGetResponse21sp1> UserSharedCallAppearanceGetRequest21sp1Async(this OcipClient client, UserSharedCallAppearanceGetRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSharedCallAppearanceGetResponse21sp1;
        }
        /// <summary>
        /// Associate/Disassociate an access device instance to the user's Shared Call Appearance.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useHotline
        /// hotlineContact
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSharedCallAppearanceModifyEndpointRequestAsync instead.")]
        public static async Task<SuccessResponse> UserSharedCallAppearanceModifyEndpointRequest(this OcipClient client, UserSharedCallAppearanceModifyEndpointRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Associate/Disassociate an access device instance to the user's Shared Call Appearance.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useHotline
        /// hotlineContact
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSharedCallAppearanceModifyEndpointRequestAsync(this OcipClient client, UserSharedCallAppearanceModifyEndpointRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the user's Shared Call Appearance service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// useUserPrimaryWithAlternateCallsSetting
        /// allowSimultaneousPrimaryAndAlternate
        /// restrictCallRetrieveOfPrimary
        /// restrictCallBridgingOfPrimary
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSharedCallAppearanceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserSharedCallAppearanceModifyRequest(this OcipClient client, UserSharedCallAppearanceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's Shared Call Appearance service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// useUserPrimaryWithAlternateCallsSetting
        /// allowSimultaneousPrimaryAndAlternate
        /// restrictCallRetrieveOfPrimary
        /// restrictCallBridgingOfPrimary
        /// </summary>
        public static async Task<SuccessResponse> UserSharedCallAppearanceModifyRequestAsync(this OcipClient client, UserSharedCallAppearanceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
