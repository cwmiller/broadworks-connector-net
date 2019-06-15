using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the configured time zone of the server processing the request and the list of time zone names.
    /// The response is either SystemTimeZoneGetListResponse20 or ErrorResponse.
        /// <see cref="SystemTimeZoneGetListResponse20"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTimeZoneGetListRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
