using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum SIPPrivacyVersion{
    RFC3323,
    RFC3323Japan,
    Privacy03,
    Privacy00,
 }
}
