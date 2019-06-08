using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaSetDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
