using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseVoiceVPNGetDefaultResponse.
    /// <see cref="EnterpriseVoiceVPNGetDefaultResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""405ec18fe08719ecf74e749d7e18c88f:1064""}]")]
    public class EnterpriseVoiceVPNGetDefaultResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection> _policySelection = new List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection>();

        [XmlElement(ElementName = "policySelection", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1064")]
        public List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection> PolicySelection
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

        protected List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperation> _digitManipulationOperation = new List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperation>();

        [XmlElement(ElementName = "digitManipulationOperation", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1064")]
        public List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperation> DigitManipulationOperation
        {
            get => _digitManipulationOperation;
            set
            {
                DigitManipulationOperationSpecified = true;
                _digitManipulationOperation = value;
            }
        }

        [XmlIgnore]
        protected bool DigitManipulationOperationSpecified { get; set; }

        protected List<string> _routeGroupId = new List<string>();

        [XmlElement(ElementName = "routeGroupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1064")]
        [MinLength(1)]
        [MaxLength(30)]
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
        protected bool RouteGroupIdSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNTreatmentEntry> _treatment = new List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNTreatmentEntry>();

        [XmlElement(ElementName = "treatment", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1064")]
        public List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNTreatmentEntry> Treatment
        {
            get => _treatment;
            set
            {
                TreatmentSpecified = true;
                _treatment = value;
            }
        }

        [XmlIgnore]
        protected bool TreatmentSpecified { get; set; }

    }
}
