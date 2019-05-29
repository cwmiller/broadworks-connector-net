using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum TrunkGroupUserCreationUserIdFormat{
    Extension,
    NationalDN,
    E164FormatNoPlus,
 }
}
