using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSAvpCodeMapGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _avpCodeTable;

    [XmlElement(ElementName = "avpCodeTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable AvpCodeTable {
        get => _avpCodeTable;
        set {
            AvpCodeTableSpecified = true;
            _avpCodeTable = value;
        }
    }

    [XmlIgnore]
    public bool AvpCodeTableSpecified { get; set; }
}
}
