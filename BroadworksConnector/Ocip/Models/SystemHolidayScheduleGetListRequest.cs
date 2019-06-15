using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a list of all system holiday schedules.
    /// The response is either a SystemHolidayScheduleGetListResponse or an ErrorResponse.
        /// <see cref="SystemHolidayScheduleGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemHolidayScheduleGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
