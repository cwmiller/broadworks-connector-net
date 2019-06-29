using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a user time schedule.
    /// The response is either a UserTimeScheduleGetResponse or an ErrorResponse.
    /// <see cref="UserTimeScheduleGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:17877""}]")]
    public class UserTimeScheduleGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17877")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        private string _timeScheduleName;

        [XmlElement(ElementName = "timeScheduleName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17877")]
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
