using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of time zone names.
    /// The response is either SystemTimeZoneGetListResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemTimeZoneGetListRequest20 in AS data mode
        /// <see cref="SystemTimeZoneGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemTimeZoneGetListRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTimeZoneGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
