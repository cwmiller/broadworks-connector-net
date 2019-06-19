using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Hunt Group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""bc829065f9d696d3ca7084121d57f8c0:612""}]")]
    public class SystemHuntGroupModifyRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _removeHuntGroupNameFromCLID;

        [XmlElement(ElementName = "removeHuntGroupNameFromCLID", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:612")]
        public bool RemoveHuntGroupNameFromCLID
        {
            get => _removeHuntGroupNameFromCLID;
            set
            {
                RemoveHuntGroupNameFromCLIDSpecified = true;
                _removeHuntGroupNameFromCLID = value;
            }
        }

        [XmlIgnore]
        public bool RemoveHuntGroupNameFromCLIDSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.HuntGroupUniformCallDistributionPolicyScope _uniformCallDistributionPolicyScope;

        [XmlElement(ElementName = "uniformCallDistributionPolicyScope", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:612")]
        public BroadWorksConnector.Ocip.Models.HuntGroupUniformCallDistributionPolicyScope UniformCallDistributionPolicyScope
        {
            get => _uniformCallDistributionPolicyScope;
            set
            {
                UniformCallDistributionPolicyScopeSpecified = true;
                _uniformCallDistributionPolicyScope = value;
            }
        }

        [XmlIgnore]
        public bool UniformCallDistributionPolicyScopeSpecified { get; set; }

        private bool _allowAgentDeviceInitiatedForward;

        [XmlElement(ElementName = "allowAgentDeviceInitiatedForward", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:612")]
        public bool AllowAgentDeviceInitiatedForward
        {
            get => _allowAgentDeviceInitiatedForward;
            set
            {
                AllowAgentDeviceInitiatedForwardSpecified = true;
                _allowAgentDeviceInitiatedForward = value;
            }
        }

        [XmlIgnore]
        public bool AllowAgentDeviceInitiatedForwardSpecified { get; set; }

    }
}
