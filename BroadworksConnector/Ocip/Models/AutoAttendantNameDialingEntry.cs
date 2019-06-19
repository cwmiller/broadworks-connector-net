using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The format callers should use when dialing by name.
    /// </summary>
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
