using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get all the Communication Barring Alternate Call Indicator defined
    /// in the system. The response is either a SystemCommunicationBarringAlternateCallIndicatorGetListResponse or an ErrorResponse.
        /// <see cref="SystemCommunicationBarringAlternateCallIndicatorGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringAlternateCallIndicatorGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
