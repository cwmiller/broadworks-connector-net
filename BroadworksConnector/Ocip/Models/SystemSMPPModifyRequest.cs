using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSMPPModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _primarySMPPServerNetAddress;

    [XmlElement(ElementName = "primarySMPPServerNetAddress", IsNullable = true, Namespace = "")]
    public string PrimarySMPPServerNetAddress {
        get => _primarySMPPServerNetAddress;
        set {
            PrimarySMPPServerNetAddressSpecified = true;
            _primarySMPPServerNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool PrimarySMPPServerNetAddressSpecified { get; set; }
    private int _primarySMPPPort;

    [XmlElement(ElementName = "primarySMPPPort", IsNullable = false, Namespace = "")]
    public int PrimarySMPPPort {
        get => _primarySMPPPort;
        set {
            PrimarySMPPPortSpecified = true;
            _primarySMPPPort = value;
        }
    }

    [XmlIgnore]
    public bool PrimarySMPPPortSpecified { get; set; }
    private string _secondarySMPPServerNetAddress;

    [XmlElement(ElementName = "secondarySMPPServerNetAddress", IsNullable = true, Namespace = "")]
    public string SecondarySMPPServerNetAddress {
        get => _secondarySMPPServerNetAddress;
        set {
            SecondarySMPPServerNetAddressSpecified = true;
            _secondarySMPPServerNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool SecondarySMPPServerNetAddressSpecified { get; set; }
    private int _secondarySMPPPort;

    [XmlElement(ElementName = "secondarySMPPPort", IsNullable = false, Namespace = "")]
    public int SecondarySMPPPort {
        get => _secondarySMPPPort;
        set {
            SecondarySMPPPortSpecified = true;
            _secondarySMPPPort = value;
        }
    }

    [XmlIgnore]
    public bool SecondarySMPPPortSpecified { get; set; }
    private string _systemId;

    [XmlElement(ElementName = "systemId", IsNullable = true, Namespace = "")]
    public string SystemId {
        get => _systemId;
        set {
            SystemIdSpecified = true;
            _systemId = value;
        }
    }

    [XmlIgnore]
    public bool SystemIdSpecified { get; set; }
    private string _password;

    [XmlElement(ElementName = "password", IsNullable = true, Namespace = "")]
    public string Password {
        get => _password;
        set {
            PasswordSpecified = true;
            _password = value;
        }
    }

    [XmlIgnore]
    public bool PasswordSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SMPPVersion _version;

    [XmlElement(ElementName = "version", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SMPPVersion Version {
        get => _version;
        set {
            VersionSpecified = true;
            _version = value;
        }
    }

    [XmlIgnore]
    public bool VersionSpecified { get; set; }
    private string _systemType;

    [XmlElement(ElementName = "systemType", IsNullable = true, Namespace = "")]
    public string SystemType {
        get => _systemType;
        set {
            SystemTypeSpecified = true;
            _systemType = value;
        }
    }

    [XmlIgnore]
    public bool SystemTypeSpecified { get; set; }
    private bool _enableMWICustomizedMessage;

    [XmlElement(ElementName = "enableMWICustomizedMessage", IsNullable = false, Namespace = "")]
    public bool EnableMWICustomizedMessage {
        get => _enableMWICustomizedMessage;
        set {
            EnableMWICustomizedMessageSpecified = true;
            _enableMWICustomizedMessage = value;
        }
    }

    [XmlIgnore]
    public bool EnableMWICustomizedMessageSpecified { get; set; }
    private bool _supportMessagePayload;

    [XmlElement(ElementName = "supportMessagePayload", IsNullable = false, Namespace = "")]
    public bool SupportMessagePayload {
        get => _supportMessagePayload;
        set {
            SupportMessagePayloadSpecified = true;
            _supportMessagePayload = value;
        }
    }

    [XmlIgnore]
    public bool SupportMessagePayloadSpecified { get; set; }
    private int _maxShortMessageLength;

    [XmlElement(ElementName = "maxShortMessageLength", IsNullable = false, Namespace = "")]
    public int MaxShortMessageLength {
        get => _maxShortMessageLength;
        set {
            MaxShortMessageLengthSpecified = true;
            _maxShortMessageLength = value;
        }
    }

    [XmlIgnore]
    public bool MaxShortMessageLengthSpecified { get; set; }
    private bool _useGsmMwiUcs2Encoding;

    [XmlElement(ElementName = "useGsmMwiUcs2Encoding", IsNullable = false, Namespace = "")]
    public bool UseGsmMwiUcs2Encoding {
        get => _useGsmMwiUcs2Encoding;
        set {
            UseGsmMwiUcs2EncodingSpecified = true;
            _useGsmMwiUcs2Encoding = value;
        }
    }

    [XmlIgnore]
    public bool UseGsmMwiUcs2EncodingSpecified { get; set; }
    private bool _includeOnlyNewMessageCount;

    [XmlElement(ElementName = "includeOnlyNewMessageCount", IsNullable = false, Namespace = "")]
    public bool IncludeOnlyNewMessageCount {
        get => _includeOnlyNewMessageCount;
        set {
            IncludeOnlyNewMessageCountSpecified = true;
            _includeOnlyNewMessageCount = value;
        }
    }

    [XmlIgnore]
    public bool IncludeOnlyNewMessageCountSpecified { get; set; }
}
}
