using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Adds system service Dns. It is possible to add either: a single DN,
    /// a list of DNs a range of DNs, or any combination thereof.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSystemServiceDnAddListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private List<string> _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        public List<string> PhoneNumber {
            get => _phoneNumber;
            set {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.DNRange> _dnRange;

        [XmlElement(ElementName = "dnRange", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.DNRange> DnRange {
            get => _dnRange;
            set {
                DnRangeSpecified = true;
                _dnRange = value;
            }
        }

        [XmlIgnore]
        public bool DnRangeSpecified { get; set; }
        
    }
}
