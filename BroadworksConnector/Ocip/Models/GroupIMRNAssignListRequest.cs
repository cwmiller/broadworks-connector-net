using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Assign a list of group DNs to the IMRN pool. It is possible to assign either: a single DN,
    /// or a list of DNs, or a range of DNs, or any combination thereof.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:5330""}]")]
    public class GroupIMRNAssignListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5330")]
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

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5330")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private List<string> _imrn = new List<string>();

        [XmlElement(ElementName = "imrn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5330")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5330")]
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
