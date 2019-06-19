using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemTimeScheduleGetListRequest.
    /// The response contains all the system time schedule names.
    /// <see cref="SystemTimeScheduleGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:16499""}]")]
    public class SystemTimeScheduleGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _timeSchedule = new List<string>();

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16499")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> TimeSchedule
        {
            get => _timeSchedule;
            set
            {
                TimeScheduleSpecified = true;
                _timeSchedule = value;
            }
        }

        [XmlIgnore]
        public bool TimeScheduleSpecified { get; set; }

    }
}
