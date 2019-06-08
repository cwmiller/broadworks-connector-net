using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMailParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _primaryServerNetAddress;

    [XmlElement(ElementName = "primaryServerNetAddress", IsNullable = true, Namespace = "")]
    public string PrimaryServerNetAddress {
        get => _primaryServerNetAddress;
        set {
            PrimaryServerNetAddressSpecified = true;
            _primaryServerNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool PrimaryServerNetAddressSpecified { get; set; }
    private string _secondaryServerNetAddress;

    [XmlElement(ElementName = "secondaryServerNetAddress", IsNullable = true, Namespace = "")]
    public string SecondaryServerNetAddress {
        get => _secondaryServerNetAddress;
        set {
            SecondaryServerNetAddressSpecified = true;
            _secondaryServerNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool SecondaryServerNetAddressSpecified { get; set; }
    private string _defaultFromAddress;

    [XmlElement(ElementName = "defaultFromAddress", IsNullable = false, Namespace = "")]
    public string DefaultFromAddress {
        get => _defaultFromAddress;
        set {
            DefaultFromAddressSpecified = true;
            _defaultFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool DefaultFromAddressSpecified { get; set; }
    private string _defaultSubject;

    [XmlElement(ElementName = "defaultSubject", IsNullable = true, Namespace = "")]
    public string DefaultSubject {
        get => _defaultSubject;
        set {
            DefaultSubjectSpecified = true;
            _defaultSubject = value;
        }
    }

    [XmlIgnore]
    public bool DefaultSubjectSpecified { get; set; }
    private bool _supportDNSSRVForMailServerAccess;

    [XmlElement(ElementName = "supportDNSSRVForMailServerAccess", IsNullable = false, Namespace = "")]
    public bool SupportDNSSRVForMailServerAccess {
        get => _supportDNSSRVForMailServerAccess;
        set {
            SupportDNSSRVForMailServerAccessSpecified = true;
            _supportDNSSRVForMailServerAccess = value;
        }
    }

    [XmlIgnore]
    public bool SupportDNSSRVForMailServerAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SMTPSecureMode _secureMode;

    [XmlElement(ElementName = "secureMode", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SMTPSecureMode SecureMode {
        get => _secureMode;
        set {
            SecureModeSpecified = true;
            _secureMode = value;
        }
    }

    [XmlIgnore]
    public bool SecureModeSpecified { get; set; }
    private int? _port;

    [XmlElement(ElementName = "port", IsNullable = true, Namespace = "")]
    public int? Port {
        get => _port;
        set {
            PortSpecified = true;
            _port = value;
        }
    }

    [XmlIgnore]
    public bool PortSpecified { get; set; }
}
}
