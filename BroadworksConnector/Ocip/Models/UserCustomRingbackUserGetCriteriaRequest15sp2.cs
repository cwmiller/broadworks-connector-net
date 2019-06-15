using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a criteria for the user's custom ringback service.
    /// The response is either a UserCustomRingbackUserGetCriteriaResponse15sp2 or an ErrorResponse.
    /// Replaced By: UserCustomRingbackUserGetCriteriaRequest16
        /// <see cref="UserCustomRingbackUserGetCriteriaResponse15sp2"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserCustomRingbackUserGetCriteriaRequest16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCustomRingbackUserGetCriteriaRequest15sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
