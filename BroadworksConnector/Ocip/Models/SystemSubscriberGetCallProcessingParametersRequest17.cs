using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system call processing configuration for all subscribers
    /// The response is either a SystemSubscriberGetCallProcessingParametersResponse17
    /// or an ErrorResponse.
        /// <see cref="SystemSubscriberGetCallProcessingParametersResponse17"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSubscriberGetCallProcessingParametersRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
