using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserXsiPolicyProfileGetRequest.
    /// <see cref="UserXsiPolicyProfileGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:4184""}]")]
    public class UserXsiPolicyProfileGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _xsiPolicyProfile;

        [XmlElement(ElementName = "xsiPolicyProfile", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4184")]
        [MinLength(1)]
        [MaxLength(40)]
        public string XsiPolicyProfile
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
