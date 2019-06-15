using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of routing Network Servers defined in the system.
    /// The response is either a SystemNetworkRoutingServerGetListResponse or an ErrorResponse.
        /// <see cref="SystemNetworkRoutingServerGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNetworkRoutingServerGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
