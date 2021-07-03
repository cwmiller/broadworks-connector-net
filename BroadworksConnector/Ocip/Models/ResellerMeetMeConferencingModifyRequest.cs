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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0fd24121d16995c994d40bc408dbcfa5:380""}]")]
    public class ResellerMeetMeConferencingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:380")]
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

        private string _conferenceFromAddress;

        [XmlElement(ElementName = "conferenceFromAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:380")]
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

        private int _maxAllocatedPorts;

        [XmlElement(ElementName = "maxAllocatedPorts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:380")]
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

        private bool _disableUnlimitedMeetMePorts;

        [XmlElement(ElementName = "disableUnlimitedMeetMePorts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:380")]
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

        private bool _enableMaxAllocatedPorts;

        [XmlElement(ElementName = "enableMaxAllocatedPorts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:380")]
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
