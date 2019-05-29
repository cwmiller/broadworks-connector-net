using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ProfileAndServiceCustomRingbackInfo 
{
    [XmlElement(ElementName = "criteriaTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable CriteriaTable { get; set; }
 }
}
