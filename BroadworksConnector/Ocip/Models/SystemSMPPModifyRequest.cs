using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the system level data associated with the SMPP external interface.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:16913""}]")]
    public class SystemSMPPModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _primarySMPPServerNetAddress;

        [XmlElement(ElementName = "primarySMPPServerNetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16913")]
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

        private int _primarySMPPPort;

        [XmlElement(ElementName = "primarySMPPPort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16913")]
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

        private string _secondarySMPPServerNetAddress;

        [XmlElement(ElementName = "secondarySMPPServerNetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16913")]
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

        private int _secondarySMPPPort;

        [XmlElement(ElementName = "secondarySMPPPort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16913")]
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

        private string _systemId;

        [XmlElement(ElementName = "systemId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16913")]
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

        private string _password;

        [XmlElement(ElementName = "password", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16913")]
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

        private BroadWorksConnector.Ocip.Models.SMPPVersion _version;

        [XmlElement(ElementName = "version", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16913")]
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

        private string _systemType;

        [XmlElement(ElementName = "systemType", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16913")]
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

        private bool _enableMWICustomizedMessage;

        [XmlElement(ElementName = "enableMWICustomizedMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16913")]
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

        private bool _supportMessagePayload;

        [XmlElement(ElementName = "supportMessagePayload", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16913")]
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

        private int _maxShortMessageLength;

        [XmlElement(ElementName = "maxShortMessageLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16913")]
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

        private bool _useGsmMwiUcs2Encoding;

        [XmlElement(ElementName = "useGsmMwiUcs2Encoding", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16913")]
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

        private bool _includeOnlyNewMessageCount;

        [XmlElement(ElementName = "includeOnlyNewMessageCount", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16913")]
        public bool IncludeOnlyNewMessageCount
        {
            get => _includeOnlyNewMessageCount;
            set
            {
                IncludeOnlyNewMessageCountSpecified = true;
                _includeOnlyNewMessageCount = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeOnlyNewMessageCountSpecified { get; set; }

    }
}
