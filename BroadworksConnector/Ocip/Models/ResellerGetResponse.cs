using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ResellerGetRequest.
    /// <see cref="ResellerGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b009175f2a2a9d38115e319a6ad64d7f:383""}]")]
    public class ResellerGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _resellerName;

        [XmlElement(ElementName = "resellerName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:383")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ResellerName
        {
            get => _resellerName;
            set
            {
                ResellerNameSpecified = true;
                _resellerName = value;
            }
        }

        [XmlIgnore]
        public bool ResellerNameSpecified { get; set; }

    }
}
