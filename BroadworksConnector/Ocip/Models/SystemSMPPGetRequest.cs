using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with SMPP external interface.
    /// The response is either a SystemSMPPGetResponse or an ErrorResponse.
    /// Replaced By: SystemSMPPGetRequest14sp5
        /// <see cref="SystemSMPPGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemSMPPGetRequest14sp5"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSMPPGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
