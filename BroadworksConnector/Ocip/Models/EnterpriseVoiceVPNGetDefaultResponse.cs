using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseVoiceVPNGetDefaultResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private List<BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection> _policySelection;

        [XmlElement(ElementName = "policySelection", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection> PolicySelection
        {
            get => _policySelection;
            set
            {
                PolicySelectionSpecified = true;
                _policySelection = value;
            }
        }

        [XmlIgnore]
        public bool PolicySelectionSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperation> _digitManipulationOperation;

        [XmlElement(ElementName = "digitManipulationOperation", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperation> DigitManipulationOperation
        {
            get => _digitManipulationOperation;
            set
            {
                DigitManipulationOperationSpecified = true;
                _digitManipulationOperation = value;
            }
        }

        [XmlIgnore]
        public bool DigitManipulationOperationSpecified { get; set; }
        private List<string> _routeGroupId;

        [XmlElement(ElementName = "routeGroupId", IsNullable = false, Namespace = "")]
        public List<string> RouteGroupId
        {
            get => _routeGroupId;
            set
            {
                RouteGroupIdSpecified = true;
                _routeGroupId = value;
            }
        }

        [XmlIgnore]
        public bool RouteGroupIdSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNTreatmentEntry> _treatment;

        [XmlElement(ElementName = "treatment", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNTreatmentEntry> Treatment
        {
            get => _treatment;
            set
            {
                TreatmentSpecified = true;
                _treatment = value;
            }
        }

        [XmlIgnore]
        public bool TreatmentSpecified { get; set; }
    }
}
