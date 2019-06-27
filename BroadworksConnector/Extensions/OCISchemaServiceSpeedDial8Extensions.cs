using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceSpeedDial8Extensions
    {

        /// <summary>
        /// Get the speed dial 8 settings for a user.
        /// The response is either a UserSpeedDial8GetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserSpeedDial8GetListResponse> UserSpeedDial8GetListRequest(this OcipClient client, UserSpeedDial8GetListRequest request)
        {
            return await client.Call(request) as UserSpeedDial8GetListResponse;
        }

        /// <summary>
        /// Modify the speed dial 8 settings for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<SuccessResponse> UserSpeedDial8ModifyListRequest(this OcipClient client, UserSpeedDial8ModifyListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
