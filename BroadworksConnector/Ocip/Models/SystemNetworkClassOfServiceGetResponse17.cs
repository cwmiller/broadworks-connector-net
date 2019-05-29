using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNetworkClassOfServiceGetResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile0", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile0 { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile1", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile1 { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile2", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile2 { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile3", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile3 { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile4", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile4 { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile5", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile5 { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile6", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile6 { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile7", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile7 { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile8", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile8 { get; set; }
    [XmlElement(ElementName = "communicationBarringProfile9", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile9 { get; set; }
    [XmlElement(ElementName = "networkTranslationIndex", IsNullable = false)]
    public string NetworkTranslationIndex { get; set; }
 }
}
