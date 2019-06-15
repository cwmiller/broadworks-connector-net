using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system Third-Party IMP service attributes.
    /// The response is either SystemThirdPartyIMPGetResponse19 or ErrorResponse.
        /// <see cref="SystemThirdPartyIMPGetResponse19"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemThirdPartyIMPGetRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
