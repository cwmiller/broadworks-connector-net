using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemFileRepositoryDeviceUserGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _fileRepositoryUserTable;

    [XmlElement(ElementName = "fileRepositoryUserTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable FileRepositoryUserTable {
        get => _fileRepositoryUserTable;
        set {
            FileRepositoryUserTableSpecified = true;
            _fileRepositoryUserTable = value;
        }
    }

    [XmlIgnore]
    public bool FileRepositoryUserTableSpecified { get; set; }
}
}
