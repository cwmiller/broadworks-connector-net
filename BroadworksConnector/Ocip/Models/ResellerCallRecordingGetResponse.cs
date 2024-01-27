using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ResellerCallRecordingGetRequest.
    /// The response contains the reseller’s Call Recording attribute.
    /// <see cref="ResellerCallRecordingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0731150ec7515df8cd710f04d8f62f66:177""}]")]
    public class ResellerCallRecordingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _fQDN;

        [XmlElement(ElementName = "FQDN", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0731150ec7515df8cd710f04d8f62f66:177")]
        [MinLength(1)]
        [MaxLength(80)]
        public string FQDN
        {
            get => _fQDN;
            set
            {
                FQDNSpecified = true;
                _fQDN = value;
            }
        }

        [XmlIgnore]
        protected bool FQDNSpecified { get; set; }

    }
}
