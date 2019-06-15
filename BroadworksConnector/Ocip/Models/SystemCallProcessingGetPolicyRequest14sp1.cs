using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Processing Policy.
    /// The response is either a SystemCallProcessingGetPolicyResponse14sp1 or an
    /// ErrorResponse.
        /// <see cref="SystemCallProcessingGetPolicyResponse14sp1"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallProcessingGetPolicyRequest14sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
