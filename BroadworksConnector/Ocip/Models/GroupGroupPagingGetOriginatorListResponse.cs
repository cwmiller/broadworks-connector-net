using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupPagingGetOriginatorListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _originatorTable;

    [XmlElement(ElementName = "originatorTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable OriginatorTable {
        get => _originatorTable;
        set {
            OriginatorTableSpecified = true;
            _originatorTable = value;
        }
    }

    [XmlIgnore]
    public bool OriginatorTableSpecified { get; set; }
}
}
