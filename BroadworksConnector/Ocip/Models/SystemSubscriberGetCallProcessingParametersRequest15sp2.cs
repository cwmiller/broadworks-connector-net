using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system call processing configuration for all subscribers
    /// The response is either a SystemSubscriberGetCallProcessingParametersResponse15sp2 or an ErrorResponse.
    /// Replaced by: SystemSubscriberGetCallProcessingParametersRequest17
        /// <see cref="SystemSubscriberGetCallProcessingParametersResponse15sp2"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemSubscriberGetCallProcessingParametersRequest17"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSubscriberGetCallProcessingParametersRequest15sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
