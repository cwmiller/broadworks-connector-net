using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// ShInterface User Id Data Entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:4544""}]")]
    public class ShInterfaceUserIdDataEntry
    {

        private BroadWorksConnector.Ocip.Models.UserType _userType;

        [XmlElement(ElementName = "userType", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4544")]
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

        private BroadWorksConnector.Ocip.Models.PublicUserIdentity _publicUserIdentity;

        [XmlElement(ElementName = "publicUserIdentity", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4544")]
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

        private BroadWorksConnector.Ocip.Models.EndpointType _endpointType;

        [XmlElement(ElementName = "endpointType", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4544")]
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

        private string _sCSCFName;

        [XmlElement(ElementName = "SCSCFName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4544")]
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

        private BroadWorksConnector.Ocip.Models.IMSUserState _iMSUserState;

        [XmlElement(ElementName = "IMSUserState", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4544")]
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
