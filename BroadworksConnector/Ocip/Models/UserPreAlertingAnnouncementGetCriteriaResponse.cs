using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserPreAlertingAnnouncementGetCriteriaRequest.
    /// Replaced by: UserPreAlertingAnnouncementGetCriteriaResponse21 in AS data mode
    /// <see cref="UserPreAlertingAnnouncementGetCriteriaRequest"/>
    /// <see cref="UserPreAlertingAnnouncementGetCriteriaResponse21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:18552""}]")]
    public class UserPreAlertingAnnouncementGetCriteriaResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.TimeSchedule _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18552")]
        public BroadWorksConnector.Ocip.Models.TimeSchedule TimeSchedule
        {
            get => _timeSchedule;
            set
            {
                TimeScheduleSpecified = true;
                _timeSchedule = value;
            }
        }

        [XmlIgnore]
        protected bool TimeScheduleSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18552")]
        public BroadWorksConnector.Ocip.Models.HolidaySchedule HolidaySchedule
        {
            get => _holidaySchedule;
            set
            {
                HolidayScheduleSpecified = true;
                _holidaySchedule = value;
            }
        }

        [XmlIgnore]
        protected bool HolidayScheduleSpecified { get; set; }

        protected bool _blacklisted;

        [XmlElement(ElementName = "blacklisted", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18552")]
        public bool Blacklisted
        {
            get => _blacklisted;
            set
            {
                BlacklistedSpecified = true;
                _blacklisted = value;
            }
        }

        [XmlIgnore]
        protected bool BlacklistedSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CriteriaFromDn _fromDnCriteria;

        [XmlElement(ElementName = "fromDnCriteria", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18552")]
        public BroadWorksConnector.Ocip.Models.CriteriaFromDn FromDnCriteria
        {
            get => _fromDnCriteria;
            set
            {
                FromDnCriteriaSpecified = true;
                _fromDnCriteria = value;
            }
        }

        [XmlIgnore]
        protected bool FromDnCriteriaSpecified { get; set; }

    }
}
