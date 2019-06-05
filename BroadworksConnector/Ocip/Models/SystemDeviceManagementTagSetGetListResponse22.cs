using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementTagSetGetListResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _tagSetTable;

    [XmlElement(ElementName = "tagSetTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable TagSetTable {
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
