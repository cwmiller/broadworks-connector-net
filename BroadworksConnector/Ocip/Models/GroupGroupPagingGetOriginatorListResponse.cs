using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupPagingGetOriginatorListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _originatorTable;

    [XmlElement(ElementName = "originatorTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable OriginatorTable {
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
