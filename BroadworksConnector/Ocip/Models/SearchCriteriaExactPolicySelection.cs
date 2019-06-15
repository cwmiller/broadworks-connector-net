using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular Voice VPN policy selection.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SearchCriteriaExactPolicySelection : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        
        private BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection _policySelection;

        [XmlElement(ElementName = "policySelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection PolicySelection {
            get => _policySelection;
            set {
                PolicySelectionSpecified = true;
                _policySelection = value;
            }
        }

        [XmlIgnore]
        public bool PolicySelectionSpecified { get; set; }
        
    }
}
