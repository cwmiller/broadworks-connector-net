using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system's default policy settings.
    /// The response is either SystemPolicyGetDefaultResponse14 or ErrorResponse.
        /// <see cref="SystemPolicyGetDefaultResponse14"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPolicyGetDefaultRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
