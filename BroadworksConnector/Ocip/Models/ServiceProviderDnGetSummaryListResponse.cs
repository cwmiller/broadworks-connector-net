using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDnGetSummaryListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "dnSummaryTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable DnSummaryTable { get; set; }
 }
}
