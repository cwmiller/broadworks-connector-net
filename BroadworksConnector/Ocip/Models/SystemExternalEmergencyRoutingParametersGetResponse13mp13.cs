using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemExternalEmergencyRoutingParametersGetResponse13mp13 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _serviceURI;

    [XmlElement(ElementName = "serviceURI", IsNullable = false, Namespace = "")]
    public string ServiceURI {
        get => _serviceURI;
        set {
            ServiceURISpecified = true;
            _serviceURI = value;
        }
    }

    [XmlIgnore]
    public bool ServiceURISpecified { get; set; }
    private string _defaultEmergencyNumber;

    [XmlElement(ElementName = "defaultEmergencyNumber", IsNullable = false, Namespace = "")]
    public string DefaultEmergencyNumber {
        get => _defaultEmergencyNumber;
        set {
            DefaultEmergencyNumberSpecified = true;
            _defaultEmergencyNumber = value;
        }
    }

    [XmlIgnore]
    public bool DefaultEmergencyNumberSpecified { get; set; }
    private bool _isActive;

    [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
    public bool IsActive {
        get => _isActive;
        set {
            IsActiveSpecified = true;
            _isActive = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveSpecified { get; set; }
    private bool _supportsDNSSRV;

    [XmlElement(ElementName = "supportsDNSSRV", IsNullable = false, Namespace = "")]
    public bool SupportsDNSSRV {
        get => _supportsDNSSRV;
        set {
            SupportsDNSSRVSpecified = true;
            _supportsDNSSRV = value;
        }
    }

    [XmlIgnore]
    public bool SupportsDNSSRVSpecified { get; set; }
    private int _connectionTimeoutSeconds;

    [XmlElement(ElementName = "connectionTimeoutSeconds", IsNullable = false, Namespace = "")]
    public int ConnectionTimeoutSeconds {
        get => _connectionTimeoutSeconds;
        set {
            ConnectionTimeoutSecondsSpecified = true;
            _connectionTimeoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool ConnectionTimeoutSecondsSpecified { get; set; }
}
}
