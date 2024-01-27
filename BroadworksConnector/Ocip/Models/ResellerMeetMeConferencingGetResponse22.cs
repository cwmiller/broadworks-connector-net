using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ResellerMeetMeConferencingGetRequest22.
    /// <see cref="ResellerMeetMeConferencingGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""adf25df72505d1c476ebb480b6cce18d:355""}]")]
    public class ResellerMeetMeConferencingGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _conferenceFromAddress;

        [XmlElement(ElementName = "conferenceFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:355")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ConferenceFromAddress
        {
            get => _conferenceFromAddress;
            set
            {
                ConferenceFromAddressSpecified = true;
                _conferenceFromAddress = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceFromAddressSpecified { get; set; }

        protected int _maxAllocatedPorts;

        [XmlElement(ElementName = "maxAllocatedPorts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:355")]
        [MinInclusive(0)]
        [MaxInclusive(999999)]
        public int MaxAllocatedPorts
        {
            get => _maxAllocatedPorts;
            set
            {
                MaxAllocatedPortsSpecified = true;
                _maxAllocatedPorts = value;
            }
        }

        [XmlIgnore]
        protected bool MaxAllocatedPortsSpecified { get; set; }

        protected bool _disableUnlimitedMeetMePorts;

        [XmlElement(ElementName = "disableUnlimitedMeetMePorts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:355")]
        public bool DisableUnlimitedMeetMePorts
        {
            get => _disableUnlimitedMeetMePorts;
            set
            {
                DisableUnlimitedMeetMePortsSpecified = true;
                _disableUnlimitedMeetMePorts = value;
            }
        }

        [XmlIgnore]
        protected bool DisableUnlimitedMeetMePortsSpecified { get; set; }

        protected bool _enableMaxAllocatedPorts;

        [XmlElement(ElementName = "enableMaxAllocatedPorts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:355")]
        public bool EnableMaxAllocatedPorts
        {
            get => _enableMaxAllocatedPorts;
            set
            {
                EnableMaxAllocatedPortsSpecified = true;
                _enableMaxAllocatedPorts = value;
            }
        }

        [XmlIgnore]
        protected bool EnableMaxAllocatedPortsSpecified { get; set; }

    }
}
