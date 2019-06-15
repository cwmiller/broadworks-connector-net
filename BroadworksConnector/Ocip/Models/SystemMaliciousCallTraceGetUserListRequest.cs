using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the list of users that use the Malicious Call Trace feature.
    /// The response is either a SystemMaliciousCallTraceGetUserListResponse or an
    /// ErrorResponse.
    /// Replaced By: SystemMaliciousCallTraceGetRequest
        /// <see cref="SystemMaliciousCallTraceGetUserListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemMaliciousCallTraceGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMaliciousCallTraceGetUserListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
