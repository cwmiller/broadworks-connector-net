using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Gets a list of all zones defined in the system
    /// The response is SystemZoneCallingRestrictionsZoneGetListResponse or an ErrorResponse.
    /// Replaced by: SystemZoneGetListRequest
        /// <see cref="SystemZoneCallingRestrictionsZoneGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemZoneGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemZoneCallingRestrictionsZoneGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
