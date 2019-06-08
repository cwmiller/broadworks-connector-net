using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaSetModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private BroadWorksConnector.Ocip.Models.ReplacementMediaNameList _mediaNameList;

    [XmlElement(ElementName = "mediaNameList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementMediaNameList MediaNameList {
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
