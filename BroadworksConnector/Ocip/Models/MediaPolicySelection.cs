using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum MediaPolicySelection{
    UseUncompressedCodec,
    UseSupportedMediaSet,
    NoRestrictions,
 }
}
