using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallingPartyCategoryDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _category;

    [XmlElement(ElementName = "category", IsNullable = false, Namespace = "")]
    public string Category {
        get => _category;
        set {
            CategorySpecified = true;
            _category = value;
        }
    }

    [XmlIgnore]
    public bool CategorySpecified { get; set; }
}
}
