using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupBroadWorksAnywhereAddInstanceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
    {
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.ServiceInstanceAddProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.ServiceInstanceAddProfile ServiceInstanceProfile
        {
            get => _serviceInstanceProfile;
            set
            {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInstanceProfileSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.BroadWorksAnywhereScope _broadWorksAnywhereScope;

        [XmlElement(ElementName = "broadWorksAnywhereScope", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.BroadWorksAnywhereScope BroadWorksAnywhereScope
        {
            get => _broadWorksAnywhereScope;
            set
            {
                BroadWorksAnywhereScopeSpecified = true;
                _broadWorksAnywhereScope = value;
            }
        }

        [XmlIgnore]
        public bool BroadWorksAnywhereScopeSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.BroadWorksAnywhereCLIDPrompt _promptForCLID;

        [XmlElement(ElementName = "promptForCLID", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.BroadWorksAnywhereCLIDPrompt PromptForCLID
        {
            get => _promptForCLID;
            set
            {
                PromptForCLIDSpecified = true;
                _promptForCLID = value;
            }
        }

        [XmlIgnore]
        public bool PromptForCLIDSpecified { get; set; }
        private bool _silentPromptMode;

        [XmlElement(ElementName = "silentPromptMode", IsNullable = false, Namespace = "")]
        public bool SilentPromptMode
        {
            get => _silentPromptMode;
            set
            {
                SilentPromptModeSpecified = true;
                _silentPromptMode = value;
            }
        }

        [XmlIgnore]
        public bool SilentPromptModeSpecified { get; set; }
        private bool _promptForPasscode;

        [XmlElement(ElementName = "promptForPasscode", IsNullable = false, Namespace = "")]
        public bool PromptForPasscode
        {
            get => _promptForPasscode;
            set
            {
                PromptForPasscodeSpecified = true;
                _promptForPasscode = value;
            }
        }

        [XmlIgnore]
        public bool PromptForPasscodeSpecified { get; set; }
        private string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        public string NetworkClassOfService
        {
            get => _networkClassOfService;
            set
            {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        public bool NetworkClassOfServiceSpecified { get; set; }
    }
}
