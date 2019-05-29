using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemEnhancedCallLogsModifyRequest22 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "maxNonPagedResponseSize", IsNullable = false)]
    public int MaxNonPagedResponseSize { get; set; }
    [XmlElement(ElementName = "eclQueryApplicationURL", IsNullable = true)]
    public string EclQueryApplicationURL { get; set; }
    [XmlElement(ElementName = "eclQueryDataRepositoryURL", IsNullable = true)]
    public string EclQueryDataRepositoryURL { get; set; }
 }
}
