using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementTagSetModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
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
    private string _newTagSetName;

    [XmlElement(ElementName = "newTagSetName", IsNullable = false, Namespace = "")]
    public string NewTagSetName {
        get => _newTagSetName;
        set {
            NewTagSetNameSpecified = true;
            _newTagSetName = value;
        }
    }

    [XmlIgnore]
    public bool NewTagSetNameSpecified { get; set; }
}
}
