using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemFileRepositoryDeviceGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _fileRepositoryTable;

    [XmlElement(ElementName = "fileRepositoryTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable FileRepositoryTable {
        get => _fileRepositoryTable;
        set {
            FileRepositoryTableSpecified = true;
            _fileRepositoryTable = value;
        }
    }

    [XmlIgnore]
    public bool FileRepositoryTableSpecified { get; set; }
}
}
