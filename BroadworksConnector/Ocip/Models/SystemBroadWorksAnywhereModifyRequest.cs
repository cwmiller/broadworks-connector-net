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
    /// 
    /// The following elements are only used in AS data mode:
    /// enableTransferNotification
    /// 
    /// The following elements are only used in XS data mode:
    /// blockProvisioningOfDNAsBALocationEnabled
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f39163d0e42e05c4a1692a62f625df9f:254""}]")]
    public class SystemBroadWorksAnywhereModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _enableTransferNotification;

        [XmlElement(ElementName = "enableTransferNotification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f39163d0e42e05c4a1692a62f625df9f:254")]
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

        protected bool _blockProvisioningOfDNAsBALocation;

        [XmlElement(ElementName = "blockProvisioningOfDNAsBALocation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f39163d0e42e05c4a1692a62f625df9f:254")]
        public bool BlockProvisioningOfDNAsBALocation
        {
            get => _blockProvisioningOfDNAsBALocation;
            set
            {
                BlockProvisioningOfDNAsBALocationSpecified = true;
                _blockProvisioningOfDNAsBALocation = value;
            }
        }

        [XmlIgnore]
        protected bool BlockProvisioningOfDNAsBALocationSpecified { get; set; }

    }
}
