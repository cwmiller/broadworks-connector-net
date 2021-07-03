using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSessionAdmissionControlGetRequest22.
    /// The response contains the session admission control settings for the system.
    /// <see cref="SystemSessionAdmissionControlGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:29227""}]")]
    public class SystemSessionAdmissionControlGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _countLongConnectionsToMediaServer;

        [XmlElement(ElementName = "countLongConnectionsToMediaServer", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29227")]
        public bool CountLongConnectionsToMediaServer
        {
            get => _countLongConnectionsToMediaServer;
            set
            {
                CountLongConnectionsToMediaServerSpecified = true;
                _countLongConnectionsToMediaServer = value;
            }
        }

        [XmlIgnore]
        protected bool CountLongConnectionsToMediaServerSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SessionAdmissionControlForMusicOnHoldType _sacHandlingForMoH;

        [XmlElement(ElementName = "sacHandlingForMoH", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29227")]
        public BroadWorksConnector.Ocip.Models.SessionAdmissionControlForMusicOnHoldType SacHandlingForMoH
        {
            get => _sacHandlingForMoH;
            set
            {
                SacHandlingForMoHSpecified = true;
                _sacHandlingForMoH = value;
            }
        }

        [XmlIgnore]
        protected bool SacHandlingForMoHSpecified { get; set; }

        private bool _blockVMDepositDueToSACLimits;

        [XmlElement(ElementName = "blockVMDepositDueToSACLimits", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29227")]
        public bool BlockVMDepositDueToSACLimits
        {
            get => _blockVMDepositDueToSACLimits;
            set
            {
                BlockVMDepositDueToSACLimitsSpecified = true;
                _blockVMDepositDueToSACLimits = value;
            }
        }

        [XmlIgnore]
        protected bool BlockVMDepositDueToSACLimitsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SessionAdmissionControlCodecSelectionPolicyType _sacCodecSelectionPolicy;

        [XmlElement(ElementName = "sacCodecSelectionPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29227")]
        public BroadWorksConnector.Ocip.Models.SessionAdmissionControlCodecSelectionPolicyType SacCodecSelectionPolicy
        {
            get => _sacCodecSelectionPolicy;
            set
            {
                SacCodecSelectionPolicySpecified = true;
                _sacCodecSelectionPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool SacCodecSelectionPolicySpecified { get; set; }

        private bool _countCallToMobileNumberForSACSubscriber;

        [XmlElement(ElementName = "countCallToMobileNumberForSACSubscriber", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29227")]
        public bool CountCallToMobileNumberForSACSubscriber
        {
            get => _countCallToMobileNumberForSACSubscriber;
            set
            {
                CountCallToMobileNumberForSACSubscriberSpecified = true;
                _countCallToMobileNumberForSACSubscriber = value;
            }
        }

        [XmlIgnore]
        protected bool CountCallToMobileNumberForSACSubscriberSpecified { get; set; }

        private bool _countBWAnywhereForSACSubscriber;

        [XmlElement(ElementName = "countBWAnywhereForSACSubscriber", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29227")]
        public bool CountBWAnywhereForSACSubscriber
        {
            get => _countBWAnywhereForSACSubscriber;
            set
            {
                CountBWAnywhereForSACSubscriberSpecified = true;
                _countBWAnywhereForSACSubscriber = value;
            }
        }

        [XmlIgnore]
        protected bool CountBWAnywhereForSACSubscriberSpecified { get; set; }

        private bool _countROForSACSubscriber;

        [XmlElement(ElementName = "countROForSACSubscriber", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29227")]
        public bool CountROForSACSubscriber
        {
            get => _countROForSACSubscriber;
            set
            {
                CountROForSACSubscriberSpecified = true;
                _countROForSACSubscriber = value;
            }
        }

        [XmlIgnore]
        protected bool CountROForSACSubscriberSpecified { get; set; }

        private bool _excludeBWMobilityForSACSubscriber;

        [XmlElement(ElementName = "excludeBWMobilityForSACSubscriber", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29227")]
        public bool ExcludeBWMobilityForSACSubscriber
        {
            get => _excludeBWMobilityForSACSubscriber;
            set
            {
                ExcludeBWMobilityForSACSubscriberSpecified = true;
                _excludeBWMobilityForSACSubscriber = value;
            }
        }

        [XmlIgnore]
        protected bool ExcludeBWMobilityForSACSubscriberSpecified { get; set; }

    }
}
