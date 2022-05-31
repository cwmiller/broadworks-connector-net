using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupTrunkGroupSecurityClassificationGetRequest.
    /// <see cref="GroupTrunkGroupSecurityClassificationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b3afea8308b7fdaab8d385357ca9c2d:69""}]")]
    public class GroupTrunkGroupSecurityClassificationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _defaultSecurityClassification;

        [XmlElement(ElementName = "defaultSecurityClassification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b3afea8308b7fdaab8d385357ca9c2d:69")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DefaultSecurityClassification
        {
            get => _defaultSecurityClassification;
            set
            {
                DefaultSecurityClassificationSpecified = true;
                _defaultSecurityClassification = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultSecurityClassificationSpecified { get; set; }

    }
}
