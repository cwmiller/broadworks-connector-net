using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum PresentationIndicator{
    Anonymous,
    AnonymousName,
    AnonymousURI,
    AnonymousUnavailable,
    Public,
    Unavailable,
 }
}
