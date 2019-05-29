using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum RedirectingPresentationIndicator{
    Anonymous,
    AnonymousName,
    AnonymousURI,
    Public,
 }
}
