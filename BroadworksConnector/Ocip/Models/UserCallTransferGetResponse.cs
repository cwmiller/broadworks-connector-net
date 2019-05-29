using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallTransferGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isRecallActive", IsNullable = false)]
    public bool IsRecallActive { get; set; }
    [XmlElement(ElementName = "recallNumberOfRings", IsNullable = false)]
    public int RecallNumberOfRings { get; set; }
    [XmlElement(ElementName = "useDiversionInhibitorForBlindTransfer", IsNullable = false)]
    public bool UseDiversionInhibitorForBlindTransfer { get; set; }
    [XmlElement(ElementName = "useDiversionInhibitorForConsultativeCalls", IsNullable = false)]
    public bool UseDiversionInhibitorForConsultativeCalls { get; set; }
 }
}
