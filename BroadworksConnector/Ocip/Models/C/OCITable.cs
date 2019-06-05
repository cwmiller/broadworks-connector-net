using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models.C
{
[Serializable]
[XmlRoot(Namespace = "C")]
public  class OCITable 
{
    private List<string> _colHeading;

    [XmlElement(ElementName = "colHeading", IsNullable = false, Namespace = "")]
    public List<string> ColHeading {
        get => _colHeading;
        set {
            ColHeadingSpecified = true;
            _colHeading = value;
        }
    }

    [XmlIgnore]
    public bool ColHeadingSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.C.OCITableRow> _row;

    [XmlElement(ElementName = "row", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.C.OCITableRow> Row {
        get => _row;
        set {
            RowSpecified = true;
            _row = value;
        }
    }

    [XmlIgnore]
    public bool RowSpecified { get; set; }
}
}
