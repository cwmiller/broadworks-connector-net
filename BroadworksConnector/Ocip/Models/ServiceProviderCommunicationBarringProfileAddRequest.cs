using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a new Communication Barring Profile.
    /// The priorities for OriginatingRules, RedirectingRules and IncomingRules are requantized to consecutive
    /// integers as part of the add.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderCommunicationBarringProfileAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
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
        
        private List<BroadWorksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalOriginatingRule> _originatingRule;

        [XmlElement(ElementName = "originatingRule", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalOriginatingRule> OriginatingRule {
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
        
        private List<BroadWorksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalRedirectingRule> _redirectingRule;

        [XmlElement(ElementName = "redirectingRule", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalRedirectingRule> RedirectingRule {
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
        
        private bool _becomeDefault;

        [XmlElement(ElementName = "becomeDefault", IsNullable = false, Namespace = "")]
        public bool BecomeDefault {
            get => _becomeDefault;
            set {
                BecomeDefaultSpecified = true;
                _becomeDefault = value;
            }
        }

        [XmlIgnore]
        public bool BecomeDefaultSpecified { get; set; }
        
    }
}
