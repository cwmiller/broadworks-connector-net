using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum CallCenterMediaOnHoldMessageSelection{
    Default,
    URL,
    Custom,
    External,
 }
}
