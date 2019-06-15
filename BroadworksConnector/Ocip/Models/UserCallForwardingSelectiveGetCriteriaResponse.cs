using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallForwardingSelectiveGetCriteriaRequest.
        /// <see cref="UserCallForwardingSelectiveGetCriteriaRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallForwardingSelectiveGetCriteriaResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
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
        
        private BroadWorksConnector.Ocip.Models.CallForwardingSelectiveNumberSelection _forwardToNumberSelection;

        [XmlElement(ElementName = "forwardToNumberSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallForwardingSelectiveNumberSelection ForwardToNumberSelection {
            get => _forwardToNumberSelection;
            set {
                ForwardToNumberSelectionSpecified = true;
                _forwardToNumberSelection = value;
            }
        }

        [XmlIgnore]
        public bool ForwardToNumberSelectionSpecified { get; set; }
        
        private string _forwardToPhoneNumber;

        [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = false, Namespace = "")]
        public string ForwardToPhoneNumber {
            get => _forwardToPhoneNumber;
            set {
                ForwardToPhoneNumberSpecified = true;
                _forwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool ForwardToPhoneNumberSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CriteriaFromDn _fromDnCriteria;

        [XmlElement(ElementName = "fromDnCriteria", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CriteriaFromDn FromDnCriteria {
            get => _fromDnCriteria;
            set {
                FromDnCriteriaSpecified = true;
                _fromDnCriteria = value;
            }
        }

        [XmlIgnore]
        public bool FromDnCriteriaSpecified { get; set; }
        
    }
}
