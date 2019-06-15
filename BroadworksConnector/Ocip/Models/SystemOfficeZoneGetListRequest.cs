using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all Office Zones.
    /// The response is either a SystemOfficeZoneGetListResponse
    /// or an ErrorResponse.
        /// <see cref="SystemOfficeZoneGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemOfficeZoneGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
