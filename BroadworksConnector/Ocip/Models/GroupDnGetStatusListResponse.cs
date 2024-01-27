using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDnGetStatusListRequest.
    /// <see cref="GroupDnGetStatusListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:5066""}]")]
    public class GroupDnGetStatusListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.DNValidationStatusMessage> _dnStatus = new List<BroadWorksConnector.Ocip.Models.DNValidationStatusMessage>();

        [XmlElement(ElementName = "dnStatus", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5066")]
        public List<BroadWorksConnector.Ocip.Models.DNValidationStatusMessage> DnStatus
        {
            get => _dnStatus;
            set
            {
                DnStatusSpecified = true;
                _dnStatus = value;
            }
        }

        [XmlIgnore]
        protected bool DnStatusSpecified { get; set; }

    }
}
