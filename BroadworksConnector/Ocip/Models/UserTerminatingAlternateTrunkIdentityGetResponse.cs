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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3991""}]")]
    public class UserTerminatingAlternateTrunkIdentityGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _terminatingTrunkIdentity;

        [XmlElement(ElementName = "terminatingTrunkIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3991")]
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
        public bool TerminatingTrunkIdentitySpecified { get; set; }

    }
}
