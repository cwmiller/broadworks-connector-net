using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum TrunkGroupUserCreationSIPURIFormat{
    Extension,
    NationalDN,
    E164FormatNoPlus,
    E164Format,
 }
}
