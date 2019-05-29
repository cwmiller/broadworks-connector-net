using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemEnhancedCallLogsGetResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "maxNonPagedResponseSize", IsNullable = false)]
    public int MaxNonPagedResponseSize { get; set; }
    [XmlElement(ElementName = "eclQueryApplicationURL", IsNullable = false)]
    public string EclQueryApplicationURL { get; set; }
    [XmlElement(ElementName = "eclQueryDataRepositoryURL", IsNullable = false)]
    public string EclQueryDataRepositoryURL { get; set; }
 }
}
