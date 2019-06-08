using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallingPartyCategoryGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.CallingPartyCategorySelection _category;

    [XmlElement(ElementName = "category", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallingPartyCategorySelection Category {
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