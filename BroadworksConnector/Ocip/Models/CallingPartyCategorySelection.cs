using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum CallingPartyCategorySelection{
    Special,
    Hospital,
    Hotel,
    Prison,
    Payphone,
    Ordinary,
 }
}
