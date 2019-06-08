using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSReservedFeatureAccessCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _reservedCodeTable;

    [XmlElement(ElementName = "reservedCodeTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ReservedCodeTable {
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
