using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a list of account/authorization codes to a group.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupAccountAuthorizationCodesAddListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        
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
