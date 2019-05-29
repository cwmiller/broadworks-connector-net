using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMusicOnHoldGetInstanceResponse14sp6 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "isActiveDuringCallHold", IsNullable = false)]
    public bool IsActiveDuringCallHold { get; set; }
    [XmlElement(ElementName = "isActiveDuringCallPark", IsNullable = false)]
    public bool IsActiveDuringCallPark { get; set; }
    [XmlElement(ElementName = "isActiveDuringBusyCampOn", IsNullable = false)]
    public bool IsActiveDuringBusyCampOn { get; set; }
    [XmlElement(ElementName = "enableVideo", IsNullable = false)]
    public bool EnableVideo { get; set; }
    [XmlElement(ElementName = "source", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceRead Source { get; set; }
    [XmlElement(ElementName = "useAlternateSourceForInternalCalls", IsNullable = false)]
    public bool UseAlternateSourceForInternalCalls { get; set; }
    [XmlElement(ElementName = "internalSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceRead InternalSource { get; set; }
 }
}
