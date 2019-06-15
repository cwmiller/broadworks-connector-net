using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Processing Policy.
    /// The response is either a SystemCallProcessingGetPolicyResponse15 or an
    /// ErrorResponse.
    /// Replaced By: SystemCallProcessingGetPolicyRequest15sp2
        /// <see cref="SystemCallProcessingGetPolicyResponse15"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCallProcessingGetPolicyRequest15sp2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallProcessingGetPolicyRequest15 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
