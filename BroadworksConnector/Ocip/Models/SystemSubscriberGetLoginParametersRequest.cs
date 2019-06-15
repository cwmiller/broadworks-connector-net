using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system login configuration for all subscribers.
    /// The response is either a SystemSubscriberGetLoginParametersResponse or an ErrorResponse.
        /// <see cref="SystemSubscriberGetLoginParametersResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSubscriberGetLoginParametersRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
