using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:36032""}]")]
    public class SystemVoiceMessagingGroupGetPasscodeRulesRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
