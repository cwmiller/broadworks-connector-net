using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CriteriaFromDn
    {
        private BroadworksConnector.Ocip.Models.CriteriaDnSelection _fromDnCriteriaSelection;

        [XmlElement(ElementName = "fromDnCriteriaSelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CriteriaDnSelection FromDnCriteriaSelection
        {
            get => _fromDnCriteriaSelection;
            set
            {
                FromDnCriteriaSelectionSpecified = true;
                _fromDnCriteriaSelection = value;
            }
        }

        [XmlIgnore]
        public bool FromDnCriteriaSelectionSpecified { get; set; }
        private bool _includeAnonymousCallers;

        [XmlElement(ElementName = "includeAnonymousCallers", IsNullable = false, Namespace = "")]
        public bool IncludeAnonymousCallers
        {
            get => _includeAnonymousCallers;
            set
            {
                IncludeAnonymousCallersSpecified = true;
                _includeAnonymousCallers = value;
            }
        }

        [XmlIgnore]
        public bool IncludeAnonymousCallersSpecified { get; set; }
        private bool _includeUnavailableCallers;

        [XmlElement(ElementName = "includeUnavailableCallers", IsNullable = false, Namespace = "")]
        public bool IncludeUnavailableCallers
        {
            get => _includeUnavailableCallers;
            set
            {
                IncludeUnavailableCallersSpecified = true;
                _includeUnavailableCallers = value;
            }
        }

        [XmlIgnore]
        public bool IncludeUnavailableCallersSpecified { get; set; }
        private List<string> _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        public List<string> PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }
    }
}
