using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular Dn activation state.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SearchCriteriaExactDnActivation : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        
        private bool _activated;

        [XmlElement(ElementName = "activated", IsNullable = false, Namespace = "")]
        public bool Activated {
            get => _activated;
            set {
                ActivatedSpecified = true;
                _activated = value;
            }
        }

        [XmlIgnore]
        public bool ActivatedSpecified { get; set; }
        
    }
}
