using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOCIReportingGetACLListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _ociReportingACLTable;

    [XmlElement(ElementName = "ociReportingACLTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable OciReportingACLTable {
        get => _ociReportingACLTable;
        set {
            OciReportingACLTableSpecified = true;
            _ociReportingACLTable = value;
        }
    }

    [XmlIgnore]
    public bool OciReportingACLTableSpecified { get; set; }
}
}
