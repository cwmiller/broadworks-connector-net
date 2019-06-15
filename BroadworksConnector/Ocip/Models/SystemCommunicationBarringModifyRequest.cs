using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Communication Barring.
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// vmCallbackScreening
    /// 
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _directTransferScreening;

        [XmlElement(ElementName = "directTransferScreening", IsNullable = false, Namespace = "")]
        public bool DirectTransferScreening {
            get => _directTransferScreening;
            set {
                DirectTransferScreeningSpecified = true;
                _directTransferScreening = value;
            }
        }

        [XmlIgnore]
        public bool DirectTransferScreeningSpecified { get; set; }
        
        private bool _vmCallbackScreening;

        [XmlElement(ElementName = "vmCallbackScreening", IsNullable = false, Namespace = "")]
        public bool VmCallbackScreening {
            get => _vmCallbackScreening;
            set {
                VmCallbackScreeningSpecified = true;
                _vmCallbackScreening = value;
            }
        }

        [XmlIgnore]
        public bool VmCallbackScreeningSpecified { get; set; }
        
    }
}
