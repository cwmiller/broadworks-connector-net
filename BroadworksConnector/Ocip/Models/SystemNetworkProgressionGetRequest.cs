using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with network progression.
    /// The response is either a SystemNetworkProgressionGetResponse or an
    /// ErrorResponse.
        /// <see cref="SystemNetworkProgressionGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNetworkProgressionGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
