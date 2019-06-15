using System;
using System.Xml.Serialization;
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
     
    public class SystemSessionAdmissionControlGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _countLongConnectionsToMediaServer;

        [XmlElement(ElementName = "countLongConnectionsToMediaServer", IsNullable = false, Namespace = "")]
        public bool CountLongConnectionsToMediaServer {
            get => _countLongConnectionsToMediaServer;
            set {
                CountLongConnectionsToMediaServerSpecified = true;
                _countLongConnectionsToMediaServer = value;
            }
        }

        [XmlIgnore]
        public bool CountLongConnectionsToMediaServerSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SessionAdmissionControlForMusicOnHoldType _sacHandlingForMoH;

        [XmlElement(ElementName = "sacHandlingForMoH", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SessionAdmissionControlForMusicOnHoldType SacHandlingForMoH {
            get => _sacHandlingForMoH;
            set {
                SacHandlingForMoHSpecified = true;
                _sacHandlingForMoH = value;
            }
        }

        [XmlIgnore]
        public bool SacHandlingForMoHSpecified { get; set; }
        
        private bool _blockVMDepositDueToSACLimits;

        [XmlElement(ElementName = "blockVMDepositDueToSACLimits", IsNullable = false, Namespace = "")]
        public bool BlockVMDepositDueToSACLimits {
            get => _blockVMDepositDueToSACLimits;
            set {
                BlockVMDepositDueToSACLimitsSpecified = true;
                _blockVMDepositDueToSACLimits = value;
            }
        }

        [XmlIgnore]
        public bool BlockVMDepositDueToSACLimitsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SessionAdmissionControlCodecSelectionPolicyType _sacCodecSelectionPolicy;

        [XmlElement(ElementName = "sacCodecSelectionPolicy", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SessionAdmissionControlCodecSelectionPolicyType SacCodecSelectionPolicy {
            get => _sacCodecSelectionPolicy;
            set {
                SacCodecSelectionPolicySpecified = true;
                _sacCodecSelectionPolicy = value;
            }
        }

        [XmlIgnore]
        public bool SacCodecSelectionPolicySpecified { get; set; }
        
        private bool _countCallToMobileNumberForSACSubscriber;

        [XmlElement(ElementName = "countCallToMobileNumberForSACSubscriber", IsNullable = false, Namespace = "")]
        public bool CountCallToMobileNumberForSACSubscriber {
            get => _countCallToMobileNumberForSACSubscriber;
            set {
                CountCallToMobileNumberForSACSubscriberSpecified = true;
                _countCallToMobileNumberForSACSubscriber = value;
            }
        }

        [XmlIgnore]
        public bool CountCallToMobileNumberForSACSubscriberSpecified { get; set; }
        
        private bool _countBWAnywhereForSACSubscriber;

        [XmlElement(ElementName = "countBWAnywhereForSACSubscriber", IsNullable = false, Namespace = "")]
        public bool CountBWAnywhereForSACSubscriber {
            get => _countBWAnywhereForSACSubscriber;
            set {
                CountBWAnywhereForSACSubscriberSpecified = true;
                _countBWAnywhereForSACSubscriber = value;
            }
        }

        [XmlIgnore]
        public bool CountBWAnywhereForSACSubscriberSpecified { get; set; }
        
        private bool _countROForSACSubscriber;

        [XmlElement(ElementName = "countROForSACSubscriber", IsNullable = false, Namespace = "")]
        public bool CountROForSACSubscriber {
            get => _countROForSACSubscriber;
            set {
                CountROForSACSubscriberSpecified = true;
                _countROForSACSubscriber = value;
            }
        }

        [XmlIgnore]
        public bool CountROForSACSubscriberSpecified { get; set; }
        
        private bool _excludeBWMobilityForSACSubscriber;

        [XmlElement(ElementName = "excludeBWMobilityForSACSubscriber", IsNullable = false, Namespace = "")]
        public bool ExcludeBWMobilityForSACSubscriber {
            get => _excludeBWMobilityForSACSubscriber;
            set {
                ExcludeBWMobilityForSACSubscriberSpecified = true;
                _excludeBWMobilityForSACSubscriber = value;
            }
        }

        [XmlIgnore]
        public bool ExcludeBWMobilityForSACSubscriberSpecified { get; set; }
        
    }
}
