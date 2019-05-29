using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum ConnectedNumberSource{
    ConfigurableCLID,
    Group,
    User,
    Department,
 }
}
