using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderCPEConfigReorderDeviceLinePortsRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
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
    private List<string> _orderedLinePortList;

    [XmlElement(ElementName = "orderedLinePortList", IsNullable = false, Namespace = "")]
    public List<string> OrderedLinePortList {
        get => _orderedLinePortList;
        set {
            OrderedLinePortListSpecified = true;
            _orderedLinePortList = value;
        }
    }

    [XmlIgnore]
    public bool OrderedLinePortListSpecified { get; set; }
}
}