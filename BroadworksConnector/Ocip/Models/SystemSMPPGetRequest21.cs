using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with SMPP external interface.
    /// The response is either a SystemSMPPGetResponse21 or an ErrorResponse.
        /// <see cref="SystemSMPPGetResponse21"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSMPPGetRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
