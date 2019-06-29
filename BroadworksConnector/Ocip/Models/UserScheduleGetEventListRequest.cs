using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of events of a user schedule.
    /// The response is either a UserScheduleGetEventListResponse or an ErrorResponse.
    /// <see cref="UserScheduleGetEventListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3600""}]")]
    public class UserScheduleGetEventListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3600")]
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

        private BroadWorksConnector.Ocip.Models.ScheduleKey _scheduleKey;

        [XmlElement(ElementName = "scheduleKey", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3600")]
        public BroadWorksConnector.Ocip.Models.ScheduleKey ScheduleKey
        {
            get => _scheduleKey;
            set
            {
                ScheduleKeySpecified = true;
                _scheduleKey = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleKeySpecified { get; set; }

    }
}
