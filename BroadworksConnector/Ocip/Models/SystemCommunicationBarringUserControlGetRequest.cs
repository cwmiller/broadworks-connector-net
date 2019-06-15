using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Gets the Communication Barring system level settings.
    /// The response is either SystemCommunicationBarringUserControlGetResponse or ErrorResponse.
        /// <see cref="SystemCommunicationBarringUserControlGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringUserControlGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
