using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementTagSetGetListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _tagSetTable;

    [XmlElement(ElementName = "tagSetTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable TagSetTable {
        get => _tagSetTable;
        set {
            TagSetTableSpecified = true;
            _tagSetTable = value;
        }
    }

    [XmlIgnore]
    public bool TagSetTableSpecified { get; set; }
}
}
