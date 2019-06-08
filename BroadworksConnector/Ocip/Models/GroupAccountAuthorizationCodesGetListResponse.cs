using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccountAuthorizationCodesGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadWorksConnector.Ocip.Models.AccountAuthorizationCodeEntry> _codeEntry;

    [XmlElement(ElementName = "codeEntry", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.AccountAuthorizationCodeEntry> CodeEntry {
        get => _codeEntry;
        set {
            CodeEntrySpecified = true;
            _codeEntry = value;
        }
    }

    [XmlIgnore]
    public bool CodeEntrySpecified { get; set; }
}
}
