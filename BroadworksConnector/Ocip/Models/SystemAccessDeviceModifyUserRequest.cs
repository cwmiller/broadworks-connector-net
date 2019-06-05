using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccessDeviceModifyUserRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _deviceName;

    [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
    public string DeviceName {
        get => _deviceName;
        set {
            DeviceNameSpecified = true;
            _deviceName = value;
        }
    }

    [XmlIgnore]
    public bool DeviceNameSpecified { get; set; }
    private string _linePort;

    [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
    public string LinePort {
        get => _linePort;
        set {
            LinePortSpecified = true;
            _linePort = value;
        }
    }

    [XmlIgnore]
    public bool LinePortSpecified { get; set; }
    private string _privateIdentity;

    [XmlElement(ElementName = "privateIdentity", IsNullable = false, Namespace = "")]
    public string PrivateIdentity {
        get => _privateIdentity;
        set {
            PrivateIdentitySpecified = true;
            _privateIdentity = value;
        }
    }

    [XmlIgnore]
    public bool PrivateIdentitySpecified { get; set; }
    private bool _isPrimaryLinePort;

    [XmlElement(ElementName = "isPrimaryLinePort", IsNullable = false, Namespace = "")]
    public bool IsPrimaryLinePort {
        get => _isPrimaryLinePort;
        set {
            IsPrimaryLinePortSpecified = true;
            _isPrimaryLinePort = value;
        }
    }

    [XmlIgnore]
    public bool IsPrimaryLinePortSpecified { get; set; }
}
}
