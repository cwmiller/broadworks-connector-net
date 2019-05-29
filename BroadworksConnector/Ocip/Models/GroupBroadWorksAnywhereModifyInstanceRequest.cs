using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupBroadWorksAnywhereModifyInstanceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "broadWorksAnywhereScope", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BroadWorksAnywhereScope BroadWorksAnywhereScope { get; set; }
    [XmlElement(ElementName = "promptForCLID", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BroadWorksAnywhereCLIDPrompt PromptForCLID { get; set; }
    [XmlElement(ElementName = "silentPromptMode", IsNullable = false)]
    public bool SilentPromptMode { get; set; }
    [XmlElement(ElementName = "promptForPasscode", IsNullable = false)]
    public bool PromptForPasscode { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public string NetworkClassOfService { get; set; }
 }
}
