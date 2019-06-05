using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDeviceTypeCustomTagGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _groupDeviceTypeCustomTagsTable;

    [XmlElement(ElementName = "groupDeviceTypeCustomTagsTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable GroupDeviceTypeCustomTagsTable {
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
