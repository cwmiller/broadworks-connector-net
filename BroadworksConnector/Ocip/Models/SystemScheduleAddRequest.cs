using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a system schedule.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:15872""}]")]
    public class SystemScheduleAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _scheduleName;

        [XmlElement(ElementName = "scheduleName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:15872")]
        [MinLength(1)]
        [MaxLength(40)]
        public string ScheduleName
        {
            get => _scheduleName;
            set
            {
                ScheduleNameSpecified = true;
                _scheduleName = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ScheduleType _scheduleType;

        [XmlElement(ElementName = "scheduleType", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:15872")]
        public BroadWorksConnector.Ocip.Models.ScheduleType ScheduleType
        {
            get => _scheduleType;
            set
            {
                ScheduleTypeSpecified = true;
                _scheduleType = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleTypeSpecified { get; set; }

    }
}
