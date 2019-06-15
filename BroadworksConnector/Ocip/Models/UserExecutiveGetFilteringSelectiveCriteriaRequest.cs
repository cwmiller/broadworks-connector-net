using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a filtering criteria for an executive user.
    /// Both executive and the executive assistant can run this command.
    /// The response is either UserExecutiveGetFilteringSelectiveCriteriaResponse or ErrorResponse.
    /// Replaced by: UserExecutiveGetFilteringSelectiveCriteriaRequest21
        /// <see cref="UserExecutiveGetFilteringSelectiveCriteriaResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserExecutiveGetFilteringSelectiveCriteriaRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserExecutiveGetFilteringSelectiveCriteriaRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
