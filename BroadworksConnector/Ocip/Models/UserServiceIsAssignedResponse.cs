using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserServiceIsAssignedResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _isAssigned;

    [XmlElement(ElementName = "isAssigned", IsNullable = false, Namespace = "")]
    public bool IsAssigned {
        get => _isAssigned;
        set {
            IsAssignedSpecified = true;
            _isAssigned = value;
        }
    }

    [XmlIgnore]
    public bool IsAssignedSpecified { get; set; }
}
}
