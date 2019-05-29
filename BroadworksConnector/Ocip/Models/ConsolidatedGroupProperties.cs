using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ConsolidatedGroupProperties 
{
    [XmlElement(ElementName = "defaultDomain", IsNullable = false)]
    public string DefaultDomain { get; set; }
    [XmlElement(ElementName = "userLimit", IsNullable = false)]
    public int UserLimit { get; set; }
    [XmlElement(ElementName = "groupName", IsNullable = false)]
    public string GroupName { get; set; }
    [XmlElement(ElementName = "callingLineIdName", IsNullable = false)]
    public string CallingLineIdName { get; set; }
    [XmlElement(ElementName = "timeZone", IsNullable = false)]
    public string TimeZone { get; set; }
    [XmlElement(ElementName = "locationDialingCode", IsNullable = false)]
    public string LocationDialingCode { get; set; }
    [XmlElement(ElementName = "contact", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.Contact Contact { get; set; }
    [XmlElement(ElementName = "address", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.StreetAddress Address { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public List<string> NetworkClassOfService { get; set; }
    [XmlElement(ElementName = "defaultNetworkClassOfService", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DefaultNetworkClassOfService DefaultNetworkClassOfService { get; set; }
    [XmlElement(ElementName = "groupService", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ConsolidatedGroupServiceAssignment> GroupService { get; set; }
    [XmlElement(ElementName = "servicePolicy", IsNullable = false)]
    public string ServicePolicy { get; set; }
 }
}
