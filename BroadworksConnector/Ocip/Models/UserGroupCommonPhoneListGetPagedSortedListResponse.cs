using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserGroupCommonPhoneListGetPagedSortedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _totalNumberOfRows;

    [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
    public int TotalNumberOfRows {
        get => _totalNumberOfRows;
        set {
            TotalNumberOfRowsSpecified = true;
            _totalNumberOfRows = value;
        }
    }

    [XmlIgnore]
    public bool TotalNumberOfRowsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _groupCommonPhoneListTable;

    [XmlElement(ElementName = "groupCommonPhoneListTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable GroupCommonPhoneListTable {
        get => _groupCommonPhoneListTable;
        set {
            GroupCommonPhoneListTableSpecified = true;
            _groupCommonPhoneListTable = value;
        }
    }

    [XmlIgnore]
    public bool GroupCommonPhoneListTableSpecified { get; set; }
}
}
