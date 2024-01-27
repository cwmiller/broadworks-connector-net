using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the reseller profile.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d45e381d6dbac771631649063122a42e:671"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""d45e381d6dbac771631649063122a42e:672""}]}]")]
    public class ResellerModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Group(@"d45e381d6dbac771631649063122a42e:672")]
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

        protected string _resellerExternalId;

        [XmlElement(ElementName = "resellerExternalId", IsNullable = false, Namespace = "")]
        [Group(@"d45e381d6dbac771631649063122a42e:672")]
        [MaxLength(36)]
        public string ResellerExternalId
        {
            get => _resellerExternalId;
            set
            {
                ResellerExternalIdSpecified = true;
                _resellerExternalId = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerExternalIdSpecified { get; set; }

        protected string _resellerName;

        [XmlElement(ElementName = "resellerName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d45e381d6dbac771631649063122a42e:671")]
        [MinLength(1)]
        [MaxLength(320)]
        public string ResellerName
        {
            get => _resellerName;
            set
            {
                ResellerNameSpecified = true;
                _resellerName = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerNameSpecified { get; set; }

    }
}
