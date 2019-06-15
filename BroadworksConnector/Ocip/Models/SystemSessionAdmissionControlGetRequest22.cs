using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the session admission control settings for the system.
    /// The response is either a SystemSessionAdmissionControlGetResponse22 or an ErrorResponse.
        /// <see cref="SystemSessionAdmissionControlGetResponse22"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSessionAdmissionControlGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
