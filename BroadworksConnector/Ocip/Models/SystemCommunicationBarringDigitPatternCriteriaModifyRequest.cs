using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringDigitPatternCriteriaModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "newName", IsNullable = false)]
    public string NewName { get; set; }
    [XmlElement(ElementName = "description", IsNullable = true)]
    public string Description { get; set; }
    [XmlElement(ElementName = "addMatchDigitPattern", IsNullable = false)]
    public List<string> AddMatchDigitPattern { get; set; }
    [XmlElement(ElementName = "deleteMatchDigitPattern", IsNullable = false)]
    public List<string> DeleteMatchDigitPattern { get; set; }
 }
}
