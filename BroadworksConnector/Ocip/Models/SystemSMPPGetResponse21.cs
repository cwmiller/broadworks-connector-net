using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSMPPGetRequest21.
    /// 
    /// The following elements are only used in AS data mode:
    /// primarySMPPServerNetAddress, value "" is returned in Amplify data mode
    /// primarySMPPPort, value "2775" is returned in Amplify data mode
    /// secondarySMPPServerNetAddress, value "" is returned in Amplify mode
    /// secondarySMPPPort, value "2775" is returned in Amplify data mode
    /// systemId, value "" is returned in Amplify data mode
    /// password, value "" is returned in Amplify mode
    /// version, value "" is returned in Amplify data mode
    /// systemType, value "VMS" is returned in Amplify mode
    /// useGsmMwiUcs2Encoding, value "true" is returned in Amplify mode
    /// <see cref="SystemSMPPGetRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:11578""}]")]
    public class SystemSMPPGetResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _primarySMPPServerNetAddress;

        [XmlElement(ElementName = "primarySMPPServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:11578")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PrimarySMPPServerNetAddress
        {
            get => _primarySMPPServerNetAddress;
            set
            {
                PrimarySMPPServerNetAddressSpecified = true;
                _primarySMPPServerNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool PrimarySMPPServerNetAddressSpecified { get; set; }

        protected int _primarySMPPPort;

        [XmlElement(ElementName = "primarySMPPPort", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:11578")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int PrimarySMPPPort
        {
            get => _primarySMPPPort;
            set
            {
                PrimarySMPPPortSpecified = true;
                _primarySMPPPort = value;
            }
        }

        [XmlIgnore]
        protected bool PrimarySMPPPortSpecified { get; set; }

        protected string _secondarySMPPServerNetAddress;

        [XmlElement(ElementName = "secondarySMPPServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:11578")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SecondarySMPPServerNetAddress
        {
            get => _secondarySMPPServerNetAddress;
            set
            {
                SecondarySMPPServerNetAddressSpecified = true;
                _secondarySMPPServerNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool SecondarySMPPServerNetAddressSpecified { get; set; }

        protected int _secondarySMPPPort;

        [XmlElement(ElementName = "secondarySMPPPort", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:11578")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int SecondarySMPPPort
        {
            get => _secondarySMPPPort;
            set
            {
                SecondarySMPPPortSpecified = true;
                _secondarySMPPPort = value;
            }
        }

        [XmlIgnore]
        protected bool SecondarySMPPPortSpecified { get; set; }

        protected string _systemId;

        [XmlElement(ElementName = "systemId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:11578")]
        [MinLength(1)]
        [MaxLength(16)]
        public string SystemId
        {
            get => _systemId;
            set
            {
                SystemIdSpecified = true;
                _systemId = value;
            }
        }

        [XmlIgnore]
        protected bool SystemIdSpecified { get; set; }

        protected string _password;

        [XmlElement(ElementName = "password", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:11578")]
        [MinLength(1)]
        [MaxLength(8)]
        public string Password
        {
            get => _password;
            set
            {
                PasswordSpecified = true;
                _password = value;
            }
        }

        [XmlIgnore]
        protected bool PasswordSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SMPPVersion _version;

        [XmlElement(ElementName = "version", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:11578")]
        public BroadWorksConnector.Ocip.Models.SMPPVersion Version
        {
            get => _version;
            set
            {
                VersionSpecified = true;
                _version = value;
            }
        }

        [XmlIgnore]
        protected bool VersionSpecified { get; set; }

        protected string _systemType;

        [XmlElement(ElementName = "systemType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:11578")]
        [MinLength(1)]
        [MaxLength(12)]
        public string SystemType
        {
            get => _systemType;
            set
            {
                SystemTypeSpecified = true;
                _systemType = value;
            }
        }

        [XmlIgnore]
        protected bool SystemTypeSpecified { get; set; }

        protected bool _enableMWICustomizedMessage;

        [XmlElement(ElementName = "enableMWICustomizedMessage", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:11578")]
        public bool EnableMWICustomizedMessage
        {
            get => _enableMWICustomizedMessage;
            set
            {
                EnableMWICustomizedMessageSpecified = true;
                _enableMWICustomizedMessage = value;
            }
        }

        [XmlIgnore]
        protected bool EnableMWICustomizedMessageSpecified { get; set; }

        protected bool _supportMessagePayload;

        [XmlElement(ElementName = "supportMessagePayload", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:11578")]
        public bool SupportMessagePayload
        {
            get => _supportMessagePayload;
            set
            {
                SupportMessagePayloadSpecified = true;
                _supportMessagePayload = value;
            }
        }

        [XmlIgnore]
        protected bool SupportMessagePayloadSpecified { get; set; }

        protected int _maxShortMessageLength;

        [XmlElement(ElementName = "maxShortMessageLength", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:11578")]
        [MinInclusive(1)]
        [MaxInclusive(70)]
        public int MaxShortMessageLength
        {
            get => _maxShortMessageLength;
            set
            {
                MaxShortMessageLengthSpecified = true;
                _maxShortMessageLength = value;
            }
        }

        [XmlIgnore]
        protected bool MaxShortMessageLengthSpecified { get; set; }

        protected bool _useGsmMwiUcs2Encoding;

        [XmlElement(ElementName = "useGsmMwiUcs2Encoding", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:11578")]
        public bool UseGsmMwiUcs2Encoding
        {
            get => _useGsmMwiUcs2Encoding;
            set
            {
                UseGsmMwiUcs2EncodingSpecified = true;
                _useGsmMwiUcs2Encoding = value;
            }
        }

        [XmlIgnore]
        protected bool UseGsmMwiUcs2EncodingSpecified { get; set; }

    }
}
