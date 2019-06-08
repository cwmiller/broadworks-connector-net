using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDeviceTypeCustomTagGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _groupDeviceTypeCustomTagsTable;

    [XmlElement(ElementName = "groupDeviceTypeCustomTagsTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable GroupDeviceTypeCustomTagsTable {
        get => _groupDeviceTypeCustomTagsTable;
        set {
            GroupDeviceTypeCustomTagsTableSpecified = true;
            _groupDeviceTypeCustomTagsTable = value;
        }
    }

    [XmlIgnore]
    public bool GroupDeviceTypeCustomTagsTableSpecified { get; set; }
}
}
