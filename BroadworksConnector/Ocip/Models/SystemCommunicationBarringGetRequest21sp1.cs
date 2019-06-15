using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Communication Barring.
    /// The response is either a SystemCommunicationBarringGetResponse21sp1 or an ErrorResponse.
        /// <see cref="SystemCommunicationBarringGetResponse21sp1"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringGetRequest21sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
