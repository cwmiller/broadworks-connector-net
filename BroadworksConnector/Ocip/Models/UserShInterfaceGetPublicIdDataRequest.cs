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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:18833""}]")]
    public class UserShInterfaceGetPublicIdDataRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserShInterfaceGetPublicIdDataResponse>
    {

        protected BroadWorksConnector.Ocip.Models.PublicUserIdentity _publicUserIdentity;

        [XmlElement(ElementName = "publicUserIdentity", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18833")]
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
