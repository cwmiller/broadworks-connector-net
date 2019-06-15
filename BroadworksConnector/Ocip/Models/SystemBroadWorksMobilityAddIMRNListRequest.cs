using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Adds BroadWorks Mobility IMRN numbers to the system. It is possible to add either:
    /// a single number, a list of numbers, or a range of numbers, or any combination thereof.
    /// The response is either a SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksMobilityAddIMRNListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
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
