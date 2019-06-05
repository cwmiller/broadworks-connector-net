using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSMPPGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _primarySMPPServerNetAddress;

    [XmlElement(ElementName = "primarySMPPServerNetAddress", IsNullable = false, Namespace = "")]
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

    [XmlElement(ElementName = "secondarySMPPServerNetAddress", IsNullable = false, Namespace = "")]
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

    [XmlElement(ElementName = "systemId", IsNullable = false, Namespace = "")]
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

    [XmlElement(ElementName = "password", IsNullable = false, Namespace = "")]
    public string Password {
        get => _password;
        set {
            PasswordSpecified = true;
            _password = value;
        }
    }

    [XmlIgnore]
    public bool PasswordSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SMPPVersion _version;

    [XmlElement(ElementName = "version", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SMPPVersion Version {
        get => _version;
        set {
            VersionSpecified = true;
            _version = value;
        }
    }

    [XmlIgnore]
    public bool VersionSpecified { get; set; }
}
}
