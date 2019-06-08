using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
