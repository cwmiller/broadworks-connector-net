using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemHuntGroupGetRequest21.
    /// <see cref="SystemHuntGroupGetRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""bc829065f9d696d3ca7084121d57f8c0:594""}]")]
    public class SystemHuntGroupGetResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _removeHuntGroupNameFromCLID;

        [XmlElement(ElementName = "removeHuntGroupNameFromCLID", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:594")]
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
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:594")]
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
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:594")]
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
