using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSNumberGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _reservedNumberTable;

    [XmlElement(ElementName = "reservedNumberTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ReservedNumberTable {
        get => _reservedNumberTable;
        set {
            ReservedNumberTableSpecified = true;
            _reservedNumberTable = value;
        }
    }

    [XmlIgnore]
    public bool ReservedNumberTableSpecified { get; set; }
}
}
