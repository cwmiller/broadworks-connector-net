using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallingPartyCategoryGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.CallingPartyCategorySelection _category;

    [XmlElement(ElementName = "category", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallingPartyCategorySelection Category {
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
