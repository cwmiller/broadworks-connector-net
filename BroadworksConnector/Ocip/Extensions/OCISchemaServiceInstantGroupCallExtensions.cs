using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceInstantGroupCallExtensions
    {

        /// <summary>
        /// Request to add an Instant Group Call service instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupInstantGroupCallAddInstanceRequest14(this OcipClient client, GroupInstantGroupCallAddInstanceRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete an Instant Group Call service instance from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupInstantGroupCallDeleteInstanceRequest(this OcipClient client, GroupInstantGroupCallDeleteInstanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a list of Instant Group Call service instances within a group.
        /// The response is either GroupInstantGroupCallGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the service instances within a specified department.
        /// </summary>
        public static async Task<GroupInstantGroupCallGetInstanceListResponse> GroupInstantGroupCallGetInstanceListRequest(this OcipClient client, GroupInstantGroupCallGetInstanceListRequest request)
        {
            return await client.Call(request) as GroupInstantGroupCallGetInstanceListResponse;
        }

        /// <summary>
        /// Request to get all the information of an Instant Group Call service instance.
        /// The response is either GroupInstantGroupCallGetInstanceResponse19sp1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupInstantGroupCallGetInstanceResponse19sp1> GroupInstantGroupCallGetInstanceRequest19sp1(this OcipClient client, GroupInstantGroupCallGetInstanceRequest19sp1 request)
        {
            return await client.Call(request) as GroupInstantGroupCallGetInstanceResponse19sp1;
        }

        /// <summary>
        /// Request to set the active status of Instant Group Call service instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupInstantGroupCallModifyActiveInstanceListRequest(this OcipClient client, GroupInstantGroupCallModifyActiveInstanceListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an Instant Group Call service instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupInstantGroupCallModifyInstanceRequest(this OcipClient client, GroupInstantGroupCallModifyInstanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
