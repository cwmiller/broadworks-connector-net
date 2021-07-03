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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:3873""}]")]
    public class ServiceProviderDnGetStatusListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.DNValidationStatusMessage> _dnStatus = new List<BroadWorksConnector.Ocip.Models.DNValidationStatusMessage>();

        [XmlElement(ElementName = "dnStatus", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3873")]
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
