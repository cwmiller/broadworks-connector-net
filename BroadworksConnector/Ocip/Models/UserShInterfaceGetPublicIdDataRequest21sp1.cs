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
    /// The response is either a UserShInterfaceGetPublicIdDataResponse21sp1 or an ErrorResponse.
    /// <see cref="UserShInterfaceGetPublicIdDataResponse21sp1"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:3964""}]")]
    public class UserShInterfaceGetPublicIdDataRequest21sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserShInterfaceGetPublicIdDataResponse21sp1>
    {

        protected BroadWorksConnector.Ocip.Models.PublicUserIdentity _publicUserIdentity;

        [XmlElement(ElementName = "publicUserIdentity", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3964")]
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
        protected bool PublicUserIdentitySpecified { get; set; }

    }
}
