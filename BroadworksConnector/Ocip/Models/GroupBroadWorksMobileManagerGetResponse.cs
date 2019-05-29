using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupBroadWorksMobileManagerGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "mobileManagerId", IsNullable = false)]
    public string MobileManagerId { get; set; }
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "localToCarrier", IsNullable = false)]
    public bool LocalToCarrier { get; set; }
    [XmlElement(ElementName = "deactivationReason", IsNullable = false)]
    public string DeactivationReason { get; set; }
    [XmlElement(ElementName = "maxTxPerSecondEnabled", IsNullable = false)]
    public bool MaxTxPerSecondEnabled { get; set; }
    [XmlElement(ElementName = "maxTxPerSecond", IsNullable = false)]
    public int MaxTxPerSecond { get; set; }
    [XmlElement(ElementName = "tldnEnabled", IsNullable = false)]
    public bool TldnEnabled { get; set; }
    [XmlElement(ElementName = "genericNumberEnabled", IsNullable = false)]
    public bool GenericNumberEnabled { get; set; }
    [XmlElement(ElementName = "mobileStateCheckEnabled", IsNullable = false)]
    public bool MobileStateCheckEnabled { get; set; }
    [XmlElement(ElementName = "locationBasedServicesEnabled", IsNullable = false)]
    public bool LocationBasedServicesEnabled { get; set; }
 }
}
