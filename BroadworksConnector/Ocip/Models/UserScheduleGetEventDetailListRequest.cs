using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the list of schedules viewable by a User. The list can be filtered by schedule type.
    /// The response is either a UserScheduleGetEventDetailListResponse or an ErrorResponse.
    /// <see cref="UserScheduleGetEventDetailListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:3612""}]")]
    public class UserScheduleGetEventDetailListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserScheduleGetEventDetailListResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3612")]
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

        protected BroadWorksConnector.Ocip.Models.ScheduleGlobalKey _scheduleGlobalKey;

        [XmlElement(ElementName = "scheduleGlobalKey", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3612")]
        public BroadWorksConnector.Ocip.Models.ScheduleGlobalKey ScheduleGlobalKey
        {
            get => _scheduleGlobalKey;
            set
            {
                ScheduleGlobalKeySpecified = true;
                _scheduleGlobalKey = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleGlobalKeySpecified { get; set; }

    }
}
