using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSessionAdmissionControlGetRequest.
    /// The response contains the session admission control settings for the system.
    /// 
    /// Replaced by: SystemSessionAdmissionControlGetResponse21sp1.
    /// <see cref="SystemSessionAdmissionControlGetRequest"/>
    /// <see cref="SystemSessionAdmissionControlGetResponse21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:5621""}]")]
    public class SystemSessionAdmissionControlGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _countLongConnectionsToMediaServer;

        [XmlElement(ElementName = "countLongConnectionsToMediaServer", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5621")]
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
        public bool CountLongConnectionsToMediaServerSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SessionAdmissionControlForMusicOnHoldType _sacHandlingForMoH;

        [XmlElement(ElementName = "sacHandlingForMoH", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5621")]
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
        public bool SacHandlingForMoHSpecified { get; set; }

        private bool _blockVMDepositDueToSACLimits;

        [XmlElement(ElementName = "blockVMDepositDueToSACLimits", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5621")]
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
        public bool BlockVMDepositDueToSACLimitsSpecified { get; set; }

    }
}
