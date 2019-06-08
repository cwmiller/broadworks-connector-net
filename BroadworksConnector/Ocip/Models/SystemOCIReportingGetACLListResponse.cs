using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOCIReportingGetACLListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _ociReportingACLTable;

    [XmlElement(ElementName = "ociReportingACLTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable OciReportingACLTable {
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
