using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointGetDNISListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _displayDNISNumber;

    [XmlElement(ElementName = "displayDNISNumber", IsNullable = false, Namespace = "")]
    public bool DisplayDNISNumber {
        get => _displayDNISNumber;
        set {
            DisplayDNISNumberSpecified = true;
            _displayDNISNumber = value;
        }
    }

    [XmlIgnore]
    public bool DisplayDNISNumberSpecified { get; set; }
    private bool _displayDNISName;

    [XmlElement(ElementName = "displayDNISName", IsNullable = false, Namespace = "")]
    public bool DisplayDNISName {
        get => _displayDNISName;
        set {
            DisplayDNISNameSpecified = true;
            _displayDNISName = value;
        }
    }

    [XmlIgnore]
    public bool DisplayDNISNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _dnisTable;

    [XmlElement(ElementName = "dnisTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable DnisTable {
        get => _dnisTable;
        set {
            DnisTableSpecified = true;
            _dnisTable = value;
        }
    }

    [XmlIgnore]
    public bool DnisTableSpecified { get; set; }
}
}
