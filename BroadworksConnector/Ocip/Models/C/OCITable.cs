using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models.C
{
[Serializable]
[XmlRoot(Namespace = "C")]
public  class OCITable 
{
    [XmlElement(ElementName = "colHeading", IsNullable = false)]
    public List<string> ColHeading { get; set; }
    [XmlElement(ElementName = "row", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.C.OCITableRow> Row { get; set; }
 }
}
