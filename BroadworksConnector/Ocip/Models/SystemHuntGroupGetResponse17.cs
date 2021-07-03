using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemHuntGroupGetRequest.
    /// Replaced by: SystemHuntGroupGetResponse21 in AS data mode
    /// <see cref="SystemHuntGroupGetRequest"/>
    /// <see cref="SystemHuntGroupGetResponse21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:8331""}]")]
    public class SystemHuntGroupGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _anonymousInsteadOfPrivateCLID;

        [XmlElement(ElementName = "anonymousInsteadOfPrivateCLID", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:8331")]
        public bool AnonymousInsteadOfPrivateCLID
        {
            get => _anonymousInsteadOfPrivateCLID;
            set
            {
                AnonymousInsteadOfPrivateCLIDSpecified = true;
                _anonymousInsteadOfPrivateCLID = value;
            }
        }

        [XmlIgnore]
        protected bool AnonymousInsteadOfPrivateCLIDSpecified { get; set; }

        private bool _removeHuntGroupNameFromCLID;

        [XmlElement(ElementName = "removeHuntGroupNameFromCLID", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:8331")]
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
        protected bool RemoveHuntGroupNameFromCLIDSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.HuntGroupUniformCallDistributionPolicyScope _uniformCallDistributionPolicyScope;

        [XmlElement(ElementName = "uniformCallDistributionPolicyScope", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:8331")]
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
        protected bool UniformCallDistributionPolicyScopeSpecified { get; set; }

    }
}
