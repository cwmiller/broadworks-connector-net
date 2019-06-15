using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Communication Barring.
    /// The response is either a SystemCommunicationBarringGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemCommunicationBarringGetRequest21sp1 in AS data mode.
        /// <see cref="SystemCommunicationBarringGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCommunicationBarringGetRequest21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
