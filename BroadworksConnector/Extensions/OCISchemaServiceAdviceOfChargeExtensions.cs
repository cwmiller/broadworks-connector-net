using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceAdviceOfChargeExtensions
    {

        /// <summary>
        /// Request to get the list of Advice of Charge group parameters.
        /// The response is either GroupAdviceOfChargeGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAdviceOfChargeGetRequestAsync instead.")]
        public static async Task<GroupAdviceOfChargeGetResponse> GroupAdviceOfChargeGetRequest(this OcipClient client, GroupAdviceOfChargeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAdviceOfChargeGetResponse;
        }

        /// <summary>
        /// Request to get the list of Advice of Charge group parameters.
        /// The response is either GroupAdviceOfChargeGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupAdviceOfChargeGetResponse> GroupAdviceOfChargeGetRequestAsync(this OcipClient client, GroupAdviceOfChargeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAdviceOfChargeGetResponse;
        }
        /// <summary>
        /// Modify the service provider level Advice Of Charge group settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAdviceOfChargeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAdviceOfChargeModifyRequest(this OcipClient client, GroupAdviceOfChargeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the service provider level Advice Of Charge group settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAdviceOfChargeModifyRequestAsync(this OcipClient client, GroupAdviceOfChargeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Advice of Charge service provider parameters.
        /// The response is either ServiceProviderAdviceOfChargeGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdviceOfChargeGetRequestAsync instead.")]
        public static async Task<ServiceProviderAdviceOfChargeGetResponse> ServiceProviderAdviceOfChargeGetRequest(this OcipClient client, ServiceProviderAdviceOfChargeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAdviceOfChargeGetResponse;
        }

        /// <summary>
        /// Request to get the list of Advice of Charge service provider parameters.
        /// The response is either ServiceProviderAdviceOfChargeGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAdviceOfChargeGetResponse> ServiceProviderAdviceOfChargeGetRequestAsync(this OcipClient client, ServiceProviderAdviceOfChargeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAdviceOfChargeGetResponse;
        }
        /// <summary>
        /// Modify the service provider level Advice Of Charge service provider settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdviceOfChargeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderAdviceOfChargeModifyRequest(this OcipClient client, ServiceProviderAdviceOfChargeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the service provider level Advice Of Charge service provider settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAdviceOfChargeModifyRequestAsync(this OcipClient client, ServiceProviderAdviceOfChargeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a cost information source. The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAdviceOfChargeCostInformationSourceAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAdviceOfChargeCostInformationSourceAddRequest(this OcipClient client, SystemAdviceOfChargeCostInformationSourceAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a cost information source. The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAdviceOfChargeCostInformationSourceAddRequestAsync(this OcipClient client, SystemAdviceOfChargeCostInformationSourceAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a cost information source.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAdviceOfChargeCostInformationSourceDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAdviceOfChargeCostInformationSourceDeleteRequest(this OcipClient client, SystemAdviceOfChargeCostInformationSourceDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a cost information source.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAdviceOfChargeCostInformationSourceDeleteRequestAsync(this OcipClient client, SystemAdviceOfChargeCostInformationSourceDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of cost information sources.
        /// The response is either SystemAdviceOfChargeCostInformationSourceGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAdviceOfChargeCostInformationSourceGetListRequestAsync instead.")]
        public static async Task<SystemAdviceOfChargeCostInformationSourceGetListResponse> SystemAdviceOfChargeCostInformationSourceGetListRequest(this OcipClient client, SystemAdviceOfChargeCostInformationSourceGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAdviceOfChargeCostInformationSourceGetListResponse;
        }

        /// <summary>
        /// Get a list of cost information sources.
        /// The response is either SystemAdviceOfChargeCostInformationSourceGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemAdviceOfChargeCostInformationSourceGetListResponse> SystemAdviceOfChargeCostInformationSourceGetListRequestAsync(this OcipClient client, SystemAdviceOfChargeCostInformationSourceGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAdviceOfChargeCostInformationSourceGetListResponse;
        }
        /// <summary>
        /// Modify a cost information source.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAdviceOfChargeCostInformationSourceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAdviceOfChargeCostInformationSourceModifyRequest(this OcipClient client, SystemAdviceOfChargeCostInformationSourceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a cost information source.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAdviceOfChargeCostInformationSourceModifyRequestAsync(this OcipClient client, SystemAdviceOfChargeCostInformationSourceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Advice of Charge system parameters.
        /// The response is either SystemAdviceOfChargeGetResponse19sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAdviceOfChargeGetRequest19sp1Async instead.")]
        public static async Task<SystemAdviceOfChargeGetResponse19sp1> SystemAdviceOfChargeGetRequest19sp1(this OcipClient client, SystemAdviceOfChargeGetRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAdviceOfChargeGetResponse19sp1;
        }

        /// <summary>
        /// Request to get the list of Advice of Charge system parameters.
        /// The response is either SystemAdviceOfChargeGetResponse19sp1 or ErrorResponse.
        /// </summary>
        public static async Task<SystemAdviceOfChargeGetResponse19sp1> SystemAdviceOfChargeGetRequest19sp1Async(this OcipClient client, SystemAdviceOfChargeGetRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAdviceOfChargeGetResponse19sp1;
        }
        /// <summary>
        /// Request to modify Advice of Charge system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAdviceOfChargeModifyRequest19sp1Async instead.")]
        public static async Task<SuccessResponse> SystemAdviceOfChargeModifyRequest19sp1(this OcipClient client, SystemAdviceOfChargeModifyRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Advice of Charge system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAdviceOfChargeModifyRequest19sp1Async(this OcipClient client, SystemAdviceOfChargeModifyRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Advice Of Charge.
        /// The response is either a UserAdviceOfChargeGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAdviceOfChargeGetRequestAsync instead.")]
        public static async Task<UserAdviceOfChargeGetResponse> UserAdviceOfChargeGetRequest(this OcipClient client, UserAdviceOfChargeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAdviceOfChargeGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Advice Of Charge.
        /// The response is either a UserAdviceOfChargeGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserAdviceOfChargeGetResponse> UserAdviceOfChargeGetRequestAsync(this OcipClient client, UserAdviceOfChargeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAdviceOfChargeGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Advice of Charge.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAdviceOfChargeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserAdviceOfChargeModifyRequest(this OcipClient client, UserAdviceOfChargeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Advice of Charge.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAdviceOfChargeModifyRequestAsync(this OcipClient client, UserAdviceOfChargeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
