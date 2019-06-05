using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _mediaName;

    [XmlElement(ElementName = "mediaName", IsNullable = false, Namespace = "")]
    public string MediaName {
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
