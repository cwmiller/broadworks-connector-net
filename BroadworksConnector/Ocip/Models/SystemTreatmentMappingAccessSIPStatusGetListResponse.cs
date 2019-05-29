using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTreatmentMappingAccessSIPStatusGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "treatmentMappingTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable TreatmentMappingTable { get; set; }
 }
}
