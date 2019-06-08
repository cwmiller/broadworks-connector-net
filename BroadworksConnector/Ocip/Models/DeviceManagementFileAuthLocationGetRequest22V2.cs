using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class DeviceManagementFileAuthLocationGetRequest22V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.DeviceAccessProtocol22 _deviceAccessProtocol;

    [XmlElement(ElementName = "deviceAccessProtocol", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DeviceAccessProtocol22 DeviceAccessProtocol {
        get => _deviceAccessProtocol;
        set {
            DeviceAccessProtocolSpecified = true;
            _deviceAccessProtocol = value;
        }
    }

    [XmlIgnore]
    public bool DeviceAccessProtocolSpecified { get; set; }
    private string _deviceAccessMethod;

    [XmlElement(ElementName = "deviceAccessMethod", IsNullable = false, Namespace = "")]
    public string DeviceAccessMethod {
        get => _deviceAccessMethod;
        set {
            DeviceAccessMethodSpecified = true;
            _deviceAccessMethod = value;
        }
    }

    [XmlIgnore]
    public bool DeviceAccessMethodSpecified { get; set; }
    private string _deviceAccessURI;

    [XmlElement(ElementName = "deviceAccessURI", IsNullable = false, Namespace = "")]
    public string DeviceAccessURI {
        get => _deviceAccessURI;
        set {
            DeviceAccessURISpecified = true;
            _deviceAccessURI = value;
        }
    }

    [XmlIgnore]
    public bool DeviceAccessURISpecified { get; set; }
    private string _accessDeviceUserName;

    [XmlElement(ElementName = "accessDeviceUserName", IsNullable = false, Namespace = "")]
    public string AccessDeviceUserName {
        get => _accessDeviceUserName;
        set {
            AccessDeviceUserNameSpecified = true;
            _accessDeviceUserName = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceUserNameSpecified { get; set; }
    private string _accessDeviceUserPassword;

    [XmlElement(ElementName = "accessDeviceUserPassword", IsNullable = false, Namespace = "")]
    public string AccessDeviceUserPassword {
        get => _accessDeviceUserPassword;
        set {
            AccessDeviceUserPasswordSpecified = true;
            _accessDeviceUserPassword = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceUserPasswordSpecified { get; set; }
    private string _deviceToken;

    [XmlElement(ElementName = "deviceToken", IsNullable = false, Namespace = "")]
    public string DeviceToken {
        get => _deviceToken;
        set {
            DeviceTokenSpecified = true;
            _deviceToken = value;
        }
    }

    [XmlIgnore]
    public bool DeviceTokenSpecified { get; set; }
    private string _signedPassword;

    [XmlElement(ElementName = "signedPassword", IsNullable = false, Namespace = "")]
    public string SignedPassword {
        get => _signedPassword;
        set {
            SignedPasswordSpecified = true;
            _signedPassword = value;
        }
    }

    [XmlIgnore]
    public bool SignedPasswordSpecified { get; set; }
    private string _macAddress;

    [XmlElement(ElementName = "macAddress", IsNullable = false, Namespace = "")]
    public string MacAddress {
        get => _macAddress;
        set {
            MacAddressSpecified = true;
            _macAddress = value;
        }
    }

    [XmlIgnore]
    public bool MacAddressSpecified { get; set; }
    private string _realmName;

    [XmlElement(ElementName = "realmName", IsNullable = false, Namespace = "")]
    public string RealmName {
        get => _realmName;
        set {
            RealmNameSpecified = true;
            _realmName = value;
        }
    }

    [XmlIgnore]
    public bool RealmNameSpecified { get; set; }
    private string _digestHa1Complement;

    [XmlElement(ElementName = "digestHa1Complement", IsNullable = false, Namespace = "")]
    public string DigestHa1Complement {
        get => _digestHa1Complement;
        set {
            DigestHa1ComplementSpecified = true;
            _digestHa1Complement = value;
        }
    }

    [XmlIgnore]
    public bool DigestHa1ComplementSpecified { get; set; }
    private string _digestResponse;

    [XmlElement(ElementName = "digestResponse", IsNullable = false, Namespace = "")]
    public string DigestResponse {
        get => _digestResponse;
        set {
            DigestResponseSpecified = true;
            _digestResponse = value;
        }
    }

    [XmlIgnore]
    public bool DigestResponseSpecified { get; set; }
    private bool _fileNameLookup;

    [XmlElement(ElementName = "fileNameLookup", IsNullable = false, Namespace = "")]
    public bool FileNameLookup {
        get => _fileNameLookup;
        set {
            FileNameLookupSpecified = true;
            _fileNameLookup = value;
        }
    }

    [XmlIgnore]
    public bool FileNameLookupSpecified { get; set; }
    private string _fileNameOnDisk;

    [XmlElement(ElementName = "fileNameOnDisk", IsNullable = false, Namespace = "")]
    public string FileNameOnDisk {
        get => _fileNameOnDisk;
        set {
            FileNameOnDiskSpecified = true;
            _fileNameOnDisk = value;
        }
    }

    [XmlIgnore]
    public bool FileNameOnDiskSpecified { get; set; }
}
}
