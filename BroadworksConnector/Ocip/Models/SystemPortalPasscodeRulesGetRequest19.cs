using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system passcode rules setting.
    /// The response is either SystemPortalPasscodeRulesGetResponse19 or ErrorResponse.
    /// <see cref="SystemPortalPasscodeRulesGetResponse19"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14592""}]")]
    public class SystemPortalPasscodeRulesGetRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemPortalPasscodeRulesGetResponse19>
    {

    }
}
