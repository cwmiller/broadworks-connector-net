using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceSecurityClassificationExtensions
    {

        /// <summary>
        /// Get a trunk group's Security Classifications configuration.
        /// The response is either GroupTrunkGroupSecurityClassificationGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupSecurityClassificationGetResponse> GroupTrunkGroupSecurityClassificationGetRequest(this OcipClient client, GroupTrunkGroupSecurityClassificationGetRequest request)
        {
            return await client.Call(request) as GroupTrunkGroupSecurityClassificationGetResponse;
        }

        /// <summary>
        /// Modify a trunk group's Security Classification configuration
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupSecurityClassificationModifyRequest(this OcipClient client, GroupTrunkGroupSecurityClassificationModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Security Classification
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSecurityClassificationAddClassificationRequest(this OcipClient client, SystemSecurityClassificationAddClassificationRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a System Security Classification
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSecurityClassificationDeleteClassificationRequest(this OcipClient client, SystemSecurityClassificationDeleteClassificationRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a system Security Classification.
        /// The response is either SystemSecurityClassificationGetClassificationResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSecurityClassificationGetClassificationResponse> SystemSecurityClassificationGetClassificationRequest(this OcipClient client, SystemSecurityClassificationGetClassificationRequest request)
        {
            return await client.Call(request) as SystemSecurityClassificationGetClassificationResponse;
        }

        /// <summary>
        /// Get a list of users that currently have the specified Security Classification assigned.
        /// The response is either SystemSecurityClassificationGetClassificationTrunkGroupUsageListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSecurityClassificationGetClassificationTrunkGroupUsageListResponse> SystemSecurityClassificationGetClassificationTrunkGroupUsageListRequest(this OcipClient client, SystemSecurityClassificationGetClassificationTrunkGroupUsageListRequest request)
        {
            return await client.Call(request) as SystemSecurityClassificationGetClassificationTrunkGroupUsageListResponse;
        }

        /// <summary>
        /// Get a list of users that currently have the specified Security Classification assigned.
        /// The response is either SystemSecurityClassificationGetClassificationUserUsageListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSecurityClassificationGetClassificationUserUsageListResponse> SystemSecurityClassificationGetClassificationUserUsageListRequest(this OcipClient client, SystemSecurityClassificationGetClassificationUserUsageListRequest request)
        {
            return await client.Call(request) as SystemSecurityClassificationGetClassificationUserUsageListResponse;
        }

        /// <summary>
        /// Get system Security Classifications parameters.
        /// The response is either SystemSecurityClassificationGetResponse21 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSecurityClassificationGetResponse21> SystemSecurityClassificationGetRequest21(this OcipClient client, SystemSecurityClassificationGetRequest21 request)
        {
            return await client.Call(request) as SystemSecurityClassificationGetResponse21;
        }

        /// <summary>
        /// Modify a Security Classification
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSecurityClassificationModifyClassificationRequest(this OcipClient client, SystemSecurityClassificationModifyClassificationRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify security classification parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// NOTE: The security classifications must be specified in order of priority. The command fails if all the security classifications defined for the system are not provided.
        /// </summary>
        public static async Task<SuccessResponse> SystemSecurityClassificationModifyRequest(this OcipClient client, SystemSecurityClassificationModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a user's Security Classifications configuration.
        /// The response is either UserSecurityClassificationGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<UserSecurityClassificationGetResponse22> UserSecurityClassificationGetRequest22(this OcipClient client, UserSecurityClassificationGetRequest22 request)
        {
            return await client.Call(request) as UserSecurityClassificationGetResponse22;
        }

        /// <summary>
        /// Modify a user's Security Classification configuration
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSecurityClassificationModifyRequest(this OcipClient client, UserSecurityClassificationModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
