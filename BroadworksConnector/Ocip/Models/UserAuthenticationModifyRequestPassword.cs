using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAuthenticationModifyRequestPassword 
{
    private string _old;

    [XmlElement(ElementName = "old", IsNullable = false, Namespace = "")]
    public string Old {
        get => _old;
        set {
            OldSpecified = true;
            _old = value;
        }
    }

    [XmlIgnore]
    public bool OldSpecified { get; set; }
    private string _new;

    [XmlElement(ElementName = "new", IsNullable = false, Namespace = "")]
    public string New {
        get => _new;
        set {
            NewSpecified = true;
            _new = value;
        }
    }

    [XmlIgnore]
    public bool NewSpecified { get; set; }
}
}
