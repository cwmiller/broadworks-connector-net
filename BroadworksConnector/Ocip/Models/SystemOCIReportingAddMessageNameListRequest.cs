using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a list of reported messages for a host in the OCI Reporting
    /// Access Control List. The response is either a SuccessResponse or an
    /// ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemOCIReportingAddMessageNameListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        public string NetAddress {
            get => _netAddress;
            set {
                NetAddressSpecified = true;
                _netAddress = value;
            }
        }

        [XmlIgnore]
        public bool NetAddressSpecified { get; set; }
        
        private List<string> _messageNameStartsWith;

        [XmlElement(ElementName = "messageNameStartsWith", IsNullable = false, Namespace = "")]
        public List<string> MessageNameStartsWith {
            get => _messageNameStartsWith;
            set {
                MessageNameStartsWithSpecified = true;
                _messageNameStartsWith = value;
            }
        }

        [XmlIgnore]
        public bool MessageNameStartsWithSpecified { get; set; }
        
    }
}
