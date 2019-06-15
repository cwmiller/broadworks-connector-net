using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for users with Route List feature assignment.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SearchCriteriaExactUserRouteListAssignment : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        
        private bool _assigned;

        [XmlElement(ElementName = "assigned", IsNullable = false, Namespace = "")]
        public bool Assigned {
            get => _assigned;
            set {
                AssignedSpecified = true;
                _assigned = value;
            }
        }

        [XmlIgnore]
        public bool AssignedSpecified { get; set; }
        
    }
}
