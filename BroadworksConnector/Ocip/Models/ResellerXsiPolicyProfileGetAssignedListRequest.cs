using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of Xsi policy profile assigned.
    /// The response is either a ResellerXsiPolicyProfileGetAssignedListResponse
    /// or an ErrorResponse.
    /// <see cref="ResellerXsiPolicyProfileGetAssignedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d45e381d6dbac771631649063122a42e:982""}]")]
    public class ResellerXsiPolicyProfileGetAssignedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ResellerXsiPolicyProfileGetAssignedListResponse>
    {

        protected string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Group(@"d45e381d6dbac771631649063122a42e:982")]
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

        protected BroadWorksConnector.Ocip.Models.XsiPolicyProfileLevel _level;

        [XmlElement(ElementName = "level", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d45e381d6dbac771631649063122a42e:982")]
        public BroadWorksConnector.Ocip.Models.XsiPolicyProfileLevel Level
        {
            get => _level;
            set
            {
                LevelSpecified = true;
                _level = value;
            }
        }

        [XmlIgnore]
        protected bool LevelSpecified { get; set; }

    }
}
