using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaASDeprecatedSpecialExceptionsExtensions
    {

        /// <summary>
        /// This command is part of the Portal API.
        /// Sent when a Web or CLI user logs in using external authentication.
        /// The password must be hashed. The password hashing algorithm is:
        /// 1) The message digest of the user's plain password is calculated using the SHA algorithm.
        /// 2) For every four bits in the 160-bit digest, starting from the first bit, it is
        /// converted into a character in ASCII Hex format (0 through 9, a through f).
        /// The result is a 40-character string, for example, f7a9e24777ec23212c54d7a350bc5bea5477fdbb.
        /// 3) The above string then is used to populate the password field in the request.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ExternalAuthenticationAuthorizeTokenRequest(this OcipClient client, ExternalAuthenticationAuthorizeTokenRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call center's forced forwarding
        /// settings.
        /// The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterForcedForwardingModifyRequest17(this OcipClient client, GroupCallCenterForcedForwardingModifyRequest17 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a call center's night service settings.
        /// The response is either a GroupCallCenterNightServiceGetResponse17sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterNightServiceGetResponse17sp1> GroupCallCenterNightServiceGetRequest17sp1(this OcipClient client, GroupCallCenterNightServiceGetRequest17sp1 request)
        {
            return await client.Call(request) as GroupCallCenterNightServiceGetResponse17sp1;
        }

        /// <summary>
        /// Modify a call center's night service settings.
        /// Only Group and Enterprise level schedules are
        /// accepted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterNightServiceModifyRequest17sp1(this OcipClient client, GroupCallCenterNightServiceModifyRequest17sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the user's broadworks mobility service settings.
        /// The response is either a UserBroadWorksMobilityGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksMobilityGetResponse> UserBroadWorksMobilityGetRequest(this OcipClient client, UserBroadWorksMobilityGetRequest request)
        {
            return await client.Call(request) as UserBroadWorksMobilityGetResponse;
        }

        /// <summary>
        /// Modify the user's broadworks mobility service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// If the request modifies the mobilePhoneNumber and the new number does not belong to the appropriate Mobile Subscriber Directory Numbers pool, the request is rejected. For a service provider the number must belong to the group Mobile Subscriber Directory Numbers pool. For an enterprise user, the number must belong to the enterprise Mobile Subscriber Directory Numbers pool.
        /// If the request is executed by a user and modifies the mobilePhoneNumber, the request is rejected.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksMobilityModifyRequest20(this OcipClient client, UserBroadWorksMobilityModifyRequest20 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a criteria to the user's custom ringback
        /// service.
        /// The response is either a SuccessResponse or
        /// an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCustomRingbackUserAddCriteriaRequest16(this OcipClient client, UserCustomRingbackUserAddCriteriaRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a criteria for the user's custom ringback service.
        /// The response is either a UserCustomRingbackUserGetCriteriaResponse16 or an ErrorResponse.
        /// 
        /// Replaced by: UserCustomRingbackUserGetCriteriaRequest20 in AS data mode
        /// </summary>
        public static async Task<UserCustomRingbackUserGetCriteriaResponse16> UserCustomRingbackUserGetCriteriaRequest16(this OcipClient client, UserCustomRingbackUserGetCriteriaRequest16 request)
        {
            return await client.Call(request) as UserCustomRingbackUserGetCriteriaResponse16;
        }

        /// <summary>
        /// Modify the user's broadworks mobility service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksMobilityModifyRequest(this OcipClient client, UserBroadWorksMobilityModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify a criteria for the user's custom ringback
        /// service.
        /// The response is either a SuccessResponse
        /// or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCustomRingbackUserModifyCriteriaRequest16(this OcipClient client, UserCustomRingbackUserModifyCriteriaRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the user's voice messaging greeting information.
        /// The response is either a UserVoiceMessagingUserGetGreetingResponse18sp1 or an ErrorResponse.
        /// 
        /// Replaced by: UserVoiceMessagingUserGetGreetingRequest20 in AS data mode
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetGreetingResponse18sp1> UserVoiceMessagingUserGetGreetingRequest18sp1(this OcipClient client, UserVoiceMessagingUserGetGreetingRequest18sp1 request)
        {
            return await client.Call(request) as UserVoiceMessagingUserGetGreetingResponse18sp1;
        }

        /// <summary>
        /// Get the user's voice messaging voice portal settings.
        /// The response is either a UserVoiceMessagingUserGetVoicePortalResponse16 or an ErrorResponse.
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetVoicePortalResponse16> UserVoiceMessagingUserGetVoicePortalRequest16(this OcipClient client, UserVoiceMessagingUserGetVoicePortalRequest16 request)
        {
            return await client.Call(request) as UserVoiceMessagingUserGetVoicePortalResponse16;
        }

        /// <summary>
        /// Modify the user's voice messaging greeting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// disableMessageDeposit
        /// disableMessageDepositAction
        /// greetingOnlyForwardDestination
        /// 
        /// Replaced by UserVoiceMessagingUserModifyGreetingRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyGreetingRequest16(this OcipClient client, UserVoiceMessagingUserModifyGreetingRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging voice portal settings.
        /// The response is either a SuccessResponse
        /// or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyVoicePortalRequest16(this OcipClient client, UserVoiceMessagingUserModifyVoicePortalRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
