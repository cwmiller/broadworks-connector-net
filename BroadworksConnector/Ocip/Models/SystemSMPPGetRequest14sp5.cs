using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with SMPP external interface.
    /// The response is either a SystemSMPPGetResponse14sp5 or an ErrorResponse.
    /// 
    /// Replaced by: SystemSMPPGetRequest21 in AS data mode
        /// <see cref="SystemSMPPGetResponse14sp5"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemSMPPGetRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSMPPGetRequest14sp5 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
