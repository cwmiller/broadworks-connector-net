using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a criteria for the user's call notify service.
    /// The response is either a UserCallNotifyGetCriteriaResponse16 or an ErrorResponse.
    /// Replaced by: UserCallNotifyGetCriteriaRequest21 in AS data mode
        /// <see cref="UserCallNotifyGetCriteriaResponse16"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserCallNotifyGetCriteriaRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallNotifyGetCriteriaRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
