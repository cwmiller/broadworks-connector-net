using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceVoiceXmlExtensions
    {

        /// <summary>
        /// Add a VoiceXML instance to a group.
        /// The domain is required in the serviceUserId.  For a valid voiceXml instance to work properly,
        /// a device with Static Registration is expected with a valid contact.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceXmlAddInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupVoiceXmlAddInstanceRequest(this OcipClient client, GroupVoiceXmlAddInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a VoiceXML instance to a group.
        /// The domain is required in the serviceUserId.  For a valid voiceXml instance to work properly,
        /// a device with Static Registration is expected with a valid contact.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupVoiceXmlAddInstanceRequestAsync(this OcipClient client, GroupVoiceXmlAddInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a VoiceXML instance from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceXmlDeleteInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupVoiceXmlDeleteInstanceRequest(this OcipClient client, GroupVoiceXmlDeleteInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a VoiceXML instance from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupVoiceXmlDeleteInstanceRequestAsync(this OcipClient client, GroupVoiceXmlDeleteInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of VoiceXML instances within a group.
        /// The response is either GroupVoiceXmlGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceXmlGetInstanceListRequestAsync instead.")]
        public static async Task<GroupVoiceXmlGetInstanceListResponse> GroupVoiceXmlGetInstanceListRequest(this OcipClient client, GroupVoiceXmlGetInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupVoiceXmlGetInstanceListResponse;
        }

        /// <summary>
        /// Get a list of VoiceXML instances within a group.
        /// The response is either GroupVoiceXmlGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        public static async Task<GroupVoiceXmlGetInstanceListResponse> GroupVoiceXmlGetInstanceListRequestAsync(this OcipClient client, GroupVoiceXmlGetInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupVoiceXmlGetInstanceListResponse;
        }
        /// <summary>
        /// Request to get all the information of a VoiceXML instance.
        /// The response is either GroupVoiceXmlGetInstanceResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceXmlGetInstanceRequest22Async instead.")]
        public static async Task<GroupVoiceXmlGetInstanceResponse22> GroupVoiceXmlGetInstanceRequest22(this OcipClient client, GroupVoiceXmlGetInstanceRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupVoiceXmlGetInstanceResponse22;
        }

        /// <summary>
        /// Request to get all the information of a VoiceXML instance.
        /// The response is either GroupVoiceXmlGetInstanceResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<GroupVoiceXmlGetInstanceResponse22> GroupVoiceXmlGetInstanceRequest22Async(this OcipClient client, GroupVoiceXmlGetInstanceRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupVoiceXmlGetInstanceResponse22;
        }
        /// <summary>
        /// Request to set the active status of VoiceXML instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceXmlModifyActiveInstanceListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupVoiceXmlModifyActiveInstanceListRequest(this OcipClient client, GroupVoiceXmlModifyActiveInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to set the active status of VoiceXML instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupVoiceXmlModifyActiveInstanceListRequestAsync(this OcipClient client, GroupVoiceXmlModifyActiveInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a VoiceXML instance. For a valid voiceXml instance to work properly,
        /// a device with Static Registration is expected with a valid contact.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceXmlModifyInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupVoiceXmlModifyInstanceRequest(this OcipClient client, GroupVoiceXmlModifyInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a VoiceXML instance. For a valid voiceXml instance to work properly,
        /// a device with Static Registration is expected with a valid contact.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupVoiceXmlModifyInstanceRequestAsync(this OcipClient client, GroupVoiceXmlModifyInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
