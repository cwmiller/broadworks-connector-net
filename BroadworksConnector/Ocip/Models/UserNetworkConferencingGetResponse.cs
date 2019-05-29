using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserNetworkConferencingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "conferenceURI", IsNullable = false)]
    public string ConferenceURI { get; set; }
    [XmlElement(ElementName = "maxConferenceParties", IsNullable = false)]
    public int MaxConferenceParties { get; set; }
 }
}
