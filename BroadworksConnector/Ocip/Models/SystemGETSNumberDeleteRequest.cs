using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSNumberDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _number;

    [XmlElement(ElementName = "number", IsNullable = false, Namespace = "")]
    public string Number {
        get => _number;
        set {
            NumberSpecified = true;
            _number = value;
        }
    }

    [XmlIgnore]
    public bool NumberSpecified { get; set; }
}
}
