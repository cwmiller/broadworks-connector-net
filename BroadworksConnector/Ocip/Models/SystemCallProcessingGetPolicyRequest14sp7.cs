using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Processing Policy.
    /// The response is either a SystemCallProcessingGetPolicyResponse14sp7 or an
    /// ErrorResponse.
    /// Replaced By: SystemCallProcessingGetPolicyRequest16
        /// <see cref="SystemCallProcessingGetPolicyResponse14sp7"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCallProcessingGetPolicyRequest16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallProcessingGetPolicyRequest14sp7 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
