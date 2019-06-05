using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class RandomPort 
{
    private string _random;

    [XmlElement(ElementName = "random", IsNullable = false, Namespace = "")]
    public string Random {
        get => _random;
        set {
            RandomSpecified = true;
            _random = value;
        }
    }

    [XmlIgnore]
    public bool RandomSpecified { get; set; }
    private int _port;

    [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
    public int Port {
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
