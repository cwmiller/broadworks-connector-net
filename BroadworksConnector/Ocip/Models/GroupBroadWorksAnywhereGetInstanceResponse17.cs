using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupBroadWorksAnywhereGetInstanceRequest17.
    /// Contains the service profile information.
    /// 
    /// Replaced by: GroupBroadWorksAnywhereGetInstanceResponse19sp1 in AS data mode
        /// <see cref="GroupBroadWorksAnywhereGetInstanceRequest17"/>
        /// <see cref="GroupBroadWorksAnywhereGetInstanceResponse19sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupBroadWorksAnywhereGetInstanceResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile17 _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile17 ServiceInstanceProfile {
            get => _serviceInstanceProfile;
            set {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInstanceProfileSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.BroadWorksAnywhereScope _broadWorksAnywhereScope;

        [XmlElement(ElementName = "broadWorksAnywhereScope", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.BroadWorksAnywhereScope BroadWorksAnywhereScope {
            get => _broadWorksAnywhereScope;
            set {
                BroadWorksAnywhereScopeSpecified = true;
                _broadWorksAnywhereScope = value;
            }
        }

        [XmlIgnore]
        public bool BroadWorksAnywhereScopeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.BroadWorksAnywhereCLIDPrompt _promptForCLID;

        [XmlElement(ElementName = "promptForCLID", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.BroadWorksAnywhereCLIDPrompt PromptForCLID {
            get => _promptForCLID;
            set {
                PromptForCLIDSpecified = true;
                _promptForCLID = value;
            }
        }

        [XmlIgnore]
        public bool PromptForCLIDSpecified { get; set; }
        
        private bool _silentPromptMode;

        [XmlElement(ElementName = "silentPromptMode", IsNullable = false, Namespace = "")]
        public bool SilentPromptMode {
            get => _silentPromptMode;
            set {
                SilentPromptModeSpecified = true;
                _silentPromptMode = value;
            }
        }

        [XmlIgnore]
        public bool SilentPromptModeSpecified { get; set; }
        
        private bool _promptForPasscode;

        [XmlElement(ElementName = "promptForPasscode", IsNullable = false, Namespace = "")]
        public bool PromptForPasscode {
            get => _promptForPasscode;
            set {
                PromptForPasscodeSpecified = true;
                _promptForPasscode = value;
            }
        }

        [XmlIgnore]
        public bool PromptForPasscodeSpecified { get; set; }
        
    }
}
