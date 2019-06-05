using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobileManagerModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _scfApiNetAddress1;

    [XmlElement(ElementName = "scfApiNetAddress1", IsNullable = true, Namespace = "")]
    public string ScfApiNetAddress1 {
        get => _scfApiNetAddress1;
        set {
            ScfApiNetAddress1Specified = true;
            _scfApiNetAddress1 = value;
        }
    }

    [XmlIgnore]
    public bool ScfApiNetAddress1Specified { get; set; }
    private string _scfApiNetAddress2;

    [XmlElement(ElementName = "scfApiNetAddress2", IsNullable = true, Namespace = "")]
    public string ScfApiNetAddress2 {
        get => _scfApiNetAddress2;
        set {
            ScfApiNetAddress2Specified = true;
            _scfApiNetAddress2 = value;
        }
    }

    [XmlIgnore]
    public bool ScfApiNetAddress2Specified { get; set; }
    private string _userName;

    [XmlElement(ElementName = "userName", IsNullable = true, Namespace = "")]
    public string UserName {
        get => _userName;
        set {
            UserNameSpecified = true;
            _userName = value;
        }
    }

    [XmlIgnore]
    public bool UserNameSpecified { get; set; }
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
    private string _emailFromAddress;

    [XmlElement(ElementName = "emailFromAddress", IsNullable = true, Namespace = "")]
    public string EmailFromAddress {
        get => _emailFromAddress;
        set {
            EmailFromAddressSpecified = true;
            _emailFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool EmailFromAddressSpecified { get; set; }
    private bool _scfIMSOnly;

    [XmlElement(ElementName = "scfIMSOnly", IsNullable = false, Namespace = "")]
    public bool ScfIMSOnly {
        get => _scfIMSOnly;
        set {
            ScfIMSOnlySpecified = true;
            _scfIMSOnly = value;
        }
    }

    [XmlIgnore]
    public bool ScfIMSOnlySpecified { get; set; }
    private string _signalingIPAddress;

    [XmlElement(ElementName = "signalingIPAddress", IsNullable = true, Namespace = "")]
    public string SignalingIPAddress {
        get => _signalingIPAddress;
        set {
            SignalingIPAddressSpecified = true;
            _signalingIPAddress = value;
        }
    }

    [XmlIgnore]
    public bool SignalingIPAddressSpecified { get; set; }
    private int? _signalingPort;

    [XmlElement(ElementName = "signalingPort", IsNullable = true, Namespace = "")]
    public int? SignalingPort {
        get => _signalingPort;
        set {
            SignalingPortSpecified = true;
            _signalingPort = value;
        }
    }

    [XmlIgnore]
    public bool SignalingPortSpecified { get; set; }
}
}
