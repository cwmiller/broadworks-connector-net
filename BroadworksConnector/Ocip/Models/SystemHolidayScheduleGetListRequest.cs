using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:15397""}]")]
    public class SystemHolidayScheduleGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
