using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a Meet-Me Conferencing bridge to a group.
    /// The domain is required in the serviceUserId.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:19701""}]")]
    public class GroupMeetMeConferencingAddInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19701")]
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

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19701")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19701")]
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

        private BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19701")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile ServiceInstanceProfile
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

        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferencePorts _allocatedPorts;

        [XmlElement(ElementName = "allocatedPorts", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19701")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferencePorts AllocatedPorts
        {
            get => _allocatedPorts;
            set
            {
                AllocatedPortsSpecified = true;
                _allocatedPorts = value;
            }
        }

        [XmlIgnore]
        protected bool AllocatedPortsSpecified { get; set; }

        private string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19701")]
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

        private bool _allowIndividualOutDial;

        [XmlElement(ElementName = "allowIndividualOutDial", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19701")]
        public bool AllowIndividualOutDial
        {
            get => _allowIndividualOutDial;
            set
            {
                AllowIndividualOutDialSpecified = true;
                _allowIndividualOutDial = value;
            }
        }

        [XmlIgnore]
        protected bool AllowIndividualOutDialSpecified { get; set; }

        private string _operatorNumber;

        [XmlElement(ElementName = "operatorNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19701")]
        [MinLength(1)]
        [MaxLength(161)]
        public string OperatorNumber
        {
            get => _operatorNumber;
            set
            {
                OperatorNumberSpecified = true;
                _operatorNumber = value;
            }
        }

        [XmlIgnore]
        protected bool OperatorNumberSpecified { get; set; }

        private List<string> _conferenceHostUserId = new List<string>();

        [XmlElement(ElementName = "conferenceHostUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19701")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> ConferenceHostUserId
        {
            get => _conferenceHostUserId;
            set
            {
                ConferenceHostUserIdSpecified = true;
                _conferenceHostUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceHostUserIdSpecified { get; set; }

    }
}
