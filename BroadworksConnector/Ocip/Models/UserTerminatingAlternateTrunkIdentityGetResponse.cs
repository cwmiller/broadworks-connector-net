using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserTerminatingAlternateTrunkIdentityGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "terminatingTrunkIdentity", IsNullable = false)]
    public string TerminatingTrunkIdentity { get; set; }
 }
}
