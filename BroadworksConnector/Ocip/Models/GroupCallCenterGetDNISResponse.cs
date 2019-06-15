using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterGetDNISResponse.
        /// <see cref="GroupCallCenterGetDNISResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterGetDNISResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _dnisPhoneNumber;

        [XmlElement(ElementName = "dnisPhoneNumber", IsNullable = false, Namespace = "")]
        public string DnisPhoneNumber {
            get => _dnisPhoneNumber;
            set {
                DnisPhoneNumberSpecified = true;
                _dnisPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool DnisPhoneNumberSpecified { get; set; }
        
        private string _extension;

        [XmlElement(ElementName = "extension", IsNullable = false, Namespace = "")]
        public string Extension {
            get => _extension;
            set {
                ExtensionSpecified = true;
                _extension = value;
            }
        }

        [XmlIgnore]
        public bool ExtensionSpecified { get; set; }
        
        private bool _useCustomCLIDSettings;

        [XmlElement(ElementName = "useCustomCLIDSettings", IsNullable = false, Namespace = "")]
        public bool UseCustomCLIDSettings {
            get => _useCustomCLIDSettings;
            set {
                UseCustomCLIDSettingsSpecified = true;
                _useCustomCLIDSettings = value;
            }
        }

        [XmlIgnore]
        public bool UseCustomCLIDSettingsSpecified { get; set; }
        
        private string _callingLineIdPhoneNumber;

        [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = false, Namespace = "")]
        public string CallingLineIdPhoneNumber {
            get => _callingLineIdPhoneNumber;
            set {
                CallingLineIdPhoneNumberSpecified = true;
                _callingLineIdPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool CallingLineIdPhoneNumberSpecified { get; set; }
        
        private string _callingLineIdLastName;

        [XmlElement(ElementName = "callingLineIdLastName", IsNullable = false, Namespace = "")]
        public string CallingLineIdLastName {
            get => _callingLineIdLastName;
            set {
                CallingLineIdLastNameSpecified = true;
                _callingLineIdLastName = value;
            }
        }

        [XmlIgnore]
        public bool CallingLineIdLastNameSpecified { get; set; }
        
        private string _callingLineIdFirstName;

        [XmlElement(ElementName = "callingLineIdFirstName", IsNullable = false, Namespace = "")]
        public string CallingLineIdFirstName {
            get => _callingLineIdFirstName;
            set {
                CallingLineIdFirstNameSpecified = true;
                _callingLineIdFirstName = value;
            }
        }

        [XmlIgnore]
        public bool CallingLineIdFirstNameSpecified { get; set; }
        
        private bool _useCustomDnisAnnouncementSettings;

        [XmlElement(ElementName = "useCustomDnisAnnouncementSettings", IsNullable = false, Namespace = "")]
        public bool UseCustomDnisAnnouncementSettings {
            get => _useCustomDnisAnnouncementSettings;
            set {
                UseCustomDnisAnnouncementSettingsSpecified = true;
                _useCustomDnisAnnouncementSettings = value;
            }
        }

        [XmlIgnore]
        public bool UseCustomDnisAnnouncementSettingsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.DNISPriority _priority;

        [XmlElement(ElementName = "priority", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.DNISPriority Priority {
            get => _priority;
            set {
                PrioritySpecified = true;
                _priority = value;
            }
        }

        [XmlIgnore]
        public bool PrioritySpecified { get; set; }
        
        private bool _allowOutgoingACDCall;

        [XmlElement(ElementName = "allowOutgoingACDCall", IsNullable = false, Namespace = "")]
        public bool AllowOutgoingACDCall {
            get => _allowOutgoingACDCall;
            set {
                AllowOutgoingACDCallSpecified = true;
                _allowOutgoingACDCall = value;
            }
        }

        [XmlIgnore]
        public bool AllowOutgoingACDCallSpecified { get; set; }
        
    }
}
