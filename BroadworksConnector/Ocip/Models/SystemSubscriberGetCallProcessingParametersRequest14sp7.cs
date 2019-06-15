using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system call processing configuration for all subscribers
    /// The response is either a SystemSubscriberGetCallProcessingParametersResponse14sp7 or an ErrorResponse.
    /// Replaced By : SystemSubscriberGetCallProcessingParametersRequest15sp2
        /// <see cref="SystemSubscriberGetCallProcessingParametersResponse14sp7"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemSubscriberGetCallProcessingParametersRequest15sp2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSubscriberGetCallProcessingParametersRequest14sp7 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
