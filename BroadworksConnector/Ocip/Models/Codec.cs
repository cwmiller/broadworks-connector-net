using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum Codec{
    [XmlEnum(Name = "Clear")]
    Clear,
    [XmlEnum(Name = "G711alaw")]
    G711alaw,
    [XmlEnum(Name = "G711ulaw")]
    G711ulaw,
    [XmlEnum(Name = "G722")]
    G722,
    [XmlEnum(Name = "G723-53")]
    G72353,
    [XmlEnum(Name = "G723-63")]
    G72363,
    [XmlEnum(Name = "G723A-53")]
    G723A53,
    [XmlEnum(Name = "G723A-63")]
    G723A63,
    [XmlEnum(Name = "G726-16")]
    G72616,
    [XmlEnum(Name = "G726-24")]
    G72624,
    [XmlEnum(Name = "G726-32")]
    G72632,
    [XmlEnum(Name = "G726-40")]
    G72640,
    [XmlEnum(Name = "G728")]
    G728,
    [XmlEnum(Name = "G729-8")]
    G7298,
    [XmlEnum(Name = "G729B-8")]
    G729B8,
    [XmlEnum(Name = "GSMEFR")]
    GSMEFR,
    [XmlEnum(Name = "GSMFR")]
    GSMFR,
    [XmlEnum(Name = "AMR-WB")]
    AMRWB,
 }
}
