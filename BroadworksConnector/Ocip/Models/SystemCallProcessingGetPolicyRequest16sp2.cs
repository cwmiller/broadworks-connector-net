using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Processing Policy.
    /// The response is either a SystemCallProcessingGetPolicyResponse16sp2 or an
    /// ErrorResponse.
        /// <see cref="SystemCallProcessingGetPolicyResponse16sp2"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallProcessingGetPolicyRequest16sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
