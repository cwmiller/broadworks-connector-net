using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderPreferredCarrierGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceProviderCarrierTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ServiceProviderCarrierTable { get; set; }
 }
}
