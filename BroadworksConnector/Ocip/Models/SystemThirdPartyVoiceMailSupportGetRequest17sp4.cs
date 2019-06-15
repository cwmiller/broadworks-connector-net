using System;
using System.Xml.Serialization;
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
     
    public class SystemThirdPartyVoiceMailSupportGetRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
