using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupPhoneDirectoryGetListResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _directoryTable;

    [XmlElement(ElementName = "directoryTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable DirectoryTable {
        get => _directoryTable;
        set {
            DirectoryTableSpecified = true;
            _directoryTable = value;
        }
    }

    [XmlIgnore]
    public bool DirectoryTableSpecified { get; set; }
}
}
