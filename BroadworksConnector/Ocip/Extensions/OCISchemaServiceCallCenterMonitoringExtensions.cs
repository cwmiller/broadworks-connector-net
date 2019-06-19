using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceCallCenterMonitoringExtensions
    {

        /// <summary>
        /// Request the user's Call Center Monitoring settings.
        /// The response is either a UserCallCenterMonitoringGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallCenterMonitoringGetResponse> UserCallCenterMonitoringGetRequest(this OcipClient client, UserCallCenterMonitoringGetRequest request)
        {
            return await client.Call(request) as UserCallCenterMonitoringGetResponse;
        }

        /// <summary>
        /// Modify the user's Call Center Monitoring settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallCenterMonitoringModifyRequest(this OcipClient client, UserCallCenterMonitoringModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
