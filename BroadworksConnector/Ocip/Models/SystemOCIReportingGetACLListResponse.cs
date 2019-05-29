using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOCIReportingGetACLListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "ociReportingACLTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable OciReportingACLTable { get; set; }
 }
}
