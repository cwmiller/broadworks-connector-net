using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a new Communication Barring Profile.
    /// The priorities for OriginatingRules, RedirectingRules, CallMeNowRules and IncomingRules are requantized to consecutive integers as part of the add.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The following elements are only used in AS data mode:
    /// callMeNowDefaultAction, use value "Block" in XS data mode
    /// callMeNowDefaultCallTimeout
    /// callMeNowRule
    /// applyToAttendedCallTransfers, use value "false" in XS data mode
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:2272""}]")]
    public class ServiceProviderCommunicationBarringProfileAddRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2272")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2272")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2272")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingAction _originatingDefaultAction;

        [XmlElement(ElementName = "originatingDefaultAction", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2272")]
        public BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingAction OriginatingDefaultAction
        {
            get => _originatingDefaultAction;
            set
            {
                OriginatingDefaultActionSpecified = true;
                _originatingDefaultAction = value;
            }
        }

        [XmlIgnore]
        protected bool OriginatingDefaultActionSpecified { get; set; }

        private string _originatingDefaultTreatmentId;

        [XmlElement(ElementName = "originatingDefaultTreatmentId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2272")]
        [MinLength(1)]
        [MaxLength(40)]
        public string OriginatingDefaultTreatmentId
        {
            get => _originatingDefaultTreatmentId;
            set
            {
                OriginatingDefaultTreatmentIdSpecified = true;
                _originatingDefaultTreatmentId = value;
            }
        }

        [XmlIgnore]
        protected bool OriginatingDefaultTreatmentIdSpecified { get; set; }

        private string _originatingDefaultTransferNumber;

        [XmlElement(ElementName = "originatingDefaultTransferNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2272")]
        [MinLength(1)]
        [MaxLength(30)]
        public string OriginatingDefaultTransferNumber
        {
            get => _originatingDefaultTransferNumber;
            set
            {
                OriginatingDefaultTransferNumberSpecified = true;
                _originatingDefaultTransferNumber = value;
            }
        }

        [XmlIgnore]
        protected bool OriginatingDefaultTransferNumberSpecified { get; set; }

        private int _originatingDefaultCallTimeout;

        [XmlElement(ElementName = "originatingDefaultCallTimeout", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2272")]
        [MinInclusive(60)]
        [MaxInclusive(86400)]
        public int OriginatingDefaultCallTimeout
        {
            get => _originatingDefaultCallTimeout;
            set
            {
                OriginatingDefaultCallTimeoutSpecified = true;
                _originatingDefaultCallTimeout = value;
            }
        }

        [XmlIgnore]
        protected bool OriginatingDefaultCallTimeoutSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalOriginatingRule> _originatingRule = new List<BroadWorksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalOriginatingRule>();

        [XmlElement(ElementName = "originatingRule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2272")]
        public List<BroadWorksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalOriginatingRule> OriginatingRule
        {
            get => _originatingRule;
            set
            {
                OriginatingRuleSpecified = true;
                _originatingRule = value;
            }
        }

        [XmlIgnore]
        protected bool OriginatingRuleSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CommunicationBarringRedirectingAction _redirectingDefaultAction;

        [XmlElement(ElementName = "redirectingDefaultAction", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2272")]
        public BroadWorksConnector.Ocip.Models.CommunicationBarringRedirectingAction RedirectingDefaultAction
        {
            get => _redirectingDefaultAction;
            set
            {
                RedirectingDefaultActionSpecified = true;
                _redirectingDefaultAction = value;
            }
        }

        [XmlIgnore]
        protected bool RedirectingDefaultActionSpecified { get; set; }

        private int _redirectingDefaultCallTimeout;

        [XmlElement(ElementName = "redirectingDefaultCallTimeout", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2272")]
        [MinInclusive(60)]
        [MaxInclusive(86400)]
        public int RedirectingDefaultCallTimeout
        {
            get => _redirectingDefaultCallTimeout;
            set
            {
                RedirectingDefaultCallTimeoutSpecified = true;
                _redirectingDefaultCallTimeout = value;
            }
        }

        [XmlIgnore]
        protected bool RedirectingDefaultCallTimeoutSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalRedirectingRule> _redirectingRule = new List<BroadWorksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalRedirectingRule>();

        [XmlElement(ElementName = "redirectingRule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2272")]
        public List<BroadWorksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalRedirectingRule> RedirectingRule
        {
            get => _redirectingRule;
            set
            {
                RedirectingRuleSpecified = true;
                _redirectingRule = value;
            }
        }

        [XmlIgnore]
        protected bool RedirectingRuleSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CommunicationBarringCallMeNowAction _callMeNowDefaultAction;

        [XmlElement(ElementName = "callMeNowDefaultAction", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2272")]
        public BroadWorksConnector.Ocip.Models.CommunicationBarringCallMeNowAction CallMeNowDefaultAction
        {
            get => _callMeNowDefaultAction;
            set
            {
                CallMeNowDefaultActionSpecified = true;
                _callMeNowDefaultAction = value;
            }
        }

        [XmlIgnore]
        protected bool CallMeNowDefaultActionSpecified { get; set; }

        private int _callMeNowDefaultCallTimeout;

        [XmlElement(ElementName = "callMeNowDefaultCallTimeout", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2272")]
        [MinInclusive(60)]
        [MaxInclusive(86400)]
        public int CallMeNowDefaultCallTimeout
        {
            get => _callMeNowDefaultCallTimeout;
            set
            {
                CallMeNowDefaultCallTimeoutSpecified = true;
                _callMeNowDefaultCallTimeout = value;
            }
        }

        [XmlIgnore]
        protected bool CallMeNowDefaultCallTimeoutSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalCallMeNowRule> _callMeNowRule = new List<BroadWorksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalCallMeNowRule>();

        [XmlElement(ElementName = "callMeNowRule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2272")]
        public List<BroadWorksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalCallMeNowRule> CallMeNowRule
        {
            get => _callMeNowRule;
            set
            {
                CallMeNowRuleSpecified = true;
                _callMeNowRule = value;
            }
        }

        [XmlIgnore]
        protected bool CallMeNowRuleSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingAction _incomingDefaultAction;

        [XmlElement(ElementName = "incomingDefaultAction", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2272")]
        public BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingAction IncomingDefaultAction
        {
            get => _incomingDefaultAction;
            set
            {
                IncomingDefaultActionSpecified = true;
                _incomingDefaultAction = value;
            }
        }

        [XmlIgnore]
        protected bool IncomingDefaultActionSpecified { get; set; }

        private int _incomingDefaultCallTimeout;

        [XmlElement(ElementName = "incomingDefaultCallTimeout", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2272")]
        [MinInclusive(60)]
        [MaxInclusive(86400)]
        public int IncomingDefaultCallTimeout
        {
            get => _incomingDefaultCallTimeout;
            set
            {
                IncomingDefaultCallTimeoutSpecified = true;
                _incomingDefaultCallTimeout = value;
            }
        }

        [XmlIgnore]
        protected bool IncomingDefaultCallTimeoutSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingRule19sp1> _incomingRule = new List<BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingRule19sp1>();

        [XmlElement(ElementName = "incomingRule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2272")]
        public List<BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingRule19sp1> IncomingRule
        {
            get => _incomingRule;
            set
            {
                IncomingRuleSpecified = true;
                _incomingRule = value;
            }
        }

        [XmlIgnore]
        protected bool IncomingRuleSpecified { get; set; }

        private bool _becomeDefault;

        [XmlElement(ElementName = "becomeDefault", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2272")]
        public bool BecomeDefault
        {
            get => _becomeDefault;
            set
            {
                BecomeDefaultSpecified = true;
                _becomeDefault = value;
            }
        }

        [XmlIgnore]
        protected bool BecomeDefaultSpecified { get; set; }

        private bool _applyToAttendedCallTransfers;

        [XmlElement(ElementName = "applyToAttendedCallTransfers", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2272")]
        public bool ApplyToAttendedCallTransfers
        {
            get => _applyToAttendedCallTransfers;
            set
            {
                ApplyToAttendedCallTransfersSpecified = true;
                _applyToAttendedCallTransfers = value;
            }
        }

        [XmlIgnore]
        protected bool ApplyToAttendedCallTransfersSpecified { get; set; }

    }
}
