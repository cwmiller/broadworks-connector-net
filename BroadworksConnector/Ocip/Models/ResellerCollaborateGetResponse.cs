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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""939fd5846dfae8bdf58308d6cb9ebb12:479""}]")]
    public class ResellerCollaborateGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _collaborateFromAddress;

        [XmlElement(ElementName = "collaborateFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:479")]
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
