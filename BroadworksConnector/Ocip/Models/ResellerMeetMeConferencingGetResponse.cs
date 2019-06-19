using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ResellerMeetMeConferencingGetRequest.
    /// <see cref="ResellerMeetMeConferencingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0fd24121d16995c994d40bc408dbcfa5:350""}]")]
    public class ResellerMeetMeConferencingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _conferenceFromAddress;

        [XmlElement(ElementName = "conferenceFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:350")]
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
        public bool ConferenceFromAddressSpecified { get; set; }

        private int _maxAllocatedPorts;

        [XmlElement(ElementName = "maxAllocatedPorts", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:350")]
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
        public bool MaxAllocatedPortsSpecified { get; set; }

    }
}
