using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular User Type.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SearchCriteriaExactUserType : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        
        private BroadWorksConnector.Ocip.Models.UserType _userType;

        [XmlElement(ElementName = "userType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.UserType UserType {
            get => _userType;
            set {
                UserTypeSpecified = true;
                _userType = value;
            }
        }

        [XmlIgnore]
        public bool UserTypeSpecified { get; set; }
        
    }
}
