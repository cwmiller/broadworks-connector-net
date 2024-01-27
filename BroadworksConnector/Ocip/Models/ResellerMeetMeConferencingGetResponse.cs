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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:5144""}]")]
    public class ResellerMeetMeConferencingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _conferenceFromAddress;

        [XmlElement(ElementName = "conferenceFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5144")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:5144")]
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

    }
}
