using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceSMDIMessageDeskExtensions
    {

        /// <summary>
        /// Request to add a SMDI Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIMessageDeskAddServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSMDIMessageDeskAddServerRequest(this OcipClient client, SystemSMDIMessageDeskAddServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a SMDI Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIMessageDeskAddServerRequestAsync(this OcipClient client, SystemSMDIMessageDeskAddServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a SMDI Server route to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIMessageDeskAddServerRouteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSMDIMessageDeskAddServerRouteRequest(this OcipClient client, SystemSMDIMessageDeskAddServerRouteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a SMDI Server route to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIMessageDeskAddServerRouteRequestAsync(this OcipClient client, SystemSMDIMessageDeskAddServerRouteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a SMDI Server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIMessageDeskDeleteServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSMDIMessageDeskDeleteServerRequest(this OcipClient client, SystemSMDIMessageDeskDeleteServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a SMDI Server from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIMessageDeskDeleteServerRequestAsync(this OcipClient client, SystemSMDIMessageDeskDeleteServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a SMDI Server route from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIMessageDeskDeleteServerRouteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSMDIMessageDeskDeleteServerRouteRequest(this OcipClient client, SystemSMDIMessageDeskDeleteServerRouteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a SMDI Server route from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIMessageDeskDeleteServerRouteRequestAsync(this OcipClient client, SystemSMDIMessageDeskDeleteServerRouteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of SMDI Servers defined in the system.
        /// The response is either a SystemSMDIMessageDeskGetServerListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIMessageDeskGetServerListRequestAsync instead.")]
        public static async Task<SystemSMDIMessageDeskGetServerListResponse> SystemSMDIMessageDeskGetServerListRequest(this OcipClient client, SystemSMDIMessageDeskGetServerListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSMDIMessageDeskGetServerListResponse;
        }

        /// <summary>
        /// Request to get a list of SMDI Servers defined in the system.
        /// The response is either a SystemSMDIMessageDeskGetServerListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSMDIMessageDeskGetServerListResponse> SystemSMDIMessageDeskGetServerListRequestAsync(this OcipClient client, SystemSMDIMessageDeskGetServerListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSMDIMessageDeskGetServerListResponse;
        }
        /// <summary>
        /// Request to get a list of SMDI Servers routes in the system.
        /// The response is either a SystemSMDIMessageDeskGetServerRouteListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIMessageDeskGetServerRouteListRequestAsync instead.")]
        public static async Task<SystemSMDIMessageDeskGetServerRouteListResponse> SystemSMDIMessageDeskGetServerRouteListRequest(this OcipClient client, SystemSMDIMessageDeskGetServerRouteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSMDIMessageDeskGetServerRouteListResponse;
        }

        /// <summary>
        /// Request to get a list of SMDI Servers routes in the system.
        /// The response is either a SystemSMDIMessageDeskGetServerRouteListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSMDIMessageDeskGetServerRouteListResponse> SystemSMDIMessageDeskGetServerRouteListRequestAsync(this OcipClient client, SystemSMDIMessageDeskGetServerRouteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSMDIMessageDeskGetServerRouteListResponse;
        }
        /// <summary>
        /// Request to modify a SMDI Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIMessageDeskModifyServerRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSMDIMessageDeskModifyServerRequest(this OcipClient client, SystemSMDIMessageDeskModifyServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a SMDI Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIMessageDeskModifyServerRequestAsync(this OcipClient client, SystemSMDIMessageDeskModifyServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Replace the list of devices associated with a SMDI server route destination.
        /// There must be at least one device in the list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMDIMessageDeskModifyServerRouteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemSMDIMessageDeskModifyServerRouteRequest(this OcipClient client, SystemSMDIMessageDeskModifyServerRouteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Replace the list of devices associated with a SMDI server route destination.
        /// There must be at least one device in the list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIMessageDeskModifyServerRouteRequestAsync(this OcipClient client, SystemSMDIMessageDeskModifyServerRouteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a SMDI Server for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSMDIMessageDeskAddServerRequestAsync instead.")]
        public static async Task<SuccessResponse> UserSMDIMessageDeskAddServerRequest(this OcipClient client, UserSMDIMessageDeskAddServerRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a SMDI Server for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSMDIMessageDeskAddServerRequestAsync(this OcipClient client, UserSMDIMessageDeskAddServerRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a list of SMDI Servers for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSMDIMessageDeskDeleteServerListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserSMDIMessageDeskDeleteServerListRequest(this OcipClient client, UserSMDIMessageDeskDeleteServerListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a list of SMDI Servers for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSMDIMessageDeskDeleteServerListRequestAsync(this OcipClient client, UserSMDIMessageDeskDeleteServerListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the user's SMDI Message Desk service personal setting.
        /// The response is either a UserSMDIMessageDeskGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSMDIMessageDeskGetRequestAsync instead.")]
        public static async Task<UserSMDIMessageDeskGetResponse> UserSMDIMessageDeskGetRequest(this OcipClient client, UserSMDIMessageDeskGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSMDIMessageDeskGetResponse;
        }

        /// <summary>
        /// Get the user's SMDI Message Desk service personal setting.
        /// The response is either a UserSMDIMessageDeskGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserSMDIMessageDeskGetResponse> UserSMDIMessageDeskGetRequestAsync(this OcipClient client, UserSMDIMessageDeskGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSMDIMessageDeskGetResponse;
        }
        /// <summary>
        /// Request to get a list of SMDI Servers defined for a user.
        /// The response is either a UserSMDIMessageDeskGetServerListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSMDIMessageDeskGetServerListRequestAsync instead.")]
        public static async Task<UserSMDIMessageDeskGetServerListResponse> UserSMDIMessageDeskGetServerListRequest(this OcipClient client, UserSMDIMessageDeskGetServerListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSMDIMessageDeskGetServerListResponse;
        }

        /// <summary>
        /// Request to get a list of SMDI Servers defined for a user.
        /// The response is either a UserSMDIMessageDeskGetServerListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserSMDIMessageDeskGetServerListResponse> UserSMDIMessageDeskGetServerListRequestAsync(this OcipClient client, UserSMDIMessageDeskGetServerListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSMDIMessageDeskGetServerListResponse;
        }
        /// <summary>
        /// Modify the user's SMDI Message Desk service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSMDIMessageDeskModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserSMDIMessageDeskModifyRequest(this OcipClient client, UserSMDIMessageDeskModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's SMDI Message Desk service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSMDIMessageDeskModifyRequestAsync(this OcipClient client, UserSMDIMessageDeskModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
