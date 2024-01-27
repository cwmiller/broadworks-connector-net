using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderDnGetStatusListRequest.
    /// <see cref="ServiceProviderDnGetStatusListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:3951""}]")]
    public class ServiceProviderDnGetStatusListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.DNValidationStatusMessage> _dnStatus = new List<BroadWorksConnector.Ocip.Models.DNValidationStatusMessage>();

        [XmlElement(ElementName = "dnStatus", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3951")]
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
