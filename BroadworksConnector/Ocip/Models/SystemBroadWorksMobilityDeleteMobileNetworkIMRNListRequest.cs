using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Remove BroadWorks Mobility IMRN numbers from a Mobile Network.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksMobilityDeleteMobileNetworkIMRNListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _mobileNetworkName;

        [XmlElement(ElementName = "mobileNetworkName", IsNullable = false, Namespace = "")]
        public string MobileNetworkName {
            get => _mobileNetworkName;
            set {
                MobileNetworkNameSpecified = true;
                _mobileNetworkName = value;
            }
        }

        [XmlIgnore]
        public bool MobileNetworkNameSpecified { get; set; }
        
        private List<string> _imrnNumber;

        [XmlElement(ElementName = "imrnNumber", IsNullable = false, Namespace = "")]
        public List<string> ImrnNumber {
            get => _imrnNumber;
            set {
                ImrnNumberSpecified = true;
                _imrnNumber = value;
            }
        }

        [XmlIgnore]
        public bool ImrnNumberSpecified { get; set; }
        
    }
}
