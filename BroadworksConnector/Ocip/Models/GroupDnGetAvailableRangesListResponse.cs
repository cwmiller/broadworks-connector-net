using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupDnGetAvailableRangesListRequest.
    /// The response contains the list of group DNs that are not assigned to user, service instances or IMRN pool.
    /// The Dns are returned in a list of DNs or DN ranges and formated in E164 format for display.
    /// <see cref="GroupDnGetAvailableRangesListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:4958""}]")]
    public class GroupDnGetAvailableRangesListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _phoneNumber = new List<string>();

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:4958")]
        public List<string> PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneNumberSpecified { get; set; }

    }
}
