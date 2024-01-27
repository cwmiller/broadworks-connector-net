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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:4798""}]")]
    public class ServiceProviderIMRNUnassignListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4798")]
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

        protected List<string> _imrn = new List<string>();

        [XmlElement(ElementName = "imrn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4798")]
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

        protected List<BroadWorksConnector.Ocip.Models.DNRange> _imrnRange = new List<BroadWorksConnector.Ocip.Models.DNRange>();

        [XmlElement(ElementName = "imrnRange", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4798")]
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
