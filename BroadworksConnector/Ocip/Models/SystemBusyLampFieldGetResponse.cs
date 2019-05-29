using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBusyLampFieldGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "displayLocalUserIdentityLastNameFirst", IsNullable = false)]
    public bool DisplayLocalUserIdentityLastNameFirst { get; set; }
 }
}
