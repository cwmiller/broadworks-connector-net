using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallMeNowGetRequest. The criteria table's column headings are:
    /// "Is Active", "Criteria Name", "Time Schedule", "Call To", "Reject Call" and "Holiday Schedule".
        /// <see cref="UserCallMeNowGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallMeNowGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        public bool IsActive {
            get => _isActive;
            set {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallMeNowAnswerConfirmation _answerConfirmation;

        [XmlElement(ElementName = "answerConfirmation", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallMeNowAnswerConfirmation AnswerConfirmation {
            get => _answerConfirmation;
            set {
                AnswerConfirmationSpecified = true;
                _answerConfirmation = value;
            }
        }

        [XmlIgnore]
        public bool AnswerConfirmationSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _criteriaTable;

        [XmlElement(ElementName = "criteriaTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CriteriaTable {
            get => _criteriaTable;
            set {
                CriteriaTableSpecified = true;
                _criteriaTable = value;
            }
        }

        [XmlIgnore]
        public bool CriteriaTableSpecified { get; set; }
        
    }
}
