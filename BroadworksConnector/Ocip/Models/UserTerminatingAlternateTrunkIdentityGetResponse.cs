using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserTerminatingAlternateTrunkIdentityGetRequest.
    /// <see cref="UserTerminatingAlternateTrunkIdentityGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:4086""}]")]
    public class UserTerminatingAlternateTrunkIdentityGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _terminatingTrunkIdentity;

        [XmlElement(ElementName = "terminatingTrunkIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4086")]
        [MinLength(1)]
        [MaxLength(80)]
        public string TerminatingTrunkIdentity
        {
            get => _terminatingTrunkIdentity;
            set
            {
                TerminatingTrunkIdentitySpecified = true;
                _terminatingTrunkIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool TerminatingTrunkIdentitySpecified { get; set; }

    }
}
