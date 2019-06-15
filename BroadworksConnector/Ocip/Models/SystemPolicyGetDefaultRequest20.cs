using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system's default policy settings.
    /// The response is either SystemPolicyGetDefaultResponse20 or ErrorResponse.
    /// 
    /// Replaced by: SystemPolicyGetDefaultRequest22 in AS mode
        /// <see cref="SystemPolicyGetDefaultResponse20"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemPolicyGetDefaultRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPolicyGetDefaultRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
