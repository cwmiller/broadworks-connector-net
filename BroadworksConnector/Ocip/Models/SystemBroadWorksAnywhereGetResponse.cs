using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The response to a SystemBroadWorksAnywhereGetRequest.
    /// <see cref="SystemBroadWorksAnywhereGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""72f634ecc58842ce9d362ca629a47ea9:232""}]")]
    public class SystemBroadWorksAnywhereGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableTransferNotification;

        [XmlElement(ElementName = "enableTransferNotification", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:232")]
        public bool EnableTransferNotification
        {
            get => _enableTransferNotification;
            set
            {
                EnableTransferNotificationSpecified = true;
                _enableTransferNotification = value;
            }
        }

        [XmlIgnore]
        protected bool EnableTransferNotificationSpecified { get; set; }

    }
}
