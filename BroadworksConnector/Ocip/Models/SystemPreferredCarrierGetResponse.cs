using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPreferredCarrierGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "cic", IsNullable = false)]
    public string Cic { get; set; }
    [XmlElement(ElementName = "countryCode", IsNullable = false)]
    public string CountryCode { get; set; }
    [XmlElement(ElementName = "isIntraLata", IsNullable = false)]
    public bool IsIntraLata { get; set; }
    [XmlElement(ElementName = "isInterLata", IsNullable = false)]
    public bool IsInterLata { get; set; }
    [XmlElement(ElementName = "isInternational", IsNullable = false)]
    public bool IsInternational { get; set; }
 }
}
