using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserGroupPagingGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _pagingGroupTable;

    [XmlElement(ElementName = "pagingGroupTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable PagingGroupTable {
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
