using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemClassmarkDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _classmark;

    [XmlElement(ElementName = "classmark", IsNullable = false, Namespace = "")]
    public string Classmark {
        get => _classmark;
        set {
            ClassmarkSpecified = true;
            _classmark = value;
        }
    }

    [XmlIgnore]
    public bool ClassmarkSpecified { get; set; }
}
}
