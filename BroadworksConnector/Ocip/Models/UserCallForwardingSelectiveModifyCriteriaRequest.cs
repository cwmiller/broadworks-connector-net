using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a criteria for the user's call forwarding selective service.
    /// The following elements are only used in AS data mode:
    /// callToNumber
    /// 
    /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a80d284dc33fadcf5b323133519ad1a8:181""}]")]
    public class UserCallForwardingSelectiveModifyCriteriaRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:181")]
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

        protected string _criteriaName;

        [XmlElement(ElementName = "criteriaName", IsNullable = false, Namespace = "")]
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:181")]
        [MinLength(1)]
        [MaxLength(50)]
        public string CriteriaName
        {
            get => _criteriaName;
            set
            {
                CriteriaNameSpecified = true;
                _criteriaName = value;
            }
        }

        [XmlIgnore]
        protected bool CriteriaNameSpecified { get; set; }

        protected string _newCriteriaName;

        [XmlElement(ElementName = "newCriteriaName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:181")]
        [MinLength(1)]
        [MaxLength(50)]
        public string NewCriteriaName
        {
            get => _newCriteriaName;
            set
            {
                NewCriteriaNameSpecified = true;
                _newCriteriaName = value;
            }
        }

        [XmlIgnore]
        protected bool NewCriteriaNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TimeSchedule _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:181")]
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

        [XmlElement(ElementName = "holidaySchedule", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:181")]
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
        [Optional]
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:181")]
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

        [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:181")]
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

        protected BroadWorksConnector.Ocip.Models.CriteriaFromDnModify _fromDnCriteria;

        [XmlElement(ElementName = "fromDnCriteria", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:181")]
        public BroadWorksConnector.Ocip.Models.CriteriaFromDnModify FromDnCriteria
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

        protected BroadWorksConnector.Ocip.Models.ReplacementCallToNumberList _callToNumberList;

        [XmlElement(ElementName = "callToNumberList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:181")]
        public BroadWorksConnector.Ocip.Models.ReplacementCallToNumberList CallToNumberList
        {
            get => _callToNumberList;
            set
            {
                CallToNumberListSpecified = true;
                _callToNumberList = value;
            }
        }

        [XmlIgnore]
        protected bool CallToNumberListSpecified { get; set; }

    }
}
