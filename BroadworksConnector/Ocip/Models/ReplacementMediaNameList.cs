using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementMediaNameList 
{
    private List<string> _mediaName;

    [XmlElement(ElementName = "mediaName", IsNullable = false, Namespace = "")]
    public List<string> MediaName {
        get => _mediaName;
        set {
            MediaNameSpecified = true;
            _mediaName = value;
        }
    }

    [XmlIgnore]
    public bool MediaNameSpecified { get; set; }
}
}
