using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of routes in the system.
    /// The response is either a SystemRoutingGetRouteListResponse or an ErrorResponse.
        /// <see cref="SystemRoutingGetRouteListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemRoutingGetRouteListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
