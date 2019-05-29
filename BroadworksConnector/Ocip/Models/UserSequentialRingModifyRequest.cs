using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSequentialRingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "ringBaseLocationFirst", IsNullable = false)]
    public bool RingBaseLocationFirst { get; set; }
    [XmlElement(ElementName = "baseLocationNumberOfRings", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SequentialRingNumberOfRings BaseLocationNumberOfRings { get; set; }
    [XmlElement(ElementName = "continueIfBaseLocationIsBusy", IsNullable = false)]
    public bool ContinueIfBaseLocationIsBusy { get; set; }
    [XmlElement(ElementName = "callerMayStopSearch", IsNullable = false)]
    public bool CallerMayStopSearch { get; set; }
    [XmlElement(ElementName = "Location01", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SequentialRingLocationModify Location01 { get; set; }
    [XmlElement(ElementName = "Location02", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SequentialRingLocationModify Location02 { get; set; }
    [XmlElement(ElementName = "Location03", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SequentialRingLocationModify Location03 { get; set; }
    [XmlElement(ElementName = "Location04", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SequentialRingLocationModify Location04 { get; set; }
    [XmlElement(ElementName = "Location05", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SequentialRingLocationModify Location05 { get; set; }
    [XmlElement(ElementName = "criteriaActivation", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CriteriaActivation> CriteriaActivation { get; set; }
 }
}
