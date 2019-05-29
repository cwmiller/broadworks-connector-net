using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum EndpointType21sp1{
    Primary,
    SharedCallAppearance,
    VideoAddOn,
    PublicServiceIdentity,
    MusicOnHoldInternal,
    FlexibleSeatingGuest,
    Mobility,
 }
}
