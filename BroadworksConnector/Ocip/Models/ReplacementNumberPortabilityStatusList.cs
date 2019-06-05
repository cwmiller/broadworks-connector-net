using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementNumberPortabilityStatusList 
{
    private List<string> _status;

    [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
    public List<string> Status {
        get => _status;
        set {
            StatusSpecified = true;
            _status = value;
        }
    }

    [XmlIgnore]
    public bool StatusSpecified { get; set; }
}
}
