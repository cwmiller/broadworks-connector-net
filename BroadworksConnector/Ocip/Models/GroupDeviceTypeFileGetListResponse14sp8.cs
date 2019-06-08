using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDeviceTypeFileGetListResponse14sp8 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _groupDeviceTypeFilesTable;

    [XmlElement(ElementName = "groupDeviceTypeFilesTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable GroupDeviceTypeFilesTable {
        get => _groupDeviceTypeFilesTable;
        set {
            GroupDeviceTypeFilesTableSpecified = true;
            _groupDeviceTypeFilesTable = value;
        }
    }

    [XmlIgnore]
    public bool GroupDeviceTypeFilesTableSpecified { get; set; }
}
}
