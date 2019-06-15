using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a voice mail distribution list for a users voice message.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserVoiceMessagingUserModifyDistributionListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private int _listId;

        [XmlElement(ElementName = "listId", IsNullable = false, Namespace = "")]
        public int ListId {
            get => _listId;
            set {
                ListIdSpecified = true;
                _listId = value;
            }
        }

        [XmlIgnore]
        public bool ListIdSpecified { get; set; }
        
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        public string Description {
            get => _description;
            set {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ReplacementOutgoingDNorSIPURIList _phoneNumberList;

        [XmlElement(ElementName = "phoneNumberList", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ReplacementOutgoingDNorSIPURIList PhoneNumberList {
            get => _phoneNumberList;
            set {
                PhoneNumberListSpecified = true;
                _phoneNumberList = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberListSpecified { get; set; }
        
    }
}
