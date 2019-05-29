using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksAnywhereGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "alertAllLocationsForClickToDialCalls", IsNullable = false)]
    public bool AlertAllLocationsForClickToDialCalls { get; set; }
    [XmlElement(ElementName = "phoneNumberTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable PhoneNumberTable { get; set; }
 }
}
