using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The response is either a SystemCallProcessingGetPolicyResponse21sp2 or an
    /// ErrorResponse.
    /// Replaced by: SystemCallProcessingGetPolicyRequest22 in AS data mode.
        /// <see cref="SystemCallProcessingGetPolicyResponse21sp2"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCallProcessingGetPolicyRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallProcessingGetPolicyRequest21sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
