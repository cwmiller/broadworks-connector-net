using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a client identity entry to the list of client identities in the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:5362""}]")]
    public class SystemClientIdentityAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _clientIdentity;

        [XmlElement(ElementName = "clientIdentity", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5362")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ClientIdentity
        {
            get => _clientIdentity;
            set
            {
                ClientIdentitySpecified = true;
                _clientIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool ClientIdentitySpecified { get; set; }

    }
}
