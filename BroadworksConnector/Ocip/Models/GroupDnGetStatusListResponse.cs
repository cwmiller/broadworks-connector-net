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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:5330""}]")]
    public class GroupDnGetStatusListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.DNValidationStatusMessage> _dnStatus = new List<BroadWorksConnector.Ocip.Models.DNValidationStatusMessage>();

        [XmlElement(ElementName = "dnStatus", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5330")]
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
