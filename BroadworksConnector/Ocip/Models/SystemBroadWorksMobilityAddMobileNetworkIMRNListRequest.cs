using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Adds BroadWorks Mobility IMRN numbers to a Mobile Network. It is possible to add either:
    /// a single number, a list of numbers, or a range of numbers, or any combination thereof.
    /// The response is either a SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksMobilityAddMobileNetworkIMRNListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private List<BroadWorksConnector.Ocip.Models.DNRange> _numberRange;

        [XmlElement(ElementName = "numberRange", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.DNRange> NumberRange {
            get => _numberRange;
            set {
                NumberRangeSpecified = true;
                _numberRange = value;
            }
        }

        [XmlIgnore]
        public bool NumberRangeSpecified { get; set; }
        
    }
}
