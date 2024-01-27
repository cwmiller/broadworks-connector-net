using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Third-party Voice Mail Support.
    /// The response is either a SystemThirdPartyVoiceMailSupportGetResponse17sp4 or an
    /// ErrorResponse.
    /// <see cref="SystemThirdPartyVoiceMailSupportGetResponse17sp4"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""21e97b8199c6e7eff29a84874335b46e:174""}]")]
    public class SystemThirdPartyVoiceMailSupportGetRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemThirdPartyVoiceMailSupportGetResponse17sp4>
    {

    }
}
