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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f39163d0e42e05c4a1692a62f625df9f:232""}]")]
    public class SystemBroadWorksAnywhereGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableTransferNotification;

        [XmlElement(ElementName = "enableTransferNotification", IsNullable = false, Namespace = "")]
        [Group(@"f39163d0e42e05c4a1692a62f625df9f:232")]
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
