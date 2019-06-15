using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all Communication Barring Profiles.
    /// The response is either a SystemCommunicationBarringProfileGetListResponse or an ErrorResponse.
        /// <see cref="SystemCommunicationBarringProfileGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringProfileGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
