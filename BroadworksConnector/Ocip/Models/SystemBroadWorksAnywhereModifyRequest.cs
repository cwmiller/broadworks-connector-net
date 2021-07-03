using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the BroadWorks Anywhere system parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""72f634ecc58842ce9d362ca629a47ea9:248""}]")]
    public class SystemBroadWorksAnywhereModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _enableTransferNotification;

        [XmlElement(ElementName = "enableTransferNotification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:248")]
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
