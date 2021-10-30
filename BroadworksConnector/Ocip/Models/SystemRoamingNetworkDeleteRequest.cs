using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a Roaming Network.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14958""}]")]
    public class SystemRoamingNetworkDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _mscAddress;

        [XmlElement(ElementName = "mscAddress", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14958")]
        [MinLength(1)]
        [MaxLength(23)]
        public string MscAddress
        {
            get => _mscAddress;
            set
            {
                MscAddressSpecified = true;
                _mscAddress = value;
            }
        }

        [XmlIgnore]
        protected bool MscAddressSpecified { get; set; }

    }
}
