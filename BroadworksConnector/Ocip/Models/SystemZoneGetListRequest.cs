using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all Zones.
    /// The response is either a SystemZoneGetListResponse or an ErrorResponse.
        /// <see cref="SystemZoneGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemZoneGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
