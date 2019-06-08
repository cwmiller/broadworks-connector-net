using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaSetGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _mediaSetName;

    [XmlElement(ElementName = "mediaSetName", IsNullable = false, Namespace = "")]
    public List<string> MediaSetName {
        get => _mediaSetName;
        set {
            MediaSetNameSpecified = true;
            _mediaSetName = value;
        }
    }

    [XmlIgnore]
    public bool MediaSetNameSpecified { get; set; }
}
}
