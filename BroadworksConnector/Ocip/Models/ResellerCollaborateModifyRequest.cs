using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the reseller level data associated with Collaborate.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ResellerCollaborateModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        public string ResellerId {
            get => _resellerId;
            set {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        public bool ResellerIdSpecified { get; set; }
        
        private string _collaborateFromAddress;

        [XmlElement(ElementName = "collaborateFromAddress", IsNullable = true, Namespace = "")]
        public string CollaborateFromAddress {
            get => _collaborateFromAddress;
            set {
                CollaborateFromAddressSpecified = true;
                _collaborateFromAddress = value;
            }
        }

        [XmlIgnore]
        public bool CollaborateFromAddressSpecified { get; set; }
        
    }
}
