using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models.C
{
[Serializable]
[XmlRoot(Namespace = "C")]
public  class ErrorResponse : BroadworksConnector.Ocip.Models.C.OCIResponse
{
    [XmlElement(ElementName = "errorCode", IsNullable = false)]
    public int ErrorCode { get; set; }
    [XmlElement(ElementName = "summary", IsNullable = false)]
    public string Summary { get; set; }
    [XmlElement(ElementName = "summaryEnglish", IsNullable = false)]
    public string SummaryEnglish { get; set; }
    [XmlElement(ElementName = "detail", IsNullable = false)]
    public string Detail { get; set; }
 }
}
