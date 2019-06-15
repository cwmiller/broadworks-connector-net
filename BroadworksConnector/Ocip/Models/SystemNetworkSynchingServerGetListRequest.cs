using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of Network Servers defined in the system.
    /// The response is either a SystemNetworkSynchingServerGetListResponse or an ErrorResponse.
        /// <see cref="SystemNetworkSynchingServerGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNetworkSynchingServerGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
