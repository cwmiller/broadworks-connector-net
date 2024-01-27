using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAdviceOfChargeGetRequest25.
    /// Contains a list of system Advice of Charge parameters.
    /// <see cref="SystemAdviceOfChargeGetRequest25"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9975efc7f5883a0595f811ee72ba4df5:248""}]")]
    public class SystemAdviceOfChargeGetResponse25 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _delayBetweenNotificationSeconds;

        [XmlElement(ElementName = "delayBetweenNotificationSeconds", IsNullable = false, Namespace = "")]
        [Group(@"9975efc7f5883a0595f811ee72ba4df5:248")]
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

        protected BroadWorksConnector.Ocip.Models.AdviceOfChargeIncomingAocHandling _incomingAocHandling;

        [XmlElement(ElementName = "incomingAocHandling", IsNullable = false, Namespace = "")]
        [Group(@"9975efc7f5883a0595f811ee72ba4df5:248")]
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

        protected bool _useOCSEnquiry;

        [XmlElement(ElementName = "useOCSEnquiry", IsNullable = false, Namespace = "")]
        [Group(@"9975efc7f5883a0595f811ee72ba4df5:248")]
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

        protected BroadWorksConnector.Ocip.Models.AdviceOfChargeOCSEnquiryType _oCSEnquiryType;

        [XmlElement(ElementName = "OCSEnquiryType", IsNullable = false, Namespace = "")]
        [Group(@"9975efc7f5883a0595f811ee72ba4df5:248")]
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

        protected bool _proxyAoCBody;

        [XmlElement(ElementName = "proxyAoCBody", IsNullable = false, Namespace = "")]
        [Group(@"9975efc7f5883a0595f811ee72ba4df5:248")]
        public bool ProxyAoCBody
        {
            get => _proxyAoCBody;
            set
            {
                ProxyAoCBodySpecified = true;
                _proxyAoCBody = value;
            }
        }

        [XmlIgnore]
        protected bool ProxyAoCBodySpecified { get; set; }

    }
}
