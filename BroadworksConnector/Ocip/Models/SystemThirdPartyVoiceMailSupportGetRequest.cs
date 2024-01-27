using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Third-party Voice Mail Support.
    /// The response is either a SystemThirdPartyVoiceMailSupportGetResponse or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemThirdPartyVoiceMailSupportGetRequest17sp4
    /// <see cref="SystemThirdPartyVoiceMailSupportGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemThirdPartyVoiceMailSupportGetRequest17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:36245""}]")]
    public class SystemThirdPartyVoiceMailSupportGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemThirdPartyVoiceMailSupportGetResponse>
    {

    }
}
