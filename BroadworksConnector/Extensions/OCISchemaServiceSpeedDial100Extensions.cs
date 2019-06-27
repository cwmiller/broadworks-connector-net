using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceSpeedDial100Extensions
    {

        /// <summary>
        /// Get the speed dial 100 service settings for a group.
        /// The response is either a GroupSpeedDial100GetResponse17sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupSpeedDial100GetResponse17sp1> GroupSpeedDial100GetRequest17sp1(this OcipClient client, GroupSpeedDial100GetRequest17sp1 request)
        {
            return await client.Call(request) as GroupSpeedDial100GetResponse17sp1;
        }

        /// <summary>
        /// Modify the speed dial 100 prefix setting for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupSpeedDial100ModifyRequest(this OcipClient client, GroupSpeedDial100ModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the speed dial 100 system-wide default setting.
        /// The response is either a SystemSpeedDial100GetResponse17sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSpeedDial100GetResponse17sp1> SystemSpeedDial100GetRequest17sp1(this OcipClient client, SystemSpeedDial100GetRequest17sp1 request)
        {
            return await client.Call(request) as SystemSpeedDial100GetResponse17sp1;
        }

        /// <summary>
        /// Modify the speed dial 100 system-wide default prefix setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSpeedDial100ModifyRequest(this OcipClient client, SystemSpeedDial100ModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add one or more speed dial 100 settings for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSpeedDial100AddListRequest(this OcipClient client, UserSpeedDial100AddListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete one or more speed dial 100 settings for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSpeedDial100DeleteListRequest(this OcipClient client, UserSpeedDial100DeleteListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the speed dial 100 settings for a user.
        /// The response is either a UserSpeedDial100GetListResponse17sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<UserSpeedDial100GetListResponse17sp1> UserSpeedDial100GetListRequest17sp1(this OcipClient client, UserSpeedDial100GetListRequest17sp1 request)
        {
            return await client.Call(request) as UserSpeedDial100GetListResponse17sp1;
        }

        /// <summary>
        /// Get speed dial 100 settings for a speed code.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSpeedDial100GetRequest(this OcipClient client, UserSpeedDial100GetRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the speed dial 100 settings for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<SuccessResponse> UserSpeedDial100ModifyListRequest(this OcipClient client, UserSpeedDial100ModifyListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
