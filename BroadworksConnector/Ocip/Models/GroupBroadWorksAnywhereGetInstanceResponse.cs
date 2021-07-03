using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupBroadWorksAnywhereGetInstanceRequest.
    /// Contains the service profile information.
    /// <see cref="GroupBroadWorksAnywhereGetInstanceRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:3942""}]")]
    public class GroupBroadWorksAnywhereGetInstanceResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3942")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile ServiceInstanceProfile
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3942")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3942")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3942")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3942")]
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

    }
}
