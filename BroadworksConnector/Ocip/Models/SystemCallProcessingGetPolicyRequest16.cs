using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Processing Policy.
    /// The response is either a SystemCallProcessingGetPolicyResponse16 or an
    /// ErrorResponse.
        /// <see cref="SystemCallProcessingGetPolicyResponse16"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallProcessingGetPolicyRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
