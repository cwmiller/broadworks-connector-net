using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCPEConfigGetFileServerListResponse14sp6 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _fileServerTable;

    [XmlElement(ElementName = "fileServerTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable FileServerTable {
        get => _fileServerTable;
        set {
            FileServerTableSpecified = true;
            _fileServerTable = value;
        }
    }

    [XmlIgnore]
    public bool FileServerTableSpecified { get; set; }
}
}
