using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ResellerCollaborateGetRequest.
    /// <see cref="ResellerCollaborateGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""bc805893b9cc7e3e01eec64e9ad62768:478""}]")]
    public class ResellerCollaborateGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _collaborateFromAddress;

        [XmlElement(ElementName = "collaborateFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc805893b9cc7e3e01eec64e9ad62768:478")]
        [MinLength(1)]
        [MaxLength(80)]
        public string CollaborateFromAddress
        {
            get => _collaborateFromAddress;
            set
            {
                CollaborateFromAddressSpecified = true;
                _collaborateFromAddress = value;
            }
        }

        [XmlIgnore]
        protected bool CollaborateFromAddressSpecified { get; set; }

    }
}
