using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a criteria for the user's custom ringback service.
    /// The response is either a UserCustomRingbackUserGetCriteriaResponse16 or an ErrorResponse.
    /// 
    /// Replaced by: UserCustomRingbackUserGetCriteriaRequest20 in AS data mode
        /// <see cref="UserCustomRingbackUserGetCriteriaResponse16"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserCustomRingbackUserGetCriteriaRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCustomRingbackUserGetCriteriaRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
    }
}
