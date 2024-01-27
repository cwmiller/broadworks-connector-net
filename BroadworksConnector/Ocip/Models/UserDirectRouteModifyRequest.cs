using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the direct route setting and the list of DTGs/Trunk Identities assigned to a user.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""448c1807ef39a1a06e7d8d4d16ecaa31:75""}]")]
    public class UserDirectRouteModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"448c1807ef39a1a06e7d8d4d16ecaa31:75")]
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

        protected BroadWorksConnector.Ocip.Models.DirectRouteOutgoingDTGPolicy _outgoingDTGPolicy;

        [XmlElement(ElementName = "outgoingDTGPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"448c1807ef39a1a06e7d8d4d16ecaa31:75")]
        public BroadWorksConnector.Ocip.Models.DirectRouteOutgoingDTGPolicy OutgoingDTGPolicy
        {
            get => _outgoingDTGPolicy;
            set
            {
                OutgoingDTGPolicySpecified = true;
                _outgoingDTGPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool OutgoingDTGPolicySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DirectRouteOutgoingTrunkIdentityPolicy _outgoingTrunkIdentityPolicy;

        [XmlElement(ElementName = "outgoingTrunkIdentityPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"448c1807ef39a1a06e7d8d4d16ecaa31:75")]
        public BroadWorksConnector.Ocip.Models.DirectRouteOutgoingTrunkIdentityPolicy OutgoingTrunkIdentityPolicy
        {
            get => _outgoingTrunkIdentityPolicy;
            set
            {
                OutgoingTrunkIdentityPolicySpecified = true;
                _outgoingTrunkIdentityPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool OutgoingTrunkIdentityPolicySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DirectRouteReplacementIdentityList _directRouteIdentityList;

        [XmlElement(ElementName = "directRouteIdentityList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"448c1807ef39a1a06e7d8d4d16ecaa31:75")]
        public BroadWorksConnector.Ocip.Models.DirectRouteReplacementIdentityList DirectRouteIdentityList
        {
            get => _directRouteIdentityList;
            set
            {
                DirectRouteIdentityListSpecified = true;
                _directRouteIdentityList = value;
            }
        }

        [XmlIgnore]
        protected bool DirectRouteIdentityListSpecified { get; set; }

    }
}
