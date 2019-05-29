using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum AuthenticationLockoutFixedWaitTimeMinutes{
    _5,
    _10,
    _20,
    _40,
    _60,
 }
}
