using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a filtering criteria to an executive user.
    /// Both executive and the executive assistant can run this command.
    /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserExecutiveAddFilteringSelectiveCriteriaRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private string _criteriaName;

        [XmlElement(ElementName = "criteriaName", IsNullable = false, Namespace = "")]
        public string CriteriaName {
            get => _criteriaName;
            set {
                CriteriaNameSpecified = true;
                _criteriaName = value;
            }
        }

        [XmlIgnore]
        public bool CriteriaNameSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.TimeSchedule _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.TimeSchedule TimeSchedule {
            get => _timeSchedule;
            set {
                TimeScheduleSpecified = true;
                _timeSchedule = value;
            }
        }

        [XmlIgnore]
        public bool TimeScheduleSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.HolidaySchedule HolidaySchedule {
            get => _holidaySchedule;
            set {
                HolidayScheduleSpecified = true;
                _holidaySchedule = value;
            }
        }

        [XmlIgnore]
        public bool HolidayScheduleSpecified { get; set; }
        
        private bool _filter;

        [XmlElement(ElementName = "filter", IsNullable = false, Namespace = "")]
        public bool Filter {
            get => _filter;
            set {
                FilterSpecified = true;
                _filter = value;
            }
        }

        [XmlIgnore]
        public bool FilterSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExecutiveCallFilteringCriteriaFromDn _fromDnCriteria;

        [XmlElement(ElementName = "fromDnCriteria", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExecutiveCallFilteringCriteriaFromDn FromDnCriteria {
            get => _fromDnCriteria;
            set {
                FromDnCriteriaSpecified = true;
                _fromDnCriteria = value;
            }
        }

        [XmlIgnore]
        public bool FromDnCriteriaSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.CallToNumber> _callToNumber;

        [XmlElement(ElementName = "callToNumber", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CallToNumber> CallToNumber {
            get => _callToNumber;
            set {
                CallToNumberSpecified = true;
                _callToNumber = value;
            }
        }

        [XmlIgnore]
        public bool CallToNumberSpecified { get; set; }
        
    }
}
