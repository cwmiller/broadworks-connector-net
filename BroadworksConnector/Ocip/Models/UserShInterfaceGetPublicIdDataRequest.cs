using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Returns the Sh non-transparent data stored against a Public User Identity (a SIP URI
    /// or TEL URI).
    /// The response is either a UserShInterfaceGetPublicIdDataResponse or an ErrorResponse.
    /// 
    /// Replaced by: UserShInterfaceGetPublicIdDataRequest21sp1.
    /// <see cref="UserShInterfaceGetPublicIdDataResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserShInterfaceGetPublicIdDataRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:7757""}]")]
    public class UserShInterfaceGetPublicIdDataRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.PublicUserIdentity _publicUserIdentity;

        [XmlElement(ElementName = "publicUserIdentity", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7757")]
        public BroadWorksConnector.Ocip.Models.PublicUserIdentity PublicUserIdentity
        {
            get => _publicUserIdentity;
            set
            {
                PublicUserIdentitySpecified = true;
                _publicUserIdentity = value;
            }
        }

        [XmlIgnore]
        public bool PublicUserIdentitySpecified { get; set; }

    }
}
