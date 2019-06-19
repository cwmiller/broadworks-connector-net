using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a criteria to the user's BroadWorks Anywhere phone number.
    /// The following elements are only used in AS data mode:
    /// callToNumber
    /// 
    /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""72f634ecc58842ce9d362ca629a47ea9:290""}]")]
    public class UserBroadWorksAnywhereAddSelectiveCriteriaRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:290")]
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
        public bool UserIdSpecified { get; set; }

        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:290")]
        [MinLength(1)]
        [MaxLength(23)]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }

        private string _criteriaName;

        [XmlElement(ElementName = "criteriaName", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:290")]
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
        public bool CriteriaNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeSchedule _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:290")]
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
        public bool TimeScheduleSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:290")]
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
        public bool HolidayScheduleSpecified { get; set; }

        private bool _blacklisted;

        [XmlElement(ElementName = "blacklisted", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:290")]
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
        public bool BlacklistedSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CriteriaFromDn _fromDnCriteria;

        [XmlElement(ElementName = "fromDnCriteria", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:290")]
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
        public bool FromDnCriteriaSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.CallToNumber> _callToNumber = new List<BroadWorksConnector.Ocip.Models.CallToNumber>();

        [XmlElement(ElementName = "callToNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:290")]
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
        public bool CallToNumberSpecified { get; set; }

    }
}
