using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system's default policy settings.
    /// The response is either SystemPolicyGetDefaultResponse16sp2 or ErrorResponse.
        /// <see cref="SystemPolicyGetDefaultResponse16sp2"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPolicyGetDefaultRequest16sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
