using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum ProtectionAction{
    Decline,
    Drop,
    Error,
    Redirect,
    Unavailable,
 }
}
