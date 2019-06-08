using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementTagGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _tagsTable;

    [XmlElement(ElementName = "tagsTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable TagsTable {
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
