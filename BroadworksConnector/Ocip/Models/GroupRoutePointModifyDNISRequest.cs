using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a route point's DNIS settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupRoutePointModifyDNISRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private BroadWorksConnector.Ocip.Models.DNISKey _dnisKey;

        [XmlElement(ElementName = "dnisKey", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.DNISKey DnisKey {
            get => _dnisKey;
            set {
                DnisKeySpecified = true;
                _dnisKey = value;
            }
        }

        [XmlIgnore]
        public bool DnisKeySpecified { get; set; }
        
        private string _newDNISName;

        [XmlElement(ElementName = "newDNISName", IsNullable = false, Namespace = "")]
        public string NewDNISName {
            get => _newDNISName;
            set {
                NewDNISNameSpecified = true;
                _newDNISName = value;
            }
        }

        [XmlIgnore]
        public bool NewDNISNameSpecified { get; set; }
        
        private string _dnisPhoneNumber;

        [XmlElement(ElementName = "dnisPhoneNumber", IsNullable = true, Namespace = "")]
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

        [XmlElement(ElementName = "extension", IsNullable = true, Namespace = "")]
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

        [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = true, Namespace = "")]
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

        [XmlElement(ElementName = "callingLineIdLastName", IsNullable = true, Namespace = "")]
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

        [XmlElement(ElementName = "callingLineIdFirstName", IsNullable = true, Namespace = "")]
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
