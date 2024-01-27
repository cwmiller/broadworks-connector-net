using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemScheduleGetListRequest.
    /// The response contains a list of system schedules.
    /// <see cref="SystemScheduleGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:16012""}]")]
    public class SystemScheduleGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _scheduleName = new List<string>();

        [XmlElement(ElementName = "scheduleName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:16012")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> ScheduleName
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

        protected List<BroadWorksConnector.Ocip.Models.ScheduleType> _scheduleType = new List<BroadWorksConnector.Ocip.Models.ScheduleType>();

        [XmlElement(ElementName = "scheduleType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:16012")]
        public List<BroadWorksConnector.Ocip.Models.ScheduleType> ScheduleType
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
