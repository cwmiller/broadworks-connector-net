using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the profile for a reseller.
    /// The response is either ResellerGetResponse or ErrorResponse.
    /// 
    /// Replaced by: ResellerGetRequest22
    /// <see cref="ResellerGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ResellerGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:16512""}]")]
    public class ResellerGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ResellerGetResponse>
    {

        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16512")]
        [MinLength(1)]
        [MaxLength(30)]
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
