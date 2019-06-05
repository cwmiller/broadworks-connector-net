using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPersonalPhoneListGetPagedSortedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    private BroadworksConnector.Ocip.Models.C.OCITable _personalPhoneListTable;

    [XmlElement(ElementName = "personalPhoneListTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable PersonalPhoneListTable {
        get => _personalPhoneListTable;
        set {
            PersonalPhoneListTableSpecified = true;
            _personalPhoneListTable = value;
        }
    }

    [XmlIgnore]
    public bool PersonalPhoneListTableSpecified { get; set; }
}
}
