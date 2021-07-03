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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9741e074fbfeb4c7312bfa4dfbaee3d3:175""}]")]
    public class ResellerCallRecordingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _fQDN;

        [XmlElement(ElementName = "FQDN", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:175")]
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
