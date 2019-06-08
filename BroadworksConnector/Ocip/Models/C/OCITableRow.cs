using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models.C
{
[Serializable]
[XmlRoot(Namespace = "C")]
public  class OCITableRow 
{
    private List<string> _col;

    [XmlElement(ElementName = "col", IsNullable = false, Namespace = "")]
    public List<string> Col {
        get => _col;
        set {
            ColSpecified = true;
            _col = value;
        }
    }

    [XmlIgnore]
    public bool ColSpecified { get; set; }
}
}
