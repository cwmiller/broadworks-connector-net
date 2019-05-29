using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAlternateNumbersGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "distinctiveRing", IsNullable = false)]
    public bool DistinctiveRing { get; set; }
    [XmlElement(ElementName = "alternateEntry01", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry01 { get; set; }
    [XmlElement(ElementName = "alternateEntry02", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry02 { get; set; }
    [XmlElement(ElementName = "alternateEntry03", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry03 { get; set; }
    [XmlElement(ElementName = "alternateEntry04", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry04 { get; set; }
    [XmlElement(ElementName = "alternateEntry05", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry05 { get; set; }
    [XmlElement(ElementName = "alternateEntry06", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry06 { get; set; }
    [XmlElement(ElementName = "alternateEntry07", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry07 { get; set; }
    [XmlElement(ElementName = "alternateEntry08", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry08 { get; set; }
    [XmlElement(ElementName = "alternateEntry09", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry09 { get; set; }
    [XmlElement(ElementName = "alternateEntry10", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry AlternateEntry10 { get; set; }
 }
}
