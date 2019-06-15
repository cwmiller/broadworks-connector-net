using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of Route Point External Systems that are configured for the system.
    /// The response is either SystemRoutePointExternalSystemGetListResponse or ErrorResponse.
        /// <see cref="SystemRoutePointExternalSystemGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemRoutePointExternalSystemGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
