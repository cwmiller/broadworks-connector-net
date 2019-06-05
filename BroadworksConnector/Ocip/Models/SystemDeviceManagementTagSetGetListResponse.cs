using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementTagSetGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _tagSetName;

    [XmlElement(ElementName = "tagSetName", IsNullable = false, Namespace = "")]
    public List<string> TagSetName {
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
