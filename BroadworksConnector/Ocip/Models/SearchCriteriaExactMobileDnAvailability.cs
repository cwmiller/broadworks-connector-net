using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular mobile dn availability.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SearchCriteriaExactMobileDnAvailability : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        
        private bool _available;

        [XmlElement(ElementName = "available", IsNullable = false, Namespace = "")]
        public bool Available {
            get => _available;
            set {
                AvailableSpecified = true;
                _available = value;
            }
        }

        [XmlIgnore]
        public bool AvailableSpecified { get; set; }
        
    }
}
