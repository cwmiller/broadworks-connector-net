using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserExecutiveGetAssistantResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _allowOptInOut;

    [XmlElement(ElementName = "allowOptInOut", IsNullable = false, Namespace = "")]
    public bool AllowOptInOut {
        get => _allowOptInOut;
        set {
            AllowOptInOutSpecified = true;
            _allowOptInOut = value;
        }
    }

    [XmlIgnore]
    public bool AllowOptInOutSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _assistantUserTable;

    [XmlElement(ElementName = "assistantUserTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable AssistantUserTable {
        get => _assistantUserTable;
        set {
            AssistantUserTableSpecified = true;
            _assistantUserTable = value;
        }
    }

    [XmlIgnore]
    public bool AssistantUserTableSpecified { get; set; }
}
}
