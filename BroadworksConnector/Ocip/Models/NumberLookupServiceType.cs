using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Phone number lookup service type.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum NumberLookupServiceType    {
            [XmlEnum(Name = "BroadWorks Anywhere")]
        BroadWorksAnywhere,
     }
}
