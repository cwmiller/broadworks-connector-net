using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum LegacyAutomaticCallbackLineType{
    Individual,
    Coin,
    Series,
    Hunt,
    Unassigned,
    PBX,
    Multiparty,
    Choke,
    Oos,
    Nonspecific,
    Telecampus,
    ISDN,
    Telekibutz,
    Spare,
 }
}
