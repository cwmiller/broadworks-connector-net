using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Indicates whether or not the user's DN(s) should be un-assigned from the group and/or service provider.
    /// When set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group.
    /// When set to 'Service Provider', they will be un-assigned from the group and service provider.
    /// When omitted, the DN(s) will be left assigned to the group.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum UnassignPhoneNumbersLevel    {
            [XmlEnum(Name = "Group")]
        Group,
            [XmlEnum(Name = "Service Provider")]
        ServiceProvider,
     }
}
