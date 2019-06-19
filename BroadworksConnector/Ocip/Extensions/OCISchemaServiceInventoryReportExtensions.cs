using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceInventoryReportExtensions
    {

        /// <summary>
        /// Request the group's inventory report.
        /// The response is either a GroupInventoryReportGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupInventoryReportGetResponse> GroupInventoryReportGetRequest(this OcipClient client, GroupInventoryReportGetRequest request)
        {
            return await client.Call(request) as GroupInventoryReportGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Inventory Report.
        /// The response is either a SystemInventoryReportGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemInventoryReportGetResponse> SystemInventoryReportGetRequest(this OcipClient client, SystemInventoryReportGetRequest request)
        {
            return await client.Call(request) as SystemInventoryReportGetResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Inventory Report.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemInventoryReportModifyRequest(this OcipClient client, SystemInventoryReportModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
