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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18021""}]")]
    public class SystemSMPPModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _primarySMPPServerNetAddress;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "primarySMPPServerNetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18021")]
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

        protected int? _primarySMPPPort;

        [XmlElement(ElementName = "primarySMPPPort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18021")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int? PrimarySMPPPort
        {
            get => _primarySMPPPort;
            set
            {
                PrimarySMPPPortSpecified = (value != null);
                _primarySMPPPort = value;
            }
        }

        [XmlIgnore]
        protected bool PrimarySMPPPortSpecified { get; set; }

        protected string _secondarySMPPServerNetAddress;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "secondarySMPPServerNetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18021")]
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

        protected int? _secondarySMPPPort;

        [XmlElement(ElementName = "secondarySMPPPort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18021")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int? SecondarySMPPPort
        {
            get => _secondarySMPPPort;
            set
            {
                SecondarySMPPPortSpecified = (value != null);
                _secondarySMPPPort = value;
            }
        }

        [XmlIgnore]
        protected bool SecondarySMPPPortSpecified { get; set; }

        protected string _systemId;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "systemId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18021")]
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

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "password", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18021")]
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

        protected BroadWorksConnector.Ocip.Models.SMPPVersion? _version;

        [XmlElement(ElementName = "version", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18021")]
        public BroadWorksConnector.Ocip.Models.SMPPVersion? Version
        {
            get => _version;
            set
            {
                VersionSpecified = (value != null);
                _version = value;
            }
        }

        [XmlIgnore]
        protected bool VersionSpecified { get; set; }

        protected string _systemType;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "systemType", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18021")]
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

        protected bool? _enableMWICustomizedMessage;

        [XmlElement(ElementName = "enableMWICustomizedMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18021")]
        public bool? EnableMWICustomizedMessage
        {
            get => _enableMWICustomizedMessage;
            set
            {
                EnableMWICustomizedMessageSpecified = (value != null);
                _enableMWICustomizedMessage = value;
            }
        }

        [XmlIgnore]
        protected bool EnableMWICustomizedMessageSpecified { get; set; }

        protected bool? _supportMessagePayload;

        [XmlElement(ElementName = "supportMessagePayload", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18021")]
        public bool? SupportMessagePayload
        {
            get => _supportMessagePayload;
            set
            {
                SupportMessagePayloadSpecified = (value != null);
                _supportMessagePayload = value;
            }
        }

        [XmlIgnore]
        protected bool SupportMessagePayloadSpecified { get; set; }

        protected int? _maxShortMessageLength;

        [XmlElement(ElementName = "maxShortMessageLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18021")]
        [MinInclusive(1)]
        [MaxInclusive(70)]
        public int? MaxShortMessageLength
        {
            get => _maxShortMessageLength;
            set
            {
                MaxShortMessageLengthSpecified = (value != null);
                _maxShortMessageLength = value;
            }
        }

        [XmlIgnore]
        protected bool MaxShortMessageLengthSpecified { get; set; }

        protected bool? _useGsmMwiUcs2Encoding;

        [XmlElement(ElementName = "useGsmMwiUcs2Encoding", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18021")]
        public bool? UseGsmMwiUcs2Encoding
        {
            get => _useGsmMwiUcs2Encoding;
            set
            {
                UseGsmMwiUcs2EncodingSpecified = (value != null);
                _useGsmMwiUcs2Encoding = value;
            }
        }

        [XmlIgnore]
        protected bool UseGsmMwiUcs2EncodingSpecified { get; set; }

        protected bool? _includeOnlyNewMessageCount;

        [XmlElement(ElementName = "includeOnlyNewMessageCount", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18021")]
        public bool? IncludeOnlyNewMessageCount
        {
            get => _includeOnlyNewMessageCount;
            set
            {
                IncludeOnlyNewMessageCountSpecified = (value != null);
                _includeOnlyNewMessageCount = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeOnlyNewMessageCountSpecified { get; set; }

    }
}
