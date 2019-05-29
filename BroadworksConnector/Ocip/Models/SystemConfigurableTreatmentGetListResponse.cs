using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemConfigurableTreatmentGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "treatmentTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable TreatmentTable { get; set; }
 }
}
