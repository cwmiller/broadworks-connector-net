using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringUserControlGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableLockout", IsNullable = false)]
    public bool EnableLockout { get; set; }
    [XmlElement(ElementName = "maxNumberOfFailedAttempts", IsNullable = false)]
    public int MaxNumberOfFailedAttempts { get; set; }
    [XmlElement(ElementName = "lockoutMinutes", IsNullable = false)]
    public int LockoutMinutes { get; set; }
 }
}
