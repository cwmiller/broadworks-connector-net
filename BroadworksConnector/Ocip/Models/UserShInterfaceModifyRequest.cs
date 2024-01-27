using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the Sh Interface non-transparent data associated with a Public User Identity.
    /// The response is a SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:4036""}]")]
    public class UserShInterfaceModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected BroadWorksConnector.Ocip.Models.PublicUserIdentity _publicUserIdentity;

        [XmlElement(ElementName = "publicUserIdentity", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4036")]
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

        protected string _sCSCFName;

        [XmlElement(ElementName = "SCSCFName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4036")]
        [MinLength(1)]
        [MaxLength(161)]
        public string SCSCFName
        {
            get => _sCSCFName;
            set
            {
                SCSCFNameSpecified = true;
                _sCSCFName = value;
            }
        }

        [XmlIgnore]
        protected bool SCSCFNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.IMSUserState _iMSUserState;

        [XmlElement(ElementName = "IMSUserState", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4036")]
        public BroadWorksConnector.Ocip.Models.IMSUserState IMSUserState
        {
            get => _iMSUserState;
            set
            {
                IMSUserStateSpecified = true;
                _iMSUserState = value;
            }
        }

        [XmlIgnore]
        protected bool IMSUserStateSpecified { get; set; }

    }
}
