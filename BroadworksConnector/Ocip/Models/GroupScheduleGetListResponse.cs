using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupScheduleGetListRequest.
    /// The response contains a list of system schedules.
    /// <see cref="GroupScheduleGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:12734""}]")]
    public class GroupScheduleGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _scheduleName = new List<string>();

        [XmlElement(ElementName = "scheduleName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:12734")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:12734")]
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

        protected List<BroadWorksConnector.Ocip.Models.ScheduleLevel> _scheduleLevel = new List<BroadWorksConnector.Ocip.Models.ScheduleLevel>();

        [XmlElement(ElementName = "scheduleLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:12734")]
        public List<BroadWorksConnector.Ocip.Models.ScheduleLevel> ScheduleLevel
        {
            get => _scheduleLevel;
            set
            {
                ScheduleLevelSpecified = true;
                _scheduleLevel = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleLevelSpecified { get; set; }

    }
}
