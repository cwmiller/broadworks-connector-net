using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a Collaborate bridge.
    /// The request fails when the collaborateOwnerUserIdList is included in the request for the default collaborate bridge.
    /// The request fails when the supportOutdial is included in the request and the system-level collaborate supportOutdial setting is disabled.
    /// When phone numbers are un-assigned from the user, the unused numbers may be un-assigned from the group and service provider. If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group if the command is executed by a service provider administrator or above.
    /// When set to 'Service Provider', they will be un-assigned from the group and service provider if the command is executed by a provisioning administrator or above.
    /// When omitted, the number(s) will be left assigned to the group.
    /// An ErrorResponse will be returned if any number cannot be unassigned because of insufficient privilege.
    /// 
    /// If the phoneNumber has not been assigned to the group and addPhoneNumberToGroup is set to true, it will be added to group if needed if the command is executed by a service provider administrator and above. The command will fail otherwise.
    /// 
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="ErrorResponse"/>
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""939fd5846dfae8bdf58308d6cb9ebb12:162""}]")]
    public class GroupCollaborateBridgeConsolidatedModifyInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:162")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UnassignPhoneNumbersLevel _unassignPhoneNumbers;

        [XmlElement(ElementName = "unassignPhoneNumbers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:162")]
        public BroadWorksConnector.Ocip.Models.UnassignPhoneNumbersLevel UnassignPhoneNumbers
        {
            get => _unassignPhoneNumbers;
            set
            {
                UnassignPhoneNumbersSpecified = true;
                _unassignPhoneNumbers = value;
            }
        }

        [XmlIgnore]
        protected bool UnassignPhoneNumbersSpecified { get; set; }

        private bool _addPhoneNumberToGroup;

        [XmlElement(ElementName = "addPhoneNumberToGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:162")]
        public bool AddPhoneNumberToGroup
        {
            get => _addPhoneNumberToGroup;
            set
            {
                AddPhoneNumberToGroupSpecified = true;
                _addPhoneNumberToGroup = value;
            }
        }

        [XmlIgnore]
        protected bool AddPhoneNumberToGroupSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:162")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile
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
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:162")]
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
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:162")]
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

        private int _maxCollaborateRoomParticipants;

        [XmlElement(ElementName = "maxCollaborateRoomParticipants", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:162")]
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
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:162")]
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

        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _collaborateOwnerUserIdList;

        [XmlElement(ElementName = "collaborateOwnerUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:162")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList CollaborateOwnerUserIdList
        {
            get => _collaborateOwnerUserIdList;
            set
            {
                CollaborateOwnerUserIdListSpecified = true;
                _collaborateOwnerUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool CollaborateOwnerUserIdListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementConsolidatedUserServiceAssignmentList _serviceList;

        [XmlElement(ElementName = "serviceList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:162")]
        public BroadWorksConnector.Ocip.Models.ReplacementConsolidatedUserServiceAssignmentList ServiceList
        {
            get => _serviceList;
            set
            {
                ServiceListSpecified = true;
                _serviceList = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceListSpecified { get; set; }

    }
}
