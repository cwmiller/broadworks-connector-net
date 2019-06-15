using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for call center scheduled report created by a
    /// supervisor or administrator.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        
        private bool _createdBySupervisor;

        [XmlElement(ElementName = "createdBySupervisor", IsNullable = false, Namespace = "")]
        public bool CreatedBySupervisor {
            get => _createdBySupervisor;
            set {
                CreatedBySupervisorSpecified = true;
                _createdBySupervisor = value;
            }
        }

        [XmlIgnore]
        public bool CreatedBySupervisorSpecified { get; set; }
        
    }
}
