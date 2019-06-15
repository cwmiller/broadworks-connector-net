using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of Mobile Networks.
    /// The response is either SystemBroadWorksMobilityMobileNetworkGetListResponse or ErrorResponse.
        /// <see cref="SystemBroadWorksMobilityMobileNetworkGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksMobilityMobileNetworkGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
