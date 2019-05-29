using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNetworkClassOfServiceModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "newName", IsNullable = false)]
    public string NewName { get; set; }
    [XmlElement(ElementName = "description", IsNullable = true)]
    public string Description { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile0", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile0 { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile1", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile1 { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile2", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile2 { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile3", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile3 { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile4", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile4 { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile5", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile5 { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile6", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile6 { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile7", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile7 { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile8", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile8 { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile9", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile9 { get; set; }
    [XmlElement(ElementName = "networkTranslationIndex", IsNullable = true)]
    public string NetworkTranslationIndex { get; set; }
    [XmlElement(ElementName = "callProcessingPolicyProfileName", IsNullable = true)]
    public string CallProcessingPolicyProfileName { get; set; }
 }
}
