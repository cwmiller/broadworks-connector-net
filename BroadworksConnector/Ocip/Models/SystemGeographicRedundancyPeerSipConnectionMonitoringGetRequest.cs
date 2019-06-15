using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Peer SIP Connection system parameters
    /// The response is a SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse.
        /// <see cref="SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemGeographicRedundancyPeerSipConnectionMonitoringGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
