using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get an existing Xsi policy profile.
    /// The response is either a SystemXsiPolicyProfileGetResponse
    /// or an ErrorResponse.
    /// <see cref="SystemXsiPolicyProfileGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:19541""}]")]
    public class SystemXsiPolicyProfileGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemXsiPolicyProfileGetResponse>
    {

        private BroadWorksConnector.Ocip.Models.XsiPolicyProfileKey _xsiPolicyProfile;

        [XmlElement(ElementName = "xsiPolicyProfile", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19541")]
        public BroadWorksConnector.Ocip.Models.XsiPolicyProfileKey XsiPolicyProfile
        {
            get => _xsiPolicyProfile;
            set
            {
                XsiPolicyProfileSpecified = true;
                _xsiPolicyProfile = value;
            }
        }

        [XmlIgnore]
        protected bool XsiPolicyProfileSpecified { get; set; }

    }
}
