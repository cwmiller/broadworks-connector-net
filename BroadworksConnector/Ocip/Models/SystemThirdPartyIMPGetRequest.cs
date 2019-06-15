using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system Third-Party IMP service attributes.
    /// The response is either SystemThirdPartyIMPGetResponse or ErrorResponse.
    /// 
    /// Replaced by SystemThirdPartyIMPGetRequest19.
        /// <see cref="SystemThirdPartyIMPGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemThirdPartyIMPGetRequest19"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemThirdPartyIMPGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
