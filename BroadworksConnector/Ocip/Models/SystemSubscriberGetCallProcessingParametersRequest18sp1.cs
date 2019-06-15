using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system call processing configuration for all subscribers
    /// The response is either a SystemSubscriberGetCallProcessingParametersResponse18sp1
    /// or an ErrorResponse.
        /// <see cref="SystemSubscriberGetCallProcessingParametersResponse18sp1"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSubscriberGetCallProcessingParametersRequest18sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
