using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system call processing configuration for all subscribers
    /// The response is either a SystemSubscriberGetCallProcessingParametersResponse or an ErrorResponse.
    /// Replaced By: SystemSubscriberGetCallProcessingParametersRequest14sp3
        /// <see cref="SystemSubscriberGetCallProcessingParametersResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemSubscriberGetCallProcessingParametersRequest14sp3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSubscriberGetCallProcessingParametersRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
