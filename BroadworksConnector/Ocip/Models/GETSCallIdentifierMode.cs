using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum GETSCallIdentifierMode{
    RequestURI,
    RPH,
    RPHRequestURI,
 }
}
