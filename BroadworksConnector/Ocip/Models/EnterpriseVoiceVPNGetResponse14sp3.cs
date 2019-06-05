using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseVoiceVPNGetResponse14sp3 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDefaultSelection _defaultSelection;

        [XmlElement(ElementName = "defaultSelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDefaultSelection DefaultSelection
        {
            get => _defaultSelection;
            set
            {
                DefaultSelectionSpecified = true;
                _defaultSelection = value;
            }
        }

        [XmlIgnore]
        public bool DefaultSelectionSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNNonMatchingE164NumberSelection _e164Selection;

        [XmlElement(ElementName = "e164Selection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNNonMatchingE164NumberSelection E164Selection
        {
            get => _e164Selection;
            set
            {
                E164SelectionSpecified = true;
                _e164Selection = value;
            }
        }

        [XmlIgnore]
        public bool E164SelectionSpecified { get; set; }
        private bool _usePhoneContext;

        [XmlElement(ElementName = "usePhoneContext", IsNullable = false, Namespace = "")]
        public bool UsePhoneContext
        {
            get => _usePhoneContext;
            set
            {
                UsePhoneContextSpecified = true;
                _usePhoneContext = value;
            }
        }

        [XmlIgnore]
        public bool UsePhoneContextSpecified { get; set; }
    }
}
