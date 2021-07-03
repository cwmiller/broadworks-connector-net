using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupMeetMeConferencingGetRequest.
    /// <see cref="GroupMeetMeConferencingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0fd24121d16995c994d40bc408dbcfa5:256""}]")]
    public class GroupMeetMeConferencingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferencePorts _availablePorts;

        [XmlElement(ElementName = "availablePorts", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:256")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferencePorts AvailablePorts
        {
            get => _availablePorts;
            set
            {
                AvailablePortsSpecified = true;
                _availablePorts = value;
            }
        }

        [XmlIgnore]
        protected bool AvailablePortsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferencePorts _allocatedPorts;

        [XmlElement(ElementName = "allocatedPorts", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:256")]
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

    }
}
