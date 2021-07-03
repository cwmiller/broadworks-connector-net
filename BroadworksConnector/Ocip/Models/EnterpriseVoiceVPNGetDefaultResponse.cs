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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:1404""}]")]
    public class EnterpriseVoiceVPNGetDefaultResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection> _policySelection = new List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection>();

        [XmlElement(ElementName = "policySelection", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1404")]
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

        private List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperation> _digitManipulationOperation = new List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperation>();

        [XmlElement(ElementName = "digitManipulationOperation", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1404")]
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

        private List<string> _routeGroupId = new List<string>();

        [XmlElement(ElementName = "routeGroupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1404")]
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

        private List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNTreatmentEntry> _treatment = new List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNTreatmentEntry>();

        [XmlElement(ElementName = "treatment", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1404")]
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
