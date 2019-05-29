using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRedundancyParametersGetResponse16sp2 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "rollBackTimerMinutes", IsNullable = false)]
    public int RollBackTimerMinutes { get; set; }
    [XmlElement(ElementName = "sendSipOptionMessageUponMigration", IsNullable = false)]
    public bool SendSipOptionMessageUponMigration { get; set; }
 }
}
