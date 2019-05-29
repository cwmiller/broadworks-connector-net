using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupBroadWorksAnywhereGetInstanceResponse19sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 ServiceInstanceProfile { get; set; }
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
