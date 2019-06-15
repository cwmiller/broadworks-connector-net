using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Permission choices for Pinhole digit patterns on originating calls.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum OutgoingPinholeDigitPlanOriginatingPermission    {
            [XmlEnum(Name = "Ignore")]
        Ignore,
            [XmlEnum(Name = "Allow")]
        Allow,
            [XmlEnum(Name = "Authorization Code Required")]
        AuthorizationCodeRequired,
            [XmlEnum(Name = "Transfer To First Transfer Number")]
        TransferToFirstTransferNumber,
            [XmlEnum(Name = "Transfer To Second Transfer Number")]
        TransferToSecondTransferNumber,
            [XmlEnum(Name = "Transfer To Third Transfer Number")]
        TransferToThirdTransferNumber,
     }
}
