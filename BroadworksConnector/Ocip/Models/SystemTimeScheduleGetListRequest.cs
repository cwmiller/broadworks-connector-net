using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a list of all system time schedules.
    /// The response is either a SystemTimeScheduleGetListResponse or an ErrorResponse.
        /// <see cref="SystemTimeScheduleGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTimeScheduleGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
