using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAlternateNumbersGetResponse21 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "distinctiveRing", IsNullable = false)]
    public bool DistinctiveRing { get; set; }
    [XmlElement(ElementName = "alternateEntry01", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry01 { get; set; }
    [XmlElement(ElementName = "alternateEntry02", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry02 { get; set; }
    [XmlElement(ElementName = "alternateEntry03", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry03 { get; set; }
    [XmlElement(ElementName = "alternateEntry04", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry04 { get; set; }
    [XmlElement(ElementName = "alternateEntry05", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry05 { get; set; }
    [XmlElement(ElementName = "alternateEntry06", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry06 { get; set; }
    [XmlElement(ElementName = "alternateEntry07", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry07 { get; set; }
    [XmlElement(ElementName = "alternateEntry08", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry08 { get; set; }
    [XmlElement(ElementName = "alternateEntry09", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry09 { get; set; }
    [XmlElement(ElementName = "alternateEntry10", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AlternateNumberEntry21 AlternateEntry10 { get; set; }
 }
}
