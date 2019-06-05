using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupAccountAuthorizationCodesGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private List<BroadworksConnector.Ocip.Models.AccountAuthorizationCodeEntry> _codeEntry;

        [XmlElement(ElementName = "codeEntry", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.AccountAuthorizationCodeEntry> CodeEntry
        {
            get => _codeEntry;
            set
            {
                CodeEntrySpecified = true;
                _codeEntry = value;
            }
        }

        [XmlIgnore]
        public bool CodeEntrySpecified { get; set; }
    }
}
