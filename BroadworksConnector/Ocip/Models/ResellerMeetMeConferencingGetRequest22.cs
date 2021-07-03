using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the reseller level data associated with Meet-Me Conferencing functions.
    /// The response is either a ResellerMeetMeConferencingGetResponse22 or an
    /// ErrorResponse.
    /// The following data elements are only returned for System and Provisioning Administrators:
    /// maxAllocatedPorts.
    /// The following data elements are only returned for System and Provisioning Administrators and AS Mode Only:
    /// disableUnlimitedMeetMePorts,
    /// enableMaxAllocatedPorts.
    /// <see cref="ResellerMeetMeConferencingGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0fd24121d16995c994d40bc408dbcfa5:341""}]")]
    public class ResellerMeetMeConferencingGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:341")]
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

    }
}
