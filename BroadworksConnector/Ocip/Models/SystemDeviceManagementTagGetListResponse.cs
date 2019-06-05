using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementTagGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _tagsTable;

    [XmlElement(ElementName = "tagsTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable TagsTable {
        get => _tagsTable;
        set {
            TagsTableSpecified = true;
            _tagsTable = value;
        }
    }

    [XmlIgnore]
    public bool TagsTableSpecified { get; set; }
}
}
