using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaSetDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _setName;

    [XmlElement(ElementName = "setName", IsNullable = false, Namespace = "")]
    public string SetName {
        get => _setName;
        set {
            SetNameSpecified = true;
            _setName = value;
        }
    }

    [XmlIgnore]
    public bool SetNameSpecified { get; set; }
}
}
