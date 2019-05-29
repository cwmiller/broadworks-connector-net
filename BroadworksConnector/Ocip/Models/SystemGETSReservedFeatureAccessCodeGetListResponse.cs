using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSReservedFeatureAccessCodeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "reservedCodeTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ReservedCodeTable { get; set; }
 }
}
