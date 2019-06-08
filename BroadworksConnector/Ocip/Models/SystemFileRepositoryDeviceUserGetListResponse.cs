using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemFileRepositoryDeviceUserGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _fileRepositoryUserTable;

    [XmlElement(ElementName = "fileRepositoryUserTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable FileRepositoryUserTable {
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
