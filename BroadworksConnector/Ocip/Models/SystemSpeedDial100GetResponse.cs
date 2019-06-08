using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSpeedDial100GetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _prefix;

    [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
    public string Prefix {
        get => _prefix;
        set {
            PrefixSpecified = true;
            _prefix = value;
        }
    }

    [XmlIgnore]
    public bool PrefixSpecified { get; set; }
}
}
