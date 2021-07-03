using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a carrier from the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// An ErrorResponse is returned if the carrier is in use, or if the carrier didn't exist prior to deletion..
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""74a46a9bfccb54713c1d19735843f1df:342""}]")]
    public class SystemPreferredCarrierDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _carrier;

        [XmlElement(ElementName = "carrier", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:342")]
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
        protected bool CarrierSpecified { get; set; }

    }
}
