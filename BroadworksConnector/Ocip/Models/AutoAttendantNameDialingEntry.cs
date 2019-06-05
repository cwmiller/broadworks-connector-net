using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AutoAttendantNameDialingEntry
    {
        [XmlEnum(Name = "LastName + FirstName")]
        LastNameFirstName,
        [XmlEnum(Name = "LastName + FirstName or FirstName + LastName")]
        LastNameFirstNameorFirstNameLastName,
    }
}
