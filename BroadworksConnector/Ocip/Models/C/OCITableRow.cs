using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models.C
{
[Serializable]
[XmlRoot(Namespace = "C")]
public  class OCITableRow 
{
    [XmlElement(ElementName = "col", IsNullable = false)]
    public List<string> Col { get; set; }
 }
}
