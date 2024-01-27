using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserShInterfaceGetPublicIdDataRequest.
    /// The response contains the Sh non-transparent data for the specified Public User Identity.
    /// The data also includes a userId, userType, and endpointType.
    /// 
    /// Replaced by: UserShInterfaceGetPublicIdDataResponse21sp1.
    /// <see cref="UserShInterfaceGetPublicIdDataRequest"/>
    /// <see cref="UserShInterfaceGetPublicIdDataResponse21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:18852""}]")]
    public class UserShInterfaceGetPublicIdDataResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18852")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.UserType _userType;

        [XmlElement(ElementName = "userType", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18852")]
        public BroadWorksConnector.Ocip.Models.UserType UserType
        {
            get => _userType;
            set
            {
                UserTypeSpecified = true;
                _userType = value;
            }
        }

        [XmlIgnore]
        protected bool UserTypeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EndpointType _endpointType;

        [XmlElement(ElementName = "endpointType", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18852")]
        public BroadWorksConnector.Ocip.Models.EndpointType EndpointType
        {
            get => _endpointType;
            set
            {
                EndpointTypeSpecified = true;
                _endpointType = value;
            }
        }

        [XmlIgnore]
        protected bool EndpointTypeSpecified { get; set; }

        protected string _sCSCFName;

        [XmlElement(ElementName = "SCSCFName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18852")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:18852")]
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
