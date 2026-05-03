using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseVoiceVPNGetPolicyRequest.
    /// <see cref="EnterpriseVoiceVPNGetPolicyRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""405ec18fe08719ecf74e749d7e18c88f:1141"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""405ec18fe08719ecf74e749d7e18c88f:1147""}]}]")]
    public class EnterpriseVoiceVPNGetPolicyResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _minExtensionLength;

        [XmlElement(ElementName = "minExtensionLength", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1141")]
        [MinInclusive(0)]
        [MaxInclusive(100)]
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
        protected bool MinExtensionLengthSpecified { get; set; }

        protected int _maxExtensionLength;

        [XmlElement(ElementName = "maxExtensionLength", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1141")]
        [MinInclusive(0)]
        [MaxInclusive(100)]
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
        protected bool MaxExtensionLengthSpecified { get; set; }

        protected string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1141")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = (value != null);
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

        protected string _routeGroupId;

        [XmlElement(ElementName = "routeGroupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1141")]
        [MinLength(1)]
        [MaxLength(30)]
        public string RouteGroupId
        {
            get => _routeGroupId;
            set
            {
                RouteGroupIdSpecified = (value != null);
                _routeGroupId = value;
            }
        }

        [XmlIgnore]
        protected bool RouteGroupIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection _policySelection;

        [XmlElement(ElementName = "policySelection", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1141")]
        public BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection PolicySelection
        {
            get => _policySelection;
            set
            {
                PolicySelectionSpecified = true;
                _policySelection = value;
            }
        }

        [XmlIgnore]
        protected bool PolicySelectionSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulation> _digitManipulation = new List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulation>();

        [XmlElement(ElementName = "digitManipulation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1147")]
        public List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulation> DigitManipulation
        {
            get => _digitManipulation;
            set
            {
                DigitManipulationSpecified = (value != null);
                _digitManipulation = value;
            }
        }

        [XmlIgnore]
        protected bool DigitManipulationSpecified { get; set; }

        protected string _treatmentId;

        [XmlElement(ElementName = "treatmentId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1147")]
        [MinLength(1)]
        [MaxLength(30)]
        public string TreatmentId
        {
            get => _treatmentId;
            set
            {
                TreatmentIdSpecified = (value != null);
                _treatmentId = value;
            }
        }

        [XmlIgnore]
        protected bool TreatmentIdSpecified { get; set; }

    }
}
