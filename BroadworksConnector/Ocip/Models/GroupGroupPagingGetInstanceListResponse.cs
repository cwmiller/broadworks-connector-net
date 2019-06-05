using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupPagingGetInstanceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _pagingGroupTable;

    [XmlElement(ElementName = "pagingGroupTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable PagingGroupTable {
        get => _pagingGroupTable;
        set {
            PagingGroupTableSpecified = true;
            _pagingGroupTable = value;
        }
    }

    [XmlIgnore]
    public bool PagingGroupTableSpecified { get; set; }
}
}
