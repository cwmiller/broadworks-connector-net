using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get Malicious Call Trace system parameters and the list of users that use the
    /// Malicious Call Trace feature.
    /// The response is either a SystemMaliciousCallTraceGetResponse or
    /// an ErrorResponse.
        /// <see cref="SystemMaliciousCallTraceGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMaliciousCallTraceGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
