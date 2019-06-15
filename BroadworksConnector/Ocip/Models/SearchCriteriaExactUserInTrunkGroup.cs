using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for user in/not in a trunk group.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SearchCriteriaExactUserInTrunkGroup : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        
        private bool _userInTrunkGroup;

        [XmlElement(ElementName = "userInTrunkGroup", IsNullable = false, Namespace = "")]
        public bool UserInTrunkGroup {
            get => _userInTrunkGroup;
            set {
                UserInTrunkGroupSpecified = true;
                _userInTrunkGroup = value;
            }
        }

        [XmlIgnore]
        public bool UserInTrunkGroupSpecified { get; set; }
        
    }
}
