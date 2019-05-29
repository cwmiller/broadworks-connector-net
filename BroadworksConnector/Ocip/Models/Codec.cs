using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum Codec{
    Clear,
    G711alaw,
    G711ulaw,
    G722,
    G72353,
    G72363,
    G723A53,
    G723A63,
    G72616,
    G72624,
    G72632,
    G72640,
    G728,
    G7298,
    G729B8,
    GSMEFR,
    GSMFR,
    AMRWB,
 }
}
