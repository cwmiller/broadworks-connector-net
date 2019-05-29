using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksAnywhereModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "alertAllLocationsForClickToDialCalls", IsNullable = false)]
    public bool AlertAllLocationsForClickToDialCalls { get; set; }
    [XmlElement(ElementName = "alertAllLocationsForGroupPagingCalls", IsNullable = false)]
    public bool AlertAllLocationsForGroupPagingCalls { get; set; }
 }
}
