using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a BroadWorks Anywhere instance.
    /// The following elements are only used in AS data mode:
    /// networkClassOfService
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""72f634ecc58842ce9d362ca629a47ea9:197""}]")]
    public class GroupBroadWorksAnywhereModifyInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:197")]
        [MinLength(1)]
        [MaxLength(161)]
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
        protected bool ServiceUserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:197")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile
        {
            get => _serviceInstanceProfile;
            set
            {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceInstanceProfileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.BroadWorksAnywhereScope _broadWorksAnywhereScope;

        [XmlElement(ElementName = "broadWorksAnywhereScope", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:197")]
        public BroadWorksConnector.Ocip.Models.BroadWorksAnywhereScope BroadWorksAnywhereScope
        {
            get => _broadWorksAnywhereScope;
            set
            {
                BroadWorksAnywhereScopeSpecified = true;
                _broadWorksAnywhereScope = value;
            }
        }

        [XmlIgnore]
        protected bool BroadWorksAnywhereScopeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.BroadWorksAnywhereCLIDPrompt _promptForCLID;

        [XmlElement(ElementName = "promptForCLID", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:197")]
        public BroadWorksConnector.Ocip.Models.BroadWorksAnywhereCLIDPrompt PromptForCLID
        {
            get => _promptForCLID;
            set
            {
                PromptForCLIDSpecified = true;
                _promptForCLID = value;
            }
        }

        [XmlIgnore]
        protected bool PromptForCLIDSpecified { get; set; }

        private bool _silentPromptMode;

        [XmlElement(ElementName = "silentPromptMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:197")]
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
        protected bool SilentPromptModeSpecified { get; set; }

        private bool _promptForPasscode;

        [XmlElement(ElementName = "promptForPasscode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:197")]
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
        protected bool PromptForPasscodeSpecified { get; set; }

        private string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:197")]
        [MinLength(1)]
        [MaxLength(40)]
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
        protected bool NetworkClassOfServiceSpecified { get; set; }

    }
}
