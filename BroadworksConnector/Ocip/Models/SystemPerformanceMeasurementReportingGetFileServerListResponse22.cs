using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPerformanceMeasurementReportingGetFileServerListResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _fileServerTable;

    [XmlElement(ElementName = "fileServerTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable FileServerTable {
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
