using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the reseller level data associated with Collaborate.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""939fd5846dfae8bdf58308d6cb9ebb12:494""}]")]
    public class ResellerCollaborateModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:494")]
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
        public bool ResellerIdSpecified { get; set; }

        private string _collaborateFromAddress;

        [XmlElement(ElementName = "collaborateFromAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:494")]
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
        public bool CollaborateFromAddressSpecified { get; set; }

    }
}
