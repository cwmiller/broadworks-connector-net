using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's DTMF based in-call service activation trigger attributes.
    /// The response is either a SystemInCallServiceActivationGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemInCallServiceActivationGetRequest17
        /// <see cref="SystemInCallServiceActivationGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemInCallServiceActivationGetRequest17"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemInCallServiceActivationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
