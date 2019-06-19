using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a call center's DNIS settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:5184""}]")]
    public class GroupCallCenterModifyDNISRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.DNISKey _dnisKey;

        [XmlElement(ElementName = "dnisKey", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5184")]
        public BroadWorksConnector.Ocip.Models.DNISKey DnisKey
        {
            get => _dnisKey;
            set
            {
                DnisKeySpecified = true;
                _dnisKey = value;
            }
        }

        [XmlIgnore]
        public bool DnisKeySpecified { get; set; }

        private string _newDNISName;

        [XmlElement(ElementName = "newDNISName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5184")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NewDNISName
        {
            get => _newDNISName;
            set
            {
                NewDNISNameSpecified = true;
                _newDNISName = value;
            }
        }

        [XmlIgnore]
        public bool NewDNISNameSpecified { get; set; }

        private string _dnisPhoneNumber;

        [XmlElement(ElementName = "dnisPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5184")]
        [MinLength(1)]
        [MaxLength(23)]
        public string DnisPhoneNumber
        {
            get => _dnisPhoneNumber;
            set
            {
                DnisPhoneNumberSpecified = true;
                _dnisPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool DnisPhoneNumberSpecified { get; set; }

        private string _extension;

        [XmlElement(ElementName = "extension", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5184")]
        [MinLength(2)]
        [MaxLength(20)]
        public string Extension
        {
            get => _extension;
            set
            {
                ExtensionSpecified = true;
                _extension = value;
            }
        }

        [XmlIgnore]
        public bool ExtensionSpecified { get; set; }

        private bool _useCustomCLIDSettings;

        [XmlElement(ElementName = "useCustomCLIDSettings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5184")]
        public bool UseCustomCLIDSettings
        {
            get => _useCustomCLIDSettings;
            set
            {
                UseCustomCLIDSettingsSpecified = true;
                _useCustomCLIDSettings = value;
            }
        }

        [XmlIgnore]
        public bool UseCustomCLIDSettingsSpecified { get; set; }

        private string _callingLineIdPhoneNumber;

        [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5184")]
        [MinLength(1)]
        [MaxLength(23)]
        public string CallingLineIdPhoneNumber
        {
            get => _callingLineIdPhoneNumber;
            set
            {
                CallingLineIdPhoneNumberSpecified = true;
                _callingLineIdPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool CallingLineIdPhoneNumberSpecified { get; set; }

        private string _callingLineIdLastName;

        [XmlElement(ElementName = "callingLineIdLastName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5184")]
        [MinLength(1)]
        [MaxLength(30)]
        public string CallingLineIdLastName
        {
            get => _callingLineIdLastName;
            set
            {
                CallingLineIdLastNameSpecified = true;
                _callingLineIdLastName = value;
            }
        }

        [XmlIgnore]
        public bool CallingLineIdLastNameSpecified { get; set; }

        private string _callingLineIdFirstName;

        [XmlElement(ElementName = "callingLineIdFirstName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5184")]
        [MinLength(1)]
        [MaxLength(30)]
        public string CallingLineIdFirstName
        {
            get => _callingLineIdFirstName;
            set
            {
                CallingLineIdFirstNameSpecified = true;
                _callingLineIdFirstName = value;
            }
        }

        [XmlIgnore]
        public bool CallingLineIdFirstNameSpecified { get; set; }

        private bool _useCustomDnisAnnouncementSettings;

        [XmlElement(ElementName = "useCustomDnisAnnouncementSettings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5184")]
        public bool UseCustomDnisAnnouncementSettings
        {
            get => _useCustomDnisAnnouncementSettings;
            set
            {
                UseCustomDnisAnnouncementSettingsSpecified = true;
                _useCustomDnisAnnouncementSettings = value;
            }
        }

        [XmlIgnore]
        public bool UseCustomDnisAnnouncementSettingsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DNISPriority _priority;

        [XmlElement(ElementName = "priority", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5184")]
        public BroadWorksConnector.Ocip.Models.DNISPriority Priority
        {
            get => _priority;
            set
            {
                PrioritySpecified = true;
                _priority = value;
            }
        }

        [XmlIgnore]
        public bool PrioritySpecified { get; set; }

        private bool _allowOutgoingACDCall;

        [XmlElement(ElementName = "allowOutgoingACDCall", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5184")]
        public bool AllowOutgoingACDCall
        {
            get => _allowOutgoingACDCall;
            set
            {
                AllowOutgoingACDCallSpecified = true;
                _allowOutgoingACDCall = value;
            }
        }

        [XmlIgnore]
        public bool AllowOutgoingACDCallSpecified { get; set; }

    }
}
