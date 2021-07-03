using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a system time schedule.
    /// The response is either a SystemTimeScheduleGetResponse or an ErrorResponse.
    /// <see cref="SystemTimeScheduleGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:35637""}]")]
    public class SystemTimeScheduleGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _timeScheduleName;

        [XmlElement(ElementName = "timeScheduleName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35637")]
        [MinLength(1)]
        [MaxLength(40)]
        public string TimeScheduleName
        {
            get => _timeScheduleName;
            set
            {
                TimeScheduleNameSpecified = true;
                _timeScheduleName = value;
            }
        }

        [XmlIgnore]
        protected bool TimeScheduleNameSpecified { get; set; }

    }
}
