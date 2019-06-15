using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system DTMF transmission configurations.
    /// The response is either SystemDTMFTransmissionGetResponse or ErrorResponse.
        /// <see cref="SystemDTMFTransmissionGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDTMFTransmissionGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
