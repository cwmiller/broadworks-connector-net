using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "mediaName", IsNullable = false)]
    public string MediaName { get; set; }
    [XmlElement(ElementName = "codecName", IsNullable = false)]
    public string CodecName { get; set; }
    [XmlElement(ElementName = "mediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaType MediaType { get; set; }
    [XmlElement(ElementName = "bandwidthEnforcementType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaBandwidthEnforcementType BandwidthEnforcementType { get; set; }
    [XmlElement(ElementName = "mediaBandwidth", IsNullable = false)]
    public int MediaBandwidth { get; set; }
 }
}
