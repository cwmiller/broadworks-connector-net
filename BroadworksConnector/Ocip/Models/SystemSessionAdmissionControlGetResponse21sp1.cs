using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSessionAdmissionControlGetRequest21sp1.
    /// The response contains the session admission control settings for the system.
    /// 
    /// Replaced by: SystemSessionAdmissionControlGetResponse22.
    /// <see cref="SystemSessionAdmissionControlGetRequest21sp1"/>
    /// <see cref="SystemSessionAdmissionControlGetResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:29756""}]")]
    public class SystemSessionAdmissionControlGetResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _countLongConnectionsToMediaServer;

        [XmlElement(ElementName = "countLongConnectionsToMediaServer", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:29756")]
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

        protected BroadWorksConnector.Ocip.Models.SessionAdmissionControlForMusicOnHoldType _sacHandlingForMoH;

        [XmlElement(ElementName = "sacHandlingForMoH", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:29756")]
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

        protected bool _blockVMDepositDueToSACLimits;

        [XmlElement(ElementName = "blockVMDepositDueToSACLimits", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:29756")]
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

        protected BroadWorksConnector.Ocip.Models.SessionAdmissionControlCodecSelectionPolicyType _sacCodecSelectionPolicy;

        [XmlElement(ElementName = "sacCodecSelectionPolicy", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:29756")]
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

    }
}
