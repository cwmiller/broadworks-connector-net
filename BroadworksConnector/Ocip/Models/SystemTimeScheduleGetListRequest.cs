using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:16485""}]")]
    public class SystemTimeScheduleGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
