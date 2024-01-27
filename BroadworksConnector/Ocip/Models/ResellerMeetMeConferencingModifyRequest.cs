using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the reseller level data associated with Meet-Me Conferencing functions.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The following data elements are only modified for System and Provisioning Administrators:
    /// maxAllocatedPorts.
    /// The following data elements are only modified for System and Provisioning Administrators and AS Mode only:
    /// disableUnlimitedMeetMePorts,
    /// enableMaxAllocatedPorts.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""adf25df72505d1c476ebb480b6cce18d:379""}]")]
    public class ResellerMeetMeConferencingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:379")]
        [MinLength(1)]
        [MaxLength(36)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerIdSpecified { get; set; }

        protected string _conferenceFromAddress;

        [XmlElement(ElementName = "conferenceFromAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:379")]
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
        [Group(@"adf25df72505d1c476ebb480b6cce18d:379")]
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
        [Group(@"adf25df72505d1c476ebb480b6cce18d:379")]
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
        [Group(@"adf25df72505d1c476ebb480b6cce18d:379")]
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
