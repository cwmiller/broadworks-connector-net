using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The response is either a SystemCallProcessingGetPolicyResponse21sp1 or an
    /// ErrorResponse.
    /// Replaced by: SystemCallProcessingGetPolicyRequest1sp2.
        /// <see cref="SystemCallProcessingGetPolicyResponse21sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCallProcessingGetPolicyRequest1sp2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallProcessingGetPolicyRequest21sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
