using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Unassign a list of service provider DNs from the service provider IMRN pool. The DNs then become available for
    /// assignment to groups. It is possible to delete either: a single DN,
    /// or a list of DNs, or a range of DNs, or any combination thereof.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4719""}]")]
    public class ServiceProviderIMRNUnassignListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4719")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private List<string> _imrn = new List<string>();

        [XmlElement(ElementName = "imrn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4719")]
        [MinLength(1)]
        [MaxLength(23)]
        public List<string> Imrn
        {
            get => _imrn;
            set
            {
                ImrnSpecified = true;
                _imrn = value;
            }
        }

        [XmlIgnore]
        protected bool ImrnSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.DNRange> _imrnRange = new List<BroadWorksConnector.Ocip.Models.DNRange>();

        [XmlElement(ElementName = "imrnRange", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4719")]
        public List<BroadWorksConnector.Ocip.Models.DNRange> ImrnRange
        {
            get => _imrnRange;
            set
            {
                ImrnRangeSpecified = true;
                _imrnRange = value;
            }
        }

        [XmlIgnore]
        protected bool ImrnRangeSpecified { get; set; }

    }
}
