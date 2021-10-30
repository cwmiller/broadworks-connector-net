using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Unassign a list of Xsi policy profile.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b009175f2a2a9d38115e319a6ad64d7f:1060""}]")]
    public class ResellerXsiPolicyProfileUnassignListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:1060")]
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

        private BroadWorksConnector.Ocip.Models.XsiPolicyProfileUnassignEntry _spXsiPolicyProfile;

        [XmlElement(ElementName = "spXsiPolicyProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:1060")]
        public BroadWorksConnector.Ocip.Models.XsiPolicyProfileUnassignEntry SpXsiPolicyProfile
        {
            get => _spXsiPolicyProfile;
            set
            {
                SpXsiPolicyProfileSpecified = true;
                _spXsiPolicyProfile = value;
            }
        }

        [XmlIgnore]
        protected bool SpXsiPolicyProfileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.XsiPolicyProfileUnassignEntry _groupXsiPolicyProfile;

        [XmlElement(ElementName = "groupXsiPolicyProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:1060")]
        public BroadWorksConnector.Ocip.Models.XsiPolicyProfileUnassignEntry GroupXsiPolicyProfile
        {
            get => _groupXsiPolicyProfile;
            set
            {
                GroupXsiPolicyProfileSpecified = true;
                _groupXsiPolicyProfile = value;
            }
        }

        [XmlIgnore]
        protected bool GroupXsiPolicyProfileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.XsiPolicyProfileUnassignEntry _userXsiPolicyProfile;

        [XmlElement(ElementName = "userXsiPolicyProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:1060")]
        public BroadWorksConnector.Ocip.Models.XsiPolicyProfileUnassignEntry UserXsiPolicyProfile
        {
            get => _userXsiPolicyProfile;
            set
            {
                UserXsiPolicyProfileSpecified = true;
                _userXsiPolicyProfile = value;
            }
        }

        [XmlIgnore]
        protected bool UserXsiPolicyProfileSpecified { get; set; }

    }
}
