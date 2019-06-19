using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the attributes of carrier.
    /// The response is either a SystemPreferredCarrierGetResponse or an ErrorResponse.
    /// <see cref="SystemPreferredCarrierGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""74a46a9bfccb54713c1d19735843f1df:432""}]")]
    public class SystemPreferredCarrierGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _carrier;

        [XmlElement(ElementName = "carrier", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:432")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Carrier
        {
            get => _carrier;
            set
            {
                CarrierSpecified = true;
                _carrier = value;
            }
        }

        [XmlIgnore]
        public bool CarrierSpecified { get; set; }

    }
}
