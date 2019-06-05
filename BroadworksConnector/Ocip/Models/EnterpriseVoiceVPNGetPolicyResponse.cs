using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseVoiceVPNGetPolicyResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private int _minExtensionLength;

        [XmlElement(ElementName = "minExtensionLength", IsNullable = false, Namespace = "")]
        public int MinExtensionLength
        {
            get => _minExtensionLength;
            set
            {
                MinExtensionLengthSpecified = true;
                _minExtensionLength = value;
            }
        }

        [XmlIgnore]
        public bool MinExtensionLengthSpecified { get; set; }
        private int _maxExtensionLength;

        [XmlElement(ElementName = "maxExtensionLength", IsNullable = false, Namespace = "")]
        public int MaxExtensionLength
        {
            get => _maxExtensionLength;
            set
            {
                MaxExtensionLengthSpecified = true;
                _maxExtensionLength = value;
            }
        }

        [XmlIgnore]
        public bool MaxExtensionLengthSpecified { get; set; }
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        private string _routeGroupId;

        [XmlElement(ElementName = "routeGroupId", IsNullable = false, Namespace = "")]
        public string RouteGroupId
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
        private BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection _policySelection;

        [XmlElement(ElementName = "policySelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection PolicySelection
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
        private List<BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulation> _digitManipulation;

        [XmlElement(ElementName = "digitManipulation", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulation> DigitManipulation
        {
            get => _digitManipulation;
            set
            {
                DigitManipulationSpecified = true;
                _digitManipulation = value;
            }
        }

        [XmlIgnore]
        public bool DigitManipulationSpecified { get; set; }
        private string _treatmentId;

        [XmlElement(ElementName = "treatmentId", IsNullable = false, Namespace = "")]
        public string TreatmentId
        {
            get => _treatmentId;
            set
            {
                TreatmentIdSpecified = true;
                _treatmentId = value;
            }
        }

        [XmlIgnore]
        public bool TreatmentIdSpecified { get; set; }
    }
}
