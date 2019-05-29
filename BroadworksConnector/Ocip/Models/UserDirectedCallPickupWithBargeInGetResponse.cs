using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserDirectedCallPickupWithBargeInGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableBargeInWarningTone", IsNullable = false)]
    public bool EnableBargeInWarningTone { get; set; }
 }
}
