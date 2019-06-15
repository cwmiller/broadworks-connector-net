using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Geographic Redundancy Proxy system parameters
    /// The response is a SystemGeographicRedundancyProxyGetResponse.
        /// <see cref="SystemGeographicRedundancyProxyGetResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemGeographicRedundancyProxyGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
