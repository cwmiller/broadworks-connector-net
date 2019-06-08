using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSResourcePriorityDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _priorityValue;

    [XmlElement(ElementName = "priorityValue", IsNullable = false, Namespace = "")]
    public string PriorityValue {
        get => _priorityValue;
        set {
            PriorityValueSpecified = true;
            _priorityValue = value;
        }
    }

    [XmlIgnore]
    public bool PriorityValueSpecified { get; set; }
}
}
