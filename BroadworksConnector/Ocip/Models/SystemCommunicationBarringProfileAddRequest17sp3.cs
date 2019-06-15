using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a new Communication Barring Profile.
    /// The priorities for IncomingRules are requantized to consecutive integers as part of the add.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The following elements are only used in AS data mode:
    /// callMeNowDefaultAction, use value "Block" in XS data mode
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// callMeNowDefaultCallTimeout
    /// callMeNowRule
    /// 
    /// Replaced by: SystemCommunicationBarringProfileAddRequest19sp1 in AS data mode
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCommunicationBarringProfileAddRequest19sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringProfileAddRequest17sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        public string Name {
            get => _name;
            set {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }
        
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        public string Description {
            get => _description;
            set {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingAction _originatingDefaultAction;

        [XmlElement(ElementName = "originatingDefaultAction", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingAction OriginatingDefaultAction {
            get => _originatingDefaultAction;
            set {
                OriginatingDefaultActionSpecified = true;
                _originatingDefaultAction = value;
            }
        }

        [XmlIgnore]
        public bool OriginatingDefaultActionSpecified { get; set; }
        
        private string _originatingDefaultTreatmentId;

        [XmlElement(ElementName = "originatingDefaultTreatmentId", IsNullable = false, Namespace = "")]
        public string OriginatingDefaultTreatmentId {
            get => _originatingDefaultTreatmentId;
            set {
                OriginatingDefaultTreatmentIdSpecified = true;
                _originatingDefaultTreatmentId = value;
            }
        }

        [XmlIgnore]
        public bool OriginatingDefaultTreatmentIdSpecified { get; set; }
        
        private string _originatingDefaultTransferNumber;

        [XmlElement(ElementName = "originatingDefaultTransferNumber", IsNullable = false, Namespace = "")]
        public string OriginatingDefaultTransferNumber {
            get => _originatingDefaultTransferNumber;
            set {
                OriginatingDefaultTransferNumberSpecified = true;
                _originatingDefaultTransferNumber = value;
            }
        }

        [XmlIgnore]
        public bool OriginatingDefaultTransferNumberSpecified { get; set; }
        
        private int _originatingDefaultCallTimeout;

        [XmlElement(ElementName = "originatingDefaultCallTimeout", IsNullable = false, Namespace = "")]
        public int OriginatingDefaultCallTimeout {
            get => _originatingDefaultCallTimeout;
            set {
                OriginatingDefaultCallTimeoutSpecified = true;
                _originatingDefaultCallTimeout = value;
            }
        }

        [XmlIgnore]
        public bool OriginatingDefaultCallTimeoutSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingRule> _originatingRule;

        [XmlElement(ElementName = "originatingRule", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingRule> OriginatingRule {
            get => _originatingRule;
            set {
                OriginatingRuleSpecified = true;
                _originatingRule = value;
            }
        }

        [XmlIgnore]
        public bool OriginatingRuleSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CommunicationBarringRedirectingAction _redirectingDefaultAction;

        [XmlElement(ElementName = "redirectingDefaultAction", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CommunicationBarringRedirectingAction RedirectingDefaultAction {
            get => _redirectingDefaultAction;
            set {
                RedirectingDefaultActionSpecified = true;
                _redirectingDefaultAction = value;
            }
        }

        [XmlIgnore]
        public bool RedirectingDefaultActionSpecified { get; set; }
        
        private int _redirectingDefaultCallTimeout;

        [XmlElement(ElementName = "redirectingDefaultCallTimeout", IsNullable = false, Namespace = "")]
        public int RedirectingDefaultCallTimeout {
            get => _redirectingDefaultCallTimeout;
            set {
                RedirectingDefaultCallTimeoutSpecified = true;
                _redirectingDefaultCallTimeout = value;
            }
        }

        [XmlIgnore]
        public bool RedirectingDefaultCallTimeoutSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.CommunicationBarringRedirectingRule> _redirectingRule;

        [XmlElement(ElementName = "redirectingRule", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CommunicationBarringRedirectingRule> RedirectingRule {
            get => _redirectingRule;
            set {
                RedirectingRuleSpecified = true;
                _redirectingRule = value;
            }
        }

        [XmlIgnore]
        public bool RedirectingRuleSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingAction _incomingDefaultAction;

        [XmlElement(ElementName = "incomingDefaultAction", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingAction IncomingDefaultAction {
            get => _incomingDefaultAction;
            set {
                IncomingDefaultActionSpecified = true;
                _incomingDefaultAction = value;
            }
        }

        [XmlIgnore]
        public bool IncomingDefaultActionSpecified { get; set; }
        
        private int _incomingDefaultCallTimeout;

        [XmlElement(ElementName = "incomingDefaultCallTimeout", IsNullable = false, Namespace = "")]
        public int IncomingDefaultCallTimeout {
            get => _incomingDefaultCallTimeout;
            set {
                IncomingDefaultCallTimeoutSpecified = true;
                _incomingDefaultCallTimeout = value;
            }
        }

        [XmlIgnore]
        public bool IncomingDefaultCallTimeoutSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingRule> _incomingRule;

        [XmlElement(ElementName = "incomingRule", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingRule> IncomingRule {
            get => _incomingRule;
            set {
                IncomingRuleSpecified = true;
                _incomingRule = value;
            }
        }

        [XmlIgnore]
        public bool IncomingRuleSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CommunicationBarringCallMeNowAction _callMeNowDefaultAction;

        [XmlElement(ElementName = "callMeNowDefaultAction", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CommunicationBarringCallMeNowAction CallMeNowDefaultAction {
            get => _callMeNowDefaultAction;
            set {
                CallMeNowDefaultActionSpecified = true;
                _callMeNowDefaultAction = value;
            }
        }

        [XmlIgnore]
        public bool CallMeNowDefaultActionSpecified { get; set; }
        
        private int _callMeNowDefaultCallTimeout;

        [XmlElement(ElementName = "callMeNowDefaultCallTimeout", IsNullable = false, Namespace = "")]
        public int CallMeNowDefaultCallTimeout {
            get => _callMeNowDefaultCallTimeout;
            set {
                CallMeNowDefaultCallTimeoutSpecified = true;
                _callMeNowDefaultCallTimeout = value;
            }
        }

        [XmlIgnore]
        public bool CallMeNowDefaultCallTimeoutSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.CommunicationBarringCallMeNowRule> _callMeNowRule;

        [XmlElement(ElementName = "callMeNowRule", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CommunicationBarringCallMeNowRule> CallMeNowRule {
            get => _callMeNowRule;
            set {
                CallMeNowRuleSpecified = true;
                _callMeNowRule = value;
            }
        }

        [XmlIgnore]
        public bool CallMeNowRuleSpecified { get; set; }
        
    }
}
