using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a69fde15f3aa7494d83b57461a7a70bb:267""}]")]
    public class SystemAdviceOfChargeModifyRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _delayBetweenNotificationSeconds;

        [XmlElement(ElementName = "delayBetweenNotificationSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a69fde15f3aa7494d83b57461a7a70bb:267")]
        [MinInclusive(5)]
        [MaxInclusive(1800)]
        public int DelayBetweenNotificationSeconds
        {
            get => _delayBetweenNotificationSeconds;
            set
            {
                DelayBetweenNotificationSecondsSpecified = true;
                _delayBetweenNotificationSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool DelayBetweenNotificationSecondsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AdviceOfChargeIncomingAocHandling _incomingAocHandling;

        [XmlElement(ElementName = "incomingAocHandling", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a69fde15f3aa7494d83b57461a7a70bb:267")]
        public BroadWorksConnector.Ocip.Models.AdviceOfChargeIncomingAocHandling IncomingAocHandling
        {
            get => _incomingAocHandling;
            set
            {
                IncomingAocHandlingSpecified = true;
                _incomingAocHandling = value;
            }
        }

        [XmlIgnore]
        protected bool IncomingAocHandlingSpecified { get; set; }

        private bool _useOCSEnquiry;

        [XmlElement(ElementName = "useOCSEnquiry", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a69fde15f3aa7494d83b57461a7a70bb:267")]
        public bool UseOCSEnquiry
        {
            get => _useOCSEnquiry;
            set
            {
                UseOCSEnquirySpecified = true;
                _useOCSEnquiry = value;
            }
        }

        [XmlIgnore]
        protected bool UseOCSEnquirySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AdviceOfChargeOCSEnquiryType _oCSEnquiryType;

        [XmlElement(ElementName = "OCSEnquiryType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a69fde15f3aa7494d83b57461a7a70bb:267")]
        public BroadWorksConnector.Ocip.Models.AdviceOfChargeOCSEnquiryType OCSEnquiryType
        {
            get => _oCSEnquiryType;
            set
            {
                OCSEnquiryTypeSpecified = true;
                _oCSEnquiryType = value;
            }
        }

        [XmlIgnore]
        protected bool OCSEnquiryTypeSpecified { get; set; }

    }
}
