using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system's default policy settings.
    /// The response is either SystemPolicyGetDefaultResponse19sp1 or ErrorResponse.
    /// 
    /// Replaced by: SystemPolicyGetDefaultRequest20 in AS mode
        /// <see cref="SystemPolicyGetDefaultResponse19sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemPolicyGetDefaultRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPolicyGetDefaultRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
