using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupCollaborateBridgeGetInstanceRequest20sp1.
    /// The system-level collaborate supportOutdial setting is returned in the response when the system-level collaborate
    /// supportOutdial setting is disabled.
    /// Contains the service profile information and a table of assigned owners.
    /// The table has column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name",
    /// "Hiragana First Name", Phone Number", "Extension", "Department", "Email Address",
    /// "Is Phone Number Activated", "Country Code", "National Prefix", "Department Name",
    /// "Department Type", "Parent Department", "Parent Department Type", "Group Id", "Group Name".
    /// Collaborate bridge maximum participant’s choices unlimited or a quantified number of participants.
    /// <see cref="GroupCollaborateBridgeGetInstanceRequest20sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""939fd5846dfae8bdf58308d6cb9ebb12:417""}]")]
    public class GroupCollaborateBridgeGetInstanceResponse20sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:417")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 ServiceInstanceProfile
        {
            get => _serviceInstanceProfile;
            set
            {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceInstanceProfileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CollaborateBridgeMaximumParticipants _maximumBridgeParticipants;

        [XmlElement(ElementName = "maximumBridgeParticipants", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:417")]
        public BroadWorksConnector.Ocip.Models.CollaborateBridgeMaximumParticipants MaximumBridgeParticipants
        {
            get => _maximumBridgeParticipants;
            set
            {
                MaximumBridgeParticipantsSpecified = true;
                _maximumBridgeParticipants = value;
            }
        }

        [XmlIgnore]
        protected bool MaximumBridgeParticipantsSpecified { get; set; }

        private string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:417")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NetworkClassOfService
        {
            get => _networkClassOfService;
            set
            {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkClassOfServiceSpecified { get; set; }

        private bool _isDefault;

        [XmlElement(ElementName = "isDefault", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:417")]
        public bool IsDefault
        {
            get => _isDefault;
            set
            {
                IsDefaultSpecified = true;
                _isDefault = value;
            }
        }

        [XmlIgnore]
        protected bool IsDefaultSpecified { get; set; }

        private int _maxCollaborateRoomParticipants;

        [XmlElement(ElementName = "maxCollaborateRoomParticipants", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:417")]
        [MinInclusive(3)]
        [MaxInclusive(145)]
        public int MaxCollaborateRoomParticipants
        {
            get => _maxCollaborateRoomParticipants;
            set
            {
                MaxCollaborateRoomParticipantsSpecified = true;
                _maxCollaborateRoomParticipants = value;
            }
        }

        [XmlIgnore]
        protected bool MaxCollaborateRoomParticipantsSpecified { get; set; }

        private bool _supportOutdial;

        [XmlElement(ElementName = "supportOutdial", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:417")]
        public bool SupportOutdial
        {
            get => _supportOutdial;
            set
            {
                SupportOutdialSpecified = true;
                _supportOutdial = value;
            }
        }

        [XmlIgnore]
        protected bool SupportOutdialSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _collaborateOwnerUserTable;

        [XmlElement(ElementName = "collaborateOwnerUserTable", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:417")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CollaborateOwnerUserTable
        {
            get => _collaborateOwnerUserTable;
            set
            {
                CollaborateOwnerUserTableSpecified = true;
                _collaborateOwnerUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool CollaborateOwnerUserTableSpecified { get; set; }

    }
}
