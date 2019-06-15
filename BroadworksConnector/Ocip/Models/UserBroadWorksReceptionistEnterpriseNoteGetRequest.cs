using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the Receptionist notes for the specified Receptionist and Contact User IDs.
    /// The response is either a UserBroadWorksReceptionistEnterpriseNoteGetResponse or an
    /// ErrorResponse.  If the user sending the request is the not the owner of the
    /// Receptionist Note, then an ErrorResponse will be returned.
        /// <see cref="UserBroadWorksReceptionistEnterpriseNoteGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserBroadWorksReceptionistEnterpriseNoteGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _receptionistUserId;

        [XmlElement(ElementName = "receptionistUserId", IsNullable = false, Namespace = "")]
        public string ReceptionistUserId {
            get => _receptionistUserId;
            set {
                ReceptionistUserIdSpecified = true;
                _receptionistUserId = value;
            }
        }

        [XmlIgnore]
        public bool ReceptionistUserIdSpecified { get; set; }
        
        private string _contactUserId;

        [XmlElement(ElementName = "contactUserId", IsNullable = false, Namespace = "")]
        public string ContactUserId {
            get => _contactUserId;
            set {
                ContactUserIdSpecified = true;
                _contactUserId = value;
            }
        }

        [XmlIgnore]
        public bool ContactUserIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.VirtualOnNetUserKey _vonUser;

        [XmlElement(ElementName = "vonUser", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.VirtualOnNetUserKey VonUser {
            get => _vonUser;
            set {
                VonUserSpecified = true;
                _vonUser = value;
            }
        }

        [XmlIgnore]
        public bool VonUserSpecified { get; set; }
        
    }
}
