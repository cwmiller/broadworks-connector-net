using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupMeetMeConferencingGetInstanceRequest17sp4.
    /// Contains the service profile information and a table of assigned hosts.
    /// The table has column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name", and "Hiragana
    /// First Name".
    /// <see cref="GroupMeetMeConferencingGetInstanceRequest17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:19821""}]")]
    public class GroupMeetMeConferencingGetInstanceResponse17sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile17sp4 _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19821")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile17sp4 ServiceInstanceProfile
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19821")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19821")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19821")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19821")]
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

        private BroadWorksConnector.Ocip.Models.C.OCITable _conferenceHostUserTable;

        [XmlElement(ElementName = "conferenceHostUserTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19821")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ConferenceHostUserTable
        {
            get => _conferenceHostUserTable;
            set
            {
                ConferenceHostUserTableSpecified = true;
                _conferenceHostUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceHostUserTableSpecified { get; set; }

    }
}
