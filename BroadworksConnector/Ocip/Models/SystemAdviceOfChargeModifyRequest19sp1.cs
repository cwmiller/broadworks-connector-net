using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify Advice of Charge system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAdviceOfChargeModifyRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private int _delayBetweenNotificationSeconds;

        [XmlElement(ElementName = "delayBetweenNotificationSeconds", IsNullable = false, Namespace = "")]
        public int DelayBetweenNotificationSeconds {
            get => _delayBetweenNotificationSeconds;
            set {
                DelayBetweenNotificationSecondsSpecified = true;
                _delayBetweenNotificationSeconds = value;
            }
        }

        [XmlIgnore]
        public bool DelayBetweenNotificationSecondsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AdviceOfChargeIncomingAocHandling _incomingAocHandling;

        [XmlElement(ElementName = "incomingAocHandling", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AdviceOfChargeIncomingAocHandling IncomingAocHandling {
            get => _incomingAocHandling;
            set {
                IncomingAocHandlingSpecified = true;
                _incomingAocHandling = value;
            }
        }

        [XmlIgnore]
        public bool IncomingAocHandlingSpecified { get; set; }
        
        private bool _useOCSEnquiry;

        [XmlElement(ElementName = "useOCSEnquiry", IsNullable = false, Namespace = "")]
        public bool UseOCSEnquiry {
            get => _useOCSEnquiry;
            set {
                UseOCSEnquirySpecified = true;
                _useOCSEnquiry = value;
            }
        }

        [XmlIgnore]
        public bool UseOCSEnquirySpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AdviceOfChargeOCSEnquiryType _oCSEnquiryType;

        [XmlElement(ElementName = "OCSEnquiryType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AdviceOfChargeOCSEnquiryType OCSEnquiryType {
            get => _oCSEnquiryType;
            set {
                OCSEnquiryTypeSpecified = true;
                _oCSEnquiryType = value;
            }
        }

        [XmlIgnore]
        public bool OCSEnquiryTypeSpecified { get; set; }
        
    }
}
