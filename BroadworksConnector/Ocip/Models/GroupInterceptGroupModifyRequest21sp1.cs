using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupInterceptGroupModifyRequest21sp1 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "announcementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementSelection AnnouncementSelection { get; set; }
    [XmlElement(ElementName = "audioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource AudioFile { get; set; }
    [XmlElement(ElementName = "videoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource VideoFile { get; set; }
    [XmlElement(ElementName = "inboundCallMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.InterceptInboundCall InboundCallMode { get; set; }
    [XmlElement(ElementName = "alternateBlockingAnnouncement", IsNullable = false)]
    public bool AlternateBlockingAnnouncement { get; set; }
    [XmlElement(ElementName = "exemptInboundMobilityCalls", IsNullable = false)]
    public bool ExemptInboundMobilityCalls { get; set; }
    [XmlElement(ElementName = "disableParallelRingingToNetworkLocations", IsNullable = false)]
    public bool DisableParallelRingingToNetworkLocations { get; set; }
    [XmlElement(ElementName = "routeToVoiceMail", IsNullable = false)]
    public bool RouteToVoiceMail { get; set; }
    [XmlElement(ElementName = "playNewPhoneNumber", IsNullable = false)]
    public bool PlayNewPhoneNumber { get; set; }
    [XmlElement(ElementName = "newPhoneNumber", IsNullable = true)]
    public string NewPhoneNumber { get; set; }
    [XmlElement(ElementName = "transferOnZeroToPhoneNumber", IsNullable = false)]
    public bool TransferOnZeroToPhoneNumber { get; set; }
    [XmlElement(ElementName = "transferPhoneNumber", IsNullable = true)]
    public string TransferPhoneNumber { get; set; }
    [XmlElement(ElementName = "outboundCallMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.InterceptOutboundCall OutboundCallMode { get; set; }
    [XmlElement(ElementName = "exemptOutboundMobilityCalls", IsNullable = false)]
    public bool ExemptOutboundMobilityCalls { get; set; }
    [XmlElement(ElementName = "rerouteOutboundCalls", IsNullable = false)]
    public bool RerouteOutboundCalls { get; set; }
    [XmlElement(ElementName = "outboundReroutePhoneNumber", IsNullable = true)]
    public string OutboundReroutePhoneNumber { get; set; }
 }
}
