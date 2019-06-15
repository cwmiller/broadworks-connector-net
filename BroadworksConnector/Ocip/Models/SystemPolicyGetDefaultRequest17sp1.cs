using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system's default policy settings.
    /// The response is either SystemPolicyGetDefaultResponse17sp1 or ErrorResponse.
        /// <see cref="SystemPolicyGetDefaultResponse17sp1"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPolicyGetDefaultRequest17sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
