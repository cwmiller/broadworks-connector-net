using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingGetBridgeListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "conferenceBridgeTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ConferenceBridgeTable { get; set; }
 }
}
