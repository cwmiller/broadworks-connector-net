using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementTagSetDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
}
}
