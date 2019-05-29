using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBusyLampFieldGetResponse18 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "displayLocalUserIdentityLastNameFirst", IsNullable = false)]
    public bool DisplayLocalUserIdentityLastNameFirst { get; set; }
    [XmlElement(ElementName = "forceUseOfTCP", IsNullable = false)]
    public bool ForceUseOfTCP { get; set; }
 }
}
