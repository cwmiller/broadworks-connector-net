using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMusicOnHoldGetInstanceResponse14sp4 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "isActiveDuringCallHold", IsNullable = false)]
    public bool IsActiveDuringCallHold { get; set; }
    [XmlElement(ElementName = "isActiveDuringCallPark", IsNullable = false)]
    public bool IsActiveDuringCallPark { get; set; }
    [XmlElement(ElementName = "isActiveDuringBusyCampOn", IsNullable = false)]
    public bool IsActiveDuringBusyCampOn { get; set; }
    [XmlElement(ElementName = "messageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldMessageSelection MessageSelection { get; set; }
    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointRead14 AccessDeviceEndpoint { get; set; }
    [XmlElement(ElementName = "enableVideo", IsNullable = false)]
    public bool EnableVideo { get; set; }
    [XmlElement(ElementName = "audioFileDescription", IsNullable = false)]
    public string AudioFileDescription { get; set; }
    [XmlElement(ElementName = "videoFileDescription", IsNullable = false)]
    public string VideoFileDescription { get; set; }
 }
}
