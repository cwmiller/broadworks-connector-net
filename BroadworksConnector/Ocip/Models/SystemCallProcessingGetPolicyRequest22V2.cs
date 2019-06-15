using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The response is either a SystemCallProcessingGetPolicyResponse22V2 or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemCallProcessingGetPolicyRequest23 in AS data mode.
        /// <see cref="SystemCallProcessingGetPolicyResponse22V2"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCallProcessingGetPolicyRequest23"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallProcessingGetPolicyRequest22V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
