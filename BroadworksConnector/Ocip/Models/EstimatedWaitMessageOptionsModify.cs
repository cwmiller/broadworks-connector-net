using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EstimatedWaitMessageOptionsModify 
{
    [XmlElement(ElementName = "enabled", IsNullable = false)]
    public bool Enabled { get; set; }
    [XmlElement(ElementName = "operatingMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EstimatedWaitMessageOperatingMode OperatingMode { get; set; }
    [XmlElement(ElementName = "playPositionHighVolume", IsNullable = false)]
    public bool PlayPositionHighVolume { get; set; }
    [XmlElement(ElementName = "playTimeHighVolume", IsNullable = false)]
    public bool PlayTimeHighVolume { get; set; }
    [XmlElement(ElementName = "maximumPositions", IsNullable = false)]
    public int MaximumPositions { get; set; }
    [XmlElement(ElementName = "maximumWaitingMinutes", IsNullable = false)]
    public int MaximumWaitingMinutes { get; set; }
    [XmlElement(ElementName = "defaultCallHandlingMinutes", IsNullable = false)]
    public int DefaultCallHandlingMinutes { get; set; }
    [XmlElement(ElementName = "playUpdatedEWM", IsNullable = false)]
    public bool PlayUpdatedEWM { get; set; }
    [XmlElement(ElementName = "timeBetweenEWMUpdatesSeconds", IsNullable = true)]
    public int? TimeBetweenEWMUpdatesSeconds { get; set; }
 }
}
