using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSReservedFeatureAccessCodeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _reservedCodeTable;

    [XmlElement(ElementName = "reservedCodeTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ReservedCodeTable {
        get => _reservedCodeTable;
        set {
            ReservedCodeTableSpecified = true;
            _reservedCodeTable = value;
        }
    }

    [XmlIgnore]
    public bool ReservedCodeTableSpecified { get; set; }
}
}
