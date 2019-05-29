using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum SIPSuppressRFC3312Preconditions{
    Always,
    Never,
    SuppressIfSingleDialog,
 }
}
