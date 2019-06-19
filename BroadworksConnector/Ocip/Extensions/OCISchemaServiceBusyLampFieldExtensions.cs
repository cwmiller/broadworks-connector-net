using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceBusyLampFieldExtensions
    {

        /// <summary>
        /// Request the system level data associated with the Busy Lamp
        /// Field service. The response is either a SystemBusyLampFieldGetResponse18 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemBusyLampFieldGetResponse18> SystemBusyLampFieldGetRequest18(this OcipClient client, SystemBusyLampFieldGetRequest18 request)
        {
            return await client.Call(request) as SystemBusyLampFieldGetResponse18;
        }

        /// <summary>
        /// Request the system level data associated with the Busy Lamp
        /// Field service. The response is either a SystemBusyLampFieldGetResponse23 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemBusyLampFieldGetResponse23> SystemBusyLampFieldGetRequest23(this OcipClient client, SystemBusyLampFieldGetRequest23 request)
        {
            return await client.Call(request) as SystemBusyLampFieldGetResponse23;
        }

        /// <summary>
        /// Modify the system level data associated with the Busy Lamp Field
        /// Service. The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// forceUseOfTCP
        /// 
        /// The following elements are only used in AS data mode and ignored in Amplify and XS data mode:
        /// enableRedundancy
        /// redundancyTaskDelayMilliseconds
        /// redundancyTaskIntervalMilliseconds
        /// maxNumberOfSubscriptionsPerRedundancyTaskInterval
        /// </summary>
        public static async Task<SuccessResponse> SystemBusyLampFieldModifyRequest(this OcipClient client, SystemBusyLampFieldModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of available users for the busy lamp field service.
        /// The response is either UserBusyLampFieldGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserBusyLampFieldGetAvailableUserListResponse> UserBusyLampFieldGetAvailableUserListRequest(this OcipClient client, UserBusyLampFieldGetAvailableUserListRequest request)
        {
            return await client.Call(request) as UserBusyLampFieldGetAvailableUserListResponse;
        }

        /// <summary>
        /// Request the settings for the busy lamp field service.
        /// The response is either a UserBusyLampFieldGetResponse16sp2 or an ErrorResponse.
        /// </summary>
        public static async Task<UserBusyLampFieldGetResponse16sp2> UserBusyLampFieldGetRequest16sp2(this OcipClient client, UserBusyLampFieldGetRequest16sp2 request)
        {
            return await client.Call(request) as UserBusyLampFieldGetResponse16sp2;
        }

        /// <summary>
        /// Modify the settings for the busy lamp field service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBusyLampFieldModifyRequest(this OcipClient client, UserBusyLampFieldModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
