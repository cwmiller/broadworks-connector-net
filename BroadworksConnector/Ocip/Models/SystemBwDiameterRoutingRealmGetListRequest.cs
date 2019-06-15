using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of Diameter routing realms.
    /// The response is either SystemBwDiameterRoutingRealmGetListResponse or  ErrorResponse.
        /// <see cref="SystemBwDiameterRoutingRealmGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBwDiameterRoutingRealmGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
