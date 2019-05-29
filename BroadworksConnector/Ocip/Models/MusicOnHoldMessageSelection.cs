using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum MusicOnHoldMessageSelection{
    System,
    External,
    Custom,
 }
}
