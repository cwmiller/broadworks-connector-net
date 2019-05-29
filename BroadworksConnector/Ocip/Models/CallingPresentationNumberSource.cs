using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum CallingPresentationNumberSource{
    ConfigurableCLID,
    DNIS,
    Emergency,
    Group,
    TrunkGroup,
    User,
    Department,
 }
}
