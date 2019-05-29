using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRedundancyParametersModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "rollBackTimerMinutes", IsNullable = false)]
    public int RollBackTimerMinutes { get; set; }
    [XmlElement(ElementName = "sendSipOptionMessageUponMigration", IsNullable = false)]
    public bool SendSipOptionMessageUponMigration { get; set; }
 }
}
