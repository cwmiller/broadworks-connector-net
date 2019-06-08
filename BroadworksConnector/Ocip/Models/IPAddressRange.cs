using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class IPAddressRange 
{
    private string _minIpAddress;

    [XmlElement(ElementName = "minIpAddress", IsNullable = false, Namespace = "")]
    public string MinIpAddress {
        get => _minIpAddress;
        set {
            MinIpAddressSpecified = true;
            _minIpAddress = value;
        }
    }

    [XmlIgnore]
    public bool MinIpAddressSpecified { get; set; }
    private string _maxIpAddress;

    [XmlElement(ElementName = "maxIpAddress", IsNullable = false, Namespace = "")]
    public string MaxIpAddress {
        get => _maxIpAddress;
        set {
            MaxIpAddressSpecified = true;
            _maxIpAddress = value;
        }
    }

    [XmlIgnore]
    public bool MaxIpAddressSpecified { get; set; }
}
}
