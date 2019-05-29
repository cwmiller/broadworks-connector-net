using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAdviceOfChargeCostInformationSourceGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "costInformationSourceTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable CostInformationSourceTable { get; set; }
 }
}
