using System;
using System.Xml.Serialization;
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
     
    public class SystemThirdPartyVoiceMailSupportGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
