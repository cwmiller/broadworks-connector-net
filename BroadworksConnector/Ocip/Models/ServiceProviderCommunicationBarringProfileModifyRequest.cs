using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify an existing Communication Barring Profile.
    /// The priorities for OriginatingRules, RedirectingRules, CallMeNowRules and IncomingRules are requantized to consecutive integers as part of the modify.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The following elements are only used in AS data mode:
    /// callMeNowDefaultAction
    /// callMeNowDefaultCallTimeout
    /// callMeNowRule
    /// applyToAttendedCallTransfers
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:2075""}]")]
    public class ServiceProviderCommunicationBarringProfileModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
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
        public bool ServiceProviderIdSpecified { get; set; }

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
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
        public bool NameSpecified { get; set; }

        private string _newName;

        [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NewName
        {
            get => _newName;
            set
            {
                NewNameSpecified = true;
                _newName = value;
            }
        }

        [XmlIgnore]
        public bool NewNameSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
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
        public bool DescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingAction _originatingDefaultAction;

        [XmlElement(ElementName = "originatingDefaultAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
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
        public bool OriginatingDefaultActionSpecified { get; set; }

        private string _originatingDefaultTreatmentId;

        [XmlElement(ElementName = "originatingDefaultTreatmentId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
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
        public bool OriginatingDefaultTreatmentIdSpecified { get; set; }

        private string _originatingDefaultTransferNumber;

        [XmlElement(ElementName = "originatingDefaultTransferNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
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
        public bool OriginatingDefaultTransferNumberSpecified { get; set; }

        private int? _originatingDefaultCallTimeout;

        [XmlElement(ElementName = "originatingDefaultCallTimeout", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
        [MinInclusive(60)]
        [MaxInclusive(86400)]
        public int? OriginatingDefaultCallTimeout
        {
            get => _originatingDefaultCallTimeout;
            set
            {
                OriginatingDefaultCallTimeoutSpecified = true;
                _originatingDefaultCallTimeout = value;
            }
        }

        [XmlIgnore]
        public bool OriginatingDefaultCallTimeoutSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ServiceProviderReplacementCommunicationBarringHierarchicalOriginatingRuleList _originatingRule;

        [XmlElement(ElementName = "originatingRule", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderReplacementCommunicationBarringHierarchicalOriginatingRuleList OriginatingRule
        {
            get => _originatingRule;
            set
            {
                OriginatingRuleSpecified = true;
                _originatingRule = value;
            }
        }

        [XmlIgnore]
        public bool OriginatingRuleSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CommunicationBarringRedirectingAction _redirectingDefaultAction;

        [XmlElement(ElementName = "redirectingDefaultAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
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
        public bool RedirectingDefaultActionSpecified { get; set; }

        private int? _redirectingDefaultCallTimeout;

        [XmlElement(ElementName = "redirectingDefaultCallTimeout", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
        [MinInclusive(60)]
        [MaxInclusive(86400)]
        public int? RedirectingDefaultCallTimeout
        {
            get => _redirectingDefaultCallTimeout;
            set
            {
                RedirectingDefaultCallTimeoutSpecified = true;
                _redirectingDefaultCallTimeout = value;
            }
        }

        [XmlIgnore]
        public bool RedirectingDefaultCallTimeoutSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ServiceProviderReplacementCommunicationBarringHierarchicalRedirectingRuleList _redirectingRule;

        [XmlElement(ElementName = "redirectingRule", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderReplacementCommunicationBarringHierarchicalRedirectingRuleList RedirectingRule
        {
            get => _redirectingRule;
            set
            {
                RedirectingRuleSpecified = true;
                _redirectingRule = value;
            }
        }

        [XmlIgnore]
        public bool RedirectingRuleSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CommunicationBarringCallMeNowAction _callMeNowDefaultAction;

        [XmlElement(ElementName = "callMeNowDefaultAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
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
        public bool CallMeNowDefaultActionSpecified { get; set; }

        private int? _callMeNowDefaultCallTimeout;

        [XmlElement(ElementName = "callMeNowDefaultCallTimeout", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
        [MinInclusive(60)]
        [MaxInclusive(86400)]
        public int? CallMeNowDefaultCallTimeout
        {
            get => _callMeNowDefaultCallTimeout;
            set
            {
                CallMeNowDefaultCallTimeoutSpecified = true;
                _callMeNowDefaultCallTimeout = value;
            }
        }

        [XmlIgnore]
        public bool CallMeNowDefaultCallTimeoutSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ServiceProviderReplacementCommunicationBarringHierarchicalCallMeNowRuleList _callMeNowRule;

        [XmlElement(ElementName = "callMeNowRule", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderReplacementCommunicationBarringHierarchicalCallMeNowRuleList CallMeNowRule
        {
            get => _callMeNowRule;
            set
            {
                CallMeNowRuleSpecified = true;
                _callMeNowRule = value;
            }
        }

        [XmlIgnore]
        public bool CallMeNowRuleSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingAction _incomingDefaultAction;

        [XmlElement(ElementName = "incomingDefaultAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
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
        public bool IncomingDefaultActionSpecified { get; set; }

        private int? _incomingDefaultCallTimeout;

        [XmlElement(ElementName = "incomingDefaultCallTimeout", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
        [MinInclusive(60)]
        [MaxInclusive(86400)]
        public int? IncomingDefaultCallTimeout
        {
            get => _incomingDefaultCallTimeout;
            set
            {
                IncomingDefaultCallTimeoutSpecified = true;
                _incomingDefaultCallTimeout = value;
            }
        }

        [XmlIgnore]
        public bool IncomingDefaultCallTimeoutSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementCommunicationBarringIncomingRuleList19sp1 _incomingRule;

        [XmlElement(ElementName = "incomingRule", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
        public BroadWorksConnector.Ocip.Models.ReplacementCommunicationBarringIncomingRuleList19sp1 IncomingRule
        {
            get => _incomingRule;
            set
            {
                IncomingRuleSpecified = true;
                _incomingRule = value;
            }
        }

        [XmlIgnore]
        public bool IncomingRuleSpecified { get; set; }

        private bool _becomeDefault;

        [XmlElement(ElementName = "becomeDefault", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
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
        public bool BecomeDefaultSpecified { get; set; }

        private bool _applyToAttendedCallTransfers;

        [XmlElement(ElementName = "applyToAttendedCallTransfers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2075")]
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
        public bool ApplyToAttendedCallTransfersSpecified { get; set; }

    }
}
