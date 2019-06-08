using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnterpriseCommonPhoneListGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
    private BroadWorksConnector.Ocip.Models.C.OCITable _enterpriseCommonPhoneListTable;

    [XmlElement(ElementName = "enterpriseCommonPhoneListTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable EnterpriseCommonPhoneListTable {
        get => _enterpriseCommonPhoneListTable;
        set {
            EnterpriseCommonPhoneListTableSpecified = true;
            _enterpriseCommonPhoneListTable = value;
        }
    }

    [XmlIgnore]
    public bool EnterpriseCommonPhoneListTableSpecified { get; set; }
}
}
