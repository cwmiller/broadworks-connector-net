using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ResellerEmergencyCallNotificationGetRequest.
    /// <see cref="ResellerEmergencyCallNotificationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b009175f2a2a9d38115e319a6ad64d7f:514""}]")]
    public class ResellerEmergencyCallNotificationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _defaultFromAddress;

        [XmlElement(ElementName = "defaultFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:514")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultFromAddress
        {
            get => _defaultFromAddress;
            set
            {
                DefaultFromAddressSpecified = true;
                _defaultFromAddress = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultFromAddressSpecified { get; set; }

    }
}
