using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDeviceTypeFileGetListResponse14sp8 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _groupDeviceTypeFilesTable;

    [XmlElement(ElementName = "groupDeviceTypeFilesTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable GroupDeviceTypeFilesTable {
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
