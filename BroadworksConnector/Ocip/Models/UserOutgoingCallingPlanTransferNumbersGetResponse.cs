using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserOutgoingCallingPlanTransferNumbersGetRequest.
        /// <see cref="UserOutgoingCallingPlanTransferNumbersGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserOutgoingCallingPlanTransferNumbersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _useCustomSettings;

        [XmlElement(ElementName = "useCustomSettings", IsNullable = false, Namespace = "")]
        public bool UseCustomSettings {
            get => _useCustomSettings;
            set {
                UseCustomSettingsSpecified = true;
                _useCustomSettings = value;
            }
        }

        [XmlIgnore]
        public bool UseCustomSettingsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbers _userNumbers;

        [XmlElement(ElementName = "userNumbers", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbers UserNumbers {
            get => _userNumbers;
            set {
                UserNumbersSpecified = true;
                _userNumbers = value;
            }
        }

        [XmlIgnore]
        public bool UserNumbersSpecified { get; set; }
        
    }
}
