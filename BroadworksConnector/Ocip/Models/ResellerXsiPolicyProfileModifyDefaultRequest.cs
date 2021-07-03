using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the default Xsi policy profile for a reseller.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b009175f2a2a9d38115e319a6ad64d7f:1041""}]")]
    public class ResellerXsiPolicyProfileModifyDefaultRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:1041")]
        [MinLength(1)]
        [MaxLength(36)]
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
        protected bool ResellerIdSpecified { get; set; }

        private string _spDefaultXsiPolicyProfile;

        [XmlElement(ElementName = "spDefaultXsiPolicyProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:1041")]
        [MinLength(1)]
        [MaxLength(40)]
        public string SpDefaultXsiPolicyProfile
        {
            get => _spDefaultXsiPolicyProfile;
            set
            {
                SpDefaultXsiPolicyProfileSpecified = true;
                _spDefaultXsiPolicyProfile = value;
            }
        }

        [XmlIgnore]
        protected bool SpDefaultXsiPolicyProfileSpecified { get; set; }

        private string _groupDefaultXsiPolicyProfile;

        [XmlElement(ElementName = "groupDefaultXsiPolicyProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:1041")]
        [MinLength(1)]
        [MaxLength(40)]
        public string GroupDefaultXsiPolicyProfile
        {
            get => _groupDefaultXsiPolicyProfile;
            set
            {
                GroupDefaultXsiPolicyProfileSpecified = true;
                _groupDefaultXsiPolicyProfile = value;
            }
        }

        [XmlIgnore]
        protected bool GroupDefaultXsiPolicyProfileSpecified { get; set; }

        private string _userDefaultXsiPolicyProfile;

        [XmlElement(ElementName = "userDefaultXsiPolicyProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:1041")]
        [MinLength(1)]
        [MaxLength(40)]
        public string UserDefaultXsiPolicyProfile
        {
            get => _userDefaultXsiPolicyProfile;
            set
            {
                UserDefaultXsiPolicyProfileSpecified = true;
                _userDefaultXsiPolicyProfile = value;
            }
        }

        [XmlIgnore]
        protected bool UserDefaultXsiPolicyProfileSpecified { get; set; }

    }
}
