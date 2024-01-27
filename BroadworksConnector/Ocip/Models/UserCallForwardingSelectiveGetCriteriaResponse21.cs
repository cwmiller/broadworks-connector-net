using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallForwardingSelectiveGetCriteriaRequest21.
    /// <see cref="UserCallForwardingSelectiveGetCriteriaRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a80d284dc33fadcf5b323133519ad1a8:107""}]")]
    public class UserCallForwardingSelectiveGetCriteriaResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.TimeSchedule _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:107")]
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
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:107")]
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

        protected BroadWorksConnector.Ocip.Models.CallForwardingSelectiveNumberSelection16 _forwardToNumberSelection;

        [XmlElement(ElementName = "forwardToNumberSelection", IsNullable = false, Namespace = "")]
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:107")]
        public BroadWorksConnector.Ocip.Models.CallForwardingSelectiveNumberSelection16 ForwardToNumberSelection
        {
            get => _forwardToNumberSelection;
            set
            {
                ForwardToNumberSelectionSpecified = true;
                _forwardToNumberSelection = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardToNumberSelectionSpecified { get; set; }

        protected string _forwardToPhoneNumber;

        [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:107")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ForwardToPhoneNumber
        {
            get => _forwardToPhoneNumber;
            set
            {
                ForwardToPhoneNumberSpecified = true;
                _forwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardToPhoneNumberSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CriteriaFromDn _fromDnCriteria;

        [XmlElement(ElementName = "fromDnCriteria", IsNullable = false, Namespace = "")]
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:107")]
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

        protected List<BroadWorksConnector.Ocip.Models.CallToNumber> _callToNumber = new List<BroadWorksConnector.Ocip.Models.CallToNumber>();

        [XmlElement(ElementName = "callToNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:107")]
        public List<BroadWorksConnector.Ocip.Models.CallToNumber> CallToNumber
        {
            get => _callToNumber;
            set
            {
                CallToNumberSpecified = true;
                _callToNumber = value;
            }
        }

        [XmlIgnore]
        protected bool CallToNumberSpecified { get; set; }

    }
}
