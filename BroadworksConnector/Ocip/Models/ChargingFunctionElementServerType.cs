using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// ChargingFunctionElement Server types.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ChargingFunctionElementServerType    {
            [XmlEnum(Name = "CCF")]
        CCF,
            [XmlEnum(Name = "ECF")]
        ECF,
     }
}
