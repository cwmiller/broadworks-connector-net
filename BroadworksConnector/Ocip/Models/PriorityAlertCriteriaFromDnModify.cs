using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The from dn criteria used within a modify request.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class PriorityAlertCriteriaFromDnModify 
    {

        
        private BroadWorksConnector.Ocip.Models.PriorityAlertCriteriaFromDnSelection _fromDnCriteriaSelection;

        [XmlElement(ElementName = "fromDnCriteriaSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.PriorityAlertCriteriaFromDnSelection FromDnCriteriaSelection {
            get => _fromDnCriteriaSelection;
            set {
                FromDnCriteriaSelectionSpecified = true;
                _fromDnCriteriaSelection = value;
            }
        }

        [XmlIgnore]
        public bool FromDnCriteriaSelectionSpecified { get; set; }
        
        private bool _includeAnonymousCallers;

        [XmlElement(ElementName = "includeAnonymousCallers", IsNullable = false, Namespace = "")]
        public bool IncludeAnonymousCallers {
            get => _includeAnonymousCallers;
            set {
                IncludeAnonymousCallersSpecified = true;
                _includeAnonymousCallers = value;
            }
        }

        [XmlIgnore]
        public bool IncludeAnonymousCallersSpecified { get; set; }
        
        private bool _includeUnavailableCallers;

        [XmlElement(ElementName = "includeUnavailableCallers", IsNullable = false, Namespace = "")]
        public bool IncludeUnavailableCallers {
            get => _includeUnavailableCallers;
            set {
                IncludeUnavailableCallersSpecified = true;
                _includeUnavailableCallers = value;
            }
        }

        [XmlIgnore]
        public bool IncludeUnavailableCallersSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CriteriaReplacementDNList _phoneNumberList;

        [XmlElement(ElementName = "phoneNumberList", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CriteriaReplacementDNList PhoneNumberList {
            get => _phoneNumberList;
            set {
                PhoneNumberListSpecified = true;
                _phoneNumberList = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberListSpecified { get; set; }
        
    }
}
