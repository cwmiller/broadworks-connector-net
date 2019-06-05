using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaSetModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _setName;

    [XmlElement(ElementName = "setName", IsNullable = false, Namespace = "")]
    public string SetName {
        get => _setName;
        set {
            SetNameSpecified = true;
            _setName = value;
        }
    }

    [XmlIgnore]
    public bool SetNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ReplacementMediaNameList _mediaNameList;

    [XmlElement(ElementName = "mediaNameList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementMediaNameList MediaNameList {
        get => _mediaNameList;
        set {
            MediaNameListSpecified = true;
            _mediaNameList = value;
        }
    }

    [XmlIgnore]
    public bool MediaNameListSpecified { get; set; }
}
}
