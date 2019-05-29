using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum EndpointType{
    Primary,
    SharedCallAppearance,
    VideoAddOn,
    PublicServiceIdentity,
    MusicOnHoldInternal,
    FlexibleSeatingGuest,
 }
}
