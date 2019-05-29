using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum AuthenticationMode{
    Enabled,
    Disabled,
    EnabledWithWebPortalCredentials,
 }
}
