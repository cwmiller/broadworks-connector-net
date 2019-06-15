using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system voice portal passcode rules setting.
    /// The response is either SystemVoiceMessagingGroupGetPasscodeRulesResponse14 or ErrorResponse.
    /// Replaced By: SystemPortalPasscodeRulesGetRequest
        /// <see cref="SystemVoiceMessagingGroupGetPasscodeRulesResponse14"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemPortalPasscodeRulesGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemVoiceMessagingGroupGetPasscodeRulesRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
