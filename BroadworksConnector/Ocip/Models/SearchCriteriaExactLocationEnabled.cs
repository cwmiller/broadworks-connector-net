using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular Location enabled state.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SearchCriteriaExactLocationEnabled : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        
        private bool _enabled;

        [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
        public bool Enabled {
            get => _enabled;
            set {
                EnabledSpecified = true;
                _enabled = value;
            }
        }

        [XmlIgnore]
        public bool EnabledSpecified { get; set; }
        
    }
}
