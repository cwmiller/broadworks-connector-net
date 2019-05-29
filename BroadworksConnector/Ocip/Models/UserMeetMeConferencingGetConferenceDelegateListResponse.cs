using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingGetConferenceDelegateListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "conferenceDelegateUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ConferenceDelegateUserTable { get; set; }
 }
}
