using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's call me now service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallMeNowModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private List<BroadWorksConnector.Ocip.Models.CriteriaActivation> _criteriaActivation;

        [XmlElement(ElementName = "criteriaActivation", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CriteriaActivation> CriteriaActivation {
            get => _criteriaActivation;
            set {
                CriteriaActivationSpecified = true;
                _criteriaActivation = value;
            }
        }

        [XmlIgnore]
        public bool CriteriaActivationSpecified { get; set; }
        
    }
}
