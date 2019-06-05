using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementTagSetAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _resellerId;

    [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
    public string ResellerId {
        get => _resellerId;
        set {
            ResellerIdSpecified = true;
            _resellerId = value;
        }
    }

    [XmlIgnore]
    public bool ResellerIdSpecified { get; set; }
}
}
