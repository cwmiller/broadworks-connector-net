using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the session admission control settings for the system.
    /// The response is either a SystemSessionAdmissionControlGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemSessionAdmissionControlGetRequest21sp1.
        /// <see cref="SystemSessionAdmissionControlGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemSessionAdmissionControlGetRequest21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSessionAdmissionControlGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
