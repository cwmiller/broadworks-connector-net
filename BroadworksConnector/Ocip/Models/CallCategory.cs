using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum CallCategory{
    Local,
    National,
    Interlata,
    Intralata,
    International,
    Private,
    Emergency,
    Other,
 }
}
