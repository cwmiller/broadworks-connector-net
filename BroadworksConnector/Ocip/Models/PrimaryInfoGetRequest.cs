using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests information about the primary server for high-availability support.
    /// The response is either PrimaryInfoGetResponse or ErrorResponse
        /// <see cref="PrimaryInfoGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class PrimaryInfoGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _isPrivate;

        [XmlElement(ElementName = "isPrivate", IsNullable = false, Namespace = "")]
        public bool IsPrivate {
            get => _isPrivate;
            set {
                IsPrivateSpecified = true;
                _isPrivate = value;
            }
        }

        [XmlIgnore]
        public bool IsPrivateSpecified { get; set; }
        
        private bool _isAddressInfoRequested;

        [XmlElement(ElementName = "isAddressInfoRequested", IsNullable = false, Namespace = "")]
        public bool IsAddressInfoRequested {
            get => _isAddressInfoRequested;
            set {
                IsAddressInfoRequestedSpecified = true;
                _isAddressInfoRequested = value;
            }
        }

        [XmlIgnore]
        public bool IsAddressInfoRequestedSpecified { get; set; }
        
    }
}
