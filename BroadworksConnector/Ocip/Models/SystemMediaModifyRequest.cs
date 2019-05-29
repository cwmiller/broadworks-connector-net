using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "mediaName", IsNullable = false)]
    public string MediaName { get; set; }
    [XmlElement(ElementName = "codecName", IsNullable = false)]
    public string CodecName { get; set; }
    [XmlElement(ElementName = "bandwidthEnforcementType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaBandwidthEnforcementType BandwidthEnforcementType { get; set; }
    [XmlElement(ElementName = "mediaBandwidth", IsNullable = true)]
    public int? MediaBandwidth { get; set; }
 }
}
