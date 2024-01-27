using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of Network Classes of Service assigned to a reseller.
    /// The response is either a ResellerNetworkClassOfServiceGetAssignedListResponse
    /// or an ErorResponse.
    /// <see cref="ResellerNetworkClassOfServiceGetAssignedListResponse"/>
    /// <see cref="ErorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d45e381d6dbac771631649063122a42e:711""}]")]
    public class ResellerNetworkClassOfServiceGetAssignedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ResellerNetworkClassOfServiceGetAssignedListResponse>
    {

        protected string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Group(@"d45e381d6dbac771631649063122a42e:711")]
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

    }
}
