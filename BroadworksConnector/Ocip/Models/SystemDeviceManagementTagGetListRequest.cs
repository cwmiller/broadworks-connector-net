using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementTagGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private bool _systemDefaultTagSet;

    [XmlElement(ElementName = "systemDefaultTagSet", IsNullable = false, Namespace = "")]
    public bool SystemDefaultTagSet {
        get => _systemDefaultTagSet;
        set {
            SystemDefaultTagSetSpecified = true;
            _systemDefaultTagSet = value;
        }
    }

    [XmlIgnore]
    public bool SystemDefaultTagSetSpecified { get; set; }
    private string _tagSetName;

    [XmlElement(ElementName = "tagSetName", IsNullable = false, Namespace = "")]
    public string TagSetName {
        get => _tagSetName;
        set {
            TagSetNameSpecified = true;
            _tagSetName = value;
        }
    }

    [XmlIgnore]
    public bool TagSetNameSpecified { get; set; }
}
}
