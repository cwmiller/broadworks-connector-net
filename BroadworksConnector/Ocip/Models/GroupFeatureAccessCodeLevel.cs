using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Feature Access Code Level defining group policy how Feature Access Codes will be used by a group.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupFeatureAccessCodeLevel    {
            [XmlEnum(Name = "Service Provider")]
        ServiceProvider,
            [XmlEnum(Name = "Group")]
        Group,
     }
}
